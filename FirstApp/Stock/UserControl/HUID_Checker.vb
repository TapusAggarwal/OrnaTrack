Imports Newtonsoft.Json.Linq
Imports System.Data.OleDb
Imports System.IO
Imports System.Net

Public Class HUID_Checker

    Public Property Huid_Attrid As Integer = 15

    Public Property SuggestionsList As New Dictionary(Of String, Dictionary(Of Integer, String))

    'Public Property UsedSuggestion As 

    Private Sub HUID_Checker_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Huid_Attrid = -1 Then Exit Sub

        Dim dr As OleDbDataReader = DataReader("Select * From Item_Suggestion")

        Dim _columnNames As New List(Of String)

        Dim schemaTable As DataTable = myconnection.GetOleDbSchemaTable(OleDbSchemaGuid.Columns,
                                                                        New Object() {Nothing, Nothing, "Item_Suggestion", Nothing})

        For Each row As DataRow In schemaTable.Rows
            _columnNames.Add(row("COLUMN_NAME"))
        Next

        While dr.Read
            Dim _dict As New Dictionary(Of Integer, String)
            Dim _huid As String = ""
            For Each i In _columnNames
                If i = "ID" Then
                    _dict.Add(-1, dr("ID"))
                    Continue For
                End If
                If i = Huid_Attrid.ToString Then
                    _huid = dr(i)
                    Continue For
                End If
                _dict.Add(Int(i), dr(i).ToString.Trim)
            Next
            SuggestionsList.Add(_huid.Trim, _dict)
        End While

        'SearchTB.Text = "VXZSYD"
    End Sub

    Private Async Function CheckUIDExists(huid As String) As Task(Of String)
        Cursor = Cursors.WaitCursor
        Dim url As String = "https://mobile.manakonline.in/MANAK/getAHCUIDdetails?uid=" & huid.Trim
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
        ListBox1.Visible = False
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

        If SuggestionsList.ContainsKey(SearchTB.Text.Trim) Then

        End If

        RaiseEvent HuidSelected(_status, huid.Trim)
    End Sub

    Private Sub SearchTB_TextChanged(sender As Object, e As EventArgs) Handles SearchTB.TextChanged
        SelectBT.Visible = False

        ListBox1.Items.Clear()
        If SearchTB.Text = "" Then
            ListBox1.Visible = False
            Exit Sub
        End If

        If sender.Text.Trim = "" Then Exit Sub

        Dim query = (From entry In SuggestionsList
                     Where ContainsLettersInOrder(entry.Key, sender.Text)
                     Select entry.Key).ToArray

        If query.Count > 7 Then Exit Sub

        ListBox1.Visible = True
        ListBox1.Items.AddRange(query)

        ListBox1.Height = Math.Min(ListBox1.Items.Count * (ListBox1.ItemHeight + 5), 498)
    End Sub

    Function ContainsLettersInOrder(origStr As String, inpStr As String) As Boolean
        Dim filteredStr = From c In origStr Where inpStr.Contains(c)
        Dim joinedStr = String.Join("", filteredStr)
        Return inpStr = joinedStr
    End Function

    Private Sub SearchTB_KeyDown(sender As Object, e As KeyEventArgs) Handles SearchTB.KeyDown
        If e.KeyCode = Keys.Enter Then
            FindCoustmerButton.PerformClick()
        End If
    End Sub

    Private Sub ListBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedValueChanged
        SearchTB.Text = ListBox1.SelectedItem
    End Sub
End Class