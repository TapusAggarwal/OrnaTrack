<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CategoriesPage
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
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SaveBT = New FontAwesome.Sharp.IconButton()
        Me.AddBT = New FontAwesome.Sharp.IconButton()
        Me.StockEntryBT = New FontAwesome.Sharp.IconButton()
        Me.EditBT = New FontAwesome.Sharp.IconButton()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView1.Location = New System.Drawing.Point(3, 3)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(428, 395)
        Me.TreeView1.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Controls.Add(Me.TreeView1)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(720, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(473, 786)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(107, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'SaveBT
        '
        Me.SaveBT.IconChar = FontAwesome.Sharp.IconChar.None
        Me.SaveBT.IconColor = System.Drawing.Color.Black
        Me.SaveBT.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.SaveBT.Location = New System.Drawing.Point(588, 102)
        Me.SaveBT.Name = "SaveBT"
        Me.SaveBT.Size = New System.Drawing.Size(101, 39)
        Me.SaveBT.TabIndex = 4
        Me.SaveBT.Text = "Save"
        Me.SaveBT.UseVisualStyleBackColor = True
        '
        'AddBT
        '
        Me.AddBT.IconChar = FontAwesome.Sharp.IconChar.None
        Me.AddBT.IconColor = System.Drawing.Color.Black
        Me.AddBT.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.AddBT.Location = New System.Drawing.Point(588, 10)
        Me.AddBT.Name = "AddBT"
        Me.AddBT.Size = New System.Drawing.Size(101, 39)
        Me.AddBT.TabIndex = 2
        Me.AddBT.Text = "Add Node"
        Me.AddBT.UseVisualStyleBackColor = True
        '
        'StockEntryBT
        '
        Me.StockEntryBT.IconChar = FontAwesome.Sharp.IconChar.None
        Me.StockEntryBT.IconColor = System.Drawing.Color.Black
        Me.StockEntryBT.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.StockEntryBT.Location = New System.Drawing.Point(588, 334)
        Me.StockEntryBT.Name = "StockEntryBT"
        Me.StockEntryBT.Size = New System.Drawing.Size(101, 39)
        Me.StockEntryBT.TabIndex = 5
        Me.StockEntryBT.Text = "Stock Entry"
        Me.StockEntryBT.UseVisualStyleBackColor = True
        '
        'EditBT
        '
        Me.EditBT.IconChar = FontAwesome.Sharp.IconChar.None
        Me.EditBT.IconColor = System.Drawing.Color.Black
        Me.EditBT.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.EditBT.Location = New System.Drawing.Point(588, 55)
        Me.EditBT.Name = "EditBT"
        Me.EditBT.Size = New System.Drawing.Size(101, 39)
        Me.EditBT.TabIndex = 6
        Me.EditBT.Text = "Edit Node"
        Me.EditBT.UseVisualStyleBackColor = True
        '
        'CategoriesPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1193, 786)
        Me.Controls.Add(Me.EditBT)
        Me.Controls.Add(Me.StockEntryBT)
        Me.Controls.Add(Me.SaveBT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AddBT)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "CategoriesPage"
        Me.Text = "CategoriesPage"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents AddBT As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents SaveBT As FontAwesome.Sharp.IconButton
    Friend WithEvents StockEntryBT As FontAwesome.Sharp.IconButton
    Friend WithEvents EditBT As FontAwesome.Sharp.IconButton
End Class
