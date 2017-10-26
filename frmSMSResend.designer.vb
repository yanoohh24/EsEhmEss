<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSMSResend
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSMSResend))
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
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Send To"
        '
        'btClose
        '
        Me.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btClose.Location = New System.Drawing.Point(402, 241)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(75, 23)
        Me.btClose.TabIndex = 9
        Me.btClose.Text = "Close"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'btSend
        '
        Me.btSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btSend.Location = New System.Drawing.Point(321, 241)
        Me.btSend.Name = "btSend"
        Me.btSend.Size = New System.Drawing.Size(75, 23)
        Me.btSend.TabIndex = 8
        Me.btSend.Text = "Send"
        Me.btSend.UseVisualStyleBackColor = True
        '
        'txtMessage
        '
        Me.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMessage.Location = New System.Drawing.Point(15, 35)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.ReadOnly = True
        Me.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMessage.Size = New System.Drawing.Size(462, 200)
        Me.txtMessage.TabIndex = 7
        Me.txtMessage.Text = "txtMessage"
        '
        'txtMobile
        '
        Me.txtMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMobile.Location = New System.Drawing.Point(66, 9)
        Me.txtMobile.MaxLength = 20
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.ReadOnly = True
        Me.txtMobile.Size = New System.Drawing.Size(233, 20)
        Me.txtMobile.TabIndex = 6
        Me.txtMobile.Text = "txtMobile"
        '
        'lbInvalid
        '
        Me.lbInvalid.AutoSize = True
        Me.lbInvalid.ForeColor = System.Drawing.Color.Red
        Me.lbInvalid.Location = New System.Drawing.Point(305, 11)
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
        Me.StatusStrip1.Size = New System.Drawing.Size(489, 22)
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
        Me.lbUsernameAndBranchname.Location = New System.Drawing.Point(12, 246)
        Me.lbUsernameAndBranchname.Name = "lbUsernameAndBranchname"
        Me.lbUsernameAndBranchname.Size = New System.Drawing.Size(142, 13)
        Me.lbUsernameAndBranchname.TabIndex = 16
        Me.lbUsernameAndBranchname.Text = "lbUsernameAndBranchname"
        '
        'frmSMSResend
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 324)
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
        Me.Name = "frmSMSResend"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resend SMS"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
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
End Class
