Imports FirstApp.MessageSender
Imports System.Net.Http
Imports Newtonsoft.Json.Linq
Imports System.IO
Imports System.Data.OleDb
Imports System.Windows.Interop

Public Class MessagesPreviewForm

    Public Property MessagesToSend As New List(Of Tuple(Of String, Kitty))
    Public Property ImagePaths As New List(Of String)

    Public Property SentList As New List(Of String)
    Public Property FailedList As New List(Of String)
    Public Property UnRegisteredList As New List(Of String)
    Public Property RemovedList As New List(Of String)

    Private Property MessageText As String
    Private Property MessagesPerPage As Integer = 9
    Public Property CurrentMsgSetStartIndex As Integer = 0


#Region "Load Data"
    Private Function LoadList(listName As String) As List(Of String)
        Dim result As New List(Of String)

        Dim dr As OleDbDataReader = DataReader("SELECT " & listName & " FROM Message_Data WHERE id = 1")
        While dr.Read()
            Dim values = dr(0).ToString().Split(",")
            For Each value In values
                If value.Length > 10 Then result.Add(value)
            Next
        End While

        dr.Close()

        Return result
    End Function

    Private Sub LoadData()

        SentList = LoadList("Sent")
        FailedList = LoadList("Failed")
        UnRegisteredList = LoadList("UnRegistered")
        RemovedList = LoadList("Removed")


        For Each i In LoadList("Initial") ' i is in the form -> PhNo_KittyNo
            MessagesToSend.Add(New Tuple(Of String, Kitty)(i.Split("_")(0), New Kitty(i.Split("_")(1), True, True)))
        Next

        Dim _dr As OleDbDataReader = DataReader("Select MessageText,ImagePaths From Message_Data where id=1")
        While _dr.Read
            MessageText = _dr(0)?.ToString()
            ImagePaths = _dr(1)?.ToString().Split(",").ToList
        End While
        _dr.Close()

        Dim dr As OleDbDataReader = DataReader("Select CurrentSetStartIndex,MessagesPerPage From Message_Data where id=1")
        While dr.Read
            If Not IsDBNull(dr(0)) AndAlso dr(0) > 0 Then
                CurrentMsgSetStartIndex = dr(0)
            End If
            If Not IsDBNull(dr(1)) AndAlso dr(1) > 0 Then
                MessagesPerPageTB.Text = dr(1).ToString()
            End If
        End While
        dr.Close()

    End Sub
#End Region

    Private Sub PreviewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        KeyPreview = True

        LoadData()
        ' OneTimeControlTB.Text will be Updated In The Above Function Which Will Trigger The EventHandler To Call PopulatePreviewcontrolWithCurrentSettings()
        If ImagePaths.Count > 0 Then ImagesPreview.Visible = True

    End Sub

#Region "Routines For Preview-Msg Control"

    'Cross Button Clicked On The Preview Control
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

        SqlCommand($"Update Message_Data set Removed='{String.Join(",", RemovedList)}' where id=1")
        SqlCommand($"Update Message_Data set Failed='{String.Join(",", FailedList)}' where id=1")
        SqlCommand($"Update Message_Data set Sent='{String.Join(",", SentList)}' where id=1")
        SqlCommand($"Update Message_Data set UnRegistered='{String.Join(",", UnRegisteredList)}' where id=1")

        UpdateStatuses()
    End Sub

    Private Async Sub PopulatePreviewcontrolWithCurrentSettings()

        NextButton.Enabled = False
        BackButton.Enabled = False
        MessagesPerPageTB.Enabled = False

        Dim KittiesToShow As List(Of Tuple(Of String, Kitty))

        ' Check if the current index plus messages per page is coming out to be greater than the total number of messages in the list
        If CurrentMsgSetStartIndex + MessagesPerPage > MessagesToSend.Count Then
            PreviewCountLB.Text = $"{CurrentMsgSetStartIndex + 1}-{MessagesToSend.Count}/{MessagesToSend.Count}"
            ' Get a list of the remaining messages in the list starting from the current index
            KittiesToShow = MessagesToSend.Skip(CurrentMsgSetStartIndex).ToList
        Else
            PreviewCountLB.Text = $"{CurrentMsgSetStartIndex + 1}-{CurrentMsgSetStartIndex + MessagesPerPage}/{MessagesToSend.Count}"
            ' Get a list of messages per page starting from the current index
            KittiesToShow = MessagesToSend.Skip(CurrentMsgSetStartIndex).Take(MessagesPerPage).ToList
        End If

        Dim T_controls = TaskOfPreviewControls(KittiesToShow)

        If T_controls Is Nothing Or T_controls.Count = 0 Then Exit Sub

        FlowLayoutPanel1.Controls.Clear()
        Dim _controls = Await Task.WhenAll(T_controls)

        FlowLayoutPanel1.Invoke(Sub()
                                    FlowLayoutPanel1.Controls.Clear()
                                    FlowLayoutPanel1.Controls.AddRange(_controls)
                                End Sub)


        UpdateStatuses()

        NextButton.Enabled = True
        BackButton.Enabled = True
        MessagesPerPageTB.Enabled = True

    End Sub

    Private Function TaskOfPreviewControls(_kittiesToShow As List(Of Tuple(Of String, Kitty))) As List(Of Task(Of MessagePreviewControl))
        Dim _controlsList As New List(Of Task(Of MessagePreviewControl))

        For Each i In _kittiesToShow
            _controlsList.Add(Task.Run(Function()
                                           Dim message As String = ReplaceTemplateWithDetails(i.Item2, MessageText)

                                           Dim x As MessagePreviewControl = Nothing
                                           FlowLayoutPanel1.Invoke(Sub()
                                                                       x = New MessagePreviewControl With {
                                                                        .PhNo = i.Item1,
                                                                        .PreviewText = message,
                                                                        .CurrentKitty = i.Item2,
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
                                                                                                               PopulatePreviewcontrolWithCurrentSettings()
                                                                                                           End Sub
                                                                       AddHandler x.CloseBT_Clicked, AddressOf Close_Clicked
                                                                       AddHandler x.SendBT_Clicked, Async Sub()
                                                                                                        x.Status = "Sending"
                                                                                                        Dim id As String = $"{x.PhNo}_{x.CurrentKitty.KittyUID}"
                                                                                                        FailedList.Remove(id)
                                                                                                        UnRegisteredList.Remove(id)
                                                                                                        Dim status As String = ""
                                                                                                        Dim MessageList As List(Of String) = Split(message, $"{Environment.NewLine}{Environment.NewLine}<Next Message>{Environment.NewLine}{Environment.NewLine}").ToList
                                                                                                        Dim _resp As JObject = Await UniversalWhatsappMessageBundle(x.PhNo, MessageList, ImagePaths)
                                                                                                        If _resp IsNot Nothing Then status = _resp.SelectToken("result").ToString
                                                                                                        UpdateList(x.PhNo, x.CurrentKitty.KittyUID, status)
                                                                                                        x.Status = status
                                                                                                        UpdateStatuses()
                                                                                                    End Sub
                                                                       AddHandler x.TestMessageClicked, Async Sub(sender)
                                                                                                            Dim phno As String = InputBox("Enter Phone Number For Test Messsage.")
                                                                                                            Dim MessageList As List(Of String) = Split(message, $"{Environment.NewLine}{Environment.NewLine}<Next Message>{Environment.NewLine}{Environment.NewLine}").ToList
                                                                                                            Dim _resp As JObject = Await UniversalWhatsappMessageBundle(x.PhNo, MessageList, ImagePaths)
                                                                                                            MessageBox.Show(_resp.ToString)
                                                                                                        End Sub
                                                                   End Sub)

                                           Return x
                                       End Function))

        Next

        Return _controlsList
    End Function


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

    Private Function TryParseStatus(phno As String, kittyUID As Integer)
        Dim id As String = $"{phno}_{kittyUID}"
        If SentList.Contains(id) Then Return "pass"
        If FailedList.Contains(id) Then Return "fail"
        If UnRegisteredList.Contains(id) Then Return "UnRegistered"
        Return "NotSent"
    End Function


    Private WithEvents UpdateTimer As New Timer With {.Interval = 500, .Enabled = False} ' Delay of 500m

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        If CurrentMsgSetStartIndex - MessagesPerPage >= 0 Then CurrentMsgSetStartIndex -= MessagesPerPage
        SqlCommand($"Update Message_Data set CurrentSetStartIndex='{CurrentMsgSetStartIndex}' where id=1")


        If CurrentMsgSetStartIndex + MessagesPerPage > MessagesToSend.Count Then
            PreviewCountLB.Text = $"{CurrentMsgSetStartIndex + 1}-{MessagesToSend.Count}/{MessagesToSend.Count}"
        Else
            PreviewCountLB.Text = $"{CurrentMsgSetStartIndex + 1}-{CurrentMsgSetStartIndex + MessagesPerPage}/{MessagesToSend.Count}"
        End If

        UpdateTimer.Stop()
        UpdateTimer.Start()
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        If CurrentMsgSetStartIndex + MessagesPerPage < MessagesToSend.Count Then CurrentMsgSetStartIndex += MessagesPerPage
        SqlCommand($"Update Message_Data set CurrentSetStartIndex='{CurrentMsgSetStartIndex}' where id=1")
        If CurrentMsgSetStartIndex + MessagesPerPage > MessagesToSend.Count Then
            PreviewCountLB.Text = $"{CurrentMsgSetStartIndex + 1}-{MessagesToSend.Count}/{MessagesToSend.Count}"
        Else
            PreviewCountLB.Text = $"{CurrentMsgSetStartIndex + 1}-{CurrentMsgSetStartIndex + MessagesPerPage}/{MessagesToSend.Count}"
        End If

        UpdateTimer.Stop()
        UpdateTimer.Start()

    End Sub

    Private Sub UpdateTimer_Tick(sender As Object, e As EventArgs) Handles UpdateTimer.Tick
        UpdateTimer.Stop()
        PopulatePreviewcontrolWithCurrentSettings()
    End Sub

#End Region


#Region "Directly Used Form EventHandlers"

    Private Async Sub SendButton_Click(sender As Object, e As EventArgs) Handles SendButton.Click
        Panel1.Enabled = False
        Dim _messagesToSend As List(Of Tuple(Of String, Kitty))

        If AllCB.Checked Then
            _messagesToSend = MessagesToSend
        Else
            If CurrentMsgSetStartIndex + MessagesPerPage > MessagesToSend.Count Then
                _messagesToSend = MessagesToSend.Skip(CurrentMsgSetStartIndex).ToList
            Else
                _messagesToSend = MessagesToSend.Skip(CurrentMsgSetStartIndex).Take(MessagesPerPage).ToList
            End If
        End If

        For Each msg In _messagesToSend
            If msg.Item1.Length < 9 Then Continue For
            Dim id As String = $"{msg.Item1}_{msg.Item2.KittyUID}"
            If RemovedList.Contains(id) Then Continue For
            If SentList.Contains(id) Then Continue For
            Dim message As String = ReplaceTemplateWithDetails(msg.Item2, MessageText)
            Dim MessageList As List(Of String) = Split(message, $"{Environment.NewLine}{Environment.NewLine}<Next Message>{Environment.NewLine}{Environment.NewLine}").ToList

            Invoke(Sub()
                       UpdateStatuses()
                       Dim correspondingControl As MessagePreviewControl = FlowLayoutPanel1.Controls.OfType(Of MessagePreviewControl).Where(Function(c) c.Name = id)(0)
                       If correspondingControl IsNot Nothing Then
                           correspondingControl.Status = "Sending"
                       End If
                   End Sub)

            Dim _resp As JObject = Await UniversalWhatsappMessageBundle(msg.Item1, MessageList, ImagePaths)

            If _resp Is Nothing Then
                MessageBox.Show("An Error Occured While Sending Messages: Server Sent No Response Back. No More Further Messages Will Be Sent. Error Code:ERR01", "Unexpected Error", MessageBoxButtons.OK)
                Exit Sub
            End If

            Dim status As String = _resp.SelectToken("result").ToString

            UpdateList(msg.Item1, msg.Item2.KittyUID, status)
            Invoke(Sub()
                       UpdateStatuses()
                       Dim correspondingControl As MessagePreviewControl = FlowLayoutPanel1.Controls.OfType(Of MessagePreviewControl).Where(Function(c) c.Name = id)(0)
                       If correspondingControl IsNot Nothing Then
                           correspondingControl.Status = status
                       End If
                   End Sub)

        Next

        Panel1.Enabled = True
    End Sub


    Private Sub OneTimeControlTB_TextChanged(sender As Object, e As EventArgs) Handles MessagesPerPageTB.TextChanged
        Dim x As Integer = -1
        Try
            x = MessagesPerPageTB.Text
        Catch ex As Exception
        End Try

        If x > 0 Then
            MessagesPerPage = x
            CurrentMsgSetStartIndex = MessagesPerPage * Int(CurrentMsgSetStartIndex / MessagesPerPage)
            SqlCommand($"Update Message_Data set CurrentSetStartIndex='{CurrentMsgSetStartIndex}' where id=1")
            PopulatePreviewcontrolWithCurrentSettings()
        End If
        SqlCommand($"Update Message_Data set MessagesPerPage={x} where id=1")
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
        If MessagesToSend.Count = 0 Then Exit Sub
        If AllCB.Checked = False And CurrentCB.Checked = False Then
            AllCB.Checked = True
        End If
        UpdateStatuses()
        CurrentCB.Checked = False
    End Sub

    Private Sub CurrentCB_CheckedChanged(sender As Object, e As EventArgs) Handles CurrentCB.CheckedChanged
        If MessagesToSend.Count = 0 Then Exit Sub
        If AllCB.Checked = False And CurrentCB.Checked = False Then
            CurrentCB.Checked = True
        End If
        UpdateStatuses()
        AllCB.Checked = False
    End Sub

    Private Sub OneTimeControlTB_KeyDown(sender As Object, e As KeyEventArgs) Handles MessagesPerPageTB.KeyDown
        If e.Shift And e.KeyCode = Keys.Enter Then
            Try
                Dim x As String = InputBox("Enter No. To Jump Upon", "?")
                CurrentMsgSetStartIndex = MessagesPerPage * Int(x / MessagesPerPage)
                SqlCommand($"Update Message_Data set CurrentSetStartIndex='{CurrentMsgSetStartIndex}' where id=1")
                PopulatePreviewcontrolWithCurrentSettings()
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

#End Region

    Public Sub ClearPreviousFields()
        SqlCommand($"Update Message_Data set Removed='' where id=1")
        SqlCommand($"Update Message_Data set Failed='' where id=1")
        SqlCommand($"Update Message_Data set Sent='' where id=1")
        SqlCommand($"Update Message_Data set UnRegistered='' where id=1")
        SqlCommand($"Update Message_Data set CurrentSetStartIndex='0' where id=1")
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
            Dim _currentMessages As List(Of Tuple(Of String, Kitty))

            If CurrentMsgSetStartIndex + MessagesPerPage > MessagesToSend.Count Then
                _currentMessages = MessagesToSend.Skip(CurrentMsgSetStartIndex).ToList
            Else
                _currentMessages = MessagesToSend.Skip(CurrentMsgSetStartIndex).Take(MessagesPerPage).ToList
            End If

            Dim enbl As Boolean = False

            For Each msg In _currentMessages
                Dim id As String = $"{msg.Item1}_{msg.Item2.KittyUID}"
                If RemovedList.Contains(id) Then Continue For
                If SentList.Contains(id) Then Continue For
                If UnRegisteredList.Contains(id) Then Continue For
                If FailedList.Contains(id) Then Continue For

                enbl = True
                Exit For
            Next

            If _currentMessages.Count > 0 Then
                If enbl Then
                    SendButton.Enabled = True
                Else
                    SendButton.Enabled = False
                End If
            End If
        End If

    End Sub

End Class