<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSMS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSMS))
        Me.lstSMS = New System.Windows.Forms.ListView()
        Me.btSMSCounter = New System.Windows.Forms.Button()
        Me.lstMessages = New System.Windows.Forms.ListView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbTimer = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripNew = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripSMSCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbListSelection = New System.Windows.Forms.Label()
        Me.txtContent = New System.Windows.Forms.TextBox()
        Me.btDelete = New System.Windows.Forms.Button()
        Me.ContextMenuMessages = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReplyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BlankToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ForceQueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuSMSSetting = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ResendAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BlankToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btSearch = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout
        Me.StatusStrip1.SuspendLayout
        Me.ContextMenuMessages.SuspendLayout
        Me.ContextMenuSMSSetting.SuspendLayout
        Me.SuspendLayout
        '
        'lstSMS
        '
        Me.lstSMS.FullRowSelect = true
        Me.lstSMS.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lstSMS.Location = New System.Drawing.Point(12, 76)
        Me.lstSMS.MultiSelect = false
        Me.lstSMS.Name = "lstSMS"
        Me.lstSMS.Scrollable = false
        Me.lstSMS.Size = New System.Drawing.Size(125, 91)
        Me.lstSMS.TabIndex = 0
        Me.lstSMS.UseCompatibleStateImageBehavior = false
        Me.lstSMS.View = System.Windows.Forms.View.Details
        '
        'btSMSCounter
        '
        Me.btSMSCounter.Location = New System.Drawing.Point(12, 202)
        Me.btSMSCounter.Name = "btSMSCounter"
        Me.btSMSCounter.Size = New System.Drawing.Size(78, 23)
        Me.btSMSCounter.TabIndex = 1
        Me.btSMSCounter.Text = "SMS Counter"
        Me.btSMSCounter.UseVisualStyleBackColor = true
        Me.btSMSCounter.Visible = false
        '
        'lstMessages
        '
        Me.lstMessages.FullRowSelect = true
        Me.lstMessages.Location = New System.Drawing.Point(143, 76)
        Me.lstMessages.Name = "lstMessages"
        Me.lstMessages.Size = New System.Drawing.Size(857, 217)
        Me.lstMessages.TabIndex = 2
        Me.lstMessages.UseCompatibleStateImageBehavior = false
        Me.lstMessages.View = System.Windows.Forms.View.Details
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lbTimer
        '
        Me.lbTimer.AutoSize = true
        Me.lbTimer.Location = New System.Drawing.Point(12, 228)
        Me.lbTimer.Name = "lbTimer"
        Me.lbTimer.Size = New System.Drawing.Size(41, 13)
        Me.lbTimer.TabIndex = 3
        Me.lbTimer.Text = "lbTimer"
        Me.lbTimer.Visible = false
        '
        'ToolStrip1
        '
        Me.ToolStrip1.CanOverflow = false
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripNew})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(1032, 39)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripNew
        '
        Me.ToolStripNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripNew.Image = CType(resources.GetObject("ToolStripNew.Image"),System.Drawing.Image)
        Me.ToolStripNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripNew.Name = "ToolStripNew"
        Me.ToolStripNew.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripNew.Text = "New SMS"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSMSCount})
        Me.StatusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 456)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1032, 20)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripSMSCount
        '
        Me.ToolStripSMSCount.Name = "ToolStripSMSCount"
        Me.ToolStripSMSCount.Size = New System.Drawing.Size(63, 15)
        Me.ToolStripSMSCount.Text = "SMSCount"
        '
        'lbListSelection
        '
        Me.lbListSelection.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbListSelection.Location = New System.Drawing.Point(8, 50)
        Me.lbListSelection.Name = "lbListSelection"
        Me.lbListSelection.Size = New System.Drawing.Size(138, 23)
        Me.lbListSelection.TabIndex = 6
        Me.lbListSelection.Text = "lbListSelection"
        '
        'txtContent
        '
        Me.txtContent.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContent.Location = New System.Drawing.Point(143, 299)
        Me.txtContent.Multiline = true
        Me.txtContent.Name = "txtContent"
        Me.txtContent.ReadOnly = true
        Me.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtContent.Size = New System.Drawing.Size(857, 143)
        Me.txtContent.TabIndex = 7
        Me.txtContent.Text = "txtContent"
        '
        'btDelete
        '
        Me.btDelete.Enabled = false
        Me.btDelete.Location = New System.Drawing.Point(12, 173)
        Me.btDelete.Name = "btDelete"
        Me.btDelete.Size = New System.Drawing.Size(78, 23)
        Me.btDelete.TabIndex = 8
        Me.btDelete.Text = "Delete"
        Me.btDelete.UseVisualStyleBackColor = true
        Me.btDelete.Visible = false
        '
        'ContextMenuMessages
        '
        Me.ContextMenuMessages.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.ReplyToolStripMenuItem, Me.ToolStripSeparator1, Me.BlankToolStripMenuItem1, Me.DeleteToolStripMenuItem})
        Me.ContextMenuMessages.Name = "ContextMenuStrip1"
        Me.ContextMenuMessages.Size = New System.Drawing.Size(153, 120)
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = Global.BeloSMS.My.Resources.Resources.Document_Write_icon_32
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'ReplyToolStripMenuItem
        '
        Me.ReplyToolStripMenuItem.Image = Global.BeloSMS.My.Resources.Resources.Email_Reply_icon_24
        Me.ReplyToolStripMenuItem.Name = "ReplyToolStripMenuItem"
        Me.ReplyToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ReplyToolStripMenuItem.Text = "Reply"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'BlankToolStripMenuItem1
        '
        Me.BlankToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ForceQueToolStripMenuItem})
        Me.BlankToolStripMenuItem1.Name = "BlankToolStripMenuItem1"
        Me.BlankToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        '
        'ForceQueToolStripMenuItem
        '
        Me.ForceQueToolStripMenuItem.Name = "ForceQueToolStripMenuItem"
        Me.ForceQueToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.ForceQueToolStripMenuItem.Text = "Force que"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Image = Global.BeloSMS.My.Resources.Resources.deletered_24
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'ContextMenuSMSSetting
        '
        Me.ContextMenuSMSSetting.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResendAllToolStripMenuItem, Me.ToolStripSeparator2, Me.BlankToolStripMenuItem, Me.DeleteAllToolStripMenuItem})
        Me.ContextMenuSMSSetting.Name = "ContextMenuSMSSetting"
        Me.ContextMenuSMSSetting.Size = New System.Drawing.Size(130, 76)
        '
        'ResendAllToolStripMenuItem
        '
        Me.ResendAllToolStripMenuItem.Name = "ResendAllToolStripMenuItem"
        Me.ResendAllToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.ResendAllToolStripMenuItem.Text = "Resend All"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(126, 6)
        '
        'BlankToolStripMenuItem
        '
        Me.BlankToolStripMenuItem.Name = "BlankToolStripMenuItem"
        Me.BlankToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        '
        'DeleteAllToolStripMenuItem
        '
        Me.DeleteAllToolStripMenuItem.Image = Global.BeloSMS.My.Resources.Resources.deletered_24
        Me.DeleteAllToolStripMenuItem.Name = "DeleteAllToolStripMenuItem"
        Me.DeleteAllToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.DeleteAllToolStripMenuItem.Text = "Delete All"
        Me.DeleteAllToolStripMenuItem.Visible = false
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Location = New System.Drawing.Point(143, 52)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(161, 20)
        Me.txtSearch.TabIndex = 9
        Me.txtSearch.Text = "txtSearch"
        '
        'btSearch
        '
        Me.btSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btSearch.Location = New System.Drawing.Point(310, 50)
        Me.btSearch.Name = "btSearch"
        Me.btSearch.Size = New System.Drawing.Size(75, 23)
        Me.btSearch.TabIndex = 10
        Me.btSearch.Text = "Search"
        Me.btSearch.UseVisualStyleBackColor = true
        '
        'frmSMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1032, 476)
        Me.Controls.Add(Me.btSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btDelete)
        Me.Controls.Add(Me.btSMSCounter)
        Me.Controls.Add(Me.lstSMS)
        Me.Controls.Add(Me.lbTimer)
        Me.Controls.Add(Me.lstMessages)
        Me.Controls.Add(Me.lbListSelection)
        Me.Controls.Add(Me.txtContent)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "frmSMS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Belo SMS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        Me.StatusStrip1.ResumeLayout(false)
        Me.StatusStrip1.PerformLayout
        Me.ContextMenuMessages.ResumeLayout(false)
        Me.ContextMenuSMSSetting.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents lstSMS As System.Windows.Forms.ListView
    Friend WithEvents btSMSCounter As System.Windows.Forms.Button
    Friend WithEvents lstMessages As System.Windows.Forms.ListView
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbTimer As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripSMSCount As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbListSelection As System.Windows.Forms.Label
    Friend WithEvents txtContent As System.Windows.Forms.TextBox
    Friend WithEvents btDelete As System.Windows.Forms.Button
    Friend WithEvents ContextMenuMessages As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReplyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuSMSSetting As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ResendAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BlankToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BlankToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btSearch As System.Windows.Forms.Button
    Friend WithEvents ForceQueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
