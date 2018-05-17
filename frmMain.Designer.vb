<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.SMS_Admin_ToolStrip = New System.Windows.Forms.ToolStripButton()
        Me.Inbox_ToolStrip = New System.Windows.Forms.ToolStripButton()
        Me.SMS_FullBlastToolStrip = New System.Windows.Forms.ToolStripButton()
        Me.Patients_ToolStrip = New System.Windows.Forms.ToolStripButton()
        Me.SMS_NewToolStrip = New System.Windows.Forms.ToolStripButton()
        Me.ContactsToolStrip = New System.Windows.Forms.ToolStripButton()
        Me.BirthdayToolStrip = New System.Windows.Forms.ToolStripButton()
        Me.tsEmployee = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.HostServerToolStrip = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BranchCodeToolStripStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BranchNameToolStrip = New System.Windows.Forms.ToolStripStatusLabel()
        Me.UsernameToolStrip = New System.Windows.Forms.ToolStripStatusLabel()
        Me.NameToolStrip = New System.Windows.Forms.ToolStripStatusLabel()
        Me.AccAdminToolStripStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.KeyToolStrip = New System.Windows.Forms.ToolStripStatusLabel()
        Me.AsDeptoolStrip = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BranchDept = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserAccessSettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserAccessGroupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BranchFooterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FooterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IconToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlinkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStrip1.SuspendLayout
        Me.StatusStrip1.SuspendLayout
        Me.MenuStrip1.SuspendLayout
        Me.SuspendLayout
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SMS_Admin_ToolStrip, Me.Inbox_ToolStrip, Me.SMS_FullBlastToolStrip, Me.Patients_ToolStrip, Me.SMS_NewToolStrip, Me.ContactsToolStrip, Me.BirthdayToolStrip, Me.tsEmployee})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 84)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0)
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(1052, 55)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'SMS_Admin_ToolStrip
        '
        Me.SMS_Admin_ToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SMS_Admin_ToolStrip.Image = CType(resources.GetObject("SMS_Admin_ToolStrip.Image"),System.Drawing.Image)
        Me.SMS_Admin_ToolStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SMS_Admin_ToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SMS_Admin_ToolStrip.Name = "SMS_Admin_ToolStrip"
        Me.SMS_Admin_ToolStrip.Size = New System.Drawing.Size(52, 52)
        Me.SMS_Admin_ToolStrip.Text = "Admin SMS"
        '
        'Inbox_ToolStrip
        '
        Me.Inbox_ToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Inbox_ToolStrip.Image = CType(resources.GetObject("Inbox_ToolStrip.Image"),System.Drawing.Image)
        Me.Inbox_ToolStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Inbox_ToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Inbox_ToolStrip.Name = "Inbox_ToolStrip"
        Me.Inbox_ToolStrip.Size = New System.Drawing.Size(52, 52)
        Me.Inbox_ToolStrip.Text = "Inbox"
        '
        'SMS_FullBlastToolStrip
        '
        Me.SMS_FullBlastToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SMS_FullBlastToolStrip.Image = CType(resources.GetObject("SMS_FullBlastToolStrip.Image"),System.Drawing.Image)
        Me.SMS_FullBlastToolStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SMS_FullBlastToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SMS_FullBlastToolStrip.Name = "SMS_FullBlastToolStrip"
        Me.SMS_FullBlastToolStrip.Size = New System.Drawing.Size(52, 52)
        Me.SMS_FullBlastToolStrip.Text = "Confirmation  Full Blast SMS"
        '
        'Patients_ToolStrip
        '
        Me.Patients_ToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Patients_ToolStrip.Image = CType(resources.GetObject("Patients_ToolStrip.Image"),System.Drawing.Image)
        Me.Patients_ToolStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Patients_ToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Patients_ToolStrip.Name = "Patients_ToolStrip"
        Me.Patients_ToolStrip.Size = New System.Drawing.Size(52, 52)
        Me.Patients_ToolStrip.Text = "Patients List"
        '
        'SMS_NewToolStrip
        '
        Me.SMS_NewToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SMS_NewToolStrip.Image = CType(resources.GetObject("SMS_NewToolStrip.Image"),System.Drawing.Image)
        Me.SMS_NewToolStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SMS_NewToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SMS_NewToolStrip.Name = "SMS_NewToolStrip"
        Me.SMS_NewToolStrip.Size = New System.Drawing.Size(52, 52)
        Me.SMS_NewToolStrip.Text = "Compose SMS"
        '
        'ContactsToolStrip
        '
        Me.ContactsToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ContactsToolStrip.Image = CType(resources.GetObject("ContactsToolStrip.Image"),System.Drawing.Image)
        Me.ContactsToolStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ContactsToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ContactsToolStrip.Name = "ContactsToolStrip"
        Me.ContactsToolStrip.Size = New System.Drawing.Size(52, 52)
        Me.ContactsToolStrip.Text = "Contacts"
        '
        'BirthdayToolStrip
        '
        Me.BirthdayToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BirthdayToolStrip.Image = CType(resources.GetObject("BirthdayToolStrip.Image"),System.Drawing.Image)
        Me.BirthdayToolStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BirthdayToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BirthdayToolStrip.Name = "BirthdayToolStrip"
        Me.BirthdayToolStrip.Size = New System.Drawing.Size(52, 52)
        Me.BirthdayToolStrip.Text = "Birthday Full Blast SMS"
        '
        'tsEmployee
        '
        Me.tsEmployee.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsEmployee.Image = CType(resources.GetObject("tsEmployee.Image"),System.Drawing.Image)
        Me.tsEmployee.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsEmployee.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsEmployee.Name = "tsEmployee"
        Me.tsEmployee.Size = New System.Drawing.Size(52, 52)
        Me.tsEmployee.Text = "Birthday Full Blast SMS"
        Me.tsEmployee.Visible = false
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HostServerToolStrip, Me.BranchCodeToolStripStatus, Me.BranchNameToolStrip, Me.UsernameToolStrip, Me.NameToolStrip, Me.AccAdminToolStripStatus, Me.ToolStripStatusLabel1, Me.KeyToolStrip, Me.AsDeptoolStrip, Me.BranchDept, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 659)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1052, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.TabStop = true
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'HostServerToolStrip
        '
        Me.HostServerToolStrip.Name = "HostServerToolStrip"
        Me.HostServerToolStrip.Size = New System.Drawing.Size(64, 17)
        Me.HostServerToolStrip.Text = "HostServer"
        '
        'BranchCodeToolStripStatus
        '
        Me.BranchCodeToolStripStatus.Name = "BranchCodeToolStripStatus"
        Me.BranchCodeToolStripStatus.Size = New System.Drawing.Size(151, 17)
        Me.BranchCodeToolStripStatus.Text = "BranchCodeToolStripStatus"
        '
        'BranchNameToolStrip
        '
        Me.BranchNameToolStrip.Name = "BranchNameToolStrip"
        Me.BranchNameToolStrip.Size = New System.Drawing.Size(123, 17)
        Me.BranchNameToolStrip.Text = "BranchNameToolStrip"
        '
        'UsernameToolStrip
        '
        Me.UsernameToolStrip.Name = "UsernameToolStrip"
        Me.UsernameToolStrip.Size = New System.Drawing.Size(60, 17)
        Me.UsernameToolStrip.Text = "Username"
        '
        'NameToolStrip
        '
        Me.NameToolStrip.Name = "NameToolStrip"
        Me.NameToolStrip.Size = New System.Drawing.Size(86, 17)
        Me.NameToolStrip.Text = "NameToolStrip"
        '
        'AccAdminToolStripStatus
        '
        Me.AccAdminToolStripStatus.Name = "AccAdminToolStripStatus"
        Me.AccAdminToolStripStatus.Size = New System.Drawing.Size(142, 17)
        Me.AccAdminToolStripStatus.Text = "AccAdminToolStripStatus"
        Me.AccAdminToolStripStatus.Visible = false
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(35, 17)
        Me.ToolStripStatusLabel1.Text = "| Key:"
        '
        'KeyToolStrip
        '
        Me.KeyToolStrip.Name = "KeyToolStrip"
        Me.KeyToolStrip.Size = New System.Drawing.Size(73, 17)
        Me.KeyToolStrip.Text = "KeyToolStrip"
        '
        'AsDeptoolStrip
        '
        Me.AsDeptoolStrip.Name = "AsDeptoolStrip"
        Me.AsDeptoolStrip.Size = New System.Drawing.Size(86, 17)
        Me.AsDeptoolStrip.Text = "AsDeptoolStrip"
        '
        'BranchDept
        '
        Me.BranchDept.Name = "BranchDept"
        Me.BranchDept.Size = New System.Drawing.Size(69, 17)
        Me.BranchDept.Text = "BranchDept"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(120, 17)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SettingToolStripMenuItem, Me.AboutToolStripMenuItem, Me.IconToolStripMenuItem, Me.BlinkToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 60)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1052, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(109, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'SettingToolStripMenuItem
        '
        Me.SettingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserAccessSettingToolStripMenuItem, Me.UserAccessGroupToolStripMenuItem, Me.BranchFooterToolStripMenuItem})
        Me.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        Me.SettingToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.SettingToolStripMenuItem.Text = "Setting"
        '
        'UserAccessSettingToolStripMenuItem
        '
        Me.UserAccessSettingToolStripMenuItem.Name = "UserAccessSettingToolStripMenuItem"
        Me.UserAccessSettingToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.UserAccessSettingToolStripMenuItem.Text = "User Access Setting"
        '
        'UserAccessGroupToolStripMenuItem
        '
        Me.UserAccessGroupToolStripMenuItem.Name = "UserAccessGroupToolStripMenuItem"
        Me.UserAccessGroupToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.UserAccessGroupToolStripMenuItem.Text = "User Access Group"
        '
        'BranchFooterToolStripMenuItem
        '
        Me.BranchFooterToolStripMenuItem.Name = "BranchFooterToolStripMenuItem"
        Me.BranchFooterToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.BranchFooterToolStripMenuItem.Text = "Branch Footer"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccountInformationToolStripMenuItem, Me.FooterToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'AccountInformationToolStripMenuItem
        '
        Me.AccountInformationToolStripMenuItem.Name = "AccountInformationToolStripMenuItem"
        Me.AccountInformationToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.AccountInformationToolStripMenuItem.Text = "Account Information"
        '
        'FooterToolStripMenuItem
        '
        Me.FooterToolStripMenuItem.Name = "FooterToolStripMenuItem"
        Me.FooterToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.FooterToolStripMenuItem.Text = "Footer"
        '
        'IconToolStripMenuItem
        '
        Me.IconToolStripMenuItem.Name = "IconToolStripMenuItem"
        Me.IconToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.IconToolStripMenuItem.Text = "icon"
        Me.IconToolStripMenuItem.Visible = false
        '
        'BlinkToolStripMenuItem
        '
        Me.BlinkToolStripMenuItem.Name = "BlinkToolStripMenuItem"
        Me.BlinkToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.BlinkToolStripMenuItem.Text = "blink"
        Me.BlinkToolStripMenuItem.Visible = false
        '
        'Timer1
        '
        Me.Timer1.Enabled = true
        Me.Timer1.Interval = 1000
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"),System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "23-0.png")
        Me.ImageList1.Images.SetKeyName(1, "23-1.png")
        Me.ImageList1.Images.SetKeyName(2, "23-2.png")
        Me.ImageList1.Images.SetKeyName(3, "23-3.png")
        Me.ImageList1.Images.SetKeyName(4, "23-4.png")
        Me.ImageList1.Images.SetKeyName(5, "23-5.png")
        Me.ImageList1.Images.SetKeyName(6, "23-6.png")
        Me.ImageList1.Images.SetKeyName(7, "23-7.png")
        Me.ImageList1.Images.SetKeyName(8, "23-8.png")
        Me.ImageList1.Images.SetKeyName(9, "23-9.png")
        Me.ImageList1.Images.SetKeyName(10, "23-10.png")
        Me.ImageList1.Images.SetKeyName(11, "")
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(1053, 681)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.IsMdiContainer = true
        Me.Name = "frmMain"
        Me.Padding = New System.Windows.Forms.Padding(0, 60, 1, 0)
        Me.Text = "Belo Medical Group"
        Me.TransparencyKey = System.Drawing.Color.Empty
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        Me.StatusStrip1.ResumeLayout(false)
        Me.StatusStrip1.PerformLayout
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Patients_ToolStrip As System.Windows.Forms.ToolStripButton
    Friend WithEvents SMS_Admin_ToolStrip As System.Windows.Forms.ToolStripButton
    Friend WithEvents Inbox_ToolStrip As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents UsernameToolStrip As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents NameToolStrip As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents BranchCodeToolStripStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents AccAdminToolStripStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents BranchNameToolStrip As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SMS_FullBlastToolStrip As System.Windows.Forms.ToolStripButton
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AccountInformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BirthdayToolStrip As System.Windows.Forms.ToolStripButton
    Friend WithEvents HostServerToolStrip As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SMS_NewToolStrip As System.Windows.Forms.ToolStripButton
    Friend WithEvents SettingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FooterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserAccessSettingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserAccessGroupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeyToolStrip As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents AsDeptoolStrip As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ContactsToolStrip As System.Windows.Forms.ToolStripButton
    Friend WithEvents BranchFooterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents BranchDept As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents IconToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BlinkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents tsEmployee As System.Windows.Forms.ToolStripButton
End Class
