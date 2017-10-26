<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserBranchFooter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserBranchFooter))
        Me.lstBranchList = New System.Windows.Forms.ListView()
        Me.txtFirstFooter = New System.Windows.Forms.TextBox()
        Me.txtSecondFooter = New System.Windows.Forms.TextBox()
        Me.lbID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btUpdate = New System.Windows.Forms.Button()
        Me.btCancel = New System.Windows.Forms.Button()
        Me.lbBranchName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstBranchList
        '
        Me.lstBranchList.FullRowSelect = True
        Me.lstBranchList.GridLines = True
        Me.lstBranchList.Location = New System.Drawing.Point(12, 12)
        Me.lstBranchList.MultiSelect = False
        Me.lstBranchList.Name = "lstBranchList"
        Me.lstBranchList.Size = New System.Drawing.Size(842, 214)
        Me.lstBranchList.TabIndex = 3
        Me.lstBranchList.UseCompatibleStateImageBehavior = False
        Me.lstBranchList.View = System.Windows.Forms.View.Details
        '
        'txtFirstFooter
        '
        Me.txtFirstFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFirstFooter.Location = New System.Drawing.Point(12, 250)
        Me.txtFirstFooter.Multiline = True
        Me.txtFirstFooter.Name = "txtFirstFooter"
        Me.txtFirstFooter.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtFirstFooter.Size = New System.Drawing.Size(419, 167)
        Me.txtFirstFooter.TabIndex = 4
        Me.txtFirstFooter.Text = "txtFirstFooter"
        '
        'txtSecondFooter
        '
        Me.txtSecondFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSecondFooter.Location = New System.Drawing.Point(437, 250)
        Me.txtSecondFooter.Multiline = True
        Me.txtSecondFooter.Name = "txtSecondFooter"
        Me.txtSecondFooter.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSecondFooter.Size = New System.Drawing.Size(419, 167)
        Me.txtSecondFooter.TabIndex = 5
        Me.txtSecondFooter.Text = "txtSecondFooter"
        '
        'lbID
        '
        Me.lbID.AutoSize = True
        Me.lbID.Location = New System.Drawing.Point(12, 430)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(26, 13)
        Me.lbID.TabIndex = 6
        Me.lbID.Text = "lbID"
        Me.lbID.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 234)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "First Footer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(434, 234)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "End Footer"
        '
        'btUpdate
        '
        Me.btUpdate.Location = New System.Drawing.Point(698, 425)
        Me.btUpdate.Name = "btUpdate"
        Me.btUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btUpdate.TabIndex = 9
        Me.btUpdate.Text = "Update"
        Me.btUpdate.UseVisualStyleBackColor = True
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(779, 425)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(75, 23)
        Me.btCancel.TabIndex = 10
        Me.btCancel.Text = "Cancel"
        Me.btCancel.UseVisualStyleBackColor = True
        '
        'lbBranchName
        '
        Me.lbBranchName.AutoSize = True
        Me.lbBranchName.Location = New System.Drawing.Point(434, 430)
        Me.lbBranchName.Name = "lbBranchName"
        Me.lbBranchName.Size = New System.Drawing.Size(77, 13)
        Me.lbBranchName.TabIndex = 11
        Me.lbBranchName.Text = "lbBranchName"
        Me.lbBranchName.Visible = False
        '
        'frmUserBranchFooter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 457)
        Me.Controls.Add(Me.lbBranchName)
        Me.Controls.Add(Me.btCancel)
        Me.Controls.Add(Me.btUpdate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbID)
        Me.Controls.Add(Me.txtSecondFooter)
        Me.Controls.Add(Me.txtFirstFooter)
        Me.Controls.Add(Me.lstBranchList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUserBranchFooter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Branch Footer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstBranchList As System.Windows.Forms.ListView
    Friend WithEvents txtFirstFooter As System.Windows.Forms.TextBox
    Friend WithEvents txtSecondFooter As System.Windows.Forms.TextBox
    Friend WithEvents lbID As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btUpdate As System.Windows.Forms.Button
    Friend WithEvents btCancel As System.Windows.Forms.Button
    Friend WithEvents lbBranchName As System.Windows.Forms.Label
End Class
