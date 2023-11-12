<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OneDayControl
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DateLB = New System.Windows.Forms.Label()
        Me.NameLB = New System.Windows.Forms.Label()
        Me.AmtLB = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.DateLB)
        Me.Panel1.Controls.Add(Me.NameLB)
        Me.Panel1.Controls.Add(Me.AmtLB)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(693, 36)
        Me.Panel1.TabIndex = 5
        '
        'DateLB
        '
        Me.DateLB.AutoSize = True
        Me.DateLB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateLB.Location = New System.Drawing.Point(295, 5)
        Me.DateLB.Name = "DateLB"
        Me.DateLB.Size = New System.Drawing.Size(150, 26)
        Me.DateLB.TabIndex = 2
        Me.DateLB.Text = "19-Jun, 2003"
        '
        'NameLB
        '
        Me.NameLB.AutoSize = True
        Me.NameLB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLB.Location = New System.Drawing.Point(3, 5)
        Me.NameLB.Name = "NameLB"
        Me.NameLB.Size = New System.Drawing.Size(165, 26)
        Me.NameLB.TabIndex = 1
        Me.NameLB.Text = "Rama Sharma"
        '
        'AmtLB
        '
        Me.AmtLB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AmtLB.AutoSize = True
        Me.AmtLB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmtLB.Location = New System.Drawing.Point(543, 5)
        Me.AmtLB.Name = "AmtLB"
        Me.AmtLB.Size = New System.Drawing.Size(147, 26)
        Me.AmtLB.TabIndex = 0
        Me.AmtLB.Text = "Cash:+5,000"
        '
        'OneDayControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Name = "OneDayControl"
        Me.Size = New System.Drawing.Size(693, 36)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DateLB As Label
    Friend WithEvents NameLB As Label
    Friend WithEvents AmtLB As Label
End Class
