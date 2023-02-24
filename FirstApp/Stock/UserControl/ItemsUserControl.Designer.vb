<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItemsUserControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.DetailsButton = New FontAwesome.Sharp.IconButton()
        Me.ImageBox = New System.Windows.Forms.PictureBox()
        CType(Me.ImageBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DetailsButton
        '
        Me.DetailsButton.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.DetailsButton.FlatAppearance.BorderSize = 0
        Me.DetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DetailsButton.Font = New System.Drawing.Font("Century Schoolbook", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailsButton.ForeColor = System.Drawing.Color.Black
        Me.DetailsButton.IconChar = FontAwesome.Sharp.IconChar.InfoCircle
        Me.DetailsButton.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.DetailsButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.DetailsButton.IconSize = 35
        Me.DetailsButton.Location = New System.Drawing.Point(65, 443)
        Me.DetailsButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DetailsButton.Name = "DetailsButton"
        Me.DetailsButton.Size = New System.Drawing.Size(146, 46)
        Me.DetailsButton.TabIndex = 165
        Me.DetailsButton.Text = "Details"
        Me.DetailsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.DetailsButton.UseVisualStyleBackColor = False
        '
        'ImageBox
        '
        Me.ImageBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ImageBox.Image = Global.FirstApp.My.Resources.Resources.addSign
        Me.ImageBox.Location = New System.Drawing.Point(13, 15)
        Me.ImageBox.Name = "ImageBox"
        Me.ImageBox.Size = New System.Drawing.Size(250, 420)
        Me.ImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImageBox.TabIndex = 291
        Me.ImageBox.TabStop = False
        '
        'ItemsUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Controls.Add(Me.ImageBox)
        Me.Controls.Add(Me.DetailsButton)
        Me.Name = "ItemsUserControl"
        Me.Size = New System.Drawing.Size(277, 503)
        CType(Me.ImageBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents DetailsButton As FontAwesome.Sharp.IconButton
    Friend WithEvents ImageBox As PictureBox
End Class
