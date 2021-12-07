Public Class Form4

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fileURL As String = "https://localhost:3966/get_db"
        Dim fileName As String = My.Computer.FileSystem.GetName(fileURL)
        Try
            My.Computer.Network.DownloadFile(New Uri("https://localhost:3966/get_db"), "C:\Users\hp\Desktop\db1.txt")
        Catch ex As Exception

        End Try
    End Sub
End Class