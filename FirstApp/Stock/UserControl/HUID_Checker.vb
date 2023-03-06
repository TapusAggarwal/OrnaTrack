Imports Newtonsoft.Json.Linq
Imports System.IO
Imports System.Net

Public Class HUID_Checker

    Private Sub HUID_Checker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'SearchTB.Text = "VXZSYD"
    End Sub

    Private Async Function CheckUIDExists(huid As String) As Task(Of String)
        Cursor = Cursors.WaitCursor
        Dim url As String = "https://mobile.manakonline.in/MANAK/getAHCUIDdetails?uid=" & huid
        Dim request As HttpWebRequest = WebRequest.Create(url)
        request.Method = "GET"
        request.Timeout = 10000

        Dim responseString As String = ""
        Try
            Using response As HttpWebResponse = Await request.GetResponseAsync()
                Dim streamReader As StreamReader = New StreamReader(response.GetResponseStream())
                responseString = streamReader.ReadToEnd()
                streamReader.Close()
            End Using
        Catch ex As WebException
            Dim response As HttpWebResponse = ex.Response
            If response IsNot Nothing Then
                Dim reader As New StreamReader(response.GetResponseStream())
                responseString = reader.ReadToEnd()
                reader.Close()
                response.Close()
            End If
        End Try
        Cursor = Cursors.Default

        Return responseString
    End Function

    Public Event HuidSelected(status As Boolean, huid As String)
    Dim _status As Boolean = False
    Dim huid As String = ""

    Private Async Sub FindCoustmerButton_Click(sender As Object, e As EventArgs) Handles FindCoustmerButton.Click

        huid = SearchTB.Text

        FlowLayoutPanel1.Controls.Clear()

        Dim title As New Label With {
                .AutoSize = True,
                .Dock = DockStyle.Top,
                .Font = New Font("Segoe UI", 12, FontStyle.Bold),
                .Margin = New Padding(10, 10, 0, 0),
                .Text = "HUID NO: " & huid & " | Status: "
            }
        Dim _resp = Await CheckUIDExists(huid)

        If _resp = "[{""Status"":""false""}]" Then
            title.ForeColor = Color.Red
            title.Text &= "False"
            FlowLayoutPanel1.Controls.Add(title)
        ElseIf _resp = "" Then
            title.ForeColor = Color.Goldenrod
            title.Text &= "No Response"
            FlowLayoutPanel1.Controls.Add(title)
        Else
            title.ForeColor = Color.Green
            title.Text &= "Pass"
            _status = True
            SelectBT.Visible = True
            FlowLayoutPanel1.Controls.Add(title)

            Dim jsonData As JArray = JArray.Parse(_resp)
            For Each data As JObject In jsonData
                For Each kvp As KeyValuePair(Of String, JToken) In data
                    If kvp.Key <> "status" Then

                        Dim _lbl As New KeyValue_Control
                        _lbl.KeyLB.Text = kvp.Key & ":"
                        _lbl.ValueLB.Text = kvp.Value.ToString()

                        FlowLayoutPanel1.Controls.Add(_lbl)
                    End If
                Next
            Next
        End If

        SelectBT.Select()

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles SelectBT.Click
        RaiseEvent HuidSelected(_status, huid)
    End Sub

    Private Sub SearchTB_TextChanged(sender As Object, e As EventArgs) Handles SearchTB.TextChanged
        SelectBT.Visible = False
    End Sub

    Private Sub SearchTB_KeyDown(sender As Object, e As KeyEventArgs) Handles SearchTB.KeyDown
        If e.KeyCode = Keys.Enter Then
            FindCoustmerButton.PerformClick()
        End If
    End Sub
End Class