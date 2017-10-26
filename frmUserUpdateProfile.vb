Imports MySql.Data.MySqlClient

Public Class frmUserUpdateProfile
    Function RetriveUserProfile()
        Try

            Dim query As String
            query = "SELECT * FROM user_account_backend WHERE id='" & lbID.Text.Trim & "'"

            Dim connection As New MySqlConnection(connStrBMG)
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader
            connection.Open()
            reader = cmd.ExecuteReader()
            'this will clear the listbox
            If reader.HasRows = True Then
                While reader.Read
                    Me.Text = "Update User Profile: " & reader.Item("username").ToString.Trim()
                    txtName.Text = reader.Item("firstname").ToString.Trim()
                    txtMiddleName.Text = reader.Item("middlename").ToString.Trim()
                    txtSurname.Text = reader.Item("lastname").ToString.Trim()
                    cbUserAccGrp.Text = reader.Item("user_access_group").ToString.Trim()
                End While
            End If
            connection.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Sub frmUserUpdateProfile_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        RetriveUserProfile()
        txtName.SelectionStart = Len(txtName.Text)
    End Sub

    Private Sub btCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancel.Click
        Me.Dispose()
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Dim FirstName As String = Replace(txtName.Text.Trim, "'", "\'")
        Dim MiddleName As String = Replace(txtMiddleName.Text.Trim, "'", "\'")
        Dim LastName As String = Replace(txtSurname.Text.Trim, "'", "\'")
        Dim UserGroup As String = Replace(cbUserAccGrp.Text.Trim, "'", "\'")

        If UpdatePatientInformation("UPDATE user_account_backend SET firstname='" & FirstName & "',middlename='" & MiddleName & "',lastname='" & LastName & "', user_access_group='" & UserGroup & "' WHERE id='" & lbID.Text.Trim & "'") Then
            Me.Dispose()
            MsgBox("User profile successfully updated.", MsgBoxStyle.Information, "User Profile")
        Else
            MsgBox("User Patient profile failed.", MsgBoxStyle.Critical, "User Profile")
        End If
    End Sub
    Function UpdatePatientInformation(ByVal query As String) As Integer
        Try
            Dim rowsEffected As Integer = 0
            Dim connection As New MySqlConnection(connStrBMG)
            Dim cmd As New MySqlCommand(query, connection)

            connection.Open()

            rowsEffected = cmd.ExecuteNonQuery()
            UpdatePatientInformation = rowsEffected
            connection.Close()

            Return rowsEffected
        Catch ex As Exception
            MsgBox(ex.Message)
            Console.WriteLine(ex.Message)
        End Try

    End Function
    Private Sub UserGroupList()
        Try
            Dim i As Integer = 1
            Dim query As String

            query = "SELECT group_name FROM ref_user_access ORDER BY group_name ASC"

            Dim connection As New MySqlConnection(connStrBMG)
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader


            cbUserAccGrp.Text = "All"
            cbUserAccGrp.Items.Clear()

            connection.Open()
            reader = cmd.ExecuteReader()
            If reader.HasRows = True Then
                While reader.Read
                    cbUserAccGrp.Items.Add(reader.Item("group_name").ToString())
                End While
            End If
            cbUserAccGrp.SelectedIndex = 0
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtName.GotFocus
        txtName.SelectionStart = Len(txtName.Text)
    End Sub

    Private Sub txtMiddleName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMiddleName.GotFocus
        txtMiddleName.SelectionStart = Len(txtMiddleName.Text)
    End Sub

    Private Sub txtSurname_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSurname.GotFocus
        txtSurname.SelectionStart = Len(txtSurname.Text)
    End Sub

    Private Sub frmUserUpdateProfile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UserGroupList()
    End Sub
End Class