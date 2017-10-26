<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSMSBirthday
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSMSBirthday))
        Me.lstPatientsBirthday = New System.Windows.Forms.ListView()
        Me.dpFrom = New System.Windows.Forms.DateTimePicker()
        Me.btView = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btSendToAll = New System.Windows.Forms.Button()
        Me.txtBirthday = New System.Windows.Forms.TextBox()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ExcelToolStrip = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pbExtract = New System.Windows.Forms.ToolStripProgressBar()
        Me.PercentToolStrip = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ContextMessageInbox = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ComposeNBGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SendBBGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ContextMessageInbox.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstPatientsBirthday
        '
        Me.lstPatientsBirthday.FullRowSelect = True
        Me.lstPatientsBirthday.GridLines = True
        Me.lstPatientsBirthday.Location = New System.Drawing.Point(12, 77)
        Me.lstPatientsBirthday.Name = "lstPatientsBirthday"
        Me.lstPatientsBirthday.Size = New System.Drawing.Size(826, 287)
        Me.lstPatientsBirthday.TabIndex = 11
        Me.lstPatientsBirthday.UseCompatibleStateImageBehavior = False
        Me.lstPatientsBirthday.View = System.Windows.Forms.View.Details
        '
        'dpFrom
        '
        Me.dpFrom.CustomFormat = "MMMM dd"
        Me.dpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpFrom.Location = New System.Drawing.Point(638, 45)
        Me.dpFrom.Name = "dpFrom"
        Me.dpFrom.Size = New System.Drawing.Size(119, 20)
        Me.dpFrom.TabIndex = 12
        '
        'btView
        '
        Me.btView.Location = New System.Drawing.Point(763, 42)
        Me.btView.Name = "btView"
        Me.btView.Size = New System.Drawing.Size(75, 23)
        Me.btView.TabIndex = 14
        Me.btView.Text = "View"
        Me.btView.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(602, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "From"
        '
        'btSendToAll
        '
        Me.btSendToAll.Location = New System.Drawing.Point(302, 507)
        Me.btSendToAll.Name = "btSendToAll"
        Me.btSendToAll.Size = New System.Drawing.Size(75, 23)
        Me.btSendToAll.TabIndex = 17
        Me.btSendToAll.Text = "Send to All"
        Me.btSendToAll.UseVisualStyleBackColor = True
        '
        'txtBirthday
        '
        Me.txtBirthday.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtBirthday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBirthday.Location = New System.Drawing.Point(12, 396)
        Me.txtBirthday.Multiline = True
        Me.txtBirthday.Name = "txtBirthday"
        Me.txtBirthday.ReadOnly = True
        Me.txtBirthday.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBirthday.Size = New System.Drawing.Size(365, 105)
        Me.txtBirthday.TabIndex = 18
        Me.txtBirthday.Text = "txtBirthday"
        '
        'txtMobile
        '
        Me.txtMobile.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMobile.Location = New System.Drawing.Point(56, 370)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.ReadOnly = True
        Me.txtMobile.Size = New System.Drawing.Size(322, 20)
        Me.txtMobile.TabIndex = 19
        Me.txtMobile.Text = "txtMobile"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 372)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Mobile"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExcelToolStrip})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(850, 39)
        Me.ToolStrip1.TabIndex = 21
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ExcelToolStrip
        '
        Me.ExcelToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ExcelToolStrip.Image = CType(resources.GetObject("ExcelToolStrip.Image"), System.Drawing.Image)
        Me.ExcelToolStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExcelToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExcelToolStrip.Name = "ExcelToolStrip"
        Me.ExcelToolStrip.Size = New System.Drawing.Size(36, 36)
        Me.ExcelToolStrip.Text = "Export to excel"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusCount, Me.pbExtract, Me.PercentToolStrip})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 544)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(850, 22)
        Me.StatusStrip1.TabIndex = 22
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusCount
        '
        Me.ToolStripStatusCount.Name = "ToolStripStatusCount"
        Me.ToolStripStatusCount.Size = New System.Drawing.Size(119, 17)
        Me.ToolStripStatusCount.Text = "ToolStripStatusCount"
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
        'ContextMessageInbox
        '
        Me.ContextMessageInbox.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComposeNBGToolStripMenuItem, Me.SendBBGToolStripMenuItem, Me.ToolStripSeparator2})
        Me.ContextMessageInbox.Name = "ContextMenuStrip1"
        Me.ContextMessageInbox.Size = New System.Drawing.Size(249, 54)
        '
        'ComposeNBGToolStripMenuItem
        '
        Me.ComposeNBGToolStripMenuItem.Name = "ComposeNBGToolStripMenuItem"
        Me.ComposeNBGToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.ComposeNBGToolStripMenuItem.Text = "Compose New Bithday Greetings"
        Me.ComposeNBGToolStripMenuItem.Visible = False
        '
        'SendBBGToolStripMenuItem
        '
        Me.SendBBGToolStripMenuItem.Image = CType(resources.GetObject("SendBBGToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SendBBGToolStripMenuItem.Name = "SendBBGToolStripMenuItem"
        Me.SendBBGToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.SendBBGToolStripMenuItem.Text = "Send Belo Birthday Greetings"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(245, 6)
        '
        'frmSMSBirthday
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 566)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMobile)
        Me.Controls.Add(Me.txtBirthday)
        Me.Controls.Add(Me.btSendToAll)
        Me.Controls.Add(Me.dpFrom)
        Me.Controls.Add(Me.btView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstPatientsBirthday)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSMSBirthday"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Birthday Full Blass SMS"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ContextMessageInbox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstPatientsBirthday As System.Windows.Forms.ListView
    Friend WithEvents dpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents btView As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btSendToAll As System.Windows.Forms.Button
    Friend WithEvents txtBirthday As System.Windows.Forms.TextBox
    Friend WithEvents txtMobile As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ExcelToolStrip As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents pbExtract As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents PercentToolStrip As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ContextMessageInbox As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SendBBGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ComposeNBGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusCount As System.Windows.Forms.ToolStripStatusLabel
End Class
