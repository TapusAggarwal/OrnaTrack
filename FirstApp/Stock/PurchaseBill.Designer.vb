<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseBill
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
        Me.AttrCategoryCB = New System.Windows.Forms.ComboBox()
        Me.CtgLB = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ImageBox = New System.Windows.Forms.PictureBox()
        Me.NameLB = New System.Windows.Forms.Label()
        Me.AttrNameTB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.ImageBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AttrCategoryCB
        '
        Me.AttrCategoryCB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AttrCategoryCB.DropDownHeight = 200
        Me.AttrCategoryCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AttrCategoryCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AttrCategoryCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AttrCategoryCB.FormattingEnabled = True
        Me.AttrCategoryCB.IntegralHeight = False
        Me.AttrCategoryCB.Items.AddRange(New Object() {"Purchase Attr.", "Product Attr.", "Sale Attribute"})
        Me.AttrCategoryCB.Location = New System.Drawing.Point(137, 23)
        Me.AttrCategoryCB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AttrCategoryCB.MaxDropDownItems = 20
        Me.AttrCategoryCB.Name = "AttrCategoryCB"
        Me.AttrCategoryCB.Size = New System.Drawing.Size(293, 34)
        Me.AttrCategoryCB.TabIndex = 317
        Me.AttrCategoryCB.Tag = ""
        '
        'CtgLB
        '
        Me.CtgLB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CtgLB.AutoSize = True
        Me.CtgLB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtgLB.ForeColor = System.Drawing.Color.Peru
        Me.CtgLB.Location = New System.Drawing.Point(26, 23)
        Me.CtgLB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CtgLB.Name = "CtgLB"
        Me.CtgLB.Size = New System.Drawing.Size(90, 29)
        Me.CtgLB.TabIndex = 316
        Me.CtgLB.Text = "Seller:"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Peru
        Me.Label1.Location = New System.Drawing.Point(493, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 29)
        Me.Label1.TabIndex = 318
        Me.Label1.Text = "Date:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(602, 23)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(236, 26)
        Me.DateTimePicker1.TabIndex = 319
        '
        'ImageBox
        '
        Me.ImageBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ImageBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ImageBox.Image = Global.OrnaTrack.My.Resources.Resources.addSign
        Me.ImageBox.Location = New System.Drawing.Point(12, 456)
        Me.ImageBox.Name = "ImageBox"
        Me.ImageBox.Size = New System.Drawing.Size(227, 71)
        Me.ImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImageBox.TabIndex = 320
        Me.ImageBox.TabStop = False
        '
        'NameLB
        '
        Me.NameLB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NameLB.AutoSize = True
        Me.NameLB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLB.ForeColor = System.Drawing.Color.Peru
        Me.NameLB.Location = New System.Drawing.Point(26, 95)
        Me.NameLB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NameLB.Name = "NameLB"
        Me.NameLB.Size = New System.Drawing.Size(216, 29)
        Me.NameLB.TabIndex = 326
        Me.NameLB.Text = "Amt. Before GST:"
        '
        'AttrNameTB
        '
        Me.AttrNameTB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AttrNameTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AttrNameTB.Location = New System.Drawing.Point(262, 93)
        Me.AttrNameTB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AttrNameTB.Name = "AttrNameTB"
        Me.AttrNameTB.Size = New System.Drawing.Size(293, 35)
        Me.AttrNameTB.TabIndex = 325
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Peru
        Me.Label4.Location = New System.Drawing.Point(608, 95)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 29)
        Me.Label4.TabIndex = 328
        Me.Label4.Text = "GST:"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(689, 93)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(293, 35)
        Me.TextBox1.TabIndex = 327
        '
        'PurchaseBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1054, 539)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.NameLB)
        Me.Controls.Add(Me.AttrNameTB)
        Me.Controls.Add(Me.ImageBox)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AttrCategoryCB)
        Me.Controls.Add(Me.CtgLB)
        Me.Name = "PurchaseBill"
        Me.Text = "PurchaseBill"
        CType(Me.ImageBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AttrCategoryCB As ComboBox
    Friend WithEvents CtgLB As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ImageBox As PictureBox
    Friend WithEvents NameLB As Label
    Friend WithEvents AttrNameTB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
