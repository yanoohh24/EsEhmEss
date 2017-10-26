
Imports MetroFramework
Imports MetroFramework.Controls
Imports MySql.Data.MySqlClient

Public Class frmEmployee
    Dim Emp_id As String = ""
    Dim query As String = ""
    Dim stat As Integer
    Dim ismanager As Integer
    Dim isinput As Boolean = False
    Dim gvIsclicked As Boolean = False
    Function UPdate_Save_info(ByVal query As String)
        Dim sql As String = query

        Try
            Dim rowsEffected As Integer = 0
            Dim connection As New MySqlConnection(connStrBMG)
            Dim cmd As New MySqlCommand(sql, connection)

            connection.Open()

            rowsEffected = cmd.ExecuteNonQuery()

            connection.Close()

            Return rowsEffected
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Sub frmEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Employee_list(False)
        UserGroup()

    End Sub
    Public Sub Clear_Fields()
        ls.clear()
        Emp_id = ""
        isinput = False
        txtFname.Clear()
        txtLname.Clear()
        txtMname.Clear()
        txtMObile.Clear()
        txtEmpid.Clear()
        txtPOsition.Clear()
        dtBirthdate.Text = ""
        cbBranch.Text = ""
        cbStatus.Checked = False
        cbManager.Checked = False
    End Sub
    Public Sub UserGroup()
        query = "SELECT DISTINCT(branch) FROM ref_employee ORDER BY branch ASC"

        Dim connection As New MySqlConnection(connStrBMG)
        Dim cmd As New MySqlCommand(query, connection)
        Dim reader As MySqlDataReader

        connection.Open()
        reader = cmd.ExecuteReader()

        If reader.HasRows = True Then
            While reader.Read
                cbBranch.Items.Add(reader.Item("branch").ToString())
            End While
        End If
    End Sub

    Public Sub Employee_list(isSearch As Boolean)
        If isSearch = False Then
            query = "SELECT customer_number as employee_id,lastname,firstname,middlename,mobileNo,birthDate,branch,position,Department,isdeptHead,isResigned FROM ref_employee ORDER BY lastname ASC limit 100"
        Else
            query = "SELECT customer_number as employee_id,lastname,firstname,middlename,mobileNo,birthDate,Department,branch,position,isdeptHead,isResigned FROM ref_employee where firstname like '" & txtFilter.Text & "%'  or lastname like '" & txtFilter.Text & "%' or customer_number like '" & txtFilter.Text & "%'  ORDER BY lastname ASC limit 100"
        End If


        Dim connection As New MySqlConnection(connStrBMG)
        Dim cmd As New MySqlCommand(query, connection)
        Dim reader As MySqlDataReader

        connection.Open()
        reader = cmd.ExecuteReader()
        Dim dt As New DataTable
        dt.Load(reader)

        dgEmployee.DataSource = dt
        lblRersult.Text = String.Format("Result : {0}", dgEmployee.RowCount)
        dgEmployee.Columns("Department").Visible = False
        dgEmployee.Columns("isResigned").Visible = False
        dgEmployee.Columns("middlename").Visible = False
        dgEmployee.Columns("isdeptHead").Visible = False
    End Sub

    Sub setError(txtBox As MetroTextBox, msg As String)
        ep.SetError(txtBox, msg)
    End Sub

    Sub promt_error(txt_box As MetroTextBox)
        Dim txtbox As MetroTextBox = txt_box
        If String.IsNullOrEmpty(txtbox.Text) Then
            setError(txtbox, "Please provide this field")

            Exit Sub
        End If

        setError(txtbox, "")
    End Sub

    Dim ls = New List(Of String)

    Private Sub dgEmployee_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgEmployee.RowHeaderMouseClick
        On Error Resume Next

        Clear_Fields()
        cbStatus.Enabled = True
        gvIsclicked = True
        With dgEmployee.CurrentRow

            isinput = True
            txtFname.Text = String.Format("{0}", .Cells("firstname").Value).Trim()
            txtLname.Text = String.Format("{0}", .Cells("lastname").Value).Trim()
            txtMname.Text = String.Format("{0}", .Cells("middlename").Value).Trim()
            txtMObile.Text = String.Format("{0}", .Cells("mobileNo").Value).Trim()
            txtEmpid.Text = String.Format("{0}", .Cells("employee_id").Value).Trim()
            dtBirthdate.Text = String.Format("{0}", .Cells("birthDate").Value).Trim()
            cbBranch.Text = String.Format("{0}", .Cells("branch").Value).Trim()
            txtPOsition.Text = String.Format("{0}", .Cells("position").Value).Trim()
            Emp_id = txtEmpid.Text
            Dim _isResigned As String = .Cells("isResigned").Value.ToString()
            Dim _isManager As String = .Cells("isdeptHead").Value.ToString()

            If _isResigned = 0 Then
                cbStatus.Checked = False
            Else
                cbStatus.Checked = True
            End If

            If _isManager = 0 Then
                cbManager.Checked = False
            Else
                cbManager.Checked = True
            End If

            ls.Add(txtFname.Text.Trim())
            ls.Add(txtLname.Text.Trim())
            ls.Add(txtMname.Text.Trim())
            ls.Add(txtMObile.Text.Trim())
            ls.Add(txtEmpid.Text.Trim())
            ls.Add(dtBirthdate.Text.Trim())
            ls.Add(cbBranch.Text.Trim())
            ls.Add(_isManager.Trim())
            ls.Add(_isResigned.Trim())
            ls.Add(txtPOsition.Text.Trim())


            ls.toarray()

        End With
        save_update()
    End Sub
#Region "validations"
    Sub save_update()

        If isinput = True Then
            On Error Resume Next
            If txtFname.Text.Trim() <> ls(0) _
               Or txtLname.Text.Trim() <> ls(1) _
               Or txtMname.Text.Trim() <> ls(2) _
              Or txtEmpid.Text.Trim() <> ls(4) _
               Or dtBirthdate.Text.Trim() <> ls(5) _
               Or cbBranch.Text.Trim() <> ls(6) _
               Or ismanager <> ls(7) _
               Or stat <> ls(8) _
               Or txtPOsition.Text.Trim <> ls(9) Then

                btnSaveUpdate.Text = "Update"
                btnSaveUpdate.Enabled = True
            Else
                btnSaveUpdate.Enabled = False
            End If

        End If
        If gvIsclicked = False Then
            Check_Fields()
        End If
    End Sub

    Public Function CheckDate()
        Dim BDAY As DateTime = dtBirthdate.Text
        Dim convBdaytostring As String = BDAY.ToString("yyyy-MM-dd")

        Dim datetoday As String = Now.Date.ToString("yyyy-MM-dd")

        If convBdaytostring = datetoday Then
            MsgBox("Please check date!")
            Return False
        End If
        Return True
    End Function
    Public Sub Check_Fields()
        If String.IsNullOrEmpty(txtEmpid.Text) _
            Or String.IsNullOrEmpty(txtLname.Text) _
            Or String.IsNullOrEmpty(txtFname.Text) _
            Or String.IsNullOrEmpty(cbBranch.Text) _
           Or String.IsNullOrEmpty(txtPOsition.Text) _
         Then
            btnSaveUpdate.Enabled = False
            Exit Sub
        End If
        btnSaveUpdate.Enabled = True
    End Sub
#End Region

    Sub Text_change()
        btnSaveUpdate.Text = "Save"
        cbStatus.Enabled = False
        btnSaveUpdate.Enabled = False
    End Sub
#Region "text change"


    Private Sub txtEmpid_TextChanged(sender As Object, e As EventArgs) Handles txtEmpid.TextChanged
        Check_Fields()
        save_update()
    End Sub


    Private Sub txtLname_TextChanged(sender As Object, e As EventArgs) Handles txtLname.TextChanged
        save_update()
    End Sub

    Private Sub txtFname_TextChanged(sender As Object, e As EventArgs) Handles txtFname.TextChanged
        save_update()
    End Sub

    Private Sub txtMObile_TextChanged(sender As Object, e As EventArgs) Handles txtMObile.TextChanged
        save_update()
    End Sub

    Private Sub dtBirthdate_ValueChanged(sender As Object, e As EventArgs) Handles dtBirthdate.ValueChanged
        save_update()
    End Sub

    Private Sub cbDept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBranch.SelectedIndexChanged
        save_update()
    End Sub

    Private Sub txtMname_TextChanged(sender As Object, e As EventArgs) Handles txtMname.TextChanged
        save_update()
    End Sub
    Private Sub txtPOsition_TextChanged(sender As Object, e As EventArgs) Handles txtPOsition.TextChanged
        save_update()
    End Sub
#End Region

    Private Sub MetroTextButton2_Click(sender As Object, e As EventArgs) Handles MetroTextButton2.Click
        gvIsclicked = False
        txtFilter.Clear()
        Clear_Fields()
        Text_change()
    End Sub

    Function CheckEmployee(query)

        Dim connection As New MySqlConnection(connStrBMG)
        Dim cmd As New MySqlCommand(query, connection)
        Dim reader As MySqlDataReader

        connection.Open()
        reader = cmd.ExecuteReader()

        If reader.HasRows = True Then
            Return True
        End If
        Return False
    End Function
    Private Sub MetroTextButton1_Click(sender As Object, e As EventArgs) Handles btnSaveUpdate.Click
        If checkEmployee("select * from ref_employee where customer_number = '" & txtEmpid.Text & "'") = True  and btnSaveUpdate.Text = "Save"Then
            MsgBox("Employee id already exist!", MsgBoxStyle.Information)
            Exit Sub
        End If

        If CheckDate() = False Then
            Exit Sub
        End If
        If btnSaveUpdate.Text = "Save" Then
            UPdate_Save_info("insert into ref_employee set customer_number = '" & txtEmpid.Text.Trim() & "',lastname = '" & txtLname.Text.Trim() & "',firstname = '" & txtFname.Text.Trim() & "',middlename = '" & txtMname.Text.Trim() & "',mobileNo = '" & txtMObile.Text.Trim() & "',birthDate = '" & dtBirthdate.Text.Trim() & "',branch = '" & cbBranch.Text.Trim() & "',isdeptHead = '" & ismanager & "',position = '" & Replace(txtPOsition.Text, "'", "") & "'")
            MsgBox("Saved Successfully!", MsgBoxStyle.Information)
        Else
            UPdate_Save_info("update ref_employee set customer_number = '" & txtEmpid.Text.Trim() & "',lastname = '" & txtLname.Text.Trim() & "',firstname = '" & txtFname.Text.Trim() & "',middlename = '" & txtMname.Text.Trim() & "',mobileNo = '" & txtMObile.Text.Trim() & "',birthDate = '" & dtBirthdate.Text.Trim() & "',branch = '" & cbBranch.Text.Trim() & "',isdeptHead = '" & ismanager & "',isResigned = '" & stat & "',position = '" & Replace(txtPOsition.Text, "'", "") & "' where customer_number = '" & Emp_id & "'")
            MsgBox("Update Successfull!", MsgBoxStyle.Information)
        End If
        gvIsclicked = False
        txtFilter.Clear()
        Clear_Fields()
        Text_change()
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Select Case keyData
            Case Keys.F1
                MetroTextButton1.Visible = True
            Case Keys.Escape
                MetroTextButton1.Visible = False
          
            Case Else
                Return MyBase.ProcessCmdKey(msg, keyData)
        End Select
        Return True
    End Function
    Private Sub cbStatus_CheckedChanged(sender As Object, e As EventArgs) Handles cbStatus.CheckedChanged
        If cbStatus.Checked = True Then
            stat = "1"
        Else
            stat = "0"
        End If
        save_update()
    End Sub

    Private Sub cbManager_CheckedChanged(sender As Object, e As EventArgs) Handles cbManager.CheckedChanged
        If cbManager.Checked = True Then
            ismanager = "1"
        Else
            ismanager = "0"
        End If
        save_update()
    End Sub

    Private Sub txtFilter_TextChanged(sender As Object, e As EventArgs) Handles txtFilter.TextChanged
        Employee_list(True)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim bm As New Bitmap(Width, Height)
        DrawToBitmap(bm, New Rectangle(0, 0, Width, Height))
        Dim name As String = InputBox("Name it:")
        bm.Save("C:\Users\User\Documents\checklist\" & name & ".png", System.Drawing.Imaging.ImageFormat.Png)
        MsgBox("click")
    End Sub

    
    Private Sub MetroTextButton1_Click_1(sender As Object, e As EventArgs) Handles MetroTextButton1.Click
        If gvIsclicked = True Then
            Dim msg = MsgBox("do you want to delete this record?", MsgBoxStyle.YesNo + MsgBoxStyle.Question)
            If msg = vbYes Then
                UPdate_Save_info("delete from ref_employee where customer_number = '" & Emp_id & "'")
                Clear_Fields()
                Employee_list(False)
                Text_change()
            End If
            Exit Sub
        End If
        MsgBox("No selected record", MsgBoxStyle.Information)
       End Sub
End Class