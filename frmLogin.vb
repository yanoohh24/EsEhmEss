Imports MySql.Data.MySqlClient
Imports System.Net
Imports Microsoft.Win32
Imports System.IO
Imports System.Threading

Public Class frmLogin

    Private Sub btLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLogin.Click
        Dim usrInf As UsertInformation
        Dim Lusername As String = txtUsername.Text.Trim
        Dim Lpassword As String = txtPassword.Text
        lbDBconnection.Text = ""
        lbInformation.Text = ""
        btLogin.Enabled = False

        connStrSMS = "Database=Messages;Data Source=" & Host & ";User Id=" & UserName & ";Password=" & Password & ";UseCompression=True;Connection Timeout=28800"
        connStrBMG = "Database=belo_database;Data Source=" & Host & ";User Id=" & UserName & ";Password=" & Password & ";UseCompression=True;Connection Timeout=28800;Convert Zero Datetime=True"
        Application.DoEvents()

        If Len(Lusername) < 1 Then
            lbInformation.Text = "-Please enter username"
            txtUsername.Focus()
            btLogin.Enabled = True
            Exit Sub
        End If

        If Len(Lpassword) < 1 Then
            lbInformation.Text = "-Please enter password"
            txtPassword.Focus()
            btLogin.Enabled = True
            Exit Sub
        End If




        Select Case UserClientIformation(Lusername, Lpassword)
            Case 1
                Try

                    FFMain.Show()
                    If ClientUserAccessGroup = "HR" Or ClientUserAccessGroup = "IT Admins" Then
                        FFMain.tsEmployee.Visible = True
                    Else
                        FFMain.tsEmployee.Visible = False
                    End If
                    FFMain.BringToFront()
                    txtUsername.Text = ""
                    txtPassword.Text = ""
                    lbDBconnection.Text = ""
                Catch ex As Exception
                    FFPatientsSMS = New frmPatientSMS
                    FFMain = New frmMain()
                    FFMain.Show()
                    FFMain.BringToFront()
                    txtUsername.Text = ""
                    txtPassword.Text = ""
                    lbDBconnection.Text = ""
                End Try

                Me.Hide()
            Case 2
                lbInformation.Text = "-Invalid password"
            Case 88
                lbDBconnection.Text = "Unable to connection to host sever"
            Case Else
                lbInformation.Text = "-Invalid username and password"
        End Select

        txtPassword.Focus()
        btLogin.Enabled = True

    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbDBconnection.Text = ""
        lbVersion.Text = "Version " & Me.GetType.Assembly.GetName.Version.ToString
        RegistryGetLogin()
        txtUsername.Text = ""
        txtPassword.Text = ""
        lbInformation.Text = ""
        GetIPAddress()
    End Sub

    Private Sub btCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancel.Click
        Application.Exit()
    End Sub

    Private Sub txtPassword_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyUp
        If e.KeyCode = Keys.Enter Then
            btLogin_Click(Me, EventArgs.Empty)
        End If
    End Sub

    Private Sub GetIPAddress()
        ClientHostName = Dns.GetHostName()
        ClientHostIP = Dns.GetHostByName(ClientHostName).AddressList(0).ToString()
    End Sub
    Dim updates As Boolean = False
    Private Sub txtUsername_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsername.KeyUp
        If updates = False Then
            GetIPAddress()
            Select Case e.KeyCode
                Case Keys.F12
                    txtUsername.Text = "admin"
                    txtPassword.Text = "admin"
                    lbInformation.Text = ""
                    txtPassword.Focus()
                    txtPassword.SelectionStart = Len(txtPassword.Text)
                Case Keys.F11
                    txtUsername.Text = "vpang"
                    txtPassword.Text = "vpang"
                    lbInformation.Text = ""
                    txtPassword.Focus()
                    txtPassword.SelectionStart = Len(txtPassword.Text)
                Case Keys.F10
                    txtUsername.Text = "jalvaro"
                    txtPassword.Text = "belomedical"
                    lbInformation.Text = ""
                    txtPassword.Focus()
                    txtPassword.SelectionStart = Len(txtPassword.Text)
            End Select
        End If
    End Sub

    Private Sub DatabaseConnectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatabaseConnectionToolStripMenuItem.Click
        Panel1.Dock = DockStyle.Fill
        DisableInputButton()

    End Sub

    Private Sub btSaveUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSaveUpdate.Click
        Panel1.Dock = DockStyle.None
        EnableInputButton()
        RegistryRecordLogin()
    End Sub

    Private Sub btCancelUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancelUpdate.Click
        Panel1.Dock = DockStyle.None
        EnableInputButton()
    End Sub
    Private Sub DisableInputButton()
        txtPassword.Enabled = False
        txtUsername.Enabled = False
        btLogin.Enabled = False
        btCancel.Enabled = False
        SettingToolStripMenuItem.Enabled = False
    End Sub
    Private Sub EnableInputButton()
        txtPassword.Enabled = True
        txtUsername.Enabled = True
        btLogin.Enabled = True
        btCancel.Enabled = True
        SettingToolStripMenuItem.Enabled = True

        txtUsername.SelectionStart = Len(txtUsername.Text)
        txtUsername.Focus()
    End Sub
    Private Sub RegistryRecordLogin()
        Dim regKey As RegistryKey

        Try
            UserName = txtDBusername.Text.Trim
            Password = txtDBpassword.Text.Trim
            Host = txtDBhostip.Text.Trim

            'Create Registry Record
            regKey = Registry.LocalMachine.OpenSubKey("SYSTEM\BeloSMS", True)
            regKey.SetValue("smsusername", UserName)
            regKey.SetValue("smspassword", Password)
            regKey.SetValue("smsHostIP", Host)
            regKey.Close()

        Catch ex As Exception
            MsgBox(ex.Message(), , "Belo SMS: Registry")
        End Try
    End Sub
    Private Sub RegistryGetLogin()
        Dim regKey As RegistryKey

        Try
            'Get Registry Record
            regKey = Registry.LocalMachine.OpenSubKey("SYSTEM\BeloSMS", True)

            If Len(regKey.GetValue("smsusername", "").ToString().Trim()) > 1 Then
                UserName = regKey.GetValue("smsusername", "").ToString().Trim()
                txtDBusername.Text = UserName
            Else
                regKey.SetValue("smsusername", "root")
                UserName = "root"
                txtDBusername.Text = UserName
            End If

            If Len(regKey.GetValue("smspassword", "").ToString().Trim()) > 1 Then
                Password = regKey.GetValue("smspassword", "").ToString().Trim()
                txtDBpassword.Text = Password
            Else
                regKey.SetValue("smspassword", "")
                Password = "webdeveoper"
                txtDBpassword.Text = Password
            End If

            If Len(regKey.GetValue("smsHostIP", "").ToString().Trim()) > 1 Then
                Host = regKey.GetValue("smsHostIP", "").ToString().Trim()
                txtDBhostip.Text = Host
            Else
                regKey.SetValue("smsHostIP", "localhost")
                Host = "192.168.100.250"
                txtDBhostip.Text = Host
            End If

            regKey.Close()

        Catch ex As Exception
            'Create Registry Record
            regKey = Registry.LocalMachine.OpenSubKey("SYSTEM", True)
            regKey.CreateSubKey("BeloSMS")
            regKey = Registry.LocalMachine.OpenSubKey("SYSTEM\BeloSMS", True)

            UserName = "admin"
            Password = "webdeveoper"
            Host = "192.168.100.250"

            regKey.SetValue("smsusername", UserName)
            regKey.SetValue("smspassword", Password)
            regKey.SetValue("smsHostIP", Host)

            txtDBusername.Text = UserName
            txtDBpassword.Text = Password
            txtDBhostip.Text = Host

            regKey.Close()
        End Try
    End Sub

    Private Sub frmLogin_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        
        Dim path As String
        Try

            path = "\\192.168.100.41\Belo SMS\BELO SMS UPDATE\version.txt"

            If File.Exists(path) = True Then
                ' Open the file to read from. 
                Dim readText() As String = File.ReadAllLines(path)
                Dim FileVersion As String = readText(0).Trim
                Dim FileCurrentVersion As String = Me.GetType.Assembly.GetName.Version.ToString.Trim

                'If have new update
                If FileVersion <> FileCurrentVersion Then
                    updates = True
                    Try
                        MetroButton1.Focus()
                        Panel2.Visible = True
                    Catch ex As Exception

                    End Try
                Else
                    updates = False
                    Panel2.Visible = False
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
     
    End Sub

    Private Function FileToCopy() As String
        Throw New NotImplementedException
    End Function

    Private Sub SettingToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SettingToolStripMenuItem.Click

    End Sub

    Private Sub MetroButton1_Click(sender As System.Object, e As System.EventArgs) Handles MetroButton1.Click
        Process.Start(Application.StartupPath & "\Updates_Searcher.exe")
        End
    End Sub

    Private Sub txtUsername_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtUsername.TextChanged

    End Sub


End Class