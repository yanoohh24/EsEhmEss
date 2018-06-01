<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSMSFullBlast
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSMSFullBlast))
        Me.lstPatientsContact = New System.Windows.Forms.ListView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.FileToolStrip = New System.Windows.Forms.ToolStripSplitButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcelToolStrip = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripViewAll = New System.Windows.Forms.ToolStripButton()
        Me.pBar = New System.Windows.Forms.ProgressBar()
        Me.dpTo = New System.Windows.Forms.DateTimePicker()
        Me.dpFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbBranch = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbBranchDB = New System.Windows.Forms.Label()
        Me.lbStatus = New System.Windows.Forms.Label()
        Me.cbSatus = New System.Windows.Forms.ComboBox()
        Me.txtClientName = New System.Windows.Forms.TextBox()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.lbMobile = New System.Windows.Forms.Label()
        Me.btSendToAll = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.RowCountTool = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pbExtract = New System.Windows.Forms.ToolStripProgressBar()
        Me.PercentToolStrip = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BranchCodeTool = New System.Windows.Forms.ToolStripStatusLabel()
        Me.AddressToolStripStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbTxtLength = New System.Windows.Forms.Label()
        Me.lbBranchCode = New System.Windows.Forms.Label()
        Me.btView = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btSend_Select = New System.Windows.Forms.Button()
        Me.lbPxName = New System.Windows.Forms.Label()
        Me.lbPxID = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btSendToAll_c = New System.Windows.Forms.Button()
        Me.lbTxtLength_c = New System.Windows.Forms.Label()
        Me.txtMobile_c = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMessage_c = New System.Windows.Forms.TextBox()
        Me.lsTemplate = New System.Windows.Forms.ListView()
        Me.gbTemplate = New System.Windows.Forms.GroupBox()
        Me.chDotors = New System.Windows.Forms.CheckBox()
        Me.chAesthetician = New System.Windows.Forms.CheckBox()
        Me.cbDocAes = New System.Windows.Forms.ComboBox()
        Me.lbDocAes = New System.Windows.Forms.Label()
        Me.ContextMessageInbox = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CustomTemplateToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutoTemplateToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BlankToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.check = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ToolStrip1.SuspendLayout
        Me.StatusStrip1.SuspendLayout
        Me.TabControl1.SuspendLayout
        Me.TabPage1.SuspendLayout
        Me.TabPage2.SuspendLayout
        Me.gbTemplate.SuspendLayout
        Me.ContextMessageInbox.SuspendLayout
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'lstPatientsContact
        '
        Me.lstPatientsContact.FullRowSelect = true
        Me.lstPatientsContact.GridLines = true
        Me.lstPatientsContact.Location = New System.Drawing.Point(10, 69)
        Me.lstPatientsContact.Name = "lstPatientsContact"
        Me.lstPatientsContact.Size = New System.Drawing.Size(1045, 178)
        Me.lstPatientsContact.TabIndex = 5
        Me.lstPatientsContact.UseCompatibleStateImageBehavior = false
        Me.lstPatientsContact.View = System.Windows.Forms.View.Details
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStrip, Me.ExcelToolStrip, Me.ToolStripSeparator2, Me.ToolStripViewAll})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1062, 39)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'FileToolStrip
        '
        Me.FileToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FileToolStrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.CloseToolStripMenuItem})
        Me.FileToolStrip.Image = CType(resources.GetObject("FileToolStrip.Image"),System.Drawing.Image)
        Me.FileToolStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FileToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FileToolStrip.Name = "FileToolStrip"
        Me.FileToolStrip.Size = New System.Drawing.Size(48, 36)
        Me.FileToolStrip.Text = "File"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(141, 6)
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X),System.Windows.Forms.Keys)
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'ExcelToolStrip
        '
        Me.ExcelToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ExcelToolStrip.Image = CType(resources.GetObject("ExcelToolStrip.Image"),System.Drawing.Image)
        Me.ExcelToolStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExcelToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExcelToolStrip.Name = "ExcelToolStrip"
        Me.ExcelToolStrip.Size = New System.Drawing.Size(36, 36)
        Me.ExcelToolStrip.Text = "Extract to Excel"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripViewAll
        '
        Me.ToolStripViewAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripViewAll.Image = CType(resources.GetObject("ToolStripViewAll.Image"),System.Drawing.Image)
        Me.ToolStripViewAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripViewAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripViewAll.Name = "ToolStripViewAll"
        Me.ToolStripViewAll.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripViewAll.Text = "View All"
        '
        'pBar
        '
        Me.pBar.Location = New System.Drawing.Point(10, 253)
        Me.pBar.Name = "pBar"
        Me.pBar.Size = New System.Drawing.Size(1045, 10)
        Me.pBar.TabIndex = 5
        '
        'dpTo
        '
        Me.dpTo.CustomFormat = "MMM, dd yyyy"
        Me.dpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpTo.Location = New System.Drawing.Point(870, 43)
        Me.dpTo.Name = "dpTo"
        Me.dpTo.Size = New System.Drawing.Size(104, 20)
        Me.dpTo.TabIndex = 3
        '
        'dpFrom
        '
        Me.dpFrom.CustomFormat = "MMM, dd yyyy"
        Me.dpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpFrom.Location = New System.Drawing.Point(734, 42)
        Me.dpFrom.Name = "dpFrom"
        Me.dpFrom.Size = New System.Drawing.Size(104, 20)
        Me.dpFrom.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(698, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "From"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(844, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "To"
        '
        'cbBranch
        '
        Me.cbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBranch.FormattingEnabled = true
        Me.cbBranch.Location = New System.Drawing.Point(53, 42)
        Me.cbBranch.Name = "cbBranch"
        Me.cbBranch.Size = New System.Drawing.Size(113, 21)
        Me.cbBranch.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(6, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Branch"
        '
        'lbBranchDB
        '
        Me.lbBranchDB.AutoSize = true
        Me.lbBranchDB.Location = New System.Drawing.Point(292, 26)
        Me.lbBranchDB.Name = "lbBranchDB"
        Me.lbBranchDB.Size = New System.Drawing.Size(64, 13)
        Me.lbBranchDB.TabIndex = 9
        Me.lbBranchDB.Text = "lbBranchDB"
        Me.lbBranchDB.Visible = false
        '
        'lbStatus
        '
        Me.lbStatus.AutoSize = true
        Me.lbStatus.Location = New System.Drawing.Point(172, 45)
        Me.lbStatus.Name = "lbStatus"
        Me.lbStatus.Size = New System.Drawing.Size(37, 13)
        Me.lbStatus.TabIndex = 10
        Me.lbStatus.Text = "Status"
        '
        'cbSatus
        '
        Me.cbSatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSatus.FormattingEnabled = true
        Me.cbSatus.Location = New System.Drawing.Point(215, 42)
        Me.cbSatus.Name = "cbSatus"
        Me.cbSatus.Size = New System.Drawing.Size(121, 21)
        Me.cbSatus.TabIndex = 1
        '
        'txtClientName
        '
        Me.txtClientName.BackColor = System.Drawing.SystemColors.Window
        Me.txtClientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtClientName.Location = New System.Drawing.Point(13, 37)
        Me.txtClientName.Multiline = true
        Me.txtClientName.Name = "txtClientName"
        Me.txtClientName.ReadOnly = true
        Me.txtClientName.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtClientName.Size = New System.Drawing.Size(478, 144)
        Me.txtClientName.TabIndex = 7
        Me.txtClientName.Text = "txtClientName"
        '
        'txtMobile
        '
        Me.txtMobile.BackColor = System.Drawing.SystemColors.Window
        Me.txtMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMobile.Location = New System.Drawing.Point(54, 11)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.ReadOnly = true
        Me.txtMobile.Size = New System.Drawing.Size(437, 20)
        Me.txtMobile.TabIndex = 6
        Me.txtMobile.Text = "txtMobile"
        '
        'lbMobile
        '
        Me.lbMobile.AutoSize = true
        Me.lbMobile.Location = New System.Drawing.Point(10, 13)
        Me.lbMobile.Name = "lbMobile"
        Me.lbMobile.Size = New System.Drawing.Size(38, 13)
        Me.lbMobile.TabIndex = 13
        Me.lbMobile.Text = "Mobile"
        '
        'btSendToAll
        '
        Me.btSendToAll.Enabled = false
        Me.btSendToAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btSendToAll.Location = New System.Drawing.Point(416, 189)
        Me.btSendToAll.Name = "btSendToAll"
        Me.btSendToAll.Size = New System.Drawing.Size(75, 23)
        Me.btSendToAll.TabIndex = 9
        Me.btSendToAll.Text = "Send to All"
        Me.btSendToAll.UseVisualStyleBackColor = true
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RowCountTool, Me.pbExtract, Me.PercentToolStrip, Me.BranchCodeTool, Me.AddressToolStripStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 525)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1062, 22)
        Me.StatusStrip1.TabIndex = 17
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'RowCountTool
        '
        Me.RowCountTool.AutoSize = false
        Me.RowCountTool.Name = "RowCountTool"
        Me.RowCountTool.Size = New System.Drawing.Size(70, 17)
        Me.RowCountTool.Text = "RowCountTool"
        Me.RowCountTool.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbExtract
        '
        Me.pbExtract.Name = "pbExtract"
        Me.pbExtract.Size = New System.Drawing.Size(100, 16)
        '
        'PercentToolStrip
        '
        Me.PercentToolStrip.Name = "PercentToolStrip"
        Me.PercentToolStrip.Size = New System.Drawing.Size(94, 17)
        Me.PercentToolStrip.Text = "PercentToolStrip"
        '
        'BranchCodeTool
        '
        Me.BranchCodeTool.Name = "BranchCodeTool"
        Me.BranchCodeTool.Size = New System.Drawing.Size(78, 17)
        Me.BranchCodeTool.Text = "Branch Code:"
        '
        'AddressToolStripStatus
        '
        Me.AddressToolStripStatus.Name = "AddressToolStripStatus"
        Me.AddressToolStripStatus.Size = New System.Drawing.Size(128, 17)
        Me.AddressToolStripStatus.Text = "AddressToolStripStatus"
        '
        'lbTxtLength
        '
        Me.lbTxtLength.AutoSize = true
        Me.lbTxtLength.Location = New System.Drawing.Point(11, 194)
        Me.lbTxtLength.Name = "lbTxtLength"
        Me.lbTxtLength.Size = New System.Drawing.Size(63, 13)
        Me.lbTxtLength.TabIndex = 14
        Me.lbTxtLength.Text = "lbTxtLength"
        '
        'lbBranchCode
        '
        Me.lbBranchCode.AutoSize = true
        Me.lbBranchCode.Location = New System.Drawing.Point(212, 26)
        Me.lbBranchCode.Name = "lbBranchCode"
        Me.lbBranchCode.Size = New System.Drawing.Size(74, 13)
        Me.lbBranchCode.TabIndex = 20
        Me.lbBranchCode.Text = "lbBranchCode"
        Me.lbBranchCode.Visible = false
        '
        'btView
        '
        Me.btView.Location = New System.Drawing.Point(980, 40)
        Me.btView.Name = "btView"
        Me.btView.Size = New System.Drawing.Size(75, 23)
        Me.btView.TabIndex = 4
        Me.btView.Text = "View"
        Me.btView.UseVisualStyleBackColor = true
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 269)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(513, 244)
        Me.TabControl1.TabIndex = 21
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.btSend_Select)
        Me.TabPage1.Controls.Add(Me.lbPxName)
        Me.TabPage1.Controls.Add(Me.lbPxID)
        Me.TabPage1.Controls.Add(Me.btSendToAll)
        Me.TabPage1.Controls.Add(Me.lbTxtLength)
        Me.TabPage1.Controls.Add(Me.txtMobile)
        Me.TabPage1.Controls.Add(Me.lbMobile)
        Me.TabPage1.Controls.Add(Me.txtClientName)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(505, 218)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Auto Template"
        '
        'btSend_Select
        '
        Me.btSend_Select.Enabled = false
        Me.btSend_Select.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btSend_Select.Location = New System.Drawing.Point(321, 189)
        Me.btSend_Select.Name = "btSend_Select"
        Me.btSend_Select.Size = New System.Drawing.Size(89, 23)
        Me.btSend_Select.TabIndex = 17
        Me.btSend_Select.Text = "Send to Many?"
        Me.btSend_Select.UseVisualStyleBackColor = true
        '
        'lbPxName
        '
        Me.lbPxName.AutoSize = true
        Me.lbPxName.Location = New System.Drawing.Point(156, 194)
        Me.lbPxName.Name = "lbPxName"
        Me.lbPxName.Size = New System.Drawing.Size(55, 13)
        Me.lbPxName.TabIndex = 16
        Me.lbPxName.Text = "lbPxName"
        Me.lbPxName.Visible = false
        '
        'lbPxID
        '
        Me.lbPxID.AutoSize = true
        Me.lbPxID.Location = New System.Drawing.Point(80, 194)
        Me.lbPxID.Name = "lbPxID"
        Me.lbPxID.Size = New System.Drawing.Size(38, 13)
        Me.lbPxID.TabIndex = 15
        Me.lbPxID.Text = "lbPxID"
        Me.lbPxID.Visible = false
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.btSendToAll_c)
        Me.TabPage2.Controls.Add(Me.lbTxtLength_c)
        Me.TabPage2.Controls.Add(Me.txtMobile_c)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.txtMessage_c)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(505, 218)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Custom Template"
        '
        'btSendToAll_c
        '
        Me.btSendToAll_c.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btSendToAll_c.Location = New System.Drawing.Point(353, 189)
        Me.btSendToAll_c.Name = "btSendToAll_c"
        Me.btSendToAll_c.Size = New System.Drawing.Size(75, 23)
        Me.btSendToAll_c.TabIndex = 17
        Me.btSendToAll_c.Text = "Send to All"
        Me.btSendToAll_c.UseVisualStyleBackColor = true
        '
        'lbTxtLength_c
        '
        Me.lbTxtLength_c.AutoSize = true
        Me.lbTxtLength_c.Location = New System.Drawing.Point(11, 194)
        Me.lbTxtLength_c.Name = "lbTxtLength_c"
        Me.lbTxtLength_c.Size = New System.Drawing.Size(75, 13)
        Me.lbTxtLength_c.TabIndex = 19
        Me.lbTxtLength_c.Text = "lbTxtLength_c"
        '
        'txtMobile_c
        '
        Me.txtMobile_c.BackColor = System.Drawing.SystemColors.Window
        Me.txtMobile_c.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMobile_c.Location = New System.Drawing.Point(54, 11)
        Me.txtMobile_c.Name = "txtMobile_c"
        Me.txtMobile_c.ReadOnly = true
        Me.txtMobile_c.Size = New System.Drawing.Size(374, 20)
        Me.txtMobile_c.TabIndex = 15
        Me.txtMobile_c.Text = "txtMobile_c"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(10, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Mobile"
        '
        'txtMessage_c
        '
        Me.txtMessage_c.BackColor = System.Drawing.SystemColors.Window
        Me.txtMessage_c.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMessage_c.Location = New System.Drawing.Point(13, 37)
        Me.txtMessage_c.Multiline = true
        Me.txtMessage_c.Name = "txtMessage_c"
        Me.txtMessage_c.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtMessage_c.Size = New System.Drawing.Size(415, 144)
        Me.txtMessage_c.TabIndex = 16
        Me.txtMessage_c.Text = "txtMessage_c"
        '
        'lsTemplate
        '
        Me.lsTemplate.FullRowSelect = true
        Me.lsTemplate.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lsTemplate.Location = New System.Drawing.Point(6, 22)
        Me.lsTemplate.MultiSelect = false
        Me.lsTemplate.Name = "lsTemplate"
        Me.lsTemplate.Size = New System.Drawing.Size(370, 216)
        Me.lsTemplate.TabIndex = 22
        Me.lsTemplate.TabStop = false
        Me.lsTemplate.UseCompatibleStateImageBehavior = false
        Me.lsTemplate.View = System.Windows.Forms.View.Details
        '
        'gbTemplate
        '
        Me.gbTemplate.Controls.Add(Me.lsTemplate)
        Me.gbTemplate.Location = New System.Drawing.Point(531, 269)
        Me.gbTemplate.Name = "gbTemplate"
        Me.gbTemplate.Size = New System.Drawing.Size(385, 244)
        Me.gbTemplate.TabIndex = 23
        Me.gbTemplate.TabStop = false
        Me.gbTemplate.Text = "Template"
        '
        'chDotors
        '
        Me.chDotors.AutoSize = true
        Me.chDotors.Location = New System.Drawing.Point(354, 44)
        Me.chDotors.Name = "chDotors"
        Me.chDotors.Size = New System.Drawing.Size(63, 17)
        Me.chDotors.TabIndex = 24
        Me.chDotors.Text = "Doctors"
        Me.chDotors.UseVisualStyleBackColor = true
        '
        'chAesthetician
        '
        Me.chAesthetician.AutoSize = true
        Me.chAesthetician.Location = New System.Drawing.Point(423, 44)
        Me.chAesthetician.Name = "chAesthetician"
        Me.chAesthetician.Size = New System.Drawing.Size(84, 17)
        Me.chAesthetician.TabIndex = 25
        Me.chAesthetician.Text = "Aesthetician"
        Me.chAesthetician.UseVisualStyleBackColor = true
        '
        'cbDocAes
        '
        Me.cbDocAes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDocAes.FormattingEnabled = true
        Me.cbDocAes.Location = New System.Drawing.Point(513, 42)
        Me.cbDocAes.Name = "cbDocAes"
        Me.cbDocAes.Size = New System.Drawing.Size(179, 21)
        Me.cbDocAes.TabIndex = 26
        '
        'lbDocAes
        '
        Me.lbDocAes.AutoSize = true
        Me.lbDocAes.Location = New System.Drawing.Point(510, 26)
        Me.lbDocAes.Name = "lbDocAes"
        Me.lbDocAes.Size = New System.Drawing.Size(53, 13)
        Me.lbDocAes.TabIndex = 27
        Me.lbDocAes.Text = "lbDocAes"
        Me.lbDocAes.Visible = false
        '
        'ContextMessageInbox
        '
        Me.ContextMessageInbox.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomTemplateToolStrip, Me.AutoTemplateToolStrip, Me.ToolStripSeparator3, Me.BlankToolStripMenuItem})
        Me.ContextMessageInbox.Name = "ContextMenuStrip1"
        Me.ContextMessageInbox.Size = New System.Drawing.Size(169, 76)
        '
        'CustomTemplateToolStrip
        '
        Me.CustomTemplateToolStrip.Image = CType(resources.GetObject("CustomTemplateToolStrip.Image"),System.Drawing.Image)
        Me.CustomTemplateToolStrip.Name = "CustomTemplateToolStrip"
        Me.CustomTemplateToolStrip.Size = New System.Drawing.Size(168, 22)
        Me.CustomTemplateToolStrip.Text = "Custom Template"
        '
        'AutoTemplateToolStrip
        '
        Me.AutoTemplateToolStrip.Image = CType(resources.GetObject("AutoTemplateToolStrip.Image"),System.Drawing.Image)
        Me.AutoTemplateToolStrip.Name = "AutoTemplateToolStrip"
        Me.AutoTemplateToolStrip.Size = New System.Drawing.Size(168, 22)
        Me.AutoTemplateToolStrip.Text = "Auto Template"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(165, 6)
        '
        'BlankToolStripMenuItem
        '
        Me.BlankToolStripMenuItem.Name = "BlankToolStripMenuItem"
        Me.BlankToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.check})
        Me.DataGridView1.Location = New System.Drawing.Point(9, 69)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1046, 178)
        Me.DataGridView1.TabIndex = 18
        Me.DataGridView1.Visible = false
        '
        'check
        '
        Me.check.HeaderText = "Check"
        Me.check.Name = "check"
        Me.check.Width = 50
        '
        'frmSMSFullBlast
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1062, 547)
        Me.Controls.Add(Me.lbDocAes)
        Me.Controls.Add(Me.cbDocAes)
        Me.Controls.Add(Me.chAesthetician)
        Me.Controls.Add(Me.chDotors)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.gbTemplate)
        Me.Controls.Add(Me.dpFrom)
        Me.Controls.Add(Me.btView)
        Me.Controls.Add(Me.lbBranchDB)
        Me.Controls.Add(Me.lbBranchCode)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.cbSatus)
        Me.Controls.Add(Me.lbStatus)
        Me.Controls.Add(Me.cbBranch)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dpTo)
        Me.Controls.Add(Me.pBar)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lstPatientsContact)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.Name = "frmSMSFullBlast"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Appointment: Confirmation Full Blast SMS"
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        Me.StatusStrip1.ResumeLayout(false)
        Me.StatusStrip1.PerformLayout
        Me.TabControl1.ResumeLayout(false)
        Me.TabPage1.ResumeLayout(false)
        Me.TabPage1.PerformLayout
        Me.TabPage2.ResumeLayout(false)
        Me.TabPage2.PerformLayout
        Me.gbTemplate.ResumeLayout(false)
        Me.ContextMessageInbox.ResumeLayout(false)
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents lstPatientsContact As System.Windows.Forms.ListView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripViewAll As System.Windows.Forms.ToolStripButton
    Friend WithEvents pBar As System.Windows.Forms.ProgressBar
    Friend WithEvents dpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbBranch As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbBranchDB As System.Windows.Forms.Label
    Friend WithEvents lbStatus As System.Windows.Forms.Label
    Friend WithEvents cbSatus As System.Windows.Forms.ComboBox
    Friend WithEvents txtClientName As System.Windows.Forms.TextBox
    Friend WithEvents txtMobile As System.Windows.Forms.TextBox
    Friend WithEvents lbMobile As System.Windows.Forms.Label
    Friend WithEvents btSendToAll As System.Windows.Forms.Button
    Friend WithEvents FileToolStrip As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents pbExtract As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents RowCountTool As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbBranchCode As System.Windows.Forms.Label
    Friend WithEvents BranchCodeTool As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btView As System.Windows.Forms.Button
    Friend WithEvents ExcelToolStrip As System.Windows.Forms.ToolStripButton
    Friend WithEvents PercentToolStrip As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddressToolStripStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbTxtLength As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btSendToAll_c As System.Windows.Forms.Button
    Friend WithEvents lbTxtLength_c As System.Windows.Forms.Label
    Friend WithEvents txtMobile_c As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMessage_c As System.Windows.Forms.TextBox
    Friend WithEvents lsTemplate As System.Windows.Forms.ListView
    Friend WithEvents gbTemplate As System.Windows.Forms.GroupBox
    Friend WithEvents chDotors As System.Windows.Forms.CheckBox
    Friend WithEvents chAesthetician As System.Windows.Forms.CheckBox
    Friend WithEvents cbDocAes As System.Windows.Forms.ComboBox
    Friend WithEvents lbDocAes As System.Windows.Forms.Label
    Friend WithEvents ContextMessageInbox As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CustomTemplateToolStrip As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AutoTemplateToolStrip As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BlankToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbPxID As System.Windows.Forms.Label
    Friend WithEvents lbPxName As System.Windows.Forms.Label
    Friend WithEvents btSend_Select As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents check As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
