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
        Me.TrueChB = New System.Windows.Forms.CheckBox()
        Me.FalseChB = New System.Windows.Forms.CheckBox()
        Me.ListValues = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FormulaTB = New ProBaseAdvancedTextBox.ProBaseAdvancedTextBox.RichTextBoxPrintCtrl()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.UseBT = New FontAwesome.Sharp.IconButton()
        Me.AddParametersBT = New FontAwesome.Sharp.IconButton()
        Me.IconButton7 = New FontAwesome.Sharp.IconButton()
        Me.AddAttributeButton = New FontAwesome.Sharp.IconButton()
        Me.EditListBT = New FontAwesome.Sharp.IconButton()
        Me.DivideBT = New FontAwesome.Sharp.IconButton()
        Me.MultiplyBT = New FontAwesome.Sharp.IconButton()
        Me.PlusBT = New FontAwesome.Sharp.IconButton()
        Me.MinusBT = New FontAwesome.Sharp.IconButton()
        Me.RightBracketBT = New FontAwesome.Sharp.IconButton()
        Me.LeftBracketBT = New FontAwesome.Sharp.IconButton()
        Me.AttrCategoryCB = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SaleFP = New FirstApp.UserControl1()
        Me.ProductFP = New FirstApp.UserControl1()
        Me.PurchaseFP = New FirstApp.UserControl1()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TotalInstalmentsLabel
        '
        Me.TotalInstalmentsLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalInstalmentsLabel.AutoSize = True
        Me.TotalInstalmentsLabel.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalInstalmentsLabel.ForeColor = System.Drawing.Color.Peru
        Me.TotalInstalmentsLabel.Location = New System.Drawing.Point(569, 20)
        Me.TotalInstalmentsLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TotalInstalmentsLabel.Name = "TotalInstalmentsLabel"
        Me.TotalInstalmentsLabel.Size = New System.Drawing.Size(158, 30)
        Me.TotalInstalmentsLabel.TabIndex = 249
        Me.TotalInstalmentsLabel.Text = "Item-Name:"
        '
        'ItemNameTB
        '
        Me.ItemNameTB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemNameTB.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemNameTB.Location = New System.Drawing.Point(743, 14)
        Me.ItemNameTB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ItemNameTB.Name = "ItemNameTB"
        Me.ItemNameTB.Size = New System.Drawing.Size(293, 36)
        Me.ItemNameTB.TabIndex = 248
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Peru
        Me.Label1.Location = New System.Drawing.Point(493, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 30)
        Me.Label1.TabIndex = 250
        Me.Label1.Text = "#1"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Peru
        Me.Label2.Location = New System.Drawing.Point(559, 138)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 30)
        Me.Label2.TabIndex = 252
        Me.Label2.Text = "Attr.-Name:"
        '
        'AttrNameTB
        '
        Me.AttrNameTB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AttrNameTB.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AttrNameTB.Location = New System.Drawing.Point(743, 136)
        Me.AttrNameTB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AttrNameTB.Name = "AttrNameTB"
        Me.AttrNameTB.Size = New System.Drawing.Size(293, 36)
        Me.AttrNameTB.TabIndex = 251
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Peru
        Me.Label3.Location = New System.Drawing.Point(569, 187)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 30)
        Me.Label3.TabIndex = 254
        Me.Label3.Text = "Attr.-Type:"
        '
        'OptionalChB
        '
        Me.OptionalChB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OptionalChB.AutoSize = True
        Me.OptionalChB.BackColor = System.Drawing.Color.Transparent
        Me.OptionalChB.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptionalChB.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.OptionalChB.Location = New System.Drawing.Point(903, 282)
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
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Peru
        Me.Label4.Location = New System.Drawing.Point(526, 238)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(190, 30)
        Me.Label4.TabIndex = 282
        Me.Label4.Text = "Default Value:"
        '
        'DefaultValueTB
        '
        Me.DefaultValueTB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DefaultValueTB.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DefaultValueTB.Location = New System.Drawing.Point(743, 235)
        Me.DefaultValueTB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DefaultValueTB.Name = "DefaultValueTB"
        Me.DefaultValueTB.Size = New System.Drawing.Size(293, 36)
        Me.DefaultValueTB.TabIndex = 281
        '
        'AttrTypeCB
        '
        Me.AttrTypeCB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AttrTypeCB.DropDownHeight = 200
        Me.AttrTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AttrTypeCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AttrTypeCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AttrTypeCB.FormattingEnabled = True
        Me.AttrTypeCB.IntegralHeight = False
        Me.AttrTypeCB.Items.AddRange(New Object() {"Str", "T/F", "List", "Int"})
        Me.AttrTypeCB.Location = New System.Drawing.Point(743, 187)
        Me.AttrTypeCB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AttrTypeCB.MaxDropDownItems = 20
        Me.AttrTypeCB.Name = "AttrTypeCB"
        Me.AttrTypeCB.Size = New System.Drawing.Size(293, 34)
        Me.AttrTypeCB.TabIndex = 283
        Me.AttrTypeCB.Tag = ""
        '
        'ConstantChB
        '
        Me.ConstantChB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ConstantChB.AutoSize = True
        Me.ConstantChB.BackColor = System.Drawing.Color.Transparent
        Me.ConstantChB.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConstantChB.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.ConstantChB.Location = New System.Drawing.Point(740, 282)
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
        Me.CurrencyChB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CurrencyChB.AutoSize = True
        Me.CurrencyChB.BackColor = System.Drawing.Color.Transparent
        Me.CurrencyChB.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrencyChB.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.CurrencyChB.Location = New System.Drawing.Point(739, 330)
        Me.CurrencyChB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CurrencyChB.Name = "CurrencyChB"
        Me.CurrencyChB.Size = New System.Drawing.Size(148, 34)
        Me.CurrencyChB.TabIndex = 285
        Me.CurrencyChB.TabStop = False
        Me.CurrencyChB.Text = "Currency"
        Me.CurrencyChB.UseVisualStyleBackColor = False
        '
        'TrueChB
        '
        Me.TrueChB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TrueChB.AutoSize = True
        Me.TrueChB.BackColor = System.Drawing.Color.Transparent
        Me.TrueChB.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrueChB.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.TrueChB.Location = New System.Drawing.Point(766, 235)
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
        Me.FalseChB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FalseChB.AutoSize = True
        Me.FalseChB.BackColor = System.Drawing.Color.Transparent
        Me.FalseChB.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FalseChB.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.FalseChB.Location = New System.Drawing.Point(862, 235)
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
        Me.ListValues.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListValues.DropDownHeight = 200
        Me.ListValues.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ListValues.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ListValues.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListValues.FormattingEnabled = True
        Me.ListValues.IntegralHeight = False
        Me.ListValues.Location = New System.Drawing.Point(743, 237)
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
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Peru
        Me.Label5.Location = New System.Drawing.Point(1044, 14)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 30)
        Me.Label5.TabIndex = 293
        Me.Label5.Text = "0"
        '
        'FormulaTB
        '
        Me.FormulaTB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FormulaTB.AutoWordSelection = True
        Me.FormulaTB.BackColor = System.Drawing.Color.Lavender
        Me.FormulaTB.Font = New System.Drawing.Font("Century Schoolbook", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormulaTB.Location = New System.Drawing.Point(527, 499)
        Me.FormulaTB.Name = "FormulaTB"
        Me.FormulaTB.Size = New System.Drawing.Size(504, 84)
        Me.FormulaTB.TabIndex = 296
        Me.FormulaTB.Text = ""
        Me.FormulaTB.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(1088, 242)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(22, 21)
        Me.CheckBox1.TabIndex = 303
        Me.CheckBox1.UseVisualStyleBackColor = True
        Me.CheckBox1.Visible = False
        '
        'UseBT
        '
        Me.UseBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.UseBT.Location = New System.Drawing.Point(1049, 532)
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
        Me.AddParametersBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.AddParametersBT.Location = New System.Drawing.Point(1049, 593)
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
        Me.IconButton7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.IconButton7.Location = New System.Drawing.Point(1011, 390)
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
        Me.AddAttributeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.AddAttributeButton.Location = New System.Drawing.Point(889, 321)
        Me.AddAttributeButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AddAttributeButton.Name = "AddAttributeButton"
        Me.AddAttributeButton.Size = New System.Drawing.Size(221, 51)
        Me.AddAttributeButton.TabIndex = 277
        Me.AddAttributeButton.Text = "Add Attribute"
        Me.AddAttributeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.AddAttributeButton.UseVisualStyleBackColor = False
        '
        'EditListBT
        '
        Me.EditListBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.EditListBT.Location = New System.Drawing.Point(1040, 235)
        Me.EditListBT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.EditListBT.Name = "EditListBT"
        Me.EditListBT.Size = New System.Drawing.Size(41, 41)
        Me.EditListBT.TabIndex = 286
        Me.EditListBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.EditListBT.UseVisualStyleBackColor = False
        Me.EditListBT.Visible = False
        '
        'DivideBT
        '
        Me.DivideBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DivideBT.AutoSize = True
        Me.DivideBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.DivideBT.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.DivideBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DivideBT.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DivideBT.ForeColor = System.Drawing.Color.MediumPurple
        Me.DivideBT.IconChar = FontAwesome.Sharp.IconChar.Divide
        Me.DivideBT.IconColor = System.Drawing.Color.White
        Me.DivideBT.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.DivideBT.IconSize = 45
        Me.DivideBT.Location = New System.Drawing.Point(707, 593)
        Me.DivideBT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DivideBT.Name = "DivideBT"
        Me.DivideBT.Size = New System.Drawing.Size(53, 53)
        Me.DivideBT.TabIndex = 307
        Me.DivideBT.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.DivideBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.DivideBT.UseVisualStyleBackColor = False
        Me.DivideBT.Visible = False
        '
        'MultiplyBT
        '
        Me.MultiplyBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MultiplyBT.AutoSize = True
        Me.MultiplyBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MultiplyBT.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.MultiplyBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MultiplyBT.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MultiplyBT.ForeColor = System.Drawing.Color.MediumPurple
        Me.MultiplyBT.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.MultiplyBT.IconColor = System.Drawing.Color.White
        Me.MultiplyBT.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.MultiplyBT.IconSize = 45
        Me.MultiplyBT.Location = New System.Drawing.Point(796, 591)
        Me.MultiplyBT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MultiplyBT.Name = "MultiplyBT"
        Me.MultiplyBT.Size = New System.Drawing.Size(53, 53)
        Me.MultiplyBT.TabIndex = 308
        Me.MultiplyBT.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.MultiplyBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MultiplyBT.UseVisualStyleBackColor = False
        Me.MultiplyBT.Visible = False
        '
        'PlusBT
        '
        Me.PlusBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PlusBT.AutoSize = True
        Me.PlusBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PlusBT.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.PlusBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PlusBT.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlusBT.ForeColor = System.Drawing.Color.MediumPurple
        Me.PlusBT.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.PlusBT.IconColor = System.Drawing.Color.White
        Me.PlusBT.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.PlusBT.IconSize = 45
        Me.PlusBT.Location = New System.Drawing.Point(885, 591)
        Me.PlusBT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PlusBT.Name = "PlusBT"
        Me.PlusBT.Size = New System.Drawing.Size(53, 53)
        Me.PlusBT.TabIndex = 309
        Me.PlusBT.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.PlusBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.PlusBT.UseVisualStyleBackColor = False
        Me.PlusBT.Visible = False
        '
        'MinusBT
        '
        Me.MinusBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MinusBT.AutoSize = True
        Me.MinusBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MinusBT.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.MinusBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MinusBT.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinusBT.ForeColor = System.Drawing.Color.MediumPurple
        Me.MinusBT.IconChar = FontAwesome.Sharp.IconChar.Minus
        Me.MinusBT.IconColor = System.Drawing.Color.White
        Me.MinusBT.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.MinusBT.IconSize = 45
        Me.MinusBT.Location = New System.Drawing.Point(974, 591)
        Me.MinusBT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinusBT.Name = "MinusBT"
        Me.MinusBT.Size = New System.Drawing.Size(53, 53)
        Me.MinusBT.TabIndex = 310
        Me.MinusBT.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.MinusBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MinusBT.UseVisualStyleBackColor = False
        Me.MinusBT.Visible = False
        '
        'RightBracketBT
        '
        Me.RightBracketBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RightBracketBT.AutoSize = True
        Me.RightBracketBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.RightBracketBT.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.RightBracketBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RightBracketBT.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RightBracketBT.ForeColor = System.Drawing.Color.MediumPurple
        Me.RightBracketBT.IconChar = FontAwesome.Sharp.IconChar.AngleRight
        Me.RightBracketBT.IconColor = System.Drawing.Color.White
        Me.RightBracketBT.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.RightBracketBT.IconSize = 45
        Me.RightBracketBT.Location = New System.Drawing.Point(618, 593)
        Me.RightBracketBT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RightBracketBT.Name = "RightBracketBT"
        Me.RightBracketBT.Size = New System.Drawing.Size(53, 53)
        Me.RightBracketBT.TabIndex = 313
        Me.RightBracketBT.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.RightBracketBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RightBracketBT.UseVisualStyleBackColor = False
        Me.RightBracketBT.Visible = False
        '
        'LeftBracketBT
        '
        Me.LeftBracketBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LeftBracketBT.AutoSize = True
        Me.LeftBracketBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.LeftBracketBT.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.LeftBracketBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LeftBracketBT.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LeftBracketBT.ForeColor = System.Drawing.Color.MediumPurple
        Me.LeftBracketBT.IconChar = FontAwesome.Sharp.IconChar.AngleLeft
        Me.LeftBracketBT.IconColor = System.Drawing.Color.White
        Me.LeftBracketBT.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.LeftBracketBT.IconSize = 45
        Me.LeftBracketBT.Location = New System.Drawing.Point(529, 593)
        Me.LeftBracketBT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LeftBracketBT.Name = "LeftBracketBT"
        Me.LeftBracketBT.Size = New System.Drawing.Size(53, 53)
        Me.LeftBracketBT.TabIndex = 312
        Me.LeftBracketBT.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LeftBracketBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.LeftBracketBT.UseVisualStyleBackColor = False
        Me.LeftBracketBT.Visible = False
        '
        'AttrCategoryCB
        '
        Me.AttrCategoryCB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AttrCategoryCB.DropDownHeight = 200
        Me.AttrCategoryCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AttrCategoryCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AttrCategoryCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AttrCategoryCB.FormattingEnabled = True
        Me.AttrCategoryCB.IntegralHeight = False
        Me.AttrCategoryCB.Items.AddRange(New Object() {"Purchase Attr.", "Product Attr.", "Sale Attribute"})
        Me.AttrCategoryCB.Location = New System.Drawing.Point(743, 89)
        Me.AttrCategoryCB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AttrCategoryCB.MaxDropDownItems = 20
        Me.AttrCategoryCB.Name = "AttrCategoryCB"
        Me.AttrCategoryCB.Size = New System.Drawing.Size(293, 34)
        Me.AttrCategoryCB.TabIndex = 315
        Me.AttrCategoryCB.Tag = ""
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Peru
        Me.Label6.Location = New System.Drawing.Point(580, 89)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 30)
        Me.Label6.TabIndex = 314
        Me.Label6.Text = "Attr.-Ctg.:"
        '
        'IconButton1
        '
        Me.IconButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconButton1.AutoSize = True
        Me.IconButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.IconButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.Color.MediumPurple
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.SignInAlt
        Me.IconButton1.IconColor = System.Drawing.Color.White
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 45
        Me.IconButton1.Location = New System.Drawing.Point(507, 426)
        Me.IconButton1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(124, 51)
        Me.IconButton1.TabIndex = 316
        Me.IconButton1.Text = "Save"
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.SaleFP)
        Me.Panel1.Controls.Add(Me.ProductFP)
        Me.Panel1.Controls.Add(Me.PurchaseFP)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(332, 726)
        Me.Panel1.TabIndex = 317
        '
        'SaleFP
        '
        Me.SaleFP.AllowDrop = True
        Me.SaleFP.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.SaleFP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SaleFP.Dock = System.Windows.Forms.DockStyle.Top
        Me.SaleFP.Location = New System.Drawing.Point(0, 100)
        Me.SaleFP.Name = "SaleFP"
        Me.SaleFP.Size = New System.Drawing.Size(332, 50)
        Me.SaleFP.TabIndex = 306
        Me.SaleFP.Title = "Sale Attr."
        '
        'ProductFP
        '
        Me.ProductFP.AllowDrop = True
        Me.ProductFP.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ProductFP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ProductFP.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProductFP.Location = New System.Drawing.Point(0, 50)
        Me.ProductFP.Name = "ProductFP"
        Me.ProductFP.Size = New System.Drawing.Size(332, 50)
        Me.ProductFP.TabIndex = 305
        Me.ProductFP.Title = "Product Attr."
        '
        'PurchaseFP
        '
        Me.PurchaseFP.AllowDrop = True
        Me.PurchaseFP.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.PurchaseFP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PurchaseFP.Dock = System.Windows.Forms.DockStyle.Top
        Me.PurchaseFP.Location = New System.Drawing.Point(0, 0)
        Me.PurchaseFP.Name = "PurchaseFP"
        Me.PurchaseFP.Size = New System.Drawing.Size(332, 50)
        Me.PurchaseFP.TabIndex = 304
        Me.PurchaseFP.Title = "Puchase Attr."
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(375, 726)
        Me.Panel2.TabIndex = 318
        '
        'AddItemPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1308, 726)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.AttrCategoryCB)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.RightBracketBT)
        Me.Controls.Add(Me.LeftBracketBT)
        Me.Controls.Add(Me.MinusBT)
        Me.Controls.Add(Me.PlusBT)
        Me.Controls.Add(Me.MultiplyBT)
        Me.Controls.Add(Me.DivideBT)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.UseBT)
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
        Me.Controls.Add(Me.AddAttributeButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.AttrNameTB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TotalInstalmentsLabel)
        Me.Controls.Add(Me.ItemNameTB)
        Me.Controls.Add(Me.ListValues)
        Me.Controls.Add(Me.EditListBT)
        Me.DoubleBuffered = True
        Me.Name = "AddItemPage"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
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
    Friend WithEvents IconButton7 As FontAwesome.Sharp.IconButton
    Friend WithEvents TrueChB As CheckBox
    Friend WithEvents FalseChB As CheckBox
    Friend WithEvents ListValues As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents AddParametersBT As FontAwesome.Sharp.IconButton
    Friend WithEvents FormulaTB As ProBaseAdvancedTextBox.ProBaseAdvancedTextBox.RichTextBoxPrintCtrl
    Friend WithEvents UseBT As FontAwesome.Sharp.IconButton
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents PurchaseFP As UserControl1
    Friend WithEvents ProductFP As UserControl1
    Friend WithEvents SaleFP As UserControl1
    Friend WithEvents DivideBT As FontAwesome.Sharp.IconButton
    Friend WithEvents MultiplyBT As FontAwesome.Sharp.IconButton
    Friend WithEvents PlusBT As FontAwesome.Sharp.IconButton
    Friend WithEvents MinusBT As FontAwesome.Sharp.IconButton
    Friend WithEvents RightBracketBT As FontAwesome.Sharp.IconButton
    Friend WithEvents LeftBracketBT As FontAwesome.Sharp.IconButton
    Friend WithEvents AttrCategoryCB As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
