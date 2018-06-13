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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout
        '
        'lstBranchList
        '
        Me.lstBranchList.FullRowSelect = true
        Me.lstBranchList.GridLines = true
        Me.lstBranchList.Location = New System.Drawing.Point(12, 12)
        Me.lstBranchList.MultiSelect = false
        Me.lstBranchList.Name = "lstBranchList"
        Me.lstBranchList.Size = New System.Drawing.Size(842, 214)
        Me.lstBranchList.TabIndex = 3
        Me.lstBranchList.UseCompatibleStateImageBehavior = false
        Me.lstBranchList.View = System.Windows.Forms.View.Details
        '
        'txtFirstFooter
        '
        Me.txtFirstFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFirstFooter.Location = New System.Drawing.Point(12, 250)
        Me.txtFirstFooter.Multiline = true
        Me.txtFirstFooter.Name = "txtFirstFooter"
        Me.txtFirstFooter.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtFirstFooter.Size = New System.Drawing.Size(842, 167)
        Me.txtFirstFooter.TabIndex = 4
        Me.txtFirstFooter.Text = "txtFirstFooter"
        '
        'txtSecondFooter
        '
        Me.txtSecondFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSecondFooter.Location = New System.Drawing.Point(437, 250)
        Me.txtSecondFooter.Multiline = true
        Me.txtSecondFooter.Name = "txtSecondFooter"
        Me.txtSecondFooter.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSecondFooter.Size = New System.Drawing.Size(419, 167)
        Me.txtSecondFooter.TabIndex = 5
        Me.txtSecondFooter.Text = "txtSecondFooter"
        Me.txtSecondFooter.Visible = false
        '
        'lbID
        '
        Me.lbID.AutoSize = true
        Me.lbID.Location = New System.Drawing.Point(9, 425)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(26, 13)
        Me.lbID.TabIndex = 6
        Me.lbID.Text = "lbID"
        Me.lbID.Visible = false
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(9, 234)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Footer"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(434, 234)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "End Footer"
        Me.Label2.Visible = false
        '
        'btUpdate
        '
        Me.btUpdate.Location = New System.Drawing.Point(698, 425)
        Me.btUpdate.Name = "btUpdate"
        Me.btUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btUpdate.TabIndex = 9
        Me.btUpdate.Text = "Update"
        Me.btUpdate.UseVisualStyleBackColor = true
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(779, 425)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(75, 23)
        Me.btCancel.TabIndex = 10
        Me.btCancel.Text = "Cancel"
        Me.btCancel.UseVisualStyleBackColor = true
        '
        'lbBranchName
        '
        Me.lbBranchName.AutoSize = true
        Me.lbBranchName.Location = New System.Drawing.Point(434, 425)
        Me.lbBranchName.Name = "lbBranchName"
        Me.lbBranchName.Size = New System.Drawing.Size(77, 13)
        Me.lbBranchName.TabIndex = 11
        Me.lbBranchName.Text = "lbBranchName"
        Me.lbBranchName.Visible = false
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(9, 443)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(391, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Legend : Add ""|"" ( Shift + \ ) to add Branch Code do this only once."
        '
        'frmUserBranchFooter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 462)
        Me.Controls.Add(Me.lstBranchList)
        Me.Controls.Add(Me.txtFirstFooter)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbBranchName)
        Me.Controls.Add(Me.btCancel)
        Me.Controls.Add(Me.btUpdate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbID)
        Me.Controls.Add(Me.txtSecondFooter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmUserBranchFooter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Branch Footer"
        Me.ResumeLayout(false)
        Me.PerformLayout

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
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
