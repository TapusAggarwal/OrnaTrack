<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ShortCustomerSearch
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
        Me.KittyMode1 = New System.Windows.Forms.CheckBox()
        Me.KittyNoTB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PhNoTB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NameTB = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.FindCoustmerButton = New FontAwesome.Sharp.IconButton()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 305)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(905, 617)
        Me.FlowLayoutPanel1.TabIndex = 187
        '
        'KittyMode1
        '
        Me.KittyMode1.AutoSize = True
        Me.KittyMode1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KittyMode1.ForeColor = System.Drawing.Color.Orange
        Me.KittyMode1.Location = New System.Drawing.Point(231, 21)
        Me.KittyMode1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.KittyMode1.Name = "KittyMode1"
        Me.KittyMode1.Size = New System.Drawing.Size(133, 27)
        Me.KittyMode1.TabIndex = 9990
        Me.KittyMode1.Text = "KittyMode"
        Me.KittyMode1.UseVisualStyleBackColor = True
        '
        'KittyNoTB
        '
        Me.KittyNoTB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KittyNoTB.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KittyNoTB.Location = New System.Drawing.Point(120, 13)
        Me.KittyNoTB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.KittyNoTB.Name = "KittyNoTB"
        Me.KittyNoTB.Size = New System.Drawing.Size(90, 34)
        Me.KittyNoTB.TabIndex = 9991
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Orange
        Me.Label4.Location = New System.Drawing.Point(13, 18)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 27)
        Me.Label4.TabIndex = 142
        Me.Label4.Text = "Kitty No"
        '
        'PhNoTB
        '
        Me.PhNoTB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PhNoTB.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhNoTB.Location = New System.Drawing.Point(120, 78)
        Me.PhNoTB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PhNoTB.Name = "PhNoTB"
        Me.PhNoTB.Size = New System.Drawing.Size(211, 34)
        Me.PhNoTB.TabIndex = 9992
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Orange
        Me.Label2.Location = New System.Drawing.Point(13, 81)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 27)
        Me.Label2.TabIndex = 132
        Me.Label2.Text = "PhNo"
        '
        'NameTB
        '
        Me.NameTB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NameTB.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTB.Location = New System.Drawing.Point(120, 138)
        Me.NameTB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NameTB.Name = "NameTB"
        Me.NameTB.Size = New System.Drawing.Size(210, 34)
        Me.NameTB.TabIndex = 9993
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Orange
        Me.Label9.Location = New System.Drawing.Point(13, 143)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 27)
        Me.Label9.TabIndex = 130
        Me.Label9.Text = "Name"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Panel2.Controls.Add(Me.KittyMode1)
        Me.Panel2.Controls.Add(Me.KittyNoTB)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.FindCoustmerButton)
        Me.Panel2.Controls.Add(Me.PhNoTB)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.NameTB)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.ForeColor = System.Drawing.Color.DarkOrange
        Me.Panel2.Location = New System.Drawing.Point(268, 18)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(368, 269)
        Me.Panel2.TabIndex = 185
        '
        'FindCoustmerButton
        '
        Me.FindCoustmerButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.FindCoustmerButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FindCoustmerButton.FlatAppearance.BorderSize = 0
        Me.FindCoustmerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FindCoustmerButton.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FindCoustmerButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.FindCoustmerButton.IconChar = FontAwesome.Sharp.IconChar.Searchengin
        Me.FindCoustmerButton.IconColor = System.Drawing.Color.Purple
        Me.FindCoustmerButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.FindCoustmerButton.IconSize = 50
        Me.FindCoustmerButton.Location = New System.Drawing.Point(0, 189)
        Me.FindCoustmerButton.Margin = New System.Windows.Forms.Padding(0)
        Me.FindCoustmerButton.Name = "FindCoustmerButton"
        Me.FindCoustmerButton.Size = New System.Drawing.Size(368, 80)
        Me.FindCoustmerButton.TabIndex = 3
        Me.FindCoustmerButton.Text = "Find Coustmer"
        Me.FindCoustmerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.FindCoustmerButton.UseVisualStyleBackColor = False
        '
        'ShortCustomerSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(905, 922)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ShortCustomerSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Search"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents KittyMode1 As CheckBox
    Friend WithEvents KittyNoTB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents FindCoustmerButton As FontAwesome.Sharp.IconButton
    Friend WithEvents PhNoTB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents NameTB As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel2 As Panel
End Class
