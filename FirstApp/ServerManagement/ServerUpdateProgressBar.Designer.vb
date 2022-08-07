<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ServerUpdateProgressBar
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
        Me.StatusLB = New System.Windows.Forms.Label()
        Me.StartBT = New FontAwesome.Sharp.IconButton()
        Me.TitleLB = New FontAwesome.Sharp.IconButton()
        Me.SuspendLayout()
        '
        'StatusLB
        '
        Me.StatusLB.AutoEllipsis = True
        Me.StatusLB.BackColor = System.Drawing.Color.Transparent
        Me.StatusLB.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.StatusLB.Font = New System.Drawing.Font("Century Schoolbook", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusLB.ForeColor = System.Drawing.Color.IndianRed
        Me.StatusLB.Location = New System.Drawing.Point(0, 60)
        Me.StatusLB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.StatusLB.Name = "StatusLB"
        Me.StatusLB.Size = New System.Drawing.Size(107, 21)
        Me.StatusLB.TabIndex = 10007
        Me.StatusLB.Text = "Waiting For Previous Commands To Fininsh..."
        Me.StatusLB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'StartBT
        '
        Me.StartBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StartBT.AutoSize = True
        Me.StartBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.StartBT.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StartBT.FlatAppearance.BorderSize = 0
        Me.StartBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.StartBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StartBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StartBT.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartBT.ForeColor = System.Drawing.Color.Linen
        Me.StartBT.IconChar = FontAwesome.Sharp.IconChar.ArrowRight
        Me.StartBT.IconColor = System.Drawing.Color.White
        Me.StartBT.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.StartBT.IconSize = 36
        Me.StartBT.Location = New System.Drawing.Point(66, 4)
        Me.StartBT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.StartBT.Name = "StartBT"
        Me.StartBT.Size = New System.Drawing.Size(42, 42)
        Me.StartBT.TabIndex = 10008
        Me.StartBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.StartBT.UseVisualStyleBackColor = False
        '
        'TitleLB
        '
        Me.TitleLB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitleLB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TitleLB.BackColor = System.Drawing.Color.Transparent
        Me.TitleLB.FlatAppearance.BorderSize = 0
        Me.TitleLB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.TitleLB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TitleLB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TitleLB.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLB.ForeColor = System.Drawing.Color.DarkGray
        Me.TitleLB.IconChar = FontAwesome.Sharp.IconChar.Spinner
        Me.TitleLB.IconColor = System.Drawing.Color.DarkGray
        Me.TitleLB.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.TitleLB.IconSize = 36
        Me.TitleLB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TitleLB.Location = New System.Drawing.Point(-1, -1)
        Me.TitleLB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TitleLB.Name = "TitleLB"
        Me.TitleLB.Size = New System.Drawing.Size(54, 55)
        Me.TitleLB.TabIndex = 9997
        Me.TitleLB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TitleLB.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.TitleLB.UseVisualStyleBackColor = False
        '
        'ServerUpdateProgressBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.StartBT)
        Me.Controls.Add(Me.StatusLB)
        Me.Controls.Add(Me.TitleLB)
        Me.DoubleBuffered = True
        Me.Name = "ServerUpdateProgressBar"
        Me.Size = New System.Drawing.Size(107, 81)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TitleLB As FontAwesome.Sharp.IconButton
    Friend WithEvents StartBT As FontAwesome.Sharp.IconButton
    Friend WithEvents StatusLB As Label
End Class
