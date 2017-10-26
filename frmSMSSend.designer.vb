<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSMSSend
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSMSSend))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btClose = New System.Windows.Forms.Button()
        Me.btSend = New System.Windows.Forms.Button()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.lbInvalid = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TxtLenghtToolStrip = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pxIDToolStrip = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pxToolStrip = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbUsernameAndBranchname = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lsTemplate = New System.Windows.Forms.ListView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsTemplateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowTemplateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuSMSSetting = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuSMSSetting.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Send To"
        '
        'btClose
        '
        Me.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btClose.Location = New System.Drawing.Point(402, 273)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(75, 23)
        Me.btClose.TabIndex = 9
        Me.btClose.Text = "Close"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'btSend
        '
        Me.btSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btSend.Location = New System.Drawing.Point(321, 273)
        Me.btSend.Name = "btSend"
        Me.btSend.Size = New System.Drawing.Size(75, 23)
        Me.btSend.TabIndex = 8
        Me.btSend.Text = "Send"
        Me.btSend.UseVisualStyleBackColor = True
        '
        'txtMessage
        '
        Me.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMessage.Location = New System.Drawing.Point(15, 59)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMessage.Size = New System.Drawing.Size(462, 208)
        Me.txtMessage.TabIndex = 7
        Me.txtMessage.Text = "txtMessage"
        '
        'txtMobile
        '
        Me.txtMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMobile.Location = New System.Drawing.Point(66, 33)
        Me.txtMobile.MaxLength = 20
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(233, 20)
        Me.txtMobile.TabIndex = 6
        Me.txtMobile.Text = "txtMobile"
        '
        'lbInvalid
        '
        Me.lbInvalid.AutoSize = True
        Me.lbInvalid.ForeColor = System.Drawing.Color.Red
        Me.lbInvalid.Location = New System.Drawing.Point(305, 35)
        Me.lbInvalid.Name = "lbInvalid"
        Me.lbInvalid.Size = New System.Drawing.Size(109, 13)
        Me.lbInvalid.TabIndex = 12
        Me.lbInvalid.Text = "Invalid mobile number"
        Me.lbInvalid.Visible = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TxtLenghtToolStrip, Me.pxIDToolStrip, Me.pxToolStrip})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 302)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(494, 22)
        Me.StatusStrip1.TabIndex = 13
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TxtLenghtToolStrip
        '
        Me.TxtLenghtToolStrip.Name = "TxtLenghtToolStrip"
        Me.TxtLenghtToolStrip.Size = New System.Drawing.Size(84, 17)
        Me.TxtLenghtToolStrip.Text = "TxtLenghtTool"
        '
        'pxIDToolStrip
        '
        Me.pxIDToolStrip.Name = "pxIDToolStrip"
        Me.pxIDToolStrip.Size = New System.Drawing.Size(78, 17)
        Me.pxIDToolStrip.Text = "pxIDToolStrip"
        '
        'pxToolStrip
        '
        Me.pxToolStrip.Name = "pxToolStrip"
        Me.pxToolStrip.Size = New System.Drawing.Size(67, 17)
        Me.pxToolStrip.Text = "pxToolStrip"
        '
        'lbUsernameAndBranchname
        '
        Me.lbUsernameAndBranchname.AutoSize = True
        Me.lbUsernameAndBranchname.Location = New System.Drawing.Point(12, 278)
        Me.lbUsernameAndBranchname.Name = "lbUsernameAndBranchname"
        Me.lbUsernameAndBranchname.Size = New System.Drawing.Size(142, 13)
        Me.lbUsernameAndBranchname.TabIndex = 14
        Me.lbUsernameAndBranchname.Text = "lbUsernameAndBranchname"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.Controls.Add(Me.lsTemplate)
        Me.Panel1.Location = New System.Drawing.Point(502, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(376, 267)
        Me.Panel1.TabIndex = 17
        '
        'lsTemplate
        '
        Me.lsTemplate.FullRowSelect = True
        Me.lsTemplate.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lsTemplate.Location = New System.Drawing.Point(3, 3)
        Me.lsTemplate.MultiSelect = False
        Me.lsTemplate.Name = "lsTemplate"
        Me.lsTemplate.Size = New System.Drawing.Size(370, 261)
        Me.lsTemplate.TabIndex = 18
        Me.lsTemplate.TabStop = False
        Me.lsTemplate.UseCompatibleStateImageBehavior = False
        Me.lsTemplate.View = System.Windows.Forms.View.Details
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ShowTemplateToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(494, 24)
        Me.MenuStrip1.TabIndex = 18
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveAsTemplateToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SaveAsTemplateToolStripMenuItem
        '
        Me.SaveAsTemplateToolStripMenuItem.Name = "SaveAsTemplateToolStripMenuItem"
        Me.SaveAsTemplateToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.SaveAsTemplateToolStripMenuItem.Text = "Save As Template"
        '
        'ShowTemplateToolStripMenuItem
        '
        Me.ShowTemplateToolStripMenuItem.Name = "ShowTemplateToolStripMenuItem"
        Me.ShowTemplateToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.ShowTemplateToolStripMenuItem.Text = "Show Template"
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
        'frmSMSSend
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 324)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbUsernameAndBranchname)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lbInvalid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btClose)
        Me.Controls.Add(Me.btSend)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.txtMobile)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSMSSend"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Send SMS"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuSMSSetting.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btClose As System.Windows.Forms.Button
    Friend WithEvents btSend As System.Windows.Forms.Button
    Friend WithEvents txtMessage As System.Windows.Forms.TextBox
    Friend WithEvents txtMobile As System.Windows.Forms.TextBox
    Friend WithEvents lbInvalid As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents TxtLenghtToolStrip As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents pxToolStrip As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents pxIDToolStrip As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbUsernameAndBranchname As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lsTemplate As System.Windows.Forms.ListView
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ShowTemplateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsTemplateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuSMSSetting As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
End Class
