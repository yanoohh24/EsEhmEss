Imports MySql.Data.MySqlClient

Public Class frmPatientsList
    Dim query As String

    Private Sub ListPatientsHeaders()
        lstPatientList.Columns.Clear()
        lstPatientList.Columns.Add("ID")
        lstPatientList.Columns.Add("Patient Name", 250)
        lstPatientList.Columns.Add("Gender", 70)
        lstPatientList.Columns.Add("Mobile", 100)
        lstPatientList.Columns.Add("Birthday", 100)
        lstPatientList.Columns.Add("SMS Alert", 60)
        lstPatientList.Columns.Add("Branch Code", 80)
        lstPatientList.Columns.Add("Branch Name", 120)
        lstPatientList.Items.Clear()
    End Sub

    Private Sub frmPatientsList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListPatientsHeaders()
        lbNoRecordFound.Text = ""
        GenderToolStrip.Items.Add("All")
        GenderToolStrip.Items.Add("Male")
        GenderToolStrip.Items.Add("Female")
        GenderToolStrip.SelectedIndex = 0

        AlertStatusToolStrip.Items.Add("All")
        AlertStatusToolStrip.Items.Add("ON")
        AlertStatusToolStrip.Items.Add("OFF")
        AlertStatusToolStrip.SelectedIndex = 0

        RowsToolStrip.Text = lstPatientList.Items.Count

    End Sub
    Function RetriveSMS()
        Try

            'query = "SELECT PatientID, CONCAT(firstname,' ', lastname) pxName, gender, mobile,sms_alert FROM `patient_info` WHERE " _
            '& " (firstname LIKE '" & pxNameLast & "%' OR lastname LIKE '" & pxNameLast & "%') AND gender LIKE '" & pxGender & "' " _
            '& " AND sms_alert" & pxAlert & " ORDER BY firstname ASC"

            Dim connection As New MySqlConnection(connStrSMS)
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader
            connection.Open()
            reader = cmd.ExecuteReader()
            'this will clear the listbox
            lstPatientList.Items.Clear()
            If reader.HasRows = True Then
                While reader.Read
                    Dim byear As Integer = reader.Item("Byyyy").ToString()
                    Dim ls As New ListViewItem(reader.Item("Patient_ID").ToString())
                    ls.SubItems.Add(reader.Item("pxName").ToString.Trim())
                    ls.SubItems.Add(reader.Item("gender").ToString())
                    ls.SubItems.Add(reader.Item("mobile_number").ToString())
                    If byear <= 1 Then
                        ls.SubItems.Add("")
                    Else
                        ls.SubItems.Add(Format(reader.Item("birthday"), "MMM dd yyyy"))
                    End If
                    ls.SubItems.Add(PX_SMS_Status(reader.Item("sms_alert").ToString()))
                    ls.SubItems.Add(reader.Item("branch").ToString())
                    ls.SubItems.Add(reader.Item("branchname").ToString())
                    lstPatientList.Items.Add(ls)
                End While
                lbNoRecordFound.Text = ""
            Else
                lbNoRecordFound.Text = "- No record found"
            End If
            connection.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        RowsToolStrip.Text = lstPatientList.Items.Count

    End Function

    Private Sub SearchToolStrip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchToolStrip.Click
        Dim pxGender As String
        Dim pxAlert As String
        Dim pxFirstName As String = Replace(pxNameToolStrip.Text.Trim, "'", "\'")
        Dim pxLastName As String = Replace(pxLastNameToolStrip.Text.Trim, "'", "\'")
        Dim pxMiddleName As String = Replace(pxMiddleNameToolStrip.Text.Trim, "'", "\'")
        Dim pxMobile As String = Replace(pxMobileToolStrip.Text.Trim, "'", "\'")

        ListPatientsHeaders()

        RowsToolStrip.Text = 0
        lbNoRecordFound.Text = ""

        Select Case GenderToolStrip.SelectedIndex
            Case 1
                pxGender = "Male%"
            Case 2
                pxGender = "%Female%"
            Case Else
                pxGender = "%"
        End Select

        Select Case AlertStatusToolStrip.SelectedIndex
            Case 1
                pxAlert = "=1"
            Case 2
                pxAlert = "=0"
            Case Else
                pxAlert = ">=0"
        End Select

        If pxFirstName = "First Name" And pxLastName = "Last Name" And pxMiddleName = "Middle Name" And pxMobile = "Mobile" Then
            MsgBox("Please enter patient name or mobile number to search.", MsgBoxStyle.Information, "Information")
            Exit Sub

        End If
        If pxFirstName <> "First Name" Then
            pxFirstName = " first_name LIKE '%" & pxFirstName & "%' AND "
        Else
            pxFirstName = ""
        End If

        If pxLastName <> "Last Name" Then
            pxLastName = " last_name LIKE '%" & pxLastName & "%' AND "
        Else
            pxLastName = ""
        End If

        If pxMiddleName <> "Middle Name" Then
            pxMiddleName = " middle_name LIKE '%" & pxMiddleName & "%' AND "
        Else
            pxMiddleName = ""
        End If

        If pxMobile <> "Mobile" Then

            pxMobile = " mobile_number LIKE '%" & Replace(Replace(Replace(pxMobile, " ", ""), "-", ""), ".", "") & "%' AND "
        Else
            pxMobile = ""
        End If
        'REMOVED Clinic_name & BranchName ('clinic_name,(SELECT NAME FROM `ref_branch` WHERE CODE=clinic_name) branchname " _)
        query = "SELECT Patient_ID, CONCAT(IF(LENGTH(last_name)<1,'',CONCAT(last_name,', ')),' ', first_name,' ',middle_name) pxName, gender, mobile_number,birthday,YEAR(birthday) Byyyy, sms_alert,branch,(SELECT NAME FROM `branches` WHERE id=branch) branchname " _
        & " FROM `patient` WHERE " & pxFirstName & pxLastName & pxMiddleName & pxMobile & " gender LIKE '" & pxGender & "' AND sms_alert" & pxAlert & " ORDER BY first_name ASC LIMIT 0,1000 "

        RetriveSMS()
    End Sub

    Private Sub pxNameToolStrip_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles pxNameToolStrip.GotFocus

        If pxNameToolStrip.Text.Trim = "First Name" Then
            pxNameToolStrip.Text = ""
        End If

    End Sub

    Private Sub pxNameToolStrip_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles pxNameToolStrip.KeyUp
        If e.KeyCode = Keys.Enter Then
            If pxNameToolStrip.Text.Trim = "" Then
                lbNoRecordFound.Text = "- Please enter patient name"
            Else
                SearchToolStrip_Click(Me, EventArgs.Empty)
            End If
        End If
    End Sub

    Private Sub SearchPatientNameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchPatientNameToolStripMenuItem.Click
        pxNameToolStrip.Focus()
    End Sub

    Private Sub lstPatientList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstPatientList.Click
        FFPxProfile.lbPxID.Text = lstPatientList.SelectedItems(0).Text.Trim()
    End Sub

    Private Sub lstPatientList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstPatientList.DoubleClick
        Try
            Dim pxIDD As String = lstPatientList.SelectedItems(0).Text.Trim()
            FFPxProfile.Show()
            FFPxProfile.BringToFront()
            FFPxProfile.Text = "Patient Profile ID: " & pxIDD
            FFPxProfile.lbPxID.Text = pxIDD
        Catch ex As Exception

            FFPxProfile = New frmPatientProfile()
            Dim pxIDD As String = lstPatientList.SelectedItems(0).Text.Trim()
            FFPxProfile.Show()
            FFPxProfile.BringToFront()
            FFPxProfile.Text = "Patient Profile ID: " & pxIDD
            FFPxProfile.lbPxID.Text = pxIDD
        End Try

    End Sub

    Private Sub lstPatientList_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstPatientList.GotFocus
        If lstPatientList.Items.Count > 0 Then
            Try
                lstPatientList.Items(lstPatientList.FocusedItem.Index).Selected = True
                lstPatientList.Select()

            Catch ex As Exception
                lstPatientList.Items(0).Selected = True
                lstPatientList.Select()
            End Try
        End If
    End Sub

    Private Sub lstPatientList_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstPatientList.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If lstPatientList.Items.Count > 0 Then
                ContextMenuMessages.Show(lstPatientList, e.Location)
            End If
        End If
    End Sub

    Private Sub SentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SentToolStripMenuItem.Click
        Try
            FFSendSMS.Show()
            FFSendSMS.BringToFront()

            FFSendSMS.txtMobile.Text = px_pri_mobile(lstPatientList.SelectedItems(0).SubItems(3).Text.Trim())
            FFSendSMS.pxToolStrip.Visible = True
            FFSendSMS.pxToolStrip.Text = lstPatientList.SelectedItems(0).SubItems(1).Text.Trim()
            FFSendSMS.pxIDToolStrip.Text = lstPatientList.SelectedItems(0).Text.Trim()
            FFSendSMS.txtMobile.Focus()
            FFSendSMS.txtMobile.Enabled = False
            FFSendSMS.txtMessage.Focus()
        Catch ex As Exception
            FFSendSMS = New frmSMSSend()
            FFSendSMS.Show()
            FFSendSMS.BringToFront()

            FFSendSMS.txtMobile.Text = px_pri_mobile(lstPatientList.SelectedItems(0).SubItems(3).Text.Trim())
            FFSendSMS.pxToolStrip.Visible = True
            FFSendSMS.pxToolStrip.Text = lstPatientList.SelectedItems(0).SubItems(1).Text.Trim()
            FFSendSMS.pxIDToolStrip.Text = lstPatientList.SelectedItems(0).Text.Trim()
            FFSendSMS.txtMobile.Focus()
            FFSendSMS.txtMobile.Enabled = False
            FFSendSMS.txtMessage.Focus()
        End Try

    End Sub
    Function px_pri_mobile(ByVal mobile As String) As String

        Dim StrMobile As String

        mobile = Replace(Replace(Replace(mobile.Trim, " ", ""), "-", ""), ".", "")
        If Len(mobile) < 1 Then
            px_pri_mobile = ""
            Exit Function
        End If

        Select Case Mid(mobile.Trim, 1, 2)
            Case "09"
                If Len(mobile.Trim) >= 11 Then
                    StrMobile = Mid(mobile.Trim, 2, 10)
                    px_pri_mobile = "+63" & StrMobile
                Else
                    px_pri_mobile = ""
                End If
            Case "63"
                If Len(mobile.Trim) >= 12 Then
                    StrMobile = Mid(mobile.Trim, 1, 12)
                    px_pri_mobile = "+" & StrMobile
                Else
                    px_pri_mobile = ""
                End If
            Case Else
                Select Case Mid(mobile.Trim, 1, 3)
                    Case "+63"
                        If Len(mobile.Trim) >= 13 Then
                            StrMobile = Mid(mobile.Trim, 1, 13)
                            px_pri_mobile = StrMobile
                        Else
                            px_pri_mobile = ""
                        End If
                    Case Else
                        Select Case Mid(mobile.Trim, 1, 1)
                            Case "9"
                                If Len(mobile.Trim) >= 9 Then
                                    StrMobile = Mid(mobile.Trim, 1, 10)
                                    px_pri_mobile = "+63" & StrMobile
                                Else
                                    px_pri_mobile = ""
                                End If
                            Case Else
                                px_pri_mobile = ""
                        End Select
                End Select
        End Select
    End Function

    Private Sub pxNameToolStrip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pxNameToolStrip.Click

    End Sub

    Private Sub pxNameToolStrip_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles pxNameToolStrip.LostFocus
        If pxNameToolStrip.Text.Trim = "" Then
            pxNameToolStrip.Text = "First Name"
        End If
    End Sub

    Private Sub pxLastNameToolStrip_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles pxLastNameToolStrip.GotFocus
        If pxLastNameToolStrip.Text.Trim = "Last Name" Then
            pxLastNameToolStrip.Text = ""
        End If
    End Sub

    Private Sub pxLastNameToolStrip_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles pxLastNameToolStrip.LostFocus
        If pxLastNameToolStrip.Text.Trim = "" Then
            pxLastNameToolStrip.Text = "Last Name"
        End If
    End Sub

    Private Sub pxMiddleNameToolStrip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pxMiddleNameToolStrip.Click

    End Sub

    Private Sub pxMiddleNameToolStrip_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles pxMiddleNameToolStrip.GotFocus
        If pxMiddleNameToolStrip.Text.Trim = "Middle Name" Then
            pxMiddleNameToolStrip.Text = ""
        End If
    End Sub

    Private Sub pxMiddleNameToolStrip_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles pxMiddleNameToolStrip.KeyUp
        If e.KeyCode = Keys.Enter Then
            If pxMiddleNameToolStrip.Text.Trim = "" Then
                lbNoRecordFound.Text = "- Please enter patient middle name"
            Else
                SearchToolStrip_Click(Me, EventArgs.Empty)
            End If
        End If
    End Sub

    Private Sub pxMiddleNameToolStrip_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles pxMiddleNameToolStrip.LostFocus
        If pxMiddleNameToolStrip.Text.Trim = "" Then
            pxMiddleNameToolStrip.Text = "Middle Name"
        End If
    End Sub

    Private Sub pxMobileToolStrip_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles pxMobileToolStrip.GotFocus
        If pxMobileToolStrip.Text.Trim = "Mobile" Then
            pxMobileToolStrip.Text = ""
        End If
    End Sub

    Private Sub pxMobileToolStrip_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles pxMobileToolStrip.LostFocus
        If pxMobileToolStrip.Text.Trim = "" Then
            pxMobileToolStrip.Text = "Mobile"
        End If
    End Sub

    Private Sub pxLastNameToolStrip_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles pxLastNameToolStrip.KeyUp
        If e.KeyCode = Keys.Enter Then
            If pxLastNameToolStrip.Text.Trim = "" Then
                lbNoRecordFound.Text = "- Please enter patient last name"
            Else
                SearchToolStrip_Click(Me, EventArgs.Empty)
            End If
        End If
    End Sub

    Private Sub pxMobileToolStrip_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles pxMobileToolStrip.KeyUp
        If e.KeyCode = Keys.Enter Then
            If pxMobileToolStrip.Text.Trim = "" Then
                lbNoRecordFound.Text = "- Please enter patient mobile number"
            Else
                SearchToolStrip_Click(Me, EventArgs.Empty)
            End If
        End If
    End Sub

    Private Sub pxLastNameToolStrip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pxLastNameToolStrip.Click

    End Sub

    Private Sub AlertStatusToolStrip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlertStatusToolStrip.Click

    End Sub

    Private Sub lstPatientList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstPatientList.SelectedIndexChanged

    End Sub
End Class