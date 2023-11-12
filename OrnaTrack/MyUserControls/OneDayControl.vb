Public Class OneDayControl
    Public _kitty As Kitty

    Private Sub Panel1_DoubleClick(sender As Object, e As EventArgs) Handles Panel1.DoubleClick
        Cursor = Cursors.AppStarting
        Using Fm As New PreviewKitty With {
            ._kitty = _kitty
        }
            Fm.ShowDialog()
        End Using
        Cursor = Cursors.Default
    End Sub

End Class
