<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddFormulaForm
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FormulaPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.LeftBracketBT = New FontAwesome.Sharp.IconButton()
        Me.RightBracketBT = New FontAwesome.Sharp.IconButton()
        Me.DivideBT = New FontAwesome.Sharp.IconButton()
        Me.PlusBT = New FontAwesome.Sharp.IconButton()
        Me.MinusBT = New FontAwesome.Sharp.IconButton()
        Me.MultiplyBT = New FontAwesome.Sharp.IconButton()
        Me.UseBT = New FontAwesome.Sharp.IconButton()
        Me.FormulaTB = New ProBaseAdvancedTextBox.ProBaseAdvancedTextBox.RichTextBoxPrintCtrl()
        Me.AddParametersBT = New FontAwesome.Sharp.IconButton()
        Me.FormulaPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 141)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1325, 524)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'FormulaPanel
        '
        Me.FormulaPanel.Controls.Add(Me.LeftBracketBT)
        Me.FormulaPanel.Controls.Add(Me.RightBracketBT)
        Me.FormulaPanel.Controls.Add(Me.DivideBT)
        Me.FormulaPanel.Controls.Add(Me.PlusBT)
        Me.FormulaPanel.Controls.Add(Me.MinusBT)
        Me.FormulaPanel.Controls.Add(Me.MultiplyBT)
        Me.FormulaPanel.Location = New System.Drawing.Point(14, 74)
        Me.FormulaPanel.Name = "FormulaPanel"
        Me.FormulaPanel.Size = New System.Drawing.Size(370, 61)
        Me.FormulaPanel.TabIndex = 323
        '
        'LeftBracketBT
        '
        Me.LeftBracketBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
        Me.LeftBracketBT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LeftBracketBT.Location = New System.Drawing.Point(4, 5)
        Me.LeftBracketBT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LeftBracketBT.Name = "LeftBracketBT"
        Me.LeftBracketBT.Size = New System.Drawing.Size(53, 53)
        Me.LeftBracketBT.TabIndex = 312
        Me.LeftBracketBT.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LeftBracketBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.LeftBracketBT.UseVisualStyleBackColor = False
        '
        'RightBracketBT
        '
        Me.RightBracketBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
        Me.RightBracketBT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.RightBracketBT.Location = New System.Drawing.Point(65, 5)
        Me.RightBracketBT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RightBracketBT.Name = "RightBracketBT"
        Me.RightBracketBT.Size = New System.Drawing.Size(53, 53)
        Me.RightBracketBT.TabIndex = 313
        Me.RightBracketBT.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.RightBracketBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RightBracketBT.UseVisualStyleBackColor = False
        '
        'DivideBT
        '
        Me.DivideBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
        Me.DivideBT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.DivideBT.Location = New System.Drawing.Point(126, 5)
        Me.DivideBT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DivideBT.Name = "DivideBT"
        Me.DivideBT.Size = New System.Drawing.Size(53, 53)
        Me.DivideBT.TabIndex = 307
        Me.DivideBT.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.DivideBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.DivideBT.UseVisualStyleBackColor = False
        '
        'PlusBT
        '
        Me.PlusBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
        Me.PlusBT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.PlusBT.Location = New System.Drawing.Point(187, 5)
        Me.PlusBT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PlusBT.Name = "PlusBT"
        Me.PlusBT.Size = New System.Drawing.Size(53, 53)
        Me.PlusBT.TabIndex = 309
        Me.PlusBT.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.PlusBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.PlusBT.UseVisualStyleBackColor = False
        '
        'MinusBT
        '
        Me.MinusBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
        Me.MinusBT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.MinusBT.Location = New System.Drawing.Point(248, 5)
        Me.MinusBT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinusBT.Name = "MinusBT"
        Me.MinusBT.Size = New System.Drawing.Size(53, 53)
        Me.MinusBT.TabIndex = 310
        Me.MinusBT.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.MinusBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MinusBT.UseVisualStyleBackColor = False
        '
        'MultiplyBT
        '
        Me.MultiplyBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
        Me.MultiplyBT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.MultiplyBT.Location = New System.Drawing.Point(309, 5)
        Me.MultiplyBT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MultiplyBT.Name = "MultiplyBT"
        Me.MultiplyBT.Size = New System.Drawing.Size(53, 53)
        Me.MultiplyBT.TabIndex = 308
        Me.MultiplyBT.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.MultiplyBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MultiplyBT.UseVisualStyleBackColor = False
        '
        'UseBT
        '
        Me.UseBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UseBT.AutoSize = True
        Me.UseBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UseBT.BackColor = System.Drawing.Color.ForestGreen
        Me.UseBT.FlatAppearance.BorderSize = 0
        Me.UseBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UseBT.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UseBT.ForeColor = System.Drawing.Color.GhostWhite
        Me.UseBT.IconChar = FontAwesome.Sharp.IconChar.SignInAlt
        Me.UseBT.IconColor = System.Drawing.Color.White
        Me.UseBT.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.UseBT.IconSize = 45
        Me.UseBT.Location = New System.Drawing.Point(1017, 80)
        Me.UseBT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UseBT.Name = "UseBT"
        Me.UseBT.Size = New System.Drawing.Size(294, 51)
        Me.UseBT.TabIndex = 322
        Me.UseBT.Text = "Use This Calculation"
        Me.UseBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.UseBT.UseVisualStyleBackColor = False
        '
        'FormulaTB
        '
        Me.FormulaTB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FormulaTB.AutoWordSelection = True
        Me.FormulaTB.BackColor = System.Drawing.Color.Lavender
        Me.FormulaTB.Font = New System.Drawing.Font("Century Schoolbook", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormulaTB.Location = New System.Drawing.Point(12, 12)
        Me.FormulaTB.Name = "FormulaTB"
        Me.FormulaTB.Size = New System.Drawing.Size(1299, 56)
        Me.FormulaTB.TabIndex = 321
        Me.FormulaTB.Text = ""
        '
        'AddParametersBT
        '
        Me.AddParametersBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
        Me.AddParametersBT.Location = New System.Drawing.Point(410, 79)
        Me.AddParametersBT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AddParametersBT.Name = "AddParametersBT"
        Me.AddParametersBT.Size = New System.Drawing.Size(110, 51)
        Me.AddParametersBT.TabIndex = 320
        Me.AddParametersBT.Text = "Prm"
        Me.AddParametersBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.AddParametersBT.UseVisualStyleBackColor = False
        '
        'AddFormulaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1325, 665)
        Me.Controls.Add(Me.FormulaPanel)
        Me.Controls.Add(Me.UseBT)
        Me.Controls.Add(Me.FormulaTB)
        Me.Controls.Add(Me.AddParametersBT)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "AddFormulaForm"
        Me.Text = "Select The Attribute"
        Me.FormulaPanel.ResumeLayout(False)
        Me.FormulaPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FormulaPanel As FlowLayoutPanel
    Friend WithEvents LeftBracketBT As FontAwesome.Sharp.IconButton
    Friend WithEvents RightBracketBT As FontAwesome.Sharp.IconButton
    Friend WithEvents DivideBT As FontAwesome.Sharp.IconButton
    Friend WithEvents PlusBT As FontAwesome.Sharp.IconButton
    Friend WithEvents MinusBT As FontAwesome.Sharp.IconButton
    Friend WithEvents MultiplyBT As FontAwesome.Sharp.IconButton
    Friend WithEvents UseBT As FontAwesome.Sharp.IconButton
    Friend WithEvents FormulaTB As ProBaseAdvancedTextBox.ProBaseAdvancedTextBox.RichTextBoxPrintCtrl
    Friend WithEvents AddParametersBT As FontAwesome.Sharp.IconButton
End Class
