<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatientsList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPatientsList))
        Me.lstPatientList = New System.Windows.Forms.ListView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.RowsToolStrip = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.SearchPatientNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pxNameToolStrip = New System.Windows.Forms.ToolStripTextBox()
        Me.pxLastNameToolStrip = New System.Windows.Forms.ToolStripTextBox()
        Me.pxMiddleNameToolStrip = New System.Windows.Forms.ToolStripTextBox()
        Me.pxMobileToolStrip = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.GenderToolStrip = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.AlertStatusToolStrip = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SearchToolStrip = New System.Windows.Forms.ToolStripButton()
        Me.lbPatientsList = New System.Windows.Forms.Label()
        Me.ContextMenuMessages = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BlankToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbNoRecordFound = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout
        Me.ToolStrip1.SuspendLayout
        Me.ContextMenuMessages.SuspendLayout
        Me.SuspendLayout
        '
        'lstPatientList
        '
        Me.lstPatientList.FullRowSelect = true
        Me.lstPatientList.GridLines = true
        Me.lstPatientList.Location = New System.Drawing.Point(12, 76)
        Me.lstPatientList.Name = "lstPatientList"
        Me.lstPatientList.Size = New System.Drawing.Size(900, 364)
        Me.lstPatientList.TabIndex = 0
        Me.lstPatientList.UseCompatibleStateImageBehavior = false
        Me.lstPatientList.View = System.Windows.Forms.View.Details
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RowsToolStrip})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 461)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(942, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'RowsToolStrip
        '
        Me.RowsToolStrip.Name = "RowsToolStrip"
        Me.RowsToolStrip.Size = New System.Drawing.Size(82, 17)
        Me.RowsToolStrip.Text = "RowsToolStrip"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.pxNameToolStrip, Me.pxLastNameToolStrip, Me.pxMiddleNameToolStrip, Me.pxMobileToolStrip, Me.ToolStripLabel2, Me.GenderToolStrip, Me.ToolStripLabel1, Me.AlertStatusToolStrip, Me.ToolStripSeparator1, Me.SearchToolStrip})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(942, 39)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchPatientNameToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"),System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(65, 36)
        Me.ToolStripDropDownButton1.Text = "Shortcut"
        Me.ToolStripDropDownButton1.Visible = false
        '
        'SearchPatientNameToolStripMenuItem
        '
        Me.SearchPatientNameToolStripMenuItem.Name = "SearchPatientNameToolStripMenuItem"
        Me.SearchPatientNameToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.SearchPatientNameToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.SearchPatientNameToolStripMenuItem.Text = "Search Patient Name"
        '
        'pxNameToolStrip
        '
        Me.pxNameToolStrip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pxNameToolStrip.MaxLength = 100
        Me.pxNameToolStrip.Name = "pxNameToolStrip"
        Me.pxNameToolStrip.Size = New System.Drawing.Size(150, 39)
        Me.pxNameToolStrip.Text = "First Name"
        '
        'pxLastNameToolStrip
        '
        Me.pxLastNameToolStrip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pxLastNameToolStrip.MaxLength = 100
        Me.pxLastNameToolStrip.Name = "pxLastNameToolStrip"
        Me.pxLastNameToolStrip.Size = New System.Drawing.Size(150, 39)
        Me.pxLastNameToolStrip.Text = "Last Name"
        '
        'pxMiddleNameToolStrip
        '
        Me.pxMiddleNameToolStrip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pxMiddleNameToolStrip.MaxLength = 100
        Me.pxMiddleNameToolStrip.Name = "pxMiddleNameToolStrip"
        Me.pxMiddleNameToolStrip.Size = New System.Drawing.Size(100, 39)
        Me.pxMiddleNameToolStrip.Text = "Middle Name"
        '
        'pxMobileToolStrip
        '
        Me.pxMobileToolStrip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pxMobileToolStrip.MaxLength = 25
        Me.pxMobileToolStrip.Name = "pxMobileToolStrip"
        Me.pxMobileToolStrip.Size = New System.Drawing.Size(100, 39)
        Me.pxMobileToolStrip.Text = "Mobile"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(45, 36)
        Me.ToolStripLabel2.Text = "Gender"
        '
        'GenderToolStrip
        '
        Me.GenderToolStrip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GenderToolStrip.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GenderToolStrip.Name = "GenderToolStrip"
        Me.GenderToolStrip.Size = New System.Drawing.Size(75, 39)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(67, 36)
        Me.ToolStripLabel1.Text = "Alert Status"
        '
        'AlertStatusToolStrip
        '
        Me.AlertStatusToolStrip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AlertStatusToolStrip.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.AlertStatusToolStrip.Name = "AlertStatusToolStrip"
        Me.AlertStatusToolStrip.Size = New System.Drawing.Size(75, 39)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'SearchToolStrip
        '
        Me.SearchToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SearchToolStrip.Image = CType(resources.GetObject("SearchToolStrip.Image"),System.Drawing.Image)
        Me.SearchToolStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SearchToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SearchToolStrip.Name = "SearchToolStrip"
        Me.SearchToolStrip.Size = New System.Drawing.Size(36, 36)
        Me.SearchToolStrip.Text = "Search"
        '
        'lbPatientsList
        '
        Me.lbPatientsList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbPatientsList.Location = New System.Drawing.Point(8, 50)
        Me.lbPatientsList.Name = "lbPatientsList"
        Me.lbPatientsList.Size = New System.Drawing.Size(138, 23)
        Me.lbPatientsList.TabIndex = 7
        Me.lbPatientsList.Text = "Patients List"
        '
        'ContextMenuMessages
        '
        Me.ContextMenuMessages.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SentToolStripMenuItem, Me.ToolStripSeparator2, Me.BlankToolStripMenuItem})
        Me.ContextMenuMessages.Name = "ContextMenuStrip1"
        Me.ContextMenuMessages.Size = New System.Drawing.Size(127, 54)
        '
        'SentToolStripMenuItem
        '
        Me.SentToolStripMenuItem.Image = CType(resources.GetObject("SentToolStripMenuItem.Image"),System.Drawing.Image)
        Me.SentToolStripMenuItem.Name = "SentToolStripMenuItem"
        Me.SentToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.SentToolStripMenuItem.Text = "Send SMS"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(123, 6)
        '
        'BlankToolStripMenuItem
        '
        Me.BlankToolStripMenuItem.Name = "BlankToolStripMenuItem"
        Me.BlankToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        '
        'lbNoRecordFound
        '
        Me.lbNoRecordFound.AutoSize = true
        Me.lbNoRecordFound.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbNoRecordFound.ForeColor = System.Drawing.Color.Maroon
        Me.lbNoRecordFound.Location = New System.Drawing.Point(162, 50)
        Me.lbNoRecordFound.Name = "lbNoRecordFound"
        Me.lbNoRecordFound.Size = New System.Drawing.Size(139, 20)
        Me.lbNoRecordFound.TabIndex = 8
        Me.lbNoRecordFound.Text = "lbNoRecordFound"
        '
        'frmPatientsList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(942, 483)
        Me.Controls.Add(Me.lbNoRecordFound)
        Me.Controls.Add(Me.lbPatientsList)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lstPatientList)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "frmPatientsList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Patients List"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(false)
        Me.StatusStrip1.PerformLayout
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        Me.ContextMenuMessages.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents lstPatientList As System.Windows.Forms.ListView
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents RowsToolStrip As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents SearchToolStrip As System.Windows.Forms.ToolStripButton
    Friend WithEvents lbPatientsList As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents pxNameToolStrip As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents SearchPatientNameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlertStatusToolStrip As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents GenderToolStrip As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ContextMenuMessages As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BlankToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pxLastNameToolStrip As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents pxMiddleNameToolStrip As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents pxMobileToolStrip As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents lbNoRecordFound As System.Windows.Forms.Label
End Class
