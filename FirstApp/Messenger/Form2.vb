Imports System.IO
Imports System.Net.Http
Imports Newtonsoft.Json.Linq

Public Class Form2
    Private Sub ImgBox_Click(sender As Object, e As EventArgs) Handles ImageBox.Click
        Try
            Dim img As New OpenFileDialog With {
                    .Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"
                    }
            If img.ShowDialog = DialogResult.OK Then
                ImageBox.Image = Image.FromFile(img.FileName)
                ImageBox.ImageLocation = img.FileName
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Async Sub SendButton_Click(sender As Object, e As EventArgs) Handles SendButton.Click

        Dim dr_Inital As OleDb.OleDbDataReader = DataReader("Select Initial From Message_Data")
        Dim InitialString As String = ""
        While dr_Inital.Read
            Try
                InitialString = dr_Inital(0)
                Exit While
            Catch ex As Exception
            End Try
        End While
        If InitialString.Length <= 0 Then Exit Sub
        Dim InitialList As New List(Of Integer)
        For Each i In InitialString.Split(",")
            If Not i.Length > 0 Then Continue For
            InitialList.Add(i)
        Next

        Dim dr_Sent As OleDb.OleDbDataReader = DataReader("Select Sent From Message_Data")
        Dim SentString As String = ""
        While dr_Sent.Read
            Try
                SentString = dr_Sent(0)
                Exit While
            Catch ex As Exception
            End Try
        End While
        Dim SentList As New List(Of Integer)
        For Each i In SentString.Split(",")
            If Not i.Length > 0 Then Continue For
            SentList.Add(i)
        Next

        If MessageBox.Show($"Sending Message To Remaining {InitialList.Count - SentList.Count} Customers.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Exit Sub

        Try
            For Each i In InitialList.Except(SentList)
                If Await SendMessage(i, ImageBox.ImageLocation) = "pass" Then
                    SentList.Add(i)
                End If
            Next
        Catch ex As Exception
        End Try

        SqlCommand($"UPDATE Message_Data set Sent='{String.Join(",", SentList)}'")
        UpDate_Data()
    End Sub

    Private Async Function SendMessage(_customerID As Integer, imgPath As String) As Task(Of String)
        Dim _customer As New Customer(_customerID)
        Dim result As String = ""
        For Each PhNo In _customer.GetPhNo

            Dim dict As New Dictionary(Of String, String) From {
                        {"purpose", "wts_msg"},
                        {"phno", "91" + PhNo},
                        {"msg", MessageTB.Text},
                        {"hands", IIf(HandsCheckBox.Checked, "true", "false")},
                        {"img", imgPath}
                        }

            Dim request As New MultipartFormDataContent From {
                        {New StringContent("91" + PhNo.Trim), "phno"},
                        {New StringContent(MessageTB.Text), "msg"},
                        {New StringContent(IIf(HandsCheckBox.Checked, "true", "false")), "hands"}
                    }

            If imgPath IsNot Nothing Then
                request = New MultipartFormDataContent From {
                        {New StringContent("91" + PhNo.Trim), "phno"},
                        {New StringContent(MessageTB.Text), "msg"},
                        {New StringContent(IIf(HandsCheckBox.Checked, "true", "false")), "hands"},
                        {New StreamContent(File.OpenRead(imgPath)), "image", New FileInfo(imgPath).Name}
                    }
            End If




            Dim ResponseString As String = Await ServerHttpRequest(Nothing, request, $"http://{My.Settings.connection_url}/upload")

            If ResponseString IsNot Nothing Then
                Dim response As JObject = JObject.Parse(ResponseString)
                If result <> "pass" Then
                    result = response.SelectToken("result").ToString()
                Else
                    result = "pass"
                End If
            End If
        Next
        Return result
    End Function

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpDate_Data()
    End Sub

    Private Sub UpDate_Data()
        Dim dr_Inital As OleDb.OleDbDataReader = DataReader("Select Initial From Message_Data")
        Dim InitialString As String = ""
        While dr_Inital.Read
            Try
                InitialString = dr_Inital(0)
                Exit While
            Catch ex As Exception
            End Try
        End While

        If InitialString.Length <= 0 Then Exit Sub

        WarningLabel.Visible = False

        Dim dr_Sent As OleDb.OleDbDataReader = DataReader("Select Sent From Message_Data")
        Dim SentString As String = ""
        While dr_Sent.Read
            Try
                SentString = dr_Sent(0)
                Exit While
            Catch ex As Exception
            End Try
        End While

        Dim sentCount As Integer = 0
        If SentString.Split(",")(0).Length > 0 Then
            sentCount = 1
        End If

        Label1.Text = $"{ If(sentCount = 1, SentString.Split(",").Count, 0)} Sent Of {InitialString.Split(",").Count}"
        Label1.Visible = True
        SendButton.Enabled = True
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        If MessageBox.Show("Do You Want To Conitue?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Exit Sub

        Dim _list As List(Of Integer) = Customer.SearchByName("").ToList
        _list = _list.Distinct.ToList
        SqlCommand("Delete * From Message_Data")
        SqlCommand($"Insert INTO Message_Data (Initial) Values('{String.Join(",", _list)}')")
        UpDate_Data()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Close()
    End Sub

End Class