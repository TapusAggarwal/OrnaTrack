<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MessengerForIndividual
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TemplateBT = New FontAwesome.Sharp.IconButton()
        Me.ReceiptBT = New FontAwesome.Sharp.IconButton()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Location = New System.Drawing.Point(1, 54)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1206, 681)
        Me.Panel1.TabIndex = 10000
        '
        'TemplateBT
        '
        Me.TemplateBT.AutoSize = True
        Me.TemplateBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TemplateBT.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.TemplateBT.FlatAppearance.BorderSize = 0
        Me.TemplateBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.TemplateBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.TemplateBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TemplateBT.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TemplateBT.ForeColor = System.Drawing.Color.SlateBlue
        Me.TemplateBT.IconChar = FontAwesome.Sharp.IconChar.ListUl
        Me.TemplateBT.IconColor = System.Drawing.Color.White
        Me.TemplateBT.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.TemplateBT.IconSize = 36
        Me.TemplateBT.Location = New System.Drawing.Point(310, 6)
        Me.TemplateBT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TemplateBT.Name = "TemplateBT"
        Me.TemplateBT.Size = New System.Drawing.Size(315, 44)
        Me.TemplateBT.TabIndex = 9999
        Me.TemplateBT.Text = "Message Template"
        Me.TemplateBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.TemplateBT.UseVisualStyleBackColor = False
        '
        'ReceiptBT
        '
        Me.ReceiptBT.AutoSize = True
        Me.ReceiptBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ReceiptBT.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ReceiptBT.FlatAppearance.BorderSize = 0
        Me.ReceiptBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.ReceiptBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.ReceiptBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReceiptBT.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReceiptBT.ForeColor = System.Drawing.Color.SlateBlue
        Me.ReceiptBT.IconChar = FontAwesome.Sharp.IconChar.Scroll
        Me.ReceiptBT.IconColor = System.Drawing.Color.White
        Me.ReceiptBT.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ReceiptBT.IconSize = 36
        Me.ReceiptBT.Location = New System.Drawing.Point(9, 6)
        Me.ReceiptBT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ReceiptBT.Name = "ReceiptBT"
        Me.ReceiptBT.Size = New System.Drawing.Size(293, 44)
        Me.ReceiptBT.TabIndex = 9998
        Me.ReceiptBT.Text = "Message Receipt"
        Me.ReceiptBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ReceiptBT.UseVisualStyleBackColor = False
        '
        'MessengerForIndividual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1208, 737)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TemplateBT)
        Me.Controls.Add(Me.ReceiptBT)
        Me.Name = "MessengerForIndividual"
        Me.Text = "MessengerForIndividual"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TemplateBT As FontAwesome.Sharp.IconButton
    Friend WithEvents ReceiptBT As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
End Class
