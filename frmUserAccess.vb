Imports MySql.Data.MySqlClient
Imports Microsoft.Win32

Public Class frmUserAccess
    Dim pxID As String = ""
    Dim pxUsername As String = ""
    Dim ls_username As String = ""
    Dim ls_name As String = ""
    Dim ls_Department As String = ""
    Dim ls_AsDept As Integer
    Dim ls_DeptKey As String
    Dim acc_admin As String = ""
    Dim acc_sms_admin As Integer
    Dim acc_sms_inbox As Integer
    Dim acc_sms_fullblast As Integer
    Dim acc_pxlist As Integer
    Dim acc_sms_send As Integer
    Dim acc_sms_birthday As Integer
    Dim acc_sms_contacts As Integer

    Dim query As String = ""
    Private Sub btView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btView.Click
        ToolStripStatus.Text = ""
        StatusUpdateToolStrip.Text = ""
        RetriveSMS()
    End Sub
    Private Sub LstColumns()
        lstUserList.Columns.Clear()
        lstUserList.Columns.Add("ID", 0)
        lstUserList.Columns.Add("Username", 100)
        lstUserList.Columns.Add("First Name", 120)
        lstUserList.Columns.Add("Last Name", 120)
        lstUserList.Columns.Add("Branch", 0)
        lstUserList.Columns.Add("Department", 80)
        lstUserList.Columns.Add("AsDept", 50)
        lstUserList.Columns.Add("DeptKey", 55)
        lstUserList.Columns.Add("User Group", 100)
        lstUserList.Columns.Add("Admin", 50)
        lstUserList.Columns.Add("SMS", 50)
        lstUserList.Columns.Add("Inbox", 50)
        lstUserList.Columns.Add("Full Blast", 65)
        lstUserList.Columns.Add("Patient List", 68)
        lstUserList.Columns.Add("Send SMS", 68)
        lstUserList.Columns.Add("Birthday", 60)
        lstUserList.Columns.Add("Contacts", 60)
        lstUserList.Columns.Add("Branch", 55)
        lstUserList.Items.Clear()
    End Sub
    Function RetriveSMS()
        Try
            Dim pxusername As String = Replace(txtUsername.Text.Trim, "'", "\'")
            Dim sql As String
            Dim usrgrp As String
            Dim branchCode As String

            If chUserAccGrp.SelectedIndex < 1 Then
                usrgrp = "%"
            Else
                usrgrp = chUserAccGrp.Text.Trim
            End If

            If cbBranch.SelectedIndex < 1 Then
                branchCode = "%"
            Else
                branchCode = lbBranchCode.Text
            End If

            If Len(pxusername) > 0 Then
                'sql = "SELECT * FROM `user_account_backend` WHERE username LIKE '%" & pxusername & "%' AND user_access_group LIKE '" & usrgrp & "' ORDER BY username ASC"
                sql = "SELECT id, username,firstname,lastname,branch,IFNULL((SELECT department_name FROM ref_user_access WHERE group_name=user_access_group),'') AS department," _
                & " as_dept,IFNULL((SELECT department_key FROM ref_user_access WHERE group_name=user_access_group),'') AS department_key,user_access_group, acc_admin, acc_sms_admin," _
                & " acc_sms, acc_sms_fullblast, acc_sms_pxlist, acc_sms_send,acc_sms_birthday,acc_sms_contacts,branch FROM `user_account_backend` WHERE username LIKE '%" & pxusername & "%' AND user_access_group LIKE '" & usrgrp & "' AND branch LIKE '" & branchCode & "' ORDER BY username ASC"
            Else
                'sql = "SELECT * FROM `user_account_backend` WHERE username LIKE '%' AND user_access_group LIKE '" & usrgrp & "' ORDER BY username ASC"
                sql = "SELECT id, username,firstname,lastname,branch,IFNULL((SELECT department_name FROM ref_user_access WHERE group_name=user_access_group),'') AS department," _
                & " as_dept,IFNULL((SELECT department_key FROM ref_user_access WHERE group_name=user_access_group),'') AS department_key,user_access_group, acc_admin, acc_sms_admin," _
                & " acc_sms, acc_sms_fullblast, acc_sms_pxlist, acc_sms_send,acc_sms_birthday,acc_sms_contacts,branch FROM `user_account_backend` WHERE username LIKE '%' AND user_access_group LIKE '" & usrgrp & "' AND branch LIKE '" & branchCode & "' ORDER BY username ASC"
            End If
            'MsgBox(sql)
            Dim connection As New MySqlConnection(connStrBMG)
            Dim cmd As New MySqlCommand(sql, connection)
            Dim reader As MySqlDataReader
            connection.Open()
            reader = cmd.ExecuteReader()
            'this will clear the listbox
            lstUserList.Items.Clear()
            If reader.HasRows = True Then
                While reader.Read
                    Dim ls As New ListViewItem(reader.Item("id").ToString())
                    ls.SubItems.Add(reader.Item("username").ToString.Trim())
                    ls.SubItems.Add(reader.Item("firstname").ToString())
                    ls.SubItems.Add(reader.Item("lastname").ToString())
                    ls.SubItems.Add(reader.Item("branch").ToString())
                    ls.SubItems.Add(reader.Item("department").ToString())
                    ls.SubItems.Add(reader.Item("as_dept").ToString())
                    ls.SubItems.Add(reader.Item("department_key").ToString())
                    ls.SubItems.Add(reader.Item("user_access_group").ToString())
                    ls.SubItems.Add(reader.Item("acc_admin").ToString())
                    ls.SubItems.Add(reader.Item("acc_sms_admin").ToString())
                    ls.SubItems.Add(reader.Item("acc_sms").ToString())
                    ls.SubItems.Add(reader.Item("acc_sms_fullblast").ToString())
                    ls.SubItems.Add(reader.Item("acc_sms_pxlist").ToString())
                    ls.SubItems.Add(reader.Item("acc_sms_send").ToString())
                    ls.SubItems.Add(reader.Item("acc_sms_birthday").ToString())
                    ls.SubItems.Add(reader.Item("acc_sms_contacts").ToString())
                    ls.SubItems.Add(reader.Item("branch").ToString())
                    lstUserList.Items.Add(ls)
                End While
            Else
                ToolStripStatus.Text = "No record found"
            End If
            connection.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function
    Private Sub lstUserList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstUserList.Click

        If lstUserList.Items.Count > 0 Then
            pxID = lstUserList.SelectedItems(0).Text
            ls_username = lstUserList.SelectedItems(0).SubItems(1).Text.Trim()
            ls_name = lstUserList.SelectedItems(0).SubItems(2).Text.Trim()
            ls_Department = lstUserList.SelectedItems(0).SubItems(5).Text.Trim()
            ls_AsDept = lstUserList.SelectedItems(0).SubItems(6).Text.Trim()
            ls_DeptKey = lstUserList.SelectedItems(0).SubItems(7).Text.Trim()
            acc_admin = lstUserList.SelectedItems(0).SubItems(9).Text.Trim()
            acc_sms_admin = lstUserList.SelectedItems(0).SubItems(10).Text.Trim()
            acc_sms_inbox = lstUserList.SelectedItems(0).SubItems(11).Text.Trim()
            acc_sms_fullblast = lstUserList.SelectedItems(0).SubItems(12).Text.Trim()
            acc_pxlist = lstUserList.SelectedItems(0).SubItems(13).Text.Trim()
            acc_sms_send = lstUserList.SelectedItems(0).SubItems(14).Text.Trim()
            acc_sms_birthday = lstUserList.SelectedItems(0).SubItems(15).Text.Trim()
            acc_sms_contacts = lstUserList.SelectedItems(0).SubItems(16).Text.Trim()

            lbpxID.Text = pxID
            txtLUsername.Text = ls_username
            txtName.Text = ls_name

            If ls_AsDept > 0 Then
                chEnableTag.Checked = True
            Else
                chEnableTag.Checked = False
            End If

            If acc_admin > 0 Then
                chAdmin.Checked = True
            Else
                chAdmin.Checked = False
            End If

            If acc_sms_admin > 0 Then
                chSMSAdmin.Checked = True
            Else
                chSMSAdmin.Checked = False
            End If

            If acc_sms_inbox Then
                chSMSInbox.Checked = True
            Else
                chSMSInbox.Checked = False
            End If

            If acc_sms_fullblast > 0 Then
                chFullBlast.Checked = True
            Else
                chFullBlast.Checked = False
            End If

            If acc_pxlist > 0 Then
                chPatientList.Checked = True
            Else
                chPatientList.Checked = False
            End If

            If acc_sms_send > 0 Then
                chSendSMS.Checked = True
            Else
                chSendSMS.Checked = False
            End If

            If acc_sms_birthday > 0 Then
                chBirthday.Checked = True
            Else
                chBirthday.Checked = False
            End If

            If acc_sms_contacts > 0 Then
                chContacts.Checked = True
            Else
                chContacts.Checked = False
            End If

        End If

    End Sub
    Private Sub UserGroupList()
        Try
            Dim i As Integer = 1
            Dim query As String

            query = "SELECT group_name FROM ref_user_access ORDER BY group_name ASC"

            Dim connection As New MySqlConnection(connStrBMG)
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader


            chUserAccGrp.Text = "All"
            chUserAccGrp.Items.Clear()

            connection.Open()
            reader = cmd.ExecuteReader()
            If reader.HasRows = True Then
                chUserAccGrp.Items.Add("All")
                While reader.Read
                    chUserAccGrp.Items.Add(reader.Item("group_name").ToString())
                End While
            End If
            chUserAccGrp.SelectedIndex = 0
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub combo_Branch_List()
        Try
            Dim i As Integer = 1
            Dim query As String

            If ClientAccAdmin = 1 Then
                query = "SELECT * FROM `ref_branch` WHERE CODE NOT LIKE '00' ORDER BY name ASC"
            Else
                query = "SELECT * FROM `ref_branch` WHERE CODE NOT LIKE '00' AND CODE='" & ClientBranch & "' ORDER BY name ASC"
            End If

            Dim connection As New MySqlConnection(connStrBMG)
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader

            cbBranch.Text = "[Branch]"
            cbBranch.Items.Clear()

            connection.Open()
            reader = cmd.ExecuteReader()
            cbBranch.Items.Add("All")
            If reader.HasRows = True Then
                While reader.Read
                    cbBranch.Items.Add(reader.Item("name").ToString())
                End While
            End If
            cbBranch.SelectedIndex = 0
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Function User_BranchCode(ByVal BranchName As String) As String
        Try
            Dim query As String = "SELECT * FROM `ref_branch` WHERE NAME LIKE '%" & BranchName & "%'"
            Dim connection As New MySqlConnection(connStrBMG)
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader
            connection.Open()
            reader = cmd.ExecuteReader()

            If reader.HasRows = True Then
                While reader.Read
                    User_BranchCode = reader.Item("code").ToString()
                    lbBranchCode.Text = User_BranchCode
                End While
            Else
                User_BranchCode = ""
                lbBranchCode.Text = ""
            End If
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Private Sub frmUserAccess_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RegistryGetLogin()
        LstColumns()
        UserGroupList()
        combo_Branch_List()
        connStrSMS = "Database=belo_test;Data Source=" & Host & ";User Id=" & UserName & ";Password=" & Password & ";UseCompression=True;Connection Timeout=28800"
        connStrBMG = " Database=belo_test;Data Source=" & Host & ";User Id=" & UserName & ";Password=" & Password & ";UseCompression=True;Connection Timeout=28800"
        connStrLOC = "Database=belo_test;Data Source=localhost;User Id=root;Password='';UseCompression=True;Connection Timeout=28800;Convert Zero Datetime=True"
        txtUsername.Text = ""
        txtLUsername.Text = ""
        txtName.Text = ""
        lbpxID.Text = ""
        ToolStripStatus.Text = ""
        StatusUpdateToolStrip.Text = ""

        HostToolStrip.Text = "IP: " & Host
    End Sub
    Private Sub RegistryGetLogin()
        Dim regKey As RegistryKey

        Try
            'Get Registry Record
            regKey = Registry.LocalMachine.OpenSubKey("SYSTEM\BeloSMS", True)

            If Len(regKey.GetValue("smsusername", "").ToString().Trim()) > 1 Then
                UserName = regKey.GetValue("smsusername", "").ToString().Trim()

            Else
                regKey.SetValue("smsusername", "root")
                UserName = "root"
            End If

            If Len(regKey.GetValue("smspassword", "").ToString().Trim()) > 1 Then
                Password = regKey.GetValue("smspassword", "").ToString().Trim()

            Else
                regKey.SetValue("smspassword", "")
                'Password = "webdeveoper"
                Password = "belo"
            End If

            If Len(regKey.GetValue("smsHostIP", "").ToString().Trim()) > 1 Then
                Host = regKey.GetValue("smsHostIP", "").ToString().Trim()
            Else
                regKey.SetValue("smsHostIP", "localhost")
                'Host = "192.168.100.250"
                Host = "192.168.100.172"
            End If

            regKey.Close()

        Catch ex As Exception
            'Create Registry Record
            regKey = Registry.LocalMachine.OpenSubKey("SYSTEM", True)
            regKey.CreateSubKey("BeloSMS")
            regKey = Registry.LocalMachine.OpenSubKey("SYSTEM\BeloSMS", True)

            'UserName = "admin"
            'Password = "webdeveoper"
            'Host = "192.168.100.250"

            UserName = "root"
            Password = "belo"
            Host = "192.168.100.172"

            regKey.SetValue("smsusername", UserName)
            regKey.SetValue("smspassword", Password)
            regKey.SetValue("smsHostIP", Host)

            regKey.Close()

        End Try
    End Sub
    Private Sub chAdmin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chAdmin.CheckedChanged
        If chAdmin.Checked = True Then
            acc_admin = 1
        Else
            acc_admin = 0
        End If
    End Sub

    Private Sub chSMSAdmin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chSMSAdmin.CheckedChanged
        If chSMSAdmin.Checked = True Then
            acc_sms_admin = 1
        Else
            acc_sms_admin = 0
        End If
    End Sub

    Private Sub chSMS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chSMSInbox.CheckedChanged
        If chSMSInbox.Checked = True Then
            acc_sms_inbox = 1
        Else
            acc_sms_inbox = 0
        End If
    End Sub

    Private Sub chFullBlast_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chFullBlast.CheckedChanged
        If chFullBlast.Checked = True Then
            acc_sms_fullblast = 1
        Else
            acc_sms_fullblast = 0
        End If
    End Sub

    Private Sub chPatientList_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chPatientList.CheckedChanged
        If chPatientList.Checked = True Then
            acc_pxlist = 1
        Else
            acc_pxlist = 0
        End If
    End Sub

    Private Sub chSendSMS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chSendSMS.CheckedChanged
        If chSendSMS.Checked = True Then
            acc_sms_send = 1
        Else
            acc_sms_send = 0
        End If
    End Sub

    Private Sub chBirthday_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chBirthday.CheckedChanged
        If chBirthday.Checked = True Then
            acc_sms_birthday = 1
        Else
            acc_sms_birthday = 0
        End If
    End Sub
    Private Sub chContacts_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chContacts.CheckedChanged
        If chContacts.Checked = True Then
            acc_sms_contacts = 1
        Else
            acc_sms_contacts = 0
        End If
    End Sub

    Private Sub chEnableTag_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chEnableTag.CheckedChanged
        If chEnableTag.Checked = True Then
            ls_AsDept = 1
        Else
            ls_AsDept = 0
        End If
    End Sub
    Private Sub btUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btUpdate.Click
        Dim sql As String
        If Len(pxID) < 1 Or Len(lbpxID.Text) < 1 Then
            StatusUpdateToolStrip.Text = "Please select user to update setting"
            Exit Sub
        End If

        sql = "UPDATE `user_account_backend` SET acc_admin=" & acc_admin & ",acc_sms=" & acc_sms_inbox & ",acc_sms_admin=" & acc_sms_admin & ",acc_sms_fullblast=" & acc_sms_fullblast & ",acc_sms_pxlist=" & acc_pxlist & ", " _
            & " acc_sms_send=" & acc_sms_send & ",acc_sms_birthday=" & acc_sms_birthday & ",acc_sms_contacts=" & acc_sms_contacts & ",as_dept=" & ls_AsDept & " WHERE id=" & pxID & ""
        'MsgBox(sql)

        If SMS_UPDATE(sql) > 0 Then
            StatusUpdateToolStrip.Text = "Successfully updated"
        Else
            StatusUpdateToolStrip.Text = ""
        End If

        btView_Click(Me, EventArgs.Empty)
    End Sub
    Function SMS_UPDATE(ByVal sql As String) As Integer

        Try
            Dim rowsEffected As Integer = 0
            Dim connection As New MySqlConnection(connStrBMG)
            Dim cmd As New MySqlCommand(sql, connection)

            connection.Open()

            rowsEffected = cmd.ExecuteNonQuery()
            SMS_UPDATE = rowsEffected
            connection.Close()

            Return rowsEffected
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Sub lstUserList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstUserList.DoubleClick
        lstUserList_Click(Me, EventArgs.Empty)

        Try
            FFUserUpdateProfile.Show()
            FFUserUpdateProfile.BringToFront()
            FFUserUpdateProfile.lbID.Text = pxID
        Catch ex As Exception
            FFUserUpdateProfile = New frmUserUpdateProfile()
            FFUserUpdateProfile.Show()
            FFUserUpdateProfile.BringToFront()
            FFUserUpdateProfile.lbID.Text = pxID
        End Try

    End Sub

    Private Sub lstUserList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstUserList.KeyDown
        If lstUserList.Items.Count > 0 Then
            lstUserList_Click(Me, EventArgs.Empty)
        End If
    End Sub

    Private Sub lstUserList_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstUserList.KeyUp
        If lstUserList.Items.Count > 0 Then
            lstUserList_Click(Me, EventArgs.Empty)
        End If
    End Sub

    Private Sub txtUsername_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsername.KeyUp
        If e.KeyCode = Keys.Enter Then
            btView_Click(Me, EventArgs.Empty)
        End If
    End Sub

    Private Sub cbBranch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbBranch.SelectedIndexChanged
        lbBranchCode.Text = User_BranchCode(cbBranch.Text.Trim)
        btView_Click(Me, EventArgs.Empty)
    End Sub

    Private Sub AddUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddUserToolStripMenuItem.Click

        Try
            FFUserAdd.Show()
            FFUserAdd.BringToFront()
        Catch ex As Exception
            FFUserAdd = New frmUserAdd()
            FFUserAdd.Show()
            FFUserAdd.BringToFront()

        End Try
    End Sub

    Private Sub lstUserList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstUserList.SelectedIndexChanged

    End Sub
End Class