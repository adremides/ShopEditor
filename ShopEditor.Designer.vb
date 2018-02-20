<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShopEditor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ShopEditor))
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.newToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.openToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.saveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.label_FileName = New System.Windows.Forms.Label()
        Me.checkBox_FO = New System.Windows.Forms.CheckBox()
        Me.button_Update = New System.Windows.Forms.Button()
        Me.label_Size = New System.Windows.Forms.Label()
        Me.grpExcOpt = New System.Windows.Forms.GroupBox()
        Me.radioButton_ExcWings = New System.Windows.Forms.RadioButton()
        Me.radioButton_ExcArmor = New System.Windows.Forms.RadioButton()
        Me.radioButton_ExcWeapon = New System.Windows.Forms.RadioButton()
        Me.checkBox_ExcOpt6 = New System.Windows.Forms.CheckBox()
        Me.checkBox_ExcOpt5 = New System.Windows.Forms.CheckBox()
        Me.checkBox_ExcOpt4 = New System.Windows.Forms.CheckBox()
        Me.checkBox_ExcOpt3 = New System.Windows.Forms.CheckBox()
        Me.checkBox_ExcOpt2 = New System.Windows.Forms.CheckBox()
        Me.checkBox_ExcOpt1 = New System.Windows.Forms.CheckBox()
        Me.button_Add = New System.Windows.Forms.Button()
        Me.pictureBox_ItemPreview = New System.Windows.Forms.PictureBox()
        Me.grpAncientOptions = New System.Windows.Forms.GroupBox()
        Me.cmbAncientLevel = New System.Windows.Forms.ComboBox()
        Me.cmbAncientName = New System.Windows.Forms.ComboBox()
        Me.checkBox_Skill = New System.Windows.Forms.CheckBox()
        Me.checkBox_Luck = New System.Windows.Forms.CheckBox()
        Me.grpItemDurability = New System.Windows.Forms.GroupBox()
        Me.checkBox_DurLock = New System.Windows.Forms.CheckBox()
        Me.numericUpDown_Durability = New System.Windows.Forms.NumericUpDown()
        Me.grpItemOption = New System.Windows.Forms.GroupBox()
        Me.listBox_Option = New System.Windows.Forms.ListBox()
        Me.grpItemLevel = New System.Windows.Forms.GroupBox()
        Me.listBox_Level = New System.Windows.Forms.ListBox()
        Me.listBox_Index = New System.Windows.Forms.ListBox()
        Me.listBox_Group = New System.Windows.Forms.ListBox()
        Me.pictureBox_Init_1x1 = New System.Windows.Forms.PictureBox()
        Me.pictureBox_ShopPreview = New System.Windows.Forms.PictureBox()
        Me.grpSocket = New System.Windows.Forms.GroupBox()
        Me.ListBox_Socket = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListBox_Element = New System.Windows.Forms.ListBox()
        Me.CheckBox_Serial = New System.Windows.Forms.CheckBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.searchBox = New System.Windows.Forms.ComboBox()
        Me.btnSearchFilter = New System.Windows.Forms.Button()
        Me.mnuMain.SuspendLayout()
        Me.grpExcOpt.SuspendLayout()
        CType(Me.pictureBox_ItemPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAncientOptions.SuspendLayout()
        Me.grpItemDurability.SuspendLayout()
        CType(Me.numericUpDown_Durability, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpItemOption.SuspendLayout()
        Me.grpItemLevel.SuspendLayout()
        CType(Me.pictureBox_Init_1x1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox_ShopPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSocket.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileToolStripMenuItem})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(652, 24)
        Me.mnuMain.TabIndex = 14
        Me.mnuMain.Text = "menuStrip1"
        '
        'fileToolStripMenuItem
        '
        Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newToolStripMenuItem, Me.openToolStripMenuItem, Me.saveAsToolStripMenuItem})
        Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
        Me.fileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.fileToolStripMenuItem.Text = "File"
        '
        'newToolStripMenuItem
        '
        Me.newToolStripMenuItem.Name = "newToolStripMenuItem"
        Me.newToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.newToolStripMenuItem.Text = "New"
        '
        'openToolStripMenuItem
        '
        Me.openToolStripMenuItem.Name = "openToolStripMenuItem"
        Me.openToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.openToolStripMenuItem.Text = "Open"
        '
        'saveAsToolStripMenuItem
        '
        Me.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem"
        Me.saveAsToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.saveAsToolStripMenuItem.Text = "Save As"
        '
        'label_FileName
        '
        Me.label_FileName.BackColor = System.Drawing.Color.Black
        Me.label_FileName.ForeColor = System.Drawing.Color.White
        Me.label_FileName.Location = New System.Drawing.Point(412, 32)
        Me.label_FileName.Name = "label_FileName"
        Me.label_FileName.Size = New System.Drawing.Size(208, 15)
        Me.label_FileName.TabIndex = 40
        Me.label_FileName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'checkBox_FO
        '
        Me.checkBox_FO.AutoSize = True
        Me.checkBox_FO.Location = New System.Drawing.Point(133, 253)
        Me.checkBox_FO.Name = "checkBox_FO"
        Me.checkBox_FO.Size = New System.Drawing.Size(92, 30)
        Me.checkBox_FO.TabIndex = 9
        Me.checkBox_FO.Text = "FO " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "+15+28+Luck"
        Me.checkBox_FO.UseVisualStyleBackColor = True
        '
        'button_Update
        '
        Me.button_Update.Enabled = False
        Me.button_Update.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.button_Update.Location = New System.Drawing.Point(12, 426)
        Me.button_Update.Name = "button_Update"
        Me.button_Update.Size = New System.Drawing.Size(78, 30)
        Me.button_Update.TabIndex = 24
        Me.button_Update.Text = "Update Item"
        Me.button_Update.UseVisualStyleBackColor = True
        '
        'label_Size
        '
        Me.label_Size.AutoSize = True
        Me.label_Size.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.label_Size.Location = New System.Drawing.Point(363, 253)
        Me.label_Size.Name = "label_Size"
        Me.label_Size.Size = New System.Drawing.Size(26, 15)
        Me.label_Size.TabIndex = 37
        Me.label_Size.Text = "1x1"
        '
        'grpExcOpt
        '
        Me.grpExcOpt.BackColor = System.Drawing.Color.Transparent
        Me.grpExcOpt.Controls.Add(Me.radioButton_ExcWings)
        Me.grpExcOpt.Controls.Add(Me.radioButton_ExcArmor)
        Me.grpExcOpt.Controls.Add(Me.radioButton_ExcWeapon)
        Me.grpExcOpt.Controls.Add(Me.checkBox_ExcOpt6)
        Me.grpExcOpt.Controls.Add(Me.checkBox_ExcOpt5)
        Me.grpExcOpt.Controls.Add(Me.checkBox_ExcOpt4)
        Me.grpExcOpt.Controls.Add(Me.checkBox_ExcOpt3)
        Me.grpExcOpt.Controls.Add(Me.checkBox_ExcOpt2)
        Me.grpExcOpt.Controls.Add(Me.checkBox_ExcOpt1)
        Me.grpExcOpt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.grpExcOpt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grpExcOpt.Location = New System.Drawing.Point(185, 289)
        Me.grpExcOpt.Name = "grpExcOpt"
        Me.grpExcOpt.Size = New System.Drawing.Size(204, 167)
        Me.grpExcOpt.TabIndex = 13
        Me.grpExcOpt.TabStop = False
        Me.grpExcOpt.Text = "Excellent Options"
        '
        'radioButton_ExcWings
        '
        Me.radioButton_ExcWings.AutoSize = True
        Me.radioButton_ExcWings.Location = New System.Drawing.Point(136, 18)
        Me.radioButton_ExcWings.Name = "radioButton_ExcWings"
        Me.radioButton_ExcWings.Size = New System.Drawing.Size(55, 17)
        Me.radioButton_ExcWings.TabIndex = 15
        Me.radioButton_ExcWings.Text = "Wings"
        Me.radioButton_ExcWings.UseVisualStyleBackColor = True
        '
        'radioButton_ExcArmor
        '
        Me.radioButton_ExcArmor.AutoSize = True
        Me.radioButton_ExcArmor.Location = New System.Drawing.Point(78, 18)
        Me.radioButton_ExcArmor.Name = "radioButton_ExcArmor"
        Me.radioButton_ExcArmor.Size = New System.Drawing.Size(52, 17)
        Me.radioButton_ExcArmor.TabIndex = 14
        Me.radioButton_ExcArmor.Text = "Armor"
        Me.radioButton_ExcArmor.UseVisualStyleBackColor = True
        '
        'radioButton_ExcWeapon
        '
        Me.radioButton_ExcWeapon.AutoSize = True
        Me.radioButton_ExcWeapon.Location = New System.Drawing.Point(6, 18)
        Me.radioButton_ExcWeapon.Name = "radioButton_ExcWeapon"
        Me.radioButton_ExcWeapon.Size = New System.Drawing.Size(66, 17)
        Me.radioButton_ExcWeapon.TabIndex = 13
        Me.radioButton_ExcWeapon.Text = "Weapon"
        Me.radioButton_ExcWeapon.UseVisualStyleBackColor = True
        '
        'checkBox_ExcOpt6
        '
        Me.checkBox_ExcOpt6.AutoSize = True
        Me.checkBox_ExcOpt6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.checkBox_ExcOpt6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.checkBox_ExcOpt6.Location = New System.Drawing.Point(6, 133)
        Me.checkBox_ExcOpt6.Name = "checkBox_ExcOpt6"
        Me.checkBox_ExcOpt6.Size = New System.Drawing.Size(80, 17)
        Me.checkBox_ExcOpt6.TabIndex = 21
        Me.checkBox_ExcOpt6.Text = "checkBox6"
        Me.checkBox_ExcOpt6.UseVisualStyleBackColor = True
        '
        'checkBox_ExcOpt5
        '
        Me.checkBox_ExcOpt5.AutoSize = True
        Me.checkBox_ExcOpt5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.checkBox_ExcOpt5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.checkBox_ExcOpt5.Location = New System.Drawing.Point(6, 115)
        Me.checkBox_ExcOpt5.Name = "checkBox_ExcOpt5"
        Me.checkBox_ExcOpt5.Size = New System.Drawing.Size(80, 17)
        Me.checkBox_ExcOpt5.TabIndex = 20
        Me.checkBox_ExcOpt5.Text = "checkBox5"
        Me.checkBox_ExcOpt5.UseVisualStyleBackColor = True
        '
        'checkBox_ExcOpt4
        '
        Me.checkBox_ExcOpt4.AutoSize = True
        Me.checkBox_ExcOpt4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.checkBox_ExcOpt4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.checkBox_ExcOpt4.Location = New System.Drawing.Point(6, 97)
        Me.checkBox_ExcOpt4.Name = "checkBox_ExcOpt4"
        Me.checkBox_ExcOpt4.Size = New System.Drawing.Size(80, 17)
        Me.checkBox_ExcOpt4.TabIndex = 19
        Me.checkBox_ExcOpt4.Text = "checkBox4"
        Me.checkBox_ExcOpt4.UseVisualStyleBackColor = True
        '
        'checkBox_ExcOpt3
        '
        Me.checkBox_ExcOpt3.AutoSize = True
        Me.checkBox_ExcOpt3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.checkBox_ExcOpt3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.checkBox_ExcOpt3.Location = New System.Drawing.Point(6, 78)
        Me.checkBox_ExcOpt3.Name = "checkBox_ExcOpt3"
        Me.checkBox_ExcOpt3.Size = New System.Drawing.Size(80, 17)
        Me.checkBox_ExcOpt3.TabIndex = 18
        Me.checkBox_ExcOpt3.Text = "checkBox3"
        Me.checkBox_ExcOpt3.UseVisualStyleBackColor = True
        '
        'checkBox_ExcOpt2
        '
        Me.checkBox_ExcOpt2.AutoSize = True
        Me.checkBox_ExcOpt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.checkBox_ExcOpt2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.checkBox_ExcOpt2.Location = New System.Drawing.Point(6, 60)
        Me.checkBox_ExcOpt2.Name = "checkBox_ExcOpt2"
        Me.checkBox_ExcOpt2.Size = New System.Drawing.Size(80, 17)
        Me.checkBox_ExcOpt2.TabIndex = 17
        Me.checkBox_ExcOpt2.Text = "checkBox2"
        Me.checkBox_ExcOpt2.UseVisualStyleBackColor = True
        '
        'checkBox_ExcOpt1
        '
        Me.checkBox_ExcOpt1.AutoSize = True
        Me.checkBox_ExcOpt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.checkBox_ExcOpt1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.checkBox_ExcOpt1.Location = New System.Drawing.Point(6, 42)
        Me.checkBox_ExcOpt1.Name = "checkBox_ExcOpt1"
        Me.checkBox_ExcOpt1.Size = New System.Drawing.Size(80, 17)
        Me.checkBox_ExcOpt1.TabIndex = 16
        Me.checkBox_ExcOpt1.Text = "checkBox1"
        Me.checkBox_ExcOpt1.UseVisualStyleBackColor = True
        '
        'button_Add
        '
        Me.button_Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.button_Add.Location = New System.Drawing.Point(96, 426)
        Me.button_Add.Name = "button_Add"
        Me.button_Add.Size = New System.Drawing.Size(83, 30)
        Me.button_Add.TabIndex = 25
        Me.button_Add.Text = "Add Item"
        Me.button_Add.UseVisualStyleBackColor = True
        '
        'pictureBox_ItemPreview
        '
        Me.pictureBox_ItemPreview.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.pictureBox_ItemPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pictureBox_ItemPreview.Location = New System.Drawing.Point(269, 173)
        Me.pictureBox_ItemPreview.Name = "pictureBox_ItemPreview"
        Me.pictureBox_ItemPreview.Size = New System.Drawing.Size(120, 94)
        Me.pictureBox_ItemPreview.TabIndex = 35
        Me.pictureBox_ItemPreview.TabStop = False
        '
        'grpAncientOptions
        '
        Me.grpAncientOptions.Controls.Add(Me.cmbAncientLevel)
        Me.grpAncientOptions.Controls.Add(Me.cmbAncientName)
        Me.grpAncientOptions.Location = New System.Drawing.Point(133, 173)
        Me.grpAncientOptions.Name = "grpAncientOptions"
        Me.grpAncientOptions.Size = New System.Drawing.Size(130, 51)
        Me.grpAncientOptions.TabIndex = 5
        Me.grpAncientOptions.TabStop = False
        Me.grpAncientOptions.Text = "Anceint Option"
        '
        'cmbAncientLevel
        '
        Me.cmbAncientLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAncientLevel.FormattingEnabled = True
        Me.cmbAncientLevel.Location = New System.Drawing.Point(79, 19)
        Me.cmbAncientLevel.Name = "cmbAncientLevel"
        Me.cmbAncientLevel.Size = New System.Drawing.Size(44, 21)
        Me.cmbAncientLevel.TabIndex = 6
        '
        'cmbAncientName
        '
        Me.cmbAncientName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAncientName.FormattingEnabled = True
        Me.cmbAncientName.Location = New System.Drawing.Point(6, 19)
        Me.cmbAncientName.Name = "cmbAncientName"
        Me.cmbAncientName.Size = New System.Drawing.Size(67, 21)
        Me.cmbAncientName.TabIndex = 5
        '
        'checkBox_Skill
        '
        Me.checkBox_Skill.AutoSize = True
        Me.checkBox_Skill.Location = New System.Drawing.Point(189, 230)
        Me.checkBox_Skill.Name = "checkBox_Skill"
        Me.checkBox_Skill.Size = New System.Drawing.Size(45, 17)
        Me.checkBox_Skill.TabIndex = 8
        Me.checkBox_Skill.Text = "Skill"
        Me.checkBox_Skill.UseVisualStyleBackColor = True
        '
        'checkBox_Luck
        '
        Me.checkBox_Luck.AutoSize = True
        Me.checkBox_Luck.Location = New System.Drawing.Point(133, 230)
        Me.checkBox_Luck.Name = "checkBox_Luck"
        Me.checkBox_Luck.Size = New System.Drawing.Size(50, 17)
        Me.checkBox_Luck.TabIndex = 7
        Me.checkBox_Luck.Text = "Luck"
        Me.checkBox_Luck.UseVisualStyleBackColor = True
        '
        'grpItemDurability
        '
        Me.grpItemDurability.Controls.Add(Me.checkBox_DurLock)
        Me.grpItemDurability.Controls.Add(Me.numericUpDown_Durability)
        Me.grpItemDurability.Location = New System.Drawing.Point(12, 378)
        Me.grpItemDurability.Name = "grpItemDurability"
        Me.grpItemDurability.Size = New System.Drawing.Size(106, 42)
        Me.grpItemDurability.TabIndex = 22
        Me.grpItemDurability.TabStop = False
        Me.grpItemDurability.Text = "Durability"
        '
        'checkBox_DurLock
        '
        Me.checkBox_DurLock.AutoSize = True
        Me.checkBox_DurLock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.checkBox_DurLock.Location = New System.Drawing.Point(54, 19)
        Me.checkBox_DurLock.Name = "checkBox_DurLock"
        Me.checkBox_DurLock.Size = New System.Drawing.Size(50, 17)
        Me.checkBox_DurLock.TabIndex = 23
        Me.checkBox_DurLock.Text = "Lock"
        Me.checkBox_DurLock.UseVisualStyleBackColor = True
        '
        'numericUpDown_Durability
        '
        Me.numericUpDown_Durability.Location = New System.Drawing.Point(6, 18)
        Me.numericUpDown_Durability.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.numericUpDown_Durability.Name = "numericUpDown_Durability"
        Me.numericUpDown_Durability.Size = New System.Drawing.Size(44, 20)
        Me.numericUpDown_Durability.TabIndex = 22
        '
        'grpItemOption
        '
        Me.grpItemOption.Controls.Add(Me.listBox_Option)
        Me.grpItemOption.Location = New System.Drawing.Point(73, 173)
        Me.grpItemOption.Name = "grpItemOption"
        Me.grpItemOption.Size = New System.Drawing.Size(54, 120)
        Me.grpItemOption.TabIndex = 4
        Me.grpItemOption.TabStop = False
        Me.grpItemOption.Text = "Option"
        '
        'listBox_Option
        '
        Me.listBox_Option.FormattingEnabled = True
        Me.listBox_Option.Location = New System.Drawing.Point(5, 14)
        Me.listBox_Option.Name = "listBox_Option"
        Me.listBox_Option.Size = New System.Drawing.Size(44, 95)
        Me.listBox_Option.TabIndex = 4
        '
        'grpItemLevel
        '
        Me.grpItemLevel.Controls.Add(Me.listBox_Level)
        Me.grpItemLevel.Location = New System.Drawing.Point(12, 173)
        Me.grpItemLevel.Name = "grpItemLevel"
        Me.grpItemLevel.Size = New System.Drawing.Size(55, 120)
        Me.grpItemLevel.TabIndex = 3
        Me.grpItemLevel.TabStop = False
        Me.grpItemLevel.Text = "Level"
        '
        'listBox_Level
        '
        Me.listBox_Level.FormattingEnabled = True
        Me.listBox_Level.Location = New System.Drawing.Point(7, 14)
        Me.listBox_Level.Name = "listBox_Level"
        Me.listBox_Level.Size = New System.Drawing.Size(41, 95)
        Me.listBox_Level.TabIndex = 3
        '
        'listBox_Index
        '
        Me.listBox_Index.FormattingEnabled = True
        Me.listBox_Index.Location = New System.Drawing.Point(176, 57)
        Me.listBox_Index.Name = "listBox_Index"
        Me.listBox_Index.Size = New System.Drawing.Size(213, 108)
        Me.listBox_Index.TabIndex = 2
        '
        'listBox_Group
        '
        Me.listBox_Group.FormattingEnabled = True
        Me.listBox_Group.Location = New System.Drawing.Point(12, 57)
        Me.listBox_Group.Name = "listBox_Group"
        Me.listBox_Group.Size = New System.Drawing.Size(158, 108)
        Me.listBox_Group.TabIndex = 1
        '
        'pictureBox_Init_1x1
        '
        Me.pictureBox_Init_1x1.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox_Init_1x1.BackgroundImage = Global.My.Resources.Resources.Untitled_3
        Me.pictureBox_Init_1x1.Enabled = False
        Me.pictureBox_Init_1x1.Location = New System.Drawing.Point(412, 49)
        Me.pictureBox_Init_1x1.Name = "pictureBox_Init_1x1"
        Me.pictureBox_Init_1x1.Size = New System.Drawing.Size(27, 25)
        Me.pictureBox_Init_1x1.TabIndex = 27
        Me.pictureBox_Init_1x1.TabStop = False
        Me.pictureBox_Init_1x1.Visible = False
        '
        'pictureBox_ShopPreview
        '
        Me.pictureBox_ShopPreview.BackgroundImage = Global.My.Resources.Resources.Untitled_2
        Me.pictureBox_ShopPreview.ErrorImage = Nothing
        Me.pictureBox_ShopPreview.Image = Global.My.Resources.Resources.Untitled_21
        Me.pictureBox_ShopPreview.Location = New System.Drawing.Point(395, 31)
        Me.pictureBox_ShopPreview.Name = "pictureBox_ShopPreview"
        Me.pictureBox_ShopPreview.Size = New System.Drawing.Size(244, 425)
        Me.pictureBox_ShopPreview.TabIndex = 24
        Me.pictureBox_ShopPreview.TabStop = False
        Me.pictureBox_ShopPreview.Visible = False
        '
        'grpSocket
        '
        Me.grpSocket.Controls.Add(Me.ListBox_Socket)
        Me.grpSocket.Location = New System.Drawing.Point(12, 299)
        Me.grpSocket.Name = "grpSocket"
        Me.grpSocket.Size = New System.Drawing.Size(55, 80)
        Me.grpSocket.TabIndex = 11
        Me.grpSocket.TabStop = False
        Me.grpSocket.Text = "Socket"
        '
        'ListBox_Socket
        '
        Me.ListBox_Socket.FormattingEnabled = True
        Me.ListBox_Socket.Location = New System.Drawing.Point(7, 14)
        Me.ListBox_Socket.Name = "ListBox_Socket"
        Me.ListBox_Socket.Size = New System.Drawing.Size(41, 56)
        Me.ListBox_Socket.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListBox_Element)
        Me.GroupBox1.Location = New System.Drawing.Point(72, 299)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(107, 80)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Element"
        '
        'ListBox_Element
        '
        Me.ListBox_Element.FormattingEnabled = True
        Me.ListBox_Element.Location = New System.Drawing.Point(7, 14)
        Me.ListBox_Element.Name = "ListBox_Element"
        Me.ListBox_Element.Size = New System.Drawing.Size(91, 56)
        Me.ListBox_Element.TabIndex = 12
        '
        'CheckBox_Serial
        '
        Me.CheckBox_Serial.AutoSize = True
        Me.CheckBox_Serial.Location = New System.Drawing.Point(133, 287)
        Me.CheckBox_Serial.Name = "CheckBox_Serial"
        Me.CheckBox_Serial.Size = New System.Drawing.Size(52, 17)
        Me.CheckBox_Serial.TabIndex = 10
        Me.CheckBox_Serial.Text = "Serial"
        Me.CheckBox_Serial.UseVisualStyleBackColor = True
        '
        'searchBox
        '
        Me.searchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.searchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.searchBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.searchBox.FormattingEnabled = True
        Me.searchBox.Location = New System.Drawing.Point(12, 32)
        Me.searchBox.Name = "searchBox"
        Me.searchBox.Size = New System.Drawing.Size(268, 21)
        Me.searchBox.TabIndex = 42
        '
        'btnSearchFilter
        '
        Me.btnSearchFilter.Location = New System.Drawing.Point(286, 31)
        Me.btnSearchFilter.Name = "btnSearchFilter"
        Me.btnSearchFilter.Size = New System.Drawing.Size(103, 23)
        Me.btnSearchFilter.TabIndex = 43
        Me.btnSearchFilter.Text = "Advanced Filter"
        Me.btnSearchFilter.UseVisualStyleBackColor = True
        '
        'ShopEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 468)
        Me.Controls.Add(Me.btnSearchFilter)
        Me.Controls.Add(Me.searchBox)
        Me.Controls.Add(Me.label_FileName)
        Me.Controls.Add(Me.checkBox_FO)
        Me.Controls.Add(Me.button_Update)
        Me.Controls.Add(Me.label_Size)
        Me.Controls.Add(Me.grpExcOpt)
        Me.Controls.Add(Me.button_Add)
        Me.Controls.Add(Me.pictureBox_ItemPreview)
        Me.Controls.Add(Me.grpAncientOptions)
        Me.Controls.Add(Me.checkBox_Skill)
        Me.Controls.Add(Me.CheckBox_Serial)
        Me.Controls.Add(Me.checkBox_Luck)
        Me.Controls.Add(Me.grpItemDurability)
        Me.Controls.Add(Me.grpItemOption)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpSocket)
        Me.Controls.Add(Me.grpItemLevel)
        Me.Controls.Add(Me.listBox_Index)
        Me.Controls.Add(Me.listBox_Group)
        Me.Controls.Add(Me.pictureBox_Init_1x1)
        Me.Controls.Add(Me.pictureBox_ShopPreview)
        Me.Controls.Add(Me.mnuMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ShopEditor"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MuOnline S9E3 Shop Editor"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.grpExcOpt.ResumeLayout(False)
        Me.grpExcOpt.PerformLayout()
        CType(Me.pictureBox_ItemPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAncientOptions.ResumeLayout(False)
        Me.grpItemDurability.ResumeLayout(False)
        Me.grpItemDurability.PerformLayout()
        CType(Me.numericUpDown_Durability, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpItemOption.ResumeLayout(False)
        Me.grpItemLevel.ResumeLayout(False)
        CType(Me.pictureBox_Init_1x1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox_ShopPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSocket.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents mnuMain As System.Windows.Forms.MenuStrip
    Private WithEvents fileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents newToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents openToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents saveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents label_FileName As System.Windows.Forms.Label
    Private WithEvents checkBox_FO As System.Windows.Forms.CheckBox
    Private WithEvents button_Update As System.Windows.Forms.Button
    Private WithEvents label_Size As System.Windows.Forms.Label
    Private WithEvents grpExcOpt As System.Windows.Forms.GroupBox
    Private WithEvents radioButton_ExcWings As System.Windows.Forms.RadioButton
    Private WithEvents radioButton_ExcArmor As System.Windows.Forms.RadioButton
    Private WithEvents radioButton_ExcWeapon As System.Windows.Forms.RadioButton
    Public WithEvents checkBox_ExcOpt6 As System.Windows.Forms.CheckBox
    Public WithEvents checkBox_ExcOpt5 As System.Windows.Forms.CheckBox
    Public WithEvents checkBox_ExcOpt4 As System.Windows.Forms.CheckBox
    Public WithEvents checkBox_ExcOpt3 As System.Windows.Forms.CheckBox
    Public WithEvents checkBox_ExcOpt2 As System.Windows.Forms.CheckBox
    Public WithEvents checkBox_ExcOpt1 As System.Windows.Forms.CheckBox
    Private WithEvents button_Add As System.Windows.Forms.Button
    Private WithEvents pictureBox_ItemPreview As System.Windows.Forms.PictureBox
    Private WithEvents grpAncientOptions As System.Windows.Forms.GroupBox
    Private WithEvents checkBox_Skill As System.Windows.Forms.CheckBox
    Private WithEvents checkBox_Luck As System.Windows.Forms.CheckBox
    Private WithEvents grpItemDurability As System.Windows.Forms.GroupBox
    Private WithEvents checkBox_DurLock As System.Windows.Forms.CheckBox
    Private WithEvents numericUpDown_Durability As System.Windows.Forms.NumericUpDown
    Private WithEvents grpItemOption As System.Windows.Forms.GroupBox
    Private WithEvents listBox_Option As System.Windows.Forms.ListBox
    Private WithEvents grpItemLevel As System.Windows.Forms.GroupBox
    Private WithEvents listBox_Level As System.Windows.Forms.ListBox
    Private WithEvents listBox_Index As System.Windows.Forms.ListBox
    Private WithEvents listBox_Group As System.Windows.Forms.ListBox
    Private WithEvents pictureBox_Init_1x1 As System.Windows.Forms.PictureBox
    Private WithEvents pictureBox_ShopPreview As System.Windows.Forms.PictureBox
    Friend WithEvents cmbAncientLevel As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAncientName As System.Windows.Forms.ComboBox
    Private WithEvents grpSocket As System.Windows.Forms.GroupBox
    Private WithEvents ListBox_Socket As System.Windows.Forms.ListBox
    Private WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents ListBox_Element As System.Windows.Forms.ListBox
    Private WithEvents CheckBox_Serial As System.Windows.Forms.CheckBox
    Friend WithEvents BindingSource1 As Windows.Forms.BindingSource
    Friend WithEvents searchBox As Windows.Forms.ComboBox
    Friend WithEvents btnSearchFilter As Windows.Forms.Button
End Class
