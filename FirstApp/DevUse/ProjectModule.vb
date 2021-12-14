Imports System.Data.OleDb
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.IO
Imports WebSocket4Net
Imports System.Net.Http
Imports System.Net.Http.Headers

Module ProjectModule
    Public myconnection As New OleDbConnection
    Public WebSocket As WebSocket
    Public state As String = ""
    Public ReadOnly apostropheReplacer As String = "{#}"


    Public Structure Variables
        Shared ConnectionString As String =
                "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\Desktop\FirstApp_database.accdb"
    End Structure

    Sub InitaliseConnection()
        Try : myconnection.ConnectionString = Variables.ConnectionString : Catch : End Try
    End Sub

    'FUNCTION:- SQL Command
    Function SqlCommand(cmd As String, Optional CloseConnection As Boolean = False) As Boolean
        Try
            If myconnection.State = ConnectionState.Closed Then myconnection.Open()
            Dim comnd = New OleDbCommand(cmd, myconnection)
            comnd.ExecuteNonQuery()
            comnd.Dispose()
            If CloseConnection Then myconnection.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show("ProjectModule SQL Command Error:- " & ex.Message)
            Return False
        End Try
    End Function

    'FUNCTION:- Returns A DataReader Based On A Command Note:-(Need To Close dr And myconnection After Using.)
    Function DataReader(cmdi As String)
        Try
            Dim cmd As New OleDbCommand With {
                .CommandText = cmdi,
                .Connection = myconnection
                }
            Dim Data_Reader As OleDbDataReader = cmd.ExecuteReader
            Return Data_Reader
        Catch ex As Exception
            MessageBox.Show("ProjectModule DataReader Error:- " & ex.Message)
            Return Nothing
        End Try
    End Function

    'SUB:- Serialize A Dgv
    Sub SrNoUpdate(Dgv As DataGridView, Optional SerialIndex As Integer = 1)
        For i = 0 To Dgv.Rows.Count - 1
            Dgv.Rows(i).Cells(SerialIndex).Value = i + 1
        Next
    End Sub

    'Function: General Function That takes Dictionary Of Commands As Input And Returns Server Respons As String
    Function ServerHttpRequest(Optional requestPrams As Dictionary(Of String, String) = Nothing, Optional request_headres As MultipartFormDataContent = Nothing, Optional _uri As String = Nothing)

        If _uri Is Nothing Then _uri = $"http://{My.Settings.connection_url}"

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
        client.Timeout = TimeSpan.FromSeconds(5)

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

    'Function ServerHttpRequest(command As Dictionary(Of String, String)) As String
    '    Dim rawresponse As String = Nothing
    '    Try
    '        Dim url = $"http://{My.Settings.connection_url}?"
    '        For Each comm In command
    '            url += $"{comm.Key}={comm.Value}&"
    '        Next
    '        url = url.Substring(0, url.Length - 1)
    '        If String.IsNullOrWhiteSpace(url) Then Return Nothing
    '        Dim req As WebRequest = WebRequest.Create(url.Trim)
    '        req.Method = "POST"
    '        Dim response = DirectCast(req.GetResponse(), HttpWebResponse)
    '        Dim reader = New StreamReader(response.GetResponseStream())
    '        rawresponse = reader.ReadToEnd().ToString()
    '    Catch ex As Exception
    '        'MessageBox.Show(String.Format("An error occurred:{0}{0}{1}",
    '        '                                  vbCrLf, ex.Message),
    '        '                    "Exception Thrown",
    '        '                    MessageBoxButtons.OK,
    '        '                    MessageBoxIcon.Warning)
    '    End Try
    '    Return rawresponse
    'End Function


    'Function: Check's If A Number Is Registered With Watsapp Returns true, false or Nothing In Case When Server Does Not Respond
    Async Function Isregistered(PhNo As String) As Task(Of String)
        Dim dict As New Dictionary(Of String, String) From {
                {"purpose", "is_registered"},
                {"phno", "91" & PhNo}
            }
        Try
            'Dim ResponseString As String = Await 
            Return Await ServerHttpRequest(dict)
        Catch ex As Exception
            Return Nothing
            'MessageBox.Show(String.Format("An error occurred:{0}{0}{1}",
            '                              vbCrLf, ex.Message),
            '                    "Exception Thrown",
            '                    MessageBoxButtons.OK,
            '                    MessageBoxIcon.Warning)
        End Try
    End Function

    <Extension>
    Public Function OrderBasedOnStatus(_list As List(Of Kitty)) As List(Of Kitty)

        Dim imMature As New List(Of Kitty)
        Dim Matured As New List(Of Kitty)
        Dim Availed As New List(Of Kitty)

        'Adding Kitty To Respective Lists
        For Each _kitty As Kitty In _list
            _kitty.Initialize()
            If _kitty.IsAvailed Then
                Availed.Add(_kitty)
            ElseIf _kitty.IsMatured Then
                Matured.Add(_kitty)
            Else
                imMature.Add(_kitty)
            End If
        Next

        _list.Clear()

        'Adding Kitty Back In Order
        _list.AddRange(imMature)
        _list.AddRange(Matured)
        _list.AddRange(Availed)

        Return _list
    End Function

    <Extension()>
    Public Function PendingInstalmentsInWords(_kitty As Kitty, Optional IncludeInstalmentWord As Boolean = False) As String
        Dim pendingInst As Integer = _kitty.GetInstalmentsPending
        If _kitty.Record.Count = -1 Then
            Return "No Entry Made"
        End If
        If pendingInst = 0 Then
            If IncludeInstalmentWord Then
                Return "No Instalment Pending"
            End If
            Return "None Pending"
        Else
            If IncludeInstalmentWord Then
                If pendingInst > 1 Then
                    Return $"{pendingInst} Instalments Pending"
                Else
                    Return $"{pendingInst} Instalment Pending"
                End If
            End If
            Return $"{pendingInst} Pending"
        End If
    End Function

    <Extension()>
    Public Function ToCurrency(_number As Integer, Optional RemoveSpaces As Boolean = False) As String
        If RemoveSpaces Then
            Return Format(_number, "C0").Replace(" ", "")
        Else
            Return Format(_number, "C0")
        End If
    End Function

    <Extension()>
    Public Function ToCurrency(_text As String, Optional RemoveSpaces As Boolean = False) As String
        Try
            Dim _temp As Integer = _text
            Return _temp.ToCurrency(RemoveSpaces)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    '<Extension()>
    'Public Function AddToList(Of TKey, TValue)(_dict As Dictionary(Of TKey, List(Of TValue)), _key As Object, _value As Object)
    '    If _dict.ContainsKey(_key) Then
    '        _dict.Item(_key).Add(_value)
    '    Else

    '    End If
    'End Function

End Module