<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PerUnitTimeControl
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.InfoLB = New System.Windows.Forms.Label()
        Me.AmtLB = New System.Windows.Forms.Label()
        Me.DateLB = New System.Windows.Forms.Label()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 45)
        Me.FlowLayoutPanel1.MaximumSize = New System.Drawing.Size(826, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(0, 0)
        Me.FlowLayoutPanel1.TabIndex = 1
        Me.FlowLayoutPanel1.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel2.Controls.Add(Me.InfoLB)
        Me.Panel2.Controls.Add(Me.AmtLB)
        Me.Panel2.Controls.Add(Me.DateLB)
        Me.Panel2.Controls.Add(Me.IconButton1)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(823, 41)
        Me.Panel2.TabIndex = 3
        '
        'InfoLB
        '
        Me.InfoLB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoLB.AutoSize = True
        Me.InfoLB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoLB.Location = New System.Drawing.Point(657, 8)
        Me.InfoLB.Name = "InfoLB"
        Me.InfoLB.Size = New System.Drawing.Size(93, 26)
        Me.InfoLB.TabIndex = 5
        Me.InfoLB.Text = "Kitty:43"
        '
        'AmtLB
        '
        Me.AmtLB.AutoSize = True
        Me.AmtLB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmtLB.Location = New System.Drawing.Point(248, 8)
        Me.AmtLB.Name = "AmtLB"
        Me.AmtLB.Size = New System.Drawing.Size(177, 26)
        Me.AmtLB.TabIndex = 4
        Me.AmtLB.Text = "Total:+3,00,000"
        '
        'DateLB
        '
        Me.DateLB.AutoSize = True
        Me.DateLB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateLB.Location = New System.Drawing.Point(3, 8)
        Me.DateLB.Name = "DateLB"
        Me.DateLB.Size = New System.Drawing.Size(116, 26)
        Me.DateLB.TabIndex = 3
        Me.DateLB.Text = "Jun, 2003"
        '
        'IconButton1
        '
        Me.IconButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconButton1.AutoSize = True
        Me.IconButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.IconButton1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.IconButton1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowUp
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 30
        Me.IconButton1.Location = New System.Drawing.Point(784, 3)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(36, 36)
        Me.IconButton1.TabIndex = 0
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'PerUnitTimeControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.DoubleBuffered = True
        Me.Name = "PerUnitTimeControl"
        Me.Size = New System.Drawing.Size(826, 48)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents DateLB As Label
    Friend WithEvents AmtLB As Label
    Friend WithEvents InfoLB As Label
End Class
