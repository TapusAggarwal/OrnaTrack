<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HUID_Checker
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
        Me.SearchTB = New System.Windows.Forms.TextBox()
        Me.FindCoustmerButton = New FontAwesome.Sharp.IconButton()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.SelectBT = New FontAwesome.Sharp.IconButton()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'SearchTB
        '
        Me.SearchTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.SearchTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.SearchTB.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchTB.Location = New System.Drawing.Point(138, 27)
        Me.SearchTB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SearchTB.Name = "SearchTB"
        Me.SearchTB.Size = New System.Drawing.Size(248, 45)
        Me.SearchTB.TabIndex = 9994
        '
        'FindCoustmerButton
        '
        Me.FindCoustmerButton.AutoSize = True
        Me.FindCoustmerButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FindCoustmerButton.BackColor = System.Drawing.Color.Transparent
        Me.FindCoustmerButton.FlatAppearance.BorderSize = 0
        Me.FindCoustmerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.FindCoustmerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.FindCoustmerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FindCoustmerButton.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FindCoustmerButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.FindCoustmerButton.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.FindCoustmerButton.IconColor = System.Drawing.Color.DarkMagenta
        Me.FindCoustmerButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.FindCoustmerButton.IconSize = 50
        Me.FindCoustmerButton.Location = New System.Drawing.Point(404, 27)
        Me.FindCoustmerButton.Margin = New System.Windows.Forms.Padding(0)
        Me.FindCoustmerButton.Name = "FindCoustmerButton"
        Me.FindCoustmerButton.Size = New System.Drawing.Size(56, 56)
        Me.FindCoustmerButton.TabIndex = 9995
        Me.FindCoustmerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.FindCoustmerButton.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 102)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(610, 505)
        Me.FlowLayoutPanel1.TabIndex = 9996
        '
        'SelectBT
        '
        Me.SelectBT.AutoSize = True
        Me.SelectBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.SelectBT.BackColor = System.Drawing.Color.Transparent
        Me.SelectBT.FlatAppearance.BorderSize = 0
        Me.SelectBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.SelectBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.SelectBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SelectBT.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectBT.ForeColor = System.Drawing.Color.MediumPurple
        Me.SelectBT.IconChar = FontAwesome.Sharp.IconChar.HandPointer
        Me.SelectBT.IconColor = System.Drawing.Color.Goldenrod
        Me.SelectBT.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.SelectBT.IconSize = 50
        Me.SelectBT.Location = New System.Drawing.Point(472, 27)
        Me.SelectBT.Margin = New System.Windows.Forms.Padding(0)
        Me.SelectBT.Name = "SelectBT"
        Me.SelectBT.Size = New System.Drawing.Size(56, 56)
        Me.SelectBT.TabIndex = 9997
        Me.SelectBT.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.SelectBT.UseVisualStyleBackColor = False
        Me.SelectBT.Visible = False
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.IntegralHeight = False
        Me.ListBox1.ItemHeight = 38
        Me.ListBox1.Location = New System.Drawing.Point(138, 69)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(248, 42)
        Me.ListBox1.TabIndex = 9999
        Me.ListBox1.Visible = False
        '
        'HUID_Checker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(610, 607)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.SelectBT)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.FindCoustmerButton)
        Me.Controls.Add(Me.SearchTB)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "HUID_Checker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HUID_Checker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SearchTB As TextBox
    Friend WithEvents FindCoustmerButton As FontAwesome.Sharp.IconButton
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents SelectBT As FontAwesome.Sharp.IconButton
    Friend WithEvents ListBox1 As ListBox
End Class
