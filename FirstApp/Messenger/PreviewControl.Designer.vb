<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PreviewControl
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DetailsButton = New FontAwesome.Sharp.IconButton()
        Me.CloseButton = New FontAwesome.Sharp.IconButton()
        Me.SendBT = New FontAwesome.Sharp.IconButton()
        Me.SrNoLB = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.StatusLB = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(3, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 28)
        Me.Label1.TabIndex = 9998
        Me.Label1.Text = "Label1"
        '
        'DetailsButton
        '
        Me.DetailsButton.AutoSize = True
        Me.DetailsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.DetailsButton.BackColor = System.Drawing.Color.Transparent
        Me.DetailsButton.FlatAppearance.BorderSize = 0
        Me.DetailsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.DetailsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DetailsButton.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailsButton.ForeColor = System.Drawing.Color.Linen
        Me.DetailsButton.IconChar = FontAwesome.Sharp.IconChar.InfoCircle
        Me.DetailsButton.IconColor = System.Drawing.Color.White
        Me.DetailsButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.DetailsButton.IconSize = 36
        Me.DetailsButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.DetailsButton.Location = New System.Drawing.Point(182, 4)
        Me.DetailsButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DetailsButton.Name = "DetailsButton"
        Me.DetailsButton.Size = New System.Drawing.Size(42, 42)
        Me.DetailsButton.TabIndex = 9997
        Me.DetailsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.DetailsButton.UseVisualStyleBackColor = False
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.AutoSize = True
        Me.CloseButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CloseButton.FlatAppearance.BorderSize = 0
        Me.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.ForeColor = System.Drawing.Color.Linen
        Me.CloseButton.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.CloseButton.IconColor = System.Drawing.Color.White
        Me.CloseButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.CloseButton.IconSize = 32
        Me.CloseButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CloseButton.Location = New System.Drawing.Point(573, 5)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(38, 38)
        Me.CloseButton.TabIndex = 9996
        Me.CloseButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CloseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'SendBT
        '
        Me.SendBT.AutoSize = True
        Me.SendBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.SendBT.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SendBT.FlatAppearance.BorderSize = 0
        Me.SendBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.SendBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SendBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SendBT.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SendBT.ForeColor = System.Drawing.Color.Linen
        Me.SendBT.IconChar = FontAwesome.Sharp.IconChar.PaperPlane
        Me.SendBT.IconColor = System.Drawing.Color.White
        Me.SendBT.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.SendBT.IconSize = 36
        Me.SendBT.Location = New System.Drawing.Point(60, 4)
        Me.SendBT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SendBT.Name = "SendBT"
        Me.SendBT.Size = New System.Drawing.Size(115, 42)
        Me.SendBT.TabIndex = 9995
        Me.SendBT.Text = "Send"
        Me.SendBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SendBT.UseVisualStyleBackColor = False
        '
        'SrNoLB
        '
        Me.SrNoLB.AutoSize = True
        Me.SrNoLB.BackColor = System.Drawing.Color.Transparent
        Me.SrNoLB.Font = New System.Drawing.Font("Century Schoolbook", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SrNoLB.ForeColor = System.Drawing.Color.Goldenrod
        Me.SrNoLB.Location = New System.Drawing.Point(1, 13)
        Me.SrNoLB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SrNoLB.Name = "SrNoLB"
        Me.SrNoLB.Size = New System.Drawing.Size(56, 25)
        Me.SrNoLB.TabIndex = 10000
        Me.SrNoLB.Text = "#999"
        Me.SrNoLB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel1.Controls.Add(Me.IconButton1)
        Me.Panel1.Controls.Add(Me.StatusLB)
        Me.Panel1.Controls.Add(Me.SrNoLB)
        Me.Panel1.Controls.Add(Me.SendBT)
        Me.Panel1.Controls.Add(Me.DetailsButton)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.MaximumSize = New System.Drawing.Size(615, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(568, 52)
        Me.Panel1.TabIndex = 10001
        '
        'IconButton1
        '
        Me.IconButton1.AutoSize = True
        Me.IconButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.IconButton1.BackColor = System.Drawing.Color.Transparent
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.IconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.Color.Linen
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.EnvelopeOpen
        Me.IconButton1.IconColor = System.Drawing.Color.White
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 36
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.IconButton1.Location = New System.Drawing.Point(232, 4)
        Me.IconButton1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(42, 42)
        Me.IconButton1.TabIndex = 10007
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'StatusLB
        '
        Me.StatusLB.AutoSize = True
        Me.StatusLB.BackColor = System.Drawing.Color.Transparent
        Me.StatusLB.Font = New System.Drawing.Font("Century Schoolbook", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusLB.ForeColor = System.Drawing.Color.Red
        Me.StatusLB.Location = New System.Drawing.Point(277, 13)
        Me.StatusLB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.StatusLB.Name = "StatusLB"
        Me.StatusLB.Size = New System.Drawing.Size(286, 21)
        Me.StatusLB.TabIndex = 10006
        Me.StatusLB.Text = "+916239631173: NotRegistered"
        Me.StatusLB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.StatusLB.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(559, 39)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 21)
        Me.Panel2.TabIndex = 10002
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(550, 39)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 21)
        Me.Panel3.TabIndex = 10003
        '
        'PreviewControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CloseButton)
        Me.Name = "PreviewControl"
        Me.Size = New System.Drawing.Size(615, 63)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SendBT As FontAwesome.Sharp.IconButton
    Friend WithEvents CloseButton As FontAwesome.Sharp.IconButton
    Friend WithEvents DetailsButton As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Private WithEvents SrNoLB As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Private WithEvents StatusLB As Label
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
End Class
