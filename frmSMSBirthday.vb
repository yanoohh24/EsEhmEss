Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop
Imports System.Threading

Public Class frmSMSBirthday
    Dim pxID As String
    Dim pxGender As String
    Dim pxName As String
    Dim pxMobile As String
    Dim pxBranch As String

    Private Sub ListViewPatientsContactSetting()
        lstPatientsBirthday.Columns.Clear()
        lstPatientsBirthday.Columns.Add("PID", 0)
        lstPatientsBirthday.Columns.Add("Gender", 55)
        lstPatientsBirthday.Columns.Add("Patient Name", 200)
        lstPatientsBirthday.Columns.Add("Mobile", 100)
        lstPatientsBirthday.Columns.Add("Birthday", 100)
        lstPatientsBirthday.Columns.Add("Branch name", 100)
        lstPatientsBirthday.Columns.Add("Branch code", 80)
        lstPatientsBirthday.Items.Clear()
    End Sub
    Private Sub frmSMSBirthday_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListViewPatientsContactSetting()
        txtBirthday.Text = ""
        txtMobile.Text = ""
        PercentToolStrip.Text = ""
        ToolStripStatusCount.Text = lstPatientsBirthday.Items.Count
    End Sub
    Public Sub RetriveSMS()
        ListViewPatientsContactSetting()
        Try
            Dim query As String
            Dim MonthFrm As Integer = Format(dpFrom.Value, "MM")
            Dim DayFirst As Integer = Format(dpFrom.Value, "dd")


            query = "SELECT PatientID,patientid,gender px_gender,CONCAT(firstname,' ',lastname) px_name,mobile px_mobile,birthday, " _
            & " (SELECT NAME FROM `ref_branch` WHERE CODE=clinic_name) Branch_name,clinic_name FROM patient_info WHERE MONTH(birthday)=" & Format(dpFrom.Value, "MM") & " AND DAY(birthday)=" & DayFirst & " " _
            & " AND LENGTH(patientid)>1 ORDER BY DAY(birthday),MONTH(birthday) ASC"

            Dim connection As New MySqlConnection(connStrBMG)
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader

            connection.Open()
            reader = cmd.ExecuteReader()
            If reader.HasRows = True Then
                While reader.Read
                    Dim ls As New ListViewItem(reader.Item("PatientID").ToString.Trim())
                    ls.SubItems.Add(StrConv(reader.Item("px_gender").ToString.Trim(), VbStrConv.Uppercase))
                    ls.SubItems.Add(reader.Item("px_name").ToString.Trim())
                    ls.SubItems.Add(Replace(Replace(Replace(reader.Item("px_mobile").ToString.Trim(), " ", ""), ".", ""), "-", ""))
                    ls.SubItems.Add(Format(reader.Item("birthday"), "MMM dd, yyyy"))
                    ls.SubItems.Add(reader.Item("Branch_name").ToString.Trim())
                    ls.SubItems.Add(reader.Item("clinic_name").ToString.Trim())
                    lstPatientsBirthday.Items.Add(ls)
                End While
            End If
            connection.Close()
            ToolStripStatusCount.Text = lstPatientsBirthday.Items.Count
        Catch ex As Exception
            MsgBox(ex.Message & "::RetriveSMS")
        End Try
    End Sub

    Private Sub btView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btView.Click
        RetriveSMS()
    End Sub

    Private Sub btSendToAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSendToAll.Click

        If MsgBox("Send Birthday Full blast SMS to all patients?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.No Then
            Exit Sub
        End If

        For Each item As ListViewItem In lstPatientsBirthday.Items
            Dim pxID As String = item.Text.Trim
            Dim pxGender As String = item.SubItems(1).Text.Trim
            Dim pxName As String = item.SubItems(2).Text.Trim
            Dim pxMobile As String = item.SubItems(3).Text.Trim
            Dim pxBranch As String = item.SubItems(5).Text.Trim
            Dim pxBranchCode As String = item.SubItems(6).Text.Trim

            pxName = PX_MrMs(pxGender) & pxName

            If Len(pxName) > 1 Then
                pxName = pxName & "!"
            End If

            px_mobile(pxMobile)
            If Mid(txtMobile.Text, 1, 4) = "+639" or Mid(txtMobile.Text,1,3) = "639" Then

                txtBirthday.Text = "A Belo Beautiful Birthday to you " & pxName & vbNewLine & "Belo " & pxBranch & " would like to extend a warm birthday greeting on this special day! " & vbNewLine _
                & "We would be delighted to see you back at the clinic you may call (8192356) for your next appointment. See you soon! " & vbNewLine & vbNewLine _
                & "To send us a message, type BD <space> (message) " & vbNewLine & vbNewLine _
                & "For other inquiries, you may call 819-BELO (2356) or visit us at www.belomed.com " & vbNewLine & vbNewLine _
                & "To unsubscribe reply OFF"

                messages_sms_out(txtBirthday.Text, pxID, pxBranchCode, txtMobile.Text.Trim)                     'Belo_Database (Messages_SMS)
                CommandXpertSMS_Birthday(txtBirthday.Text, 0, pxID, pxBranchCode, txtMobile.Text.Trim)          'Messages ( Database : Messages )
            End If

        Next

        Me.Dispose()
        MsgBox("Birthday Full Blast successfully send to all patients", MsgBoxStyle.Information, "Birthday Full Blast SMS")

    End Sub
    Function messages_sms_out(ByVal sms_body As String, ByVal px_id As String, ByVal px_branch As String, ByVal sms_sender As String) As Integer
        Try
            Dim sql As String = ""
            Dim _DeptKey As String = FFMain.KeyToolStrip.Text.Trim
            Dim MBchk As String = sms_sender
            MBchk = Mid(MBchk, 1, 4)

            sms_body = Replace(sms_body, "'", "\'")

            If MBchk = "+639" Then
                sql = "INSERT INTO `messages_sms` SET Direction=2, sender='" & sms_sender & "',body='" & sms_body & "',branch='" & _DeptKey & "', PatientID='" & px_id & "',Read_Stats='1', " _
                    & " DeptKey='" & _DeptKey & "', Username='" & ClientUsername & "', UserHostName='" & ClientHostName & "',UserHostIP='" & ClientHostIP & "', user_access_group='" & ClientUserAccessGroup & "'"

                Dim rowsEffected As Integer = 0
                Dim connection As New MySqlConnection(connStrBMG)
                Dim cmd As New MySqlCommand(sql, connection)

                connection.Open()
                rowsEffected = cmd.ExecuteNonQuery()
                connection.Close()
                Return rowsEffected
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Function px_mobile(ByVal mobile As String) As String

        Dim StrMobile As String

        mobile = Replace(Replace(mobile.Trim, " ", ""), "-", "")
        If Len(mobile) < 1 Then
            txtMobile.Text = ""
            Exit Function
        End If

        Select Case Mid(mobile.Trim, 1, 2)
            Case "09"
                If Len(mobile.Trim) >= 11 Then
                    StrMobile = Mid(mobile.Trim, 2, 10)
                    txtMobile.Text = "+63" & StrMobile
                    txtMobile.ForeColor = Color.Black
                Else
                    txtMobile.Text = ""
                    txtMobile.ForeColor = Color.Red
                End If
            Case "63"
                If Len(mobile.Trim) >= 12 Then
                    StrMobile = Mid(mobile.Trim, 1, 12)
                    txtMobile.Text = "+" & StrMobile
                    txtMobile.ForeColor = Color.Black
                Else
                    txtMobile.Text = ""
                    txtMobile.ForeColor = Color.Red
                End If
            Case Else
                Select Case Mid(mobile.Trim, 1, 3)
                    Case "+63"
                        If Len(mobile.Trim) >= 13 Then
                            StrMobile = Mid(mobile.Trim, 1, 13)
                            txtMobile.Text = StrMobile
                            txtMobile.ForeColor = Color.Black
                        Else
                            txtMobile.Text = ""
                            txtMobile.ForeColor = Color.Red
                        End If
                    Case Else
                        Select Case Mid(mobile.Trim, 1, 1)
                            Case "9"
                                If Len(mobile.Trim) >= 9 Then
                                    StrMobile = Mid(mobile.Trim, 1, 10)
                                    txtMobile.Text = "+63" & StrMobile
                                    txtMobile.ForeColor = Color.Black
                                Else
                                    txtMobile.Text = ""
                                    txtMobile.ForeColor = Color.Red
                                End If
                            Case Else
                                txtMobile.Text = ""
                                txtMobile.ForeColor = Color.Red
                        End Select
                End Select
        End Select
    End Function
#Region "Export to Excel"
    Private Sub ExportToExcel()
        Dim xls As New Excel.Application
        Dim book As Excel.Workbook
        Dim sheet As Excel.Worksheet

        If lstPatientsBirthday.Items.Count < 1 Then
            Exit Sub
        End If

        'create a workbook and get reference to first worksheet
        xls.Workbooks.Add()
        book = xls.ActiveWorkbook
        sheet = book.ActiveSheet

        With sheet
            ' SHOW AN HEADER.
            .Cells(1, 2) = "Belo Medical Group" : .Cells(1, 2).FONT.NAME = "Calibri"
            .Cells(1, 2).Font.Bold = True : .Cells(1, 2).Font.Size = 20
            .Cells(1, 2).Font.color = Color.Goldenrod

            .Cells(2, 2) = "Patients Birthday List of " & Format(dpFrom.Value, "MMMM dd.") : .Cells(2, 2).FONT.NAME = "Calibri"
            .Cells(2, 2).Font.Bold = True : .Cells(1, 2).Font.Size = 14
            .Cells(2, 2).Font.color = Color.Goldenrod

            .Range("B1:F1").MergeCells = True
            .Range("B2:F2").MergeCells = True
        End With

        'Get columns Headers
        For i As Integer = 0 To lstPatientsBirthday.Columns.Count - 1
            sheet.Cells(4, i + 1) = lstPatientsBirthday.Columns(i).Text
            sheet.Cells(4, i + 1).Font.Bold = True
        Next

        'step through rows and columns and copy data to worksheet
        Dim row As Integer = 1
        Dim col As Integer = 1

        pbExtract.Value = 0
        pbExtract.Maximum = lstPatientsBirthday.Items.Count

        For i As Integer = 0 To lstPatientsBirthday.Columns.Count - 1
            With sheet
                .Cells.NumberFormat = "@"
            End With
        Next

        For Each item As ListViewItem In lstPatientsBirthday.Items
            For i As Integer = 0 To item.SubItems.Count - 1
                sheet.Cells.NumberFormat = "@"
                sheet.Cells(row + 4, col) = item.SubItems(i).Text
                col = col + 1
            Next
            row += 1
            col = 1
            pbExtract.Value += 1
            PercentToolStrip.Text = Convert.ToInt32((pbExtract.Value / lstPatientsBirthday.Items.Count) * 100) & "% " & pbExtract.Value
        Next

        For i As Integer = 0 To lstPatientsBirthday.Columns.Count - 1
            With sheet
                .Columns(i + 1).AutoFit()
                .Columns.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            End With
        Next

        'For i As Integer = 0 To lstPatientsContact.Columns.Count - 1
        'sheet.Columns(i + 1).AutoFit()
        'Next

        'save the workbook and clean up
        xls.Visible = True
        'book.SaveAs("c:\sssss")
        'xls.Workbooks.Close()
        'xls.Quit()
        releaseObject(sheet)
        releaseObject(book)
        releaseObject(xls)
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        'Release an automation object
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

#End Region

    Private Sub ExcelToolStrip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcelToolStrip.Click
        On Error Resume Next

        btView.Enabled = False
        btSendToAll.Enabled = False
        ExcelToolStrip.Enabled = False

        ExportToExcel()

        btView.Enabled = True
        btSendToAll.Enabled = True
        ExcelToolStrip.Enabled = True
    End Sub

    Private Sub lstPatientsBirthday_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstPatientsBirthday.Click

        If lstPatientsBirthday.Items.Count > 0 Then
            pxID = lstPatientsBirthday.SelectedItems(0).Text.Trim()
            pxGender = lstPatientsBirthday.SelectedItems(0).SubItems(1).Text.Trim()
            pxName = lstPatientsBirthday.SelectedItems(0).SubItems(2).Text.Trim()
            pxMobile = lstPatientsBirthday.SelectedItems(0).SubItems(3).Text.Trim()
            pxBranch = lstPatientsBirthday.SelectedItems(0).SubItems(5).Text.Trim()

            pxName = PX_MrMs(pxGender) & pxName

            If Len(pxName) > 1 Then
                pxName = pxName & "!"
            End If

            px_mobile(pxMobile)

            'txtMobile.Text = pxMobile
            txtBirthday.Text = "A Belo Beautiful Birthday to you " & pxName & vbNewLine & "Belo " & pxBranch & " would like to extend a warm birthday greeting on this special day! " & vbNewLine _
            & "We would be delighted to see you back at the clinic you may call (8192356) for your next appointment. See you soon! " & vbNewLine & vbNewLine _
            & "For other inquiries, you may call 819-BELO (2356) or visit us at www.belomed.com " & vbNewLine & vbNewLine _
            & "To unsubscribe reply OFF"
        End If

    End Sub

    Private Sub lstPatientsBirthday_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstPatientsBirthday.MouseClick

        If e.Button = Windows.Forms.MouseButtons.Right Then
            If lstPatientsBirthday.Items.Count > 0 Then
                If Len(txtMobile.Text) < 10 Then
                    MsgBox("Unable to Send Belo Birthday Greetings. Please enter Patient mobile number.", MsgBoxStyle.Exclamation, "Invalid mobile number")
                    Exit Sub
                End If
                ContextMessageInbox.Show(lstPatientsBirthday, e.Location)
            End If
        End If
    End Sub

    Private Sub SendBBGToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendBBGToolStripMenuItem.Click
        Try
            FFResend.Show()
            FFResend.BringToFront()

            FFResend.txtMobile.Text = txtMobile.Text
            FFResend.pxToolStrip.Visible = True
            FFResend.pxToolStrip.Text = pxName
            FFResend.pxIDToolStrip.Text = pxID
            FFResend.txtMobile.Focus()
            FFResend.txtMobile.Enabled = True
            FFResend.txtMessage.Text = txtBirthday.Text
            FFResend.txtMessage.SelectionStart = Len(txtBirthday.Text)
            FFResend.TxtLenghtToolStrip.Text = Len(txtBirthday.Text)
            FFResend.lbUsernameAndBranchname.Text = UserAndBranchName
            FFResend.txtMessage.ReadOnly = True
            FFResend.txtMessage.Focus()

        Catch ex As Exception
            FFResend = New frmSMSResend()
            Thread.Sleep(100)
            FFResend.txtMobile.Text = txtMobile.Text
            FFResend.pxToolStrip.Text = pxName
            FFResend.pxIDToolStrip.Text = pxID
            FFResend.txtMobile.Focus()
            FFResend.txtMessage.Text = txtBirthday.Text
            FFResend.txtMessage.SelectionStart = Len(txtBirthday.Text)
            FFResend.TxtLenghtToolStrip.Text = "Lenght : " & Len(txtBirthday.Text)
            FFResend.lbUsernameAndBranchname.Text = UserAndBranchName
            Thread.Sleep(100)
            FFResend.Show()
            FFResend.BringToFront()
        End Try
    End Sub

    Private Sub lstPatientsBirthday_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstPatientsBirthday.SelectedIndexChanged

    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class