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
        Me.WarningLabel = New System.Windows.Forms.Label()
        Me.CustomerSelectionChB = New System.Windows.Forms.CheckBox()
        Me.KittySelectionChB = New System.Windows.Forms.CheckBox()
        Me.SendButton = New FontAwesome.Sharp.IconButton()
        Me.PreviewBT = New FontAwesome.Sharp.IconButton()
        Me.KittyTypeCList = New System.Windows.Forms.CheckedListBox()
        Me.InstalmentsPendingCList = New System.Windows.Forms.CheckedListBox()
        Me.MaturedChB = New System.Windows.Forms.CheckBox()
        Me.AvailedChB = New System.Windows.Forms.CheckBox()
        Me.InstalmentsLeftCList = New System.Windows.Forms.CheckedListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SelectedCustomersLB = New System.Windows.Forms.Label()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
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
        'WarningLabel
        '
        Me.WarningLabel.AutoSize = True
        Me.WarningLabel.BackColor = System.Drawing.Color.Transparent
        Me.WarningLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WarningLabel.ForeColor = System.Drawing.Color.Goldenrod
        Me.WarningLabel.Location = New System.Drawing.Point(164, 9)
        Me.WarningLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.WarningLabel.Name = "WarningLabel"
        Me.WarningLabel.Size = New System.Drawing.Size(413, 30)
        Me.WarningLabel.TabIndex = 253
        Me.WarningLabel.Text = "Sort Customers To Send Messages"
        '
        'CustomerSelectionChB
        '
        Me.CustomerSelectionChB.AutoSize = True
        Me.CustomerSelectionChB.Location = New System.Drawing.Point(16, 79)
        Me.CustomerSelectionChB.Name = "CustomerSelectionChB"
        Me.CustomerSelectionChB.Size = New System.Drawing.Size(133, 24)
        Me.CustomerSelectionChB.TabIndex = 255
        Me.CustomerSelectionChB.Text = "All Customers"
        Me.CustomerSelectionChB.UseVisualStyleBackColor = True
        '
        'KittySelectionChB
        '
        Me.KittySelectionChB.AutoSize = True
        Me.KittySelectionChB.Location = New System.Drawing.Point(169, 79)
        Me.KittySelectionChB.Name = "KittySelectionChB"
        Me.KittySelectionChB.Size = New System.Drawing.Size(145, 24)
        Me.KittySelectionChB.TabIndex = 257
        Me.KittySelectionChB.Text = "Selected Kitties"
        Me.KittySelectionChB.UseVisualStyleBackColor = True
        '
        'SendButton
        '
        Me.SendButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SendButton.Enabled = False
        Me.SendButton.FlatAppearance.BorderSize = 0
        Me.SendButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.SendButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SendButton.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SendButton.ForeColor = System.Drawing.Color.Linen
        Me.SendButton.IconChar = FontAwesome.Sharp.IconChar.PaperPlane
        Me.SendButton.IconColor = System.Drawing.Color.White
        Me.SendButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.SendButton.IconSize = 25
        Me.SendButton.Location = New System.Drawing.Point(366, 114)
        Me.SendButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SendButton.Name = "SendButton"
        Me.SendButton.Size = New System.Drawing.Size(191, 45)
        Me.SendButton.TabIndex = 258
        Me.SendButton.Text = "Send Message"
        Me.SendButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SendButton.UseVisualStyleBackColor = False
        '
        'PreviewBT
        '
        Me.PreviewBT.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PreviewBT.Enabled = False
        Me.PreviewBT.FlatAppearance.BorderSize = 0
        Me.PreviewBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.PreviewBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PreviewBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PreviewBT.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PreviewBT.ForeColor = System.Drawing.Color.Linen
        Me.PreviewBT.IconChar = FontAwesome.Sharp.IconChar.PaperPlane
        Me.PreviewBT.IconColor = System.Drawing.Color.White
        Me.PreviewBT.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.PreviewBT.IconSize = 25
        Me.PreviewBT.Location = New System.Drawing.Point(565, 114)
        Me.PreviewBT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PreviewBT.Name = "PreviewBT"
        Me.PreviewBT.Size = New System.Drawing.Size(127, 45)
        Me.PreviewBT.TabIndex = 259
        Me.PreviewBT.Text = "Preview"
        Me.PreviewBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.PreviewBT.UseVisualStyleBackColor = False
        '
        'KittyTypeCList
        '
        Me.KittyTypeCList.FormattingEnabled = True
        Me.KittyTypeCList.Items.AddRange(New Object() {"All", "500", "1000", "2000", "3000", "5000"})
        Me.KittyTypeCList.Location = New System.Drawing.Point(22, 186)
        Me.KittyTypeCList.Name = "KittyTypeCList"
        Me.KittyTypeCList.Size = New System.Drawing.Size(145, 211)
        Me.KittyTypeCList.TabIndex = 264
        Me.KittyTypeCList.Visible = False
        '
        'InstalmentsPendingCList
        '
        Me.InstalmentsPendingCList.FormattingEnabled = True
        Me.InstalmentsPendingCList.Items.AddRange(New Object() {"1 Instalment Pending", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13"})
        Me.InstalmentsPendingCList.Location = New System.Drawing.Point(458, 186)
        Me.InstalmentsPendingCList.Name = "InstalmentsPendingCList"
        Me.InstalmentsPendingCList.Size = New System.Drawing.Size(270, 349)
        Me.InstalmentsPendingCList.TabIndex = 263
        Me.InstalmentsPendingCList.Visible = False
        '
        'MaturedChB
        '
        Me.MaturedChB.AutoSize = True
        Me.MaturedChB.Location = New System.Drawing.Point(22, 415)
        Me.MaturedChB.Name = "MaturedChB"
        Me.MaturedChB.Size = New System.Drawing.Size(94, 24)
        Me.MaturedChB.TabIndex = 262
        Me.MaturedChB.Text = "Matured"
        Me.MaturedChB.UseVisualStyleBackColor = True
        Me.MaturedChB.Visible = False
        '
        'AvailedChB
        '
        Me.AvailedChB.AutoSize = True
        Me.AvailedChB.Location = New System.Drawing.Point(22, 448)
        Me.AvailedChB.Name = "AvailedChB"
        Me.AvailedChB.Size = New System.Drawing.Size(86, 24)
        Me.AvailedChB.TabIndex = 261
        Me.AvailedChB.Text = "Availed"
        Me.AvailedChB.UseVisualStyleBackColor = True
        Me.AvailedChB.Visible = False
        '
        'InstalmentsLeftCList
        '
        Me.InstalmentsLeftCList.FormattingEnabled = True
        Me.InstalmentsLeftCList.Items.AddRange(New Object() {"1 Instalment Left", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14"})
        Me.InstalmentsLeftCList.Location = New System.Drawing.Point(193, 186)
        Me.InstalmentsLeftCList.Name = "InstalmentsLeftCList"
        Me.InstalmentsLeftCList.Size = New System.Drawing.Size(243, 349)
        Me.InstalmentsLeftCList.TabIndex = 260
        Me.InstalmentsLeftCList.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label1.Location = New System.Drawing.Point(392, 71)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 30)
        Me.Label1.TabIndex = 265
        Me.Label1.Text = "Selected:"
        '
        'SelectedCustomersLB
        '
        Me.SelectedCustomersLB.AutoSize = True
        Me.SelectedCustomersLB.BackColor = System.Drawing.Color.Transparent
        Me.SelectedCustomersLB.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectedCustomersLB.ForeColor = System.Drawing.Color.Goldenrod
        Me.SelectedCustomersLB.Location = New System.Drawing.Point(522, 71)
        Me.SelectedCustomersLB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SelectedCustomersLB.Name = "SelectedCustomersLB"
        Me.SelectedCustomersLB.Size = New System.Drawing.Size(26, 30)
        Me.SelectedCustomersLB.TabIndex = 266
        Me.SelectedCustomersLB.Text = "0"
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.IconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.Color.Linen
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.RedoAlt
        Me.IconButton1.IconColor = System.Drawing.Color.White
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 25
        Me.IconButton1.Location = New System.Drawing.Point(231, 114)
        Me.IconButton1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(127, 45)
        Me.IconButton1.TabIndex = 267
        Me.IconButton1.Text = "Previous"
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(740, 569)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.SelectedCustomersLB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.KittyTypeCList)
        Me.Controls.Add(Me.InstalmentsPendingCList)
        Me.Controls.Add(Me.MaturedChB)
        Me.Controls.Add(Me.AvailedChB)
        Me.Controls.Add(Me.InstalmentsLeftCList)
        Me.Controls.Add(Me.PreviewBT)
        Me.Controls.Add(Me.SendButton)
        Me.Controls.Add(Me.KittySelectionChB)
        Me.Controls.Add(Me.CustomerSelectionChB)
        Me.Controls.Add(Me.WarningLabel)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.HelpButton = True
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
    Friend WithEvents WarningLabel As Label
    Friend WithEvents CustomerSelectionChB As CheckBox
    Friend WithEvents KittySelectionChB As CheckBox
    Friend WithEvents SendButton As FontAwesome.Sharp.IconButton
    Friend WithEvents PreviewBT As FontAwesome.Sharp.IconButton
    Friend WithEvents KittyTypeCList As CheckedListBox
    Friend WithEvents InstalmentsPendingCList As CheckedListBox
    Friend WithEvents MaturedChB As CheckBox
    Friend WithEvents AvailedChB As CheckBox
    Friend WithEvents InstalmentsLeftCList As CheckedListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SelectedCustomersLB As Label
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
End Class
