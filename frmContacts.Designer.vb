<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContacts
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContacts))
        Me.cbGroups = New System.Windows.Forms.ComboBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtCompany = New System.Windows.Forms.TextBox()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btCancel = New System.Windows.Forms.Button()
        Me.lstContacts = New System.Windows.Forms.ListView()
        Me.btView = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportContactsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SMSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SendSMSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtSFirstName = New System.Windows.Forms.TextBox()
        Me.txtSLastName = New System.Windows.Forms.TextBox()
        Me.txtSMobile = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btAddGroup = New System.Windows.Forms.Button()
        Me.txtGroupName = New System.Windows.Forms.TextBox()
        Me.cbGroupslst = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ContextMenuMessages = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BlankToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.chCheckAll = New System.Windows.Forms.CheckBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.RowsToolStrip = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ContextMenuMessages.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbGroups
        '
        Me.cbGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGroups.FormattingEnabled = True
        Me.cbGroups.Location = New System.Drawing.Point(79, 24)
        Me.cbGroups.Name = "cbGroups"
        Me.cbGroups.Size = New System.Drawing.Size(121, 21)
        Me.cbGroups.TabIndex = 0
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(79, 51)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(192, 20)
        Me.txtName.TabIndex = 1
        Me.txtName.Text = "txtName"
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Location = New System.Drawing.Point(350, 51)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(121, 20)
        Me.txtMiddleName.TabIndex = 2
        Me.txtMiddleName.Text = "txtMiddleName"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(539, 51)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(134, 20)
        Me.txtLastName.TabIndex = 3
        Me.txtLastName.Text = "txtLastName"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(79, 77)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(594, 42)
        Me.txtAddress.TabIndex = 4
        Me.txtAddress.Text = "txtAddress"
        '
        'txtTelephone
        '
        Me.txtTelephone.Location = New System.Drawing.Point(79, 155)
        Me.txtTelephone.MaxLength = 20
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(159, 20)
        Me.txtTelephone.TabIndex = 6
        Me.txtTelephone.Text = "txtTelephone"
        '
        'txtMobile
        '
        Me.txtMobile.Location = New System.Drawing.Point(79, 125)
        Me.txtMobile.MaxLength = 20
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(159, 20)
        Me.txtMobile.TabIndex = 5
        Me.txtMobile.Text = "txtMobile"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(79, 181)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(159, 20)
        Me.txtEmail.TabIndex = 7
        Me.txtEmail.Text = "txtEmail"
        '
        'txtCompany
        '
        Me.txtCompany.Location = New System.Drawing.Point(350, 125)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(323, 20)
        Me.txtCompany.TabIndex = 8
        Me.txtCompany.Text = "txtCompany"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(517, 202)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(75, 23)
        Me.btSave.TabIndex = 11
        Me.btSave.Text = "Save"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(598, 202)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(75, 23)
        Me.btCancel.TabIndex = 12
        Me.btCancel.Text = "Cancel"
        Me.btCancel.UseVisualStyleBackColor = True
        '
        'lstContacts
        '
        Me.lstContacts.CheckBoxes = True
        Me.lstContacts.FullRowSelect = True
        Me.lstContacts.GridLines = True
        Me.lstContacts.Location = New System.Drawing.Point(12, 58)
        Me.lstContacts.MultiSelect = False
        Me.lstContacts.Name = "lstContacts"
        Me.lstContacts.Size = New System.Drawing.Size(952, 268)
        Me.lstContacts.TabIndex = 11
        Me.lstContacts.UseCompatibleStateImageBehavior = False
        Me.lstContacts.View = System.Windows.Forms.View.Details
        '
        'btView
        '
        Me.btView.Location = New System.Drawing.Point(889, 29)
        Me.btView.Name = "btView"
        Me.btView.Size = New System.Drawing.Size(75, 23)
        Me.btView.TabIndex = 0
        Me.btView.Text = "View"
        Me.btView.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.cbGroups)
        Me.GroupBox1.Controls.Add(Me.txtMiddleName)
        Me.GroupBox1.Controls.Add(Me.btCancel)
        Me.GroupBox1.Controls.Add(Me.btSave)
        Me.GroupBox1.Controls.Add(Me.txtLastName)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.txtCompany)
        Me.GroupBox1.Controls.Add(Me.txtTelephone)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.txtMobile)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 332)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(686, 231)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Contact"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 184)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Email"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 158)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Telephone"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Mobile"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(262, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Company Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(477, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Last name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(277, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Middle name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "First name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Group Name"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SMSToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(976, 24)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportContactsToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ImportContactsToolStripMenuItem
        '
        Me.ImportContactsToolStripMenuItem.Name = "ImportContactsToolStripMenuItem"
        Me.ImportContactsToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ImportContactsToolStripMenuItem.Text = "Import Contacts"
        '
        'SMSToolStripMenuItem
        '
        Me.SMSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SendSMSToolStripMenuItem})
        Me.SMSToolStripMenuItem.Name = "SMSToolStripMenuItem"
        Me.SMSToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.SMSToolStripMenuItem.Text = "SMS"
        '
        'SendSMSToolStripMenuItem
        '
        Me.SendSMSToolStripMenuItem.Name = "SendSMSToolStripMenuItem"
        Me.SendSMSToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.SendSMSToolStripMenuItem.Text = "Send SMS"
        '
        'txtSFirstName
        '
        Me.txtSFirstName.Location = New System.Drawing.Point(12, 31)
        Me.txtSFirstName.Name = "txtSFirstName"
        Me.txtSFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtSFirstName.TabIndex = 17
        Me.txtSFirstName.Text = "First Name"
        '
        'txtSLastName
        '
        Me.txtSLastName.Location = New System.Drawing.Point(118, 31)
        Me.txtSLastName.Name = "txtSLastName"
        Me.txtSLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtSLastName.TabIndex = 18
        Me.txtSLastName.Text = "Last Name"
        '
        'txtSMobile
        '
        Me.txtSMobile.Location = New System.Drawing.Point(224, 31)
        Me.txtSMobile.Name = "txtSMobile"
        Me.txtSMobile.Size = New System.Drawing.Size(100, 20)
        Me.txtSMobile.TabIndex = 19
        Me.txtSMobile.Text = "Mobile"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btAddGroup)
        Me.GroupBox2.Controls.Add(Me.txtGroupName)
        Me.GroupBox2.Location = New System.Drawing.Point(729, 332)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(235, 93)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Add Group"
        '
        'btAddGroup
        '
        Me.btAddGroup.Location = New System.Drawing.Point(154, 51)
        Me.btAddGroup.Name = "btAddGroup"
        Me.btAddGroup.Size = New System.Drawing.Size(75, 23)
        Me.btAddGroup.TabIndex = 1
        Me.btAddGroup.Text = "Save"
        Me.btAddGroup.UseVisualStyleBackColor = True
        '
        'txtGroupName
        '
        Me.txtGroupName.Location = New System.Drawing.Point(6, 25)
        Me.txtGroupName.Name = "txtGroupName"
        Me.txtGroupName.Size = New System.Drawing.Size(223, 20)
        Me.txtGroupName.TabIndex = 0
        Me.txtGroupName.Text = "Group Name"
        '
        'cbGroupslst
        '
        Me.cbGroupslst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGroupslst.FormattingEnabled = True
        Me.cbGroupslst.Location = New System.Drawing.Point(403, 31)
        Me.cbGroupslst.Name = "cbGroupslst"
        Me.cbGroupslst.Size = New System.Drawing.Size(121, 21)
        Me.cbGroupslst.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(330, 34)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Group Name"
        '
        'ContextMenuMessages
        '
        Me.ContextMenuMessages.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SentToolStripMenuItem, Me.ToolStripSeparator2, Me.BlankToolStripMenuItem})
        Me.ContextMenuMessages.Name = "ContextMenuStrip1"
        Me.ContextMenuMessages.Size = New System.Drawing.Size(127, 54)
        '
        'SentToolStripMenuItem
        '
        Me.SentToolStripMenuItem.Image = CType(resources.GetObject("SentToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SentToolStripMenuItem.Name = "SentToolStripMenuItem"
        Me.SentToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.SentToolStripMenuItem.Text = "Send SMS"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(123, 6)
        '
        'BlankToolStripMenuItem
        '
        Me.BlankToolStripMenuItem.Name = "BlankToolStripMenuItem"
        Me.BlankToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        '
        'chCheckAll
        '
        Me.chCheckAll.AutoSize = True
        Me.chCheckAll.Location = New System.Drawing.Point(540, 33)
        Me.chCheckAll.Name = "chCheckAll"
        Me.chCheckAll.Size = New System.Drawing.Size(71, 17)
        Me.chCheckAll.TabIndex = 23
        Me.chCheckAll.Text = "Check All"
        Me.chCheckAll.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RowsToolStrip})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 568)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(976, 22)
        Me.StatusStrip1.TabIndex = 24
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'RowsToolStrip
        '
        Me.RowsToolStrip.Name = "RowsToolStrip"
        Me.RowsToolStrip.Size = New System.Drawing.Size(82, 17)
        Me.RowsToolStrip.Text = "RowsToolStrip"
        '
        'frmContacts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(976, 590)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.chCheckAll)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbGroupslst)
        Me.Controls.Add(Me.txtSMobile)
        Me.Controls.Add(Me.txtSLastName)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtSFirstName)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lstContacts)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmContacts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contacts"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ContextMenuMessages.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbGroups As System.Windows.Forms.ComboBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtMiddleName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtTelephone As System.Windows.Forms.TextBox
    Friend WithEvents txtMobile As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtCompany As System.Windows.Forms.TextBox
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents btCancel As System.Windows.Forms.Button
    Friend WithEvents lstContacts As System.Windows.Forms.ListView
    Friend WithEvents btView As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportContactsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtSFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtSLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtSMobile As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btAddGroup As System.Windows.Forms.Button
    Friend WithEvents txtGroupName As System.Windows.Forms.TextBox
    Friend WithEvents cbGroupslst As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuMessages As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BlankToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chCheckAll As System.Windows.Forms.CheckBox
    Friend WithEvents SMSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SendSMSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents RowsToolStrip As System.Windows.Forms.ToolStripStatusLabel
End Class
