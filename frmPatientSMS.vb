Imports MySql.Data.MySqlClient
Imports System.Threading

Public Class frmPatientSMS
    Dim DateFrom As String
    Dim DateTo As String
    Dim i As Integer = 0
    Dim Pri_BranchCode As String
    Dim Pri_lst_mobile As String
    Dim Pri_lst_from As String
    Dim Pri_lst_direction As String
    Dim Pri_lst_pxID As String
    Dim Pri_lst_content As String
    'Scroll bar event
    Dim WithEvents sl As MyListener

    Public Structure PatientInformation
        Dim Name As String
    End Structure
  
    Private Sub combo_Branch_List()
        Try
            Dim i = 1
            Dim query As String

            lbDBconnection.Text = ""
            If ClientAccAdmin = 1 Then
                query = "SELECT * FROM `ref_branch` WHERE CODE NOT LIKE '00' ORDER BY name ASC"
            Else
                query = "SELECT * FROM `ref_branch` WHERE CODE NOT LIKE '00' AND CODE='" & ClientBranch & "' ORDER BY name ASC"
            End If
            Dim connection As New MySqlConnection(connStrBMG)
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader
            cbBranch.Text = "[Branch]"
            cbBranch.Items.Clear()

            connection.Open()
            reader = cmd.ExecuteReader()
            If reader.HasRows = True Then

                cbBranch.Items.Add("Birthday")

                While reader.Read
                    cbBranch.Items.Add(reader.Item("name").ToString())
                End While
            End If

            cbBranch.SelectedIndex = 0
            connection.Close()
        Catch ex As Exception
            lbDBconnection.Text = ex.Message
            'MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Combo_Departist_List()
        Try
            Dim i As Integer = 1
            Dim query As String

            lbDBconnection.Text = ""

            If ClientAccAdmin = 1 Then
                query = "SELECT group_name FROM `ref_user_access` WHERE LENGTH(group_name)>1 AND dapertment_enable=1 ORDER BY group_name"
            Else
                query = "SELECT group_name FROM `ref_user_access` WHERE LENGTH(group_name)>1 AND dapertment_enable=1 AND department_key='" & ClientDepartmentKey & "' ORDER BY group_name"
            End If

            Dim connection As New MySqlConnection(connStrBMG)
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader


            cbBranch.Text = "[Branch]"
            cbBranch.Items.Clear()

            connection.Open()
            reader = cmd.ExecuteReader()
            If reader.HasRows = True Then

                If ClientAccAdmin < 1 Then
                    cbBranch.Items.Add("Birthday")
                End If

                While reader.Read
                    cbBranch.Items.Add(reader.Item("group_name").ToString())
                End While
            End If
            cbBranch.SelectedIndex = 0
            connection.Close()
        Catch ex As Exception
            lbDBconnection.Text = ex.Message
        End Try

    End Sub
    Private Sub ListViewPxSMS()
        lsPxSMS.Items.Clear()
        lsPxSMS.Columns.Clear()
        lsPxSMS.Columns.Add("PxID", 0)
        lsPxSMS.Columns.Add("Patient name", 160)
        lsPxSMS.Columns.Add("SMS", 50, HorizontalAlignment.Center)
        lsPxSMS.Columns.Add("Mobile", 0)
        lsPxSMS.Columns.Add("Read", 0)
    End Sub
    Private Sub ListViewPx_LstSMS()
        lstPx_lsSMS.Items.Clear()
        lstPx_lsSMS.Columns.Clear()
        lstPx_lsSMS.Columns.Add(" ", 0)
        lstPx_lsSMS.Columns.Add("From", 0)
        lstPx_lsSMS.Columns.Add("Mobile", 0)
        lstPx_lsSMS.Columns.Add("Content", 450)
        lstPx_lsSMS.Columns.Add("Date", 130)
        lstPx_lsSMS.Columns.Add("Sent by", 100)
        lstPx_lsSMS.Columns.Add("Invalid", 0)
    End Sub

    Private Sub frmPatientSMS_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        i = 0
        Timer1.Enabled = True
        FFSMS.Timer1.Enabled = False
    End Sub

    Private Sub frmPatientSMS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtContent.Text = ""
        ListViewPxSMS()
        lbBranchDB.Text = ClientBranchDBName
        FFMain.BranchDept.Text = ClientDepartmentKey
        FFMain.ToolStripStatusLabel2.Text = ClientAsDept

        RetriveSMS()                    'Messages_sms
        ClientBrachAsDeptAssiged()      '
        SetToBlank()                    '

        sl = New MyListener(lsPxSMS)

        If ClientDepartmentKey = "HD" Or ClientUserAccessGroup = "IT Admins" Then

            btnUnread.Visible = True
        Else
            btnUnread.Visible = False
        End If
    End Sub
    Public Sub ClientBrachAsDeptAssiged()

        If FFMain.ToolStripStatusLabel2.Text = "1" Then
            cbViewBy.SelectedIndex = 1
            Combo_Departist_List()
            cbBranch.Text = ClientUserAccessGroup
        Else
            cbViewBy.SelectedIndex = 0
            combo_Branch_List()
            cbBranch.Text = ClientBranchName
        End If
    End Sub
    Public Sub RetriveSMS()
        Try
            Dim query As String
            DateFrom = Format(dpFrom.Value, "yyyy-MM-dd")
            DateTo = Format(dpTo.Value, "yyyy-MM-dd")
            lbDBconnection.Text = ""
            If FFMain.ToolStripStatusLabel2.Text = "1" Then
                query = "SELECT DISTINCT PatientID, IFNULL((SELECT CONCAT(first_name,' ', last_name) FROM patient WHERE patient.Patient_ID=messages.PatientID), fromaddress) pxName, " _
                & " COUNT(patientid) SMS, fromaddress, MIN(Read_Stats) Read_Stats FROM messages WHERE DATE(doc) BETWEEN '" & DateFrom & "' AND '" & DateTo & "' AND DeptKey='" & FFMain.BranchDept.Text.Trim & "' GROUP BY fromaddress ORDER BY doc DESC"
            Else
                If StrConv(cbBranch.Text.Trim, VbStrConv.Uppercase) = "BIRTHDAY" Then

                    If FFMain.ToolStripStatusLabel2.Text = "1" Then
                        query = "SELECT DISTINCT PatientID, IFNULL((SELECT CONCAT(first_name,' ', last_name) FROM patient WHERE patient.PatientID=messages.PatientID),fromaddress) pxName, " _
                        & " COUNT(patientid) SMS, fromaddress, MIN(Read_Stats) Read_Stats FROM messages WHERE DATE(doc) BETWEEN '" & DateFrom & "' AND '" & DateTo & "' AND branch='" & ClientDepartmentKey & "' AND DeptKey='" & FFMain.BranchDept.Text.Trim & "' GROUP BY fromaddress ORDER BY doc DESC"
                    Else
                        query = "SELECT DISTINCT PatientID, IFNULL((SELECT CONCAT(first_name,' ', last_name) FROM patient WHERE patient.PatientID=messages.PatientID),fromaddress) pxName, " _
                        & " COUNT(patientid) SMS, fromaddress, MIN(Read_Stats) Read_Stats FROM messages WHERE DATE(doc) BETWEEN '" & DateFrom & "' AND '" & DateTo & "' AND branch='" & ClientBranch & "' AND DeptKey='" & FFMain.BranchDept.Text.Trim & "' GROUP BY fromaddress ORDER BY doc DESC"
                    End If
                Else
                    query = "SELECT DISTINCT PatientID, IFNULL((SELECT CONCAT(first_name,' ', last_name) FROM patient WHERE patient.PatientID=messages.PatientID),fromaddress) pxName, " _
                    & " COUNT(patientid) SMS, fromaddress, MIN(Read_Stats) Read_Stats FROM messages WHERE DATE(doc) BETWEEN '" & DateFrom & "' AND '" & DateTo & "' AND branch='" & FFMain.BranchDept.Text.Trim & "' AND DeptKey='" & FFMain.BranchDept.Text.Trim & "' GROUP BY fromaddress ORDER BY doc DESC"
                End If

            End If

            Dim connection As New MySqlConnection(connStrSMS)
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader
            connection.Open()
            reader = cmd.ExecuteReader()
            'this will clear the listbox
            'lstMessages.Items.Clear()
            'ListViewPxSMS()
            ListViewPxSMS()
            If reader.HasRows = True Then
                While reader.Read
                    Dim ls As New ListViewItem(reader.Item("patientid").ToString.Trim())
                    ls.SubItems.Add(reader.Item("pxName").ToString.Trim())
                    ls.SubItems.Add(reader.Item("sms").ToString.Trim())
                    ls.SubItems.Add(px_pri_mobile(reader.Item("fromaddress").ToString.Trim()))
                    ls.SubItems.Add(reader.Item("Read_Stats").ToString.Trim())
                    lsPxSMS.Items.Add(ls)
                End While
            End If
            connection.Close()

            For Each item As ListViewItem In lsPxSMS.Items
                Dim pxType As String = item.SubItems(4).Text.Trim
                lsPxSMS.Items(item.Index).UseItemStyleForSubItems = False

                If pxType = 0 Then
                    item.BackColor = Color.LightGreen
                    item.SubItems(1).BackColor = Color.LightGreen
                    item.SubItems(2).BackColor = Color.LightGreen
                    item.SubItems(3).BackColor = Color.LightGreen
                    item.SubItems(4).BackColor = Color.LightGreen
                End If
            Next

        Catch ex As Exception
            i = 0
            lbDBconnection.Text = ex.Message
            'MsgBox(ex.Message & vbNewLine & "RetriveSMS::lsPxSMS.Items", , "Belo SMS::View")
        End Try

    End Sub

    Public Sub RetriveSMSUnread()
        Try
            Dim query As String
            DateFrom = Format(dpFrom.Value, "yyyy-MM-dd")
            DateTo = Format(dpTo.Value, "yyyy-MM-dd")
            lbDBconnection.Text = ""

            If FFMain.ToolStripStatusLabel2.Text = "1" Then
                query = "SELECT DISTINCT PatientID, IFNULL((SELECT CONCAT(first_name,' ', last_name) FROM patient WHERE patient.Patient_ID=messages.PatientID), fromAddress) pxName, " _
                & " COUNT(patientid) SMS, FromAddress, MIN(Read_Stats) Read_Stats FROM messages WHERE DeptKey='" & FFMain.BranchDept.Text.Trim & "' and Read_Stats = 0  GROUP BY FromAddress ORDER BY doc DESC"
            Else
                If StrConv(cbBranch.Text.Trim, VbStrConv.Uppercase) = "BIRTHDAY" Then

                    If FFMain.ToolStripStatusLabel2.Text = "1" Then
                        query = "SELECT DISTINCT PatientID, IFNULL((SELECT CONCAT(first_name,' ', last_name) FROM patient WHERE patient.Patient_ID=messages.PatientID),fromAddress) pxName, " _
                        & " COUNT(patientid) SMS, FromAddress, MIN(Read_Stats) Read_Stats FROM messages WHERE branch='" & ClientDepartmentKey & "' AND DeptKey='" & FFMain.BranchDept.Text.Trim & "'  and Read_Stats = 0 GROUP BY fromAddress ORDER BY doc DESC"
                    Else
                        query = "SELECT DISTINCT PatientID, IFNULL((SELECT CONCAT(first_name,' ', last_name) FROM patient WHERE patient.Patient_ID=messages.PatientID),fromAddress) pxName, " _
                        & " COUNT(patientid) SMS, FromAddress, MIN(Read_Stats) Read_Stats FROM messages WHERE branch='" & ClientBranch & "' AND DeptKey='" & FFMain.BranchDept.Text.Trim & "' and Read_Stats = 0 GROUP BY fromAddress ORDER BY doc DESC"
                    End If
                Else
                    query = "SELECT DISTINCT PatientID, IFNULL((SELECT CONCAT(first_name,' ', last_name) FROM patient WHERE patient.Patient_ID=messages.PatientID),fromAddress) pxName, " _
                    & " COUNT(patientid) SMS, FromAddress, MIN(Read_Stats) Read_Stats FROM messages WHERE  AND branch='" & FFMain.BranchDept.Text.Trim & "' AND DeptKey='" & FFMain.BranchDept.Text.Trim & "' and Read_Stats = 0 GROUP BY fromAddress ORDER BY doc DESC"
                End If

            End If

            Dim connection As New MySqlConnection(connStrBMG)
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader
            connection.Open()
            reader = cmd.ExecuteReader()
            'this will clear the listbox
            'lstMessages.Items.Clear()
            'ListViewPxSMS()
            ListViewPxSMS()
            If reader.HasRows = True Then
                While reader.Read
                    Dim ls As New ListViewItem(reader.Item("patientid").ToString.Trim())
                    ls.SubItems.Add(reader.Item("pxName").ToString.Trim())
                    ls.SubItems.Add(reader.Item("sms").ToString.Trim())
                    ls.SubItems.Add(px_pri_mobile(reader.Item("Sender").ToString.Trim()))
                    ls.SubItems.Add(reader.Item("Read_Stats").ToString.Trim())
                    lsPxSMS.Items.Add(ls)
                End While
            End If
            connection.Close()

            For Each item As ListViewItem In lsPxSMS.Items
                Dim pxType As String = item.SubItems(4).Text.Trim
                lsPxSMS.Items(item.Index).UseItemStyleForSubItems = False

                If pxType = 0 Then
                    item.BackColor = Color.LightGreen
                    item.SubItems(1).BackColor = Color.LightGreen
                    item.SubItems(2).BackColor = Color.LightGreen
                    item.SubItems(3).BackColor = Color.LightGreen
                    item.SubItems(4).BackColor = Color.LightGreen
                End If
            Next

        Catch ex As Exception
            i = 0
            lbDBconnection.Text = ex.Message
            'MsgBox(ex.Message & vbNewLine & "RetriveSMS::lsPxSMS.Items", , "Belo SMS::View")
        End Try

    End Sub


    Public Sub RetriveSMSfILTER()
        Try
            Dim query As String
            DateFrom = Format(dpFrom.Value, "yyyy-MM-dd")
            DateTo = Format(dpTo.Value, "yyyy-MM-dd")
            lbDBconnection.Text = ""

            If FFMain.ToolStripStatusLabel2.Text = "1" Then
                query = "SELECT DISTINCT PatientID, IFNULL((SELECT CONCAT(first_name,' ', last_name) FROM patient WHERE patient.Patient_ID=messages.PatientID), FromAddress) pxName, " _
                & " COUNT(patientid) SMS, fromaddress, MIN(Read_Stats) Read_Stats FROM messages WHERE DATE(doc) BETWEEN '" & DateFrom & "' AND '" & DateTo & "' AND DeptKey='" & FFMain.BranchDept.Text.Trim & "'" _
                & " AND FromAddress IN (SELECT REPLACE(mobile_number,'09','+639') FROM patient WHERE CONCAT(first_name, ' ', last_name)  LIKE '%" & txtFilter.Text.Trim & "%' ORDER  BY patientid) GROUP BY fromaddress ORDER BY doc DESC"
            Else
                If StrConv(cbBranch.Text.Trim, VbStrConv.Uppercase) = "BIRTHDAY" Then

                    If FFMain.ToolStripStatusLabel2.Text = "1" Then
                        query = "SELECT DISTINCT PatientID, IFNULL((SELECT CONCAT(first_name,' ', last_name) FROM patient WHERE patient.Patient_ID=messages.PatientID),FromAddress) pxName, " _
                        & " COUNT(patientid) SMS, fromaddress, MIN(Read_Stats) Read_Stats FROM messages WHERE DATE(doc) BETWEEN '" & DateFrom & "' AND '" & DateTo & "' AND branch='" & ClientDepartmentKey & "'  AND DeptKey='" & FFMain.BranchDept.Text.Trim & "' AND " _
                        & " FromAddress IN (SELECT REPLACE(mobile_number,'09','+639') FROM patient WHERE CONCAT(first_name, ' ', last_name)  LIKE '%" & txtFilter.Text.Trim & "%' ORDER  BY patient_id) GROUP BY fromaddress ORDER BY doc DESC"
                    Else
                        query = "SELECT DISTINCT PatientID, IFNULL((SELECT CONCAT(first_name,' ', last_name) FROM patient WHERE patient.Patient_ID=messages.PatientID),FromAddress) pxName, " _
                        & " COUNT(patientid) SMS, fromaddress, MIN(Read_Stats) Read_Stats FROM messages WHERE DATE(doc) BETWEEN '" & DateFrom & "' AND '" & DateTo & "' AND branch='" & ClientBranch & "' AND DeptKey='" & FFMain.BranchDept.Text.Trim & "' AND " _
                        & " FromAddress IN (SELECT REPLACE(mobile_number,'09','+639') FROM patient WHERE  CONCAT(first_name, ' ', last_name)  LIKE '%" & txtFilter.Text.Trim & "%' ORDER  BY patient_id) GROUP BY fromaddress ORDER BY doc DESC"
                    End If
                Else
                    query = "SELECT DISTINCT PatientID, IFNULL((SELECT CONCAT(first_name,' ', last_name) FROM patient WHERE patient.Patient_ID=messages.PatientID),FromAddress) pxName, " _
                    & " COUNT(patientid) SMS, fromaddress, MIN(Read_Stats) Read_Stats FROM messages WHERE DATE(doc) BETWEEN '" & DateFrom & "' AND '" & DateTo & "' AND branch='" & FFMain.BranchDept.Text.Trim & "' AND DeptKey='" & FFMain.BranchDept.Text.Trim & "' AND " _
                    & " FromAddress IN (SELECT REPLACE(mobile_number,'09','+639') FROM patient WHERE  CONCAT(first_name, ' ', last_name)  LIKE '%" & txtFilter.Text.Trim & "%' ORDER  BY patient_id) GROUP BY fromaddress ORDER BY doc DESC"
                End If

            End If

            Dim connection As New MySqlConnection(connStrSMS)
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader
            connection.Open()
            reader = cmd.ExecuteReader()
            'this will clear the listbox
            'lstMessages.Items.Clear()
            'ListViewPxSMS()
            ListViewPxSMS()
            If reader.HasRows = True Then
                While reader.Read
                    Dim ls As New ListViewItem(reader.Item("patientid").ToString.Trim())
                    ls.SubItems.Add(reader.Item("pxName").ToString.Trim())
                    ls.SubItems.Add(reader.Item("sms").ToString.Trim())
                    ls.SubItems.Add(px_pri_mobile(reader.Item("FromAddress").ToString.Trim()))
                    ls.SubItems.Add(reader.Item("Read_Stats").ToString.Trim())
                    lsPxSMS.Items.Add(ls)
                End While
            End If
            connection.Close()

            For Each item As ListViewItem In lsPxSMS.Items
                Dim pxType As String = item.SubItems(4).Text.Trim
                lsPxSMS.Items(item.Index).UseItemStyleForSubItems = False

                If pxType = 0 Then
                    item.BackColor = Color.LightGreen
                    item.SubItems(1).BackColor = Color.LightGreen
                    item.SubItems(2).BackColor = Color.LightGreen
                    item.SubItems(3).BackColor = Color.LightGreen
                    item.SubItems(4).BackColor = Color.LightGreen
                End If
            Next

        Catch ex As Exception
            i = 0
            lbDBconnection.Text = ex.Message
            'MsgBox(ex.Message & vbNewLine & "RetriveSMS::lsPxSMS.Items", , "Belo SMS::View")
        End Try

    End Sub



    Function RetrivePX_SMS(ByVal px_Sender As String)
        Try
            Dim query As String
            lbDBconnection.Text = ""

            If ClientAsDept = 1 Then
                query = "SELECT (SELECT CONCAT(first_name,' ', last_name) FROM patient WHERE patient.Patient_ID=messages.PatientID) pxName, " _
                & " FromAddress,DirectionID,body,doc,Username,invalid FROM messages WHERE DATE(doc) BETWEEN '" & DateFrom & "' AND '" & DateTo & "' AND DeptKey='" & FFMain.BranchDept.Text.Trim & "' AND REPLACE(FromAddress,' ','')='" & px_Sender & "' ORDER BY id DESC"
            Else
                query = "SELECT (SELECT CONCAT(firstname,' ', lastname) FROM patient WHERE patient.PatientID=messages_sms.PatientID) pxName, " _
                & " FromAddress,DirectionID,body,doc,Username,invalid FROM messages WHERE DATE(doc) BETWEEN '" & DateFrom & "' AND '" & DateTo & "' AND branch='" & FFMain.BranchDept.Text.Trim & "' AND DeptKey='" & FFMain.BranchDept.Text.Trim & "' AND REPLACE(FromAddress,' ','')='" & px_Sender & "' ORDER BY id DESC"

                If StrConv(cbBranch.Text.Trim, VbStrConv.Uppercase) = "BIRTHDAY" Then

                    query = "SELECT (SELECT CONCAT(firstname,' ', lastname) FROM patient WHERE patient.PatientID=messages_sms.PatientID) pxName, " _
                    & " FromAddress,DirectionID,body,doc,Username,invalid FROM messages WHERE DATE(doc) BETWEEN '" & DateFrom & "' AND '" & DateTo & "' AND branch='" & FFMain.KeyToolStrip.Text.Trim & "' AND DeptKey='" & FFMain.BranchDept.Text.Trim & "' AND REPLACE(FromAddress,' ','')='" & px_Sender & "' ORDER BY id DESC"
                Else
                    query = "SELECT (SELECT CONCAT(firstname,' ', lastname) FROM patient WHERE patient.PatientID=messages_sms.PatientID) pxName, " _
                    & " FromAddress,DirectionID,body,doc,Username,invalid FROM messages WHERE DATE(doc) BETWEEN '" & DateFrom & "' AND '" & DateTo & "' AND branch='" & FFMain.BranchDept.Text.Trim & "' AND DeptKey='" & FFMain.BranchDept.Text.Trim & "' AND REPLACE(FromAddress,' ','')='" & px_Sender & "' ORDER BY id DESC"

                End If
            End If

            'MsgBox(query)
            Dim connection As New MySqlConnection(connStrSMS)
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader
            connection.Open()
            reader = cmd.ExecuteReader()
            'this will clear the listbox
            'lstPx_lsSMS.Items(item.Index).UseItemStyleForSubItems = False
            lstPx_lsSMS.Items.Clear()
            ListViewPx_LstSMS()
            If reader.HasRows = True Then
                While reader.Read
                    Dim ls As New ListViewItem(reader.Item("DirectionID").ToString.Trim())
                    ls.SubItems.Add(reader.Item("pxName").ToString.Trim())
                    ls.SubItems.Add(Replace(reader.Item("FromAddress").ToString.Trim(), " ", ""))
                    ls.SubItems.Add(reader.Item("body").ToString.Trim())
                    ls.SubItems.Add(Format(reader.Item("doc"), "MMM dd, yyyy hh:mm tt"))
                    ls.SubItems.Add(reader.Item("Username").ToString())
                    ls.SubItems.Add(reader.Item("invalid").ToString())
                    lstPx_lsSMS.Items.Add(ls)
                End While
            End If
            connection.Close()


            For Each item As ListViewItem In lstPx_lsSMS.Items
                Dim pxType As String = item.Text
                Dim pxInvalid As String = item.SubItems(6).Text.Trim
                lstPx_lsSMS.Items(item.Index).UseItemStyleForSubItems = False
                'If received text change backcoder to lightgreen
                If pxType = 1 Then
                    item.BackColor = Color.LightGreen
                    item.SubItems(1).BackColor = Color.LightGreen
                    item.SubItems(2).BackColor = Color.LightGreen
                    item.SubItems(3).BackColor = Color.LightGreen
                    item.SubItems(4).BackColor = Color.LightGreen
                    item.SubItems(5).BackColor = Color.LightGreen
                End If
                If pxInvalid = 1 Then
                    item.BackColor = Color.LightGreen
                    item.SubItems(1).BackColor = Color.OrangeRed
                    item.SubItems(1).ForeColor = Color.White
                    item.SubItems(2).BackColor = Color.OrangeRed
                    item.SubItems(2).ForeColor = Color.White
                    item.SubItems(3).BackColor = Color.OrangeRed
                    item.SubItems(3).ForeColor = Color.White
                    item.SubItems(4).BackColor = Color.OrangeRed
                    item.SubItems(4).ForeColor = Color.White
                    item.SubItems(5).BackColor = Color.OrangeRed
                    item.SubItems(5).ForeColor = Color.White
                End If
            Next

        Catch ex As Exception
            lbDBconnection.Text = ex.Message
            MsgBox(ex.Message)
        End Try

    End Function

    Private Sub lsPxSMS_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsPxSMS.Click
        'lsPxSMS.Enabled = False
        'Cursor = Cursors.WaitCursor
        SetToBlank()

        'timer set to 0
        i = 0

        Timer1.Enabled = False
        On Error Resume Next

        If lsPxSMS.Items.Count > 0 Then

            Pri_lst_pxID = lsPxSMS.SelectedItems(0).Text.Trim()
            Dim pxMobile As String = lsPxSMS.SelectedItems(0).SubItems(3).Text.Trim()
            Dim pxStat As Integer = lsPxSMS.SelectedItems(0).SubItems(4).Text.Trim()
            lbpxID.Text = Pri_lst_pxID
            'MsgBox(pxMobile)
            'pxMobile = Replace(pxMobile,"+","")
            RetrivePX_SMS(pxMobile)

            If pxStat < 1 Then
                SMS_Read_status(pxMobile)
                lsPxSMS.Items(lsPxSMS.FocusedItem.Index).SubItems(4).Text = "1"
            End If
        End If

        For Each item As ListViewItem In lsPxSMS.Items
            Dim pxType As String = item.SubItems(4).Text.Trim
            lsPxSMS.Items(item.Index).UseItemStyleForSubItems = False

            If pxType = 1 Then
                item.BackColor = Color.White
                item.SubItems(1).BackColor = Color.White
                item.SubItems(2).BackColor = Color.White
                item.SubItems(3).BackColor = Color.White
                item.SubItems(4).BackColor = Color.White
            End If
        Next
        Timer1.Enabled = True
        lsPxSMS.Enabled = True
        Cursor = Cursors.Default
    End Sub
    Function SMS_Read_status(px_RS_ID As String)
        'Dim sql As String = "UPDATE `messages_sms` SET Read_Stats='1'  WHERE Sender='" & px_RS_ID & "'"
        Dim sql As String = "UPDATE `messages` SET Read_Stats='1'  WHERE fromaddress='" & px_RS_ID & "'"
        Try
            Dim rowsEffected = 0
            Dim connection As New MySqlConnection(connStrSMS)
            Dim cmd As New MySqlCommand(sql, connection)

            connection.Open()

            rowsEffected = cmd.ExecuteNonQuery()

            connection.Close()

            Return rowsEffected
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function
    Private Sub lstPx_lsSMS_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstPx_lsSMS.Click
        On Error Resume Next

        If lstPx_lsSMS.Items.Count > 0 Then

            Pri_lst_direction = lstPx_lsSMS.SelectedItems(0).Text
            Pri_lst_from = lstPx_lsSMS.SelectedItems(0).SubItems(1).Text.Trim()
            Pri_lst_mobile = lstPx_lsSMS.SelectedItems(0).SubItems(2).Text.Trim()
            Pri_lst_content = lstPx_lsSMS.SelectedItems(0).SubItems(3).Text.Trim()

            lbFrom.Text = DirectionFromTo(Pri_lst_direction) & Pri_lst_from & " (" & Pri_lst_mobile & ")"
            lbDate.Text = lstPx_lsSMS.SelectedItems(0).SubItems(4).Text.Trim()

            txtContent.Text = Pri_lst_content
        End If

    End Sub

    Private Sub SetToBlank()
        txtContent.Text = ""
        lbFrom.Text = ""
        lbDate.Text = ""
    End Sub

    Private Sub btView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btView.Click
        Timer1.Enabled = False
        ListViewPx_LstSMS()'SET COLUMNS IN LISTVIEW
        SetToBlank()
        RetriveSMS()
        lstPx_lsSMS.Items.Clear()
        Timer1.Enabled = True
    End Sub

    Private Sub lsPxSMS_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsPxSMS.GotFocus
        On Error Resume Next

        If lsPxSMS.Items.Count > 0 Then
            lsPxSMS.Items(lsPxSMS.FocusedItem.Index).Selected = True
            lsPxSMS.Select()
            lsPxSMS_Click(Me, EventArgs.Empty)
            MobileUp

        End If

    End Sub

    Private Sub lsPxSMS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lsPxSMS.KeyDown
        'timer set to 0
        i = 0
    End Sub

    Private Sub lsPxSMS_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lsPxSMS.KeyUp
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
            lsPxSMS_Click(Me, EventArgs.Empty)
        End If
    End Sub

    Private Sub lsPxSMS_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lsPxSMS.MouseClick
        i = 0
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If lsPxSMS.Items.Count > 0 Then
                ContextMenuMessages.Show(lsPxSMS, e.Location)
            End If
        End If
    End Sub

    Private Sub cbBranch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbBranch.SelectedIndexChanged
        If cbBranch.Text = "CCA" Or cbBranch.Text = "CCA Admin" Then
            btnUnread.Visible = True
        Else
            btnUnread.Visible = False
        End If

        i = 0

        If FFMain.ToolStripStatusLabel2.Text = "1" Then
            FFMain.BranchDept.Text = Department_list_SMS(cbBranch.Text.Trim)
        Else
            lbBranchDB.Text = px_BranchDatabaseName(cbBranch.Text.Trim)
            FFMain.BranchDept.Text = Pri_BranchCode
            cbBranch.Enabled = True
        End If

        btView_Click(Me, EventArgs.Empty)
    End Sub
    Function px_BranchDatabaseName(ByVal BranchName As String) As String
        Try

            Dim query As String = "SELECT * FROM `ref_branch` WHERE NAME LIKE '%" & BranchName & "%'"
            Dim connection As New MySqlConnection(connStrBMG)
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader
            connection.Open()
            reader = cmd.ExecuteReader()

            lbDBconnection.Text = ""

            If reader.HasRows = True Then
                While reader.Read
                    px_BranchDatabaseName = reader.Item("db_name").ToString()
                    Pri_BranchCode = reader.Item("code").ToString()
                End While
            Else
                px_BranchDatabaseName = ""
                Pri_BranchCode = "BD"
            End If
            connection.Close()
        Catch ex As Exception
            lbDBconnection.Text = ex.Message
            'MsgBox(ex.Message)
        End Try
    End Function
    Function Department_list_SMS(ByVal GroupName As String) As String
        Try
            lbDBconnection.Text = ""
            GroupName = Replace(GroupName, "'", "\'")
            Dim query As String = "SELECT department_key FROM `ref_user_access` WHERE group_name='" & GroupName & "'"
            Dim connection As New MySqlConnection(connStrBMG)
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader
            connection.Open()
            reader = cmd.ExecuteReader()

            If reader.HasRows = True Then
                While reader.Read
                    Department_list_SMS = reader.Item("department_key").ToString()
                End While
            Else
                Department_list_SMS = ""
            End If
            connection.Close()
        Catch ex As Exception
            lbDBconnection.Text = ex.Message
            'MsgBox(ex.Message)
        End Try
    End Function
    Private Sub lstPx_lsSMS_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstPx_lsSMS.GotFocus

        If lstPx_lsSMS.Items.Count > 0 Then
            Try
                lstPx_lsSMS.Items(lsPxSMS.FocusedItem.Index).Selected = True
                lstPx_lsSMS.Select()
                lstPx_lsSMS_Click(Me, EventArgs.Empty)
            Catch ex As Exception
                lstPx_lsSMS.Items(0).Selected = True
                lstPx_lsSMS.Select()
                lstPx_lsSMS_Click(Me, EventArgs.Empty)
            End Try
        End If
    End Sub

    Private Sub lstPx_lsSMS_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstPx_lsSMS.KeyUp
        lstPx_lsSMS_Click(Me, EventArgs.Empty)
    End Sub

    Function px_pri_mobile(ByVal mobile As String) As String

        Dim StrMobile As String

        mobile = Replace(Replace(mobile.Trim, " ", ""), "-", "")
        If Len(mobile) < 1 Then
            px_pri_mobile = ""
            Exit Function
        End If

        Select Case Mid(mobile.Trim, 1, 2)
            Case "09"
                If Len(mobile.Trim) >= 11 Then
                    StrMobile = Mid(mobile.Trim, 2, 10)
                    px_pri_mobile = "+63" & StrMobile
                Else
                    px_pri_mobile = ""
                End If
            Case "63"
                If Len(mobile.Trim) >= 12 Then
                    StrMobile = Mid(mobile.Trim, 1, 12)
                    px_pri_mobile = "+" & StrMobile
                Else
                    px_pri_mobile = ""
                End If
            Case Else
                Select Case Mid(mobile.Trim, 1, 3)
                    Case "+63"
                        If Len(mobile.Trim) >= 13 Then
                            StrMobile = Mid(mobile.Trim, 1, 13)
                            px_pri_mobile = StrMobile
                        Else
                            px_pri_mobile = ""
                        End If
                    Case Else
                        Select Case Mid(mobile.Trim, 1, 1)
                            Case "9"
                                If Len(mobile.Trim) >= 9 Then
                                    StrMobile = Mid(mobile.Trim, 1, 10)
                                    px_pri_mobile = "+63" & StrMobile
                                Else
                                    px_pri_mobile = ""
                                End If
                            Case Else
                                px_pri_mobile = ""
                        End Select
                End Select
        End Select
    End Function

    Private Sub ReplyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReplyToolStripMenuItem.Click
        Try
            FFReplySMS.Show()
            FFReplySMS.BringToFront()

            FFReplySMS.txtMobile.Text = lsPxSMS.SelectedItems(0).SubItems(3).Text.Trim()
            FFReplySMS.pxToolStrip.Visible = True
            FFReplySMS.pxToolStrip.Text = lsPxSMS.SelectedItems(0).SubItems(1).Text.Trim()
            FFReplySMS.pxIDToolStrip.Text = lsPxSMS.SelectedItems(0).Text.Trim()
            FFReplySMS.txtMobile.Focus()
            FFReplySMS.txtMobile.Enabled = true
            FFReplySMS.txtMessage.Focus()
        Catch ex As Exception
            FFReplySMS = New frmSMSReply()
            FFReplySMS.Show()
            FFReplySMS.BringToFront()

            FFReplySMS.txtMobile.Text = lsPxSMS.SelectedItems(0).SubItems(3).Text.Trim()
            FFReplySMS.pxToolStrip.Visible = True
            FFReplySMS.pxToolStrip.Text = lsPxSMS.SelectedItems(0).SubItems(1).Text.Trim()
            FFReplySMS.pxIDToolStrip.Text = lsPxSMS.SelectedItems(0).Text.Trim()
            FFReplySMS.txtMobile.Focus()
            FFReplySMS.txtMobile.Enabled = true
            FFReplySMS.txtMessage.Focus()
        End Try
    End Sub

    Private Sub lstPx_lsSMS_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstPx_lsSMS.MouseClick
        i = 0
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If lsPxSMS.Items.Count > 0 Then
                ContextMessageInbox.Show(lstPx_lsSMS, e.Location)
            End If
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Try
            FFReplySMS.Show()
            FFReplySMS.BringToFront()

            FFReplySMS.txtMobile.Text = Pri_lst_mobile
            FFReplySMS.pxToolStrip.Visible = True
            FFReplySMS.pxToolStrip.Text = Pri_lst_from
            FFReplySMS.pxIDToolStrip.Text = Pri_lst_pxID
            FFReplySMS.txtMobile.Focus()
            FFReplySMS.txtMobile.Enabled = true 
            FFReplySMS.txtMessage.Focus()
        Catch ex As Exception
            FFReplySMS = New frmSMSReply()
            FFReplySMS.Show()
            FFReplySMS.BringToFront()

            FFReplySMS.txtMobile.Text = Pri_lst_mobile
            FFReplySMS.pxToolStrip.Visible = True
            FFReplySMS.pxToolStrip.Text = Pri_lst_from
            FFReplySMS.pxIDToolStrip.Text = Pri_lst_pxID
            FFReplySMS.txtMobile.Focus()
            FFReplySMS.txtMobile.Enabled = True
            FFReplySMS.txtMessage.Focus()
        End Try
    End Sub

    Private Sub ResendToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResendToolStripMenuItem.Click
        Try
            FFResend.Show()
            FFResend.BringToFront()

            FFResend.txtMobile.Text = lsPxSMS.SelectedItems(0).SubItems(3).Text.Trim()
            FFResend.pxToolStrip.Visible = True
            FFResend.pxToolStrip.Text = lsPxSMS.SelectedItems(0).SubItems(1).Text.Trim()
            FFResend.pxIDToolStrip.Text = lsPxSMS.SelectedItems(0).Text.Trim()
            FFResend.txtMobile.Focus()
            FFResend.txtMobile.Enabled = True
            FFResend.txtMessage.Text = lstPx_lsSMS.SelectedItems(0).SubItems(3).Text.Trim()
            FFResend.txtMessage.SelectionStart = Len(lstPx_lsSMS.SelectedItems(0).SubItems(3).Text.Trim())
            FFResend.TxtLenghtToolStrip.Text = Len(Pri_lst_content)
            FFResend.txtMessage.ReadOnly = True
            FFResend.txtMessage.Focus()

        Catch ex As Exception
            FFResend = New frmSMSResend()
            Thread.Sleep(200)
            FFResend.txtMobile.Text = Pri_lst_mobile
            FFResend.pxToolStrip.Text = Pri_lst_from
            FFResend.pxIDToolStrip.Text = Pri_lst_pxID
            FFResend.txtMobile.Focus()
            FFResend.txtMessage.Text = Pri_lst_content
            FFResend.txtMessage.SelectionStart = Len(Pri_lst_content)
            FFResend.TxtLenghtToolStrip.Text = "Length : " & Len(Pri_lst_content)
            FFResend.lbUsernameAndBranchname.Text = UserAndBranchName
            Thread.Sleep(500)
            FFResend.Show()
            FFResend.BringToFront()

        End Try
    End Sub

    Private Sub btCheckSMS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCheckSMS.Click
        RetriveSMS()
    End Sub

    
Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        i += 1
        lbTimer.Text = i

        If i > 20 Then
            btCheckSMS_Click(Me, EventArgs.Empty)
            i = 0
        End If



    End Sub

    Function SMS_Read(ByVal SQL As String) As Integer
        Try
            Dim connection As New MySqlConnection(connStrBMG)
            Dim cmd As New MySqlCommand(SQL, connection)
            Dim reader As MySqlDataReader
            connection.Open()
            reader = cmd.ExecuteReader()

            If reader.HasRows = True Then
                While reader.Read
                    SMS_Read = reader.Item("Read_Stats").ToString()
                End While
            Else
                SMS_Read = "0"
            End If

            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message, , "Belo SMS: Function")
        End Try
    End Function
    Private Sub ContextMenuMessages_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ContextMenuMessages.VisibleChanged
        Timer1.Enabled = True
    End Sub

    Private Sub btViewCurrentSMS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btViewCurrentSMS.Click

        dpFrom.Value = Now()
        dpTo.Value = Now()

        cbViewBy_SelectedIndexChanged(Me, EventArgs.Empty)

        DateFrom = Format(dpFrom.Value, "yyyy-MM-dd")
        DateTo = Format(dpTo.Value, "yyyy-MM-dd")

        SetToBlank()
        RetriveSMS()
        lstPx_lsSMS.Items.Clear()

    End Sub

    Public Sub cbViewBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbViewBy.SelectedIndexChanged
        'On Error Resume Next
        i = 0
        cbBranch.Enabled = False
        If cbViewBy.SelectedIndex = 0 Then
            'ClientAsDept = 0
            FFMain.ToolStripStatusLabel2.Text = "0"
        Else
            'ClientAsDept = 1
            FFMain.ToolStripStatusLabel2.Text = "1"
        End If

        FFMain.access_rights()
        ClientBrachAsDeptAssiged()
        cbBranch.Enabled = True
    End Sub

    Function UserClientContacts(ByVal lg_username As String)
        Try
            Dim sql As String = "SELECT contacts FROM user_account_backend WHERE username='" & lg_username.Trim & "'"

            Dim connection As New MySqlConnection(connStrBMG)
            Dim cmd As New MySqlCommand(sql, connection)
            Dim reader As MySqlDataReader
            connection.Open()
            reader = cmd.ExecuteReader()

            If reader.HasRows = True Then
                While reader.Read
                    UserClientContacts = reader.Item("contacts").ToString.Trim()
                End While
            End If
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Belo SMS:Login")
        End Try
    End Function
    Private Sub sl_MyScroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles sl.MyScroll
        i = 0
    End Sub

        Private Sub lsPxSMS_MouseEnter(sender As Object, e As EventArgs) Handles lsPxSMS.MouseEnter

    End Sub
    Private Sub lsPxSMS_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lsPxSMS.MouseWheel
        i = 0
    End Sub

    Private Sub lsPxSMS_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsPxSMS.SelectedIndexChanged

    End Sub

    Private Sub txtFilter_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtFilter.KeyDown
        If e.KeyCode = Keys.Enter Then
            RetriveSMSfILTER()
        End If
    End Sub

    Private Sub txtFilter_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtFilter.TextChanged

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles btnUnread.Click
        RetriveSMSUnread()
    End Sub

    Function UpdateMessages(CPnum As string , ID As String)
        dim sql as String = "Update `messages` set FromAddress '" & CPnum & "' where id = '" & ID & "'"
        Try
            Dim rowsEffected = 0
            Dim connection As New MySqlConnection(connStrSMS)
            Dim cmd As New MySqlCommand(sql, connection)

            connection.Open()

            rowsEffected = cmd.ExecuteNonQuery()

            connection.Close()

            Return rowsEffected
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Function MobileUp
        dim sql as String = "UPDATE messages SET fromAddress = CONCAT('+',fromaddress) WHERE fromaddress NOT LIKE '%+%'"
        Try
            Dim rowsEffected = 0
            Dim connection As New MySqlConnection(connStrSMS)
            Dim cmd As New MySqlCommand(sql, connection)

            connection.Open()

            rowsEffected = cmd.ExecuteNonQuery()

            connection.Close()

            Return rowsEffected
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

Private Sub Button1_Click_2( sender As Object,  e As EventArgs) Handles Button1.Click
        Try
            dim query ,sql , CPNum,ID as String
            query = "select id,directionid,IF(directionid = 1,fromaddress,toaddress) CPNO from messages WHERE (fromaddress IS NOT NULL AND fromaddress <> '') OR (toaddress IS NOT NULL AND toaddress <> '')"
            Dim connection as new MySqlConnection(connStrSMS)
            Dim cmd as new MySqlCommand(query,connection)
            Dim reader as MySqlDataReader
            connection.Open()
            reader = cmd.ExecuteReader()
            if reader.HasRows Then
                While reader.Read
                    'if reader.Item("DirectionID") = 1 Then
                        ID = reader.Item("ID")
                        CPNum = reader.Item("CPNO").ToString().Trim()
                        UpdateMessages(CPNum,ID)
                    'End If
                End While
            End If
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

End Sub

Private Sub ContextMessageInbox_Opening( sender As Object,  e As System.ComponentModel.CancelEventArgs) Handles ContextMessageInbox.Opening

End Sub
End Class