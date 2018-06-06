Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient

Public Class frmContactsImport
    Dim cName As String
    Dim cLastName As String
    Dim cMobile As String
    Dim cEmail As String
    Dim cAddress As String
    Dim cCompany As String
    Dim cGroups As String

    Private Sub KillExcelProcess()
        Try
            Dim Xcel() As Process = Process.GetProcessesByName("EXCEL")
            For Each Process As Process In Xcel
                Process.Kill()
            Next
        Catch ex As Exception
        End Try
    End Sub
    Private Sub getXlFile()
        Dim xlApp As Excel.Application
        Dim xlWorkbook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim xlRange As Excel.Range

        Dim xlCol As Integer
        Dim xlRow As Integer

        Dim strDestination As String
        Dim Data(0 To 200) As String


        With OpenFileDialog1
            .Filter = "Excel Office|*.xls;*.xlsx"
            .FileName = ""
            .ShowDialog()
            strDestination = .FileName

            TextBox1.Text = .FileName
        End With

        With lstContacts
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .Columns.Clear()
            .Items.Clear()

            If strDestination <> "" Then
                xlApp = New Excel.Application

                xlWorkbook = xlApp.Workbooks.Open(strDestination)
                xlWorkSheet = xlWorkbook.Worksheets("Sheet1")
                xlRange = xlWorkSheet.UsedRange

                If xlRange.Columns.Count > 0 Then
                    If xlRange.Rows.Count > 0 Then

                        'Header
                        For xlCol = 1 To xlRange.Columns.Count
                            '.Columns.Add("Column" & xlCol)
                            If xlCol = "1" Then
                                .Columns.Add("Name", 150)
                            End If

                            If xlCol = "2" Then
                                .Columns.Add("Last Name", 140)
                            End If

                            If xlCol = "3" Then
                                .Columns.Add("Mobile", 90)
                            End If

                            If xlCol = "4" Then
                                .Columns.Add("Email", 150)
                            End If

                            If xlCol = "5" Then
                                .Columns.Add("Address", 150)
                            End If

                            If xlCol = "6" Then
                                .Columns.Add("Company", 150)
                            End If

                            If xlCol = "7" Then
                                .Columns.Add("Group", 100)
                            End If
                        Next

                        'Detail
                        For xlRow = 1 To xlRange.Rows.Count
                            For xlCol = 1 To xlRange.Columns.Count

                                Data(xlCol) = xlRange.Cells(xlRow, xlCol).text.trim

                                If xlCol = 1 Then
                                    .Items.Add(Data(xlCol).ToString.Trim)
                                Else
                                    .Items(xlRow - 1).SubItems.Add(Data(xlCol).ToString.Trim)
                                End If

                            Next
                        Next
                        xlWorkbook.Close()
                        xlApp.Quit()

                        KillExcelProcess()
                    End If
                End If
            Else
                LisContactList()
                MessageBox.Show("Please browse contacts file for import.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End With

        If lstContacts.Items.Count > 0 Then
            btSave.Enabled = True
        Else
            btSave.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        getXlFile()
    End Sub

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstContacts.Click

        If lstContacts.Items.Count > 0 Then
            cName = lstContacts.SelectedItems(0).Text.Trim()
            cLastName = lstContacts.SelectedItems(0).SubItems(1).Text.Trim()
            cMobile = lstContacts.SelectedItems(0).SubItems(2).Text.Trim()
            cEmail = lstContacts.SelectedItems(0).SubItems(3).Text.Trim()
            cAddress = lstContacts.SelectedItems(0).SubItems(4).Text.Trim()
            cCompany = lstContacts.SelectedItems(0).SubItems(5).Text.Trim()
            cGroups = lstContacts.SelectedItems(0).SubItems(6).Text.Trim()

            cName = Replace(cName, "'", "\'")
            cLastName = Replace(cLastName, "'", "\'")
            cMobile = Replace(Replace(cMobile, " ", ""), "'", "")
            cEmail = Replace(Replace(cEmail, " ", ""), "'", "\'")
            cAddress = Replace(cAddress, "'", "\'")
            cCompany = Replace(cCompany, "'", "\'")
            cGroups = Replace(cGroups, "'", "\'")

            MsgBox(cName & " " & cLastName & " " & cMobile & " " & cEmail & " " & cAddress & " " & cCompany & " " & cGroups)

        End If

    End Sub
    Private Sub LisContactList()
        lstContacts.Columns.Clear()
        lstContacts.Columns.Add("Name", 150)
        lstContacts.Columns.Add("Last Name", 140)
        lstContacts.Columns.Add("Mobile", 90)
        lstContacts.Columns.Add("Email", 150)
        lstContacts.Columns.Add("Address", 150)
        lstContacts.Columns.Add("Company", 150)
        lstContacts.Columns.Add("Group", 100)
    End Sub
    Private Sub frmContactsImport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btSave.Enabled = False
        LisContactList()
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Try

            For Each item As ListViewItem In lstContacts.Items
                Dim cName As String = item.Text.Trim
                Dim cLastName As String = item.SubItems(1).Text.Trim
                Dim cMobile As String = item.SubItems(2).Text.Trim
                Dim cEmail As String = item.SubItems(3).Text.Trim
                Dim cAddress As String = item.SubItems(4).Text.Trim
                Dim cCompany As String = item.SubItems(5).Text.Trim
                Dim cGroups As String = item.SubItems(6).Text.Trim

                cName = Replace(cName, "'", "\'")
                cLastName = Replace(cLastName, "'", "\'")
                cMobile = Replace(Replace(cMobile, " ", ""), "'", "")
                cEmail = Replace(Replace(cEmail, " ", ""), "'", "\'")
                cAddress = Replace(Replace(cAddress, " ", ""), "'", "\'")
                cCompany = Replace(Replace(cCompany, " ", ""), "'", "\'")
                cGroups = Replace(Replace(cGroups, " ", ""), "'", "\'")

                If Len(cName) > 1 Then
                    InsertContactsList(cName, cLastName, cMobile, cEmail, cAddress, cCompany, cGroups)
                End If

            Next

            lstContacts.Items.Clear()
            btSave.Enabled = False
            TextBox1.Text = ""
            MsgBox("Contacts list successfully saved to database.", MsgBoxStyle.Information, "Successfully saved")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Function InsertContactsList(ByVal c_Name As String, ByVal c_LastName As String, ByVal c_Mobile As String, ByVal c_Email As String, ByVal c_Address As String, ByVal c_Company As String, ByVal c_groups As String) As Integer

        Try

            Dim SQL As String

            SQL = "INSERT INTO `sms_contacts` SET firstname='" & c_Name & "', lastname='" & c_LastName & "', mobile='" & c_Mobile & "', " _
            & " email='" & c_Email & "', address='" & c_Address & "', company='" & c_Company & "',sms_group='" & c_groups & "',created_by='" & ClientUsername & "' "

            Dim rowsEffected As Integer = 0
            Dim connection As New MySqlConnection(connStrSMS)
            Dim cmd As New MySqlCommand(SQL, connection)

            connection.Open()

            rowsEffected = cmd.ExecuteNonQuery()

            connection.Close()

            Return rowsEffected
        Catch ex As Exception
            InsertContactsList = "0"
            MsgBox(ex.Message)
        End Try
    End Function
    Private Sub btCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancel.Click
        Me.Dispose()
    End Sub

    Private Sub frmContactsImport_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        LisContactList()
    End Sub
End Class
