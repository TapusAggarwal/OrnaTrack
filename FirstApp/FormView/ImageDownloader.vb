Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports WebSocket4Net

Public Class ImageDownloader

    Public Property SelectedPhNo As String
    Dim fm As Frame = Nothing

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
            If ImageBox.IsHandleCreated Then
                ImageBox.Invoke(Sub()
                                    ImageBox.Image = New Bitmap(image)
                                End Sub)
            End If
            ' Do something with the image, such as display it
        End Using

    End Sub


    Private Async Sub StartListeningForMessages()

        If WebSocket Is Nothing OrElse Not WebSocket.State = WebSocketState.Open Then
            Await fm?.StartServer(False)
        End If

        If WebSocket.State = WebSocketState.Open Then
            For Each i In SelectedPhNo.Split(",")
                If i.Trim = "" Then Continue For
                Dim req As WebRequest = WebRequest.Create($"http://{My.Settings.connection_url}?purpose=listen_phno&phno={i}&listen=true")
                req.Method = "POST"
                req.Timeout = 3000
                Using request As WebResponse = req.GetResponse
                    Using reader As New StreamReader(request.GetResponseStream)
                        Dim response As String = reader.ReadToEnd

                        If response = "added" Then
                            MessageBox.Show($"PhNo:{i} Added As A New Listener", "Success")
                            AddHandler fm.NewMessage_Socket, AddressOf UpdateImage
                            My.Settings.ListenerPhNo = i
                            SelectedPhNo = i
                            UpdateRecentListeners(SelectedPhNo)
                            If FlowLayoutPanel1.IsHandleCreated Then
                                FlowLayoutPanel1.Invoke(Sub()
                                                            LoadRecentListeners()
                                                        End Sub)
                            End If
                            ListenPhNoBT.IconChar = FontAwesome.Sharp.IconChar.EyeSlash
                            ListenPhNoBT.BackColor = Color.Maroon
                            ListenPhNoBT.Text = "Stop"
                        ElseIf response = "removed" Then
                            MessageBox.Show($"PhNo:{i} removed As A New Listener", "Success")
                            RemoveHandler fm.NewMessage_Socket, AddressOf UpdateImage
                            SelectedPhNo = i
                            ListenPhNoBT.IconChar = FontAwesome.Sharp.IconChar.Eye
                            ListenPhNoBT.BackColor = Color.FromArgb(0, 64, 0)
                            ListenPhNoBT.Text = "Start"
                        Else
                            MessageBox.Show($"Can't Add PhNo: {i} Either This No. Is Not Registered With Whatsapp Or An Internal Error Occured.")
                        End If
                    End Using
                End Using
            Next
        End If

    End Sub

    Private Sub LoadRecentListeners()
        Dim dr As OleDb.OleDbDataReader = DataReader("Select RecentListeners From Message_Data Where id=1")
        Dim num As String = ""
        While dr.Read
            num = If(IsDBNull(dr(0)), "", dr(0))
        End While

        SelectedPhNo = num.Split(",").Last

        FlowLayoutPanel1.Controls.Clear()

        For Each i In num.Split(",").Reverse
            If i.Trim = "" Then Continue For

            Dim lbl As New Label With {
                .Font = New Font("Century Gothic", 12.0!, FontStyle.Bold, GraphicsUnit.Point, 0),
                .ForeColor = Color.ForestGreen,
                .Visible = True,
                .AutoSize = True,
                .Text = $"+{i.Substring(0, i.Length - 10)}-" + i.Trim.Substring(i.Length - 10),
                .Tag = i,
                .TabStop = True
            }

            AddHandler lbl.Click, Sub(Sender As Label, e As EventArgs)

                                      For Each _lbl As Label In FlowLayoutPanel1.Controls
                                          If _lbl.Tag.ToString = SelectedPhNo Then
                                              ' set focus to the label
                                              _lbl.BorderStyle = BorderStyle.None
                                              Exit For
                                          End If
                                      Next

                                      SelectedPhNo = Sender.Tag
                                      lbl.BorderStyle = BorderStyle.FixedSingle
                                      lbl.Select()

                                      SelectBT.Visible = True
                                      DeleteBT.Visible = True
                                      CancelEditBT.Visible = True

                                  End Sub

            Invoke(Sub()
                       FlowLayoutPanel1.Controls.Add(lbl)
                   End Sub)
        Next

    End Sub

#Region "Dierct Events"
    Private Sub Select_Click(sender As Object, e As EventArgs) Handles SelectBT.Click

        Dim dr As OleDb.OleDbDataReader = DataReader("Select RecentListeners From Message_Data Where id=1")
        Dim num As String = ""
        While dr.Read
            num = If(IsDBNull(dr(0)), "", dr(0))
        End While

        Dim _list = num.Split(",").ToList
        ' Removing From Current Position
        _list.Remove(SelectedPhNo.Trim)
        ' Adding To Current Position
        _list.Add(SelectedPhNo)

        SqlCommand($"Update Message_Data set RecentListeners='{String.Join(",", _list)}'")
        LoadRecentListeners()

        PhNoTB.Text = SelectedPhNo
        CancelBT_Click(sender, e)
        ListenPhNoBT.IconChar = FontAwesome.Sharp.IconChar.Eye
        ListenPhNoBT.BackColor = Color.FromArgb(0, 64, 0)
        ListenPhNoBT.Text = "Start"
    End Sub

    Private Sub DeleteBT_Click(sender As Object, e As EventArgs) Handles DeleteBT.Click
        UpdateRecentListeners(SelectedPhNo, True)
        CancelBT_Click(sender, e)
        SelectedPhNo = ""
    End Sub

    Private Sub CancelBT_Click(sender As Object, e As EventArgs) Handles CancelEditBT.Click
        SelectBT.Visible = False
        DeleteBT.Visible = False
        CancelEditBT.Visible = False

        For Each lbl As Label In FlowLayoutPanel1.Controls
            If lbl.Tag.ToString = SelectedPhNo Then
                ' set focus to the label
                lbl.BorderStyle = BorderStyle.None
                Exit For
            End If
        Next

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



    Private Sub AddNewListenerBT_Click(sender As Object, e As EventArgs) Handles AddNewListenerBT.Click
        Dim newPhno As String = InputBox($"Enter New PhNo With Country Code Which Will Be Used As A Listener. Add Comma To Add Multiple Numbers).{vbNewLine}Current PhNo: {SelectedPhNo}", "Listener PhNo")
        If newPhno.Length <> 12 Then Exit Sub

        SelectedPhNo = newPhno
        Dim dr As OleDb.OleDbDataReader = DataReader("Select RecentListeners From Message_Data Where id=1")
        Dim num As String = ""
        While dr.Read
            num = If(IsDBNull(dr(0)), "", dr(0))
        End While

        Dim _list = num.Split(",").ToList
        ' Removing From Current Position
        _list.Remove(SelectedPhNo.Trim)
        ' Adding To Current Position
        _list.Add(SelectedPhNo)

        SqlCommand($"Update Message_Data set RecentListeners='{String.Join(",", _list)}'")
        LoadRecentListeners()

        StartListeningForMessages()
    End Sub

    Private Async Sub ImageDownloader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRecentListeners()
        PhNoTB.Text = SelectedPhNo

        For Each _form As Form In Application.OpenForms
            If TypeOf _form IsNot Frame Then Continue For
            fm = _form
            Exit For
        Next

        Dim req As WebRequest = WebRequest.Create($"http://{My.Settings.connection_url}?purpose=phno_listeners")
        req.Method = "POST"
        req.Timeout = 3000
        Using request As WebResponse = req.GetResponse
            Using reader As New StreamReader(request.GetResponseStream)
                Dim response As String = reader.ReadToEnd

                If response.Trim.Length = 0 Then Exit Sub
                PhNoTB.Text = response.Trim
                ListenPhNoBT.IconChar = FontAwesome.Sharp.IconChar.EyeSlash
                ListenPhNoBT.BackColor = Color.Maroon
                ListenPhNoBT.Text = "Stop"

                If WebSocket Is Nothing OrElse Not WebSocket.State = WebSocketState.Open Then
                    Await fm?.StartServer(False)
                End If

                AddHandler fm.NewMessage_Socket, AddressOf UpdateImage

            End Using
        End Using


    End Sub

    Private Sub ListenPhNoBT_Click(sender As Object, e As EventArgs) Handles ListenPhNoBT.Click
        Dim i = SelectedPhNo
        If i = "" Then Exit Sub
        If ListenPhNoBT.IconChar = FontAwesome.Sharp.IconChar.EyeSlash Then
            Dim req As WebRequest = WebRequest.Create($"http://{My.Settings.connection_url}?purpose=listen_phno&phno={i}&listen=false")
            req.Method = "POST"
            req.Timeout = 3000
            Using request As WebResponse = req.GetResponse
                Using reader As New StreamReader(request.GetResponseStream)
                    Dim response As String = reader.ReadToEnd

                    If response = "removed" Then
                        MessageBox.Show($"PhNo:{i} removed As A New Listener", "Success")
                        RemoveHandler fm.NewMessage_Socket, AddressOf UpdateImage
                        ListenPhNoBT.IconChar = FontAwesome.Sharp.IconChar.Eye
                        ListenPhNoBT.BackColor = Color.FromArgb(0, 64, 0)
                        ListenPhNoBT.Text = "Start"
                    Else
                        MessageBox.Show($"Can't Remove PhNo: {i} Either This No. Is Not Registered With Whatsapp Or An Internal Error Occured.")
                    End If
                End Using
            End Using
        Else
            StartListeningForMessages()
        End If
    End Sub

#End Region

    Private Sub UpdateRecentListeners(phno As String, Optional remove As Boolean = False)
        Dim dr As OleDb.OleDbDataReader = DataReader("Select RecentListeners From Message_Data Where id=1")
        Dim num As String = ""
        While dr.Read
            num = If(IsDBNull(dr(0)), "", dr(0))
        End While

        Dim _list = num.Split(",").ToList
        If Not _list.Contains(phno.Trim) Then _list.Add(phno.Trim)
        If remove Then _list.Remove(phno.Trim)

        SqlCommand($"Update Message_Data set RecentListeners='{String.Join(",", _list)}'")
        LoadRecentListeners()
    End Sub

End Class