Imports MySql.Data.MySqlClient

Public Class frmSMSNew
    Dim InvdEnterMobile As String = "Please enter mobile number"
    Dim InvdMobile As String = "Invalid mobile number"
    Dim _Cid As String
    Dim _Ctemplate As String
    Dim _BeloHelpdesk As String = "-Belo Helpdesk" & vbNewLine & vbNewLine &
                                    "To unsubscribe reply OFF"

    Private Sub HeaderTemplate()
        lsTemplate.Columns.Clear()
        lsTemplate.Columns.Add("NO", 40)
        lsTemplate.Columns.Add("id", 0)
        lsTemplate.Columns.Add("Message", 450)
        lsTemplate.Columns.Add("Created by", 100)
    End Sub
    Private Sub frmComposeSMS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        HeaderTemplate()
        Retrive_SMS_TEMPLATE()

        If ClientDepartmentKey = "HD" Then
            chHelpdesk.Visible = True
        Else
            chHelpdesk.Visible = False
        End If

        If ClientDepartmentKey = "HR" Then
            chHR.Visible = True
        Else
            chHR.Visible = False
        End If

        txtMobile.Text = ""
        txtMessage.Text = ""
        txtInvalidMobile.Text = ""
        lbInvalid.Text = ""
        USAndBranchnameToolStripStatus.Text = UserAndBranchName
        TxtLenghtToolStrip.Text = Len(txtMessage.Text)
    End Sub

    Private Sub txtMessage_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMessage.KeyUp
        If e.KeyCode = Keys.F5 Then
            SendToolStrip_Click(Me, EventArgs.Empty)
        End If
        TxtLenghtToolStrip.Text = Len(txtMessage.Text)
    End Sub

    Private Sub txtMobile_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMobile.GotFocus
        txtMobile.Text = Replace(Replace(txtMobile.Text.Trim, " ", ""), "'", "")
        txtMobile.SelectionStart = Len(txtMobile.Text)
    End Sub


    Private Sub txtMessage_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtMessage.MouseUp
        
        TxtLenghtToolStrip.Text = Len(txtMessage.Text)
    End Sub

    Private Sub SendToolStrip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendToolStrip.Click
        Dim str() As String
        Dim txt_mobile As String = txtMobile.Text.Trim
        Dim SMSMsg As String = txtMessage.Text.Trim & vbNewLine & vbNewLine & FooterSMS

        If chHelpdesk.Checked = True Then
            SMSMsg = txtMessage.Text.Trim & vbNewLine & vbNewLine & _BeloHelpdesk
        End If

        If chHR.Checked = True Then
            Dim StrFistFooter = Department_First_Footer("HRT")
            SMSMsg = txtMessage.Text.Trim & vbNewLine & vbNewLine & StrFistFooter & UserAndBranchName & vbNewLine & vbNewLine & Department_End_Footer
        End If

        If Len(txt_mobile) < 1 Then
            txtMobile.Focus()
            MsgBox("Please enter mobile number", MsgBoxStyle.Information, "Enter mobile number")
            Exit Sub
        End If

        str = txt_mobile.Trim.Split(";")

        Dim msgSent As String = ""
        Dim sentOnQue As Integer = 0
        For i As Integer = 0 To str.Length - 1
            Dim _mobile As String = MobileNumberCheck(str(i))
            If Len(_mobile) = 13 Then
                Dim _pxID As String = PatientID_Mobile(Mid(_mobile, 4, 10))

                'sms_body,Branch_code, px_id, sms_sender, Username, UserHostName, UserHostIP
                messages_sms_out(SMSMsg, _pxID, _mobile)
                CommandXpertSMS(SMSMsg, 0, _pxID, _mobile)
                msgSent = msgSent & _mobile & vbNewLine
                sentOnQue += 1
            End If
        Next

        If sentOnQue > 0 Then
            txtMessage.Text = ""
            MsgBox("Message successfully sent on que for sending:" & vbNewLine & msgSent, MsgBoxStyle.Information, "Successfully Sent on que")
        End If

        txtMobile.Text = ""

    End Sub
    Function messages_sms_out(ByVal sms_body As String, ByVal px_id As String, ByVal sms_sender As String) As Integer
        Try

            Dim sql As String = ""
            Dim _DeptKey As String = FFMain.KeyToolStrip.Text.Trim
            Dim MBchk As String = sms_sender
            MBchk = Mid(MBchk, 1, 4)

            sms_body = Replace(sms_body, "'", "\'")

            If MBchk = "+639" Then
                sql = "INSERT INTO `messages_sms` SET Direction=2, sender='" & sms_sender & "',body='" & sms_body & "',branch='" & _DeptKey & "', PatientID='" & px_id & "',Username='" & ClientUsername & "', " _
                    & " UserHostName='" & ClientHostName & "',UserHostIP='" & ClientHostIP & "', Read_Stats='1',DeptKey='" & _DeptKey & "', user_access_group='" & ClientUserAccessGroup & "'"

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
    Private Sub ExitToolStrip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStrip.Click
        Me.Dispose()
    End Sub

    Private Sub MobileNumberValiDate()
        Dim StrMobile As String

        txtMobile.Text = Replace(txtMobile.Text.Trim, " ", "")

        Select Case Mid(txtMobile.Text, 1, 2)
            Case "09"
                If Len(txtMobile.Text.Trim) = 11 Then
                    StrMobile = Mid(txtMobile.Text.Trim, 2, 10)
                    txtMobile.Text = "+63" & StrMobile
                    txtMobile.ForeColor = Color.Black
                    lbInvalid.Text = ""
                Else
                    lbInvalid.Text = InvdMobile
                    txtMobile.ForeColor = Color.Red
                End If
            Case "63"
                If Len(txtMobile.Text.Trim) = 12 Then
                    StrMobile = Mid(txtMobile.Text.Trim, 1, 12)
                    txtMobile.Text = "+" & StrMobile
                    txtMobile.ForeColor = Color.Black
                    lbInvalid.Text = ""
                Else
                    lbInvalid.Text = InvdMobile
                    txtMobile.ForeColor = Color.Red
                End If

            Case Else
                Select Case Mid(txtMobile.Text.Trim, 1, 3)
                    Case "+63"
                        If Len(txtMobile.Text.Trim) = 13 Then
                            StrMobile = Mid(txtMobile.Text.Trim, 1, 13)
                            txtMobile.Text = StrMobile
                            txtMobile.ForeColor = Color.Black
                            lbInvalid.Text = ""
                        Else
                            lbInvalid.Text = InvdMobile
                            txtMobile.ForeColor = Color.Red
                        End If
                    Case Else
                        lbInvalid.Text = InvdMobile
                        txtMobile.ForeColor = Color.Red
                End Select
        End Select

        txtMobile.Text = txtMobile.Text.Trim

        If Len(txtMobile.Text.Trim) < 1 Then
            lbInvalid.Text = InvdEnterMobile
        ElseIf Len(txtMobile.Text) > 13 Then
            lbInvalid.Text = InvdMobile
        End If

    End Sub

    Function MobileNumberCheck(ByVal mobile_no As String) As String
        Dim StrMobile As String
        Dim replaceNo As String = mobile_no
        mobile_no = Replace(mobile_no, " ", "")

        If Len(mobile_no) < 1 Then
            Exit Function
        End If

        If Len(mobile_no) <= 10 Or Len(mobile_no) > 13 Then
            lbInvalid.Text = "Invalid mobile number"
            txtInvalidMobile.Text = txtInvalidMobile.Text & mobile_no & vbNewLine
            MobileNumberCheck = ""
            Exit Function
        End If

        Select Case Mid(mobile_no, 1, 2)
            Case "09"
                If Len(mobile_no.Trim) = 11 Then
                    StrMobile = Mid(mobile_no, 2, 10)
                    MobileNumberCheck = "+63" & StrMobile
                End If
            Case "63"
                If Len(mobile_no.Trim) = 12 Then
                    StrMobile = Mid(mobile_no, 1, 12)
                    MobileNumberCheck = "+" & StrMobile
                End If
            Case Else

                Select Case Mid(mobile_no.Trim, 1, 3)
                    Case "+63"
                        If Len(mobile_no.Trim) = 13 Then
                            StrMobile = Mid(mobile_no, 1, 13)
                            MobileNumberCheck = StrMobile
                        End If
                    Case Else
                        MobileNumberCheck = mobile_no
                End Select
        End Select

    End Function
    Function PatientID_Mobile(ByVal mobile_no As String) As String
        mobile_no = Replace(mobile_no.Trim, "'", "\'")
        If Len(mobile_no) < 10 Then
            Exit Function
        End If

        Dim sql As String = "SELECT PatientID FROM  `patient_info` WHERE REPLACE(REPLACE(REPLACE(mobile,' ',''),'-',''),'.','') LIKE '%" & mobile_no & "%'"
        Try
            Dim connection As New MySqlConnection(connStrBMG)
            Dim cmd As New MySqlCommand(sql, connection)
            Dim reader As MySqlDataReader
            connection.Open()
            reader = cmd.ExecuteReader()
            'this will clear the listbox
            If reader.HasRows = True Then
                While reader.Read
                    PatientID_Mobile = reader.Item("PatientID").ToString.Trim()
                End While
            Else
                PatientID_Mobile = ""
            End If
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & "::PatientID_Mobile")
        End Try

    End Function
    Private Sub Button1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        txtMobile.Text = Replace(Replace(txtMobile.Text.Trim, " ", ""), "'", "")
    End Sub

    Private Sub Button1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        txtMobile.Text = Replace(Replace(txtMobile.Text.Trim, " ", ""), "'", "")
    End Sub

    Private Sub btClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btClear.Click
        txtInvalidMobile.Text = ""
    End Sub

    Private Sub txtMobile_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMobile.LostFocus
        txtMobile.Text = Replace(Replace(txtMobile.Text.Trim, " ", ""), "'", "")
    End Sub

    Private Sub frmSMSNew_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        FFMain.AsDeptFooters()
    End Sub

    Function SaveTemplate(ByVal query As String) As Integer
        Try
            Dim rowsEffected As Integer = 0
            Dim connection As New MySqlConnection(connStrBMG)
            Dim cmd As New MySqlCommand(query, connection)

            connection.Open()

            rowsEffected = cmd.ExecuteNonQuery()
            SaveTemplate = rowsEffected
            connection.Close()

            Return rowsEffected
        Catch ex As Exception
            MsgBox(ex.Message)
            Console.WriteLine(ex.Message)
        End Try

    End Function

    Private Sub SaveToolStrip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStrip.Click
        Dim sql As String
        Dim _template As String = Replace(txtMessage.Text.Trim, "'", "\'")

        HeaderTemplate()

        If Len(_template) < 1 Then
            txtMessage.Focus()
            MsgBox("Please enter message to save template", MsgBoxStyle.Information)
            Exit Sub
        End If

        If MsgBox("Save this message as template?", vbYesNo, "Template") = vbNo Then
            txtMessage.Focus()
            Exit Sub
        End If

        sql = "INSERT sms_template SET template='" & _template & "',created_by='" & ClientUsername & "',department_key='" & ClientDepartmentKey & "',user_access_group='" & ClientUserAccessGroup & "'"
        If SaveTemplate(sql) > 0 Then
            txtMessage.Text = ""
            Retrive_SMS_TEMPLATE()
            MsgBox("Message successfully saved", MsgBoxStyle.Information, "Template")
        End If
    End Sub

    Public Sub Retrive_SMS_TEMPLATE()
        Try
            Dim query As String
            Dim i As Integer = 0
            query = "SELECT * FROM sms_template WHERE user_access_group LIKE '" & ClientUserAccessGroup & "'"

            Dim connection As New MySqlConnection(connStrBMG)
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader
            connection.Open()
            reader = cmd.ExecuteReader()
            'this will clear the listbox
            lsTemplate.Items.Clear()

            If reader.HasRows = True Then
                While reader.Read
                    i += 1
                    Dim ls As New ListViewItem(i)
                    ls.SubItems.Add(reader.Item("id").ToString.Trim())
                    ls.SubItems.Add(reader.Item("template").ToString.Trim())
                    ls.SubItems.Add(reader.Item("created_by").ToString.Trim())
                    lsTemplate.Items.Add(ls)
                End While
            End If
            connection.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Function Delete_SMS_TEMPLATE(ByVal id As String)
        Try
            Dim query As String
            query = "DELETE FROM sms_template WHERE id= '" & id & "'"

            Dim rowsEffected As Integer = 0
            Dim connection As New MySqlConnection(connStrBMG)
            Dim cmd As New MySqlCommand(query, connection)

            connection.Open()

            rowsEffected = cmd.ExecuteNonQuery()
            Delete_SMS_TEMPLATE = rowsEffected
            connection.Close()

            Return rowsEffected
        Catch ex As Exception
            MsgBox(ex.Message)
            Console.WriteLine(ex.Message)
        End Try

    End Function

    Function footer_HR(ByVal Username As String) As String

        Dim _BeloHR As String = "-Belo Helpdesk" & vbNewLine & vbNewLine &
                                    "To unsubscribe reply OFF"
        Dim footer As String = ""



        Return footer
    End Function
    Private Sub lsTemplate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsTemplate.Click
        On Error Resume Next

        If lsTemplate.Items.Count > 0 Then
            _Cid = lsTemplate.SelectedItems(0).SubItems(1).Text.Trim()
            _Ctemplate = lsTemplate.SelectedItems(0).SubItems(2).Text.Trim()
            TxtLenghtToolStrip.Text = Len(_Ctemplate)
            txtMessage.Text = _Ctemplate
        End If
    End Sub

    Private Sub lsTemplate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lsTemplate.KeyDown
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
            lsTemplate_Click(Me, EventArgs.Empty)
        End If
    End Sub

    Private Sub lsTemplate_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lsTemplate.KeyUp
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
            lsTemplate_Click(Me, EventArgs.Empty)
        End If
    End Sub

    Private Sub lsTemplate_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lsTemplate.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ContextMenuSMSSetting.Show(lsTemplate, e.Location)
        End If

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        If MsgBox("Delete Template", vbYesNo, "Template") = MsgBoxResult.Yes Then
            Delete_SMS_TEMPLATE(_Cid)
            Retrive_SMS_TEMPLATE()
        End If

    End Sub


    Private Sub FooterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FooterToolStripMenuItem.Click
        If chHelpdesk.Checked = True Then
            MsgBox(_BeloHelpdesk, MsgBoxStyle.Information, "Footer")
        ElseIf chHR.Checked = True Then
            Dim StrFistFooter = Department_First_Footer("HRT")
            MsgBox(StrFistFooter & UserAndBranchName & vbNewLine & vbNewLine & Department_End_Footer, MsgBoxStyle.Information, "Footer")
        Else
            MsgBox(FooterSMS, MsgBoxStyle.Information, "Footer")
        End If
    End Sub
    Dim bln As Boolean = False

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        bln = True
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        bln = False
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel1.Visible = False
    End Sub

    Private Sub lbInvalid_Click(sender As Object, e As EventArgs) Handles lbInvalid.Click

    End Sub
    Public Sub Display_patient(_name As String)
        Dim dt = New DataTable()
        Try
            Dim query As String
            Dim i As Integer = 0
            If _name = "" Then
                query = "SELECT `mobile`,`firstname`,lastname FROM `patient_info` WHERE MOBILE <> '' LIMIT 100"
            Else
                query = "SELECT `mobile`,`firstname`,lastname FROM `patient_info`where firstname like '%" & TextBox1.Text.Trim & "%' AND MOBILE <> '' or lastname like '%" & TextBox1.Text.Trim & "%' AND MOBILE <> '' or mobile like '%" & TextBox1.Text.Trim & "%' AND MOBILE <> '' LIMIT 100"
            End If

            Dim connection As New MySqlConnection(connStrBMG)
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader
            connection.Open()
            reader = cmd.ExecuteReader()
            dt.Load(reader)
            'this will clear the listbox
            DataGridView1.DataSource = dt
            connection.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            If CBool(DirectCast(DataGridView1.Rows(i).Cells("check"), DataGridViewCheckBoxCell).Value) = True Then
                Dim match As DataGridViewCell() = (From row As DataGridViewRow In Me.DataGridView2.Rows From cell As DataGridViewCell In row.Cells Select cell Where CStr(cell.FormattedValue) = DataGridView1.Rows(i).Cells(1).Value.ToString).ToArray()
                If match.Length = 0 Then
                    Dim row As String() = New String() {DataGridView1.Rows(i).Cells(1).Value.ToString, DataGridView1.Rows(i).Cells(2).Value.ToString, DataGridView1.Rows(i).Cells(3).Value.ToString}
                    DataGridView2.Rows.Add(row)
                End If
            End If
        Next
        Button5.Text = "CLEAR(" & DataGridView2.RowCount & ")"

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Display_patient(TextBox1.Text.Trim)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub


    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For i As Integer = 0 To DataGridView2.Rows.Count - 1
            txtMobile.AppendText(DataGridView2.Rows(i).Cells(0).Value.ToString & ";")
        Next
        Panel1.Visible = False
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        DataGridView2.Rows.Clear()
        Button5.Text = "CLEAR"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Display_patient(TextBox1.Text.Trim)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Display_patient("")
        txtMobile.Clear()
        Panel1.Visible = True
    End Sub

End Class