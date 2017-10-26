<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSMSUpdate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSMSUpdate))
        Me.btUpdate = New System.Windows.Forms.Button()
        Me.btShutdown = New System.Windows.Forms.Button()
        Me.btCancel = New System.Windows.Forms.Button()
        Me.lbStatus = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btUpdate
        '
        Me.btUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btUpdate.Location = New System.Drawing.Point(302, 15)
        Me.btUpdate.Name = "btUpdate"
        Me.btUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btUpdate.TabIndex = 0
        Me.btUpdate.Text = "Update"
        Me.btUpdate.UseVisualStyleBackColor = True
        Me.btUpdate.Visible = False
        '
        'btShutdown
        '
        Me.btShutdown.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btShutdown.Location = New System.Drawing.Point(218, 15)
        Me.btShutdown.Name = "btShutdown"
        Me.btShutdown.Size = New System.Drawing.Size(75, 23)
        Me.btShutdown.TabIndex = 1
        Me.btShutdown.Text = "Close BeloSMS"
        Me.btShutdown.UseVisualStyleBackColor = True
        Me.btShutdown.Visible = False
        '
        'btCancel
        '
        Me.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btCancel.Location = New System.Drawing.Point(302, 44)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(75, 23)
        Me.btCancel.TabIndex = 3
        Me.btCancel.Text = "Cancel"
        Me.btCancel.UseVisualStyleBackColor = True
        '
        'lbStatus
        '
        Me.lbStatus.Location = New System.Drawing.Point(12, 46)
        Me.lbStatus.Name = "lbStatus"
        Me.lbStatus.Size = New System.Drawing.Size(281, 19)
        Me.lbStatus.TabIndex = 5
        Me.lbStatus.Text = "lbStatus"
        Me.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'frmSMSUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(389, 78)
        Me.Controls.Add(Me.lbStatus)
        Me.Controls.Add(Me.btCancel)
        Me.Controls.Add(Me.btShutdown)
        Me.Controls.Add(Me.btUpdate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSMSUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BeloSMS Downloading Update"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btUpdate As System.Windows.Forms.Button
    Friend WithEvents btShutdown As System.Windows.Forms.Button
    Friend WithEvents btCancel As System.Windows.Forms.Button
    Friend WithEvents lbStatus As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
