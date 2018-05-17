Imports MySql.Data.MySqlClient

Public Class frmSMSReply
    Dim _Cid As String
    Dim _Ctemplate As String
    Public Sub Retrive_SMS_TEMPLATE()
        Try
            Dim query As String
            Dim i As Integer = 0
            query = "SELECT * FROM sms_template WHERE user_access_group LIKE '" & ClientUserAccessGroup & "'"

            Dim connection As New MySqlConnection(connStrBMG)
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader
            connection.Open()
            reader = cmd.ExecuteReader()
            'this will clear the listbox
            lsTemplate.Items.Clear()

            If reader.HasRows = True Then
                While reader.Read
                    i += 1
                    Dim ls As New ListViewItem(reader.Item("id").ToString.Trim())
                    ls.SubItems.Add(i)
                    ls.SubItems.Add(reader.Item("template").ToString.Trim())
                    lsTemplate.Items.Add(ls)
                End While
            End If
            connection.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub HeaderTemplate()
        lsTemplate.Columns.Clear()
        lsTemplate.Columns.Add("ID", 0)
        lsTemplate.Columns.Add("NO", 30)
        lsTemplate.Columns.Add("Message", 310)
    End Sub
    Private Sub btClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btClose.Click
        Me.Dispose()

        ReloadSMS()

    End Sub
    Private Sub ReloadSMS()
        If FFPatientsSMS.Visible = True Then
            FFPatientsSMS.cbViewBy_SelectedIndexChanged(Me, EventArgs.Empty)
        End If
    End Sub

    Private Sub frmSMSReply_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ReloadSMS()
    End Sub
    Private Sub frmReplySMS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtMessage.Text = ""
        lbUsernameAndBranchname.Text = UserAndBranchName
        TxtLenghtToolStrip.Text = "Lenght : " & Len(txtMessage.Text)
    End Sub

    Private Sub txtMessage_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMessage.KeyDown
        TxtLenghtToolStrip.Text = "Lenght : " & Len(txtMessage.Text)
    End Sub

    Private Sub txtMessage_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMessage.KeyUp
        If e.KeyCode = Keys.F5 Then
            btSend_Click(Me, EventArgs.Empty)
        End If

        TxtLenghtToolStrip.Text = "Lenght : " & Len(txtMessage.Text)
    End Sub

    Private Sub btSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSend.Click
        Dim SMSMobile As String = Replace(txtMobile.Text.Trim, "'", "")
        Dim SMSMsg As String = txtMessage.Text.Trim & vbNewLine & vbNewLine & FooterSMS

        If lbInvalid.Visible = True Then
            MsgBox("Please enter correct mobile number.", MsgBoxStyle.Information, "Invalid mobile number")
            txtMobile.Focus()
            Exit Sub
        End If

        messages_sms_out(SMSMsg, pxIDToolStrip.Text.Trim, SMSMobile)        'Belo_Database (Messages_SMS)
        CommandXpertSMS(SMSMsg, 0, pxIDToolStrip.Text.Trim, SMSMobile)      'Messages ( Database : Messages )

        Me.Dispose()
        ReloadSMS()

    End Sub

    Private Sub txtMobile_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMobile.GotFocus
        txtMobile.SelectionStart = Len(txtMobile.Text)
    End Sub

    Private Sub txtMobile_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMobile.LostFocus
        Dim StrMobile As String
        Select Case Mid(Replace(txtMobile.Text.Trim, ".", ""), 1, 2)
            Case "09"
                If Len(txtMobile.Text.Trim) = 11 Then
                    StrMobile = Mid(txtMobile.Text.Trim, 2, 10)
                    txtMobile.Text = "+63" & StrMobile
                    txtMobile.ForeColor = Color.Black
                    lbInvalid.Visible = False
                Else
                    lbInvalid.Visible = True
                    txtMobile.ForeColor = Color.Red
                End If
            Case "63"
                If Len(txtMobile.Text.Trim) = 12 Then
                    StrMobile = Mid(txtMobile.Text.Trim, 1, 12)
                    txtMobile.Text = "+" & StrMobile
                    txtMobile.ForeColor = Color.Black
                    lbInvalid.Visible = False
                Else
                    lbInvalid.Visible = True
                    txtMobile.ForeColor = Color.Red
                End If
            Case Else
                Select Case Mid(txtMobile.Text.Trim, 1, 3)
                    Case "+63"
                        If Len(txtMobile.Text.Trim) = 13 Then
                            StrMobile = Mid(txtMobile.Text.Trim, 1, 13)
                            txtMobile.Text = StrMobile
                            txtMobile.ForeColor = Color.Black
                            lbInvalid.Visible = False
                        Else
                            lbInvalid.Visible = True
                            txtMobile.ForeColor = Color.Red
                        End If
                    Case Else
                        lbInvalid.Visible = True
                        txtMobile.ForeColor = Color.Red
                End Select
        End Select

        If Len(txtMobile.Text.Trim) = 0 Then
            lbInvalid.Text = "Please enter mobile number"
        Else
            lbInvalid.Text = "Invalid mobile number"
        End If

        txtMobile.Text = txtMobile.Text.Trim

    End Sub

    Function messages_sms_out(ByVal sms_body As String, ByVal px_id As String, ByVal sms_sender As String) As Integer
        Try
            Dim sql As String = ""
            Dim _DeptKey As String = FFMain.KeyToolStrip.Text.Trim
            Dim MBchk As String = sms_sender
            MBchk = Mid(MBchk, 1, 4)
            sms_body = Replace(sms_body, "'", "\'")

            If MBchk = "+639" Then

                sql = "INSERT INTO `messages_sms` SET Direction=2, sender='" & sms_sender & "',body='" & sms_body & "',branch='" & _DeptKey & "', PatientID='" & px_id & "',Read_Stats='1', " _
                    & " DeptKey='" & _DeptKey & "', Username='" & ClientUsername & "', UserHostName='" & ClientHostName & "', UserHostIP='" & ClientHostIP & "', user_access_group='" & ClientUserAccessGroup & "'"

                Dim rowsEffected As Integer = 0
                Dim connection As New MySqlConnection(connStrBMG)
                Dim cmd As New MySqlCommand(sql, connection)

                connection.Open()
                rowsEffected = cmd.ExecuteNonQuery()
                connection.Close()

                Return rowsEffected
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Sub txtMessage_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtMessage.MouseUp
        TxtLenghtToolStrip.Text = "Lenght : " & Len(txtMessage.Text)
    End Sub

    Private Sub frmSMSReply_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        FFMain.AsDeptFooters()
    End Sub

    Private Sub ShowTemplateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowTemplateToolStripMenuItem.Click
        If ShowTemplateToolStripMenuItem.Text = "Show Template" Then
            ShowTemplateToolStripMenuItem.Text = "Hide Template"
            lsTemplate.TabStop = True
            Me.Size = New System.Drawing.Size(891, 352)
            HeaderTemplate()

            Retrive_SMS_TEMPLATE()
        Else
            lsTemplate.TabStop = False
            ShowTemplateToolStripMenuItem.Text = "Show Template"
            Me.Size = New System.Drawing.Size(500, 352)
        End If
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub lsTemplate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsTemplate.Click
        On Error Resume Next

        If lsTemplate.Items.Count > 0 Then
            _Cid = lsTemplate.SelectedItems(0).Text.Trim()
            _Ctemplate = lsTemplate.SelectedItems(0).SubItems(2).Text.Trim()
            TxtLenghtToolStrip.Text = "Lenght : " & Len(_Ctemplate)
            txtMessage.Text = _Ctemplate
        End If
    End Sub

    Private Sub SaveAsTemplateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsTemplateToolStripMenuItem.Click
        Dim sql As String
        Dim _template As String = Replace(txtMessage.Text.Trim, "'", "\'")

        HeaderTemplate()

        If Len(_template) < 1 Then
            txtMessage.Focus()
            MsgBox("Please enter message to save template", MsgBoxStyle.Information)
            Exit Sub
        End If

        If MsgBox("Save this message as template?", vbYesNo, "Template") = vbNo Then
            txtMessage.Focus()
            Exit Sub
        End If

        sql = "INSERT sms_template SET template='" & _template & "',created_by='" & ClientUsername & "',department_key='" & ClientDepartmentKey & "',user_access_group='" & ClientUserAccessGroup & "'"
        If SaveTemplate(sql) > 0 Then

            txtMessage.Text = ""
            Retrive_SMS_TEMPLATE()

            'Show Templates
            ShowTemplateToolStripMenuItem.Text = "Hide Template"
            lsTemplate.TabStop = True
            Me.Size = New System.Drawing.Size(891, 352)
            HeaderTemplate()
            'End show Template

            MsgBox("Message successfully saved", MsgBoxStyle.Information, "Template")
        End If
    End Sub
    Function SaveTemplate(ByVal query As String) As Integer
        Try
            Dim rowsEffected As Integer = 0
            Dim connection As New MySqlConnection(connStrBMG)
            Dim cmd As New MySqlCommand(query, connection)

            connection.Open()

            rowsEffected = cmd.ExecuteNonQuery()
            SaveTemplate = rowsEffected
            connection.Close()

            Return rowsEffected
        Catch ex As Exception
            MsgBox(ex.Message)
            Console.WriteLine(ex.Message)
        End Try

    End Function

    Private Sub lsTemplate_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lsTemplate.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ContextMenuSMSSetting.Show(lsTemplate, e.Location)
        End If
    End Sub


    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        If MsgBox("Delete Template", vbYesNo, "Template") = MsgBoxResult.Yes Then
            Delete_SMS_TEMPLATE(_Cid)
            Retrive_SMS_TEMPLATE()
        End If
    End Sub
    Function Delete_SMS_TEMPLATE(ByVal id As String)
        Try
            Dim query As String
            query = "DELETE FROM sms_template WHERE id= '" & id & "'"

            Dim rowsEffected As Integer = 0
            Dim connection As New MySqlConnection(connStrBMG)
            Dim cmd As New MySqlCommand(query, connection)

            connection.Open()

            rowsEffected = cmd.ExecuteNonQuery()
            Delete_SMS_TEMPLATE = rowsEffected
            connection.Close()

            Return rowsEffected
        Catch ex As Exception
            MsgBox(ex.Message)
            Console.WriteLine(ex.Message)
        End Try

    End Function

    Private Sub lsTemplate_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsTemplate.SelectedIndexChanged

    End Sub
End Class