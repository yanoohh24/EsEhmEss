<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btLogin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btCancel = New System.Windows.Forms.Button()
        Me.lbInformation = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDBusername = New System.Windows.Forms.TextBox()
        Me.btSaveUpdate = New System.Windows.Forms.Button()
        Me.btCancelUpdate = New System.Windows.Forms.Button()
        Me.txtDBpassword = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDBhostip = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatabaseConnectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbVersion = New System.Windows.Forms.Label()
        Me.lbDBconnection = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout
        Me.GroupBox1.SuspendLayout
        Me.MenuStrip1.SuspendLayout
        Me.Panel2.SuspendLayout
        Me.SuspendLayout
        '
        'txtUsername
        '
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Location = New System.Drawing.Point(232, 84)
        Me.txtUsername.MaxLength = 30
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(124, 20)
        Me.txtUsername.TabIndex = 0
        Me.txtUsername.Text = "txtUsername"
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Location = New System.Drawing.Point(232, 110)
        Me.txtPassword.MaxLength = 30
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(124, 20)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.Text = "txtPassword"
        '
        'btLogin
        '
        Me.btLogin.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btLogin.Location = New System.Drawing.Point(232, 136)
        Me.btLogin.Name = "btLogin"
        Me.btLogin.Size = New System.Drawing.Size(59, 23)
        Me.btLogin.TabIndex = 2
        Me.btLogin.Text = "Login"
        Me.btLogin.UseVisualStyleBackColor = false
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(171, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(171, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password"
        '
        'btCancel
        '
        Me.btCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btCancel.Location = New System.Drawing.Point(297, 136)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(59, 23)
        Me.btCancel.TabIndex = 5
        Me.btCancel.Text = "Cancel"
        Me.btCancel.UseVisualStyleBackColor = false
        '
        'lbInformation
        '
        Me.lbInformation.BackColor = System.Drawing.Color.Transparent
        Me.lbInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbInformation.ForeColor = System.Drawing.Color.DarkRed
        Me.lbInformation.Location = New System.Drawing.Point(171, 162)
        Me.lbInformation.Name = "lbInformation"
        Me.lbInformation.Size = New System.Drawing.Size(185, 17)
        Me.lbInformation.TabIndex = 6
        Me.lbInformation.Text = "lbInformation"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(419, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(333, 156)
        Me.Panel1.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDBusername)
        Me.GroupBox1.Controls.Add(Me.btSaveUpdate)
        Me.GroupBox1.Controls.Add(Me.btCancelUpdate)
        Me.GroupBox1.Controls.Add(Me.txtDBpassword)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtDBhostip)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(324, 156)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Database Connection Setting"
        '
        'txtDBusername
        '
        Me.txtDBusername.Location = New System.Drawing.Point(77, 30)
        Me.txtDBusername.Name = "txtDBusername"
        Me.txtDBusername.Size = New System.Drawing.Size(156, 20)
        Me.txtDBusername.TabIndex = 3
        Me.txtDBusername.Text = "txtDBusername"
        '
        'btSaveUpdate
        '
        Me.btSaveUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btSaveUpdate.Location = New System.Drawing.Point(239, 28)
        Me.btSaveUpdate.Name = "btSaveUpdate"
        Me.btSaveUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btSaveUpdate.TabIndex = 6
        Me.btSaveUpdate.Text = "Save"
        Me.btSaveUpdate.UseVisualStyleBackColor = true
        '
        'btCancelUpdate
        '
        Me.btCancelUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btCancelUpdate.Location = New System.Drawing.Point(239, 53)
        Me.btCancelUpdate.Name = "btCancelUpdate"
        Me.btCancelUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btCancelUpdate.TabIndex = 7
        Me.btCancelUpdate.Text = "Cancel"
        Me.btCancelUpdate.UseVisualStyleBackColor = true
        '
        'txtDBpassword
        '
        Me.txtDBpassword.Location = New System.Drawing.Point(77, 60)
        Me.txtDBpassword.Name = "txtDBpassword"
        Me.txtDBpassword.Size = New System.Drawing.Size(156, 20)
        Me.txtDBpassword.TabIndex = 4
        Me.txtDBpassword.Text = "txtDBpassword"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(16, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "HostIP"
        '
        'txtDBhostip
        '
        Me.txtDBhostip.Location = New System.Drawing.Point(77, 86)
        Me.txtDBhostip.Name = "txtDBhostip"
        Me.txtDBhostip.Size = New System.Drawing.Size(156, 20)
        Me.txtDBhostip.TabIndex = 5
        Me.txtDBhostip.Text = "txtDBhostip"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(16, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(16, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Username"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(20, 60)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(372, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SettingToolStripMenuItem
        '
        Me.SettingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatabaseConnectionToolStripMenuItem})
        Me.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        Me.SettingToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.SettingToolStripMenuItem.Text = "Setting"
        '
        'DatabaseConnectionToolStripMenuItem
        '
        Me.DatabaseConnectionToolStripMenuItem.Name = "DatabaseConnectionToolStripMenuItem"
        Me.DatabaseConnectionToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.DatabaseConnectionToolStripMenuItem.Text = "Database connection"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(12, 20)
        '
        'lbVersion
        '
        Me.lbVersion.BackColor = System.Drawing.Color.Transparent
        Me.lbVersion.Location = New System.Drawing.Point(174, 24)
        Me.lbVersion.Name = "lbVersion"
        Me.lbVersion.Size = New System.Drawing.Size(182, 13)
        Me.lbVersion.TabIndex = 9
        Me.lbVersion.Text = "lbVersion"
        Me.lbVersion.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbDBconnection
        '
        Me.lbDBconnection.AutoSize = true
        Me.lbDBconnection.BackColor = System.Drawing.Color.Transparent
        Me.lbDBconnection.Location = New System.Drawing.Point(12, 183)
        Me.lbDBconnection.Name = "lbDBconnection"
        Me.lbDBconnection.Size = New System.Drawing.Size(83, 13)
        Me.lbDBconnection.TabIndex = 23
        Me.lbDBconnection.Text = "lbDBconnection"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Image = Global.BeloSMS.My.Resources.Resources.belo_sms2
        Me.Label6.Location = New System.Drawing.Point(7, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 108)
        Me.Label6.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Location = New System.Drawing.Point(24, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Updating..."
        Me.Label7.Visible = false
        '
        'MetroButton1
        '
        Me.MetroButton1.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.MetroButton1.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.MetroButton1.Location = New System.Drawing.Point(23, 71)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(169, 85)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroButton1.TabIndex = 0
        Me.MetroButton1.Text = "UPDATE"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = true
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = true
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(10, 32)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(199, 19)
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "New BELO SMS version found!."
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.MetroLabel1)
        Me.Panel2.Controls.Add(Me.MetroButton1)
        Me.Panel2.Location = New System.Drawing.Point(174, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(221, 171)
        Me.Panel2.TabIndex = 27
        Me.Panel2.Visible = false
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"),System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(412, 237)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbVersion)
        Me.Controls.Add(Me.btCancel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lbInformation)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbDBconnection)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmLogin"
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(false)
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        Me.Panel2.ResumeLayout(false)
        Me.Panel2.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btLogin As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btCancel As System.Windows.Forms.Button
    Friend WithEvents lbInformation As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtDBhostip As System.Windows.Forms.TextBox
    Friend WithEvents txtDBpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtDBusername As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btCancelUpdate As System.Windows.Forms.Button
    Friend WithEvents btSaveUpdate As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SettingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatabaseConnectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbVersion As System.Windows.Forms.Label
    Friend WithEvents lbDBconnection As System.Windows.Forms.Label
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Private WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Private WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
End Class
