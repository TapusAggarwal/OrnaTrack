<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MessagesPreviewForm
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.SendButton = New FontAwesome.Sharp.IconButton()
        Me.RetryButton = New FontAwesome.Sharp.IconButton()
        Me.SentLB = New System.Windows.Forms.Label()
        Me.SentText = New System.Windows.Forms.Label()
        Me.UnRegisteredText = New System.Windows.Forms.Label()
        Me.UnRegisteredLB = New System.Windows.Forms.Label()
        Me.BackButton = New FontAwesome.Sharp.IconButton()
        Me.NextButton = New FontAwesome.Sharp.IconButton()
        Me.PreviewCountLB = New System.Windows.Forms.Label()
        Me.FailedLB = New System.Windows.Forms.Label()
        Me.FailedText = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ImagesPreview = New FontAwesome.Sharp.IconButton()
        Me.CurrentCB = New System.Windows.Forms.CheckBox()
        Me.AllCB = New System.Windows.Forms.CheckBox()
        Me.MessagesPerPageTB = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 61)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(1000)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1595, 569)
        Me.FlowLayoutPanel1.TabIndex = 9997
        '
        'SendButton
        '
        Me.SendButton.AutoSize = True
        Me.SendButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.SendButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SendButton.FlatAppearance.BorderSize = 0
        Me.SendButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.SendButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SendButton.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SendButton.ForeColor = System.Drawing.Color.Linen
        Me.SendButton.IconChar = FontAwesome.Sharp.IconChar.PaperPlane
        Me.SendButton.IconColor = System.Drawing.Color.White
        Me.SendButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.SendButton.IconSize = 36
        Me.SendButton.Location = New System.Drawing.Point(279, 6)
        Me.SendButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SendButton.Name = "SendButton"
        Me.SendButton.Size = New System.Drawing.Size(129, 44)
        Me.SendButton.TabIndex = 9998
        Me.SendButton.Text = "Send"
        Me.SendButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SendButton.UseVisualStyleBackColor = False
        '
        'RetryButton
        '
        Me.RetryButton.AutoSize = True
        Me.RetryButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.RetryButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RetryButton.FlatAppearance.BorderSize = 0
        Me.RetryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.RetryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RetryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RetryButton.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RetryButton.ForeColor = System.Drawing.Color.Linen
        Me.RetryButton.IconChar = FontAwesome.Sharp.IconChar.RedoAlt
        Me.RetryButton.IconColor = System.Drawing.Color.White
        Me.RetryButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.RetryButton.IconSize = 36
        Me.RetryButton.Location = New System.Drawing.Point(422, 6)
        Me.RetryButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RetryButton.Name = "RetryButton"
        Me.RetryButton.Size = New System.Drawing.Size(128, 44)
        Me.RetryButton.TabIndex = 9999
        Me.RetryButton.Text = "Retry"
        Me.RetryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RetryButton.UseVisualStyleBackColor = False
        '
        'SentLB
        '
        Me.SentLB.AutoSize = True
        Me.SentLB.BackColor = System.Drawing.Color.Transparent
        Me.SentLB.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SentLB.ForeColor = System.Drawing.Color.Goldenrod
        Me.SentLB.Location = New System.Drawing.Point(573, 15)
        Me.SentLB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SentLB.Name = "SentLB"
        Me.SentLB.Size = New System.Drawing.Size(76, 30)
        Me.SentLB.TabIndex = 10001
        Me.SentLB.Text = "Sent:"
        Me.SentLB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SentText
        '
        Me.SentText.AutoSize = True
        Me.SentText.BackColor = System.Drawing.Color.Transparent
        Me.SentText.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SentText.ForeColor = System.Drawing.Color.Goldenrod
        Me.SentText.Location = New System.Drawing.Point(646, 15)
        Me.SentText.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SentText.Name = "SentText"
        Me.SentText.Size = New System.Drawing.Size(104, 30)
        Me.SentText.TabIndex = 10002
        Me.SentText.Text = "500/710"
        Me.SentText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UnRegisteredText
        '
        Me.UnRegisteredText.AutoSize = True
        Me.UnRegisteredText.BackColor = System.Drawing.Color.Transparent
        Me.UnRegisteredText.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnRegisteredText.ForeColor = System.Drawing.Color.Goldenrod
        Me.UnRegisteredText.Location = New System.Drawing.Point(951, 15)
        Me.UnRegisteredText.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.UnRegisteredText.Name = "UnRegisteredText"
        Me.UnRegisteredText.Size = New System.Drawing.Size(55, 30)
        Me.UnRegisteredText.TabIndex = 10004
        Me.UnRegisteredText.Text = "180"
        Me.UnRegisteredText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UnRegisteredText.Visible = False
        '
        'UnRegisteredLB
        '
        Me.UnRegisteredLB.AutoSize = True
        Me.UnRegisteredLB.BackColor = System.Drawing.Color.Transparent
        Me.UnRegisteredLB.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnRegisteredLB.ForeColor = System.Drawing.Color.Goldenrod
        Me.UnRegisteredLB.Location = New System.Drawing.Point(779, 15)
        Me.UnRegisteredLB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.UnRegisteredLB.Name = "UnRegisteredLB"
        Me.UnRegisteredLB.Size = New System.Drawing.Size(176, 30)
        Me.UnRegisteredLB.TabIndex = 10003
        Me.UnRegisteredLB.Text = "UnRegiseter:"
        Me.UnRegisteredLB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UnRegisteredLB.Visible = False
        '
        'BackButton
        '
        Me.BackButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BackButton.AutoSize = True
        Me.BackButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BackButton.FlatAppearance.BorderSize = 0
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Font = New System.Drawing.Font("Cambria", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.BackButton.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft
        Me.BackButton.IconColor = System.Drawing.Color.MediumPurple
        Me.BackButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BackButton.IconSize = 40
        Me.BackButton.Location = New System.Drawing.Point(1475, 6)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(46, 46)
        Me.BackButton.TabIndex = 10009
        Me.BackButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'NextButton
        '
        Me.NextButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NextButton.AutoSize = True
        Me.NextButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.NextButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.NextButton.FlatAppearance.BorderSize = 0
        Me.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NextButton.Font = New System.Drawing.Font("Cambria", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.NextButton.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleRight
        Me.NextButton.IconColor = System.Drawing.Color.MediumPurple
        Me.NextButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.NextButton.IconSize = 40
        Me.NextButton.Location = New System.Drawing.Point(1527, 6)
        Me.NextButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(46, 46)
        Me.NextButton.TabIndex = 10008
        Me.NextButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.NextButton.UseVisualStyleBackColor = False
        '
        'PreviewCountLB
        '
        Me.PreviewCountLB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PreviewCountLB.BackColor = System.Drawing.Color.Transparent
        Me.PreviewCountLB.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PreviewCountLB.ForeColor = System.Drawing.Color.MediumPurple
        Me.PreviewCountLB.Location = New System.Drawing.Point(1226, 13)
        Me.PreviewCountLB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PreviewCountLB.Name = "PreviewCountLB"
        Me.PreviewCountLB.Size = New System.Drawing.Size(202, 30)
        Me.PreviewCountLB.TabIndex = 10010
        Me.PreviewCountLB.Text = "0-20/127"
        Me.PreviewCountLB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FailedLB
        '
        Me.FailedLB.AutoSize = True
        Me.FailedLB.BackColor = System.Drawing.Color.Transparent
        Me.FailedLB.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FailedLB.ForeColor = System.Drawing.Color.Goldenrod
        Me.FailedLB.Location = New System.Drawing.Point(1040, 15)
        Me.FailedLB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FailedLB.Name = "FailedLB"
        Me.FailedLB.Size = New System.Drawing.Size(99, 30)
        Me.FailedLB.TabIndex = 10005
        Me.FailedLB.Text = "Failed:"
        Me.FailedLB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FailedLB.Visible = False
        '
        'FailedText
        '
        Me.FailedText.AutoSize = True
        Me.FailedText.BackColor = System.Drawing.Color.Transparent
        Me.FailedText.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FailedText.ForeColor = System.Drawing.Color.Goldenrod
        Me.FailedText.Location = New System.Drawing.Point(1135, 15)
        Me.FailedText.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FailedText.Name = "FailedText"
        Me.FailedText.Size = New System.Drawing.Size(55, 30)
        Me.FailedText.TabIndex = 10006
        Me.FailedText.Text = "300"
        Me.FailedText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FailedText.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.ImagesPreview)
        Me.Panel1.Controls.Add(Me.CurrentCB)
        Me.Panel1.Controls.Add(Me.AllCB)
        Me.Panel1.Controls.Add(Me.MessagesPerPageTB)
        Me.Panel1.Controls.Add(Me.PreviewCountLB)
        Me.Panel1.Controls.Add(Me.SendButton)
        Me.Panel1.Controls.Add(Me.NextButton)
        Me.Panel1.Controls.Add(Me.RetryButton)
        Me.Panel1.Controls.Add(Me.BackButton)
        Me.Panel1.Controls.Add(Me.SentLB)
        Me.Panel1.Controls.Add(Me.FailedText)
        Me.Panel1.Controls.Add(Me.SentText)
        Me.Panel1.Controls.Add(Me.FailedLB)
        Me.Panel1.Controls.Add(Me.UnRegisteredLB)
        Me.Panel1.Controls.Add(Me.UnRegisteredText)
        Me.Panel1.Location = New System.Drawing.Point(0, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1595, 58)
        Me.Panel1.TabIndex = 0
        '
        'ImagesPreview
        '
        Me.ImagesPreview.AutoSize = True
        Me.ImagesPreview.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ImagesPreview.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ImagesPreview.FlatAppearance.BorderSize = 0
        Me.ImagesPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ImagesPreview.Font = New System.Drawing.Font("Cambria", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImagesPreview.ForeColor = System.Drawing.Color.MediumPurple
        Me.ImagesPreview.IconChar = FontAwesome.Sharp.IconChar.Images
        Me.ImagesPreview.IconColor = System.Drawing.Color.MediumPurple
        Me.ImagesPreview.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ImagesPreview.IconSize = 40
        Me.ImagesPreview.Location = New System.Drawing.Point(222, 7)
        Me.ImagesPreview.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ImagesPreview.Name = "ImagesPreview"
        Me.ImagesPreview.Size = New System.Drawing.Size(46, 46)
        Me.ImagesPreview.TabIndex = 10015
        Me.ImagesPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ImagesPreview.UseVisualStyleBackColor = False
        Me.ImagesPreview.Visible = False
        '
        'CurrentCB
        '
        Me.CurrentCB.AutoSize = True
        Me.CurrentCB.Checked = True
        Me.CurrentCB.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CurrentCB.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentCB.ForeColor = System.Drawing.Color.MediumPurple
        Me.CurrentCB.Location = New System.Drawing.Point(94, 15)
        Me.CurrentCB.Name = "CurrentCB"
        Me.CurrentCB.Size = New System.Drawing.Size(129, 30)
        Me.CurrentCB.TabIndex = 10014
        Me.CurrentCB.Text = "Current"
        Me.CurrentCB.UseVisualStyleBackColor = True
        '
        'AllCB
        '
        Me.AllCB.AutoSize = True
        Me.AllCB.Font = New System.Drawing.Font("Century Schoolbook", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AllCB.ForeColor = System.Drawing.Color.MediumPurple
        Me.AllCB.Location = New System.Drawing.Point(17, 15)
        Me.AllCB.Name = "AllCB"
        Me.AllCB.Size = New System.Drawing.Size(71, 30)
        Me.AllCB.TabIndex = 10013
        Me.AllCB.Text = "All"
        Me.AllCB.UseVisualStyleBackColor = True
        '
        'MessagesPerPageTB
        '
        Me.MessagesPerPageTB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MessagesPerPageTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessagesPerPageTB.Location = New System.Drawing.Point(1435, 13)
        Me.MessagesPerPageTB.Name = "MessagesPerPageTB"
        Me.MessagesPerPageTB.Size = New System.Drawing.Size(33, 30)
        Me.MessagesPerPageTB.TabIndex = 10012
        '
        'MessagesPreviewForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1595, 698)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MessagesPreviewForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents SendButton As FontAwesome.Sharp.IconButton
    Friend WithEvents RetryButton As FontAwesome.Sharp.IconButton
    Private WithEvents SentLB As Label
    Private WithEvents SentText As Label
    Private WithEvents UnRegisteredText As Label
    Private WithEvents UnRegisteredLB As Label
    Friend WithEvents BackButton As FontAwesome.Sharp.IconButton
    Friend WithEvents NextButton As FontAwesome.Sharp.IconButton
    Private WithEvents PreviewCountLB As Label
    Private WithEvents FailedLB As Label
    Private WithEvents FailedText As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MessagesPerPageTB As TextBox
    Friend WithEvents CurrentCB As CheckBox
    Friend WithEvents AllCB As CheckBox
    Friend WithEvents ImagesPreview As FontAwesome.Sharp.IconButton
End Class
