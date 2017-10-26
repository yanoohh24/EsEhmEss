<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccntInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccntInfo))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbInformation = New System.Windows.Forms.Label()
        Me.lbComputerName = New System.Windows.Forms.Label()
        Me.btOkay = New System.Windows.Forms.Button()
        Me.lbVersion = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lbInformation)
        Me.GroupBox1.Location = New System.Drawing.Point(173, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 177)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Information"
        '
        'lbInformation
        '
        Me.lbInformation.BackColor = System.Drawing.Color.Transparent
        Me.lbInformation.Location = New System.Drawing.Point(6, 30)
        Me.lbInformation.Name = "lbInformation"
        Me.lbInformation.Size = New System.Drawing.Size(300, 130)
        Me.lbInformation.TabIndex = 0
        Me.lbInformation.Text = "lbInformation"
        '
        'lbComputerName
        '
        Me.lbComputerName.BackColor = System.Drawing.Color.Transparent
        Me.lbComputerName.Location = New System.Drawing.Point(179, 217)
        Me.lbComputerName.Name = "lbComputerName"
        Me.lbComputerName.Size = New System.Drawing.Size(300, 43)
        Me.lbComputerName.TabIndex = 1
        Me.lbComputerName.Text = "lbComputerName"
        '
        'btOkay
        '
        Me.btOkay.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btOkay.Location = New System.Drawing.Point(410, 237)
        Me.btOkay.Name = "btOkay"
        Me.btOkay.Size = New System.Drawing.Size(75, 23)
        Me.btOkay.TabIndex = 2
        Me.btOkay.Text = "Okay"
        Me.btOkay.UseVisualStyleBackColor = True
        '
        'lbVersion
        '
        Me.lbVersion.BackColor = System.Drawing.Color.Transparent
        Me.lbVersion.Location = New System.Drawing.Point(173, 19)
        Me.lbVersion.Name = "lbVersion"
        Me.lbVersion.Size = New System.Drawing.Size(312, 15)
        Me.lbVersion.TabIndex = 3
        Me.lbVersion.Text = "lbVersion"
        Me.lbVersion.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frmAccntInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(494, 274)
        Me.Controls.Add(Me.lbVersion)
        Me.Controls.Add(Me.btOkay)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbComputerName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAccntInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account Information"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbInformation As System.Windows.Forms.Label
    Friend WithEvents lbComputerName As System.Windows.Forms.Label
    Friend WithEvents btOkay As System.Windows.Forms.Button
    Friend WithEvents lbVersion As System.Windows.Forms.Label
End Class
