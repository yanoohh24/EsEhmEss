Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class frmPatientProfile

    Function RetriveSMS()
        Try
            'REMOVED MOBILE 2 & 3
            Dim query As String
            'query = "SELECT firstname,middlename,lastname,MONTH(birthday) Bmm,DAY(birthday) Bdd,YEAR(birthday) Byyy,telephone,mobile,mobile2,mobile3,marital_status,gender, " _
            '    & " CONCAT(local_street,' ',local_subdivision,' ', local_city,' ', local_country) address,email FROM `patient_info` WHERE PatientID='" & lbPxID.Text.Trim & "'"
            
            query = "SELECT first_name,middle_name,last_name,MONTH(birthday) Bmm,DAY(birthday) Bdd,YEAR(birthday) Byyy,telephone_number,mobile_number,marital_status,gender, " _
            & " CONCAT(IFNULL(house_number,''),' ',IFNULL(street,''),' ',IFNULL(subdivision,''),' ',IFNULL(city,''),' ', IFNULL(country,'')) address," _
            & " email_address FROM `patient` WHERE Patient_ID='" & lbPxID.Text.Trim & "'"

            Dim connection As New MySqlConnection(connStrSMS)
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader
            connection.Open()
            reader = cmd.ExecuteReader()
            'this will clear the listbox
            If reader.HasRows = True Then
                While reader.Read
                    Dim BirthdayYear As Integer = reader.Item("Byyy").ToString()

                    txtName.Text = reader.Item("first_name").ToString.Trim()
                    txtMiddleName.Text = reader.Item("middle_name").ToString.Trim()
                    txtSurname.Text = reader.Item("last_name").ToString.Trim()
                    txtStatus.Text = reader.Item("marital_status").ToString.Trim()
                    txtGender.Text = reader.Item("gender").ToString.Trim()
                    txtAddress.Text = reader.Item("address").ToString.Trim()
                    txtTel.Text = reader.Item("telephone_number").ToString.Trim()
                    txtMobile.Text = reader.Item("mobile_number").ToString.Trim()
                    'txtMobile2.Text = reader.Item("mobile2").ToString.Trim()
                    'txtMobile3.Text = reader.Item("mobile3").ToString.Trim()
                    txtEmail.Text = reader.Item("email_address").ToString.Trim()


                    If BirthdayYear < 1 Then
                        cbYear.SelectedIndex = 0
                        cbMonth.SelectedIndex = 0
                        cbDay.SelectedIndex = 0

                        cbDay.Enabled = False
                        cbMonth.Enabled = False
                        cbYear.Enabled = False
                        chBirthday.Checked = False
                    Else
                        cbYear.Text = reader.Item("Byyy").ToString
                        cbMonth.SelectedIndex = reader.Item("Bmm").ToString
                        cbDay.SelectedIndex = reader.Item("Bdd").ToString

                        cbDay.Enabled = True
                        cbMonth.Enabled = True
                        cbYear.Enabled = True
                        chBirthday.Checked = True
                    End If

                End While
            End If
            connection.Close()
            txtName.SelectionStart = Len(txtName.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Sub frmPatientProfile_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        RetriveSMS()
    End Sub

    Private Sub txtName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtName.GotFocus
        txtName.SelectionStart = Len(txtName.Text)
    End Sub

    Private Sub btCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancel.Click
        Me.Dispose()
    End Sub

    Private Sub txtTel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTel.KeyPress
        'There are a couple scenerios this code is looking for. One is checking for the Decimal period "."
        'and whether it exists in the textbox already. The other is seeing if the keypress was a Number and
        'Control based key
        If e.KeyChar = "." Then
            'If a value higher than -1 is returned, it means there IS a existing decimal point’
            If txtTel.Text.IndexOf(".") > -1 Then
                'This says that I already dealt with the _KeyPress event so do not do anything else with this event.
                e.Handled = True
            End If
            'Remember you want numbers to get through and the Control keys like “Backspace”
        ElseIf Char.IsNumber(e.KeyChar) = False AndAlso Char.IsControl(e.KeyChar) = False Then
            'This says that I already dealt with the _KeyPress event so do not do anything else with this event.
            e.Handled = True
        End If
    End Sub

    Private Sub txtMobile_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMobile.KeyPress
        If Char.IsNumber(e.KeyChar) = False AndAlso Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtMobile2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMobile2.KeyPress
        If Char.IsNumber(e.KeyChar) = False AndAlso Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtMobile3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMobile3.KeyPress
        If Char.IsNumber(e.KeyChar) = False AndAlso Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub
    Private Sub combo_Year()
        Dim i As Integer = 1960
        Dim y As Integer = Format(Now().AddYears(-2), "yyyy")
        Dim yy As Integer = y
        cbYear.Items.Add("Year")
        For i = 1900 To y
            yy -= 1
            cbYear.Items.Add(yy)
        Next
    End Sub
    Private Sub combo_Day()
        Dim i As Integer = 1
        cbDay.Items.Add("Day")
        For i = 1 To 31
            cbDay.Items.Add(Format(i, "00"))
        Next
    End Sub
    Private Sub frmPatientProfile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbEmailValidate.Text = ""
        combo_Day()
        combo_Year()

        cbDay.SelectedIndex = 0
        cbMonth.SelectedIndex = 0
        cbYear.SelectedIndex = 0
        cbDay.Enabled = False
        cbMonth.Enabled = False
        cbYear.Enabled = False

    End Sub

    Private Sub txtEmail_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmail.GotFocus
        lbEmailValidate.Text = ""
        txtEmail.SelectionStart = 0 
        txtEmail.SelectionLength = Len(txtEmail.Text)
        txtEmail.SelectAll()
    End Sub

    Private Sub txtEmail_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEmail.KeyPress
        Dim ac As String = "@"
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
                If Asc(e.KeyChar) <> 46 And Asc(e.KeyChar) <> 95 Then
                    If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                        If ac.IndexOf(e.KeyChar) = -1 Then
                            e.Handled = True

                        Else
                            If txtEmail.Text.Contains("@") And e.KeyChar = "@" Then
                                e.Handled = True
                            End If

                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtemailid_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEmail.Validating

        Dim pattern As String = "^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z][a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$"

        If Len(txtEmail.Text.Trim) < 1 Then
            Exit Sub
        End If

        Dim match As System.Text.RegularExpressions.Match = Regex.Match(txtEmail.Text.Trim(), pattern, RegexOptions.IgnoreCase)
        If (match.Success) Then
            lbEmailValidate.Text = "Valid Email"
            lbEmailValidate.ForeColor = Color.Green
        Else
            lbEmailValidate.Text = "Invalid Email"
            lbEmailValidate.ForeColor = Color.DarkRed
        End If
    End Sub

    Private Sub txtEmail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmail.TextChanged

    End Sub

    Private Sub btUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btUpdate.Click
        If UpdatePatientInformation(lbPxID.Text.Trim) > 0 Then
            Me.Dispose()
            MsgBox("Patient profile successfully updated.", MsgBoxStyle.Information, "Patient Profile")
        Else
            MsgBox("Update Patient profile failed.", MsgBoxStyle.Critical, "Patient Profile")
        End If
    End Sub
    Function UpdatePatientInformation(ByVal id As String) As Integer
        Try
            Dim tel As String = Replace(txtTel.Text.Trim, "'", "")
            Dim mobile As String = Replace(txtMobile.Text.Trim, "'", "")
            Dim mobile2 As String = Replace(txtMobile2.Text.Trim, "'", "")
            Dim mobile3 As String = Replace(txtMobile3.Text.Trim, "'", "")
            Dim email As String = Replace(txtEmail.Text.Trim, "'", "")
            Dim bdd As String = cbDay.Text
            Dim bmm As String = cbMonth.SelectedIndex
            Dim byy As String = cbYear.Text

            If chBirthday.Checked = True Then
                If cbMonth.SelectedIndex < 1 Then
                    cbMonth.Focus()
                    MsgBox("Please enter Month")
                    Exit Function
                End If

                If cbDay.SelectedIndex < 1 Then
                    cbDay.Focus()
                    MsgBox("Please enter Day")
                    Exit Function
                End If

                If cbYear.SelectedIndex < 1 Then
                    cbYear.Focus()
                    MsgBox("Please enter Year")
                    Exit Function
                End If

            End If

            Dim BdayFormat As String = byy & "-" & bmm & "-" & bdd
            Dim query As String
            'UPDATE BIRTHDAY
            If cbMonth.SelectedIndex > 0 Or cbDay.SelectedIndex > 0 Or cbYear.SelectedIndex > 0 Then
                query = "UPDATE patient SET birthday = '" & BdayFormat & "', telephone_number='" & tel & "',mobile_number='" & mobile & "'," _ 
                & " updated_by='" & ClientUsername & "', email_address='" & email & "',updated_at=DATE_FORMAT(NOW(),'%Y-%m-%d %H:%i:%s') WHERE Patient_ID='" & id & "'"

            Else
                query = "UPDATE patient SET birthday = NULL, telephone_number='" & tel & "',mobile_number='" & mobile & "'," _ 
                & " updated_by='" & ClientUsername & "',email_address='" & email & "',updated_at=DATE(NOW()) WHERE Patient_ID='" & id & "'"
            End If

            Dim rowsEffected As Integer = 0
            Dim connection As New MySqlConnection(connStrSMS)
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

    Private Sub txtEmail_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmail.LostFocus
        txtEmail.Text = txtEmail.Text.Trim
    End Sub

    Private Sub txtMobile_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMobile.TextChanged

    End Sub
End Class