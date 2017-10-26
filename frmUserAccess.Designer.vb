<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserAccess
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserAccess))
        Me.lstUserList = New System.Windows.Forms.ListView()
        Me.btView = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.HostToolStrip = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusUpdateToolStrip = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.chSMSAdmin = New System.Windows.Forms.CheckBox()
        Me.chSMSInbox = New System.Windows.Forms.CheckBox()
        Me.chFullBlast = New System.Windows.Forms.CheckBox()
        Me.chPatientList = New System.Windows.Forms.CheckBox()
        Me.chSendSMS = New System.Windows.Forms.CheckBox()
        Me.chAdmin = New System.Windows.Forms.CheckBox()
        Me.btUpdate = New System.Windows.Forms.Button()
        Me.txtLUsername = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbpxID = New System.Windows.Forms.Label()
        Me.chUserAccGrp = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chContacts = New System.Windows.Forms.CheckBox()
        Me.chBirthday = New System.Windows.Forms.CheckBox()
        Me.chEnableTag = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbBranch = New System.Windows.Forms.ComboBox()
        Me.lbBranchCode = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstUserList
        '
        Me.lstUserList.FullRowSelect = True
        Me.lstUserList.GridLines = True
        Me.lstUserList.Location = New System.Drawing.Point(12, 56)
        Me.lstUserList.Name = "lstUserList"
        Me.lstUserList.Size = New System.Drawing.Size(1173, 231)
        Me.lstUserList.TabIndex = 1
        Me.lstUserList.UseCompatibleStateImageBehavior = False
        Me.lstUserList.View = System.Windows.Forms.View.Details
        '
        'btView
        '
        Me.btView.Location = New System.Drawing.Point(629, 27)
        Me.btView.Name = "btView"
        Me.btView.Size = New System.Drawing.Size(75, 23)
        Me.btView.TabIndex = 2
        Me.btView.Text = "View"
        Me.btView.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HostToolStrip, Me.ToolStripStatus, Me.StatusUpdateToolStrip})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 413)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1197, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'HostToolStrip
        '
        Me.HostToolStrip.Name = "HostToolStrip"
        Me.HostToolStrip.Size = New System.Drawing.Size(17, 17)
        Me.HostToolStrip.Text = "IP"
        '
        'ToolStripStatus
        '
        Me.ToolStripStatus.Name = "ToolStripStatus"
        Me.ToolStripStatus.Size = New System.Drawing.Size(87, 17)
        Me.ToolStripStatus.Text = "ToolStripStatus"
        '
        'StatusUpdateToolStrip
        '
        Me.StatusUpdateToolStrip.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusUpdateToolStrip.ForeColor = System.Drawing.Color.Maroon
        Me.StatusUpdateToolStrip.Name = "StatusUpdateToolStrip"
        Me.StatusUpdateToolStrip.Size = New System.Drawing.Size(134, 17)
        Me.StatusUpdateToolStrip.Text = "StatusUpdateToolStrip"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(69, 29)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(136, 20)
        Me.txtUsername.TabIndex = 4
        Me.txtUsername.Text = "txtUsername"
        '
        'chSMSAdmin
        '
        Me.chSMSAdmin.AutoSize = True
        Me.chSMSAdmin.Location = New System.Drawing.Point(256, 42)
        Me.chSMSAdmin.Name = "chSMSAdmin"
        Me.chSMSAdmin.Size = New System.Drawing.Size(81, 17)
        Me.chSMSAdmin.TabIndex = 5
        Me.chSMSAdmin.Text = "SMS Admin"
        Me.chSMSAdmin.UseVisualStyleBackColor = True
        '
        'chSMSInbox
        '
        Me.chSMSInbox.AutoSize = True
        Me.chSMSInbox.Location = New System.Drawing.Point(256, 65)
        Me.chSMSInbox.Name = "chSMSInbox"
        Me.chSMSInbox.Size = New System.Drawing.Size(52, 17)
        Me.chSMSInbox.TabIndex = 6
        Me.chSMSInbox.Text = "Inbox"
        Me.chSMSInbox.UseVisualStyleBackColor = True
        '
        'chFullBlast
        '
        Me.chFullBlast.AutoSize = True
        Me.chFullBlast.Location = New System.Drawing.Point(348, 19)
        Me.chFullBlast.Name = "chFullBlast"
        Me.chFullBlast.Size = New System.Drawing.Size(94, 17)
        Me.chFullBlast.TabIndex = 7
        Me.chFullBlast.Text = "Full Blast SMS"
        Me.chFullBlast.UseVisualStyleBackColor = True
        '
        'chPatientList
        '
        Me.chPatientList.AutoSize = True
        Me.chPatientList.Location = New System.Drawing.Point(348, 42)
        Me.chPatientList.Name = "chPatientList"
        Me.chPatientList.Size = New System.Drawing.Size(78, 17)
        Me.chPatientList.TabIndex = 8
        Me.chPatientList.Text = "Patient List"
        Me.chPatientList.UseVisualStyleBackColor = True
        '
        'chSendSMS
        '
        Me.chSendSMS.AutoSize = True
        Me.chSendSMS.Location = New System.Drawing.Point(348, 65)
        Me.chSendSMS.Name = "chSendSMS"
        Me.chSendSMS.Size = New System.Drawing.Size(77, 17)
        Me.chSendSMS.TabIndex = 9
        Me.chSendSMS.Text = "Send SMS"
        Me.chSendSMS.UseVisualStyleBackColor = True
        '
        'chAdmin
        '
        Me.chAdmin.AutoSize = True
        Me.chAdmin.Location = New System.Drawing.Point(256, 19)
        Me.chAdmin.Name = "chAdmin"
        Me.chAdmin.Size = New System.Drawing.Size(55, 17)
        Me.chAdmin.TabIndex = 10
        Me.chAdmin.Text = "Admin"
        Me.chAdmin.UseVisualStyleBackColor = True
        '
        'btUpdate
        '
        Me.btUpdate.Location = New System.Drawing.Point(163, 66)
        Me.btUpdate.Name = "btUpdate"
        Me.btUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btUpdate.TabIndex = 11
        Me.btUpdate.Text = "Update"
        Me.btUpdate.UseVisualStyleBackColor = True
        '
        'txtLUsername
        '
        Me.txtLUsername.BackColor = System.Drawing.SystemColors.Control
        Me.txtLUsername.Location = New System.Drawing.Point(84, 17)
        Me.txtLUsername.Name = "txtLUsername"
        Me.txtLUsername.ReadOnly = True
        Me.txtLUsername.Size = New System.Drawing.Size(154, 20)
        Me.txtLUsername.TabIndex = 12
        Me.txtLUsername.Text = "txtLUsername"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.Control
        Me.txtName.Location = New System.Drawing.Point(84, 40)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(154, 20)
        Me.txtName.TabIndex = 13
        Me.txtName.Text = "txtName"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Name"
        '
        'lbpxID
        '
        Me.lbpxID.AutoSize = True
        Me.lbpxID.Location = New System.Drawing.Point(577, 312)
        Me.lbpxID.Name = "lbpxID"
        Me.lbpxID.Size = New System.Drawing.Size(37, 13)
        Me.lbpxID.TabIndex = 16
        Me.lbpxID.Text = "lbpxID"
        Me.lbpxID.Visible = False
        '
        'chUserAccGrp
        '
        Me.chUserAccGrp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.chUserAccGrp.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chUserAccGrp.FormattingEnabled = True
        Me.chUserAccGrp.Location = New System.Drawing.Point(316, 29)
        Me.chUserAccGrp.Name = "chUserAccGrp"
        Me.chUserAccGrp.Size = New System.Drawing.Size(121, 21)
        Me.chUserAccGrp.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(211, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "User Access Group"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Username"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chContacts)
        Me.GroupBox1.Controls.Add(Me.chBirthday)
        Me.GroupBox1.Controls.Add(Me.chEnableTag)
        Me.GroupBox1.Controls.Add(Me.chSendSMS)
        Me.GroupBox1.Controls.Add(Me.chSMSAdmin)
        Me.GroupBox1.Controls.Add(Me.chSMSInbox)
        Me.GroupBox1.Controls.Add(Me.chFullBlast)
        Me.GroupBox1.Controls.Add(Me.chPatientList)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.chAdmin)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btUpdate)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.txtLUsername)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 293)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(559, 100)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Access Privilege"
        '
        'chContacts
        '
        Me.chContacts.AutoSize = True
        Me.chContacts.Location = New System.Drawing.Point(463, 65)
        Me.chContacts.Name = "chContacts"
        Me.chContacts.Size = New System.Drawing.Size(68, 17)
        Me.chContacts.TabIndex = 18
        Me.chContacts.Text = "Contacts"
        Me.chContacts.UseVisualStyleBackColor = True
        '
        'chBirthday
        '
        Me.chBirthday.AutoSize = True
        Me.chBirthday.Location = New System.Drawing.Point(463, 42)
        Me.chBirthday.Name = "chBirthday"
        Me.chBirthday.Size = New System.Drawing.Size(64, 17)
        Me.chBirthday.TabIndex = 17
        Me.chBirthday.Text = "Birthday"
        Me.chBirthday.UseVisualStyleBackColor = True
        '
        'chEnableTag
        '
        Me.chEnableTag.AutoSize = True
        Me.chEnableTag.Location = New System.Drawing.Point(463, 19)
        Me.chEnableTag.Name = "chEnableTag"
        Me.chEnableTag.Size = New System.Drawing.Size(81, 17)
        Me.chEnableTag.TabIndex = 0
        Me.chEnableTag.Text = "Enable Tag"
        Me.chEnableTag.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(443, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Branch"
        '
        'cbBranch
        '
        Me.cbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBranch.FormattingEnabled = True
        Me.cbBranch.Location = New System.Drawing.Point(490, 29)
        Me.cbBranch.Name = "cbBranch"
        Me.cbBranch.Size = New System.Drawing.Size(121, 21)
        Me.cbBranch.TabIndex = 22
        '
        'lbBranchCode
        '
        Me.lbBranchCode.AutoSize = True
        Me.lbBranchCode.Location = New System.Drawing.Point(577, 335)
        Me.lbBranchCode.Name = "lbBranchCode"
        Me.lbBranchCode.Size = New System.Drawing.Size(74, 13)
        Me.lbBranchCode.TabIndex = 23
        Me.lbBranchCode.Text = "lbBranchCode"
        Me.lbBranchCode.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1197, 24)
        Me.MenuStrip1.TabIndex = 24
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SettingToolStripMenuItem
        '
        Me.SettingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddUserToolStripMenuItem})
        Me.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        Me.SettingToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.SettingToolStripMenuItem.Text = "Setting"
        '
        'AddUserToolStripMenuItem
        '
        Me.AddUserToolStripMenuItem.Name = "AddUserToolStripMenuItem"
        Me.AddUserToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.AddUserToolStripMenuItem.Text = "Add User"
        '
        'frmUserAccess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1197, 435)
        Me.Controls.Add(Me.lbBranchCode)
        Me.Controls.Add(Me.cbBranch)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chUserAccGrp)
        Me.Controls.Add(Me.lbpxID)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btView)
        Me.Controls.Add(Me.lstUserList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUserAccess"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Access"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstUserList As System.Windows.Forms.ListView
    Friend WithEvents btView As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents HostToolStrip As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents chSMSAdmin As System.Windows.Forms.CheckBox
    Friend WithEvents chSMSInbox As System.Windows.Forms.CheckBox
    Friend WithEvents chFullBlast As System.Windows.Forms.CheckBox
    Friend WithEvents chPatientList As System.Windows.Forms.CheckBox
    Friend WithEvents chSendSMS As System.Windows.Forms.CheckBox
    Friend WithEvents chAdmin As System.Windows.Forms.CheckBox
    Friend WithEvents btUpdate As System.Windows.Forms.Button
    Friend WithEvents txtLUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbpxID As System.Windows.Forms.Label
    Friend WithEvents ToolStripStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents chUserAccGrp As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chEnableTag As System.Windows.Forms.CheckBox
    Friend WithEvents StatusUpdateToolStrip As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents chBirthday As System.Windows.Forms.CheckBox
    Friend WithEvents chContacts As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbBranch As System.Windows.Forms.ComboBox
    Friend WithEvents lbBranchCode As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SettingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
