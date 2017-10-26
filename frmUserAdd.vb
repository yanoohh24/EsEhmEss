Imports MySql.Data.MySqlClient

Public Class frmUserAdd

    Private Sub frmUserAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtMiddleName.Text = ""
        txtName.Text = ""
        txtSurname.Text = ""
        txtCode.Text = ""

        txtUsername.Text = ""
        txtPassword.Text = ""
        txtPassword2.Text = ""
        combo_Branch_List()
        UserGroupList()
    End Sub
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

    Private Sub btCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancel.Click
        Me.Dispose()
    End Sub

    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click
        Dim sql As String = ""
        Dim _FirstName As String = Replace(txtName.Text.Trim, "'", "\'")
        Dim _MiddleName As String = Replace(txtMiddleName.Text.Trim, "'", "\'")
        Dim _LastName As String = Replace(txtSurname.Text.Trim, "'", "\'")
        Dim _Username As String = Replace(txtUsername.Text.Trim, "'", "\'")
        Dim _Password As String = Replace(txtPassword.Text.Trim, "'", "\'")
        Dim _Password2 As String = Replace(txtPassword2.Text.Trim, "'", "\'")
        Dim _Group As String = Replace(cbUserAccGrp.Text.Trim, "'", "\'")

        If Len(_Username) < 1 Then
            txtUsername.Focus()
            MsgBox("Please enter username", MsgBoxStyle.Information)
            Exit Sub
        End If

        If ResultCountUsername(_Username) > 0 Then
            txtUsername.Focus()
            MsgBox("Username already exist", MsgBoxStyle.Information)
            Exit Sub
        End If

        If Len(_Password) < 1 Then
            txtPassword.Focus()
            MsgBox("Please enter password", MsgBoxStyle.Information)
            Exit Sub
        End If

        If Len(_Password2) < 1 Then
            txtPassword2.Focus()
            MsgBox("Please enter password", MsgBoxStyle.Information)
            Exit Sub
        End If

        If _Password <> _Password2 Then
            txtPassword.Focus()
            txtPassword2.Text = ""
            MsgBox("Password dont match", MsgBoxStyle.Information)
            Exit Sub
        End If

        If Len(_FirstName) < 1 Then
            txtName.Focus()
            MsgBox("Please enter name", MsgBoxStyle.Information)
            Exit Sub
        End If

        sql = "INSERT INTO user_account_backend SET username='" & _Username & "',password='" & _Password & "',firstname='" & _FirstName & "',middlename='" & _MiddleName & "', " _
            & " lastname='" & _LastName & "',branch='" & txtCode.Text.Trim & "',created_by='" & ClientUsername & "',date_created=DATE(NOW()),user_access_group='" & _Group & "'"

        If AddUserAccount(sql) > 0 Then
            MsgBox("User successfully saved", MsgBoxStyle.Information)
            Me.Dispose()
        End If

    End Sub
    Function AddUserAccount(ByVal query As String) As Integer
        Try
            Dim rowsEffected As Integer = 0
            Dim connection As New MySqlConnection(connStrBMG)
            Dim cmd As New MySqlCommand(query, connection)

            connection.Open()

            rowsEffected = cmd.ExecuteNonQuery()
            AddUserAccount = rowsEffected
            connection.Close()

            Return rowsEffected
        Catch ex As Exception
            MsgBox(ex.Message)
            Console.WriteLine(ex.Message)
        End Try

    End Function
    Private Sub combo_Branch_List()
        Try
            Dim i As Integer = 1
            Dim query As String

            query = "SELECT * FROM `ref_branch` WHERE CODE NOT LIKE '00' ORDER BY name ASC"


            Dim connection As New MySqlConnection(connStrBMG)
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader


            cbBranch.Text = "[Branch]"
            cbBranch.Items.Clear()

            connection.Open()
            reader = cmd.ExecuteReader()
            If reader.HasRows = True Then
                While reader.Read
                    cbBranch.Items.Add(reader.Item("name").ToString())
                End While
            End If
            cbBranch.SelectedIndex = 0
            connection.Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub
    Function BranchDatabaseName(ByVal BranchName As String) As String
        Try

            Dim query As String = "SELECT * FROM `ref_branch` WHERE NAME LIKE '%" & BranchName & "%'"
            Dim connection As New MySqlConnection(connStrBMG)
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader
            connection.Open()
            reader = cmd.ExecuteReader()


            If reader.HasRows = True Then
                While reader.Read
                    txtCode.Text = reader.Item("code").ToString()
                End While
            Else
                txtCode.Text = ""
            End If
            connection.Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Function
    Function ResultCountUsername(ByVal username As String) As String
        Try
            Dim _Username As String = Replace(txtUsername.Text.Trim, "'", "\'")
            Dim query As String
            query = "SELECT COUNT(username) ctUsrname FROM `user_account_backend` WHERE username LIKE '" & _Username & "'"

            Dim connection As New MySqlConnection(connStrBMG)
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader
            connection.Open()
            reader = cmd.ExecuteReader()

            If reader.HasRows = True Then
                While reader.Read
                    ResultCountUsername = reader.Item("ctUsrname").ToString()
                End While
            Else
                ResultCountUsername = "0"
            End If
            connection.Close()
        Catch ex As Exception
            ResultCountUsername = "0"
            MsgBox(ex.Message)
        End Try
    End Function
    Private Sub cbBranch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbBranch.SelectedIndexChanged
        BranchDatabaseName(cbBranch.Text.Trim)
    End Sub
End Class