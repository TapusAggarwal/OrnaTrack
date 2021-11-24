Imports System.IO
Imports System.Net
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Text

Public Class Form4

    'Function: General Function That takes Dictionary Of Commands As Input And Returns Server Respons As String
    Function ServerHttpRequest(Optional requestPrams As Dictionary(Of String, String) = Nothing, Optional request_headres As MultipartFormDataContent = Nothing, Optional _uri As String = "http://localhost:4000") As Task(Of String)

        If requestPrams IsNot Nothing Then
            Dim url = $"{_uri}?"
            For Each comm In requestPrams
                url += $"{comm.Key}={comm.Value}&"
            Next
            _uri = url.Substring(0, url.Length - 1)
        End If

        If String.IsNullOrEmpty(_uri) Then Return Nothing

        Dim client As New HttpClient
        client.DefaultRequestHeaders.Accept.Clear()
        client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

        Try

            Dim response As HttpResponseMessage = client.PostAsync(New Uri(_uri), request_headres).Result

            If response.IsSuccessStatusCode Then
                Dim resposeTask As Task(Of String) = response.Content.ReadAsStringAsync()
                Return resposeTask
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MessageBox.Show($"Error Occurred: While Sending Request To Server: {ex.Message}.", "Exception Thrown", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Async Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Dim request As New MultipartFormDataContent

        request.Add(New StringContent("916239631173"), "phno")
        request.Add(New StringContent("HI thsi is a message"), "msg")
        request.Add(New StringContent(IIf(True, "true", "false")), "hands")
        request.Add(New StreamContent(File.OpenRead("C:\Users\hp\Desktop\Bhagwati jewelers.png")), "tapus", New FileInfo("C:\Users\hp\Desktop\Bhagwati jewelers.png").Name)

        Dim result = ServerHttpRequest(Nothing, request, "http://localhost:4000/upload")
        MessageBox.Show(Await result)
    End Sub
End Class