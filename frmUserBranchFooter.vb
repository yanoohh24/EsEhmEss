Imports MySql.Data.MySqlClient

Public Class frmUserBranchFooter
    Dim ls_id As String
    Dim ls_firstFooter As String
    Dim ls_secondFooter As String
    Dim ls_branchCode As String
    Dim ls_branchName As String

    Private Sub LstColumns()
        lstBranchList.Columns.Clear()
        lstBranchList.Columns.Add("ID", 0)
        lstBranchList.Columns.Add("First Footer", 300)
        lstBranchList.Columns.Add("End Footer", 300)
        lstBranchList.Columns.Add("Branch Code", 80)
        lstBranchList.Columns.Add("Branch Name", 120)
    End Sub
    Private Sub frmUserBranchFooter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtFirstFooter.Text = ""
        txtSecondFooter.Text = ""
        lbID.Text = ""

        LstColumns()
        RetriveSMS()
    End Sub
    Function RetriveSMS()
        Try
            Dim sql As String

            sql = "SELECT id,branch_first_footer,branch_end_footer,branch_code,IFNULL((SELECT NAME FROM `ref_branch` WHERE CODE=branch_code),'') BranchName FROM sms_branch_footer"

            Dim connection As New MySqlConnection(connStrBMG)
            Dim cmd As New MySqlCommand(sql, connection)
            Dim reader As MySqlDataReader
            connection.Open()
            reader = cmd.ExecuteReader()
            'this will clear the listbox
            lstBranchList.Items.Clear()
            If reader.HasRows = True Then
                While reader.Read
                    Dim ls As New ListViewItem(reader.Item("id").ToString())
                    ls.SubItems.Add(reader.Item("branch_first_footer").ToString.Trim())
                    ls.SubItems.Add(reader.Item("branch_end_footer").ToString())
                    ls.SubItems.Add(reader.Item("branch_code").ToString())
                    ls.SubItems.Add(reader.Item("BranchName").ToString())
                    lstBranchList.Items.Add(ls)
                End While
            End If
            connection.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Sub lstBranchList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstBranchList.Click
        On Error Resume Next

        If lstBranchList.Items.Count > 0 Then
            ls_id = lstBranchList.SelectedItems(0).Text
            ls_firstFooter = lstBranchList.SelectedItems(0).SubItems(1).Text.Trim()
            ls_secondFooter = lstBranchList.SelectedItems(0).SubItems(2).Text.Trim()
            ls_branchCode = lstBranchList.SelectedItems(0).SubItems(3).Text.Trim()
            ls_branchName = lstBranchList.SelectedItems(0).SubItems(4).Text.Trim()
            lbID.Text = ls_id
            lbBranchName.Text = ls_branchName
            txtFirstFooter.Text = ls_firstFooter
            txtSecondFooter.Text = ls_secondFooter

        End If
    End Sub

    Private Sub lstBranchList_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstBranchList.GotFocus
        If lstBranchList.Items.Count > 0 Then
            Try
                lstBranchList.Items(lstBranchList.FocusedItem.Index).Selected = True
                lstBranchList.Select()
                lstBranchList_Click(Me, EventArgs.Empty)
            Catch ex As Exception
                lstBranchList.Items(0).Selected = True
                lstBranchList.Select()
                lstBranchList_Click(Me, EventArgs.Empty)
            End Try
        End If
    End Sub

    Private Sub lstBranchList_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstBranchList.KeyUp
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
            lstBranchList_Click(Me, EventArgs.Empty)
        End If
    End Sub

    Private Sub btCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancel.Click
        Me.Dispose()
    End Sub

    Private Sub btUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btUpdate.Click
        Dim sql As String
        Dim _first_footer As String = Replace(txtFirstFooter.Text.Trim, "'", "\'")
        Dim _second_footer As String = Replace(txtSecondFooter.Text.Trim, "'", "\'")

        sql = "UPDATE `sms_branch_footer` SET branch_first_footer='" & _first_footer & "',branch_end_footer='" & _second_footer & "' WHERE id='" & lbID.Text & "'"

        If SMS_Footer_UPDATE(sql) > 0 Then
            txtFirstFooter.Text = ""
            txtSecondFooter.Text = ""

            RetriveSMS()
            MsgBox(lbBranchName.Text & ", footer successfully update.", MsgBoxStyle.Information, "Branch Footer")
        Else
            MsgBox(lbBranchName.Text & ", footer update failed.", MsgBoxStyle.Exclamation, "Branch Footer")
        End If


    End Sub
    Function SMS_Footer_UPDATE(ByVal sql As String) As Integer

        Try
            Dim rowsEffected As Integer = 0
            Dim connection As New MySqlConnection(connStrBMG)
            Dim cmd As New MySqlCommand(sql, connection)

            connection.Open()

            rowsEffected = cmd.ExecuteNonQuery()
            SMS_Footer_UPDATE = rowsEffected
            connection.Close()
            Return rowsEffected
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Sub lstBranchList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstBranchList.SelectedIndexChanged

    End Sub
End Class