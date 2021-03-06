﻿Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop

Public Class frmSMSFullBlast
    Dim Pri_Contact As String
    Dim Pri_banchCode As String
    Dim i as Integer
    Dim OL as Integer 

    Public Sub Display_patient_Grid(_name As String)
        Dim dt = New DataTable()
        Dim apStatus As String = Replace(cbSatus.Text.Trim(), "'", "\'")
        Dim srchDoc As String
        Dim srchAes As String
        Dim Branch as String
        If chDotors.Checked = True Then
            srchDoc = " AND medical_personnel_id LIKE '%" & lbDocAes.Text.Trim & "%'"
        Else
            srchDoc = ""
        End If

        If chAesthetician.Checked = True Then
            srchAes = " AND medical_personnel_id LIKE '%" & lbDocAes.Text.Trim & "%'"
        Else
            srchAes = ""
        End If

        If cbSatus.SelectedIndex = -1 Or cbSatus.SelectedIndex = 0 Then
            apStatus = ""
        End If

        if cbBranch.Text = "All Branch" then
            Branch = " AND Branch like '%%' "
        else
            Branch = " AND Branch ='" & lbBranchCode.Text & "'"
        End If

        ListViewPatientsContactSetting()
        Try
            Dim i As Integer = 0
            Dim query As String
            Dim TTL As Integer = ResultCount("SELECT COUNT(*) TTL FROM `appointments` WHERE DATE(start_at) BETWEEN '" & Format(dpFrom.Value, "yyyy-MM-dd") & "' AND '" & Format(dpTo.Value, "yyyy-MM-dd") & "' AND appointment_status LIKE '%" & apStatus & "%' AND LENGTH(patient_id)>1 " & srchDoc & srchAes & Branch & " ORDER BY DATE(start_at) ASC")

            pBar.Value = 0
            pBar.Maximum = TTL

            'ID | PATIENT_ID | GENDER | FULLNAME | MOBILE | PROCEDURE_DATA | SCHEDULE | APPOINTMENT_STATUS | SCHED_DATE | DOCAES
            query = "SELECT id,patient_id,(SELECT gender FROM patient WHERE  patient.patient_id=`appointments`.patient_id) px_gender, " _
            & " (SELECT CONCAT(TRIM(first_name),' ',TRIM(last_name)) FROM patient WHERE  patient.patient_id=`appointments`.patient_id) px_name, " _
            & " (SELECT mobile_number FROM patient WHERE  patient.patient_id=`appointments`.`patient_id`) px_mobile," _
            & " (SELECT `master_list`.`full_description` FROM master_list WHERE `barcode`=`appointments`.`procedure`) Procedure_data, " _
            & " CONCAT(DATE_FORMAT(start_at,'%h:%i %p'), ' to ', DATE_FORMAT(end_at,'%h:%i %p')) schedTime,appointment_status,(DATE_FORMAT(start_at,'%Y-%m-%d')) appointment_date," _
            & " IF(LENGTH(`appointments`.`medical_personnel_id`) > 1,(SELECT CONCAT(Title ,' ',NAME) FROM medical_personnel WHERE `id` = `appointments`.`medical_personnel_id`),'') DocAes FROM `appointments` WHERE (DATE(start_at) " _
            & " BETWEEN '" & Format(dpFrom.Value, "yyyy-MM-dd") & "' AND '" & Format(dpTo.Value, "yyyy-MM-dd") & "') AND appointment_status LIKE '%" & apStatus & "%' AND LENGTH(patient_id)>1 " & srchDoc & srchAes & Branch & " ORDER BY DATE(start_at) ASC"


            Dim connection As New MySqlConnection(connStrSMS)
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader
            connection.Open()
            reader = cmd.ExecuteReader()
            dt.Load(reader)
            'this will clear the listbox
            DataGridView1.DataSource = dt
            connection.Close()
            DataGridView1.Columns(1).HeaderText = "AID"
            DataGridView1.Columns(3).HeaderText = "Gender"
            DataGridView1.Columns(4).HeaderText = "Patient Name"
            DataGridView1.Columns(5).HeaderText = "Mobile"
            DataGridView1.Columns(6).HeaderText = "Procedure Data"
            DataGridView1.Columns(7).HeaderText = "Schedule"
            DataGridView1.Columns(8).HeaderText = "Status"
            DataGridView1.Columns(9).HeaderText = "Date"
            DataGridView1.Columns(10).HeaderText = "Doctors/Aesthetician"
            
            DataGridView1.Columns(1).Width = 50
            DataGridView1.Columns(2).Visible = false
            DataGridView1.Columns(3).Width = 55
            DataGridView1.Columns(4).Width = 150
            DataGridView1.Columns(5).Width = 80
            DataGridView1.Columns(6).Width = 280
            DataGridView1.Columns(7).Width = 120
            DataGridView1.Columns(8).Width = 80
            DataGridView1.Columns(9).Width = 80
            DataGridView1.Columns(10).Width = 120

            DataGridView1.Columns(7).DefaultCellStyle.Format=("MMM dd, yyyy")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Branch_List()
        Try
            Dim i As Integer = 1
            Dim query As String

            If ClientAccAdmin = 1 Then
                query = "SELECT * FROM `branches` WHERE ID NOT LIKE '00' ORDER BY name ASC"
            Else
                query = "SELECT * FROM `branches` WHERE ID NOT LIKE '00' AND ID='" & ClientBranch & "' ORDER BY name ASC"
            End If

            Dim connection As New MySqlConnection(connStrSMS)
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader

            cbBranch.Text = "[Branch]"
            cbBranch.Items.Clear()

            connection.Open()
            reader = cmd.ExecuteReader()
            If reader.HasRows = True Then
                'cbBranch.Items.Add("All Branch")
                While reader.Read
                    cbBranch.Items.Add(reader.Item("name").ToString())
                End While
            End If
            cbBranch.SelectedIndex = 0
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ListViewPatientsContactSetting()
        lstPatientsContact.Items.Clear()
        lstPatientsContact.Columns.Clear()
        lstPatientsContact.Columns.Add("AID", 50)
        lstPatientsContact.Columns.Add("PID", 0)
        lstPatientsContact.Columns.Add("Gender", 55)
        lstPatientsContact.Columns.Add("Patient Name", 150)
        lstPatientsContact.Columns.Add("Mobile", 80)
        lstPatientsContact.Columns.Add("Procedure Data", 280)
        lstPatientsContact.Columns.Add("Schedule", 120)
        lstPatientsContact.Columns.Add("Date", 80)
        lstPatientsContact.Columns.Add("Status", 80)
        lstPatientsContact.Columns.Add("Doctors/Aesthetician", 120)
    End Sub
    Private Sub HeaderTemplate()
        lsTemplate.Columns.Clear()
        lsTemplate.Columns.Add("NO", 30)
        lsTemplate.Columns.Add("Message", 310)
    End Sub

    Public Sub RetriveSMS()

        Dim apStatus As String = Replace(cbSatus.Text.Trim(), "'", "\'")
        Dim srchDoc As String
        Dim srchAes As String
        Dim Branch as String
        If chDotors.Checked = True Then
            srchDoc = " AND medical_personnel_id LIKE '%" & lbDocAes.Text.Trim & "%'"
        Else
            srchDoc = ""
        End If

        If chAesthetician.Checked = True Then
            srchAes = " AND medical_personnel_id LIKE '%" & lbDocAes.Text.Trim & "%'"
        Else
            srchAes = ""
        End If

        If cbSatus.SelectedIndex = -1 Or cbSatus.SelectedIndex = 0 Then
            apStatus = ""
        End If

        if cbBranch.Text = "All Branch" then
            Branch = " AND Branch like '%%' "
        else
            Branch = " AND Branch ='" & lbBranchCode.Text & "'"
        End If

        if btSend_Select.Text <> "Send to Many?" then
            Datagridview1.Visible = False
            DataGridView1.ClearSelection()
            DataGridView1.SendToBack()
            btSend_Select.Text = "Send to Many?"
        End If

        ListViewPatientsContactSetting()

        Try
            Dim query As String
            Dim TTL As Integer = ResultCount("SELECT COUNT(*) TTL FROM `appointments` WHERE DATE(start_at) BETWEEN '" & Format(dpFrom.Value, "yyyy-MM-dd") & "' AND '" & Format(dpTo.Value, "yyyy-MM-dd") & "' AND appointment_status LIKE '%" & apStatus & "%' AND LENGTH(patient_id)>1 " & srchDoc & srchAes & Branch & " ORDER BY DATE(start_at) ASC")

            pBar.Value = 0
            pBar.Maximum = TTL

            query = "SELECT id,patient_id,(SELECT gender FROM patient WHERE  patient.patient_id=`appointments`.patient_id) px_gender, " _
            & " (SELECT CONCAT(TRIM(first_name),' ',TRIM(last_name)) FROM patient WHERE  patient.patient_id=`appointments`.patient_id) px_name, " _
            & " (SELECT mobile_number FROM patient WHERE  patient.patient_id=`appointments`.`patient_id`) px_mobile," _
            & " (SELECT `master_list`.`full_description` FROM master_list WHERE `barcode`=`appointments`.`procedure`) Procedure_data, " _
            & " CONCAT(DATE_FORMAT(start_at,'%h:%i %p'), ' to ', DATE_FORMAT(end_at,'%h:%i %p')) schedTime,appointment_status,(DATE_FORMAT(start_at,'%Y-%m-%d')) appointment_date," _
            & " IF(LENGTH(`appointments`.`medical_personnel_id`) > 1,(SELECT CONCAT(Title ,' ',NAME) FROM medical_personnel WHERE `id` = `appointments`.`medical_personnel_id`),'') DocAes FROM `appointments` WHERE (DATE(start_at) " _
            & " BETWEEN '" & Format(dpFrom.Value, "yyyy-MM-dd") & "' AND '" & Format(dpTo.Value, "yyyy-MM-dd") & "') AND appointment_status LIKE '%" & apStatus & "%' AND LENGTH(patient_id)>1 " & srchDoc & srchAes & Branch & " ORDER BY DATE(start_at) ASC"

            Dim connection As New MySqlConnection(connStrSMS)
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader
            Dim dt as new DataTable()
            connection.Open()
            reader = cmd.ExecuteReader()
            If reader.HasRows = True Then
                While reader.Read
                    Dim ls As New ListViewItem(reader.Item("id").ToString.Trim())
                    Dim appointment_date As Date = reader.Item("appointment_date").ToString()
                    ls.SubItems.Add(reader.Item("patient_id").ToString.Trim())
                    ls.SubItems.Add(StrConv(reader.Item("px_gender").ToString.Trim(), VbStrConv.Uppercase))
                    ls.SubItems.Add(StrConv(reader.Item("px_name").ToString.Trim(), VbStrConv.ProperCase))
                    ls.SubItems.Add(reader.Item("px_mobile").ToString.Trim())
                    ls.SubItems.Add(reader.Item("procedure_data").ToString.Trim())
                    ls.SubItems.Add(reader.Item("schedTime").ToString())
                    ls.SubItems.Add(Format(appointment_date, "MMM dd, yyyy"))
                    ls.SubItems.Add(reader.Item("appointment_status").ToString())
                    ls.SubItems.Add(reader.Item("DocAes").ToString())
                    lstPatientsContact.Items.Add(ls)

                    
                    pBar.Value += 1
                End While
                
            End If
            connection.Close()
            RowCountTool.Text = "Rows: " & lstPatientsContact.Items.Count

            If lstPatientsContact.Items.Count > 0 Then
                btSend_Select.Enabled = True
                btSendToAll.Enabled = True
                ExcelToolStrip.Enabled = True
            Else
                btSend_Select.Enabled = False
                btSendToAll.Enabled = False
                ExcelToolStrip.Enabled = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Console.WriteLine(ex.Message)
        End Try

    End Sub

    Private Sub ToolStripViewAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripViewAll.Click
        cbBranch.Text = "All Branch"
        btView_Click(Me, EventArgs.Empty)
    End Sub

    Private Sub btView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btView.Click
        If cbBranch.SelectedIndex = -1 Then
            MsgBox("Please Select Branch.", MsgBoxStyle.Information, "Branch Name")
            cbBranch.Focus()
            Exit Sub
        End If

        txtMobile.Text = ""
        txtClientName.Text = ""
        RowCountTool.Text = "Rows: "
        PercentToolStrip.Text = ""
        lbTxtLength.Text = Len(txtClientName.Text)
        dpTo.Focus()

        pbExtract.Value = 0
        btView.Enabled = False
        ToolStripViewAll.Enabled = False
        'POPULATE LISTVIEW
        RetriveSMS()
        btView.Enabled = True
        ToolStripViewAll.Enabled = True
        btView.Focus()
        Application.DoEvents()
    End Sub
    Private Sub frmFullBlastSMS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'SET LISTVIEW COLUMNS
        ListViewPatientsContactSetting()
        HeaderTemplate()
        gbTemplate.Visible = False
        'GET BRANCH
        Branch_List()
        FFMain.AsDeptFooters()
        'Combo Status
        cbSatus.Text = "All"
        cbSatus.Items.Add("All")
        cbSatus.Items.Add("Cancelled")
        cbSatus.Items.Add("Change Procedure")
        cbSatus.Items.Add("Completed")
        cbSatus.Items.Add("Pending")
        cbSatus.Items.Add("No Charge")
        cbSatus.Items.Add("No Show")
        cbSatus.Items.Add("Rebooked")
        cbSatus.Items.Add("Requested")
        cbSatus.Items.Add("Rescheduled")
        cbSatus.Items.Add("Reserve")
        cbSatus.Items.Add("Reserved")
        cbSatus.Items.Add("Scheduled Today")
        cbSatus.Items.Add("Tentative")
        cbSatus.SelectedIndex = 0

        txtMobile.Text = ""
        txtClientName.Text = ""
        txtMobile_c.Text = ""
        txtMessage_c.Text = ""

        RowCountTool.Text = "Rows: " & lstPatientsContact.Items.Count
        PercentToolStrip.Text = ""

        If lstPatientsContact.Items.Count > 0 Then
            btSendToAll.Enabled = True
            ExcelToolStrip.Enabled = True
        Else
            btSendToAll.Enabled = False
            ExcelToolStrip.Enabled = False
        End If

        lbTxtLength.Text = Len(txtClientName.Text)
        lbTxtLength_c.Text = Len(txtMessage_c.Text)

    End Sub
    Private Sub cbDoctors()
        Try
            Dim i As Integer = 1
            Dim query As String

            query = "SELECT name FROM medical_personnel WHERE Branch_code='" & lbBranchCode.Text.Trim & "' and type = 'Doctor' ORDER BY name ASC"

            Dim connection As New MySqlConnection(connStrSMS)
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader


            connection.Open()
            reader = cmd.ExecuteReader()
            If reader.HasRows = True Then
                While reader.Read
                    cbDocAes.Items.Add(reader.Item("name").ToString())
                End While
            End If
            cbDocAes.SelectedIndex = 0
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "::cbDoctors")
        End Try
    End Sub
    Private Sub cbAesthetician()
        Try
            Dim i As Integer = 1
            Dim query As String

            query = "SELECT name FROM medical_personnel WHERE Branch_code='" & lbBranchCode.Text.Trim & "' and type = 'Aesthetician' ORDER BY name ASC"

            Dim connection As New MySqlConnection(connStrSMS)
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader


            connection.Open()
            reader = cmd.ExecuteReader()
            If reader.HasRows = True Then
                While reader.Read
                    cbDocAes.Items.Add(reader.Item("name").ToString())
                End While
            End If
            cbDocAes.SelectedIndex = 0
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "::cbAesthetician")
        End Try

    End Sub
    Function StrMobile(ByVal MobileNo As String) As String

        Select Case Mid(MobileNo.Trim, 1, 2)
            Case "09"
                MobileNo = Replace(Replace(Replace(MobileNo, " ", ""), "-", ""), ".", "")
                StrMobile = "+63" & Mid(MobileNo.Trim, 2, 10)
            Case Else
                Select Case Mid(MobileNo.Trim, 1, 1)
                    Case "9"
                        StrMobile = "+63" & Mid(MobileNo.Trim, 1, 10)
                    Case Else
                        'StrMobile = MobileNo.Trim()
                End Select
        End Select
    End Function

    Private Sub cbBranch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbBranch.SelectedIndexChanged
        lbBranchDB.Text = BranchDatabaseName(cbBranch.Text)
        RetriveSMS()

        If chDotors.Checked = True Then
            cbDocAes.Items.Clear()
            cbDocAes.Items.Add("Doctors")
            cbDoctors()
        End If

        If chAesthetician.Checked = True Then
            cbDocAes.Items.Clear()
            cbDocAes.Items.Add("Aesthetician")
            cbAesthetician()
        End If

    End Sub

    Private Sub lstPatientsContact_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstPatientsContact.Click

        If lstPatientsContact.Items.Count > 0 Then
            Dim pxName As String
            Dim pxDocAes As String
            Dim pxDate As String
            Dim pxTime As String
            Dim strProcedure() As String

            'strProcedure = lstPatientsContact.SelectedItems(0).SubItems(5).Text.Trim().Split(New String() {"   "}, StringSplitOptions.None)

            lbPxID.Text = lstPatientsContact.SelectedItems(0).SubItems(1).Text.Trim
            pxName = PX_MrMs(lstPatientsContact.SelectedItems(0).SubItems(2).Text.Trim()) & lstPatientsContact.SelectedItems(0).SubItems(3).Text.Trim()
            lbPxName.Text = pxName
            strProcedure = lstPatientsContact.SelectedItems(0).SubItems(5).Text.Trim().Split("|")
            pxTime = lstPatientsContact.SelectedItems(0).SubItems(6).Text.Trim()
            pxDate = lstPatientsContact.SelectedItems(0).SubItems(7).Text.Trim()
            pxDocAes = lstPatientsContact.SelectedItems(0).SubItems(9).Text.Trim()

            If Len(pxName) > 1 Then
                pxName = pxName & "!"
            End If

            px_mobile(lstPatientsContact.SelectedItems(0).SubItems(4).Text.Trim())
            txtMobile_c.Text = txtMobile.Text.Trim
            '"; " & pxTime & " scheduled for " & ServiceListName(strProcedure(0)) & " at Belo clinic." & vbNewLine & vbNewLine &
            txtClientName.Text = "Hi " & pxName & " This is " & ClientName & " from the Belo Medical Group. This is to remind you of your appointment with " & pxDocAes & " on " & pxDate &
            "; " & pxTime & " scheduled for " & strProcedure(0).ToString() & " at Belo clinic." & vbNewLine & vbNewLine &
            "Our branch is located at " & AddressToolStripStatus.Text & vbNewLine & vbNewLine & FooterSMS
            
            lbTxtLength.Text = Len(txtClientName.Text)
            lbTxtLength_c.Text = Len(txtMessage_c.Text)

        End If

    End Sub

    Private Sub lstPatientsContact_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstPatientsContact.GotFocus
        Try
            lstPatientsContact.Items(lstPatientsContact.FocusedItem.Index).Selected = True
            lstPatientsContact.Select()

            lstPatientsContact_Click(Me, EventArgs.Empty)
        Catch ex As Exception
            if lstPatientsContact.Items.Count = 0 then
            Else 
            lstPatientsContact.Items(0).Selected = True
            lstPatientsContact.Select()

            lstPatientsContact_Click(Me, EventArgs.Empty)
            End If
            
        End Try
    End Sub

    Private Sub lstPatientsContact_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstPatientsContact.KeyDown
        lstPatientsContact_Click(Me, EventArgs.Empty)
    End Sub

    Private Sub lstPatientsContact_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstPatientsContact.KeyUp
        lstPatientsContact_Click(Me, EventArgs.Empty)
    End Sub

    Function px_mobile(ByVal mobile As String) As String

        Dim StrMobile As String

        mobile = Replace(Replace(mobile.Trim, " ", ""), "-", "")
        If Len(mobile) < 1 Then
            txtMobile.Text = ""
            Exit Function
        End If

        Select Case Mid(mobile.Trim, 1, 2)
            Case "09"
                If Len(mobile.Trim) >= 11 Then
                    StrMobile = Mid(mobile.Trim, 2, 10)
                    txtMobile.Text = "+63" & StrMobile
                    txtMobile.ForeColor = Color.Black
                Else
                    txtMobile.Text = ""
                    txtMobile.ForeColor = Color.Red
                End If
            Case "63"
                If Len(mobile.Trim) >= 12 Then
                    StrMobile = Mid(mobile.Trim, 1, 12)
                    txtMobile.Text = "+" & StrMobile
                    txtMobile.ForeColor = Color.Black
                Else
                    txtMobile.Text = ""
                    txtMobile.ForeColor = Color.Red
                End If
            Case Else
                Select Case Mid(mobile.Trim, 1, 3)
                    Case "+63"
                        If Len(mobile.Trim) >= 13 Then
                            StrMobile = Mid(mobile.Trim, 1, 13)
                            txtMobile.Text = StrMobile
                            txtMobile.ForeColor = Color.Black
                        Else
                            txtMobile.Text = ""
                            txtMobile.ForeColor = Color.Red
                        End If
                    Case Else
                        Select Case Mid(mobile.Trim, 1, 1)
                            Case "9"
                                If Len(mobile.Trim) >= 9 Then
                                    StrMobile = Mid(mobile.Trim, 1, 10)
                                    txtMobile.Text = "+63" & StrMobile
                                    txtMobile.ForeColor = Color.Black
                                Else
                                    txtMobile.Text = ""
                                    txtMobile.ForeColor = Color.Red
                                End If
                            Case Else
                                txtMobile.Text = ""
                                txtMobile.ForeColor = Color.Red
                        End Select
                End Select
        End Select
    End Function

    Private Sub btSendToAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSendToAll.Click
        Dim strProcedure() As String

        If MsgBox("Send Full blast SMS?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.No Then
            Exit Sub
        End If

        For Each item As ListViewItem In lstPatientsContact.Items
            Dim pxID As String = item.SubItems(1).Text.Trim             'AID
            Dim pxGender As String = item.SubItems(2).Text.Trim         'GENDER
            Dim pxName As String = item.SubItems(3).Text.Trim           'FULLNAME
            Dim pxMobile As String = item.SubItems(4).Text.Trim         'MOBILE
            Dim pxProcedure As String = item.SubItems(5).Text.Trim      'PROCEDUTE DATA
            Dim pxTime As String = item.SubItems(6).Text.Trim           'SCHEDULE
            Dim pxDate As String = item.SubItems(7).Text.Trim           'DATE
            Dim pxDocAes As String = item.SubItems(9).Text.Trim         'DOC/AES

            'strProcedure = pxProcedure.Split(New String() {"   "}, StringSplitOptions.None)

            strProcedure = pxProcedure.Split("|")
            pxName = PX_MrMs(pxGender) & pxName

            If Len(pxName) > 1 Then
                pxName = pxName & "!"
            End If

            px_mobile(pxMobile)

            If Mid(txtMobile.Text.Trim, 1, 4) = "+639" or Mid(txtMobile.Text.Trim, 1, 3) = "639"  Then

                txtClientName.Text = "Hi " & pxName & " This is " & ClientName & " from the Belo Medical Group. This is to remind you of your appointment with " & pxDocAes & " on " & pxDate &
                "; " & pxTime & " scheduled for " & ServiceListName(strProcedure(0)) & " at Belo clinic." & vbNewLine & vbNewLine &
                "Our branch is located at " & AddressToolStripStatus.Text & vbNewLine & vbNewLine & FooterSMS

                'sms_body, Branch_code, px_id, sms_sender, Username,UserHostName,UserHostIP
                messages_sms_out(txtClientName.Text, pxID, txtMobile.Text.Trim)         'Belo_Database (Messages_SMS)
                CommandXpertSMS(txtClientName.Text, 0, pxID, txtMobile.Text.Trim)       'Messages ( Database : Messages )

            End If


        Next

        MsgBox("All SMS successfully send on que", MsgBoxStyle.Information, "")

    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Dispose()
    End Sub

    Private Sub ExcelToolStrip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcelToolStrip.Click
        btView.Enabled = False
        ExcelToolStrip.Enabled = False
        FileToolStrip.Enabled = False
        ToolStripViewAll.Enabled = False
        btSendToAll.Enabled = False

        ExportToExcel()

        btSendToAll.Enabled = True
        FileToolStrip.Enabled = True
        ToolStripViewAll.Enabled = True
        ExcelToolStrip.Enabled = True
        btView.Enabled = True
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
            'MsgBox(ex.Message)
        End Try

    End Function
    Function BranchDatabaseName(ByVal BranchName As String) As String
        'GETBRANCH
        Try
            Dim query As String = "SELECT * FROM `branches` WHERE NAME LIKE '%" & BranchName & "%'"
            Dim connection As New MySqlConnection(connStrSMS)
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader
            connection.Open()
            reader = cmd.ExecuteReader()

            If reader.HasRows = True Then
                While reader.Read
                    Pri_banchCode = reader.Item("id").ToString()
                    BranchDatabaseName = "Appointments" 'reader.Item("db_name").ToString()
                    lbBranchCode.Text = reader.Item("id").ToString()
                    BranchCodeTool.Text = "Branch Code: " & Pri_banchCode
                    AddressToolStripStatus.Text = reader.Item("address").ToString.Trim()
                    Pri_Contact = reader.Item("contact_number").ToString.Trim()
                End While
            Else
                BranchDatabaseName = ""
                lbBranchCode.Text = ""
                BranchCodeTool.Text = "Branch Code: 0"
                AddressToolStripStatus.Text = ""
                Pri_Contact = ""
            End If
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Function DoctorschAestheticianID(ByVal DocAesName As String) As String
        Try
            Dim query As String

            If chDotors.Checked = True Then
                query = "SELECT ID FROM `medical_personnel` WHERE branch_code='" & lbBranchCode.Text.Trim & "' AND NAME LIKE '%" & Replace(DocAesName, "'", "\'") & "%'"
            Else
                query = "SELECT ID FROM `medical_personnel` WHERE branch_code='" & lbBranchCode.Text.Trim & "' AND NAME LIKE '%" & Replace(DocAesName, "'", "\'") & "%'"
            End If

            Dim connection As New MySqlConnection(connStrSMS)
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader
            connection.Open()
            reader = cmd.ExecuteReader()

            If reader.HasRows = True Then
                While reader.Read
                    DoctorschAestheticianID = reader.Item("ID").ToString()
                End While
            Else
                DoctorschAestheticianID = ""
            End If
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Private Sub cbSatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSatus.SelectedIndexChanged
        RetriveSMS()
    End Sub

    Private Sub btSendToAll_c_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSendToAll_c.Click
        Dim strProcedure() As String
        Dim CustomSMS As String

        If MsgBox("Send Full blast SMS?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.No Then
            Exit Sub
        End If

        For Each item As ListViewItem In lstPatientsContact.Items
            Dim pxID As String = item.SubItems(1).Text.Trim 'item.Text.Trim
            Dim pxGender As String = item.SubItems(2).Text.Trim
            Dim pxName As String = item.SubItems(3).Text.Trim
            Dim pxMobile As String = item.SubItems(4).Text.Trim
            Dim pxProcedure As String = item.SubItems(5).Text.Trim
            Dim pxTime As String = item.SubItems(6).Text.Trim
            Dim pxDate As String = item.SubItems(7).Text.Trim
            Dim pxDocAes As String = item.SubItems(9).Text.Trim

            'strProcedure = pxProcedure.Split(New String() {"   "}, StringSplitOptions.None)

            strProcedure = pxProcedure.Split("|")
            pxName = PX_MrMs(pxGender) & pxName

            If Len(pxName) > 1 Then
                pxName = pxName
            End If

            px_mobile(pxMobile)
            txtMobile_c.Text = txtMobile.Text.Trim

            If Mid(txtMobile_c.Text.Trim, 1, 4) = "+639" Then
                CustomSMS = txtMessage_c.Text & vbNewLine & vbNewLine & FooterSMS
                'sms_body, Branch_code, px_id, sms_sender, UserName, UserHostName, UserHostIP

                messages_sms_out(CustomSMS, pxID, txtMobile_c.Text.Trim)        'Belo_Database (Messages_SMS)
                CommandXpertSMS(CustomSMS, 0, pxID, txtMobile_c.Text.Trim)      'Messages ( Database : Messages )
            End If

        Next

        MsgBox("All SMS successfully send on que", MsgBoxStyle.Information, "")
    End Sub
    Private Sub lsTemplate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsTemplate.Click
        If lsTemplate.Items.Count > 0 Then
            txtMessage_c.Text = lsTemplate.SelectedItems(0).SubItems(1).Text.Trim()
        End If
        lbTxtLength_c.Text = Len(txtMessage_c.Text)
    End Sub
    Private Sub TabControl1_Selected(ByVal sender As Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles TabControl1.Selected

        Select Case e.TabPageIndex
            Case 1
                Retrive_SMS_TEMPLATE()
                gbTemplate.Visible = True
                lbTxtLength_c.Text = Len(txtMessage_c.Text)
            Case Else
                gbTemplate.Visible = False
        End Select
    End Sub
    Public Sub Retrive_SMS_TEMPLATE()
        Try
            Dim query As String
            Dim i As Integer = 0
            query = "SELECT * FROM template WHERE user_access_group LIKE '" & ClientUserAccessGroup & "'"

            Dim connection As New MySqlConnection(connStrSMS)
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader
            connection.Open()
            reader = cmd.ExecuteReader()
            'this will clear the listbox
            lsTemplate.Items.Clear()

            If reader.HasRows = True Then
                While reader.Read
                    i += 1
                    Dim ls As New ListViewItem(i)
                    ls.SubItems.Add(reader.Item("template").ToString.Trim())
                    lsTemplate.Items.Add(ls)
                End While
            End If
            connection.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
#Region "Export to Excel"
    Private Sub ExportToExcel()
        Dim xls As New Excel.Application
        Dim book As Excel.Workbook
        Dim sheet As Excel.Worksheet

        If lstPatientsContact.Items.Count < 1 Then
            Exit Sub
        End If

        'create a workbook and get reference to first worksheet
        xls.Workbooks.Add()
        book = xls.ActiveWorkbook
        sheet = book.ActiveSheet

        With sheet
            ' SHOW AN HEADER.
            .Cells(1, 2) = "Belo Medical Group" : .Cells(1, 2).FONT.NAME = "Calibri"
            .Cells(1, 2).Font.Bold = True : .Cells(1, 2).Font.Size = 20
            .Cells(1, 2).Font.color = Color.Goldenrod

            .Cells(2, 2) = cbBranch.Text.Trim & " Appointment Schedule from " & Format(dpFrom.Value, "MMM dd, yyyy") & " to " & Format(dpTo.Value, "MMM dd, yyyy") : .Cells(2, 2).FONT.NAME = "Calibri"
            .Cells(2, 2).Font.Bold = True : .Cells(1, 2).Font.Size = 14
            .Cells(2, 2).Font.color = Color.Goldenrod

            .Range("B1:I1").MergeCells = True
            .Range("B2:J2").MergeCells = True
        End With

        'Get columns Headers
        For i As Integer = 0 To lstPatientsContact.Columns.Count - 1
            sheet.Cells(4, i + 1) = lstPatientsContact.Columns(i).Text
            sheet.Cells(4, i + 1).Font.Bold = True
        Next

        'step through rows and columns and copy data to worksheet
        Dim row As Integer = 1
        Dim col As Integer = 1

        pbExtract.Value = 0
        pbExtract.Maximum = lstPatientsContact.Items.Count

        For Each item As ListViewItem In lstPatientsContact.Items
            For i As Integer = 0 To item.SubItems.Count - 1
                sheet.Cells(row + 4, col) = item.SubItems(i).Text
                col = col + 1
            Next
            row += 1
            col = 1
            pbExtract.Value += 1
            PercentToolStrip.Text = Convert.ToInt32((pbExtract.Value / lstPatientsContact.Items.Count) * 100) & "% " & pbExtract.Value
        Next

        For i As Integer = 0 To lstPatientsContact.Columns.Count - 1
            With sheet
                .Cells.NumberFormat = "@"
                .Columns(i + 1).AutoFit()
                .Columns.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            End With
        Next

        'For i As Integer = 0 To lstPatientsContact.Columns.Count - 1
        'sheet.Columns(i + 1).AutoFit()
        'Next

        'save the workbook and clean up
        xls.Visible = True
        'book.SaveAs("c:\sssss")
        'xls.Workbooks.Close()
        'xls.Quit()
        releaseObject(sheet)
        releaseObject(book)
        releaseObject(xls)
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        'Release an automation object
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

#End Region

    Private Sub txtMessage_c_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMessage_c.KeyDown
        lbTxtLength_c.Text = Len(txtMessage_c.Text)
    End Sub

    Private Sub txtMessage_c_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMessage_c.KeyUp
        lbTxtLength_c.Text = Len(txtMessage_c.Text)
    End Sub

    Private Sub txtMessage_c_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtMessage_c.MouseUp
        lbTxtLength_c.Text = Len(txtMessage_c.Text)
    End Sub

    Private Sub lstPatientsContact_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstPatientsContact.MouseClick
        If lstPatientsContact.Items.Count > 0 Then
            If e.Button = Windows.Forms.MouseButtons.Right Then
                ContextMessageInbox.Show(lstPatientsContact, e.Location)
            End If
        End If
    End Sub

    Private Sub chDotors_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chDotors.CheckedChanged

        If chDotors.Checked = True Then
            chAesthetician.Checked = False

            cbDocAes.Items.Clear()
            cbDocAes.Items.Add("Doctors")
            cbDoctors()
        Else
            chAesthetician.Checked = True
        End If

    End Sub

    Private Sub chAesthetician_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chAesthetician.CheckedChanged

        If chAesthetician.Checked = True Then
            chDotors.Checked = False
            cbDocAes.Items.Clear()
            cbDocAes.Items.Add("Aesthetician")
            cbAesthetician()
        Else
            chDotors.Checked = True
        End If
    End Sub

    Private Sub frmSMSFullBlast_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        chDotors.Checked = True
    End Sub

    Private Sub cbDocAes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDocAes.SelectedIndexChanged
        lbDocAes.Text = DoctorschAestheticianID(cbDocAes.Text.Trim)
    End Sub

    Private Sub AutoTemplateToolStrip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutoTemplateToolStrip.Click
        Dim _pxMobile As String = txtMobile.Text.Trim

        Try
            FFSendSMS.Show()
            FFSendSMS.BringToFront()

            FFSendSMS.txtMobile.Text = _pxMobile
            FFSendSMS.txtMessage.Text = txtClientName.Text
            FFSendSMS.txtMessage.ReadOnly = True
            FFSendSMS.pxToolStrip.Visible = True
            FFSendSMS.pxToolStrip.Text = lbPxName.Text.Trim
            FFSendSMS.pxIDToolStrip.Text = lbPxID.Text.Trim
            FFSendSMS.txtMobile.Focus()
            FFSendSMS.txtMobile.Enabled = False
            FFSendSMS.txtMessage.BackColor = Color.White
            FFSendSMS.ShowTemplateToolStripMenuItem.Enabled = False
            FFSendSMS.TxtLenghtToolStrip.Text = "Lenght : " & Len(txtClientName.Text)
        Catch ex As Exception
            FFSendSMS = New frmSMSSend()
            FFSendSMS.Show()
            FFSendSMS.BringToFront()

            FFSendSMS.txtMobile.Text = _pxMobile
            FFSendSMS.txtMessage.Text = txtClientName.Text
            FFSendSMS.txtMessage.ReadOnly = True
            FFSendSMS.pxToolStrip.Visible = True
            FFSendSMS.pxToolStrip.Text = lbPxName.Text.Trim
            FFSendSMS.pxIDToolStrip.Text = lbPxID.Text.Trim
            FFSendSMS.txtMobile.Focus()
            FFSendSMS.txtMobile.Enabled = False
            FFSendSMS.txtMessage.BackColor = Color.White
            FFSendSMS.ShowTemplateToolStripMenuItem.Enabled = False
            FFSendSMS.TxtLenghtToolStrip.Text = "Lenght : " & Len(txtClientName.Text)
        End Try

    End Sub

    Private Sub CustomTemplateToolStrip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomTemplateToolStrip.Click
        Dim _pxMobile As String = txtMobile.Text.Trim

        Try
            FFSendSMS.Show()
            FFSendSMS.BringToFront()

            FFSendSMS.txtMobile.Text = _pxMobile
            FFSendSMS.txtMessage.Text = ""
            FFSendSMS.pxToolStrip.Visible = True
            FFSendSMS.pxToolStrip.Text = lbPxName.Text.Trim
            FFSendSMS.pxIDToolStrip.Text = lbPxID.Text.Trim
            FFSendSMS.txtMobile.Focus()
            FFSendSMS.txtMobile.Enabled = False
            FFSendSMS.txtMessage.Focus()
        Catch ex As Exception
            FFSendSMS = New frmSMSSend()
            FFSendSMS.Show()
            FFSendSMS.BringToFront()

            FFSendSMS.txtMobile.Text = _pxMobile
            FFSendSMS.txtMessage.Text = ""
            FFSendSMS.pxToolStrip.Visible = True
            FFSendSMS.pxToolStrip.Text = lbPxName.Text.Trim
            FFSendSMS.pxIDToolStrip.Text = lbPxID.Text.Trim
            FFSendSMS.txtMobile.Focus()
            FFSendSMS.txtMobile.Enabled = False
            FFSendSMS.txtMessage.Focus()
        End Try
    End Sub

Private Sub btSend_Select_Click( sender As Object,  e As EventArgs) Handles btSend_Select.Click    
    if DataGridView1.Visible = False Then
        'POPULATE DATAGRID
        DataGridView1.BringToFront()
        DataGridView1.Visible = True
        Display_patient_Grid("")
        btSend_Select.Text = "Cancel Send."

    elseif DataGridView1.Visible = True and btSend_Select.Text = "Cancel Send."
        RetriveSMS()
        DataGridView1.ClearSelection()
        DataGridView1.SendToBack()
        DataGridView1.Visible = false
        btSend_Select.Text = "Send to Many?"
    ElseIf DataGridView1.Rowcount > 0 and btSend_Select.Text = "Send Selected" then
        Dim strProcedure() As String
        dim xxx as Integer
        If MsgBox("Send Selected blast SMS?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.No Then
            Exit Sub
        End If

        For  i As Integer = 0 To DataGridView1.Rows.Count - 1
            If CBool(DirectCast(DataGridView1.Rows(i).Cells("check"), DataGridViewCheckBoxCell).Value) = True Then
                Dim pxID As String = DataGridView1.Rows(i).Cells(1).Value.ToString() 
                Dim pxGender As String = DataGridView1.Rows(i).Cells(3).Value.ToString() 
                Dim pxName As String = DataGridView1.Rows(i).Cells(4).Value.ToString() 
                Dim pxMobile As String = DataGridView1.Rows(i).Cells(5).Value.ToString() 
                Dim pxProcedure As String = DataGridView1.Rows(i).Cells(6).Value.ToString() 
                Dim pxTime As String = DataGridView1.Rows(i).Cells(7).Value.ToString()
                Dim pxDate As String =Format(CDate(DataGridView1.Rows(i).Cells(9).Value.ToString()),"MMM dd, yyyy")
                'pxdate = (pxdate)
                Dim pxDocAes As String = DataGridView1.Rows(i).Cells(10).Value.ToString() 
                'strProcedure = pxProcedure.Split(New String() {"   "}, StringSplitOptions.None)

                strProcedure = pxProcedure.Split("|")
                pxName = PX_MrMs(pxGender) & pxName

                If Len(pxName) > 1 Then
                    pxName = pxName & "!"
                End If

                px_mobile(pxMobile)

                If Mid(txtMobile.Text.Trim, 1, 4) = "+639" or Mid(txtMobile.Text.Trim, 1, 3) = "639"  Then

                    txtClientName.Text = "Hi " & pxName & " This is " & ClientName & " from the Belo Medical Group. This is to remind you of your appointment with " & pxDocAes & " on " & pxDate &
                                         "; " & pxTime & " scheduled for " & strProcedure(0).ToString() & " at Belo clinic." & vbNewLine & vbNewLine &
                                         "Our branch is located at " & AddressToolStripStatus.Text & vbNewLine & vbNewLine & FooterSMS

                    'sms_body, Branch_code, px_id, sms_sender, Username,UserHostName,UserHostIP
                    messages_sms_out(txtClientName.Text, pxID, txtMobile.Text.Trim)         'Belo_Database (Messages_SMS)
                    CommandXpertSMS(txtClientName.Text, 0, pxID, txtMobile.Text.Trim)       'Messages ( Database : Messages )

                End If'CHECK MOBILE NUMBER
                xxx = xxx + 1
            End If'DATAGRID CHECKED RECORDS
        Next'LOOP IN RECORDS

        MsgBox("Selected SMS successfully send " & xxx & " message(s) on que", MsgBoxStyle.Information, "") 
        datagridview1.ClearSelection()
        datagridview1.SendToBack()
        btView_Click(Me,EventArgs.Empty)
    End If 'MAIN CONDITION
End Sub

Private Sub DataGridView1_CellContentClick( sender As Object,  e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
    dim xxx As String
    For i As Integer = 0 To DataGridView1.Rows.Count - 1
        If CBool(DirectCast(DataGridView1.Rows(i).Cells("check"), DataGridViewCheckBoxCell).Value) = True Then
            xxx = DataGridView1.RowCount
            if not String.IsNullOrEmpty(DataGridView1.Rows(i).Cells(1).Value.ToString()) Then
                btSend_Select.Text = "Send Selected"
                Try
                    If DataGridView1.RowCount > 0 Then
                        Dim strProcedure() As String

                        Dim pxID As String = DataGridView1.Rows(i).Cells(1).Value.ToString() 
                        Dim pxName As String = DataGridView1.Rows(i).Cells(4).Value.ToString() 
                        Dim pxMobile As String = DataGridView1.Rows(i).Cells(5).Value.ToString() 
                        Dim pxProcedure As String = DataGridView1.Rows(i).Cells(6).Value.ToString() 
                        Dim pxTime As String = DataGridView1.Rows(i).Cells(7).Value.ToString()
                        Dim pxDate As String = Format(CDate(DataGridView1.Rows(i).Cells(9).Value.ToString()),"MMM dd, yyyy")
                        Dim pxDocAes As String = DataGridView1.Rows(i).Cells(10).Value.ToString() 

                        'strProcedure = lstPatientsContact.SelectedItems(0).SubItems(5).Text.Trim().Split(New String() {"   "}, StringSplitOptions.None)

                        lbPxID.Text = pxID
                        'pxName = PX_MrMs(lstPatientsContact.SelectedItems(0).SubItems(2).Text.Trim()) & lstPatientsContact.SelectedItems(0).SubItems(3).Text.Trim()
                        lbPxName.Text = pxName
                        strProcedure = pxProcedure.ToString().Trim().Split("|")
                        'pxTime = lstPatientsContact.SelectedItems(0).SubItems(6).Text.Trim()
                        'pxDate = pxDate
                        'pxDocAes = lstPatientsContact.SelectedItems(0).SubItems(9).Text.Trim()

                        If Len(pxName) > 1 Then
                            pxName = pxName & "!"
                        End If

                        px_mobile(pxMobile)
                        txtMobile_c.Text = txtMobile.Text.Trim

                        txtClientName.Text = "Hi " & pxName & " This is " & ClientName & " from the Belo Medical Group. This is to remind you of your appointment with " & pxDocAes & " on " & pxDate &
                                             "; " & pxTime & " scheduled for " & ServiceListName(strProcedure(0)) & " at Belo clinic." & vbNewLine & vbNewLine &
                                             "Our branch is located at " & AddressToolStripStatus.Text & vbNewLine & vbNewLine & FooterSMS

                        lbTxtLength.Text = Len(txtClientName.Text)
                        lbTxtLength_c.Text = Len(txtMessage_c.Text)
                    End If'DISPLAY MESSAGES BELOW

                Catch ex As Exception
                        MsgBox("You Have selected a EMPTY Record!",vbCritical + vbOKOnly,"Selection Error!")'ERROR MESSAGE
                End Try 
            Else 
                btSend_Select.Text = "Cancel Send."
            End If
        else
            if i = (CInt(xxx) - 1) Then
            else
            btSend_Select.Text = "Cancel Send."
            'xxx = DataGridView1.RowCount
            end if 
        End If
    Next
End Sub

    Private Sub DataGridView1_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellLeave
        TRy 

        Catch ex As Exception
            MsgBox("")
        End Try
    End Sub

    Private Sub DataGridView1_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles DataGridView1.CurrentCellDirtyStateChanged
        If dataGridView1.IsCurrentCellDirty Then
            dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub DataGridView1_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError
        '// IGNORED //
    End Sub

Private Sub lbBranchCode_Click( sender As Object,  e As EventArgs) Handles lbBranchCode.Click

End Sub

Private Sub ToolStrip1_ItemClicked( sender As Object,  e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

End Sub
End Class