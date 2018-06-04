<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSMSNew
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSMSNew))
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbInvalid = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.SendToolStrip = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolStrip = New System.Windows.Forms.ToolStripButton()
        Me.ExitToolStrip = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TxtLenghtToolStrip = New System.Windows.Forms.ToolStripStatusLabel()
        Me.USAndBranchnameToolStripStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btClear = New System.Windows.Forms.Button()
        Me.txtInvalidMobile = New System.Windows.Forms.TextBox()
        Me.lsTemplate = New System.Windows.Forms.ListView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ContextMenuSMSSetting = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.chHelpdesk = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FooterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.chHR = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.mobile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.check = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStrip1.SuspendLayout
        Me.StatusStrip1.SuspendLayout
        Me.GroupBox1.SuspendLayout
        Me.ContextMenuSMSSetting.SuspendLayout
        Me.MenuStrip1.SuspendLayout
        Me.Panel1.SuspendLayout
        Me.TableLayoutPanel1.SuspendLayout
        Me.Panel5.SuspendLayout
        CType(Me.DataGridView2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel4.SuspendLayout
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel3.SuspendLayout
        Me.Panel2.SuspendLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'txtMobile
        '
        Me.txtMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMobile.Location = New System.Drawing.Point(63, 82)
        Me.txtMobile.MaxLength = 20
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(394, 20)
        Me.txtMobile.TabIndex = 0
        Me.txtMobile.Text = "txtMobile"
        '
        'txtMessage
        '
        Me.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMessage.Location = New System.Drawing.Point(12, 108)
        Me.txtMessage.Multiline = true
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMessage.Size = New System.Drawing.Size(462, 173)
        Me.txtMessage.TabIndex = 1
        Me.txtMessage.Text = " "
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(9, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Send To"
        '
        'lbInvalid
        '
        Me.lbInvalid.AutoSize = true
        Me.lbInvalid.ForeColor = System.Drawing.Color.Red
        Me.lbInvalid.Location = New System.Drawing.Point(498, 92)
        Me.lbInvalid.Name = "lbInvalid"
        Me.lbInvalid.Size = New System.Drawing.Size(109, 13)
        Me.lbInvalid.TabIndex = 6
        Me.lbInvalid.Text = "Invalid mobile number"
        Me.lbInvalid.Visible = false
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SendToolStrip, Me.SaveToolStrip, Me.ExitToolStrip})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1338, 55)
        Me.ToolStrip1.TabIndex = 7
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'SendToolStrip
        '
        Me.SendToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SendToolStrip.Image = CType(resources.GetObject("SendToolStrip.Image"),System.Drawing.Image)
        Me.SendToolStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SendToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SendToolStrip.Name = "SendToolStrip"
        Me.SendToolStrip.Size = New System.Drawing.Size(52, 52)
        Me.SendToolStrip.Text = "Send"
        '
        'SaveToolStrip
        '
        Me.SaveToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStrip.Image = CType(resources.GetObject("SaveToolStrip.Image"),System.Drawing.Image)
        Me.SaveToolStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SaveToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStrip.Name = "SaveToolStrip"
        Me.SaveToolStrip.Size = New System.Drawing.Size(36, 52)
        Me.SaveToolStrip.Text = "Save as template"
        '
        'ExitToolStrip
        '
        Me.ExitToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ExitToolStrip.Image = CType(resources.GetObject("ExitToolStrip.Image"),System.Drawing.Image)
        Me.ExitToolStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExitToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExitToolStrip.Name = "ExitToolStrip"
        Me.ExitToolStrip.Size = New System.Drawing.Size(36, 52)
        Me.ExitToolStrip.Text = "Exit"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TxtLenghtToolStrip, Me.USAndBranchnameToolStripStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 544)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1338, 22)
        Me.StatusStrip1.TabIndex = 16
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TxtLenghtToolStrip
        '
        Me.TxtLenghtToolStrip.Name = "TxtLenghtToolStrip"
        Me.TxtLenghtToolStrip.Size = New System.Drawing.Size(106, 17)
        Me.TxtLenghtToolStrip.Text = "TxtLenghtToolStrip"
        '
        'USAndBranchnameToolStripStatus
        '
        Me.USAndBranchnameToolStripStatus.Name = "USAndBranchnameToolStripStatus"
        Me.USAndBranchnameToolStripStatus.Size = New System.Drawing.Size(189, 17)
        Me.USAndBranchnameToolStripStatus.Text = "USAndBranchnameToolStripStatus"
        '
        'btClear
        '
        Me.btClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btClear.Location = New System.Drawing.Point(571, 287)
        Me.btClear.Name = "btClear"
        Me.btClear.Size = New System.Drawing.Size(75, 23)
        Me.btClear.TabIndex = 3
        Me.btClear.Text = "Clear"
        Me.btClear.UseVisualStyleBackColor = true
        '
        'txtInvalidMobile
        '
        Me.txtInvalidMobile.BackColor = System.Drawing.SystemColors.Window
        Me.txtInvalidMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInvalidMobile.Location = New System.Drawing.Point(501, 108)
        Me.txtInvalidMobile.Multiline = true
        Me.txtInvalidMobile.Name = "txtInvalidMobile"
        Me.txtInvalidMobile.ReadOnly = true
        Me.txtInvalidMobile.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInvalidMobile.Size = New System.Drawing.Size(160, 173)
        Me.txtInvalidMobile.TabIndex = 2
        Me.txtInvalidMobile.Text = "txtInvalidMobile"
        '
        'lsTemplate
        '
        Me.lsTemplate.FullRowSelect = true
        Me.lsTemplate.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lsTemplate.Location = New System.Drawing.Point(6, 19)
        Me.lsTemplate.MultiSelect = false
        Me.lsTemplate.Name = "lsTemplate"
        Me.lsTemplate.Size = New System.Drawing.Size(622, 177)
        Me.lsTemplate.TabIndex = 17
        Me.lsTemplate.UseCompatibleStateImageBehavior = false
        Me.lsTemplate.View = System.Windows.Forms.View.Details
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lsTemplate)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 316)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(634, 202)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Template"
        '
        'ContextMenuSMSSetting
        '
        Me.ContextMenuSMSSetting.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem, Me.ToolStripSeparator2})
        Me.ContextMenuSMSSetting.Name = "ContextMenuSMSSetting"
        Me.ContextMenuSMSSetting.Size = New System.Drawing.Size(108, 32)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Image = Global.BeloSMS.My.Resources.Resources.deletered_24
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(104, 6)
        '
        'chHelpdesk
        '
        Me.chHelpdesk.AutoSize = true
        Me.chHelpdesk.Location = New System.Drawing.Point(12, 291)
        Me.chHelpdesk.Name = "chHelpdesk"
        Me.chHelpdesk.Size = New System.Drawing.Size(109, 17)
        Me.chHelpdesk.TabIndex = 19
        Me.chHelpdesk.Text = "Belo Invite Footer"
        Me.chHelpdesk.UseVisualStyleBackColor = true
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1338, 24)
        Me.MenuStrip1.TabIndex = 20
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FooterToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'FooterToolStripMenuItem
        '
        Me.FooterToolStripMenuItem.Name = "FooterToolStripMenuItem"
        Me.FooterToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.FooterToolStripMenuItem.Text = "Footer"
        '
        'chHR
        '
        Me.chHR.AutoSize = true
        Me.chHR.Location = New System.Drawing.Point(12, 291)
        Me.chHR.Name = "chHR"
        Me.chHR.Size = New System.Drawing.Size(97, 17)
        Me.chHR.TabIndex = 21
        Me.chHR.Text = "Training Footer"
        Me.chHR.UseVisualStyleBackColor = true
        '
        'Timer1
        '
        Me.Timer1.Enabled = true
        Me.Timer1.Interval = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Panel1.Location = New System.Drawing.Point(667, 82)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(658, 458)
        Me.Panel1.TabIndex = 22
        Me.Panel1.Visible = false
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66667!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel5, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 29)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(658, 372)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.DataGridView2)
        Me.Panel5.Controls.Add(Me.Button5)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(386, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(269, 366)
        Me.Panel5.TabIndex = 25
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = false
        Me.DataGridView2.AllowUserToDeleteRows = false
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.mobile, Me.fname, Me.lname})
        Me.DataGridView2.Location = New System.Drawing.Point(3, 0)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(263, 340)
        Me.DataGridView2.TabIndex = 5
        '
        'mobile
        '
        Me.mobile.HeaderText = "mobile"
        Me.mobile.Name = "mobile"
        '
        'fname
        '
        Me.fname.HeaderText = "Firstname"
        Me.fname.Name = "fname"
        '
        'lname
        '
        Me.lname.HeaderText = "Lastname"
        Me.lname.Name = "lname"
        '
        'Button5
        '
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button5.Location = New System.Drawing.Point(0, 343)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(269, 23)
        Me.Button5.TabIndex = 24
        Me.Button5.Text = "CLEAR"
        Me.Button5.UseVisualStyleBackColor = true
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Controls.Add(Me.DataGridView1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(377, 366)
        Me.Panel4.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button1.Location = New System.Drawing.Point(0, 343)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(377, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "SELECT"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = false
        Me.DataGridView1.AllowUserToDeleteRows = false
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.check})
        Me.DataGridView1.Location = New System.Drawing.Point(3, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(377, 334)
        Me.DataGridView1.TabIndex = 4
        '
        'check
        '
        Me.check.HeaderText = "check"
        Me.check.Name = "check"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Button4)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 401)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(658, 57)
        Me.Panel3.TabIndex = 3
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(6, 6)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(640, 21)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "DONE"
        Me.Button4.UseVisualStyleBackColor = false
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(6, 30)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(640, 21)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "CANCEL"
        Me.Button2.UseVisualStyleBackColor = false
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button6)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(658, 29)
        Me.Panel2.TabIndex = 2
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button6.Location = New System.Drawing.Point(561, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(85, 23)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "SEARCH"
        Me.Button6.UseVisualStyleBackColor = true
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(3, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "SEARCH PATIENT :"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(115, 6)
        Me.TextBox1.MaxLength = 50
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(440, 21)
        Me.TextBox1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"),System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(422, 51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 28)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = false
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "select recipient")
        '
        'frmSMSNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1338, 566)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.chHR)
        Me.Controls.Add(Me.chHelpdesk)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txtInvalidMobile)
        Me.Controls.Add(Me.txtMobile)
        Me.Controls.Add(Me.btClear)
        Me.Controls.Add(Me.lbInvalid)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmSMSNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compose SMS"
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        Me.StatusStrip1.ResumeLayout(false)
        Me.StatusStrip1.PerformLayout
        Me.GroupBox1.ResumeLayout(false)
        Me.ContextMenuSMSSetting.ResumeLayout(false)
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        Me.Panel1.ResumeLayout(false)
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.Panel5.ResumeLayout(false)
        CType(Me.DataGridView2,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel4.ResumeLayout(false)
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel3.ResumeLayout(false)
        Me.Panel2.ResumeLayout(false)
        Me.Panel2.PerformLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents txtMobile As System.Windows.Forms.TextBox
    Friend WithEvents txtMessage As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbInvalid As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents SendToolStrip As System.Windows.Forms.ToolStripButton
    Friend WithEvents ExitToolStrip As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents TxtLenghtToolStrip As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btClear As System.Windows.Forms.Button
    Friend WithEvents txtInvalidMobile As System.Windows.Forms.TextBox
    Friend WithEvents SaveToolStrip As System.Windows.Forms.ToolStripButton
    Friend WithEvents lsTemplate As System.Windows.Forms.ListView
    Friend WithEvents USAndBranchnameToolStripStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ContextMenuSMSSetting As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents chHelpdesk As System.Windows.Forms.CheckBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FooterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chHR As System.Windows.Forms.CheckBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents check As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents mobile As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
