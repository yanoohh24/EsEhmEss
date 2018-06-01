<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatientSMS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPatientSMS))
        Me.lsPxSMS = New System.Windows.Forms.ListView()
        Me.lstPx_lsSMS = New System.Windows.Forms.ListView()
        Me.txtContent = New System.Windows.Forms.TextBox()
        Me.lbFrom = New System.Windows.Forms.Label()
        Me.lbDate = New System.Windows.Forms.Label()
        Me.dpFrom = New System.Windows.Forms.DateTimePicker()
        Me.dpTo = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btView = New System.Windows.Forms.Button()
        Me.cbBranch = New System.Windows.Forms.ComboBox()
        Me.lbBranchDB = New System.Windows.Forms.Label()
        Me.ContextMenuMessages = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ReplyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BlankToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMessageInbox = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResendToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BlankToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btCheckSMS = New System.Windows.Forms.Button()
        Me.lbTimer = New System.Windows.Forms.Label()
        Me.btViewCurrentSMS = New System.Windows.Forms.Button()
        Me.lbpxID = New System.Windows.Forms.Label()
        Me.cbViewBy = New System.Windows.Forms.ComboBox()
        Me.lbViewBy = New System.Windows.Forms.Label()
        Me.lbDBconnection = New System.Windows.Forms.Label()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnUnread = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ContextMenuMessages.SuspendLayout
        Me.ContextMessageInbox.SuspendLayout
        CType(Me.BindingSource1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'lsPxSMS
        '
        Me.lsPxSMS.FullRowSelect = true
        Me.lsPxSMS.Location = New System.Drawing.Point(12, 41)
        Me.lsPxSMS.MultiSelect = false
        Me.lsPxSMS.Name = "lsPxSMS"
        Me.lsPxSMS.Size = New System.Drawing.Size(239, 417)
        Me.lsPxSMS.TabIndex = 4
        Me.lsPxSMS.UseCompatibleStateImageBehavior = false
        Me.lsPxSMS.View = System.Windows.Forms.View.Details
        '
        'lstPx_lsSMS
        '
        Me.lstPx_lsSMS.FullRowSelect = true
        Me.lstPx_lsSMS.GridLines = true
        Me.lstPx_lsSMS.Location = New System.Drawing.Point(257, 41)
        Me.lstPx_lsSMS.MultiSelect = false
        Me.lstPx_lsSMS.Name = "lstPx_lsSMS"
        Me.lstPx_lsSMS.Size = New System.Drawing.Size(790, 248)
        Me.lstPx_lsSMS.TabIndex = 5
        Me.lstPx_lsSMS.UseCompatibleStateImageBehavior = false
        Me.lstPx_lsSMS.View = System.Windows.Forms.View.Details
        '
        'txtContent
        '
        Me.txtContent.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContent.Location = New System.Drawing.Point(257, 311)
        Me.txtContent.Multiline = true
        Me.txtContent.Name = "txtContent"
        Me.txtContent.ReadOnly = true
        Me.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtContent.Size = New System.Drawing.Size(787, 147)
        Me.txtContent.TabIndex = 6
        Me.txtContent.Text = "txtContent"
        '
        'lbFrom
        '
        Me.lbFrom.AutoSize = true
        Me.lbFrom.Location = New System.Drawing.Point(257, 295)
        Me.lbFrom.Name = "lbFrom"
        Me.lbFrom.Size = New System.Drawing.Size(38, 13)
        Me.lbFrom.TabIndex = 5
        Me.lbFrom.Text = "lbFrom"
        '
        'lbDate
        '
        Me.lbDate.Location = New System.Drawing.Point(869, 295)
        Me.lbDate.Name = "lbDate"
        Me.lbDate.Size = New System.Drawing.Size(175, 13)
        Me.lbDate.TabIndex = 6
        Me.lbDate.Text = "lbDate"
        Me.lbDate.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dpFrom
        '
        Me.dpFrom.CustomFormat = "MMM dd, yyyy"
        Me.dpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpFrom.Location = New System.Drawing.Point(733, 13)
        Me.dpFrom.Name = "dpFrom"
        Me.dpFrom.Size = New System.Drawing.Size(106, 20)
        Me.dpFrom.TabIndex = 1
        '
        'dpTo
        '
        Me.dpTo.CustomFormat = "MMM dd, yyyy"
        Me.dpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpTo.Location = New System.Drawing.Point(871, 13)
        Me.dpTo.Name = "dpTo"
        Me.dpTo.Size = New System.Drawing.Size(106, 20)
        Me.dpTo.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(697, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "From"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(845, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "To"
        '
        'btView
        '
        Me.btView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btView.Location = New System.Drawing.Point(983, 14)
        Me.btView.Name = "btView"
        Me.btView.Size = New System.Drawing.Size(61, 23)
        Me.btView.TabIndex = 3
        Me.btView.Text = "View"
        Me.btView.UseVisualStyleBackColor = true
        '
        'cbBranch
        '
        Me.cbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBranch.FormattingEnabled = true
        Me.cbBranch.Location = New System.Drawing.Point(12, 14)
        Me.cbBranch.Name = "cbBranch"
        Me.cbBranch.Size = New System.Drawing.Size(124, 21)
        Me.cbBranch.TabIndex = 0
        '
        'lbBranchDB
        '
        Me.lbBranchDB.AutoSize = true
        Me.lbBranchDB.Location = New System.Drawing.Point(187, 482)
        Me.lbBranchDB.Name = "lbBranchDB"
        Me.lbBranchDB.Size = New System.Drawing.Size(64, 13)
        Me.lbBranchDB.TabIndex = 13
        Me.lbBranchDB.Text = "lbBranchDB"
        Me.lbBranchDB.Visible = false
        '
        'ContextMenuMessages
        '
        Me.ContextMenuMessages.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReplyToolStripMenuItem, Me.ToolStripSeparator1, Me.BlankToolStripMenuItem1})
        Me.ContextMenuMessages.Name = "ContextMenuStrip1"
        Me.ContextMenuMessages.Size = New System.Drawing.Size(104, 54)
        '
        'ReplyToolStripMenuItem
        '
        Me.ReplyToolStripMenuItem.Image = Global.BeloSMS.My.Resources.Resources.Email_Reply_icon_24
        Me.ReplyToolStripMenuItem.Name = "ReplyToolStripMenuItem"
        Me.ReplyToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ReplyToolStripMenuItem.Text = "Reply"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(100, 6)
        '
        'BlankToolStripMenuItem1
        '
        Me.BlankToolStripMenuItem1.Name = "BlankToolStripMenuItem1"
        Me.BlankToolStripMenuItem1.Size = New System.Drawing.Size(103, 22)
        '
        'ContextMessageInbox
        '
        Me.ContextMessageInbox.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ResendToolStripMenuItem, Me.ToolStripSeparator2, Me.BlankToolStripMenuItem})
        Me.ContextMessageInbox.Name = "ContextMenuStrip1"
        Me.ContextMessageInbox.Size = New System.Drawing.Size(113, 76)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.BeloSMS.My.Resources.Resources.Email_Reply_icon_24
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(112, 22)
        Me.ToolStripMenuItem1.Text = "Reply"
        '
        'ResendToolStripMenuItem
        '
        Me.ResendToolStripMenuItem.Image = CType(resources.GetObject("ResendToolStripMenuItem.Image"),System.Drawing.Image)
        Me.ResendToolStripMenuItem.Name = "ResendToolStripMenuItem"
        Me.ResendToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.ResendToolStripMenuItem.Text = "Resend"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(109, 6)
        '
        'BlankToolStripMenuItem
        '
        Me.BlankToolStripMenuItem.Name = "BlankToolStripMenuItem"
        Me.BlankToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        '
        'Timer1
        '
        Me.Timer1.Enabled = true
        Me.Timer1.Interval = 1000
        '
        'btCheckSMS
        '
        Me.btCheckSMS.Location = New System.Drawing.Point(616, 12)
        Me.btCheckSMS.Name = "btCheckSMS"
        Me.btCheckSMS.Size = New System.Drawing.Size(75, 23)
        Me.btCheckSMS.TabIndex = 14
        Me.btCheckSMS.Text = "CheckSMS"
        Me.btCheckSMS.UseVisualStyleBackColor = true
        Me.btCheckSMS.Visible = false
        '
        'lbTimer
        '
        Me.lbTimer.AutoSize = true
        Me.lbTimer.Location = New System.Drawing.Point(12, 482)
        Me.lbTimer.Name = "lbTimer"
        Me.lbTimer.Size = New System.Drawing.Size(41, 13)
        Me.lbTimer.TabIndex = 16
        Me.lbTimer.Text = "lbTimer"
        Me.lbTimer.Visible = false
        '
        'btViewCurrentSMS
        '
        Me.btViewCurrentSMS.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btViewCurrentSMS.Location = New System.Drawing.Point(142, 12)
        Me.btViewCurrentSMS.Name = "btViewCurrentSMS"
        Me.btViewCurrentSMS.Size = New System.Drawing.Size(109, 23)
        Me.btViewCurrentSMS.TabIndex = 17
        Me.btViewCurrentSMS.Text = "View Current SMS"
        Me.btViewCurrentSMS.UseVisualStyleBackColor = true
        '
        'lbpxID
        '
        Me.lbpxID.AutoSize = true
        Me.lbpxID.Location = New System.Drawing.Point(59, 482)
        Me.lbpxID.Name = "lbpxID"
        Me.lbpxID.Size = New System.Drawing.Size(37, 13)
        Me.lbpxID.TabIndex = 18
        Me.lbpxID.Text = "lbpxID"
        Me.lbpxID.Visible = false
        '
        'cbViewBy
        '
        Me.cbViewBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbViewBy.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbViewBy.FormattingEnabled = true
        Me.cbViewBy.Items.AddRange(New Object() {"Branch", "Department"})
        Me.cbViewBy.Location = New System.Drawing.Point(307, 14)
        Me.cbViewBy.Name = "cbViewBy"
        Me.cbViewBy.Size = New System.Drawing.Size(109, 21)
        Me.cbViewBy.TabIndex = 20
        '
        'lbViewBy
        '
        Me.lbViewBy.AutoSize = true
        Me.lbViewBy.Location = New System.Drawing.Point(257, 19)
        Me.lbViewBy.Name = "lbViewBy"
        Me.lbViewBy.Size = New System.Drawing.Size(44, 13)
        Me.lbViewBy.TabIndex = 21
        Me.lbViewBy.Text = "View by"
        '
        'lbDBconnection
        '
        Me.lbDBconnection.AutoSize = true
        Me.lbDBconnection.Location = New System.Drawing.Point(333, 482)
        Me.lbDBconnection.Name = "lbDBconnection"
        Me.lbDBconnection.Size = New System.Drawing.Size(83, 13)
        Me.lbDBconnection.TabIndex = 22
        Me.lbDBconnection.Text = "lbDBconnection"
        Me.lbDBconnection.Visible = false
        '
        'txtFilter
        '
        Me.txtFilter.Location = New System.Drawing.Point(510, 17)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(100, 20)
        Me.txtFilter.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(431, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Search Name :"
        '
        'btnUnread
        '
        Me.btnUnread.Location = New System.Drawing.Point(12, 456)
        Me.btnUnread.Name = "btnUnread"
        Me.btnUnread.Size = New System.Drawing.Size(239, 23)
        Me.btnUnread.TabIndex = 25
        Me.btnUnread.Text = "Unread Messages"
        Me.btnUnread.UseVisualStyleBackColor = true
        Me.btnUnread.Visible = false
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1050, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = true
        Me.Button1.Visible = false
        '
        'frmPatientSMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1108, 504)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnUnread)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFilter)
        Me.Controls.Add(Me.lbViewBy)
        Me.Controls.Add(Me.lstPx_lsSMS)
        Me.Controls.Add(Me.cbViewBy)
        Me.Controls.Add(Me.btViewCurrentSMS)
        Me.Controls.Add(Me.cbBranch)
        Me.Controls.Add(Me.btView)
        Me.Controls.Add(Me.lsPxSMS)
        Me.Controls.Add(Me.dpTo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btCheckSMS)
        Me.Controls.Add(Me.txtContent)
        Me.Controls.Add(Me.lbDBconnection)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbBranchDB)
        Me.Controls.Add(Me.lbpxID)
        Me.Controls.Add(Me.lbDate)
        Me.Controls.Add(Me.dpFrom)
        Me.Controls.Add(Me.lbFrom)
        Me.Controls.Add(Me.lbTimer)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "frmPatientSMS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inbox"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ContextMenuMessages.ResumeLayout(false)
        Me.ContextMessageInbox.ResumeLayout(false)
        CType(Me.BindingSource1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents lsPxSMS As System.Windows.Forms.ListView
    Friend WithEvents lstPx_lsSMS As System.Windows.Forms.ListView
    Friend WithEvents txtContent As System.Windows.Forms.TextBox
    Friend WithEvents lbFrom As System.Windows.Forms.Label
    Friend WithEvents lbDate As System.Windows.Forms.Label
    Friend WithEvents dpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents dpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btView As System.Windows.Forms.Button
    Friend WithEvents cbBranch As System.Windows.Forms.ComboBox
    Friend WithEvents lbBranchDB As System.Windows.Forms.Label
    Friend WithEvents ContextMenuMessages As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ReplyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ContextMessageInbox As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ResendToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BlankToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BlankToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btCheckSMS As System.Windows.Forms.Button
    Friend WithEvents lbTimer As System.Windows.Forms.Label
    Friend WithEvents btViewCurrentSMS As System.Windows.Forms.Button
    Friend WithEvents lbpxID As System.Windows.Forms.Label
    Friend WithEvents cbViewBy As System.Windows.Forms.ComboBox
    Friend WithEvents lbViewBy As System.Windows.Forms.Label
    Friend WithEvents lbDBconnection As System.Windows.Forms.Label
    Friend WithEvents txtFilter As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnUnread As System.Windows.Forms.Button
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
