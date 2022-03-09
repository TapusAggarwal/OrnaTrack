<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.CmdTB = New System.Windows.Forms.TextBox()
        Me.RunBT = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.StartBT = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CmdTB
        '
        Me.CmdTB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdTB.Location = New System.Drawing.Point(68, 38)
        Me.CmdTB.Name = "CmdTB"
        Me.CmdTB.Size = New System.Drawing.Size(549, 26)
        Me.CmdTB.TabIndex = 0
        '
        'RunBT
        '
        Me.RunBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RunBT.Location = New System.Drawing.Point(447, 336)
        Me.RunBT.Name = "RunBT"
        Me.RunBT.Size = New System.Drawing.Size(195, 67)
        Me.RunBT.TabIndex = 1
        Me.RunBT.Text = "Run"
        Me.RunBT.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.Location = New System.Drawing.Point(68, 70)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(549, 260)
        Me.RichTextBox1.TabIndex = 4
        Me.RichTextBox1.Text = ""
        '
        'StartBT
        '
        Me.StartBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.StartBT.Location = New System.Drawing.Point(45, 336)
        Me.StartBT.Name = "StartBT"
        Me.StartBT.Size = New System.Drawing.Size(195, 67)
        Me.StartBT.TabIndex = 5
        Me.StartBT.Text = "Start"
        Me.StartBT.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(246, 336)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(195, 67)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Cmd"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.StartBT)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.RunBT)
        Me.Controls.Add(Me.CmdTB)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmdTB As TextBox
    Friend WithEvents RunBT As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents StartBT As Button
    Friend WithEvents Button1 As Button
End Class
