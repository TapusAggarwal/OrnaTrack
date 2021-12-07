Imports System.IO
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports Newtonsoft.Json.Linq

Public Class Messenger
    ReadOnly MessageImgs_Dict As New Dictionary(Of String, List(Of String))
    ReadOnly MessageImgs_List As New List(Of Bitmap)

    Private Async Sub MakeBills()
        Dim Fm As New KittyRecievedReciept
        Panel1.Controls.Add(Fm.Panel1)

        Dim SrNo As Integer = 1
        For Each _kitty As Kitty In Tag
            For Each _no In _kitty.Owner.GetPhNo
                With Fm
                    .RecieptDate = _kitty.Record.Last.Key
                    .KittyNo = _kitty.KittyNo
                    .CustomerName = _kitty.Owner.FullName()
                    .PhNo = $"+91{_no}"
                    If _no.Length = 0 Then .PhNo = "UnKnown"
                    .AmountRecieved = _kitty.Record.Last.Value
                    .AmountBeforePayment = _kitty.GivenAmount - _kitty.Record.Last.Value
                    .Total = _kitty.GivenAmount
                    .First_Month = _kitty.Record.First.Key
                    .CompletedTill_Month = _kitty.Record.First.Key.AddMonths(_kitty.GetInstalmentsCompleted - 1)
                    .Status = _kitty.GetInstalmentsPending
                    .BarCodeData = $"{ _kitty.KittyUID}000{ _kitty.Owner.CustomerID}000{New Random(_kitty.GivenAmount).Next}"
                End With
                Await Task.Delay(500)
                ClickMe(_no, SrNo)
                SrNo += 1
            Next
        Next
        Panel1.Visible = False
        ImgBox.Visible = True
        ImgBox.Image = MessageImgs_List(0)
        If MessageImgs_List.Count > 1 Then
            NextButton.Visible = True
            BackButton.Visible = True
        Else
            NextButton.Visible = False
            BackButton.Visible = False
        End If
        CloseButton.Visible = True
        SendButton.Enabled = True
        'ServerCall(state)
    End Sub

    Private Sub ClickMe(PhNo As String, SrNo As Integer)
        Dim tmpImg As New Bitmap(Panel1.Width, Panel1.Height)
        Using g As Graphics = Graphics.FromImage(tmpImg)
            g.CopyFromScreen(Panel1.PointToScreen(New Point(0, 0)), New Point(0, 0),
                             New Size(Panel1.Width, Panel1.Height))
        End Using
        Dim path As String = $"C:\Users\hp\Desktop\Bills\{PhNo}_{SrNo}.jpg"
        tmpImg.Save(path)

        If MessageImgs_Dict.ContainsKey(PhNo) Then
            MessageImgs_Dict.Item(PhNo).Add(path)
        Else
            MessageImgs_Dict.Add(PhNo, New List(Of String)({path}))
        End If
        MessageImgs_List.Add(tmpImg)
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        Try
            With MessageImgs_List
                ImgBox.Image = MessageImgs_List(.IndexOf(ImgBox.Image) + 1)
            End With
        Catch
        End Try
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Try
            With MessageImgs_List
                ImgBox.Image = MessageImgs_List(.IndexOf(ImgBox.Image) - 1)
            End With
        Catch
        End Try
    End Sub

    Public Sub ServerCall(recievedData As String)
        Try
            If recievedData = "qr" Then
                WarningLabel.Visible = True : SendButton.Enabled = False : SendButton.UseWaitCursor = True
            Else
                WarningLabel.Visible = False : SendButton.Enabled = True : SendButton.UseWaitCursor = False
            End If

            'If recievedData.SelectToken("webReady") = "False" Then
            '    QrBox.Invoke(Sub()
            '                     QrBox.Visible = True : MessageTB.Visible = False : WarningLabel.Visible = True : SendButton.Enabled = False : SendButton.UseWaitCursor = True
            '                 End Sub)
            '    Dim gen As New QRCodeGenerator
            '    Dim data = gen.CreateQrCode(recievedData.SelectToken("qrData").ToString, QRCodeGenerator.ECCLevel.Q)
            '    Dim code As New QRCode(data)
            '    QrBox.Image = code.GetGraphic(10)
            'ElseIf recievedData.SelectToken("webReady") = "True" Then
            '    MessageTB.Invoke(Sub()
            '                         QrBox.Visible = False : MessageTB.Visible = True : WarningLabel.Visible = False : SendButton.Enabled = True : SendButton.UseWaitCursor = False
            '                     End Sub)
            '    webReady = True
            'End If
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try
    End Sub

    Private Sub DissolveButton_Click_1(sender As Object, e As EventArgs) Handles CloseButton.Click
        Close()
    End Sub

    Private Async Sub GlobalKittyBillView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageTB.Text = "Thank You"
        Panel1.Size = KittyRecievedReciept.Size
        Cursor.Hide()
        Await Task.Delay(500)
        If Tag IsNot Nothing Then MakeBills()
        Cursor.Show()
    End Sub

    Private Async Sub SendButton_Click(sender As Object, e As EventArgs) Handles SendButton.Click
        FlowLayoutPanel1.Controls.Clear()
        With Me
            .Cursor = Cursors.AppStarting
            .Refresh()
        End With
        SendButton.Enabled = False
        For Each _entry In MessageImgs_Dict
            For Each imgPath In _entry.Value

                Dim request As New MultipartFormDataContent From {
                    {New StringContent("91" + _entry.Key.Trim), "phno"},
                    {New StringContent(MessageTB.Text), "msg"},
                    {New StringContent(IIf(HandsCheckBox.Checked, "true", "false")), "hands"}
                }

                If SendRecieptCB.Checked Then
                    request.Add(New StreamContent(File.OpenRead(imgPath)), "image", New FileInfo(imgPath).Name)
                End If

                Dim ResponseString As String = Await ServerHttpRequest(Nothing, request, $"http://{My.Settings.connection_url}/upload")
                If ResponseString IsNot Nothing Then
                    Dim response As JObject = JObject.Parse(ResponseString)

                    Dim _temp As New Label With {
                        .Font = MessageResultLB.Font,
                        .Visible = True,
                        .AutoSize = True
                    }

                    If response.SelectToken("result").ToString = "pass" Then
                        _temp.ForeColor = Color.ForestGreen
                        _temp.Text = $"+{_entry.Key.Trim}: Sent"
                    ElseIf response.SelectToken("result").ToString = "fail" Then
                        _temp.ForeColor = Color.Firebrick
                        _temp.Text = $"+{_entry.Key.Trim}: Failed"
                    Else
                        _temp.ForeColor = Color.Firebrick
                        _temp.Text = $"+{_entry.Key.Trim}: NotRegistered"
                    End If
                    FlowLayoutPanel1.Controls.Add(_temp)
                End If

            Next
        Next

        With Me
            .Cursor = Cursors.Default
            .Refresh()
        End With
        SendButton.Enabled = True
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles SendRecieptCB.CheckedChanged
        If SendRecieptCB.Checked Then
            Panel1.Enabled = True
            ImgBox.Enabled = True
            NextButton.Enabled = True
            BackButton.Enabled = True
            SendButton.Text = "Send Receipt"
            Try
                ImgBox.Image = MessageImgs_List(0)
            Catch ex As Exception
            End Try
        Else
            Panel1.Enabled = False
            ImgBox.Enabled = False
            NextButton.Enabled = False
            BackButton.Enabled = False
            Dim OrignalImage As New Bitmap(ImgBox.Image)
            Dim BlackAndWhite As New Bitmap(OrignalImage.Width, OrignalImage.Height)

            For i As Integer = 0 To OrignalImage.Width - 1
                For y As Integer = 0 To OrignalImage.Height - 1
                    Dim c As Color = OrignalImage.GetPixel(i, y)
                    Dim sum As Integer = Int(c.R) + Int(c.B) + Int(c.G)
                    Dim av As Integer = sum / 3
                    Dim v As Color = Color.FromArgb(c.A, av, av, av)
                    BlackAndWhite.SetPixel(i, y, v)
                Next
            Next

            ImgBox.Image = BlackAndWhite
            SendButton.Text = "Send Message"
        End If
    End Sub
End Class