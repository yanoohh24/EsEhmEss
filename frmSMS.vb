Imports MySql.Data.MySqlClient

Public Class frmSMS
    Dim cntDwn As Integer = 10
    Private _ToolTip As New ToolTip()

    'Scroll bar event
    Dim WithEvents sl As MyListener

    Private Sub ListViewFormatSetting()
        lstSMS.Columns.Clear()
        lstSMS.Columns.Add("", 10)
        lstSMS.Columns.Add("", 55)
        lstSMS.Columns.Add("Count", 70)

        Dim ListItem As ListViewItem
        ListItem = lstSMS.Items.Add("")
        ListItem.SubItems.Add("Inbox")
        ListItem.SubItems.Add("0")

        Dim ListItem2 As ListViewItem
        ListItem2 = lstSMS.Items.Add("")
        ListItem2.SubItems.Add("Outbox")
        ListItem2.SubItems.Add("0")

        Dim ListItem3 As ListViewItem
        ListItem3 = lstSMS.Items.Add("")
        ListItem3.SubItems.Add("Sent")
        ListItem3.SubItems.Add("0")

        Dim ListItem4 As ListViewItem
        ListItem4 = lstSMS.Items.Add("")
        ListItem4.SubItems.Add("Pending")
        ListItem4.SubItems.Add("0")

    End Sub
    Private Sub ListViewMessagesSetting()
        lstMessages.Items.Clear()
        lstMessages.Columns.Clear()
        lstMessages.Columns.Add("ID", 0)
        lstMessages.Columns.Add("Mobile", 100)
        lstMessages.Columns.Add("Message", 390)
        lstMessages.Columns.Add("Date", 120)
        lstMessages.Columns.Add("Sent by", 130)
        lstMessages.Columns.Add("Branch", 80)
    End Sub

    Private Sub frmSMS_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        cntDwn = 10
        Timer1.Enabled = True
        FFPatientsSMS.Timer1.Enabled = False
    End Sub

    Private Sub frmSMS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtContent.Text = ""
        txtSearch.Text = ""
        lbTimer.Text = ""
        ToolStripSMSCount.Text = ""

        ListViewFormatSetting()
        ListViewMessagesSetting()
        'RetriveSMS()
        sl = New MyListener(lstMessages)

    End Sub
    Public Sub RetriveSMS()
        Try
            Dim query As String
            'query = "SELECT * FROM Messages WHERE Direction=1 AND TypeID=2 ORDER BY ID DESC"
            query = "SELECT * FROM Messages WHERE Direction=1 AND TypeID=1 ORDER BY ID DESC"
            Dim connection As New MySqlConnection(connStrSMS)
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader
            connection.Open()
            reader = cmd.ExecuteReader()
            'this will clear the listbox
            'lstMessages.Items.Clear()
            ListViewMessagesSetting()
            If reader.HasRows = True Then
                While reader.Read
                    Dim ls As New ListViewItem(reader.Item("id").ToString())
                    Dim _pxID As String = reader.Item("PatientID")
                    ls.SubItems.Add(reader.Item("Sender").ToString.Trim())
                    ls.SubItems.Add(reader.Item("Body").ToString())
                    ls.SubItems.Add(Format(reader.Item("doc"), "MM-dd-yyyy hh:MM tt"))
                    ls.SubItems.Add(px_name(_pxID))
                    lstMessages.Items.Add(ls)
                End While
            End If
            connection.Close()
            ToolStripSMSCount.Text = lstMessages.Items.Count
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

    End Sub
    Private Sub btSMSCounter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSMSCounter.Click
        'OLD DATABASE (4.1) `messages`.`type` == ID:2 | DESCRIPTION:SMS
        'NEW DATABASE (5.6) `messages`.`type` == ID:1 | DESCRIPTION:SMS
        Try
            Dim sqlCount As String
            if ClientDepartmentKey <> "ICT" and ClientDepartmentKey <> "HR" Then
                sqlCount = "SELECT COUNT(*) AS INBOX, " _
                & " (SELECT COUNT(*) AS TTL FROM Messages WHERE DirectionID=2 AND TYPEID=1 AND StatusDetailsID BETWEEN 210 AND 212 AND branch = '" & ClientBranch & "') AS OUTBOX, " _
                & " (SELECT COUNT(*) AS TTL FROM Messages WHERE DirectionID=2 AND TYPEID=1 AND StatusDetailsID BETWEEN 220 AND 221 AND branch = '" & ClientBranch & "') AS SENT, " _
                & " (SELECT COUNT(*) AS TTL FROM Messages WHERE DirectionID=2 AND TYPEID=1 AND StatusDetailsID BETWEEN 200 AND 202 AND branch = '" & ClientBranch & "') AS PENDING FROM Messages WHERE DirectionID=1 AND TypeID=1 AND branch = '" & ClientBranch & "'"
            Else 
                sqlCount = "SELECT COUNT(*) AS INBOX, " _
                & " (SELECT COUNT(*) AS TTL FROM Messages WHERE DirectionID=2 AND TYPEID=1 AND StatusDetailsID BETWEEN 210 AND 212) AS OUTBOX, " _
                & " (SELECT COUNT(*) AS TTL FROM Messages WHERE DirectionID=2 AND TYPEID=1 AND StatusDetailsID BETWEEN 220 AND 221) AS SENT, " _
                & " (SELECT COUNT(*) AS TTL FROM Messages WHERE DirectionID=2 AND TYPEID=1 AND StatusDetailsID BETWEEN 200 AND 202) AS PENDING FROM Messages WHERE DirectionID=1 AND TypeID=1"
            End If   
            
            Dim connection As New MySqlConnection(connStrSMS)
            Dim cmd As New MySqlCommand(sqlCount, connection)
            Dim reader As MySqlDataReader
            connection.Open()
            reader = cmd.ExecuteReader()
            Application.DoEvents()
            If reader.HasRows = True Then
                While reader.Read
                    lstSMS.Items(0).SubItems(2).Text = reader.Item("INBOX").ToString()
                    lstSMS.Items(1).SubItems(2).Text = reader.Item("OUTBOX").ToString()
                    lstSMS.Items(2).SubItems(2).Text = reader.Item("SENT").ToString()
                    lstSMS.Items(3).SubItems(2).Text = reader.Item("PENDING").ToString()
                End While
            End If
            connection.Close()
        Catch ex As Exception
            dim xxx as String
            xxx = ex.Message
            MsgBox(xxx)
        End Try

        Timer1.Enabled = True
        cntDwn = 10

        'Inbox Result
        'sql = "SELECT COUNT(*) AS TTL FROM Messages WHERE Direction=1 AND TypeID=2"
        'lstSMS.Items(0).SubItems(2).Text = ResultSQL(sql)

        'Outbox Result
        'sql = "SELECT COUNT(*) AS TTL FROM Messages WHERE DirectionID=2 AND TypeID=2 AND StatusDetails BETWEEN 210 AND 212"
        'lstSMS.Items(1).SubItems(2).Text = ResultSQL(sql)

        'Sent Result
        'sql = "SELECT COUNT(*) AS TTL FROM Messages WHERE DirectionID=2 AND TypeID=2 AND StatusDetails BETWEEN 220 AND 221"
        'lstSMS.Items(2).SubItems(2).Text = ResultSQL(sql)

        'Pending Result
        'sql = "SELECT COUNT(*) AS TTL FROM Messages WHERE DirectionID=2 AND TypeID=2 AND StatusDetails BETWEEN 200 AND 202"
        'lstSMS.Items(3).SubItems(2).Text = ResultSQL(sql)

    End Sub

    Public Sub RefreshSMSSetting()
        Timer1.Enabled = False
        btSMSCounter_Click(Me, EventArgs.Empty)
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        cntDwn = cntDwn - Val(1)
        If cntDwn = 0 Then
            cntDwn = 10
            btSMSCounter_Click(Me, EventArgs.Empty)
        End If
        lbTimer.Text = Format(cntDwn, "00")
    End Sub

    Private Sub lstSMS_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstSMS.Click
        Dim SQLquery As String
        On Error Resume Next
        'OLD DATABASE (4.1) `messages`.`type` == ID:2 | DESCRIPTION:SMS
        'NEW DATABASE (5.6) `messages`.`type` == ID:1 | DESCRIPTION:SMS

        'Timer
        Timer1.Enabled = False
        cntDwn = 10
        txtContent.Text = ""
        Select Case lstSMS.SelectedItems(0).SubItems(1).Text.Trim()
            Case "Inbox"
                lbListSelection.Text = "Inbox"
                lstMessages.Items.Clear()
                Application.DoEvents()
                btSMSCounter_Click(Me, EventArgs.Empty)
                'SQLquery = "SELECT * FROM Messages WHERE Direction=1 AND TypeID=2 ORDER BY ID DESC LIMIT 0,300"
                SQLquery = "SELECT * FROM Messages WHERE DirectionID=1 AND TypeID=1 ORDER BY ID DESC LIMIT 0,300"
                RetriveSMSToDevice(SQLquery)
                ToolStripSMSCount.Text = "Rows: " & lstMessages.Items.Count
            Case "Outbox"
                lbListSelection.Text = "Outbox"
                lstMessages.Items.Clear()
                Application.DoEvents()
                btSMSCounter_Click(Me, EventArgs.Empty)
                'SQLquery = "SELECT * FROM Messages WHERE Direction=2 AND Type=2 AND StatusDetails BETWEEN 210 AND 212 ORDER BY ID DESC"
                SQLquery = "SELECT * FROM Messages WHERE DirectionID=2 AND TypeID=1 AND StatusDetailsID BETWEEN 210 AND 212 ORDER BY ID DESC"
                RetriveSMSToDevice(SQLquery)
                ToolStripSMSCount.Text = "Rows: " & lstMessages.Items.Count
            Case "Sent"
                lbListSelection.Text = "Sent"
                lstMessages.Items.Clear()
                Application.DoEvents()
                btSMSCounter_Click(Me, EventArgs.Empty)
                'SQLquery = "SELECT * FROM Messages WHERE Direction=2 AND Type=2 AND StatusDetails BETWEEN 220 AND 221 ORDER BY ID DESC LIMIT 0,300"
                SQLquery = "SELECT * FROM Messages WHERE DirectionID=2 AND TypeID=1 AND StatusDetailsID BETWEEN 220 AND 221 ORDER BY ID DESC LIMIT 0,300"
                RetriveSMSToDevice(SQLquery)
                ToolStripSMSCount.Text = "Rows: " & lstMessages.Items.Count
            Case "Pending"
                lbListSelection.Text = "Pending"
                lstMessages.Items.Clear()
                Application.DoEvents()
                btSMSCounter_Click(Me, EventArgs.Empty)
                'SQLquery = "SELECT * FROM Messages WHERE Direction=2 AND Type=2 AND StatusDetails BETWEEN 200 AND 202 ORDER BY ID DESC"
                SQLquery = "SELECT * FROM Messages WHERE DirectionID=2 AND TypeID=1 AND StatusDetailsID BETWEEN 200 AND 202 ORDER BY ID DESC"
                RetriveSMSToDevice(SQLquery)
                ToolStripSMSCount.Text = "Rows: " & lstMessages.Items.Count
        End Select

        Timer1.Enabled = True

    End Sub

    Function RetriveSMSToDevice(ByVal query As String)
        Try
            Dim connection As New MySqlConnection(connStrSMS)
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader
            connection.Open()
            reader = cmd.ExecuteReader()
            'this will clear the listbox
            ListViewMessagesSetting()
            If reader.HasRows = True Then
                If lbListSelection.Text = "Inbox" Then
                    While reader.Read
                        Dim ls As New ListViewItem(reader.Item("id").ToString())
                        Dim _pxID As String = reader.Item("PatientID")
                        'ls.SubItems.Add(reader.Item("Sender").ToString.Trim()) 'Recipient 'Sender
                        ls.SubItems.Add(reader.Item("FromAddress").ToString.Trim()) 'Recipient 'Sender
                        ls.SubItems.Add(reader.Item("Body").ToString())
                        ls.SubItems.Add(Format(reader.Item("doc"), "hh:mm tt MM-dd-yyyy"))
                        ls.SubItems.Add(px_name(_pxID))
                        ls.SubItems.Add(BranchName(reader.Item("branch").ToString.Trim))
                        lstMessages.Items.Add(ls)
                    End While
                Else
                    While reader.Read
                        Dim ls As New ListViewItem(reader.Item("id").ToString())
                        'ls.SubItems.Add(reader.Item("Recipient").ToString.Trim()) 'Recipient 'Sender
                        ls.SubItems.Add(reader.Item("ToAddress").ToString.Trim()) 'Recipient 'Sender
                        ls.SubItems.Add(reader.Item("Body").ToString())
                        ls.SubItems.Add(Format(reader.Item("doc"), "hh:mm tt MM-dd-yyyy"))
                        ls.SubItems.Add(reader.Item("Username"))
                        ls.SubItems.Add(BranchName(reader.Item("branch").ToString.Trim))
                        lstMessages.Items.Add(ls)
                    End While
                End If
            End If
            connection.Close()

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

    End Function

    Private Sub lstSMS_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstSMS.GotFocus
        btDelete.Enabled = False
            Try
                lstSMS.Items(lstSMS.FocusedItem.Index).Selected = True
                lstSMS.Select()
                lbListSelection.Text = lstSMS.SelectedItems(0).SubItems(1).Text

            Catch ex As Exception
                lstSMS.Items(0).Selected = True
                lstSMS.Select()
                lbListSelection.Text = lstSMS.SelectedItems(0).SubItems(1).Text

            End Try
    End Sub

    Private Sub lstSMS_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstSMS.KeyUp
        lstSMS_Click(Me, EventArgs.Empty)
    End Sub

    Private Sub ToolStripNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripNew.Click
        Try
            FFNewSMS.Show()
            FFNewSMS.BringToFront()

        Catch ex As Exception
            FFNewSMS = New frmSMSNew()
            FFNewSMS.Show()
            FFNewSMS.BringToFront()
        End Try

    End Sub

    Private Sub lstMessages_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstMessages.Click
        cntDwn = 10
        Try
            If lstMessages.Items.Count > 0 Then
                txtContent.Text = "Number: " & lstMessages.SelectedItems(0).SubItems(1).Text.Trim() & vbNewLine & _
                 "Content: " & vbNewLine & lstMessages.SelectedItems(0).SubItems(2).Text.Trim()
            End If
        Catch ex As Exception
            lstSMS.Focus()
            txtContent.Text = ""
        End Try

    End Sub

    Private Sub lstMessages_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstMessages.GotFocus
        If lstMessages.Items.Count > 0 Then
            btDelete.Enabled = True

            Try
                lstMessages.Items(lstMessages.FocusedItem.Index).Selected = True
                lstMessages.Select()
                lstMessages_Click(Me, EventArgs.Empty)
            Catch ex As Exception
                lstMessages.Items(0).Selected = True
                lstMessages.Select()
                lstMessages_Click(Me, EventArgs.Empty)
            End Try

        Else
            btDelete.Enabled = False
        End If
    End Sub

    Private Sub lstMessages_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstMessages.KeyDown
        lstMessages_Click(Me, EventArgs.Empty)
    End Sub

    Private Sub lstMessages_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstMessages.KeyUp
        If e.KeyCode = Keys.Delete Then
            btDelete_Click(Me, EventArgs.Empty)
        End If
        lstMessages_Click(Me, EventArgs.Empty)
    End Sub

    Private Sub btDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDelete.Click
        Dim SelectedCount As Integer = 0
        Dim SQLquery As String

        For Each selectedItem As ListViewItem In lstMessages.SelectedItems
            SelectedCount = SelectedCount + 1
        Next

        If SelectedCount < 1 Then
            Exit Sub
        End If

        Select Case SelectedCount
            Case 1
                If MsgBox("Are you sure you want to delete this selected item?", vbYesNo, "Delete SMS") = vbYes Then
                    For Each selectedItem As ListViewItem In lstMessages.SelectedItems
                        SMS_DELETE(selectedItem.Text.Trim)
                    Next
                Else
                    lstMessages.Items(lstMessages.FocusedItem.Index).Selected = True
                    lstMessages.Select()
                    Exit Sub
                End If
            Case Else
                If MsgBox("Are you sure you want to delete this all selected item?", vbYesNo, "Delete SMS") = vbYes Then
                    For Each selectedItem As ListViewItem In lstMessages.SelectedItems
                        SMS_DELETE(selectedItem.Text.Trim)
                    Next
                Else
                    lstMessages.Items(lstMessages.FocusedItem.Index).Selected = True
                    lstMessages.Select()
                    Exit Sub
                End If
        End Select

        Select Case lbListSelection.Text.Trim
            Case "Inbox"
                lbListSelection.Text = "Inbox"
                'SQLquery = "SELECT * FROM Messages WHERE DirectionID=1 AND TypeID=2 ORDER BY ID DESC LIMIT 0,500"
                SQLquery = "SELECT * FROM Messages WHERE DirectionID=1 AND TypeID=1 ORDER BY ID DESC LIMIT 0,500"
                RetriveSMSToDevice(SQLquery)
                ToolStripSMSCount.Text = lstMessages.Items.Count
            Case "Outbox"
                lbListSelection.Text = "Outbox"
                'SQLquery = "SELECT * FROM Messages WHERE DirectionID=2 AND TypeID=2 AND StatusDetailsID BETWEEN 210 AND 212 ORDER BY ID DESC"
                SQLquery = "SELECT * FROM Messages WHERE DirectionID=2 AND TypeID=1 AND StatusDetailsID BETWEEN 210 AND 212 ORDER BY ID DESC"
                RetriveSMSToDevice(SQLquery)
                ToolStripSMSCount.Text = lstMessages.Items.Count
            Case "Sent"
                lbListSelection.Text = "Sent"
                'SQLquery = "SELECT * FROM Messages WHERE DirectionID=2 AND TypeID=2 AND StatusDetailsID BETWEEN 220 AND 221 ORDER BY ID DESC LIMIT 0,500"
                SQLquery = "SELECT * FROM Messages WHERE DirectionID=2 AND TypeID=1 AND StatusDetailsID BETWEEN 220 AND 221 ORDER BY ID DESC LIMIT 0,500"
                RetriveSMSToDevice(SQLquery)
                ToolStripSMSCount.Text = lstMessages.Items.Count
            Case "Pending"
                lbListSelection.Text = "Pending"
                'SQLquery = "SELECT * FROM Messages WHERE DirectionID=2 AND TypeID=2 AND StatusDetailsID BETWEEN 200 AND 202 ORDER BY ID DESC"
                SQLquery = "SELECT * FROM Messages WHERE DirectionID=2 AND TypeID=1 AND StatusDetailsID BETWEEN 200 AND 202 ORDER BY ID DESC"
                RetriveSMSToDevice(SQLquery)
                ToolStripSMSCount.Text = lstMessages.Items.Count
        End Select

        btSMSCounter_Click(Me, EventArgs.Empty)
    End Sub

    Private Sub txtContent_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtContent.GotFocus
        btDelete.Enabled = False
    End Sub

    Private Sub lstMessages_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstMessages.MouseClick
        cntDwn = 10
        If lstMessages.Items.Count > 0 Then
            If e.Button = Windows.Forms.MouseButtons.Right Then

                If lbListSelection.Text = "Pending" Then
                    BlankToolStripMenuItem1.Enabled = True
                Else
                    BlankToolStripMenuItem1.Enabled = False
                End If
                if ClientAccAdmin = 0 and ClientDepartmentKey <> "ICT" then 
                ContextMenuMessages.Items("BlankToolStripMenuItem1").Visible = False
                ContextMenuMessages.Items("DeleteToolStripMenuItem").Visible = False 
                End If
                ContextMenuMessages.Show(lstMessages, e.Location)
            End If
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        btDelete_Click(Me, EventArgs.Empty)
        lstMessages_Click(Me, EventArgs.Empty)
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        Try
            FFNewSMS.Show()
            FFNewSMS.BringToFront()

        Catch ex As Exception
            FFNewSMS = New frmSMSNew()
            FFNewSMS.Show()
        End Try

    End Sub

    Private Sub ReplyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReplyToolStripMenuItem.Click
        Try
            FFReplySMS.Show()
            FFReplySMS.BringToFront()
            FFReplySMS.txtMobile.Text = lstMessages.SelectedItems(0).SubItems(1).Text.Trim()
            FFReplySMS.txtMobile.SelectionStart = Len(FFReplySMS.txtMobile.Text)
            FFReplySMS.pxIDToolStrip.Text = ""
            FFReplySMS.pxToolStrip.Text = ""
        Catch ex As Exception
            FFReplySMS = New frmSMSReply()
            FFReplySMS.Show()
            FFReplySMS.txtMobile.Text = lstMessages.SelectedItems(0).SubItems(1).Text.Trim()
            FFReplySMS.txtMobile.SelectionStart = Len(FFReplySMS.txtMobile.Text)
            FFReplySMS.pxIDToolStrip.Text = ""
            FFReplySMS.pxToolStrip.Text = ""
        End Try

    End Sub

    Private Sub lstSMS_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstSMS.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Select Case lbListSelection.Text.Trim
                Case "Outbox"
                    If lstMessages.Items.Count > 0 Then
                        ResendAllToolStripMenuItem.Enabled = True
                        DeleteAllToolStripMenuItem.Enabled = True
                        ContextMenuSMSSetting.Show(lstSMS, e.Location)
                    Else
                        ResendAllToolStripMenuItem.Enabled = False
                        DeleteAllToolStripMenuItem.Enabled = False
                        ContextMenuSMSSetting.Show(lstSMS, e.Location)
                    End If
                Case "Inbox", "Sent", "Pending"
                    If lstMessages.Items.Count > 0 Then
                        ResendAllToolStripMenuItem.Enabled = False
                        DeleteAllToolStripMenuItem.Enabled = True
                        ContextMenuSMSSetting.Show(lstSMS, e.Location)
                    Else
                        ResendAllToolStripMenuItem.Enabled = False
                        DeleteAllToolStripMenuItem.Enabled = False
                        ContextMenuSMSSetting.Show(lstSMS, e.Location)
                    End If
            End Select
        End If
    End Sub

    Private Sub ResendAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResendAllToolStripMenuItem.Click
        Dim sql As String
        'RESEND TO ALL (SET STATUS TO PENDING FROM FAILURE)
        'OLD DATABASE (4.1) `messages`.`type` == ID:2 | DESCRIPTION:SMS
        'NEW DATABASE (5.6) `messages`.`type` == ID:1 | DESCRIPTION:SMS
        'REMOVED (sysForwarded=0,sysGwReference='',) Column doesn't exist in new ActiveXperts Database  
        Timer1.Enabled = False

        sql = "UPDATE messages SET StatusDetailsID=200, STATUSID=1, ChannelID=0, MessageReference='', SentTimeSecs=0, ReceivedTimeSecs=0, ScheduledTimeSecs=0, " _
        & "LastUpdateSecs=0, BodyFormatID=0, CustomField1=0, CustomField2='', sysCreator=0, sysArchive=0, sysLock=0, sysHash='', Header='' WHERE DirectionID=2 AND TYPEID=1 AND STATUSID=3 "
        SMS_UPDATE(sql)
        btSMSCounter_Click(Me, EventArgs.Empty)
    End Sub

    Private Sub DeleteAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteAllToolStripMenuItem.Click
        Dim SQLquery As String = ""

        Select Case lstSMS.SelectedItems(0).SubItems(1).Text.Trim()
            Case "Inbox"
                lbListSelection.Text = "Inbox"

                If MsgBox("Are you sure you want to delete all Inbox messages.", MsgBoxStyle.YesNo, "Delete All Inbox Messages") = MsgBoxResult.Yes Then
                    'SQLquery = "DELETE FROM Messages WHERE Direction=1 AND TypeID=2"
                    SQLquery = "DELETE FROM Messages WHERE Direction=1 AND TypeID=1"
                    SMS_UPDATE(SQLquery)

                    lstMessages.Items.Clear()
                    ToolStripSMSCount.Text = lstMessages.Items.Count
                End If

            Case "Outbox"
                lbListSelection.Text = "Outbox"

                If MsgBox("Are you sure you want to delete all Outbox messages.", MsgBoxStyle.YesNo, "Delete All Outbox Messages") = MsgBoxResult.Yes Then
                    'SQLquery = "DELETE FROM Messages WHERE DirectionID=2 AND TypeID=2 AND StatusID=3"
                    SQLquery = "DELETE FROM Messages WHERE DirectionID=2 AND TypeID=1 AND StatusID=3"
                    SMS_UPDATE(SQLquery)

                    lstMessages.Items.Clear()
                    ToolStripSMSCount.Text = lstMessages.Items.Count
                End If
            Case "Sent"
                lbListSelection.Text = "Sent"

                If MsgBox("Are you sure you want to delete all Sent messages.", MsgBoxStyle.YesNo, "Delete All Sent Messages") = MsgBoxResult.Yes Then
                    SQLquery = "DELETE FROM Messages WHERE DirectionID=2 AND TypeID=2 AND StatusID=2"
                    'SMS_UPDATE(SQLquery)

                    lstMessages.Items.Clear()
                    ToolStripSMSCount.Text = lstMessages.Items.Count
                End If
            Case "Pending"
                lbListSelection.Text = "Pending"

                If MsgBox("Are you sure you want to delete all Pending messages.", MsgBoxStyle.YesNo, "Delete All Pending Messages") = MsgBoxResult.Yes Then
                    'SQLquery = "DELETE FROM Messages WHERE DirectionID=2 AND TypeID=2 AND StatusID=1"
                    SQLquery = "DELETE FROM Messages WHERE DirectionID=2 AND TypeID=1 AND StatusID=1"
                    SMS_UPDATE(SQLquery)

                    lstMessages.Items.Clear()
                    ToolStripSMSCount.Text = lstMessages.Items.Count
                End If
        End Select

        btSMSCounter_Click(Me, EventArgs.Empty)
    End Sub


    Private Sub btSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSearch.Click
        Dim SQLquery As String
        Dim _search As String = Replace(txtSearch.Text.Trim, "'", "\'")

        'Timer
        Timer1.Enabled = False
        txtContent.Text = ""

        Select Case lstSMS.SelectedItems(0).SubItems(1).Text.Trim()
            Case "Inbox"
                lbListSelection.Text = "Inbox"
                SQLquery = "SELECT * FROM Messages WHERE DirectionID=1 AND TypeID=1 AND (Body LIKE '%" & _search & "%' OR fromAddress LIKE '%" & _search & "%') ORDER BY ID DESC LIMIT 0,400"
                RetriveSMSToDevice(SQLquery)
                ToolStripSMSCount.Text = "Rows: " & lstMessages.Items.Count
            Case "Sent"
                lbListSelection.Text = "Sent"
                SQLquery = "SELECT * FROM Messages WHERE DirectionID=2 AND TypeID=1 AND (Body LIKE '%" & _search & "%' OR toaddress LIKE '%" & _search & "%')  ORDER BY ID DESC LIMIT 0,400"
                RetriveSMSToDevice(SQLquery)
                ToolStripSMSCount.Text = "Rows: " & lstMessages.Items.Count
            Case "Pending"
                lbListSelection.Text = "Pending"
                SQLquery = "SELECT * FROM Messages WHERE DirectionID=2 AND TypeID=1 AND StatusID = 1 AND (Body LIKE '%" & _search & "%' OR toaddress LIKE '%" & _search & "%')  ORDER BY ID DESC LIMIT 0,400"
                RetriveSMSToDevice(SQLquery)
                ToolStripSMSCount.Text = "Rows: " & lstMessages.Items.Count
        End Select

        btSMSCounter_Click(Me, EventArgs.Empty)

    End Sub

    Private Sub txtSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.Click
        _ToolTip.Show("Search mobile number and message content", txtSearch)
    End Sub

    Private Sub txtSearch_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyUp
        If e.KeyCode = Keys.Enter Then
            btSearch_Click(Me, EventArgs.Empty)
        End If
    End Sub

    Private Sub txtSearch_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.MouseLeave
        _ToolTip.Show("", txtSearch)
    End Sub

    Private Sub txtSearch_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtSearch.MouseMove
        _ToolTip.Show("Search mobile number and message content", txtSearch)
    End Sub

    Private Sub ForceQueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForceQueToolStripMenuItem.Click
        Dim SelectedCount As Integer = 0

        For Each selectedItem As ListViewItem In lstMessages.SelectedItems
            SelectedCount = SelectedCount + 1
        Next

        If SelectedCount < 1 Then
            Exit Sub
        End If

        If lstMessages.Items.Count > 0 Then
            'SMS_FORCEque(lstMessages.SelectedItems(0).Text.Trim())
            For Each selectedItem As ListViewItem In lstMessages.SelectedItems
                SMS_FORCE_ON_QUE(selectedItem.Text.Trim)
            Next
        End If
    End Sub

    Private Sub sl_MyScroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles sl.MyScroll
        cntDwn = 10
    End Sub

    Private Sub lstMessages_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstMessages.MouseWheel
        cntDwn = 10
    End Sub

    Private Sub frmSMS_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        btSMSCounter_Click(Me, EventArgs.Empty)
    End Sub

    Private Sub lstSMS_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstSMS.SelectedIndexChanged

    End Sub

Private Sub ContextMenuMessages_Opening( sender As Object,  e As System.ComponentModel.CancelEventArgs) Handles ContextMenuMessages.Opening

End Sub
End Class
