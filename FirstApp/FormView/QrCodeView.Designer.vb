<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class QrCodeView
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
        Me.QrBox = New System.Windows.Forms.PictureBox()
        CType(Me.QrBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QrBox
        '
        Me.QrBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QrBox.Location = New System.Drawing.Point(0, 0)
        Me.QrBox.Name = "QrBox"
        Me.QrBox.Size = New System.Drawing.Size(433, 431)
        Me.QrBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.QrBox.TabIndex = 0
        Me.QrBox.TabStop = False
        '
        'QrCodeView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(433, 431)
        Me.Controls.Add(Me.QrBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "QrCodeView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Scan The QrCode"
        CType(Me.QrBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents QrBox As PictureBox
End Class
