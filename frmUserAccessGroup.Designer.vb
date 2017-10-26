<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserAccessGroup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserAccessGroup))
        Me.lstUserGroupList = New System.Windows.Forms.ListView()
        Me.txtGroupname = New System.Windows.Forms.TextBox()
        Me.btView = New System.Windows.Forms.Button()
        Me.txtGroupNameUpdate = New System.Windows.Forms.TextBox()
        Me.txtDepartmentName = New System.Windows.Forms.TextBox()
        Me.txtKey = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btUpdate = New System.Windows.Forms.Button()
        Me.lbID = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtAcknowledgmentAdd = New System.Windows.Forms.TextBox()
        Me.chEnableDepUpdate = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtReplyFormatAdd = New System.Windows.Forms.TextBox()
        Me.txtKeyAdd = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDepartmentNameAdd = New System.Windows.Forms.TextBox()
        Me.txtGroupNameAdd = New System.Windows.Forms.TextBox()
        Me.btAddGroup = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtAcknowledgment = New System.Windows.Forms.TextBox()
        Me.chEnableDep = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtReplyFormat = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstUserGroupList
        '
        Me.lstUserGroupList.FullRowSelect = True
        Me.lstUserGroupList.GridLines = True
        Me.lstUserGroupList.Location = New System.Drawing.Point(12, 45)
        Me.lstUserGroupList.Name = "lstUserGroupList"
        Me.lstUserGroupList.Size = New System.Drawing.Size(1013, 188)
        Me.lstUserGroupList.TabIndex = 2
        Me.lstUserGroupList.UseCompatibleStateImageBehavior = False
        Me.lstUserGroupList.View = System.Windows.Forms.View.Details
        '
        'txtGroupname
        '
        Me.txtGroupname.Location = New System.Drawing.Point(81, 20)
        Me.txtGroupname.Name = "txtGroupname"
        Me.txtGroupname.Size = New System.Drawing.Size(136, 20)
        Me.txtGroupname.TabIndex = 5
        Me.txtGroupname.Text = "txtGroupname"
        '
        'btView
        '
        Me.btView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btView.Location = New System.Drawing.Point(223, 18)
        Me.btView.Name = "btView"
        Me.btView.Size = New System.Drawing.Size(75, 23)
        Me.btView.TabIndex = 6
        Me.btView.Text = "View"
        Me.btView.UseVisualStyleBackColor = True
        '
        'txtGroupNameUpdate
        '
        Me.txtGroupNameUpdate.Location = New System.Drawing.Point(110, 25)
        Me.txtGroupNameUpdate.Name = "txtGroupNameUpdate"
        Me.txtGroupNameUpdate.ReadOnly = True
        Me.txtGroupNameUpdate.Size = New System.Drawing.Size(185, 20)
        Me.txtGroupNameUpdate.TabIndex = 7
        Me.txtGroupNameUpdate.Text = "txtGroupNameUpdate"
        '
        'txtDepartmentName
        '
        Me.txtDepartmentName.Location = New System.Drawing.Point(110, 51)
        Me.txtDepartmentName.Name = "txtDepartmentName"
        Me.txtDepartmentName.Size = New System.Drawing.Size(185, 20)
        Me.txtDepartmentName.TabIndex = 8
        Me.txtDepartmentName.Text = "txtDepartmentName"
        '
        'txtKey
        '
        Me.txtKey.Location = New System.Drawing.Point(110, 77)
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Size = New System.Drawing.Size(185, 20)
        Me.txtKey.TabIndex = 9
        Me.txtKey.Text = "txtKey"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Group name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Department"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Key"
        '
        'btUpdate
        '
        Me.btUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btUpdate.Location = New System.Drawing.Point(410, 315)
        Me.btUpdate.Name = "btUpdate"
        Me.btUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btUpdate.TabIndex = 13
        Me.btUpdate.Text = "Update"
        Me.btUpdate.UseVisualStyleBackColor = True
        '
        'lbID
        '
        Me.lbID.AutoSize = True
        Me.lbID.Location = New System.Drawing.Point(304, 23)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(26, 13)
        Me.lbID.TabIndex = 14
        Me.lbID.Text = "lbID"
        Me.lbID.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtAcknowledgmentAdd)
        Me.GroupBox2.Controls.Add(Me.chEnableDepUpdate)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtReplyFormatAdd)
        Me.GroupBox2.Controls.Add(Me.txtKeyAdd)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtDepartmentNameAdd)
        Me.GroupBox2.Controls.Add(Me.txtGroupNameAdd)
        Me.GroupBox2.Controls.Add(Me.btAddGroup)
        Me.GroupBox2.Location = New System.Drawing.Point(524, 239)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(506, 342)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Add user access group"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 185)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Acknowledgment"
        '
        'txtAcknowledgmentAdd
        '
        Me.txtAcknowledgmentAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAcknowledgmentAdd.Location = New System.Drawing.Point(101, 183)
        Me.txtAcknowledgmentAdd.Multiline = True
        Me.txtAcknowledgmentAdd.Name = "txtAcknowledgmentAdd"
        Me.txtAcknowledgmentAdd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAcknowledgmentAdd.Size = New System.Drawing.Size(375, 126)
        Me.txtAcknowledgmentAdd.TabIndex = 21
        Me.txtAcknowledgmentAdd.Text = "txtAcknowledgmentAdd"
        '
        'chEnableDepUpdate
        '
        Me.chEnableDepUpdate.AutoSize = True
        Me.chEnableDepUpdate.Location = New System.Drawing.Point(101, 319)
        Me.chEnableDepUpdate.Name = "chEnableDepUpdate"
        Me.chEnableDepUpdate.Size = New System.Drawing.Size(117, 17)
        Me.chEnableDepUpdate.TabIndex = 20
        Me.chEnableDepUpdate.Text = "Enable Department"
        Me.chEnableDepUpdate.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 106)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Reply format"
        '
        'txtReplyFormatAdd
        '
        Me.txtReplyFormatAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReplyFormatAdd.Location = New System.Drawing.Point(101, 104)
        Me.txtReplyFormatAdd.Multiline = True
        Me.txtReplyFormatAdd.Name = "txtReplyFormatAdd"
        Me.txtReplyFormatAdd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReplyFormatAdd.Size = New System.Drawing.Size(375, 74)
        Me.txtReplyFormatAdd.TabIndex = 18
        Me.txtReplyFormatAdd.Text = "txtReplyFormatAdd"
        '
        'txtKeyAdd
        '
        Me.txtKeyAdd.Location = New System.Drawing.Point(101, 74)
        Me.txtKeyAdd.Name = "txtKeyAdd"
        Me.txtKeyAdd.Size = New System.Drawing.Size(144, 20)
        Me.txtKeyAdd.TabIndex = 17
        Me.txtKeyAdd.Text = "txtKeyAdd"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Group name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Key"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Department"
        '
        'txtDepartmentNameAdd
        '
        Me.txtDepartmentNameAdd.Location = New System.Drawing.Point(101, 48)
        Me.txtDepartmentNameAdd.Name = "txtDepartmentNameAdd"
        Me.txtDepartmentNameAdd.Size = New System.Drawing.Size(144, 20)
        Me.txtDepartmentNameAdd.TabIndex = 10
        Me.txtDepartmentNameAdd.Text = "txtDepartmentNameAdd"
        '
        'txtGroupNameAdd
        '
        Me.txtGroupNameAdd.Location = New System.Drawing.Point(101, 19)
        Me.txtGroupNameAdd.Name = "txtGroupNameAdd"
        Me.txtGroupNameAdd.Size = New System.Drawing.Size(144, 20)
        Me.txtGroupNameAdd.TabIndex = 1
        Me.txtGroupNameAdd.Text = "txtGroupNameAdd"
        '
        'btAddGroup
        '
        Me.btAddGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btAddGroup.Location = New System.Drawing.Point(391, 315)
        Me.btAddGroup.Name = "btAddGroup"
        Me.btAddGroup.Size = New System.Drawing.Size(85, 23)
        Me.btAddGroup.TabIndex = 0
        Me.btAddGroup.Text = "Add Group"
        Me.btAddGroup.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtAcknowledgment)
        Me.GroupBox1.Controls.Add(Me.chEnableDep)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtReplyFormat)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtGroupNameUpdate)
        Me.GroupBox1.Controls.Add(Me.txtDepartmentName)
        Me.GroupBox1.Controls.Add(Me.btUpdate)
        Me.GroupBox1.Controls.Add(Me.txtKey)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 239)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(506, 342)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Update user access group"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 185)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Acknowledgment"
        '
        'txtAcknowledgment
        '
        Me.txtAcknowledgment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAcknowledgment.Location = New System.Drawing.Point(110, 183)
        Me.txtAcknowledgment.Multiline = True
        Me.txtAcknowledgment.Name = "txtAcknowledgment"
        Me.txtAcknowledgment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAcknowledgment.Size = New System.Drawing.Size(375, 126)
        Me.txtAcknowledgment.TabIndex = 17
        Me.txtAcknowledgment.Text = "txtAcknowledgment"
        '
        'chEnableDep
        '
        Me.chEnableDep.AutoSize = True
        Me.chEnableDep.Location = New System.Drawing.Point(110, 319)
        Me.chEnableDep.Name = "chEnableDep"
        Me.chEnableDep.Size = New System.Drawing.Size(117, 17)
        Me.chEnableDep.TabIndex = 16
        Me.chEnableDep.Text = "Enable Department"
        Me.chEnableDep.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Reply format"
        '
        'txtReplyFormat
        '
        Me.txtReplyFormat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReplyFormat.Location = New System.Drawing.Point(110, 103)
        Me.txtReplyFormat.Multiline = True
        Me.txtReplyFormat.Name = "txtReplyFormat"
        Me.txtReplyFormat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReplyFormat.Size = New System.Drawing.Size(375, 74)
        Me.txtReplyFormat.TabIndex = 14
        Me.txtReplyFormat.Text = "txtReplyFormat"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Group name"
        '
        'frmUserAccessGroup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1106, 591)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lbID)
        Me.Controls.Add(Me.btView)
        Me.Controls.Add(Me.txtGroupname)
        Me.Controls.Add(Me.lstUserGroupList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUserAccessGroup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User access group name"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstUserGroupList As System.Windows.Forms.ListView
    Friend WithEvents txtGroupname As System.Windows.Forms.TextBox
    Friend WithEvents btView As System.Windows.Forms.Button
    Friend WithEvents txtGroupNameUpdate As System.Windows.Forms.TextBox
    Friend WithEvents txtDepartmentName As System.Windows.Forms.TextBox
    Friend WithEvents txtKey As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btUpdate As System.Windows.Forms.Button
    Friend WithEvents lbID As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtGroupNameAdd As System.Windows.Forms.TextBox
    Friend WithEvents btAddGroup As System.Windows.Forms.Button
    Friend WithEvents txtKeyAdd As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDepartmentNameAdd As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtReplyFormat As System.Windows.Forms.TextBox
    Friend WithEvents txtReplyFormatAdd As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents chEnableDep As System.Windows.Forms.CheckBox
    Friend WithEvents chEnableDepUpdate As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtAcknowledgmentAdd As System.Windows.Forms.TextBox
    Friend WithEvents txtAcknowledgment As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
