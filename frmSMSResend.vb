Imports MySql.Data.MySqlClient

Public Class frmSMSResend

    Private Sub btClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btClose.Click
        Me.Dispose()
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
        Dim SMSMsg As String = txtMessage.Text.Trim

        If lbInvalid.Visible = True Then
            MsgBox("Please enter correct mobile number.", MsgBoxStyle.Information, "Invalid mobile number")
            txtMobile.Focus()
            Exit Sub
        End If

        messages_sms_out(SMSMsg, pxIDToolStrip.Text.Trim, SMSMobile)
        CommandXpertSMS(SMSMsg, 0, pxIDToolStrip.Text.Trim, SMSMobile)
        Me.Dispose()

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
        Dim sql As String = ""
        Dim _DeptKey As String = FFMain.KeyToolStrip.Text.Trim

        sms_body = Replace(sms_body, "'", "\'")

        Try
            sql = "INSERT INTO `messages_sms` SET Direction=2, sender='" & sms_sender & "',body='" & sms_body & "',branch='" & _DeptKey & "', PatientID='" & px_id & "',Username='" & ClientUsername & "', " _
                & " UserHostName='" & ClientHostName & "',UserHostIP='" & ClientHostIP & "', Read_Stats='1',DeptKey='" & _DeptKey & "', user_access_group='" & ClientUserAccessGroup & "'"

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

    Private Sub txtMessage_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtMessage.MouseUp
        TxtLenghtToolStrip.Text = "Lenght : " & Len(txtMessage.Text)
    End Sub

    Private Sub frmSMSResend_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        FFMain.AsDeptFooters()
    End Sub

    Private Sub frmSMSResend_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FFMain.AsDeptFooters()
    End Sub
End Class