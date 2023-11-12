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
        Me.components = New System.ComponentModel.Container()
        Me.ItemNameLB = New System.Windows.Forms.Label()
        Me.ItemNameTB = New System.Windows.Forms.TextBox()
        Me.NameLB = New System.Windows.Forms.Label()
        Me.AttrNameTB = New System.Windows.Forms.TextBox()
        Me.TypeLB = New System.Windows.Forms.Label()
        Me.OptionalChB = New System.Windows.Forms.CheckBox()
        Me.DefValLB = New System.Windows.Forms.Label()
        Me.DefaultValueTB = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NotNowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnKnownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttrTypeCB = New System.Windows.Forms.ComboBox()
        Me.ConstantChB = New System.Windows.Forms.CheckBox()
        Me.CurrencyChB = New System.Windows.Forms.CheckBox()
        Me.TrueChB = New System.Windows.Forms.CheckBox()
        Me.FalseChB = New System.Windows.Forms.CheckBox()
        Me.ListValuesCB = New System.Windows.Forms.ComboBox()
        Me.AddAttributeButton = New FontAwesome.Sharp.IconButton()
        Me.EditListBT = New FontAwesome.Sharp.IconButton()
        Me.AttrCategoryCB = New System.Windows.Forms.ComboBox()
        Me.CtgLB = New System.Windows.Forms.Label()
        Me.SaveBT = New FontAwesome.Sharp.IconButton()
        Me.FillDockPNL = New System.Windows.Forms.Panel()
        Me.SaleFP = New OrnaTrack.UserControl1()
        Me.ProductFP = New OrnaTrack.UserControl1()
        Me.PurchaseFP = New OrnaTrack.UserControl1()
        Me.TopDockPNL = New System.Windows.Forms.Panel()
        Me.AbrvLB = New System.Windows.Forms.Label()
        Me.AbbreviationTB = New System.Windows.Forms.TextBox()
        Me.FormulaBT = New FontAwesome.Sharp.IconButton()
        Me.DeleteBT = New FontAwesome.Sharp.IconButton()
        Me.ClearBT = New FontAwesome.Sharp.IconButton()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.FillDockPNL.SuspendLayout()
        Me.TopDockPNL.SuspendLayout()
        Me.SuspendLayout()
        '
        'ItemNameLB
        '
        Me.ItemNameLB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ItemNameLB.AutoSize = True
        Me.ItemNameLB.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemNameLB.ForeColor = System.Drawing.Color.Peru
        Me.ItemNameLB.Location = New System.Drawing.Point(49, 603)
        Me.ItemNameLB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ItemNameLB.Name = "ItemNameLB"
        Me.ItemNameLB.Size = New System.Drawing.Size(158, 30)
        Me.ItemNameLB.TabIndex = 249
        Me.ItemNameLB.Text = "Item-Name:"
        '
        'ItemNameTB
        '
        Me.ItemNameTB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ItemNameTB.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemNameTB.Location = New System.Drawing.Point(223, 597)
        Me.ItemNameTB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ItemNameTB.Name = "ItemNameTB"
        Me.ItemNameTB.Size = New System.Drawing.Size(293, 36)
        Me.ItemNameTB.TabIndex = 248
        '
        'NameLB
        '
        Me.NameLB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NameLB.AutoSize = True
        Me.NameLB.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLB.ForeColor = System.Drawing.Color.Peru
        Me.NameLB.Location = New System.Drawing.Point(1118, 594)
        Me.NameLB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NameLB.Name = "NameLB"
        Me.NameLB.Size = New System.Drawing.Size(157, 30)
        Me.NameLB.TabIndex = 252
        Me.NameLB.Text = "Attr.-Name:"
        '
        'AttrNameTB
        '
        Me.AttrNameTB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AttrNameTB.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AttrNameTB.Location = New System.Drawing.Point(1312, 592)
        Me.AttrNameTB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AttrNameTB.Name = "AttrNameTB"
        Me.AttrNameTB.Size = New System.Drawing.Size(293, 36)
        Me.AttrNameTB.TabIndex = 251
        '
        'TypeLB
        '
        Me.TypeLB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TypeLB.AutoSize = True
        Me.TypeLB.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TypeLB.ForeColor = System.Drawing.Color.Peru
        Me.TypeLB.Location = New System.Drawing.Point(569, 657)
        Me.TypeLB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TypeLB.Name = "TypeLB"
        Me.TypeLB.Size = New System.Drawing.Size(147, 30)
        Me.TypeLB.TabIndex = 254
        Me.TypeLB.Text = "Attr.-Type:"
        '
        'OptionalChB
        '
        Me.OptionalChB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.OptionalChB.AutoSize = True
        Me.OptionalChB.BackColor = System.Drawing.Color.Transparent
        Me.OptionalChB.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptionalChB.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.OptionalChB.Location = New System.Drawing.Point(1309, 715)
        Me.OptionalChB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OptionalChB.Name = "OptionalChB"
        Me.OptionalChB.Size = New System.Drawing.Size(159, 34)
        Me.OptionalChB.TabIndex = 279
        Me.OptionalChB.TabStop = False
        Me.OptionalChB.Text = "IsOptional"
        Me.OptionalChB.UseVisualStyleBackColor = False
        '
        'DefValLB
        '
        Me.DefValLB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DefValLB.AutoSize = True
        Me.DefValLB.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DefValLB.ForeColor = System.Drawing.Color.Peru
        Me.DefValLB.Location = New System.Drawing.Point(1118, 657)
        Me.DefValLB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DefValLB.Name = "DefValLB"
        Me.DefValLB.Size = New System.Drawing.Size(190, 30)
        Me.DefValLB.TabIndex = 282
        Me.DefValLB.Text = "Default Value:"
        '
        'DefaultValueTB
        '
        Me.DefaultValueTB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DefaultValueTB.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DefaultValueTB.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DefaultValueTB.Location = New System.Drawing.Point(1312, 655)
        Me.DefaultValueTB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DefaultValueTB.Name = "DefaultValueTB"
        Me.DefaultValueTB.Size = New System.Drawing.Size(293, 36)
        Me.DefaultValueTB.TabIndex = 281
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NotNowToolStripMenuItem, Me.UnKnownToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(161, 100)
        '
        'NotNowToolStripMenuItem
        '
        Me.NotNowToolStripMenuItem.Name = "NotNowToolStripMenuItem"
        Me.NotNowToolStripMenuItem.Size = New System.Drawing.Size(160, 32)
        Me.NotNowToolStripMenuItem.Text = "NotNow"
        '
        'UnKnownToolStripMenuItem
        '
        Me.UnKnownToolStripMenuItem.Name = "UnKnownToolStripMenuItem"
        Me.UnKnownToolStripMenuItem.Size = New System.Drawing.Size(160, 32)
        Me.UnKnownToolStripMenuItem.Text = "UnKnown"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(160, 32)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'AttrTypeCB
        '
        Me.AttrTypeCB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AttrTypeCB.DropDownHeight = 200
        Me.AttrTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AttrTypeCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AttrTypeCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AttrTypeCB.FormattingEnabled = True
        Me.AttrTypeCB.IntegralHeight = False
        Me.AttrTypeCB.Location = New System.Drawing.Point(732, 657)
        Me.AttrTypeCB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AttrTypeCB.MaxDropDownItems = 20
        Me.AttrTypeCB.Name = "AttrTypeCB"
        Me.AttrTypeCB.Size = New System.Drawing.Size(293, 34)
        Me.AttrTypeCB.TabIndex = 283
        Me.AttrTypeCB.Tag = ""
        '
        'ConstantChB
        '
        Me.ConstantChB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ConstantChB.AutoSize = True
        Me.ConstantChB.BackColor = System.Drawing.Color.Transparent
        Me.ConstantChB.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConstantChB.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.ConstantChB.Location = New System.Drawing.Point(1490, 715)
        Me.ConstantChB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ConstantChB.Name = "ConstantChB"
        Me.ConstantChB.Size = New System.Drawing.Size(163, 34)
        Me.ConstantChB.TabIndex = 284
        Me.ConstantChB.TabStop = False
        Me.ConstantChB.Text = "IsConstant"
        Me.ConstantChB.UseVisualStyleBackColor = False
        '
        'CurrencyChB
        '
        Me.CurrencyChB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CurrencyChB.AutoSize = True
        Me.CurrencyChB.BackColor = System.Drawing.Color.Transparent
        Me.CurrencyChB.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrencyChB.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.CurrencyChB.Location = New System.Drawing.Point(1123, 715)
        Me.CurrencyChB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CurrencyChB.Name = "CurrencyChB"
        Me.CurrencyChB.Size = New System.Drawing.Size(164, 34)
        Me.CurrencyChB.TabIndex = 285
        Me.CurrencyChB.TabStop = False
        Me.CurrencyChB.Text = "IsCurrency"
        Me.CurrencyChB.UseVisualStyleBackColor = False
        '
        'TrueChB
        '
        Me.TrueChB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TrueChB.AutoSize = True
        Me.TrueChB.BackColor = System.Drawing.Color.Transparent
        Me.TrueChB.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrueChB.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.TrueChB.Location = New System.Drawing.Point(1335, 655)
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
        Me.FalseChB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FalseChB.AutoSize = True
        Me.FalseChB.BackColor = System.Drawing.Color.Transparent
        Me.FalseChB.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FalseChB.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.FalseChB.Location = New System.Drawing.Point(1431, 655)
        Me.FalseChB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FalseChB.Name = "FalseChB"
        Me.FalseChB.Size = New System.Drawing.Size(99, 34)
        Me.FalseChB.TabIndex = 288
        Me.FalseChB.TabStop = False
        Me.FalseChB.Text = "False"
        Me.FalseChB.UseVisualStyleBackColor = False
        Me.FalseChB.Visible = False
        '
        'ListValuesCB
        '
        Me.ListValuesCB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListValuesCB.DropDownHeight = 200
        Me.ListValuesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ListValuesCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ListValuesCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListValuesCB.FormattingEnabled = True
        Me.ListValuesCB.IntegralHeight = False
        Me.ListValuesCB.Location = New System.Drawing.Point(1312, 657)
        Me.ListValuesCB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListValuesCB.MaxDropDownItems = 20
        Me.ListValuesCB.Name = "ListValuesCB"
        Me.ListValuesCB.Size = New System.Drawing.Size(293, 34)
        Me.ListValuesCB.TabIndex = 290
        Me.ListValuesCB.Tag = ""
        Me.ListValuesCB.Visible = False
        '
        'AddAttributeButton
        '
        Me.AddAttributeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
        Me.AddAttributeButton.Location = New System.Drawing.Point(1384, 809)
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
        Me.EditListBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
        Me.EditListBT.Location = New System.Drawing.Point(1613, 655)
        Me.EditListBT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.EditListBT.Name = "EditListBT"
        Me.EditListBT.Size = New System.Drawing.Size(41, 41)
        Me.EditListBT.TabIndex = 286
        Me.EditListBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.EditListBT.UseVisualStyleBackColor = False
        Me.EditListBT.Visible = False
        '
        'AttrCategoryCB
        '
        Me.AttrCategoryCB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AttrCategoryCB.DropDownHeight = 200
        Me.AttrCategoryCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AttrCategoryCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AttrCategoryCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AttrCategoryCB.FormattingEnabled = True
        Me.AttrCategoryCB.IntegralHeight = False
        Me.AttrCategoryCB.Items.AddRange(New Object() {"Purchase Attr.", "Product Attr.", "Sale Attribute"})
        Me.AttrCategoryCB.Location = New System.Drawing.Point(732, 594)
        Me.AttrCategoryCB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AttrCategoryCB.MaxDropDownItems = 20
        Me.AttrCategoryCB.Name = "AttrCategoryCB"
        Me.AttrCategoryCB.Size = New System.Drawing.Size(293, 34)
        Me.AttrCategoryCB.TabIndex = 315
        Me.AttrCategoryCB.Tag = ""
        '
        'CtgLB
        '
        Me.CtgLB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CtgLB.AutoSize = True
        Me.CtgLB.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtgLB.ForeColor = System.Drawing.Color.Peru
        Me.CtgLB.Location = New System.Drawing.Point(569, 594)
        Me.CtgLB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CtgLB.Name = "CtgLB"
        Me.CtgLB.Size = New System.Drawing.Size(136, 30)
        Me.CtgLB.TabIndex = 314
        Me.CtgLB.Text = "Attr.-Ctg.:"
        '
        'SaveBT
        '
        Me.SaveBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SaveBT.AutoSize = True
        Me.SaveBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.SaveBT.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.SaveBT.FlatAppearance.BorderSize = 0
        Me.SaveBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveBT.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBT.ForeColor = System.Drawing.Color.MediumPurple
        Me.SaveBT.IconChar = FontAwesome.Sharp.IconChar.SignInAlt
        Me.SaveBT.IconColor = System.Drawing.Color.White
        Me.SaveBT.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.SaveBT.IconSize = 45
        Me.SaveBT.Location = New System.Drawing.Point(293, 661)
        Me.SaveBT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SaveBT.Name = "SaveBT"
        Me.SaveBT.Size = New System.Drawing.Size(124, 51)
        Me.SaveBT.TabIndex = 316
        Me.SaveBT.Text = "Save"
        Me.SaveBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SaveBT.UseVisualStyleBackColor = False
        '
        'FillDockPNL
        '
        Me.FillDockPNL.AutoScroll = True
        Me.FillDockPNL.Controls.Add(Me.SaleFP)
        Me.FillDockPNL.Controls.Add(Me.ProductFP)
        Me.FillDockPNL.Controls.Add(Me.PurchaseFP)
        Me.FillDockPNL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FillDockPNL.Location = New System.Drawing.Point(0, 0)
        Me.FillDockPNL.Name = "FillDockPNL"
        Me.FillDockPNL.Size = New System.Drawing.Size(1688, 572)
        Me.FillDockPNL.TabIndex = 317
        '
        'SaleFP
        '
        Me.SaleFP.AllowDrop = True
        Me.SaleFP.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.SaleFP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SaleFP.Dock = System.Windows.Forms.DockStyle.Left
        Me.SaleFP.Location = New System.Drawing.Point(1122, 0)
        Me.SaleFP.Name = "SaleFP"
        Me.SaleFP.Size = New System.Drawing.Size(561, 572)
        Me.SaleFP.TabIndex = 306
        Me.SaleFP.Title = "Sale Attr."
        '
        'ProductFP
        '
        Me.ProductFP.AllowDrop = True
        Me.ProductFP.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ProductFP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ProductFP.Dock = System.Windows.Forms.DockStyle.Left
        Me.ProductFP.Location = New System.Drawing.Point(561, 0)
        Me.ProductFP.Name = "ProductFP"
        Me.ProductFP.Size = New System.Drawing.Size(561, 572)
        Me.ProductFP.TabIndex = 305
        Me.ProductFP.Title = "Product Attr."
        '
        'PurchaseFP
        '
        Me.PurchaseFP.AllowDrop = True
        Me.PurchaseFP.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.PurchaseFP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PurchaseFP.Dock = System.Windows.Forms.DockStyle.Left
        Me.PurchaseFP.Location = New System.Drawing.Point(0, 0)
        Me.PurchaseFP.Name = "PurchaseFP"
        Me.PurchaseFP.Size = New System.Drawing.Size(561, 572)
        Me.PurchaseFP.TabIndex = 304
        Me.PurchaseFP.Title = "Puchase Attr."
        '
        'TopDockPNL
        '
        Me.TopDockPNL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TopDockPNL.Controls.Add(Me.FillDockPNL)
        Me.TopDockPNL.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopDockPNL.Location = New System.Drawing.Point(0, 0)
        Me.TopDockPNL.Name = "TopDockPNL"
        Me.TopDockPNL.Size = New System.Drawing.Size(1690, 574)
        Me.TopDockPNL.TabIndex = 318
        '
        'AbrvLB
        '
        Me.AbrvLB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AbrvLB.AutoSize = True
        Me.AbrvLB.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AbrvLB.ForeColor = System.Drawing.Color.Peru
        Me.AbrvLB.Location = New System.Drawing.Point(569, 721)
        Me.AbrvLB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AbrvLB.Name = "AbrvLB"
        Me.AbrvLB.Size = New System.Drawing.Size(153, 30)
        Me.AbrvLB.TabIndex = 322
        Me.AbrvLB.Text = "Attr.-Abrv.:"
        Me.AbrvLB.Visible = False
        '
        'AbbreviationTB
        '
        Me.AbbreviationTB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AbbreviationTB.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AbbreviationTB.Location = New System.Drawing.Point(732, 715)
        Me.AbbreviationTB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AbbreviationTB.Name = "AbbreviationTB"
        Me.AbbreviationTB.Size = New System.Drawing.Size(293, 36)
        Me.AbbreviationTB.TabIndex = 321
        Me.AbbreviationTB.Visible = False
        '
        'FormulaBT
        '
        Me.FormulaBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FormulaBT.AutoSize = True
        Me.FormulaBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FormulaBT.BackColor = System.Drawing.Color.Transparent
        Me.FormulaBT.FlatAppearance.BorderSize = 0
        Me.FormulaBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.FormulaBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.FormulaBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FormulaBT.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormulaBT.ForeColor = System.Drawing.Color.Transparent
        Me.FormulaBT.IconChar = FontAwesome.Sharp.IconChar.Calculator
        Me.FormulaBT.IconColor = System.Drawing.Color.Goldenrod
        Me.FormulaBT.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.FormulaBT.IconSize = 35
        Me.FormulaBT.Location = New System.Drawing.Point(1613, 655)
        Me.FormulaBT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FormulaBT.Name = "FormulaBT"
        Me.FormulaBT.Size = New System.Drawing.Size(41, 41)
        Me.FormulaBT.TabIndex = 323
        Me.FormulaBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.FormulaBT.UseVisualStyleBackColor = False
        Me.FormulaBT.Visible = False
        '
        'DeleteBT
        '
        Me.DeleteBT.BackColor = System.Drawing.Color.Maroon
        Me.DeleteBT.FlatAppearance.BorderSize = 0
        Me.DeleteBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.DeleteBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DeleteBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteBT.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBT.ForeColor = System.Drawing.Color.Linen
        Me.DeleteBT.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        Me.DeleteBT.IconColor = System.Drawing.Color.White
        Me.DeleteBT.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.DeleteBT.IconSize = 36
        Me.DeleteBT.Location = New System.Drawing.Point(1335, 811)
        Me.DeleteBT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DeleteBT.Name = "DeleteBT"
        Me.DeleteBT.Size = New System.Drawing.Size(45, 44)
        Me.DeleteBT.TabIndex = 10039
        Me.DeleteBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.DeleteBT.UseVisualStyleBackColor = False
        Me.DeleteBT.Visible = False
        '
        'ClearBT
        '
        Me.ClearBT.BackColor = System.Drawing.Color.Transparent
        Me.ClearBT.FlatAppearance.BorderSize = 0
        Me.ClearBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.ClearBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClearBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearBT.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearBT.ForeColor = System.Drawing.Color.Linen
        Me.ClearBT.IconChar = FontAwesome.Sharp.IconChar.Eraser
        Me.ClearBT.IconColor = System.Drawing.Color.White
        Me.ClearBT.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ClearBT.IconSize = 36
        Me.ClearBT.Location = New System.Drawing.Point(1639, 580)
        Me.ClearBT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ClearBT.Name = "ClearBT"
        Me.ClearBT.Size = New System.Drawing.Size(45, 44)
        Me.ClearBT.TabIndex = 10040
        Me.ClearBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ClearBT.UseVisualStyleBackColor = False
        '
        'AddItemPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1690, 896)
        Me.Controls.Add(Me.ClearBT)
        Me.Controls.Add(Me.DeleteBT)
        Me.Controls.Add(Me.AbrvLB)
        Me.Controls.Add(Me.AbbreviationTB)
        Me.Controls.Add(Me.TopDockPNL)
        Me.Controls.Add(Me.SaveBT)
        Me.Controls.Add(Me.AttrCategoryCB)
        Me.Controls.Add(Me.CtgLB)
        Me.Controls.Add(Me.DefaultValueTB)
        Me.Controls.Add(Me.TrueChB)
        Me.Controls.Add(Me.FalseChB)
        Me.Controls.Add(Me.CurrencyChB)
        Me.Controls.Add(Me.ConstantChB)
        Me.Controls.Add(Me.AttrTypeCB)
        Me.Controls.Add(Me.DefValLB)
        Me.Controls.Add(Me.OptionalChB)
        Me.Controls.Add(Me.AddAttributeButton)
        Me.Controls.Add(Me.TypeLB)
        Me.Controls.Add(Me.NameLB)
        Me.Controls.Add(Me.AttrNameTB)
        Me.Controls.Add(Me.ItemNameLB)
        Me.Controls.Add(Me.ItemNameTB)
        Me.Controls.Add(Me.ListValuesCB)
        Me.Controls.Add(Me.EditListBT)
        Me.Controls.Add(Me.FormulaBT)
        Me.DoubleBuffered = True
        Me.Name = "AddItemPage"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.FillDockPNL.ResumeLayout(False)
        Me.TopDockPNL.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ItemNameLB As Label
    Friend WithEvents ItemNameTB As TextBox
    Friend WithEvents NameLB As Label
    Friend WithEvents AttrNameTB As TextBox
    Friend WithEvents TypeLB As Label
    Friend WithEvents AddAttributeButton As FontAwesome.Sharp.IconButton
    Friend WithEvents OptionalChB As CheckBox
    Friend WithEvents DefValLB As Label
    Friend WithEvents DefaultValueTB As TextBox
    Friend WithEvents AttrTypeCB As ComboBox
    Friend WithEvents ConstantChB As CheckBox
    Friend WithEvents EditListBT As FontAwesome.Sharp.IconButton
    Friend WithEvents CurrencyChB As CheckBox
    Friend WithEvents TrueChB As CheckBox
    Friend WithEvents FalseChB As CheckBox
    Friend WithEvents ListValuesCB As ComboBox
    Friend WithEvents PurchaseFP As UserControl1
    Friend WithEvents ProductFP As UserControl1
    Friend WithEvents SaleFP As UserControl1
    Friend WithEvents AttrCategoryCB As ComboBox
    Friend WithEvents CtgLB As Label
    Friend WithEvents SaveBT As FontAwesome.Sharp.IconButton
    Friend WithEvents FillDockPNL As Panel
    Friend WithEvents TopDockPNL As Panel
    Friend WithEvents AbrvLB As Label
    Friend WithEvents AbbreviationTB As TextBox
    Friend WithEvents FormulaBT As FontAwesome.Sharp.IconButton
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents NotNowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnKnownToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteBT As FontAwesome.Sharp.IconButton
    Friend WithEvents ClearBT As FontAwesome.Sharp.IconButton
End Class
