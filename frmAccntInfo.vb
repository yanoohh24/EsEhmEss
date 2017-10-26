Imports MySql.Data.MySqlClient

Public Class frmAccntInfo

    Private Sub frmAccntInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbVersion.Text = "Version " & Me.GetType.Assembly.GetName.Version.ToString

        lbInformation.Text = "Name: " & ClientName & vbNewLine _
                            & "Username: " & ClientUsername & vbNewLine _
                            & "User Access Group: " & ClientUserAccessGroup & vbNewLine _
                            & "Acount Type: " & AccountType(ClientAccAdmin) & vbNewLine _
                            & "Branch code: " & ClientBranch & vbNewLine _
                            & "Branch name: " & ClientBranchName & vbNewLine _
                            & "Contact number: " & ClientBranchContact & vbNewLine _
                            & "Branch address: " & BranchAddress(ClientBranch)

        lbComputerName.Text = "Computer name: " & ClientHostName & vbNewLine _
                            & "IP address: " & ClientHostIP
    End Sub
    Function AccountType(ByVal AccAdmin As String) As String
        Try
            Select Case AccAdmin.Trim
                Case Is = "1"
                    AccountType = "Admin"
                Case Else
                    AccountType = "User"
            End Select

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Function BranchAddress(ByVal BranchCODE As String) As String
        Try
            Dim query As String = "SELECT address FROM `ref_branch` WHERE code = '" & BranchCODE & "'"
            Dim connection As New MySqlConnection(connStrBMG)
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader
            connection.Open()
            reader = cmd.ExecuteReader()

            If reader.HasRows = True Then
                While reader.Read
                    BranchAddress = reader.Item("address").ToString()
                End While
            Else
                BranchAddress = ""
            End If
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub btOkay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOkay.Click
        Me.Dispose()
    End Sub

End Class