<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ActiveKittyControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.ImagePanel2 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ActiveKittyParam = New System.Windows.Forms.Label()
        Me.ActiveKittyLabel = New System.Windows.Forms.Label()
        Me.NeverLabel = New System.Windows.Forms.Label()
        Me.CoustmerIdParam = New System.Windows.Forms.Label()
        Me.SrNoParam = New System.Windows.Forms.Label()
        Me.PhNoParam = New System.Windows.Forms.Label()
        Me.NameParam = New System.Windows.Forms.Label()
        Me.ImageParam = New System.Windows.Forms.PictureBox()
        Me.DetailsButton = New FontAwesome.Sharp.IconButton()
        Me.CloseButton = New FontAwesome.Sharp.IconButton()
        Me.ImagePanel2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ImageParam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImagePanel2
        '
        Me.ImagePanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.ImagePanel2.Controls.Add(Me.ImageParam)
        Me.ImagePanel2.Location = New System.Drawing.Point(56, 3)
        Me.ImagePanel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ImagePanel2.Name = "ImagePanel2"
        Me.ImagePanel2.Size = New System.Drawing.Size(180, 228)
        Me.ImagePanel2.TabIndex = 177
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Panel2.Controls.Add(Me.ActiveKittyParam)
        Me.Panel2.Controls.Add(Me.ActiveKittyLabel)
        Me.Panel2.Controls.Add(Me.NeverLabel)
        Me.Panel2.Controls.Add(Me.CoustmerIdParam)
        Me.Panel2.Controls.Add(Me.DetailsButton)
        Me.Panel2.Controls.Add(Me.SrNoParam)
        Me.Panel2.Controls.Add(Me.CloseButton)
        Me.Panel2.Controls.Add(Me.PhNoParam)
        Me.Panel2.Controls.Add(Me.NameParam)
        Me.Panel2.Location = New System.Drawing.Point(6, 24)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(787, 186)
        Me.Panel2.TabIndex = 176
        '
        'ActiveKittyParam
        '
        Me.ActiveKittyParam.BackColor = System.Drawing.Color.Transparent
        Me.ActiveKittyParam.Font = New System.Drawing.Font("Century Schoolbook", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActiveKittyParam.ForeColor = System.Drawing.Color.LimeGreen
        Me.ActiveKittyParam.Location = New System.Drawing.Point(444, 88)
        Me.ActiveKittyParam.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ActiveKittyParam.Name = "ActiveKittyParam"
        Me.ActiveKittyParam.Size = New System.Drawing.Size(87, 26)
        Me.ActiveKittyParam.TabIndex = 170
        Me.ActiveKittyParam.Text = "2"
        Me.ActiveKittyParam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ActiveKittyLabel
        '
        Me.ActiveKittyLabel.BackColor = System.Drawing.Color.Transparent
        Me.ActiveKittyLabel.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActiveKittyLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.ActiveKittyLabel.Location = New System.Drawing.Point(256, 83)
        Me.ActiveKittyLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ActiveKittyLabel.Name = "ActiveKittyLabel"
        Me.ActiveKittyLabel.Size = New System.Drawing.Size(190, 37)
        Me.ActiveKittyLabel.TabIndex = 169
        Me.ActiveKittyLabel.Text = "Active Kitty:"
        Me.ActiveKittyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NeverLabel
        '
        Me.NeverLabel.AutoSize = True
        Me.NeverLabel.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NeverLabel.ForeColor = System.Drawing.Color.Red
        Me.NeverLabel.Location = New System.Drawing.Point(282, 85)
        Me.NeverLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NeverLabel.Name = "NeverLabel"
        Me.NeverLabel.Size = New System.Drawing.Size(215, 35)
        Me.NeverLabel.TabIndex = 171
        Me.NeverLabel.Text = "Never A Member"
        Me.NeverLabel.Visible = False
        '
        'CoustmerIdParam
        '
        Me.CoustmerIdParam.AutoSize = True
        Me.CoustmerIdParam.Location = New System.Drawing.Point(20, 45)
        Me.CoustmerIdParam.Name = "CoustmerIdParam"
        Me.CoustmerIdParam.Size = New System.Drawing.Size(0, 20)
        Me.CoustmerIdParam.TabIndex = 168
        Me.CoustmerIdParam.Visible = False
        '
        'SrNoParam
        '
        Me.SrNoParam.AutoSize = True
        Me.SrNoParam.BackColor = System.Drawing.Color.Transparent
        Me.SrNoParam.Font = New System.Drawing.Font("Century Schoolbook", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SrNoParam.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.SrNoParam.Location = New System.Drawing.Point(0, 5)
        Me.SrNoParam.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SrNoParam.Name = "SrNoParam"
        Me.SrNoParam.Size = New System.Drawing.Size(30, 21)
        Me.SrNoParam.TabIndex = 161
        Me.SrNoParam.Text = "#1"
        Me.SrNoParam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PhNoParam
        '
        Me.PhNoParam.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhNoParam.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.PhNoParam.Location = New System.Drawing.Point(234, 157)
        Me.PhNoParam.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PhNoParam.Name = "PhNoParam"
        Me.PhNoParam.Size = New System.Drawing.Size(560, 25)
        Me.PhNoParam.TabIndex = 152
        Me.PhNoParam.Text = "7018362951, 9816057863, 9882960863, 6239631173"
        Me.PhNoParam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NameParam
        '
        Me.NameParam.Font = New System.Drawing.Font("Century Schoolbook", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameParam.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.NameParam.Location = New System.Drawing.Point(236, 5)
        Me.NameParam.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NameParam.Name = "NameParam"
        Me.NameParam.Size = New System.Drawing.Size(485, 55)
        Me.NameParam.TabIndex = 151
        Me.NameParam.Text = "Dhananjaysd Aggarwalxsa"
        Me.NameParam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ImageParam
        '
        Me.ImageParam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ImageParam.Image = Global.FirstApp.My.Resources.Resources.addSign
        Me.ImageParam.Location = New System.Drawing.Point(3, 26)
        Me.ImageParam.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ImageParam.Name = "ImageParam"
        Me.ImageParam.Size = New System.Drawing.Size(174, 177)
        Me.ImageParam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImageParam.TabIndex = 7
        Me.ImageParam.TabStop = False
        '
        'DetailsButton
        '
        Me.DetailsButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DetailsButton.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.DetailsButton.FlatAppearance.BorderSize = 0
        Me.DetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DetailsButton.Font = New System.Drawing.Font("Century Schoolbook", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailsButton.ForeColor = System.Drawing.Color.Black
        Me.DetailsButton.IconChar = FontAwesome.Sharp.IconChar.InfoCircle
        Me.DetailsButton.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.DetailsButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.DetailsButton.IconSize = 35
        Me.DetailsButton.Location = New System.Drawing.Point(641, 100)
        Me.DetailsButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DetailsButton.Name = "DetailsButton"
        Me.DetailsButton.Size = New System.Drawing.Size(146, 46)
        Me.DetailsButton.TabIndex = 164
        Me.DetailsButton.Text = "Details"
        Me.DetailsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.DetailsButton.UseVisualStyleBackColor = False
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.BackColor = System.Drawing.Color.Transparent
        Me.CloseButton.FlatAppearance.BorderSize = 0
        Me.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Snow
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.CloseButton.IconColor = System.Drawing.Color.DarkRed
        Me.CloseButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.CloseButton.IconSize = 45
        Me.CloseButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CloseButton.Location = New System.Drawing.Point(730, 2)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(51, 46)
        Me.CloseButton.TabIndex = 160
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'ActiveKittyControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.ImagePanel2)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "ActiveKittyControl"
        Me.Size = New System.Drawing.Size(799, 234)
        Me.ImagePanel2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ImageParam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents ImagePanel2 As Panel
    Private WithEvents ImageParam As PictureBox
    Private WithEvents Panel2 As Panel
    Private WithEvents CoustmerIdParam As Label
    Private WithEvents DetailsButton As FontAwesome.Sharp.IconButton
    Private WithEvents SrNoParam As Label
    Private WithEvents CloseButton As FontAwesome.Sharp.IconButton
    Private WithEvents PhNoParam As Label
    Private WithEvents NameParam As Label
    Private WithEvents ActiveKittyParam As Label
    Private WithEvents ActiveKittyLabel As Label
    Private WithEvents NeverLabel As Label
End Class
