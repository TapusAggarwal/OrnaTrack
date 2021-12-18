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
        Me.Address = New System.Windows.Forms.Label()
        Me.Region = New System.Windows.Forms.Label()
        Me.Married = New System.Windows.Forms.Label()
        Me.Gender = New System.Windows.Forms.Label()
        Me.Profession = New System.Windows.Forms.Label()
        Me.FullName = New System.Windows.Forms.Label()
        Me.ProfessionLabel = New System.Windows.Forms.Label()
        Me.MarriedLabel = New System.Windows.Forms.Label()
        Me.PhNo = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PhNoLabel = New System.Windows.Forms.Label()
        Me.AddressLabel = New System.Windows.Forms.Label()
        Me.RegionLabel = New System.Windows.Forms.Label()
        Me.KittyPanel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ProfilePanel.SuspendLayout()
        CType(Me.ImageBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProfilePanel
        '
        Me.ProfilePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ProfilePanel.Controls.Add(Me.AllKittiesBT)
        Me.ProfilePanel.Controls.Add(Me.SaveCoustmerButton)
        Me.ProfilePanel.Controls.Add(Me.ProfileLabel)
        Me.ProfilePanel.Controls.Add(Me.ImageBox)
        Me.ProfilePanel.Controls.Add(Me.Address)
        Me.ProfilePanel.Controls.Add(Me.Region)
        Me.ProfilePanel.Controls.Add(Me.Married)
        Me.ProfilePanel.Controls.Add(Me.Gender)
        Me.ProfilePanel.Controls.Add(Me.Profession)
        Me.ProfilePanel.Controls.Add(Me.FullName)
        Me.ProfilePanel.Controls.Add(Me.ProfessionLabel)
        Me.ProfilePanel.Controls.Add(Me.MarriedLabel)
        Me.ProfilePanel.Controls.Add(Me.PhNo)
        Me.ProfilePanel.Controls.Add(Me.NameLabel)
        Me.ProfilePanel.Controls.Add(Me.Label9)
        Me.ProfilePanel.Controls.Add(Me.PhNoLabel)
        Me.ProfilePanel.Controls.Add(Me.AddressLabel)
        Me.ProfilePanel.Controls.Add(Me.RegionLabel)
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
        'Address
        '
        Me.Address.BackColor = System.Drawing.Color.Transparent
        Me.Address.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Address.Location = New System.Drawing.Point(1025, 99)
        Me.Address.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(358, 136)
        Me.Address.TabIndex = 271
        Me.Address.Text = "Introduced By kamla Kambosh"
        Me.Address.Visible = False
        '
        'Region
        '
        Me.Region.AutoSize = True
        Me.Region.BackColor = System.Drawing.Color.Transparent
        Me.Region.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Region.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Region.Location = New System.Drawing.Point(766, 194)
        Me.Region.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Region.Name = "Region"
        Me.Region.Size = New System.Drawing.Size(156, 25)
        Me.Region.TabIndex = 269
        Me.Region.Text = "Bhojpur Bazar"
        '
        'Married
        '
        Me.Married.AutoSize = True
        Me.Married.BackColor = System.Drawing.Color.Transparent
        Me.Married.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Married.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Married.Location = New System.Drawing.Point(778, 72)
        Me.Married.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Married.Name = "Married"
        Me.Married.Size = New System.Drawing.Size(67, 25)
        Me.Married.TabIndex = 275
        Me.Married.Text = "False"
        '
        'Gender
        '
        Me.Gender.AutoSize = True
        Me.Gender.BackColor = System.Drawing.Color.Transparent
        Me.Gender.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gender.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Gender.Location = New System.Drawing.Point(415, 133)
        Me.Gender.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Gender.Name = "Gender"
        Me.Gender.Size = New System.Drawing.Size(94, 25)
        Me.Gender.TabIndex = 2987
        Me.Gender.Text = "Female"
        '
        'Profession
        '
        Me.Profession.AutoSize = True
        Me.Profession.BackColor = System.Drawing.Color.Transparent
        Me.Profession.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Profession.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Profession.Location = New System.Drawing.Point(809, 133)
        Me.Profession.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Profession.Name = "Profession"
        Me.Profession.Size = New System.Drawing.Size(91, 25)
        Me.Profession.TabIndex = 267
        Me.Profession.Text = "Lawyer"
        '
        'FullName
        '
        Me.FullName.AutoSize = True
        Me.FullName.BackColor = System.Drawing.Color.Transparent
        Me.FullName.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FullName.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FullName.Location = New System.Drawing.Point(444, 74)
        Me.FullName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FullName.Name = "FullName"
        Me.FullName.Size = New System.Drawing.Size(154, 25)
        Me.FullName.TabIndex = 265
        Me.FullName.Text = "Tapus Ranjan"
        '
        'ProfessionLabel
        '
        Me.ProfessionLabel.AutoSize = True
        Me.ProfessionLabel.BackColor = System.Drawing.Color.Transparent
        Me.ProfessionLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProfessionLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.ProfessionLabel.Location = New System.Drawing.Point(673, 129)
        Me.ProfessionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ProfessionLabel.Name = "ProfessionLabel"
        Me.ProfessionLabel.Size = New System.Drawing.Size(138, 30)
        Me.ProfessionLabel.TabIndex = 195
        Me.ProfessionLabel.Text = "Profession:"
        '
        'MarriedLabel
        '
        Me.MarriedLabel.AutoSize = True
        Me.MarriedLabel.BackColor = System.Drawing.Color.Transparent
        Me.MarriedLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MarriedLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.MarriedLabel.Location = New System.Drawing.Point(672, 68)
        Me.MarriedLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MarriedLabel.Name = "MarriedLabel"
        Me.MarriedLabel.Size = New System.Drawing.Size(111, 30)
        Me.MarriedLabel.TabIndex = 274
        Me.MarriedLabel.Text = "Married:"
        '
        'PhNo
        '
        Me.PhNo.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhNo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.PhNo.Location = New System.Drawing.Point(390, 190)
        Me.PhNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PhNo.Name = "PhNo"
        Me.PhNo.Size = New System.Drawing.Size(276, 67)
        Me.PhNo.TabIndex = 260
        Me.PhNo.Text = "9816057863, 9882960863, 6239631173, 7018362951"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.BackColor = System.Drawing.Color.Transparent
        Me.NameLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.NameLabel.Location = New System.Drawing.Point(308, 70)
        Me.NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(140, 30)
        Me.NameLabel.TabIndex = 189
        Me.NameLabel.Text = "Full Name:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label9.Location = New System.Drawing.Point(308, 129)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 30)
        Me.Label9.TabIndex = 272
        Me.Label9.Text = "Gender:"
        '
        'PhNoLabel
        '
        Me.PhNoLabel.AutoSize = True
        Me.PhNoLabel.BackColor = System.Drawing.Color.Transparent
        Me.PhNoLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhNoLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.PhNoLabel.Location = New System.Drawing.Point(312, 188)
        Me.PhNoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PhNoLabel.Name = "PhNoLabel"
        Me.PhNoLabel.Size = New System.Drawing.Size(83, 30)
        Me.PhNoLabel.TabIndex = 266
        Me.PhNoLabel.Text = "PhNo:"
        '
        'AddressLabel
        '
        Me.AddressLabel.AutoSize = True
        Me.AddressLabel.BackColor = System.Drawing.Color.Transparent
        Me.AddressLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.AddressLabel.Location = New System.Drawing.Point(1025, 67)
        Me.AddressLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(112, 30)
        Me.AddressLabel.TabIndex = 270
        Me.AddressLabel.Text = "Address:"
        Me.AddressLabel.Visible = False
        '
        'RegionLabel
        '
        Me.RegionLabel.AutoSize = True
        Me.RegionLabel.BackColor = System.Drawing.Color.Transparent
        Me.RegionLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegionLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.RegionLabel.Location = New System.Drawing.Point(673, 190)
        Me.RegionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RegionLabel.Name = "RegionLabel"
        Me.RegionLabel.Size = New System.Drawing.Size(104, 30)
        Me.RegionLabel.TabIndex = 268
        Me.RegionLabel.Text = "Region:"
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
        Me.Panel1.Location = New System.Drawing.Point(246, 529)
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
        Me.Controls.Add(Me.Panel1)
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
    Friend WithEvents Address As Label
    Friend WithEvents Region As Label
    Friend WithEvents Married As Label
    Friend WithEvents Gender As Label
    Friend WithEvents Profession As Label
    Friend WithEvents FullName As Label
    Friend WithEvents ProfessionLabel As Label
    Friend WithEvents MarriedLabel As Label
    Friend WithEvents PhNo As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PhNoLabel As Label
    Friend WithEvents AddressLabel As Label
    Friend WithEvents RegionLabel As Label
    Friend WithEvents KittyPanel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents AllKittiesBT As FontAwesome.Sharp.IconButton
    Friend WithEvents SaveCoustmerButton As FontAwesome.Sharp.IconButton
End Class
