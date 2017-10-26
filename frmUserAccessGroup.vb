Imports MySql.Data.MySqlClient

Public Class frmUserAccessGroup
    Dim ls_id As String
    Dim ls_group_name As String
    Dim ls_department_name As String
    Dim ls_department_first_footer As String
    Dim ls_Acknowledgment As String
    Dim ls_enable As String
    Dim ls_enableUpdate As String
    Dim ls_key As String

    Private Sub LstColumns()
        lstUserGroupList.Columns.Clear()
        lstUserGroupList.Columns.Add("ID", 0)
        lstUserGroupList.Columns.Add("Group Name", 150)
        lstUserGroupList.Columns.Add("Department Name", 200)
        lstUserGroupList.Columns.Add("key", 50)
        lstUserGroupList.Columns.Add("Reply format", 200)
        lstUserGroupList.Columns.Add("Acknowledgment", 200)
        lstUserGroupList.Columns.Add("Enable", 55)
        lstUserGroupList.Items.Clear()
    End Sub
    Private Sub frmUserAccessGroup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtGroupname.Text = ""

        txtGroupNameUpdate.Text = ""
        txtDepartmentName.Text = ""
        txtKey.Text = ""
        txtReplyFormat.Text = ""

        txtGroupNameAdd.Text = ""
        txtDepartmentNameAdd.Text = ""
        txtKeyAdd.Text = ""
        lbID.Text = ""
        txtReplyFormatAdd.Text = ""
        txtAcknowledgment.Text = ""
        txtAcknowledgmentAdd.Text = ""
        LstColumns()
    End Sub

    Function RetriveSMS()
        Try
            Dim Groupname As String = Replace(txtGroupname.Text.Trim, "'", "\'")
            Dim sql As String

            If Len(Groupname) > 0 Then
                sql = "SELECT * FROM ref_user_access WHERE group_name LIKE '%" & Groupname & "%' ORDER BY group_name ASC"
            Else
                sql = "SELECT * FROM ref_user_access WHERE group_name LIKE '%" & Groupname & "%' ORDER BY group_name ASC"
            End If

            'MsgBox(sql)
            Dim connection As New MySqlConnection(connStrBMG)
            Dim cmd As New MySqlCommand(sql, connection)
            Dim reader As MySqlDataReader
            connection.Open()
            reader = cmd.ExecuteReader()
            'this will clear the listbox
            lstUserGroupList.Items.Clear()
            If reader.HasRows = True Then
                While reader.Read
                    Dim ls As New ListViewItem(reader.Item("id").ToString())
                    ls.SubItems.Add(reader.Item("group_name").ToString.Trim())
                    ls.SubItems.Add(reader.Item("department_name").ToString())
                    ls.SubItems.Add(reader.Item("department_key").ToString())
                    ls.SubItems.Add(reader.Item("department_first_footer").ToString())
                    ls.SubItems.Add(reader.Item("dapertment_reply_sms").ToString())
                    ls.SubItems.Add(reader.Item("dapertment_enable").ToString())
                    lstUserGroupList.Items.Add(ls)
                End While
            Else
                MsgBox("No record found")
            End If
            connection.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Sub btView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btView.Click
        txtGroupNameUpdate.Text = ""
        txtDepartmentName.Text = ""
        txtKey.Text = ""
        lbID.Text = ""
        RetriveSMS()
    End Sub

    Private Sub lstUserGroupList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstUserGroupList.Click
        On Error Resume Next

        If lstUserGroupList.Items.Count > 0 Then
            ls_id = lstUserGroupList.SelectedItems(0).Text
            ls_group_name = lstUserGroupList.SelectedItems(0).SubItems(1).Text.Trim()
            ls_department_name = lstUserGroupList.SelectedItems(0).SubItems(2).Text.Trim()
            ls_key = lstUserGroupList.SelectedItems(0).SubItems(3).Text.Trim()
            ls_department_first_footer = lstUserGroupList.SelectedItems(0).SubItems(4).Text.Trim()
            ls_Acknowledgment = lstUserGroupList.SelectedItems(0).SubItems(5).Text.Trim()
            ls_enable = lstUserGroupList.SelectedItems(0).SubItems(6).Text.Trim()

            If ls_enable = 1 Then
                chEnableDep.Checked = True
            Else
                chEnableDep.Checked = False
            End If

            lbID.Text = ls_id
            txtGroupNameUpdate.Text = ls_group_name
            txtDepartmentName.Text = ls_department_name
            txtKey.Text = ls_key
            txtReplyFormat.Text = ls_department_first_footer
            txtAcknowledgment.Text = ls_Acknowledgment

        End If
    End Sub

    Function SMS_GROUP_UPDATE(ByVal sql As String) As Integer

        Try
            Dim rowsEffected As Integer = 0
            Dim connection As New MySqlConnection(connStrBMG)
            Dim cmd As New MySqlCommand(sql, connection)

            connection.Open()

            rowsEffected = cmd.ExecuteNonQuery()
            SMS_GROUP_UPDATE = rowsEffected
            connection.Close()
            Return rowsEffected
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Sub btUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btUpdate.Click
        Dim sql As String
        Dim _departmentname As String = Replace(txtDepartmentName.Text.Trim, "'", "\'")
        Dim _key As String = Replace(txtKey.Text.Trim, "'", "\'")
        Dim _department_first_footer = Replace(txtReplyFormat.Text.Trim, "'", "\'")
        Dim _acknowledgedment As String = Replace(txtAcknowledgment.Text.Trim, "'", "\'")

        If Len(lbID.Text) < 1 Then
            MsgBox("Please select group name to update.")
            Exit Sub
        End If
        If Len(_departmentname) < 1 Then
            txtDepartmentName.Focus()
            MsgBox("Please enter department name")
            Exit Sub
        End If

        If Len(_key) < 1 Then
            txtKey.Focus()
            MsgBox("Please enter key name")
            Exit Sub
        End If

        sql = "UPDATE  `ref_user_access` SET department_name='" & _departmentname & "',department_key='" & _key & "',department_first_footer='" & _department_first_footer & "', dapertment_reply_sms='" & _acknowledgedment & "', dapertment_enable='" & ls_enable & "' WHERE id='" & lbID.Text.Trim & "'"
        If SMS_GROUP_UPDATE(sql) > 0 Then
            txtGroupNameUpdate.Text = ""
            txtDepartmentName.Text = ""
            txtKey.Text = ""
            txtReplyFormat.Text = ""
            txtAcknowledgment.Text = ""
            lbID.Text = ""

            txtGroupNameAdd.Text = ""
            txtDepartmentNameAdd.Text = ""
            txtKeyAdd.Text = ""
            txtReplyFormatAdd.Text = ""
            txtAcknowledgmentAdd.Text = ""

            FFPatientsSMS.ClientBrachAsDeptAssiged()
            MsgBox("Successfully updated")
        Else
            MsgBox("Update failed. Please try again.")
        End If

        btView_Click(Me, EventArgs.Empty)

    End Sub

    Private Sub btAddGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAddGroup.Click
        Dim _groupNameAdd As String = Replace(txtGroupNameAdd.Text.Trim, "'", "\'")
        Dim _departmentname As String = Replace(txtDepartmentNameAdd.Text.Trim, "'", "\'")
        Dim _key As String = Replace(txtKeyAdd.Text.Trim, "'", "\'")
        Dim _department_first_footer = Replace(txtReplyFormatAdd.Text.Trim, "'", "\'")
        Dim _acknowledgedment As String = Replace(txtAcknowledgmentAdd.Text.Trim, "'", "\'")

        txtGroupNameUpdate.Text = ""
        txtDepartmentName.Text = ""
        txtKey.Text = ""
        lbID.Text = ""

        If Len(_groupNameAdd) < 1 Then
            txtGroupNameAdd.Focus()
            MsgBox("Please enter group name.")

            Exit Sub
        End If
        If Len(_departmentname) < 1 Then
            txtDepartmentNameAdd.Focus()
            MsgBox("Please enter department name")

            Exit Sub
        End If

        If Len(_key) < 1 Then
            txtKeyAdd.Focus()
            MsgBox("Please enter key name")
            Exit Sub
        End If

        Dim sql As String = "INSERT INTO `ref_user_access` SET group_name='" & _groupNameAdd & "',department_name='" & _departmentname & "',department_key='" & _key & "',department_first_footer='" & _department_first_footer & "',dapertment_reply_sms='" & _acknowledgedment & "',dapertment_enable='" & ls_enableUpdate & "', r_sms=1"
        If ADD_Group(sql) > 0 Then
            txtGroupNameAdd.Text = ""
            txtDepartmentNameAdd.Text = ""
            txtKeyAdd.Text = ""
            txtReplyFormatAdd.Text = ""
            txtAcknowledgmentAdd.Text = ""

            txtGroupNameUpdate.Text = ""
            txtDepartmentName.Text = ""
            txtKey.Text = ""
            txtReplyFormat.Text = ""
            txtAcknowledgment.Text = ""
            lbID.Text = ""

            chEnableDepUpdate.Checked = False
            FFPatientsSMS.ClientBrachAsDeptAssiged()
            btView_Click(Me, EventArgs.Empty)
            MsgBox("Successfully added group")
        Else
            MsgBox("added failed. Please try again.")

        End If
    End Sub
    Function ADD_Group(ByVal sql As String)

        Try
            Dim rowsEffected As Integer = 0
            Dim connection As New MySqlConnection(connStrBMG)
            Dim cmd As New MySqlCommand(sql, connection)

            connection.Open()

            rowsEffected = cmd.ExecuteNonQuery()
            ADD_Group = rowsEffected
            connection.Close()

            Return rowsEffected
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function


    Private Sub chEnableDep_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chEnableDep.CheckedChanged
        If chEnableDep.Checked = True Then
            ls_enable = "1"
        Else
            ls_enable = "0"
        End If
    End Sub

    Private Sub chEnableDepUpdate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chEnableDepUpdate.CheckedChanged
        If chEnableDepUpdate.Checked = True Then
            ls_enableUpdate = "1"
        Else
            ls_enableUpdate = "0"
        End If
    End Sub

    Private Sub lstUserGroupList_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstUserGroupList.KeyUp
        lstUserGroupList_Click(Me, EventArgs.Empty)
    End Sub

    Private Sub lstUserGroupList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstUserGroupList.SelectedIndexChanged

    End Sub

    Private Sub txtGroupname_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtGroupname.KeyUp
        If e.KeyCode = Keys.Enter Then
            btView_Click(Me, EventArgs.Empty)
        End If
    End Sub

    Private Sub txtGroupname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGroupname.TextChanged

    End Sub
End Class