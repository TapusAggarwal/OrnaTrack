<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PreviewKitty
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PreviewKitty))
        Me.ProfilePanel = New System.Windows.Forms.Panel()
        Me.AllKittiesBT = New FontAwesome.Sharp.IconButton()
        Me.SaveCoustmerButton = New FontAwesome.Sharp.IconButton()
        Me.ProfileLabel = New System.Windows.Forms.Label()
        Me.ImageBox = New System.Windows.Forms.PictureBox()
        Me.KittyPanel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ProfilePanel.SuspendLayout()
        CType(Me.ImageBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProfilePanel
        '
        Me.ProfilePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ProfilePanel.Controls.Add(Me.Panel1)
        Me.ProfilePanel.Controls.Add(Me.AllKittiesBT)
        Me.ProfilePanel.Controls.Add(Me.SaveCoustmerButton)
        Me.ProfilePanel.Controls.Add(Me.ProfileLabel)
        Me.ProfilePanel.Controls.Add(Me.ImageBox)
        Me.ProfilePanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProfilePanel.Location = New System.Drawing.Point(0, 529)
        Me.ProfilePanel.Name = "ProfilePanel"
        Me.ProfilePanel.Size = New System.Drawing.Size(1405, 368)
        Me.ProfilePanel.TabIndex = 252
        '
        'AllKittiesBT
        '
        Me.AllKittiesBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AllKittiesBT.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.AllKittiesBT.FlatAppearance.BorderSize = 0
        Me.AllKittiesBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AllKittiesBT.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AllKittiesBT.ForeColor = System.Drawing.Color.MediumPurple
        Me.AllKittiesBT.IconChar = FontAwesome.Sharp.IconChar.AddressBook
        Me.AllKittiesBT.IconColor = System.Drawing.Color.Black
        Me.AllKittiesBT.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.AllKittiesBT.Location = New System.Drawing.Point(1092, 159)
        Me.AllKittiesBT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AllKittiesBT.Name = "AllKittiesBT"
        Me.AllKittiesBT.Padding = New System.Windows.Forms.Padding(15, 0, 30, 0)
        Me.AllKittiesBT.Size = New System.Drawing.Size(313, 76)
        Me.AllKittiesBT.TabIndex = 2989
        Me.AllKittiesBT.Text = "All Kitties"
        Me.AllKittiesBT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AllKittiesBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.AllKittiesBT.UseVisualStyleBackColor = False
        '
        'SaveCoustmerButton
        '
        Me.SaveCoustmerButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveCoustmerButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.SaveCoustmerButton.FlatAppearance.BorderSize = 0
        Me.SaveCoustmerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveCoustmerButton.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveCoustmerButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.SaveCoustmerButton.IconChar = FontAwesome.Sharp.IconChar.AddressBook
        Me.SaveCoustmerButton.IconColor = System.Drawing.Color.Black
        Me.SaveCoustmerButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.SaveCoustmerButton.Location = New System.Drawing.Point(1092, 74)
        Me.SaveCoustmerButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SaveCoustmerButton.Name = "SaveCoustmerButton"
        Me.SaveCoustmerButton.Padding = New System.Windows.Forms.Padding(15, 0, 30, 0)
        Me.SaveCoustmerButton.Size = New System.Drawing.Size(313, 76)
        Me.SaveCoustmerButton.TabIndex = 2988
        Me.SaveCoustmerButton.Text = "Save Record"
        Me.SaveCoustmerButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SaveCoustmerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SaveCoustmerButton.UseVisualStyleBackColor = False
        '
        'ProfileLabel
        '
        Me.ProfileLabel.AutoSize = True
        Me.ProfileLabel.BackColor = System.Drawing.Color.Transparent
        Me.ProfileLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProfileLabel.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.ProfileLabel.Location = New System.Drawing.Point(4, 2)
        Me.ProfileLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ProfileLabel.Name = "ProfileLabel"
        Me.ProfileLabel.Size = New System.Drawing.Size(86, 30)
        Me.ProfileLabel.TabIndex = 255
        Me.ProfileLabel.Text = "Profile"
        '
        'ImageBox
        '
        Me.ImageBox.BackgroundImage = CType(resources.GetObject("ImageBox.BackgroundImage"), System.Drawing.Image)
        Me.ImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ImageBox.ErrorImage = CType(resources.GetObject("ImageBox.ErrorImage"), System.Drawing.Image)
        Me.ImageBox.InitialImage = CType(resources.GetObject("ImageBox.InitialImage"), System.Drawing.Image)
        Me.ImageBox.Location = New System.Drawing.Point(13, 68)
        Me.ImageBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ImageBox.Name = "ImageBox"
        Me.ImageBox.Size = New System.Drawing.Size(226, 233)
        Me.ImageBox.TabIndex = 4
        Me.ImageBox.TabStop = False
        '
        'KittyPanel
        '
        Me.KittyPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.KittyPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KittyPanel.Location = New System.Drawing.Point(0, 0)
        Me.KittyPanel.MaximumSize = New System.Drawing.Size(1404, 523)
        Me.KittyPanel.MinimumSize = New System.Drawing.Size(1404, 523)
        Me.KittyPanel.Name = "KittyPanel"
        Me.KittyPanel.Size = New System.Drawing.Size(1404, 523)
        Me.KittyPanel.TabIndex = 265
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(244, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(839, 359)
        Me.Panel1.TabIndex = 6
        '
        'PreviewKitty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1405, 897)
        Me.Controls.Add(Me.KittyPanel)
        Me.Controls.Add(Me.ProfilePanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "PreviewKitty"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PreviewKitty"
        Me.ProfilePanel.ResumeLayout(False)
        Me.ProfilePanel.PerformLayout()
        CType(Me.ImageBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ProfilePanel As Panel
    Friend WithEvents ProfileLabel As Label
    Friend WithEvents ImageBox As PictureBox
    Friend WithEvents KittyPanel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents AllKittiesBT As FontAwesome.Sharp.IconButton
    Friend WithEvents SaveCoustmerButton As FontAwesome.Sharp.IconButton
End Class
