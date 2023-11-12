<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ServerUpdateForm
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
        Me.UpdateBT = New FontAwesome.Sharp.IconButton()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.LogoffBT = New FontAwesome.Sharp.IconButton()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(4, 106)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(277, 379)
        Me.FlowLayoutPanel1.TabIndex = 1
        Me.FlowLayoutPanel1.WrapContents = False
        '
        'UpdateBT
        '
        Me.UpdateBT.AutoSize = True
        Me.UpdateBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UpdateBT.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UpdateBT.FlatAppearance.BorderSize = 0
        Me.UpdateBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.UpdateBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UpdateBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateBT.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateBT.ForeColor = System.Drawing.Color.Linen
        Me.UpdateBT.IconChar = FontAwesome.Sharp.IconChar.Connectdevelop
        Me.UpdateBT.IconColor = System.Drawing.Color.White
        Me.UpdateBT.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.UpdateBT.IconSize = 36
        Me.UpdateBT.Location = New System.Drawing.Point(13, 14)
        Me.UpdateBT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UpdateBT.Name = "UpdateBT"
        Me.UpdateBT.Size = New System.Drawing.Size(120, 42)
        Me.UpdateBT.TabIndex = 10009
        Me.UpdateBT.Text = "Login"
        Me.UpdateBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.UpdateBT.UseVisualStyleBackColor = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(296, 104)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(697, 381)
        Me.RichTextBox1.TabIndex = 10012
        Me.RichTextBox1.Text = ""
        '
        'LogoffBT
        '
        Me.LogoffBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LogoffBT.AutoSize = True
        Me.LogoffBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.LogoffBT.BackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LogoffBT.FlatAppearance.BorderSize = 0
        Me.LogoffBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.LogoffBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LogoffBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogoffBT.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoffBT.ForeColor = System.Drawing.Color.Linen
        Me.LogoffBT.IconChar = FontAwesome.Sharp.IconChar.Bed
        Me.LogoffBT.IconColor = System.Drawing.Color.White
        Me.LogoffBT.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.LogoffBT.IconSize = 36
        Me.LogoffBT.Location = New System.Drawing.Point(859, 14)
        Me.LogoffBT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LogoffBT.Name = "LogoffBT"
        Me.LogoffBT.Size = New System.Drawing.Size(134, 42)
        Me.LogoffBT.TabIndex = 10013
        Me.LogoffBT.Text = "LogOff"
        Me.LogoffBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.LogoffBT.UseVisualStyleBackColor = False
        Me.LogoffBT.Visible = False
        '
        'ServerUpdateForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 489)
        Me.Controls.Add(Me.LogoffBT)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.UpdateBT)
        Me.Name = "ServerUpdateForm"
        Me.Text = "ServerUpdateForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents UpdateBT As FontAwesome.Sharp.IconButton
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents LogoffBT As FontAwesome.Sharp.IconButton
End Class
