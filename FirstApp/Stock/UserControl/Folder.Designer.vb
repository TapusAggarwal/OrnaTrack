<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Folder
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.BackPanel = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.Btn = New FontAwesome.Sharp.IconButton()
        Me.BackPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'BackPanel
        '
        Me.BackPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackPanel.Controls.Add(Me.Label5)
        Me.BackPanel.Controls.Add(Me.Panel4)
        Me.BackPanel.Controls.Add(Me.Panel3)
        Me.BackPanel.Controls.Add(Me.TopPanel)
        Me.BackPanel.Controls.Add(Me.Btn)
        Me.BackPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BackPanel.Location = New System.Drawing.Point(0, 0)
        Me.BackPanel.Name = "BackPanel"
        Me.BackPanel.Size = New System.Drawing.Size(258, 208)
        Me.BackPanel.TabIndex = 289
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Schoolbook", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Peru
        Me.Label5.Location = New System.Drawing.Point(62, 166)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 25)
        Me.Label5.TabIndex = 292
        Me.Label5.Text = "Item-Name:"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(14, 42)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(92, 8)
        Me.Panel4.TabIndex = 291
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(91, 28)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(164, 4)
        Me.Panel3.TabIndex = 290
        '
        'TopPanel
        '
        Me.TopPanel.Location = New System.Drawing.Point(88, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(172, 26)
        Me.TopPanel.TabIndex = 289
        '
        'Btn
        '
        Me.Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn.FlatAppearance.BorderSize = 0
        Me.Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn.ForeColor = System.Drawing.Color.MediumPurple
        Me.Btn.IconChar = FontAwesome.Sharp.IconChar.SignLanguage
        Me.Btn.IconColor = System.Drawing.Color.White
        Me.Btn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Btn.IconSize = 60
        Me.Btn.Location = New System.Drawing.Point(0, 0)
        Me.Btn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn.Name = "Btn"
        Me.Btn.Size = New System.Drawing.Size(258, 151)
        Me.Btn.TabIndex = 278
        Me.Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn.UseVisualStyleBackColor = False
        '
        'Folder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.BackPanel)
        Me.Name = "Folder"
        Me.Size = New System.Drawing.Size(258, 208)
        Me.BackPanel.ResumeLayout(False)
        Me.BackPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BackPanel As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TopPanel As Panel
    Friend WithEvents Btn As FontAwesome.Sharp.IconButton
End Class
