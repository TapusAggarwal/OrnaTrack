Imports System.IO
Imports Newtonsoft.Json.Linq

Public Class Messenger

    Dim MessageImgs_Dict As New Dictionary(Of String, List(Of String))
    Dim MessageImgs_List As New List(Of Bitmap)

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

    Private Sub SendButton_Click(sender As Object, e As EventArgs) Handles SendButton.Click
        With Me
            .Cursor = Cursors.AppStarting
            .Refresh()
        End With
        For Each _entry In MessageImgs_Dict
            For Each img In _entry.Value

                Dim dict As New Dictionary(Of String, String) From {
                        {"purpose", "wts_msg"},
                        {"phno", "91" + _entry.Key.Trim},
                        {"msg", MessageTB.Text},
                        {"hands", IIf(HandsCheckBox.Checked, "true", "false")},
                        {"img", img}
                        }

                Dim ResponseString As String = ServerHttpRequest(dict)
                If ResponseString IsNot Nothing Then
                    Dim response As JObject = JObject.Parse(ResponseString)

                    Dim _temp As New Label With {
                        .Font = MessageResultLB.Font,
                        .Visible = True,
                        .AutoSize = True
                    }

                    If response.SelectToken("result").ToString = "pass" Then
                        _temp.ForeColor = Color.ForestGreen
                        _temp.Text = $"+{dict.Item("phno")}: Sent"
                    ElseIf response.SelectToken("result").ToString = "fail" Then
                        _temp.ForeColor = Color.Firebrick
                        _temp.Text = $"+{dict.Item("phno")}: Failed"
                    Else
                        _temp.ForeColor = Color.Firebrick
                        _temp.Text = $"+{dict.Item("phno")}: NotRegistered"
                    End If
                    FlowLayoutPanel1.Controls.Add(_temp)
                End If

            Next
        Next

        With Me
            .Cursor = Cursors.Default
            .Refresh()
        End With

    End Sub
End Class