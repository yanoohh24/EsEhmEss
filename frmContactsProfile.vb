Imports MySql.Data.MySqlClient

Public Class frmContactsProfile
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
    Private Sub btCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancel.Click
        Me.Dispose()
    End Sub

    Private Sub frmContactsProfile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Combo_GroupName_List()
    End Sub
    Function RetriveUserProfile()
        Try

            Dim query As String
            query = "SELECT * FROM `sms_contacts` WHERE id='" & lbID.Text.Trim & "'"

            Dim connection As New MySqlConnection(connStrSMS)
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader
            connection.Open()
            reader = cmd.ExecuteReader()
            'this will clear the listbox
            If reader.HasRows = True Then
                While reader.Read
                    txtName.Text = reader.Item("firstname").ToString.Trim()
                    txtLastName.Text = reader.Item("lastname").ToString.Trim()
                    txtMiddleName.Text = reader.Item("middlename").ToString.Trim()
                    txtAddress.Text = reader.Item("address").ToString.Trim()
                    txtTelephone.Text = reader.Item("telephone").ToString.Trim()
                    txtMobile.Text = reader.Item("mobile").ToString.Trim()
                    txtEmail.Text = reader.Item("email").ToString.Trim()
                    txtCompany.Text = reader.Item("company").ToString.Trim()
                    cbGroups.Text = reader.Item("sms_group").ToString.Trim()
                End While
            End If
            connection.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
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

    Private Sub frmContactsProfile_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        RetriveUserProfile()
    End Sub

    Private Sub btUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btUpdate.Click
        Dim sql As String
        firstname = Replace(txtName.Text.Trim, "'", "\'")
        lastname = Replace(txtLastName.Text.Trim, "'", "\'")
        middlename = Replace(txtMiddleName.Text.Trim, "'", "\'")
        address = Replace(txtAddress.Text.Trim, "'", "\'")
        telephone = Replace(txtTelephone.Text.Trim, "'", "\'")
        mobile = Replace(txtMobile.Text.Trim, "'", "\'")
        email = Replace(txtEmail.Text.Trim, "'", "\'")
        company = Replace(txtCompany.Text.Trim, "'", "\'")
        sms_group = Replace(cbGroups.Text.Trim, "'", "\'")

        If Len(firstname) < 1 Then
            txtName.Text = txtName.Text.Trim
            txtName.Focus()
            MsgBox("Please enter Name")
            Exit Sub
        End If

        If cbGroups.SelectedIndex < 1 Then
            sms_group = ""
        Else
            sms_group = Replace(cbGroups.Text.Trim, "'", "\'")
        End If

        sql = "UPDATE `sms_contacts` SET firstname='" & firstname & "',lastname='" & lastname & "',middlename='" & middlename & "',address='" & address & "', " _
            & " telephone='" & telephone & "',mobile='" & mobile & "',email='" & email & "',company='" & company & "',sms_group='" & sms_group & "',created_by='" & ClientUsername & "' WHERE id='" & lbID.Text.Trim & "'"

        If Update_contact_person(sql) > 0 Then
            Me.Hide()
            MsgBox("Contacts successfully saved.")
            Me.Dispose()
        End If
    End Sub
    Function Update_contact_person(ByVal sql As String) As Integer
        Try
            Dim rowsEffected As Integer = 0
            Dim connection As New MySqlConnection(connStrBMG)
            Dim cmd As New MySqlCommand(sql, connection)

            connection.Open()

            rowsEffected = cmd.ExecuteNonQuery()
            Update_contact_person = rowsEffected
            connection.Close()

            Return rowsEffected

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
End Class