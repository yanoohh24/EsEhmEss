<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployee
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
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.txtEmpid = New MetroFramework.Controls.MetroTextBox()
        Me.txtFname = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtLname = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.txtMname = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.txtMObile = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.dtBirthdate = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.txtPOsition = New MetroFramework.Controls.MetroTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbManager = New MetroFramework.Controls.MetroCheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MetroTextButton1 = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.cbStatus = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroTextButton2 = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.cbBranch = New MetroFramework.Controls.MetroComboBox()
        Me.btnSaveUpdate = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.ep = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.dgEmployee = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblRersult = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.txtFilter = New MetroFramework.Controls.MetroTextBox()
        Me.GroupBox1.SuspendLayout
        Me.GroupBox2.SuspendLayout
        CType(Me.ep,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.dgEmployee,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel1.SuspendLayout
        Me.SuspendLayout
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = true
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel1.Location = New System.Drawing.Point(24, 13)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(75, 15)
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "Employee Id :"
        '
        'txtEmpid
        '
        '
        '
        '
        Me.txtEmpid.CustomButton.Image = Nothing
        Me.txtEmpid.CustomButton.Location = New System.Drawing.Point(208, 1)
        Me.txtEmpid.CustomButton.Name = ""
        Me.txtEmpid.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtEmpid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtEmpid.CustomButton.TabIndex = 1
        Me.txtEmpid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEmpid.CustomButton.UseSelectable = true
        Me.txtEmpid.CustomButton.Visible = false
        Me.txtEmpid.Lines = New String(-1) {}
        Me.txtEmpid.Location = New System.Drawing.Point(24, 35)
        Me.txtEmpid.MaxLength = 32767
        Me.txtEmpid.Name = "txtEmpid"
        Me.txtEmpid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmpid.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEmpid.SelectedText = ""
        Me.txtEmpid.SelectionLength = 0
        Me.txtEmpid.SelectionStart = 0
        Me.txtEmpid.Size = New System.Drawing.Size(230, 23)
        Me.txtEmpid.TabIndex = 1
        Me.txtEmpid.UseSelectable = true
        Me.txtEmpid.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtEmpid.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtFname
        '
        '
        '
        '
        Me.txtFname.CustomButton.Image = Nothing
        Me.txtFname.CustomButton.Location = New System.Drawing.Point(208, 1)
        Me.txtFname.CustomButton.Name = ""
        Me.txtFname.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtFname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtFname.CustomButton.TabIndex = 1
        Me.txtFname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtFname.CustomButton.UseSelectable = true
        Me.txtFname.CustomButton.Visible = false
        Me.txtFname.Lines = New String(-1) {}
        Me.txtFname.Location = New System.Drawing.Point(24, 87)
        Me.txtFname.MaxLength = 32767
        Me.txtFname.Name = "txtFname"
        Me.txtFname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFname.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFname.SelectedText = ""
        Me.txtFname.SelectionLength = 0
        Me.txtFname.SelectionStart = 0
        Me.txtFname.Size = New System.Drawing.Size(230, 23)
        Me.txtFname.TabIndex = 4
        Me.txtFname.UseSelectable = true
        Me.txtFname.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtFname.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = true
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel2.Location = New System.Drawing.Point(24, 65)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(68, 15)
        Me.MetroLabel2.TabIndex = 3
        Me.MetroLabel2.Text = "First Name :"
        '
        'txtLname
        '
        '
        '
        '
        Me.txtLname.CustomButton.Image = Nothing
        Me.txtLname.CustomButton.Location = New System.Drawing.Point(159, 1)
        Me.txtLname.CustomButton.Name = ""
        Me.txtLname.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtLname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtLname.CustomButton.TabIndex = 1
        Me.txtLname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtLname.CustomButton.UseSelectable = true
        Me.txtLname.CustomButton.Visible = false
        Me.txtLname.Lines = New String(-1) {}
        Me.txtLname.Location = New System.Drawing.Point(306, 35)
        Me.txtLname.MaxLength = 32767
        Me.txtLname.Name = "txtLname"
        Me.txtLname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLname.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtLname.SelectedText = ""
        Me.txtLname.SelectionLength = 0
        Me.txtLname.SelectionStart = 0
        Me.txtLname.Size = New System.Drawing.Size(181, 23)
        Me.txtLname.TabIndex = 2
        Me.txtLname.UseSelectable = true
        Me.txtLname.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtLname.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = true
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel3.Location = New System.Drawing.Point(306, 8)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(67, 15)
        Me.MetroLabel3.TabIndex = 5
        Me.MetroLabel3.Text = "Last Name :"
        '
        'txtMname
        '
        '
        '
        '
        Me.txtMname.CustomButton.Image = Nothing
        Me.txtMname.CustomButton.Location = New System.Drawing.Point(8, 1)
        Me.txtMname.CustomButton.Name = ""
        Me.txtMname.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtMname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMname.CustomButton.TabIndex = 1
        Me.txtMname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMname.CustomButton.UseSelectable = true
        Me.txtMname.CustomButton.Visible = false
        Me.txtMname.Lines = New String(-1) {}
        Me.txtMname.Location = New System.Drawing.Point(493, 35)
        Me.txtMname.MaxLength = 32767
        Me.txtMname.Name = "txtMname"
        Me.txtMname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMname.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMname.SelectedText = ""
        Me.txtMname.SelectionLength = 0
        Me.txtMname.SelectionStart = 0
        Me.txtMname.Size = New System.Drawing.Size(30, 23)
        Me.txtMname.TabIndex = 3
        Me.txtMname.UseSelectable = true
        Me.txtMname.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtMname.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = true
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel4.Location = New System.Drawing.Point(493, 8)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(26, 15)
        Me.MetroLabel4.TabIndex = 9
        Me.MetroLabel4.Text = "M.I."
        '
        'txtMObile
        '
        '
        '
        '
        Me.txtMObile.CustomButton.Image = Nothing
        Me.txtMObile.CustomButton.Location = New System.Drawing.Point(195, 1)
        Me.txtMObile.CustomButton.Name = ""
        Me.txtMObile.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtMObile.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMObile.CustomButton.TabIndex = 1
        Me.txtMObile.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMObile.CustomButton.UseSelectable = true
        Me.txtMObile.CustomButton.Visible = false
        Me.txtMObile.Lines = New String(-1) {}
        Me.txtMObile.Location = New System.Drawing.Point(306, 87)
        Me.txtMObile.MaxLength = 32767
        Me.txtMObile.Name = "txtMObile"
        Me.txtMObile.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMObile.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMObile.SelectedText = ""
        Me.txtMObile.SelectionLength = 0
        Me.txtMObile.SelectionStart = 0
        Me.txtMObile.Size = New System.Drawing.Size(217, 23)
        Me.txtMObile.TabIndex = 5
        Me.txtMObile.UseSelectable = true
        Me.txtMObile.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtMObile.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = true
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel5.Location = New System.Drawing.Point(306, 65)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(66, 15)
        Me.MetroLabel5.TabIndex = 10
        Me.MetroLabel5.Text = "Mobile No.:"
        '
        'dtBirthdate
        '
        Me.dtBirthdate.CustomFormat = "yyyy-MM-dd"
        Me.dtBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtBirthdate.Location = New System.Drawing.Point(24, 138)
        Me.dtBirthdate.MinimumSize = New System.Drawing.Size(4, 29)
        Me.dtBirthdate.Name = "dtBirthdate"
        Me.dtBirthdate.Size = New System.Drawing.Size(230, 29)
        Me.dtBirthdate.TabIndex = 6
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = true
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel6.Location = New System.Drawing.Point(24, 116)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(64, 15)
        Me.MetroLabel6.TabIndex = 13
        Me.MetroLabel6.Text = "Birth Date :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.MetroLabel9)
        Me.GroupBox1.Controls.Add(Me.txtPOsition)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbManager)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.MetroTextButton2)
        Me.GroupBox1.Controls.Add(Me.MetroLabel7)
        Me.GroupBox1.Controls.Add(Me.txtMObile)
        Me.GroupBox1.Controls.Add(Me.cbBranch)
        Me.GroupBox1.Controls.Add(Me.dtBirthdate)
        Me.GroupBox1.Controls.Add(Me.btnSaveUpdate)
        Me.GroupBox1.Controls.Add(Me.MetroLabel6)
        Me.GroupBox1.Controls.Add(Me.MetroLabel5)
        Me.GroupBox1.Controls.Add(Me.MetroLabel1)
        Me.GroupBox1.Controls.Add(Me.txtEmpid)
        Me.GroupBox1.Controls.Add(Me.MetroLabel2)
        Me.GroupBox1.Controls.Add(Me.txtFname)
        Me.GroupBox1.Controls.Add(Me.MetroLabel3)
        Me.GroupBox1.Controls.Add(Me.MetroLabel4)
        Me.GroupBox1.Controls.Add(Me.txtLname)
        Me.GroupBox1.Controls.Add(Me.txtMname)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(773, 291)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Employee Info. "
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(91, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(12, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "*"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = true
        Me.MetroLabel9.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel9.Location = New System.Drawing.Point(24, 174)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(52, 15)
        Me.MetroLabel9.TabIndex = 21
        Me.MetroLabel9.Text = "Position :"
        '
        'txtPOsition
        '
        '
        '
        '
        Me.txtPOsition.CustomButton.Image = Nothing
        Me.txtPOsition.CustomButton.Location = New System.Drawing.Point(473, 1)
        Me.txtPOsition.CustomButton.Name = ""
        Me.txtPOsition.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPOsition.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPOsition.CustomButton.TabIndex = 1
        Me.txtPOsition.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPOsition.CustomButton.UseSelectable = true
        Me.txtPOsition.CustomButton.Visible = false
        Me.txtPOsition.Lines = New String(-1) {}
        Me.txtPOsition.Location = New System.Drawing.Point(24, 192)
        Me.txtPOsition.MaxLength = 32767
        Me.txtPOsition.Name = "txtPOsition"
        Me.txtPOsition.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPOsition.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPOsition.SelectedText = ""
        Me.txtPOsition.SelectionLength = 0
        Me.txtPOsition.SelectionStart = 0
        Me.txtPOsition.Size = New System.Drawing.Size(495, 23)
        Me.txtPOsition.TabIndex = 20
        Me.txtPOsition.UseSelectable = true
        Me.txtPOsition.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtPOsition.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(373, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(373, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(12, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(91, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(12, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(91, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(12, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(93, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(12, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "*"
        '
        'cbManager
        '
        Me.cbManager.AutoSize = true
        Me.cbManager.Location = New System.Drawing.Point(449, 120)
        Me.cbManager.Name = "cbManager"
        Me.cbManager.Size = New System.Drawing.Size(70, 15)
        Me.cbManager.TabIndex = 8
        Me.cbManager.Text = "Manager"
        Me.cbManager.UseSelectable = true
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.MetroTextButton1)
        Me.GroupBox2.Controls.Add(Me.cbStatus)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox2.Location = New System.Drawing.Point(568, 17)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(202, 271)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = false
        Me.GroupBox2.Text = "Status"
        '
        'MetroTextButton1
        '
        Me.MetroTextButton1.Image = Nothing
        Me.MetroTextButton1.Location = New System.Drawing.Point(6, 219)
        Me.MetroTextButton1.Name = "MetroTextButton1"
        Me.MetroTextButton1.Size = New System.Drawing.Size(193, 36)
        Me.MetroTextButton1.TabIndex = 23
        Me.MetroTextButton1.Text = "Delete"
        Me.MetroTextButton1.UseSelectable = true
        Me.MetroTextButton1.UseVisualStyleBackColor = true
        Me.MetroTextButton1.Visible = false
        '
        'cbStatus
        '
        Me.cbStatus.AutoSize = true
        Me.cbStatus.Enabled = false
        Me.cbStatus.Location = New System.Drawing.Point(6, 26)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(71, 15)
        Me.cbStatus.TabIndex = 0
        Me.cbStatus.Text = "Resigned"
        Me.cbStatus.UseSelectable = true
        '
        'MetroTextButton2
        '
        Me.MetroTextButton2.Image = Nothing
        Me.MetroTextButton2.Location = New System.Drawing.Point(306, 221)
        Me.MetroTextButton2.Name = "MetroTextButton2"
        Me.MetroTextButton2.Size = New System.Drawing.Size(217, 36)
        Me.MetroTextButton2.TabIndex = 10
        Me.MetroTextButton2.Text = "Cancel"
        Me.MetroTextButton2.UseSelectable = true
        Me.MetroTextButton2.UseVisualStyleBackColor = true
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = true
        Me.MetroLabel7.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel7.Location = New System.Drawing.Point(306, 116)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(47, 15)
        Me.MetroLabel7.TabIndex = 15
        Me.MetroLabel7.Text = "Branch :"
        '
        'cbBranch
        '
        Me.cbBranch.FormattingEnabled = true
        Me.cbBranch.ItemHeight = 23
        Me.cbBranch.Location = New System.Drawing.Point(306, 138)
        Me.cbBranch.Name = "cbBranch"
        Me.cbBranch.Size = New System.Drawing.Size(217, 29)
        Me.cbBranch.TabIndex = 7
        Me.cbBranch.UseSelectable = true
        '
        'btnSaveUpdate
        '
        Me.btnSaveUpdate.Enabled = false
        Me.btnSaveUpdate.Image = Nothing
        Me.btnSaveUpdate.Location = New System.Drawing.Point(24, 221)
        Me.btnSaveUpdate.Name = "btnSaveUpdate"
        Me.btnSaveUpdate.Size = New System.Drawing.Size(230, 36)
        Me.btnSaveUpdate.TabIndex = 9
        Me.btnSaveUpdate.Text = "Save"
        Me.btnSaveUpdate.UseSelectable = true
        Me.btnSaveUpdate.UseVisualStyleBackColor = true
        '
        'ep
        '
        Me.ep.ContainerControl = Me
        '
        'dgEmployee
        '
        Me.dgEmployee.AllowUserToAddRows = false
        Me.dgEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgEmployee.BackgroundColor = System.Drawing.Color.White
        Me.dgEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEmployee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgEmployee.Location = New System.Drawing.Point(0, 291)
        Me.dgEmployee.Name = "dgEmployee"
        Me.dgEmployee.Size = New System.Drawing.Size(773, 158)
        Me.dgEmployee.TabIndex = 15
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblRersult)
        Me.Panel1.Controls.Add(Me.MetroLabel8)
        Me.Panel1.Controls.Add(Me.txtFilter)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 449)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(773, 27)
        Me.Panel1.TabIndex = 16
        '
        'lblRersult
        '
        Me.lblRersult.AutoSize = true
        Me.lblRersult.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblRersult.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblRersult.Location = New System.Drawing.Point(3, 6)
        Me.lblRersult.Name = "lblRersult"
        Me.lblRersult.Size = New System.Drawing.Size(45, 15)
        Me.lblRersult.Style = MetroFramework.MetroColorStyle.Blue
        Me.lblRersult.TabIndex = 19
        Me.lblRersult.Text = "Result :"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = true
        Me.MetroLabel8.Dock = System.Windows.Forms.DockStyle.Right
        Me.MetroLabel8.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel8.Location = New System.Drawing.Point(430, 0)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(51, 15)
        Me.MetroLabel8.TabIndex = 18
        Me.MetroLabel8.Text = "Search :"
        '
        'txtFilter
        '
        '
        '
        '
        Me.txtFilter.CustomButton.Image = Nothing
        Me.txtFilter.CustomButton.Location = New System.Drawing.Point(266, 1)
        Me.txtFilter.CustomButton.Name = ""
        Me.txtFilter.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtFilter.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtFilter.CustomButton.TabIndex = 1
        Me.txtFilter.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtFilter.CustomButton.UseSelectable = true
        Me.txtFilter.CustomButton.Visible = false
        Me.txtFilter.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtFilter.Lines = New String(-1) {}
        Me.txtFilter.Location = New System.Drawing.Point(481, 0)
        Me.txtFilter.MaxLength = 32767
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFilter.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFilter.SelectedText = ""
        Me.txtFilter.SelectionLength = 0
        Me.txtFilter.SelectionStart = 0
        Me.txtFilter.Size = New System.Drawing.Size(292, 27)
        Me.txtFilter.Style = MetroFramework.MetroColorStyle.Brown
        Me.txtFilter.TabIndex = 18
        Me.txtFilter.UseSelectable = true
        Me.txtFilter.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtFilter.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'frmEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(773, 476)
        Me.Controls.Add(Me.dgEmployee)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmEmployee"
        Me.Text = "Employee"
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox2.PerformLayout
        CType(Me.ep,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.dgEmployee,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents dtBirthdate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbBranch As MetroFramework.Controls.MetroComboBox
    Friend WithEvents ep As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnSaveUpdate As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents MetroTextButton2 As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents dgEmployee As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MetroTextButton1 As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Private WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Private WithEvents txtEmpid As MetroFramework.Controls.MetroTextBox
    Private WithEvents txtFname As MetroFramework.Controls.MetroTextBox
    Private WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Private WithEvents txtLname As MetroFramework.Controls.MetroTextBox
    Private WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Private WithEvents txtMname As MetroFramework.Controls.MetroTextBox
    Private WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Private WithEvents txtMObile As MetroFramework.Controls.MetroTextBox
    Private WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Private WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Private WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Private WithEvents txtFilter As MetroFramework.Controls.MetroTextBox
    Private WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Private WithEvents cbStatus As MetroFramework.Controls.MetroCheckBox
    Private WithEvents cbManager As MetroFramework.Controls.MetroCheckBox
    Private WithEvents lblRersult As MetroFramework.Controls.MetroLabel
    Private WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Private WithEvents txtPOsition As MetroFramework.Controls.MetroTextBox
End Class
