<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MaturedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PendingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpToDateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AvailedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.WarningLabel = New System.Windows.Forms.Label()
        Me.CheckedListBox3 = New System.Windows.Forms.CheckedListBox()
        Me.CheckedListBox2 = New System.Windows.Forms.CheckedListBox()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.AllowDrop = True
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MaturedToolStripMenuItem, Me.PendingToolStripMenuItem, Me.NewToolStripMenuItem, Me.UpToDateToolStripMenuItem, Me.AvailedToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(163, 164)
        '
        'MaturedToolStripMenuItem
        '
        Me.MaturedToolStripMenuItem.Name = "MaturedToolStripMenuItem"
        Me.MaturedToolStripMenuItem.Size = New System.Drawing.Size(162, 32)
        Me.MaturedToolStripMenuItem.Text = "Matured"
        '
        'PendingToolStripMenuItem
        '
        Me.PendingToolStripMenuItem.Name = "PendingToolStripMenuItem"
        Me.PendingToolStripMenuItem.Size = New System.Drawing.Size(162, 32)
        Me.PendingToolStripMenuItem.Text = "Pending"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(162, 32)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'UpToDateToolStripMenuItem
        '
        Me.UpToDateToolStripMenuItem.Name = "UpToDateToolStripMenuItem"
        Me.UpToDateToolStripMenuItem.Size = New System.Drawing.Size(162, 32)
        Me.UpToDateToolStripMenuItem.Text = "UpToDate"
        '
        'AvailedToolStripMenuItem
        '
        Me.AvailedToolStripMenuItem.Name = "AvailedToolStripMenuItem"
        Me.AvailedToolStripMenuItem.Size = New System.Drawing.Size(162, 32)
        Me.AvailedToolStripMenuItem.Text = "Availed"
        '
        'Button2
        '
        Me.Button2.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Button2.Location = New System.Drawing.Point(21, 86)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 46)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Kitty"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"Active", "Passive", "Never"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(637, 70)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(96, 73)
        Me.CheckedListBox1.TabIndex = 4
        '
        'ComboBox1
        '
        Me.ComboBox1.Location = New System.Drawing.Point(150, 96)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 28)
        Me.ComboBox1.TabIndex = 0
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(185, 150)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(86, 24)
        Me.CheckBox1.TabIndex = 8
        Me.CheckBox1.Text = "Availed"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(85, 150)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(94, 24)
        Me.CheckBox2.TabIndex = 9
        Me.CheckBox2.Text = "Matured"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(500, 86)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 46)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Customer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'WarningLabel
        '
        Me.WarningLabel.AutoSize = True
        Me.WarningLabel.BackColor = System.Drawing.Color.Transparent
        Me.WarningLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WarningLabel.ForeColor = System.Drawing.Color.Goldenrod
        Me.WarningLabel.Location = New System.Drawing.Point(234, 9)
        Me.WarningLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.WarningLabel.Name = "WarningLabel"
        Me.WarningLabel.Size = New System.Drawing.Size(413, 30)
        Me.WarningLabel.TabIndex = 253
        Me.WarningLabel.Text = "Sort Customers To Send Messages"
        Me.WarningLabel.Visible = False
        '
        'CheckedListBox3
        '
        Me.CheckedListBox3.FormattingEnabled = True
        Me.CheckedListBox3.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"})
        Me.CheckedListBox3.Location = New System.Drawing.Point(23, 203)
        Me.CheckedListBox3.Name = "CheckedListBox3"
        Me.CheckedListBox3.Size = New System.Drawing.Size(234, 349)
        Me.CheckedListBox3.TabIndex = 6
        '
        'CheckedListBox2
        '
        Me.CheckedListBox2.FormattingEnabled = True
        Me.CheckedListBox2.Location = New System.Drawing.Point(278, 203)
        Me.CheckedListBox2.Name = "CheckedListBox2"
        Me.CheckedListBox2.Size = New System.Drawing.Size(234, 349)
        Me.CheckedListBox2.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(915, 564)
        Me.Controls.Add(Me.WarningLabel)
        Me.Controls.Add(Me.CheckedListBox2)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.CheckedListBox3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.HelpButton = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents MaturedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PendingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpToDateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AvailedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button2 As Button
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents WarningLabel As Label
    Friend WithEvents CheckedListBox3 As CheckedListBox
    Friend WithEvents CheckedListBox2 As CheckedListBox
End Class
