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
        Me.ListenPhNoBT = New FontAwesome.Sharp.IconButton()
        Me.ImageBox = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ChangeListenerPhNoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListenOnceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PhNoTB = New System.Windows.Forms.TextBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.SaveButton = New FontAwesome.Sharp.IconButton()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.ImageBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListenPhNoBT
        '
        Me.ListenPhNoBT.BackColor = System.Drawing.Color.Transparent
        Me.ListenPhNoBT.FlatAppearance.BorderSize = 0
        Me.ListenPhNoBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ListenPhNoBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.ListenPhNoBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ListenPhNoBT.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListenPhNoBT.ForeColor = System.Drawing.Color.Transparent
        Me.ListenPhNoBT.IconChar = FontAwesome.Sharp.IconChar.Eye
        Me.ListenPhNoBT.IconColor = System.Drawing.Color.Goldenrod
        Me.ListenPhNoBT.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ListenPhNoBT.IconSize = 40
        Me.ListenPhNoBT.Location = New System.Drawing.Point(883, 157)
        Me.ListenPhNoBT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListenPhNoBT.Name = "ListenPhNoBT"
        Me.ListenPhNoBT.Size = New System.Drawing.Size(34, 38)
        Me.ListenPhNoBT.TabIndex = 321
        Me.ListenPhNoBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ListenPhNoBT.UseVisualStyleBackColor = False
        '
        'ImageBox
        '
        Me.ImageBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.ImageBox.Image = Global.FirstApp.My.Resources.Resources.addSign
        Me.ImageBox.Location = New System.Drawing.Point(0, 0)
        Me.ImageBox.Name = "ImageBox"
        Me.ImageBox.Size = New System.Drawing.Size(564, 636)
        Me.ImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImageBox.TabIndex = 320
        Me.ImageBox.TabStop = False
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
        Me.PhNoTB.Location = New System.Drawing.Point(587, 157)
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
        Me.NameLabel.Location = New System.Drawing.Point(582, 9)
        Me.NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(335, 143)
        Me.NameLabel.TabIndex = 323
        Me.NameLabel.Text = "Enter New PhNo With Country Code Which Will Be Used As A Listener." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Eg: 91623963" &
    "1173)"
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.Transparent
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.IconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.IconButton1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.Color.Transparent
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.IconButton1.IconColor = System.Drawing.Color.Goldenrod
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 40
        Me.IconButton1.Location = New System.Drawing.Point(824, 157)
        Me.IconButton1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(34, 38)
        Me.IconButton1.TabIndex = 324
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = False
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
        Me.SaveButton.Location = New System.Drawing.Point(587, 226)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(282, 56)
        Me.SaveButton.TabIndex = 325
        Me.SaveButton.Text = "Download To PC"
        Me.SaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'ImageDownloader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(992, 636)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.PhNoTB)
        Me.Controls.Add(Me.ListenPhNoBT)
        Me.Controls.Add(Me.ImageBox)
        Me.Name = "ImageDownloader"
        Me.Text = "ImageDownloader"
        CType(Me.ImageBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListenPhNoBT As FontAwesome.Sharp.IconButton
    Friend WithEvents ImageBox As PictureBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ChangeListenerPhNoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListenOnceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PhNoTB As TextBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents SaveButton As FontAwesome.Sharp.IconButton
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
