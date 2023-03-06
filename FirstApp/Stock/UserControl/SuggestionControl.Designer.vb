<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SuggestionControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SelectBT = New FontAwesome.Sharp.IconButton()
        Me.DefValueLB = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AttrIconBT = New FontAwesome.Sharp.IconButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 93)
        Me.Label1.TabIndex = 280
        Me.Label1.Text = "Column 4:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.Controls.Add(Me.SelectBT)
        Me.Panel1.Controls.Add(Me.DefValueLB)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.AttrIconBT)
        Me.Panel1.Location = New System.Drawing.Point(132, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(107, 90)
        Me.Panel1.TabIndex = 9999
        '
        'SelectBT
        '
        Me.SelectBT.AutoSize = True
        Me.SelectBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.SelectBT.BackColor = System.Drawing.Color.Transparent
        Me.SelectBT.FlatAppearance.BorderSize = 0
        Me.SelectBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.SelectBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Snow
        Me.SelectBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SelectBT.IconChar = FontAwesome.Sharp.IconChar.HandPointer
        Me.SelectBT.IconColor = System.Drawing.Color.Goldenrod
        Me.SelectBT.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.SelectBT.IconSize = 45
        Me.SelectBT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SelectBT.Location = New System.Drawing.Point(0, 5)
        Me.SelectBT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SelectBT.Name = "SelectBT"
        Me.SelectBT.Size = New System.Drawing.Size(51, 51)
        Me.SelectBT.TabIndex = 10000
        Me.SelectBT.UseVisualStyleBackColor = False
        '
        'DefValueLB
        '
        Me.DefValueLB.AutoSize = True
        Me.DefValueLB.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DefValueLB.ForeColor = System.Drawing.Color.AliceBlue
        Me.DefValueLB.Location = New System.Drawing.Point(96, 62)
        Me.DefValueLB.Name = "DefValueLB"
        Me.DefValueLB.Size = New System.Drawing.Size(0, 28)
        Me.DefValueLB.TabIndex = 285
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label2.Location = New System.Drawing.Point(3, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 27)
        Me.Label2.TabIndex = 283
        Me.Label2.Text = "Def. Val:"
        Me.Label2.Visible = False
        '
        'AttrIconBT
        '
        Me.AttrIconBT.AutoSize = True
        Me.AttrIconBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AttrIconBT.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.AttrIconBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.AttrIconBT.FlatAppearance.BorderSize = 0
        Me.AttrIconBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.AttrIconBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.AttrIconBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AttrIconBT.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AttrIconBT.ForeColor = System.Drawing.Color.MediumPurple
        Me.AttrIconBT.IconChar = FontAwesome.Sharp.IconChar.CheckSquare
        Me.AttrIconBT.IconColor = System.Drawing.Color.White
        Me.AttrIconBT.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.AttrIconBT.IconSize = 45
        Me.AttrIconBT.Location = New System.Drawing.Point(52, 5)
        Me.AttrIconBT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AttrIconBT.Name = "AttrIconBT"
        Me.AttrIconBT.Size = New System.Drawing.Size(51, 51)
        Me.AttrIconBT.TabIndex = 282
        Me.AttrIconBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.AttrIconBT.UseVisualStyleBackColor = False
        Me.AttrIconBT.Visible = False
        '
        'SuggestionControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SuggestionControl"
        Me.Size = New System.Drawing.Size(242, 93)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DefValueLB As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents AttrIconBT As FontAwesome.Sharp.IconButton
    Friend WithEvents SelectBT As FontAwesome.Sharp.IconButton
End Class
