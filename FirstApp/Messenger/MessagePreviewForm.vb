Imports FirstApp.MessageSender
Imports System.Net.Http
Imports Newtonsoft.Json.Linq
Imports System.IO

Public Class MessagePreviewForm

    Public Property SelectedKitties As New List(Of Kitty)
    Public Property MessagesToSend As New List(Of Tuple(Of String, Kitty))
    Public Property ImagePaths As New List(Of String)
    Public Property SentList As New List(Of String)
    Public Property FailedList As New List(Of String)
    Public Property UnRegisteredList As New List(Of String)
    Public Property RemovedList As New List(Of String)

    Private Property MessageText As String
    Private Property OneTimeControlsValue As Integer = 9
    Public Property CurrentControlsValue As Integer = 0

    Public Function Greet()
        Dim hour As String = TimeOfDay.ToString("hh")
        If TimeOfDay.ToString("tt") = "AM" Then
            Return "Good Morning"
        ElseIf TimeOfDay.ToString("tt") = "PM" _
            And hour >= 5 _
            And hour <= 11 Then
            Return "Good Evening"
        Else
            Return "Good AfterNoon"
        End If
    End Function

    Public Function ReplaceTemplateWithDetails(_kitty As Kitty, _text As String) As String
        _kitty.Initialize(True)
        With _kitty
            _text = _text.Replace(Templates.Greeting, Greet())
            _text = _text.Replace(Templates.CoustName, .Owner.FullName())
            _text = _text.Replace(Templates.CoustPhNo, .Owner.PhNo(","))
            _text = _text.Replace(Templates.KittyType, .KittyType.ToCurrency(True))
            _text = _text.Replace(Templates.KittyNo, .KittyNo)
            _text = _text.Replace(Templates.InstalmentsCompleted, .GetInstalmentsCompleted)

            Dim FirstDate As Date = .Record.First.Key
            Dim InstComp As Integer = .GetInstalmentsCompleted
            Dim InstPending As Integer = .GetInstalmentsPending

            If InstComp = 1 Then
                _text = _text.Replace(Templates.PeriodIntalmentsCompleted, $"{ FirstDate:MMM}({ FirstDate:yyyy})")
            ElseIf InstComp = 2 Then
                _text = _text.Replace(Templates.PeriodIntalmentsCompleted, $"{ FirstDate:MMM}({ FirstDate:yyyy}),{ FirstDate.AddMonths(1):MMM}({ FirstDate.AddMonths(1):yyyy})")
            Else
                _text = _text.Replace(Templates.PeriodIntalmentsCompleted, $"{ FirstDate:MMM}({ FirstDate:yyyy})-{ FirstDate.AddMonths(InstComp - 1):MMM}({ FirstDate.AddMonths(InstComp - 1):yyyy})")
            End If

            _text = _text.Replace(Templates.GivenAmount, .GivenAmount.ToCurrency(True))
            _text = _text.Replace(Templates.InstalmentsPending, InstPending)

            If InstPending = 1 Then
                _text = _text.Replace(Templates.PeriodInstalmentsPending, $"{ FirstDate.AddMonths(InstComp):MMM}({ FirstDate.AddMonths(InstComp):yyyy})")
            ElseIf InstPending = 2 Then
                _text = _text.Replace(Templates.PeriodInstalmentsPending, $"{ FirstDate.AddMonths(InstComp):MMM}({ FirstDate.AddMonths(InstComp):yyyy}),{ FirstDate.AddMonths(InstComp + 1):MMM}({ FirstDate.AddMonths(InstComp + 1):yyyy})")
            Else
                _text = _text.Replace(Templates.PeriodInstalmentsPending, $"{ FirstDate.AddMonths(InstComp):MMM}({ FirstDate.AddMonths(InstComp):yyyy})-{ FirstDate.AddMonths(InstComp + InstPending - 1):MMM}({ FirstDate.AddMonths(InstComp + InstPending - 1):yyyy})")
            End If

            _text = _text.Replace(Templates.PendingAmount, Int(InstPending * .KittyType).ToCurrency(True))

        End With

        Return _text
    End Function

    Private Sub PreviewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        KeyPreview = True

        Dim KittyList As List(Of Integer) = SelectedKitties.Select(Function(m) m.KittyType).Distinct().ToList()
        Dim orderedKitties As New List(Of Kitty)

        KittyList.Sort()
        KittyList.Reverse()

        Dim SrNo As Integer = 0

        For Each type In KittyList
            orderedKitties.AddRange(SelectedKitties.Where(Function(s) s.KittyType = type).OrderBy(Function(g) g.KittyNo))
        Next

        SelectedKitties = orderedKitties

        For Each i In SelectedKitties
            For Each phno In i.Owner.GetPhNo
                MessagesToSend.Add(New Tuple(Of String, Kitty)(phno, i))
            Next
        Next

        SentText.Text = $"0/{MessagesToSend.Count}"

        Try
            Dim msgtxt As String = ""
            Dim imgtxt As String = ""
            Dim dr As OleDb.OleDbDataReader = DataReader("Select MessageText,ImagePaths From Message_Data where id=1")
            While dr.Read
                msgtxt = dr(0)
                imgtxt = dr(1)
            End While
            MessageText = msgtxt
            ImagePaths = imgtxt.Split(",").ToList

            If ImagePaths.Count > 0 Then
                ImagesPreview.Visible = True
            End If

        Catch ex As Exception
        End Try

        Dim x As Integer = -1

        Try
            Dim dr As OleDb.OleDbDataReader = DataReader("Select OneTimeControlValue From Message_Data where id=1")
            While dr.Read
                x = Int(dr(0))
            End While
        Catch ex As Exception
        End Try

        If x > 0 Then OneTimeControlTB.Text = x

        Dim Initial As String = String.Join(",", MessagesToSend.Select(Function(f) $"{f.Item1}_{f.Item2.KittyUID}"))
        SqlCommand($"Update Message_Data set Initial='{Initial}' where id=1")

    End Sub

    Private Sub Close_Clicked(sender As MessagePreviewControl)
        If sender.Status <> "NotSent" Then
            MessageBox.Show("Can't Disable After Message Is Sent.", "Illegal Selection")
            Exit Sub
        End If
        For Each phno In sender.CurrentKitty.Owner.GetPhNo
            Dim id As String = $"{ phno}_{ sender.CurrentKitty.KittyUID}"

            Dim correspondingControl As MessagePreviewControl = FlowLayoutPanel1.Controls.OfType(Of MessagePreviewControl).Where(Function(c) c.Name = id)(0)

            If Not RemovedList.Remove(id) Then
                RemovedList.Add(id)
                If correspondingControl IsNot Nothing Then correspondingControl.Enabled = False
            Else
                If correspondingControl IsNot Nothing Then correspondingControl.Enabled = True
            End If
            FailedList.Remove(id)
            UnRegisteredList.Remove(id)
        Next
        UpdateStatuses()

        SqlCommand($"Update Message_Data set Removed='{String.Join(",", RemovedList)}' where id=1")
        SqlCommand($"Update Message_Data set Failed='{String.Join(",", FailedList)}' where id=1")
        SqlCommand($"Update Message_Data set Sent='{String.Join(",", SentList)}' where id=1")
        SqlCommand($"Update Message_Data set UnRegistered='{String.Join(",", UnRegisteredList)}' where id=1")
    End Sub

    Public Sub ClearPrevious()
        SqlCommand($"Update Message_Data set Removed='' where id=1")
        SqlCommand($"Update Message_Data set Failed='' where id=1")
        SqlCommand($"Update Message_Data set Sent='' where id=1")
        SqlCommand($"Update Message_Data set UnRegistered='' where id=1")
    End Sub

    Private Sub UpdatePreview()

        Dim KittiesToShow As New List(Of Tuple(Of String, Kitty))

        If CurrentControlsValue + OneTimeControlsValue > MessagesToSend.Count Then
            PreviewCountLB.Text = $"{CurrentControlsValue + 1}-{MessagesToSend.Count}/{MessagesToSend.Count}"
            KittiesToShow = MessagesToSend.Skip(CurrentControlsValue).ToList
        Else
            PreviewCountLB.Text = $"{CurrentControlsValue + 1}-{CurrentControlsValue + OneTimeControlsValue}/{MessagesToSend.Count}"
            KittiesToShow = MessagesToSend.Skip(CurrentControlsValue).Take(OneTimeControlsValue).ToList
        End If

        FlowLayoutPanel1.Controls.Clear()

        For Each i In KittiesToShow

            Dim tempKitty As Kitty = i.Item2

            tempKitty.Initialize(True)

            Dim message As String = ReplaceTemplateWithDetails(tempKitty, MessageText)

            Dim x As New MessagePreviewControl With {
                .PhNo = i.Item1,
                .PreviewText = message,
                .CurrentKitty = tempKitty,
                .Name = $"{ .PhNo}_{ .CurrentKitty.KittyUID}",
                .SrNo = MessagesToSend.IndexOf(i) + 1,
                .Status = TryParseStatus(.PhNo, .CurrentKitty.KittyUID)
            }

            If RemovedList.Contains(x.Name) Then x.Enabled = False

            AddHandler x.DetailsButton_Clicked, Sub(sender As MessagePreviewControl)
                                                    Dim Fm As New PreviewKitty With {
                                                        ._kitty = sender.CurrentKitty
                                                    }
                                                    Fm.ShowDialog()
                                                    UpdatePreview()
                                                End Sub
            AddHandler x.CloseBT_Clicked, AddressOf Close_Clicked
            AddHandler x.SendBT_Clicked, Async Sub()
                                             x.Status = "Sending"
                                             Dim id As String = $"{x.PhNo}_{x.CurrentKitty.KittyUID}"
                                             FailedList.Remove(id)
                                             UnRegisteredList.Remove(id)
                                             Dim status As String = ""
                                             If ImagePaths.Count > 0 Then
                                                 status = Await Task.Run(Function()
                                                                             Return SendImage(x.PhNo)
                                                                         End Function)
                                             End If
                                             status = Await SendMessage(x.PhNo, x.CurrentKitty)
                                             UpdateList(x.PhNo, x.CurrentKitty.KittyUID, status)
                                             x.Status = status
                                             UpdateStatuses()
                                         End Sub
            AddHandler x.TestMessageClicked, Async Sub(sender)
                                                 Dim phno As String = InputBox("Enter Phone Number For Test Messsage.")
                                                 Dim result As String = Await SendMessage(phno, sender.CurrentKitty)
                                                 MessageBox.Show(result)
                                             End Sub
            FlowLayoutPanel1.Controls.Add(x)
        Next

        UpdateStatuses()

    End Sub

    Private Sub UpdateList(phNo As String, kittyUID As Integer, status As String)
        Dim id As String = $"{phNo}_{kittyUID}"
        Select Case status
            Case "fail"
                FailedList.Add(id)
                FailedList = FailedList.Distinct.ToList
                SqlCommand($"Update Message_Data set Failed='{String.Join(",", FailedList)}' where id=1")
            Case "pass"
                SentList.Add(id)
                SentList = SentList.Distinct.ToList
                SqlCommand($"Update Message_Data set Sent='{String.Join(",", SentList)}' where id=1")
            Case Else
                UnRegisteredList.Add(id)
                UnRegisteredList = UnRegisteredList.Distinct.ToList
                SqlCommand($"Update Message_Data set UnRegistered='{String.Join(",", UnRegisteredList)}' where id=1")
        End Select
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        If CurrentControlsValue - OneTimeControlsValue >= 0 Then CurrentControlsValue -= OneTimeControlsValue
        SqlCommand($"Update Message_Data set CurrentControlsValue='{CurrentControlsValue}' where id=1")
        UpdatePreview()
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        If CurrentControlsValue + OneTimeControlsValue < MessagesToSend.Count Then CurrentControlsValue += OneTimeControlsValue
        SqlCommand($"Update Message_Data set CurrentControlsValue='{CurrentControlsValue}' where id=1")
        UpdatePreview()
    End Sub

    Public Async Function SendImage(phno As String, Optional Paths As List(Of String) = Nothing) As Task(Of String)
        For Each imgPath As String In If(Paths, ImagePaths)

            If imgPath.Replace(" ", "").Length < 1 Then Exit For

            Dim request As New MultipartFormDataContent From {
                {New StringContent("91" + phno.Trim), "phno"},
                {New StringContent(""), "msg"},
                {New StreamContent(File.OpenRead(imgPath)), "image", New FileInfo(imgPath).Name}
            }

            Dim ResponseString As String = Await ServerHttpRequest(Nothing, request, $"http://{My.Settings.connection_url}/upload")

            If ResponseString IsNot Nothing Then
                Dim response As JObject = JObject.Parse(ResponseString)
                Select Case response.SelectToken("result").ToString
                    Case "fail"
                        Return "fail"
                    Case "pass"
                        Continue For
                    Case Else
                        Return "UnRegistered"
                End Select
            Else
                Return "NoResponse"
            End If

        Next

        Return "pass"

    End Function

    Public Async Function SendMessage(phno As String, _kitty As Kitty, Optional msgList As List(Of String) = Nothing) As Task(Of String)
        Dim MessageList As List(Of String) = Split(MessageText, $"{Environment.NewLine}{Environment.NewLine}<Next Message>{Environment.NewLine}{Environment.NewLine}").ToList
        MessageList = If(msgList, MessageList)
        For Each msg In MessageList

            msg = ReplaceTemplateWithDetails(_kitty, msg)

            If msg.Replace(" ", "").Length < 1 Then Exit For

            Dim request As New MultipartFormDataContent From {
                {New StringContent("91" + phno.Trim), "phno"},
                {New StringContent(msg.Replace("{hands}", "")), "msg"},
                {New StringContent(IIf(msg.Contains("{hands}"), "true", "false")), "hands"}
            }

            Dim ResponseString As String = Await ServerHttpRequest(Nothing, request, $"http://{My.Settings.connection_url}/upload")

            If ResponseString IsNot Nothing Then
                Dim response As JObject = JObject.Parse(ResponseString)
                Select Case response.SelectToken("result").ToString
                    Case "fail"
                        Return "fail"
                    Case "pass"
                        Continue For
                    Case Else
                        Return "UnRegistered"
                End Select
            Else
                Return "NoResponse"
            End If

        Next

        Return "pass"

    End Function

    Private Async Sub SendButton_Click(sender As Object, e As EventArgs) Handles SendButton.Click
        Panel1.Enabled = False
        Dim MessagesToSend As New List(Of Tuple(Of String, Kitty))

        If AllCB.Checked Then
            MessagesToSend = Me.MessagesToSend
        Else
            If CurrentControlsValue + OneTimeControlsValue > Me.MessagesToSend.Count Then
                MessagesToSend = Me.MessagesToSend.Skip(CurrentControlsValue).ToList
            Else
                MessagesToSend = Me.MessagesToSend.Skip(CurrentControlsValue).Take(OneTimeControlsValue).ToList
            End If
        End If

        For Each msg In MessagesToSend
            If msg.Item1.Length < 9 Then Continue For
            Dim id As String = $"{msg.Item1}_{msg.Item2.KittyUID}"
            If RemovedList.Contains(id) Then Continue For
            If SentList.Contains(id) Then Continue For
            Dim message As String = ReplaceTemplateWithDetails(msg.Item2, MessageText)
            Dim status As String = Await SendMessage(msg.Item1, msg.Item2)
            UpdateList(msg.Item1, msg.Item2.KittyUID, status)
            UpdateStatuses()
            Try
                Dim correspondingControl As MessagePreviewControl = FlowLayoutPanel1.Controls.OfType(Of MessagePreviewControl).Where(Function(c) c.Name = id)(0)
                correspondingControl.Status = "Sending"
                correspondingControl.Status = status
            Catch ex As Exception
            End Try
        Next
        Panel1.Enabled = True
    End Sub

    Private Function TryParseStatus(phno As String, kittyUID As Integer)
        Dim id As String = $"{phno}_{kittyUID}"
        If SentList.Contains(id) Then Return "pass"
        If FailedList.Contains(id) Then Return "fail"
        If UnRegisteredList.Contains(id) Then Return "UnRegistered"
        Return "NotSent"
    End Function

    Private Sub OneTimeControlTB_TextChanged(sender As Object, e As EventArgs) Handles OneTimeControlTB.TextChanged
        Dim x As Integer = -1
        Try
            x = OneTimeControlTB.Text
        Catch ex As Exception
        End Try

        If x > 0 Then
            OneTimeControlsValue = x
            CurrentControlsValue = OneTimeControlsValue * Int(CurrentControlsValue / OneTimeControlsValue)
            SqlCommand($"Update Message_Data set CurrentControlsValue='{CurrentControlsValue}' where id=1")
            UpdatePreview()
        End If
        SqlCommand($"Update Message_Data set OneTimeControlValue={x} where id=1")
    End Sub

    Private Sub UpdateStatuses()
        SentText.Text = $"{SentList.Count}/{MessagesToSend.Count - RemovedList.Count}"

        If UnRegisteredList.Count > 0 Then
            UnRegisteredLB.Visible = True
            UnRegisteredText.Visible = True
            UnRegisteredText.Text = UnRegisteredList.Count
        Else
            UnRegisteredLB.Visible = False
            UnRegisteredText.Visible = False
        End If

        If FailedList.Count > 0 Then
            FailedLB.Visible = True
            FailedText.Visible = True
            FailedText.Text = FailedList.Count
        Else
            FailedLB.Visible = False
            FailedText.Visible = False
        End If

        If AllCB.Checked Then
            If SentList.Count + UnRegisteredList.Count + FailedList.Count + RemovedList.Count = MessagesToSend.Count Then
                SendButton.Enabled = False
            Else
                SendButton.Enabled = True
            End If
        Else
            Dim CurrentMessages As New List(Of Tuple(Of String, Kitty))

            If CurrentControlsValue + OneTimeControlsValue > MessagesToSend.Count Then
                CurrentMessages = MessagesToSend.Skip(CurrentControlsValue).ToList
            Else
                CurrentMessages = MessagesToSend.Skip(CurrentControlsValue).Take(OneTimeControlsValue).ToList
            End If

            Dim enbl As Boolean = False

            For Each msg In CurrentMessages
                Dim id As String = $"{msg.Item1}_{msg.Item2.KittyUID}"
                If RemovedList.Contains(id) Then Continue For
                If SentList.Contains(id) Then Continue For
                If UnRegisteredList.Contains(id) Then Continue For
                If FailedList.Contains(id) Then Continue For

                enbl = True
                Exit For
            Next

            If CurrentMessages.Count > 0 Then
                If enbl Then
                    SendButton.Enabled = True
                Else
                    SendButton.Enabled = False
                End If
            End If
        End If

    End Sub

    Private Sub RetryButton_Click(sender As Object, e As EventArgs) Handles RetryButton.Click
        If SendButton.Enabled <> False Then
            MessageBox.Show("First Send Message To All Selected Kitties. To Be Able To Retry.", "Illegal Selection")
            Exit Sub
        End If
        If AllCB.Checked Then
            UnRegisteredList.Clear()
            FailedList.Clear()
            UpdateStatuses()
            SendButton.PerformClick()
        Else

        End If
    End Sub

    Private Sub AllCB_CheckedChanged(sender As Object, e As EventArgs) Handles AllCB.CheckedChanged
        If AllCB.Checked = False And CurrentCB.Checked = False Then
            AllCB.Checked = True
        End If
        UpdateStatuses()
        CurrentCB.Checked = False
    End Sub

    Private Sub CurrentCB_CheckedChanged(sender As Object, e As EventArgs) Handles CurrentCB.CheckedChanged
        If AllCB.Checked = False And CurrentCB.Checked = False Then
            CurrentCB.Checked = True
        End If
        UpdateStatuses()
        AllCB.Checked = False
    End Sub

    Private Sub OneTimeControlTB_KeyDown(sender As Object, e As KeyEventArgs) Handles OneTimeControlTB.KeyDown
        If e.Shift And e.KeyCode = Keys.Enter Then
            Try
                Dim x As String = InputBox("Enter No. To Jump Upon", "?")
                CurrentControlsValue = OneTimeControlsValue * Int(x / OneTimeControlsValue)
                SqlCommand($"Update Message_Data set CurrentControlsValue='{CurrentControlsValue}' where id=1")
                UpdatePreview()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub PreviewForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Right Then
            NextButton.PerformClick()
        ElseIf e.KeyCode = Keys.Left Then
            BackButton.PerformClick()
        End If
    End Sub

    Private Sub ImagesPreview_Click(sender As Object, e As EventArgs) Handles ImagesPreview.Click
        Dim Fm As New Form

    End Sub
End Class