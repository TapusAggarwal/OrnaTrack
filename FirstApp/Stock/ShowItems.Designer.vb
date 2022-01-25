<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShowItems
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
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.AddAttributeButton = New FontAwesome.Sharp.IconButton()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 72)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(945, 464)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'IconButton1
        '
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
        Me.IconButton1.Location = New System.Drawing.Point(219, 13)
        Me.IconButton1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(149, 51)
        Me.IconButton1.TabIndex = 279
        Me.IconButton1.Text = "Reload"
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = False
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
        Me.AddAttributeButton.Location = New System.Drawing.Point(13, 13)
        Me.AddAttributeButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AddAttributeButton.Name = "AddAttributeButton"
        Me.AddAttributeButton.Size = New System.Drawing.Size(176, 51)
        Me.AddAttributeButton.TabIndex = 278
        Me.AddAttributeButton.Text = "New Item"
        Me.AddAttributeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.AddAttributeButton.UseVisualStyleBackColor = False
        '
        'ShowItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(945, 536)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.AddAttributeButton)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "ShowItems"
        Me.Text = "ShowItems"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents AddAttributeButton As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
End Class
