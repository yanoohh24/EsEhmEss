Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Imports Microsoft.WindowsAPICodePack.Shell
Imports Microsoft.WindowsAPICodePack.Taskbar
Imports TAFactory.IconPack
Public Class frmMain
    Dim originalSizeHeight As Integer = 641
    Dim originalSizeWidth As Integer = 1041
    Private Sub PatientsToolStrip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Patients_ToolStrip.Click
        Try
            If FFPatients.Visible = True Then
                FFPatients.Dock = DockStyle.Fill
                FFPatients.BringToFront()
                FFPatients.WindowState = FormWindowState.Maximized
                FFPatients.Show()

                FFPatients.Activate()
            Else
                FFPatients.MdiParent = Me
                FFPatients.WindowState = FormWindowState.Maximized
                FFPatients.Show()
                FFPatients.Activate()
            End If
        Catch ex As Exception
            FFPatients = New frmPatientsList()
            FFPatients.MdiParent = Me
            FFPatients.WindowState = FormWindowState.Maximized
            FFPatients.Show()
        End Try
    End Sub

    Private Sub SMSToolStrip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SMS_Admin_ToolStrip.Click
        Try
            If FFSMS.Visible = True Then
                FFSMS.BringToFront()
                FFSMS.WindowState = FormWindowState.Maximized
                FFSMS.Show()
                FFSMS.Activate()
            Else
                FFSMS.MdiParent = Me
                FFSMS.WindowState = FormWindowState.Maximized
                FFSMS.Show()
                FFSMS.Activate()
            End If

        Catch ex As Exception
            FFSMS = New frmSMS()
            FFSMS.MdiParent = Me
            FFSMS.BringToFront()
            FFSMS.WindowState = FormWindowState.Maximized
            FFSMS.Show()
            FFSMS.Activate()
        End Try

    End Sub


    Private Sub PatientsSMSToolStrip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Inbox_ToolStrip.Click
        Try
            If FFPatientsSMS.Visible = True Then
                FFPatientsSMS.BringToFront()
                FFPatientsSMS.WindowState = FormWindowState.Maximized
                FFPatientsSMS.Show()
                FFPatientsSMS.Activate()
            Else
                FFPatientsSMS.MdiParent = Me
                FFPatientsSMS.WindowState = FormWindowState.Maximized
                FFPatientsSMS.Show()
                FFPatientsSMS.Activate()
            End If

        Catch ex As Exception
            FFPatientsSMS = New frmPatientSMS()
            FFPatientsSMS.MdiParent = Me
            FFPatientsSMS.BringToFront()
            FFPatientsSMS.WindowState = FormWindowState.Maximized
            FFPatientsSMS.Show()
            FFPatientsSMS.Activate()
        End Try
    End Sub

    Private Sub frmMain_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        frmLogin.BringToFront()
        frmLogin.Show()
        frmLogin.txtUsername.Focus()
        Me.Dispose()
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        access_rights()
        Try
            If ClientSMSInbox = "1" Then
                FFPatientsSMS.MdiParent = Me
                FFPatientsSMS.BringToFront()
                FFPatientsSMS.WindowState = FormWindowState.Maximized
                FFPatientsSMS.Show()
            End If

        Catch ex As Exception
            If ClientSMSInbox = "1" Then
                FFPatientsSMS = New frmPatientSMS()
                FFPatientsSMS.MdiParent = Me
                FFPatientsSMS.BringToFront()
                FFPatientsSMS.WindowState = FormWindowState.Maximized
                FFPatientsSMS.Show()
            End If
        End Try
    End Sub

    Private Sub FullBlastSMSToolStrip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SMS_FullBlastToolStrip.Click
        Try
            FFFullBlastSMS.WindowState = FormWindowState.Normal
            FFFullBlastSMS.StartPosition = FormStartPosition.CenterScreen
            FFFullBlastSMS.Show()
            FFFullBlastSMS.BringToFront()

        Catch ex As Exception
            FFFullBlastSMS = New frmSMSFullBlast()
            FFFullBlastSMS.WindowState = FormWindowState.Normal
            FFFullBlastSMS.StartPosition = FormStartPosition.CenterScreen
            FFFullBlastSMS.Show()
        End Try
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Dispose()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub AccountInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountInformationToolStripMenuItem.Click
        Try
            FFAcountInfo.Show()
            FFAcountInfo.BringToFront()
        Catch ex As Exception
            FFAcountInfo = New frmAccntInfo()
            FFAcountInfo.Show()
            FFAcountInfo.BringToFront()
        End Try
    End Sub

    Private Sub BirthdayToolStrip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BirthdayToolStrip.Click
        Try
            FFBirthday.WindowState = FormWindowState.Normal
            FFBirthday.StartPosition = FormStartPosition.CenterScreen
            FFBirthday.Show()
            FFBirthday.BringToFront()

        Catch ex As Exception
            FFBirthday = New frmSMSBirthday()
            FFBirthday.WindowState = FormWindowState.Normal
            FFBirthday.StartPosition = FormStartPosition.CenterScreen
            FFBirthday.Show()
        End Try
    End Sub

    Private Sub NewToolStrip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SMS_NewToolStrip.Click
        Try
            FFNewSMS.Show()
            FFNewSMS.BringToFront()

        Catch ex As Exception
            FFNewSMS = New frmSMSNew()
            FFNewSMS.Show()
            FFNewSMS.BringToFront()
        End Try
    End Sub
    Public Sub access_rights()

        HostServerToolStrip.Text = "| IP: " & Host
        BranchCodeToolStripStatus.Text = "| Branch code: " & ClientBranch
        BranchNameToolStrip.Text = "| Branch name: " & ClientBranchName
        UsernameToolStrip.Text = "| username: " & ClientUsername
        NameToolStrip.Text = "| Name: " & ClientName
        AccAdminToolStripStatus.Text = "| Admin: " & ClientAccAdmin
        AsDeptoolStrip.Text = "| As: " & ClientAsDept

        AsDeptFooters()

        If ClientAccAdmin = 1 Then
            SettingToolStripMenuItem.Visible = True
            FFPatientsSMS.lbViewBy.Visible = True
            FFPatientsSMS.cbViewBy.Visible = True
            FFPatientsSMS.cbViewBy.Enabled = True
        Else
            FFPatientsSMS.lbViewBy.Visible = False
            FFPatientsSMS.cbViewBy.Visible = False
            FFPatientsSMS.cbViewBy.Enabled = False
            SettingToolStripMenuItem.Visible = False
        End If

        If ClientSMSAdmin = "1" Then
            SMS_Admin_ToolStrip.Visible = True
        Else
            SMS_Admin_ToolStrip.Visible = False
        End If

        If ClientSMSInbox = "1" Then
            Inbox_ToolStrip.Visible = True
        Else
            Inbox_ToolStrip.Visible = False
        End If

        If ClientFullBlast = "1" Then
            SMS_FullBlastToolStrip.Visible = True
        Else
            SMS_FullBlastToolStrip.Visible = False
        End If

        If ClientContacts = "1" Then
            ContactsToolStrip.Visible = True
        Else
            ContactsToolStrip.Visible = False
        End If

        If ClientPxList = "1" Then
            Patients_ToolStrip.Visible = True
        Else
            Patients_ToolStrip.Visible = False
        End If

        If ClientSendSMS = "1" Then
            SMS_NewToolStrip.Visible = True
        Else
            SMS_NewToolStrip.Visible = False
        End If

        If ClientBirthday = "1" Then
            BirthdayToolStrip.Visible = True
        Else
            BirthdayToolStrip.Visible = False
        End If

    End Sub

    Private Sub FooterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FooterToolStripMenuItem.Click
        AsDeptFooters()
        MsgBox(FooterSMS, MsgBoxStyle.Information, "Footer")
    End Sub

    Private Sub UserAccessSettingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserAccessSettingToolStripMenuItem.Click
        Try
            FFUserAccess.Show()
            FFUserAccess.BringToFront()

        Catch ex As Exception
            FFUserAccess = New frmUserAccess()
            FFUserAccess.Show()
            FFUserAccess.BringToFront()
        End Try
    End Sub

    Private Sub UserAccessGroupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserAccessGroupToolStripMenuItem.Click
        Try
            FFUserAccessGroup.Show()
            FFUserAccessGroup.BringToFront()

        Catch ex As Exception
            FFUserAccessGroup = New frmUserAccessGroup()
            FFUserAccessGroup.Show()
            FFUserAccessGroup.BringToFront()
        End Try
    End Sub

    Private Sub ContactsToolStrip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContactsToolStrip.Click
        Try
            FFContacts.Show()
            FFContacts.BringToFront()

        Catch ex As Exception
            FFContacts = New frmContacts()
            FFContacts.Show()
            FFContacts.BringToFront()
        End Try
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

    Private Sub BranchFooterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BranchFooterToolStripMenuItem.Click
        Try
            FFBranchFooter.Show()
            FFBranchFooter.BringToFront()

        Catch ex As Exception
            FFBranchFooter = New frmUserBranchFooter
            FFBranchFooter.Show()
            FFBranchFooter.BringToFront()

        End Try

    End Sub

    Public Sub AsDeptFooters()

        If ClientAsDept = "1" Then
            KeyToolStrip.Text = ClientDepartmentKey
            BranchDept.Text = ClientDepartmentKey

            UserAndBranchName = "-" & ClientName & ", " & ClientDepartment

            FooterSMS = Department_First_Footer(ClientDepartmentKey) _
            & UserAndBranchName & vbNewLine _
            & UserClientContacts(ClientUsername) & vbNewLine & vbNewLine _
            & Department_End_Footer
        Else
            KeyToolStrip.Text = ClientBranch
            BranchDept.Text = ClientBranch

            UserAndBranchName = "-" & ClientName & ", Belo " & ClientBranchName

            FooterSMS = Branch_First_Footer(ClientBranch) _
            & UserAndBranchName & vbNewLine & vbNewLine _
            & Branch_End_Footer

        End If

    End Sub

    Private Sub IconToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles IconToolStripMenuItem.Click
        If counts = "0" Then
            TaskbarManager.Instance.SetOverlayIcon(Me.Handle, Nothing, "Icon Name")
        ElseIf counts = "1" Then
            Dim ID As Icon = IconHelper.ExtractIcon(CurDir() & "\customize_icon.dll", 1)
            TaskbarManager.Instance.SetOverlayIcon(Me.Handle, ID, "Icon Name")
        ElseIf counts = "2" Then
            Dim ID As Icon = IconHelper.ExtractIcon(CurDir() & "\customize_icon.dll", 3)
            TaskbarManager.Instance.SetOverlayIcon(Me.Handle, ID, "Icon Name")
        ElseIf counts = "3" Then
            Dim ID As Icon = IconHelper.ExtractIcon(CurDir() & "\customize_icon.dll", 4)
            TaskbarManager.Instance.SetOverlayIcon(Me.Handle, ID, "Icon Name")
        ElseIf counts = "4" Then
            Dim ID As Icon = IconHelper.ExtractIcon(CurDir() & "\customize_icon.dll", 5)
            TaskbarManager.Instance.SetOverlayIcon(Me.Handle, ID, "Icon Name")
        ElseIf counts = "5" Then
            Dim ID As Icon = IconHelper.ExtractIcon(CurDir() & "\customize_icon.dll", 6)
            TaskbarManager.Instance.SetOverlayIcon(Me.Handle, ID, "Icon Name")
        ElseIf counts = "6" Then
            Dim ID As Icon = IconHelper.ExtractIcon(CurDir() & "\customize_icon.dll", 7)
            TaskbarManager.Instance.SetOverlayIcon(Me.Handle, ID, "Icon Name")
        ElseIf counts = "7" Then
            Dim ID As Icon = IconHelper.ExtractIcon(CurDir() & "\customize_icon.dll", 8)
            TaskbarManager.Instance.SetOverlayIcon(Me.Handle, ID, "Icon Name")
        ElseIf counts = "8" Then
            Dim ID As Icon = IconHelper.ExtractIcon(CurDir() & "\customize_icon.dll", 9)
            TaskbarManager.Instance.SetOverlayIcon(Me.Handle, ID, "Icon Name")
        ElseIf counts = "9" Then
            Dim ID As Icon = IconHelper.ExtractIcon(CurDir() & "\customize_icon.dll", 10)
            TaskbarManager.Instance.SetOverlayIcon(Me.Handle, ID, "Icon Name")
        ElseIf counts > "9" Then
            Dim ID As Icon = IconHelper.ExtractIcon(CurDir() & "\customize_icon.dll", 2)
            TaskbarManager.Instance.SetOverlayIcon(Me.Handle, ID, "Icon Name")
        End If
    End Sub

    Public Structure FLASHWINFO
        Public cbSize As Int32
        Public hwnd As IntPtr
        Public dwFlags As Int32
        Public uCount As Int32
        Public dwTimeout As Int32
    End Structure

    Private Declare Function FlashWindowEx Lib "user32.dll" (ByRef pfwi As FLASHWINFO) As Int32
    Private Const FLASHW_CAPTION As Int32 = &H1
    Private Const FLASHW_TRAY As Int32 = &H2
    Private Const FLASHW_ALL As Int32 = (FLASHW_CAPTION Or FLASHW_TRAY)

    Private Sub BlinkToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BlinkToolStripMenuItem.Click

        Dim flash As New FLASHWINFO
        flash.cbSize = System.Runtime.InteropServices.Marshal.SizeOf(flash) '/// size of structure in bytes
        flash.hwnd = MyBase.Handle '/// Handle to the window to be flashed
        flash.dwFlags = FLASHW_ALL '/// to flash both the caption bar + the tray
        flash.uCount = 5 '/// the number of flashes
        flash.dwTimeout = 1000 '/// speed of flashes in MilliSeconds ( can be left out )
        '/// flash the window you have specified the handle for... 
        FlashWindowEx(flash)
    End Sub
    Dim curr_count As Integer = 0
    Dim counts As String = ""
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
First_line:
        Try

        If ClientDepartmentKey = "HD" Or ClientUserAccessGroup = "IT Admins" Then

            Dim sql As String = "SELECT COUNT(*) FROM messages_sms WHERE  `DeptKey` LIKE '%HD%' AND `Read_Stats` = 0"

            Dim connection As New MySqlConnection(connStrBMG)
            Dim cmd As New MySqlCommand(sql, connection)
            Dim reader As MySqlDataReader
            Try
                connection.Open()
            Catch ex As Exception

            End Try

            reader = cmd.ExecuteReader()

            If reader.HasRows = True Then
                While reader.Read
                    counts = reader.Item(0).ToString.Trim()
                End While
                IconToolStripMenuItem_Click(Me, EventArgs.Empty)
                If counts <> 0 Then


                    If curr_count <> counts Then
                        curr_count = counts

                        Dim flash As New FLASHWINFO
                        flash.cbSize = System.Runtime.InteropServices.Marshal.SizeOf(flash) '/// size of structure in bytes
                        flash.hwnd = MyBase.Handle '/// Handle to the window to be flashed
                        flash.dwFlags = FLASHW_ALL '/// to flash both the caption bar + the tray
                        flash.uCount = 5 '/// the number of flashes
                        flash.dwTimeout = 1000 '/// speed of flashes in MilliSeconds ( can be left out )
                        '/// flash the window you have specified the handle for...
                        FlashWindowEx(flash)
                    End If

                End If
            End If
            connection.Close()
            End If

        Catch ex As Exception
            GoTo First_line
        End Try
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub frmMain_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.Height = 681
    End Sub


    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles tsEmployee.Click
        Try
            If FFEmployeeSMS.Visible = True Then
                FFEmployeeSMS.BringToFront()
                FFEmployeeSMS.WindowState = FormWindowState.Maximized
                FFEmployeeSMS.Show()
                FFEmployeeSMS.Activate()
            Else
                FFEmployeeSMS.MdiParent = Me
                FFEmployeeSMS.WindowState = FormWindowState.Maximized
                FFEmployeeSMS.Show()
                FFEmployeeSMS.Activate()
            End If

        Catch ex As Exception
            FFEmployeeSMS = New frmEmployee()
            FFEmployeeSMS.MdiParent = Me
            FFEmployeeSMS.BringToFront()
            FFEmployeeSMS.WindowState = FormWindowState.Maximized
            FFEmployeeSMS.Show()
            FFEmployeeSMS.Activate()
        End Try
    End Sub
End Class

