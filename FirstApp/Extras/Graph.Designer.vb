<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Graph
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel2019 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel2020 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel2021 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel2022 = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(627, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(627, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(627, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Label3"
        '
        'FlowLayoutPanel2019
        '
        Me.FlowLayoutPanel2019.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel2019.AutoScroll = True
        Me.FlowLayoutPanel2019.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel2019.Location = New System.Drawing.Point(6, 5)
        Me.FlowLayoutPanel2019.Name = "FlowLayoutPanel2019"
        Me.FlowLayoutPanel2019.Size = New System.Drawing.Size(143, 439)
        Me.FlowLayoutPanel2019.TabIndex = 4
        '
        'FlowLayoutPanel2020
        '
        Me.FlowLayoutPanel2020.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel2020.AutoScroll = True
        Me.FlowLayoutPanel2020.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel2020.Location = New System.Drawing.Point(159, 5)
        Me.FlowLayoutPanel2020.Name = "FlowLayoutPanel2020"
        Me.FlowLayoutPanel2020.Size = New System.Drawing.Size(143, 439)
        Me.FlowLayoutPanel2020.TabIndex = 5
        '
        'FlowLayoutPanel2021
        '
        Me.FlowLayoutPanel2021.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel2021.AutoScroll = True
        Me.FlowLayoutPanel2021.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel2021.Location = New System.Drawing.Point(312, 5)
        Me.FlowLayoutPanel2021.Name = "FlowLayoutPanel2021"
        Me.FlowLayoutPanel2021.Size = New System.Drawing.Size(143, 439)
        Me.FlowLayoutPanel2021.TabIndex = 6
        '
        'FlowLayoutPanel2022
        '
        Me.FlowLayoutPanel2022.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel2022.AutoScroll = True
        Me.FlowLayoutPanel2022.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel2022.Location = New System.Drawing.Point(465, 5)
        Me.FlowLayoutPanel2022.Name = "FlowLayoutPanel2022"
        Me.FlowLayoutPanel2022.Size = New System.Drawing.Size(143, 439)
        Me.FlowLayoutPanel2022.TabIndex = 7
        '
        'Graph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(916, 450)
        Me.Controls.Add(Me.FlowLayoutPanel2022)
        Me.Controls.Add(Me.FlowLayoutPanel2021)
        Me.Controls.Add(Me.FlowLayoutPanel2020)
        Me.Controls.Add(Me.FlowLayoutPanel2019)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Graph"
        Me.Text = "Graph"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents FlowLayoutPanel2019 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2020 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2021 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2022 As FlowLayoutPanel
End Class
