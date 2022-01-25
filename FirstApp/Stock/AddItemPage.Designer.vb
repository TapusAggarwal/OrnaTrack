<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddItemPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TotalInstalmentsLabel = New System.Windows.Forms.Label()
        Me.ItemNameTB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AttrNameTB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OptionalChB = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DefaultValueTB = New System.Windows.Forms.TextBox()
        Me.AttrTypeCB = New System.Windows.Forms.ComboBox()
        Me.ConstantChB = New System.Windows.Forms.CheckBox()
        Me.CurrencyChB = New System.Windows.Forms.CheckBox()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.TrueChB = New System.Windows.Forms.CheckBox()
        Me.FalseChB = New System.Windows.Forms.CheckBox()
        Me.ListValues = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FormulaTB = New ProBaseAdvancedTextBox.ProBaseAdvancedTextBox.RichTextBoxPrintCtrl()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FormulaNameLB = New System.Windows.Forms.Label()
        Me.FormulaNameTB = New System.Windows.Forms.TextBox()
        Me.UseBT = New FontAwesome.Sharp.IconButton()
        Me.AddParametersBT = New FontAwesome.Sharp.IconButton()
        Me.IconButton7 = New FontAwesome.Sharp.IconButton()
        Me.AddAttributeButton = New FontAwesome.Sharp.IconButton()
        Me.FormulaBT = New FontAwesome.Sharp.Material.MaterialButton()
        Me.EditListBT = New FontAwesome.Sharp.IconButton()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'TotalInstalmentsLabel
        '
        Me.TotalInstalmentsLabel.AutoSize = True
        Me.TotalInstalmentsLabel.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalInstalmentsLabel.ForeColor = System.Drawing.Color.Peru
        Me.TotalInstalmentsLabel.Location = New System.Drawing.Point(504, 11)
        Me.TotalInstalmentsLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TotalInstalmentsLabel.Name = "TotalInstalmentsLabel"
        Me.TotalInstalmentsLabel.Size = New System.Drawing.Size(158, 30)
        Me.TotalInstalmentsLabel.TabIndex = 249
        Me.TotalInstalmentsLabel.Text = "Item-Name:"
        '
        'ItemNameTB
        '
        Me.ItemNameTB.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemNameTB.Location = New System.Drawing.Point(670, 9)
        Me.ItemNameTB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ItemNameTB.Name = "ItemNameTB"
        Me.ItemNameTB.Size = New System.Drawing.Size(168, 36)
        Me.ItemNameTB.TabIndex = 248
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Peru
        Me.Label1.Location = New System.Drawing.Point(370, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 30)
        Me.Label1.TabIndex = 250
        Me.Label1.Text = "#1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Peru
        Me.Label2.Location = New System.Drawing.Point(372, 120)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 30)
        Me.Label2.TabIndex = 252
        Me.Label2.Text = "Attr.-Name:"
        '
        'AttrNameTB
        '
        Me.AttrNameTB.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AttrNameTB.Location = New System.Drawing.Point(545, 118)
        Me.AttrNameTB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AttrNameTB.Name = "AttrNameTB"
        Me.AttrNameTB.Size = New System.Drawing.Size(293, 36)
        Me.AttrNameTB.TabIndex = 251
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Peru
        Me.Label3.Location = New System.Drawing.Point(382, 169)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 30)
        Me.Label3.TabIndex = 254
        Me.Label3.Text = "Attr.-Type:"
        '
        'OptionalChB
        '
        Me.OptionalChB.AutoSize = True
        Me.OptionalChB.BackColor = System.Drawing.Color.Transparent
        Me.OptionalChB.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptionalChB.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.OptionalChB.Location = New System.Drawing.Point(705, 264)
        Me.OptionalChB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OptionalChB.Name = "OptionalChB"
        Me.OptionalChB.Size = New System.Drawing.Size(143, 34)
        Me.OptionalChB.TabIndex = 279
        Me.OptionalChB.TabStop = False
        Me.OptionalChB.Text = "Optional"
        Me.OptionalChB.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Peru
        Me.Label4.Location = New System.Drawing.Point(339, 220)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(190, 30)
        Me.Label4.TabIndex = 282
        Me.Label4.Text = "Default Value:"
        '
        'DefaultValueTB
        '
        Me.DefaultValueTB.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DefaultValueTB.Location = New System.Drawing.Point(545, 217)
        Me.DefaultValueTB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DefaultValueTB.Name = "DefaultValueTB"
        Me.DefaultValueTB.Size = New System.Drawing.Size(293, 36)
        Me.DefaultValueTB.TabIndex = 281
        '
        'AttrTypeCB
        '
        Me.AttrTypeCB.DropDownHeight = 200
        Me.AttrTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AttrTypeCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AttrTypeCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AttrTypeCB.FormattingEnabled = True
        Me.AttrTypeCB.IntegralHeight = False
        Me.AttrTypeCB.Items.AddRange(New Object() {"String", "Boolean", "List", "Integer"})
        Me.AttrTypeCB.Location = New System.Drawing.Point(545, 169)
        Me.AttrTypeCB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AttrTypeCB.MaxDropDownItems = 20
        Me.AttrTypeCB.Name = "AttrTypeCB"
        Me.AttrTypeCB.Size = New System.Drawing.Size(293, 34)
        Me.AttrTypeCB.TabIndex = 283
        Me.AttrTypeCB.Tag = ""
        '
        'ConstantChB
        '
        Me.ConstantChB.AutoSize = True
        Me.ConstantChB.BackColor = System.Drawing.Color.Transparent
        Me.ConstantChB.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConstantChB.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.ConstantChB.Location = New System.Drawing.Point(542, 264)
        Me.ConstantChB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ConstantChB.Name = "ConstantChB"
        Me.ConstantChB.Size = New System.Drawing.Size(147, 34)
        Me.ConstantChB.TabIndex = 284
        Me.ConstantChB.TabStop = False
        Me.ConstantChB.Text = "Constant"
        Me.ConstantChB.UseVisualStyleBackColor = False
        '
        'CurrencyChB
        '
        Me.CurrencyChB.AutoSize = True
        Me.CurrencyChB.BackColor = System.Drawing.Color.Transparent
        Me.CurrencyChB.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrencyChB.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.CurrencyChB.Location = New System.Drawing.Point(541, 312)
        Me.CurrencyChB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CurrencyChB.Name = "CurrencyChB"
        Me.CurrencyChB.Size = New System.Drawing.Size(148, 34)
        Me.CurrencyChB.TabIndex = 285
        Me.CurrencyChB.TabStop = False
        Me.CurrencyChB.Text = "Currency"
        Me.CurrencyChB.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(315, 685)
        Me.FlowLayoutPanel2.TabIndex = 286
        Me.FlowLayoutPanel2.WrapContents = False
        '
        'TrueChB
        '
        Me.TrueChB.AutoSize = True
        Me.TrueChB.BackColor = System.Drawing.Color.Transparent
        Me.TrueChB.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrueChB.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.TrueChB.Location = New System.Drawing.Point(568, 217)
        Me.TrueChB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TrueChB.Name = "TrueChB"
        Me.TrueChB.Size = New System.Drawing.Size(88, 34)
        Me.TrueChB.TabIndex = 289
        Me.TrueChB.TabStop = False
        Me.TrueChB.Text = "True"
        Me.TrueChB.UseVisualStyleBackColor = False
        Me.TrueChB.Visible = False
        '
        'FalseChB
        '
        Me.FalseChB.AutoSize = True
        Me.FalseChB.BackColor = System.Drawing.Color.Transparent
        Me.FalseChB.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FalseChB.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.FalseChB.Location = New System.Drawing.Point(664, 217)
        Me.FalseChB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FalseChB.Name = "FalseChB"
        Me.FalseChB.Size = New System.Drawing.Size(99, 34)
        Me.FalseChB.TabIndex = 288
        Me.FalseChB.TabStop = False
        Me.FalseChB.Text = "False"
        Me.FalseChB.UseVisualStyleBackColor = False
        Me.FalseChB.Visible = False
        '
        'ListValues
        '
        Me.ListValues.DropDownHeight = 200
        Me.ListValues.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ListValues.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ListValues.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListValues.FormattingEnabled = True
        Me.ListValues.IntegralHeight = False
        Me.ListValues.Location = New System.Drawing.Point(545, 219)
        Me.ListValues.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListValues.MaxDropDownItems = 20
        Me.ListValues.Name = "ListValues"
        Me.ListValues.Size = New System.Drawing.Size(293, 34)
        Me.ListValues.TabIndex = 290
        Me.ListValues.Tag = ""
        Me.ListValues.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Peru
        Me.Label5.Location = New System.Drawing.Point(760, 68)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 30)
        Me.Label5.TabIndex = 293
        Me.Label5.Text = "0"
        '
        'FormulaTB
        '
        Me.FormulaTB.AutoWordSelection = True
        Me.FormulaTB.BackColor = System.Drawing.Color.Lavender
        Me.FormulaTB.Font = New System.Drawing.Font("Century Schoolbook", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormulaTB.Location = New System.Drawing.Point(344, 509)
        Me.FormulaTB.Name = "FormulaTB"
        Me.FormulaTB.Size = New System.Drawing.Size(504, 84)
        Me.FormulaTB.TabIndex = 296
        Me.FormulaTB.Text = ""
        Me.FormulaTB.Visible = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(944, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(315, 685)
        Me.FlowLayoutPanel1.TabIndex = 297
        Me.FlowLayoutPanel1.WrapContents = False
        '
        'FormulaNameLB
        '
        Me.FormulaNameLB.AutoSize = True
        Me.FormulaNameLB.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormulaNameLB.ForeColor = System.Drawing.Color.Peru
        Me.FormulaNameLB.Location = New System.Drawing.Point(339, 462)
        Me.FormulaNameLB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FormulaNameLB.Name = "FormulaNameLB"
        Me.FormulaNameLB.Size = New System.Drawing.Size(206, 30)
        Me.FormulaNameLB.TabIndex = 301
        Me.FormulaNameLB.Text = "Formula-Name:"
        Me.FormulaNameLB.Visible = False
        '
        'FormulaNameTB
        '
        Me.FormulaNameTB.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormulaNameTB.Location = New System.Drawing.Point(553, 460)
        Me.FormulaNameTB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FormulaNameTB.Name = "FormulaNameTB"
        Me.FormulaNameTB.Size = New System.Drawing.Size(293, 36)
        Me.FormulaNameTB.TabIndex = 300
        Me.FormulaNameTB.Visible = False
        '
        'UseBT
        '
        Me.UseBT.AutoSize = True
        Me.UseBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UseBT.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.UseBT.FlatAppearance.BorderSize = 0
        Me.UseBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UseBT.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UseBT.ForeColor = System.Drawing.Color.MediumPurple
        Me.UseBT.IconChar = FontAwesome.Sharp.IconChar.SignInAlt
        Me.UseBT.IconColor = System.Drawing.Color.White
        Me.UseBT.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.UseBT.IconSize = 45
        Me.UseBT.Location = New System.Drawing.Point(813, 620)
        Me.UseBT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UseBT.Name = "UseBT"
        Me.UseBT.Size = New System.Drawing.Size(107, 51)
        Me.UseBT.TabIndex = 302
        Me.UseBT.Text = "Use"
        Me.UseBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.UseBT.UseVisualStyleBackColor = False
        Me.UseBT.Visible = False
        '
        'AddParametersBT
        '
        Me.AddParametersBT.AutoSize = True
        Me.AddParametersBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AddParametersBT.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.AddParametersBT.FlatAppearance.BorderSize = 0
        Me.AddParametersBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddParametersBT.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddParametersBT.ForeColor = System.Drawing.Color.MediumPurple
        Me.AddParametersBT.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.AddParametersBT.IconColor = System.Drawing.Color.White
        Me.AddParametersBT.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.AddParametersBT.IconSize = 45
        Me.AddParametersBT.Location = New System.Drawing.Point(344, 601)
        Me.AddParametersBT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AddParametersBT.Name = "AddParametersBT"
        Me.AddParametersBT.Size = New System.Drawing.Size(187, 51)
        Me.AddParametersBT.TabIndex = 295
        Me.AddParametersBT.Text = "Parameter"
        Me.AddParametersBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.AddParametersBT.UseVisualStyleBackColor = False
        Me.AddParametersBT.Visible = False
        '
        'IconButton7
        '
        Me.IconButton7.AutoSize = True
        Me.IconButton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.IconButton7.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.IconButton7.FlatAppearance.BorderSize = 0
        Me.IconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton7.ForeColor = System.Drawing.Color.MediumPurple
        Me.IconButton7.IconChar = FontAwesome.Sharp.IconChar.SignInAlt
        Me.IconButton7.IconColor = System.Drawing.Color.White
        Me.IconButton7.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton7.IconSize = 45
        Me.IconButton7.Location = New System.Drawing.Point(813, 385)
        Me.IconButton7.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IconButton7.Name = "IconButton7"
        Me.IconButton7.Size = New System.Drawing.Size(124, 51)
        Me.IconButton7.TabIndex = 287
        Me.IconButton7.Text = "Save"
        Me.IconButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton7.UseVisualStyleBackColor = False
        '
        'AddAttributeButton
        '
        Me.AddAttributeButton.AutoSize = True
        Me.AddAttributeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AddAttributeButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.AddAttributeButton.FlatAppearance.BorderSize = 0
        Me.AddAttributeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddAttributeButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddAttributeButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.AddAttributeButton.IconChar = FontAwesome.Sharp.IconChar.SignInAlt
        Me.AddAttributeButton.IconColor = System.Drawing.Color.White
        Me.AddAttributeButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.AddAttributeButton.IconSize = 45
        Me.AddAttributeButton.Location = New System.Drawing.Point(691, 303)
        Me.AddAttributeButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AddAttributeButton.Name = "AddAttributeButton"
        Me.AddAttributeButton.Size = New System.Drawing.Size(221, 51)
        Me.AddAttributeButton.TabIndex = 277
        Me.AddAttributeButton.Text = "Add Attribute"
        Me.AddAttributeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.AddAttributeButton.UseVisualStyleBackColor = False
        '
        'FormulaBT
        '
        Me.FormulaBT.AutoSize = True
        Me.FormulaBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FormulaBT.BackColor = System.Drawing.Color.Transparent
        Me.FormulaBT.FlatAppearance.BorderSize = 0
        Me.FormulaBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.FormulaBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.FormulaBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FormulaBT.ForeColor = System.Drawing.Color.Transparent
        Me.FormulaBT.IconChar = FontAwesome.Sharp.MaterialIcons.FunctionVariant
        Me.FormulaBT.IconColor = System.Drawing.Color.Goldenrod
        Me.FormulaBT.IconSize = 45
        Me.FormulaBT.Location = New System.Drawing.Point(836, 210)
        Me.FormulaBT.Name = "FormulaBT"
        Me.FormulaBT.Size = New System.Drawing.Size(51, 51)
        Me.FormulaBT.TabIndex = 299
        Me.FormulaBT.UseVisualStyleBackColor = False
        Me.FormulaBT.Visible = False
        '
        'EditListBT
        '
        Me.EditListBT.AutoSize = True
        Me.EditListBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.EditListBT.BackColor = System.Drawing.Color.Transparent
        Me.EditListBT.FlatAppearance.BorderSize = 0
        Me.EditListBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.EditListBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.EditListBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditListBT.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditListBT.ForeColor = System.Drawing.Color.Transparent
        Me.EditListBT.IconChar = FontAwesome.Sharp.IconChar.List
        Me.EditListBT.IconColor = System.Drawing.Color.Goldenrod
        Me.EditListBT.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.EditListBT.IconSize = 35
        Me.EditListBT.Location = New System.Drawing.Point(842, 217)
        Me.EditListBT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.EditListBT.Name = "EditListBT"
        Me.EditListBT.Size = New System.Drawing.Size(41, 41)
        Me.EditListBT.TabIndex = 286
        Me.EditListBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.EditListBT.UseVisualStyleBackColor = False
        Me.EditListBT.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Location = New System.Drawing.Point(890, 226)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(22, 21)
        Me.CheckBox1.TabIndex = 303
        Me.CheckBox1.UseVisualStyleBackColor = True
        Me.CheckBox1.Visible = False
        '
        'AddItemPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1259, 685)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.UseBT)
        Me.Controls.Add(Me.FormulaNameLB)
        Me.Controls.Add(Me.FormulaNameTB)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.FormulaTB)
        Me.Controls.Add(Me.AddParametersBT)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DefaultValueTB)
        Me.Controls.Add(Me.TrueChB)
        Me.Controls.Add(Me.FalseChB)
        Me.Controls.Add(Me.IconButton7)
        Me.Controls.Add(Me.CurrencyChB)
        Me.Controls.Add(Me.ConstantChB)
        Me.Controls.Add(Me.AttrTypeCB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.OptionalChB)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.AddAttributeButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.AttrNameTB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TotalInstalmentsLabel)
        Me.Controls.Add(Me.ItemNameTB)
        Me.Controls.Add(Me.ListValues)
        Me.Controls.Add(Me.FormulaBT)
        Me.Controls.Add(Me.EditListBT)
        Me.DoubleBuffered = True
        Me.Name = "AddItemPage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TotalInstalmentsLabel As Label
    Friend WithEvents ItemNameTB As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents AttrNameTB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents AddAttributeButton As FontAwesome.Sharp.IconButton
    Friend WithEvents OptionalChB As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DefaultValueTB As TextBox
    Friend WithEvents AttrTypeCB As ComboBox
    Friend WithEvents ConstantChB As CheckBox
    Friend WithEvents EditListBT As FontAwesome.Sharp.IconButton
    Friend WithEvents CurrencyChB As CheckBox
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents IconButton7 As FontAwesome.Sharp.IconButton
    Friend WithEvents TrueChB As CheckBox
    Friend WithEvents FalseChB As CheckBox
    Friend WithEvents ListValues As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents AddParametersBT As FontAwesome.Sharp.IconButton
    Friend WithEvents FormulaTB As ProBaseAdvancedTextBox.ProBaseAdvancedTextBox.RichTextBoxPrintCtrl
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FormulaBT As FontAwesome.Sharp.Material.MaterialButton
    Friend WithEvents FormulaNameLB As Label
    Friend WithEvents FormulaNameTB As TextBox
    Friend WithEvents UseBT As FontAwesome.Sharp.IconButton
    Friend WithEvents CheckBox1 As CheckBox
End Class
