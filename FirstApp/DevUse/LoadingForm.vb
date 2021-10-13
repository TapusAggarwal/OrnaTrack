Public Class LoadingForm
    ' Prevents Flickering
    'Protected Overrides ReadOnly Property CreateParams As CreateParams
    '    Get
    '        Dim cp As CreateParams = MyBase.CreateParams
    '        cp.ExStyle = cp.ExStyle Or &H2000000
    '        ' Turn on WS_EX_COMPOSITED
    '        Return cp
    '    End Get
    'End Property

    'Public Sub StopAnimation()
    '    Invoke(Sub()
    '               Close()
    '           End Sub)
    'End Sub

    ''Private Sub Me_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ''    Try
    ''        '' Fade in when started
    ''        Me.Opacity = 0
    ''        Dim tmr As New Timer With {
    ''            .Interval = 2
    ''        }
    ''        tmr.Start()
    ''        AddHandler tmr.Tick, Sub()
    ''                                 Try
    ''                                     Me.Opacity += 0.1
    ''                                     If Me.Opacity = 1 Then tmr.Stop()
    ''                                 Catch ex As Exception
    ''                                 End Try
    ''                             End Sub
    ''    Catch ex As Exception
    ''    End Try
    ''End Sub

    ''Private Sub Me_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
    ''    Try
    ''        '' Fade out when closed
    ''        e.Cancel = True
    ''        Me.Opacity = 1
    ''        Dim tmr As New Timer With {
    ''            .Interval = 1
    ''        }
    ''        tmr.Start()
    ''        AddHandler tmr.Tick, Sub()
    ''                                 Me.Opacity -= 0.1
    ''                                 If Me.Opacity = 0 Then
    ''                                     e.Cancel = False
    ''                                     tmr.Stop()
    ''                                     Me.Dispose()
    ''                                 End If
    ''                             End Sub
    ''    Catch ex As Exception
    ''    End Try

    ''End Sub
End Class