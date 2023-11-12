<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AllStock
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.NextButton = New FontAwesome.Sharp.IconButton()
        Me.BackButton = New FontAwesome.Sharp.IconButton()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 58)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1332, 741)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'NextButton
        '
        Me.NextButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NextButton.AutoSize = True
        Me.NextButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.NextButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.NextButton.FlatAppearance.BorderSize = 0
        Me.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NextButton.Font = New System.Drawing.Font("Cambria", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.NextButton.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleRight
        Me.NextButton.IconColor = System.Drawing.Color.MediumPurple
        Me.NextButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.NextButton.IconSize = 40
        Me.NextButton.Location = New System.Drawing.Point(1273, 7)
        Me.NextButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(46, 46)
        Me.NextButton.TabIndex = 10010
        Me.NextButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.NextButton.UseVisualStyleBackColor = False
        '
        'BackButton
        '
        Me.BackButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BackButton.AutoSize = True
        Me.BackButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BackButton.FlatAppearance.BorderSize = 0
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Font = New System.Drawing.Font("Cambria", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.BackButton.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft
        Me.BackButton.IconColor = System.Drawing.Color.MediumPurple
        Me.BackButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BackButton.IconSize = 40
        Me.BackButton.Location = New System.Drawing.Point(1221, 7)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(46, 46)
        Me.BackButton.TabIndex = 10011
        Me.BackButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'ShowItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1332, 799)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "ShowItems"
        Me.Text = "ShowItems"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents NextButton As FontAwesome.Sharp.IconButton
    Friend WithEvents BackButton As FontAwesome.Sharp.IconButton
End Class
