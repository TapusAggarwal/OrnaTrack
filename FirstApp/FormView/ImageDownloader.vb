Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports WebSocket4Net

Public Class ImageDownloader

    Public Sub UpdateImage(e As MessageReceivedEventArgs)
        Dim req As WebRequest = WebRequest.Create($"http://{My.Settings.connection_url}?purpose=latest_images")
        req.Method = "POST"

        ' Get the response and extract the base64 encoded string
        Dim response As WebResponse = req.GetResponse()
        Dim streamReader As New StreamReader(response.GetResponseStream())
        Dim base64String As String = streamReader.ReadToEnd()

        ' Convert the base64 encoded string to a byte array
        Dim imageBytes As Byte() = Convert.FromBase64String(base64String)

        ' Convert the byte array to an image
        Using memoryStream As New MemoryStream(imageBytes)
            Dim image As Image = Image.FromStream(memoryStream)
            ImageBox.Invoke(Sub()
                                ImageBox.Image = New Bitmap(image)
                            End Sub)
            ' Do something with the image, such as display it
        End Using

    End Sub


    Private Sub ExistingPhNosButton_Click(sender As Object, e As EventArgs) Handles ListenPhNoBT.Click
        If ListenPhNoBT.IconChar = FontAwesome.Sharp.IconChar.EyeSlash Then
            Dim i = My.Settings.ListenerPhNo
            Dim req As WebRequest = WebRequest.Create($"http://{My.Settings.connection_url}?purpose=listen_phno&phno={i}&listen='false'")
            req.Method = "POST"
            req.Timeout = 3000
            Using request As WebResponse = req.GetResponse
                Using reader As New StreamReader(request.GetResponseStream)
                    Dim response As String = reader.ReadToEnd

                    If response = "removed" Then
                        MessageBox.Show($"PhNo:{i} removed As A New Listener", "Success")
                        RemoveHandler fm.NewMessage_Socket, AddressOf UpdateImage
                        My.Settings.ListenerPhNo = i
                        ListenPhNoBT.IconChar = FontAwesome.Sharp.IconChar.EyeSlash
                    Else
                        MessageBox.Show($"Can't Remove PhNo: {i} Either This No. Is Not Registered With Whatsapp Or An Internal Error Occured.")
                    End If
                End Using
            End Using
            ListenPhNoBT.IconChar = FontAwesome.Sharp.IconChar.Eye
        Else
            StartListeningForMessages(My.Settings.ListenerPhNo)
        End If
    End Sub

    Dim fm As Frame = Nothing

    Private Sub StartListeningForMessages(phno As String)

        fm?.ConnectionLabel_Click()


        AddHandler fm.State_Changed,
            Sub(newState, oldState)

                For Each i In phno.Split(",")
                    Dim req As WebRequest = WebRequest.Create($"http://{My.Settings.connection_url}?purpose=listen_phno&phno={i}&listen='true'")
                    req.Method = "POST"
                    req.Timeout = 3000
                    Using request As WebResponse = req.GetResponse
                        Using reader As New StreamReader(request.GetResponseStream)
                            Dim response As String = reader.ReadToEnd

                            If response = "added" Then
                                MessageBox.Show($"PhNo:{i} Added As A New Listener", "Success")
                                AddHandler fm.NewMessage_Socket, AddressOf UpdateImage
                                My.Settings.ListenerPhNo = i
                                ListenPhNoBT.IconChar = FontAwesome.Sharp.IconChar.EyeSlash
                            Else
                                MessageBox.Show($"Can't Add PhNo: {i} Either This No. Is Not Registered With Whatsapp Or An Internal Error Occured.")
                            End If
                        End Using
                    End Using
                Next
            End Sub
    End Sub

    Private Sub ImageDownloader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PhNoTB.Text = My.Settings.ListenerPhNo

        For Each _form As Form In Application.OpenForms
            If TypeOf _form IsNot Frame Then Continue For
            fm = _form
            Exit For
        Next
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim newPhno As String = InputBox($"Enter New PhNo With Country Code Which Will Be Used As A Listener. Add Comma To Add Multiple Numbers).{vbNewLine}Current PhNo: {My.Settings.ListenerPhNo}", "Listener PhNo")
        If newPhno.Length <> 12 Then Exit Sub
        My.Settings.ListenerPhNo = newPhno
        StartListeningForMessages(newPhno)
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If ImageBox.Image IsNot Nothing Then
            SaveFileDialog1.Filter = "JPEG Image|*.jpg|PNG Image|*.png"
            SaveFileDialog1.FileName = "Whatsapp-Image.jpg"
            SaveFileDialog1.ShowDialog()
            If SaveFileDialog1.FileName <> "" Then
                ImageBox.Image.Save(SaveFileDialog1.FileName)
            End If
        End If
    End Sub

    Private Sub ImageDownloader_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            Dim i = My.Settings.ListenerPhNo
            Dim req As WebRequest = WebRequest.Create($"http://{My.Settings.connection_url}?purpose=listen_phno&phno={i}&listen='false'")
            req.Method = "POST"
            req.Timeout = 3000
            Using request As WebResponse = req.GetResponse
                Using reader As New StreamReader(request.GetResponseStream)
                End Using
            End Using
        Catch ex As Exception

        End Try
    End Sub

End Class