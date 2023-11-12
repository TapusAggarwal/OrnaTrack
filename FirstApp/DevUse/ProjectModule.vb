Imports System.Data.OleDb
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.IO
Imports WebSocket4Net
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports OrnaTrack.MessageAndImageSender
Imports Newtonsoft.Json.Linq

Module ProjectModule
    Public myconnection As New OleDbConnection
    Public WebSocket As WebSocket
    Public state As String = ""
    Public Property ImageFirst As Boolean = True
    Public ReadOnly apostropheReplacer As String = "{#}"


    Public Structure Variables
        Shared ConnectionString As String =
                $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={My.Settings.Database_path}"
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

    'Function: General Function That takes Dictionary Of Parameters As Input And Returns Server Response As String
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

    Async Function UniversalWhatsappMessageBundle(phno As String, msgList As List(Of String), imgList As List(Of String)) As Task(Of JObject)

        Using client As New HttpClient()
            Dim content As New MultipartFormDataContent From {
            {New StringContent("91" + phno.Trim), "phno"}
        }

            If imgList.Count = 0 And msgList.Count = 0 Then
                MessageBox.Show($"Neither Image Nor Message was provided to send to this number.", "Error", MessageBoxButtons.OK)
                Return Nothing
            End If

            If Not ImageFirst And (msgList.Count > 0 AndAlso imgList.Count > 0) Then
                Dim _resp As JObject = Await UniversalWhatsappMessageBundle(phno, msgList, New List(Of String))
                Dim status = "fail"
                If _resp IsNot Nothing Then status = _resp.SelectToken("result").ToString

                If status = "pass" Then
                    msgList.Clear()
                ElseIf status = "fail" Then
                    Dim response As New JObject From {
                        {"result", "fail"}
                    }
                    Return response
                Else
                    Return Nothing
                End If
            End If

            For Each msg In msgList
                content.Add(New StringContent(msg), "msg")
            Next

            For Each imgPath In imgList
                If imgPath.Trim = "" Then Continue For
                Dim imageContent As New ByteArrayContent(File.ReadAllBytes(imgPath))
                imageContent.Headers.ContentType = MediaTypeHeaderValue.Parse("image/jpeg")
                content.Add(imageContent, "image", Path.GetFileName(imgPath))
            Next

            Dim responseString As String = Nothing

            Try
                Dim response As HttpResponseMessage = Await client.PostAsync($"http://{My.Settings.connection_url}/upload", content)
                responseString = response.Content.ReadAsStringAsync().Result
            Catch ex As Exception
                MessageBox.Show($"The Client Made A Successful Request But The Server Failed To Respond. Exception Details: {ex.Message}", "Server Side Error", MessageBoxButtons.OK)
            End Try

            If responseString IsNot Nothing Then
                Return JObject.Parse(responseString)
            Else
                Return Nothing
            End If

        End Using

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


    <Extension>
    Public Function OrderBasedOnStatus(_list As List(Of Kitty)) As List(Of Kitty)

        Dim imMature As New List(Of Kitty)
        Dim Matured As New List(Of Kitty)
        Dim Availed As New List(Of Kitty)
        Dim inActive As New List(Of Kitty)

        'Adding Kitty To Respective Lists
        For Each _kitty As Kitty In _list
            _kitty.Initialize(True)
            If _kitty.IsAvailed Then
                Availed.Add(_kitty)
            ElseIf _kitty.IsMatured Then
                Matured.Add(_kitty)
            ElseIf _kitty.IsInactive Then
                inActive.Add(_kitty)
            Else
                imMature.Add(_kitty)
            End If
        Next

        _list.Clear()

        'Adding Kitty Back In Order
        _list.AddRange(imMature)
        _list.AddRange(Matured)
        _list.AddRange(Availed)
        _list.AddRange(inActive)

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
    Public Function ToCurrency(_number As Object, Optional AddSpace As Boolean = False) As String
        Dim _numberCur As String = _number.ToString()
        If _numberCur = "" Then
            Return ""
        End If
        _numberCur = _numberCur.Replace(" ", "")
        _numberCur = _numberCur.Replace("₹", "")
        If AddSpace Then
            Return String.Format("₹{0:C}", _numberCur)
        Else
            Return String.Format("₹ {0:C}", _numberCur)
        End If
    End Function

    '<Extension()>
    'Public Function AddToList(Of TKey, TValue)(_dict As Dictionary(Of TKey, List(Of TValue)), _key As Object, _value As Object)
    '    If _dict.ContainsKey(_key) Then
    '        _dict.Item(_key).Add(_value)
    '    Else

    '    End If
    'End Function

End Module