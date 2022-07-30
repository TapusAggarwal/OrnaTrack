Imports System.IO
Imports System.Net

Public Class webjs
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UpdateImage()
    End Sub

    Public Sub UpdateImage()
        Dim req As WebRequest = WebRequest.Create($"http://{My.Settings.connection_url}?purpose=recent_image")
        req.Method = "POST"
        Using request As WebResponse = req.GetResponse
            Using stream As Stream = request.GetResponseStream
                ImageBox.Image = New Bitmap(Image.FromStream(stream))
            End Using
        End Using
    End Sub

End Class