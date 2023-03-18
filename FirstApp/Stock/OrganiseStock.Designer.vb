<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrganiseStock
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
        Me.TrayWidthTB = New System.Windows.Forms.TextBox()
        Me.TrayHeightTB = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TrayWidthTB
        '
        Me.TrayWidthTB.Font = New System.Drawing.Font("Nirmala UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrayWidthTB.Location = New System.Drawing.Point(40, 24)
        Me.TrayWidthTB.Name = "TrayWidthTB"
        Me.TrayWidthTB.Size = New System.Drawing.Size(100, 50)
        Me.TrayWidthTB.TabIndex = 0
        '
        'TrayHeightTB
        '
        Me.TrayHeightTB.Font = New System.Drawing.Font("Nirmala UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrayHeightTB.Location = New System.Drawing.Point(196, 24)
        Me.TrayHeightTB.Name = "TrayHeightTB"
        Me.TrayHeightTB.Size = New System.Drawing.Size(100, 50)
        Me.TrayHeightTB.TabIndex = 1
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(12, 89)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1037, 571)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(360, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 85)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OrganiseStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1061, 672)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.TrayHeightTB)
        Me.Controls.Add(Me.TrayWidthTB)
        Me.Name = "OrganiseStock"
        Me.Text = "OrganiseStock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TrayWidthTB As TextBox
    Friend WithEvents TrayHeightTB As TextBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Button1 As Button
End Class
