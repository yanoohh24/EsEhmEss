Imports MySql.Data.MySqlClient

Public Class frmContacts
    Dim cID As String
    Dim firstname As String
    Dim lastname As String
    Dim middlename As String
    Dim address As String
    Dim telephone As String
    Dim mobile As String
    Dim email As String
    Dim company As String
    Dim sms_group As String

    Function save_contact_person(ByVal sql As String) As Integer
        Try
            Dim rowsEffected As Integer = 0
            Dim connection As New MySqlConnection(connStrBMG)
            Dim cmd As New MySqlCommand(sql, connection)

            connection.Open()

            rowsEffected = cmd.ExecuteNonQuery()
            save_contact_person = rowsEffected
            connection.Close()

            Return rowsEffected

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Dim sql As String
        firstname = Replace(txtName.Text.Trim, "'", "\'")
        lastname = Replace(txtLastName.Text.Trim, "'", "\'")
        middlename = Replace(txtMiddleName.Text.Trim, "'", "\'")
        address = Replace(txtAddress.Text.Trim, "'", "\'")
        telephone = Replace(txtTelephone.Text.Trim, "'", "\'")
        mobile = Replace(txtMobile.Text.Trim, "'", "\'")
        email = Replace(txtEmail.Text.Trim, "'", "\'")
        company = Replace(txtCompany.Text.Trim, "'", "\'")

        If Len(firstname) < 1 Then
            txtName.Text = txtName.Text.Trim
            txtName.Focus()
            MsgBox("Please enter Name")
            Exit Sub
        End If

        If cbGroups.SelectedIndex < 2 Then
            sms_group = ""
        Else
            sms_group = Replace(cbGroups.Text.Trim, "'", "\'")
        End If

        sql = "INSERT INTO `sms_contacs` SET firstname='" & firstname & "',lastname='" & lastname & "',middlename='" & middlename & "',address='" & address & "', " _
            & " telephone='" & telephone & "',mobile='" & mobile & "',email='" & email & "',company='" & company & "',sms_group='" & sms_group & "',created_by='" & ClientUsername & "'"
        If save_contact_person(sql) > 0 Then
            txtName.Text = ""
            txtLastName.Text = ""
            txtMiddleName.Text = ""
            txtAddress.Text = ""
            txtTelephone.Text = ""
            txtMobile.Text = ""
            txtEmail.Text = ""
            txtCompany.Text = ""
            cbGroups.SelectedIndex = 0
            MsgBox("Contacts successfully saved.")
        End If

    End Sub

    Private Sub btCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancel.Click
        Me.Dispose()
    End Sub
    Public Sub RetriveSMS()
        Try
            Dim frstName As String = Replace(txtSFirstName.Text.Trim, "'", "\'")
            Dim lstName As String = Replace(txtSLastName.Text.Trim, "'", "\'")
            Dim sMobile As String = Replace(txtSMobile.Text.Trim, "'", "\'")
            Dim grpName As String = Replace(cbGroupslst.Text.Trim, "'", "\'")

            If frstName <> "First Name" Then
                frstName = " firstname LIKE '%" & frstName & "%' AND "
            Else
                frstName = ""
            End If

            If lstName <> "Last Name" Then
                lstName = " lastname LIKE '%" & lstName & "%' AND "
            Else
                lstName = ""
            End If

            If sMobile <> "Mobile" Then

                sMobile = " mobile LIKE '%" & Replace(Replace(Replace(sMobile, " ", ""), "-", ""), ".", "") & "%' AND "
            Else
                sMobile = ""
            End If

            If cbGroupslst.SelectedIndex = 0 Then
                grpName = " sms_group LIKE '%' AND "
            Else
                grpName = " sms_group LIKE '" & grpName & "%' AND "
            End If

            Dim query As String
            query = "SELECT * FROM sms_contacs WHERE " & frstName & " " & lstName & " " & sMobile & grpName & " gender LIKE '%' ORDER BY firstname ASC"

            Dim connection As New MySqlConnection(connStrBMG)
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader
            connection.Open()
            reader = cmd.ExecuteReader()
            If reader.HasRows = True Then
                While reader.Read
                    Dim ls As New ListViewItem(reader.Item("id").ToString())
                    ls.SubItems.Add(reader.Item("firstname").ToString.Trim())
                    ls.SubItems.Add(reader.Item("middlename").ToString())
                    ls.SubItems.Add(reader.Item("lastname").ToString())
                    ls.SubItems.Add(reader.Item("gender").ToString())
                    ls.SubItems.Add(reader.Item("address").ToString())
                    ls.SubItems.Add(reader.Item("telephone").ToString())
                    ls.SubItems.Add(reader.Item("mobile").ToString())
                    ls.SubItems.Add(reader.Item("email").ToString())
                    ls.SubItems.Add(reader.Item("company").ToString())
                    ls.SubItems.Add(reader.Item("sms_group").ToString())
                    lstContacts.Items.Add(ls)
                End While
            End If
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub LisContactList()

        lstContacts.Items.Clear()
        lstContacts.Columns.Clear()
        lstContacts.Columns.Add("id", 20)
        lstContacts.Columns.Add("Name", 100)
        lstContacts.Columns.Add("Middle Name", 100)
        lstContacts.Columns.Add("Last Name", 100)
        lstContacts.Columns.Add("Gender", 70)
        lstContacts.Columns.Add("Address", 100)
        lstContacts.Columns.Add("Telephone", 80)
        lstContacts.Columns.Add("Mobile", 80)
        lstContacts.Columns.Add("email", 100)
        lstContacts.Columns.Add("Company", 100)
        lstContacts.Columns.Add("Group", 70)

    End Sub
    Private Sub Combo_GroupName_List_s()
        Try
            Dim i As Integer = 1
            Dim query As String

            query = "SELECT name FROM `sms_groups` ORDER BY name"

            Dim connection As New MySqlConnection(connStrBMG)
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader

            cbGroupslst.Items.Clear()
            cbGroupslst.Items.Add("All")

            connection.Open()
            reader = cmd.ExecuteReader()
            If reader.HasRows = True Then
                While reader.Read
                    cbGroupslst.Items.Add(reader.Item("name").ToString())
                End While
            End If
            cbGroupslst.SelectedIndex = 0
            connection.Close()
        Catch ex As Exception
            cbGroups.Text = ex.Message
        End Try

    End Sub
    Private Sub frmContacts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LisContactList()
        Combo_GroupName_List()
        Combo_GroupName_List_s()

        txtName.Text = ""
        txtLastName.Text = ""
        txtMiddleName.Text = ""
        txtAddress.Text = ""
        txtTelephone.Text = ""
        txtMobile.Text = ""
        txtEmail.Text = ""
        txtCompany.Text = ""
        cbGroups.Text = ""

        RowsToolStrip.Text = "Rows: " & lstContacts.Items.Count
    End Sub

    Private Sub btView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btView.Click
        chCheckAll.Checked = False
        'this will clear the listbox
        LisContactList()
        RetriveSMS()

        RowsToolStrip.Text = "Rows: " & lstContacts.Items.Count
    End Sub

    Private Sub ImportContactsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportContactsToolStripMenuItem.Click
        Try
            FFContactsImport.Show()
            FFContactsImport.BringToFront()
        Catch ex As Exception
            FFContactsImport = New frmContactsImport()
            FFContactsImport.Show()
            FFContactsImport.BringToFront()
        End Try
    End Sub

    Private Sub txtSFirstName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSFirstName.GotFocus
        If txtSFirstName.Text.Trim = "First Name" Then
            txtSFirstName.Text = ""
        End If
    End Sub

    Private Sub txtSFirstName_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSFirstName.KeyUp
        If e.KeyCode = Keys.Enter Then
            btView_Click(Me, EventArgs.Empty)
        End If
    End Sub
    Private Sub txtSFirstName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSFirstName.LostFocus
        If txtSFirstName.Text.Trim = "" Then
            txtSFirstName.Text = "First Name"
        End If
    End Sub
    Private Sub txtSLastName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSLastName.GotFocus
        If txtSLastName.Text.Trim = "Last Name" Then
            txtSLastName.Text = ""
        End If
    End Sub

    Private Sub txtSLastName_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSLastName.KeyUp
        If e.KeyCode = Keys.Enter Then
            btView_Click(Me, EventArgs.Empty)
        End If
    End Sub
    Private Sub txtSLastName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSLastName.LostFocus
        If txtSLastName.Text.Trim = "" Then
            txtSLastName.Text = "Last Name"
        End If
    End Sub
    Private Sub txtSMobile_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSMobile.GotFocus
        If txtSMobile.Text.Trim = "Mobile" Then
            txtSMobile.Text = ""
        End If
    End Sub

    Private Sub txtSMobile_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSMobile.KeyUp
        If e.KeyCode = Keys.Enter Then
            btView_Click(Me, EventArgs.Empty)
        End If
    End Sub

    Private Sub txtSMobile_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSMobile.LostFocus
        If txtSMobile.Text.Trim = "" Then
            txtSMobile.Text = "Mobile"
        End If
    End Sub

    Private Sub txtGroupName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGroupName.GotFocus
        If txtGroupName.Text = "Group Name" Then
            txtGroupName.Text = ""
        End If

    End Sub

    Private Sub txtGroupName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGroupName.LostFocus
        If txtGroupName.Text = "" Then
            txtGroupName.Text = "Group Name"
        End If
    End Sub

    Private Sub btAddGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAddGroup.Click
        Dim GrpName As String = Replace(txtGroupName.Text.Trim, "'", "\'")

        If Len(GrpName) < 1 Then
            txtGroupName.Focus()
            MsgBox("Please enter group name")
            Exit Sub
        End If

        Dim sql As String = "INSERT INTO sms_groups SET name='" & GrpName & "'"

        If InsertGroup(sql) > 0 Then
            txtGroupName.Text = ""
            Combo_GroupName_List()
            MsgBox("Group name successfully saved.")

        Else
            MsgBox("Group name saving failed.")
        End If

    End Sub
    Function InsertGroup(ByVal sql As String) As Integer
        Try
            Dim rowsEffected As Integer = 0
            Dim connection As New MySqlConnection(connStrBMG)
            Dim cmd As New MySqlCommand(sql, connection)

            connection.Open()

            rowsEffected = cmd.ExecuteNonQuery()
            InsertGroup = rowsEffected
            connection.Close()

            Return rowsEffected

        Catch ex As Exception
            InsertGroup = 0
        End Try
    End Function
    Private Sub Combo_GroupName_List()
        Try
            Dim i As Integer = 1
            Dim query As String

            query = "SELECT name FROM `sms_groups` ORDER BY name"


            Dim connection As New MySqlConnection(connStrBMG)
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader


            cbGroups.Items.Clear()
            cbGroups.Items.Add("")
            connection.Open()
            reader = cmd.ExecuteReader()
            If reader.HasRows = True Then
                While reader.Read
                    cbGroups.Items.Add(reader.Item("name").ToString())
                End While
            End If
            cbGroups.SelectedIndex = 0
            connection.Close()
        Catch ex As Exception
            cbGroups.Text = ex.Message
        End Try
    End Sub

    Private Sub txtMobile_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMobile.KeyPress
        If Char.IsNumber(e.KeyChar) = False AndAlso Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTelephone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelephone.KeyPress
        If Char.IsNumber(e.KeyChar) = False AndAlso Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub lstContacts_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstContacts.Click
        On Error Resume Next
        If lstContacts.Items.Count > 0 Then
            cID = lstContacts.SelectedItems(0).Text.Trim()
        End If
    End Sub

    Private Sub lstContacts_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstContacts.DoubleClick
        lstContacts_Click(Me, EventArgs.Empty)

        Try
            FFContactsProfile.Show()
            FFContactsProfile.BringToFront()
            FFContactsProfile.lbID.Text = cID
        Catch ex As Exception
            FFContactsProfile = New frmContactsProfile()
            FFContactsProfile.Show()
            FFContactsProfile.BringToFront()
            FFContactsProfile.lbID.Text = cID
        End Try
    End Sub

    Private Sub lstContacts_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstContacts.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If lstContacts.Items.Count > 0 Then
                ContextMenuMessages.Show(lstContacts, e.Location)
            End If
        End If
    End Sub

    Private Sub SentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SentToolStripMenuItem.Click
        Try
            FFSendSMS.Show()
            FFSendSMS.BringToFront()

            FFSendSMS.txtMobile.Text = px_pri_mobile(lstContacts.SelectedItems(0).SubItems(7).Text.Trim())
            FFSendSMS.pxToolStrip.Visible = True
            FFSendSMS.pxToolStrip.Text = lstContacts.SelectedItems(0).SubItems(1).Text.Trim()
            FFSendSMS.pxIDToolStrip.Text = "" 'lstContacts.SelectedItems(0).Text.Trim()
            FFSendSMS.txtMobile.Focus()
            FFSendSMS.txtMobile.Enabled = False
            FFSendSMS.txtMessage.Focus()
        Catch ex As Exception
            FFSendSMS = New frmSMSSend()
            FFSendSMS.Show()
            FFSendSMS.BringToFront()

            FFSendSMS.txtMobile.Text = px_pri_mobile(lstContacts.SelectedItems(0).SubItems(7).Text.Trim())
            FFSendSMS.pxToolStrip.Visible = True
            FFSendSMS.pxToolStrip.Text = lstContacts.SelectedItems(0).SubItems(1).Text.Trim()
            FFSendSMS.pxIDToolStrip.Text = "" 'lstContacts.SelectedItems(0).Text.Trim()
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

    Private Sub chCheckAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chCheckAll.CheckedChanged


        If chCheckAll.Checked = True Then

            For Each itm As ListViewItem In lstContacts.Items
                Me.lstContacts.Items(itm.Index).Checked = True
                Application.DoEvents()

            Next

        Else

            For Each itm As ListViewItem In lstContacts.Items
                Me.lstContacts.Items(itm.Index).Checked = False
                Application.DoEvents()

                If itm.Checked Then
                    '_pxMobile = itm.SubItems(7).Text.Trim()
                    'MsgBox(_pxMobile)
                End If
            Next

        End If



    End Sub

    Private Sub SendSMSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendSMSToolStripMenuItem.Click
        Dim _pxMobile As String = ""
        Dim _multiPxMobile As String = ""
        Dim i As Integer = 0
        For Each itm As ListViewItem In lstContacts.Items
            i += 1

            If itm.Checked Then
                _pxMobile = itm.SubItems(7).Text.Trim()
                _multiPxMobile = _multiPxMobile & px_pri_mobile(_pxMobile) & ";"

                If i >= 300 Then
                    Exit For
                End If
            End If

        Next

        Try
            FFNewSMS.Show()
            FFNewSMS.BringToFront()
            FFNewSMS.txtMobile.Text = _multiPxMobile
        Catch ex As Exception
            FFNewSMS = New frmSMSNew()
            FFNewSMS.Show()
            FFNewSMS.BringToFront()
            FFNewSMS.txtMobile.Text = _multiPxMobile
        End Try

    End Sub

    Private Sub cbGroupslst_Click(sender As Object, e As EventArgs) Handles cbGroupslst.Click

    End Sub

    Private Sub cbGroupslst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGroupslst.SelectedIndexChanged

    End Sub
End Class