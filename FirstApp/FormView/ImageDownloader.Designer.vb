<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImageDownloader
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
        Me.components = New System.ComponentModel.Container()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ChangeListenerPhNoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListenOnceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PhNoTB = New System.Windows.Forms.TextBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.CancelEditBT = New FontAwesome.Sharp.IconButton()
        Me.SelectBT = New FontAwesome.Sharp.IconButton()
        Me.DeleteBT = New FontAwesome.Sharp.IconButton()
        Me.SaveButton = New FontAwesome.Sharp.IconButton()
        Me.AddNewListenerBT = New FontAwesome.Sharp.IconButton()
        Me.ListenPhNoBT = New FontAwesome.Sharp.IconButton()
        Me.ImageBox = New System.Windows.Forms.PictureBox()
        Me.ReloadImgBT = New FontAwesome.Sharp.IconButton()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.ImageBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeListenerPhNoToolStripMenuItem, Me.ListenOnceToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(259, 68)
        '
        'ChangeListenerPhNoToolStripMenuItem
        '
        Me.ChangeListenerPhNoToolStripMenuItem.Name = "ChangeListenerPhNoToolStripMenuItem"
        Me.ChangeListenerPhNoToolStripMenuItem.Size = New System.Drawing.Size(258, 32)
        Me.ChangeListenerPhNoToolStripMenuItem.Text = "Change Listener PhNo"
        '
        'ListenOnceToolStripMenuItem
        '
        Me.ListenOnceToolStripMenuItem.Name = "ListenOnceToolStripMenuItem"
        Me.ListenOnceToolStripMenuItem.Size = New System.Drawing.Size(258, 32)
        Me.ListenOnceToolStripMenuItem.Text = "Listen Once"
        '
        'PhNoTB
        '
        Me.PhNoTB.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PhNoTB.BackColor = System.Drawing.Color.White
        Me.PhNoTB.Enabled = False
        Me.PhNoTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhNoTB.Location = New System.Drawing.Point(581, 157)
        Me.PhNoTB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PhNoTB.Name = "PhNoTB"
        Me.PhNoTB.Size = New System.Drawing.Size(229, 35)
        Me.PhNoTB.TabIndex = 322
        Me.PhNoTB.Tag = ""
        '
        'NameLabel
        '
        Me.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.NameLabel.BackColor = System.Drawing.Color.Transparent
        Me.NameLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.NameLabel.Location = New System.Drawing.Point(576, 9)
        Me.NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(335, 143)
        Me.NameLabel.TabIndex = 323
        Me.NameLabel.Text = "Enter New PhNo With Country Code Which Will Be Used As A Listener." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Eg: 91988296" &
    "0863)"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(576, 300)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(341, 318)
        Me.FlowLayoutPanel1.TabIndex = 326
        '
        'CancelEditBT
        '
        Me.CancelEditBT.BackColor = System.Drawing.Color.Maroon
        Me.CancelEditBT.FlatAppearance.BorderSize = 0
        Me.CancelEditBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.CancelEditBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CancelEditBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelEditBT.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelEditBT.ForeColor = System.Drawing.Color.Linen
        Me.CancelEditBT.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.CancelEditBT.IconColor = System.Drawing.Color.White
        Me.CancelEditBT.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.CancelEditBT.IconSize = 36
        Me.CancelEditBT.Location = New System.Drawing.Point(924, 418)
        Me.CancelEditBT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CancelEditBT.Name = "CancelEditBT"
        Me.CancelEditBT.Size = New System.Drawing.Size(45, 44)
        Me.CancelEditBT.TabIndex = 10040
        Me.CancelEditBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CancelEditBT.UseVisualStyleBackColor = False
        Me.CancelEditBT.Visible = False
        '
        'SelectBT
        '
        Me.SelectBT.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SelectBT.FlatAppearance.BorderSize = 0
        Me.SelectBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.SelectBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SelectBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SelectBT.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectBT.ForeColor = System.Drawing.Color.Linen
        Me.SelectBT.IconChar = FontAwesome.Sharp.IconChar.Check
        Me.SelectBT.IconColor = System.Drawing.Color.White
        Me.SelectBT.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.SelectBT.IconSize = 36
        Me.SelectBT.Location = New System.Drawing.Point(924, 310)
        Me.SelectBT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SelectBT.Name = "SelectBT"
        Me.SelectBT.Size = New System.Drawing.Size(45, 44)
        Me.SelectBT.TabIndex = 10039
        Me.SelectBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SelectBT.UseVisualStyleBackColor = False
        Me.SelectBT.Visible = False
        '
        'DeleteBT
        '
        Me.DeleteBT.BackColor = System.Drawing.Color.Maroon
        Me.DeleteBT.FlatAppearance.BorderSize = 0
        Me.DeleteBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.DeleteBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DeleteBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteBT.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBT.ForeColor = System.Drawing.Color.Linen
        Me.DeleteBT.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        Me.DeleteBT.IconColor = System.Drawing.Color.White
        Me.DeleteBT.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.DeleteBT.IconSize = 36
        Me.DeleteBT.Location = New System.Drawing.Point(924, 364)
        Me.DeleteBT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DeleteBT.Name = "DeleteBT"
        Me.DeleteBT.Size = New System.Drawing.Size(45, 44)
        Me.DeleteBT.TabIndex = 10041
        Me.DeleteBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.DeleteBT.UseVisualStyleBackColor = False
        Me.DeleteBT.Visible = False
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SaveButton.FlatAppearance.BorderSize = 0
        Me.SaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.SaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveButton.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.ForeColor = System.Drawing.Color.Linen
        Me.SaveButton.IconChar = FontAwesome.Sharp.IconChar.Download
        Me.SaveButton.IconColor = System.Drawing.Color.White
        Me.SaveButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.SaveButton.IconSize = 32
        Me.SaveButton.Location = New System.Drawing.Point(581, 226)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(282, 56)
        Me.SaveButton.TabIndex = 325
        Me.SaveButton.Text = "Download To PC"
        Me.SaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'AddNewListenerBT
        '
        Me.AddNewListenerBT.BackColor = System.Drawing.Color.Transparent
        Me.AddNewListenerBT.FlatAppearance.BorderSize = 0
        Me.AddNewListenerBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.AddNewListenerBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.AddNewListenerBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AddNewListenerBT.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddNewListenerBT.ForeColor = System.Drawing.Color.Transparent
        Me.AddNewListenerBT.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.AddNewListenerBT.IconColor = System.Drawing.Color.Goldenrod
        Me.AddNewListenerBT.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.AddNewListenerBT.IconSize = 40
        Me.AddNewListenerBT.Location = New System.Drawing.Point(941, 156)
        Me.AddNewListenerBT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AddNewListenerBT.Name = "AddNewListenerBT"
        Me.AddNewListenerBT.Size = New System.Drawing.Size(34, 38)
        Me.AddNewListenerBT.TabIndex = 324
        Me.AddNewListenerBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.AddNewListenerBT.UseVisualStyleBackColor = False
        '
        'ListenPhNoBT
        '
        Me.ListenPhNoBT.AutoSize = True
        Me.ListenPhNoBT.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ListenPhNoBT.FlatAppearance.BorderSize = 0
        Me.ListenPhNoBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ListenPhNoBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.ListenPhNoBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ListenPhNoBT.Font = New System.Drawing.Font("Century Schoolbook", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListenPhNoBT.ForeColor = System.Drawing.Color.White
        Me.ListenPhNoBT.IconChar = FontAwesome.Sharp.IconChar.Eye
        Me.ListenPhNoBT.IconColor = System.Drawing.Color.White
        Me.ListenPhNoBT.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ListenPhNoBT.IconSize = 40
        Me.ListenPhNoBT.Location = New System.Drawing.Point(818, 152)
        Me.ListenPhNoBT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListenPhNoBT.Name = "ListenPhNoBT"
        Me.ListenPhNoBT.Size = New System.Drawing.Size(115, 46)
        Me.ListenPhNoBT.TabIndex = 321
        Me.ListenPhNoBT.Text = "Start"
        Me.ListenPhNoBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ListenPhNoBT.UseVisualStyleBackColor = False
        '
        'ImageBox
        '
        Me.ImageBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.ImageBox.Image = Global.OrnaTrack.My.Resources.Resources.addSign
        Me.ImageBox.Location = New System.Drawing.Point(0, 0)
        Me.ImageBox.Name = "ImageBox"
        Me.ImageBox.Size = New System.Drawing.Size(564, 636)
        Me.ImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImageBox.TabIndex = 320
        Me.ImageBox.TabStop = False
        '
        'ReloadImgBT
        '
        Me.ReloadImgBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReloadImgBT.AutoSize = True
        Me.ReloadImgBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ReloadImgBT.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ReloadImgBT.FlatAppearance.BorderSize = 0
        Me.ReloadImgBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReloadImgBT.Font = New System.Drawing.Font("Cambria", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReloadImgBT.ForeColor = System.Drawing.Color.MediumPurple
        Me.ReloadImgBT.IconChar = FontAwesome.Sharp.IconChar.RedoAlt
        Me.ReloadImgBT.IconColor = System.Drawing.Color.MediumPurple
        Me.ReloadImgBT.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ReloadImgBT.IconSize = 40
        Me.ReloadImgBT.Location = New System.Drawing.Point(871, 231)
        Me.ReloadImgBT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ReloadImgBT.Name = "ReloadImgBT"
        Me.ReloadImgBT.Size = New System.Drawing.Size(46, 46)
        Me.ReloadImgBT.TabIndex = 10042
        Me.ReloadImgBT.Tag = "-1"
        Me.ReloadImgBT.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ReloadImgBT.UseVisualStyleBackColor = False
        '
        'ImageDownloader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(992, 636)
        Me.Controls.Add(Me.ReloadImgBT)
        Me.Controls.Add(Me.CancelEditBT)
        Me.Controls.Add(Me.SelectBT)
        Me.Controls.Add(Me.DeleteBT)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.AddNewListenerBT)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.PhNoTB)
        Me.Controls.Add(Me.ListenPhNoBT)
        Me.Controls.Add(Me.ImageBox)
        Me.Name = "ImageDownloader"
        Me.Text = "ImageDownloader"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.ImageBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImageBox As PictureBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ChangeListenerPhNoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListenOnceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PhNoTB As TextBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents AddNewListenerBT As FontAwesome.Sharp.IconButton
    Friend WithEvents SaveButton As FontAwesome.Sharp.IconButton
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents CancelEditBT As FontAwesome.Sharp.IconButton
    Friend WithEvents SelectBT As FontAwesome.Sharp.IconButton
    Friend WithEvents DeleteBT As FontAwesome.Sharp.IconButton
    Friend WithEvents ListenPhNoBT As FontAwesome.Sharp.IconButton
    Friend WithEvents ReloadImgBT As FontAwesome.Sharp.IconButton
End Class
