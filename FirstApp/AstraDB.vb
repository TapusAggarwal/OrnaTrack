Imports System.IO
Imports System.Net
Imports System.Net.Http
Imports System.Text
Imports Newtonsoft

Public Class AstraDB

    Const DB_ID = "31f178a4-d16d-41c4-ac73-d714ba8a0235"
    Const DB_REGION = "asia-south1"
    Const DB_KEYSPACE = "customerdata"
    Const DB_APPLICATION_TOKEN = "AstraCS:ujbnTGoqRuGfZDXjkZpzdJPP:3a679940aee2db68bfab5377d32d571135768a45f7ab30acb7f940a81034624a"

    Private Async Sub AstraDB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim client As New HttpClient

        Const table = "coustmers_data"

        Dim T_List As New List(Of Task(Of String))

        Dim _stopWatch As Stopwatch = Stopwatch.StartNew
        Dim dr As OleDb.OleDbDataReader = DataReader("Select * From Coustmers_Data")
        While dr.Read

            Dim _dict As New Dictionary(Of String, String) From {
                                               {"srno", ""},
                                               {"address", ""},
                                               {"cname", ""},
                                               {"csname", ""},
                                               {"dscrp", ""},
                                               {"gender", ""},
                                               {"img", ""},
                                               {"mry", ""},
                                               {"phno", ""},
                                               {"prof", ""},
                                               {"region", ""},
                                               {"review", ""}
                                               }
            Dim f = Function(x)
                        Return If(IsDBNull(x), "", x)
                    End Function
            _dict("srno") = f(dr("SrNo"))
            _dict("address") = f(dr("Address"))
            _dict("cname") = f(dr("CName"))
            _dict("csname") = f(dr("CsName"))
            _dict("dscrp") = f(dr("dscrp"))
            _dict("gender") = f(dr("Gender"))
            _dict("img") = f(dr("img"))
            _dict("mry") = f(dr("Mry"))
            _dict("phno") = f(dr("PhNo"))
            _dict("prof") = f(dr("Prof"))
            _dict("region") = f(dr("Region"))
            _dict("review") = f(dr("Review"))


            T_List.Add(Task.Run(Function()
                                    Dim _uri As New Uri($"https://{DB_ID}-{DB_REGION}.apps.astra.datastax.com/api/rest/v2/keyspaces/{DB_KEYSPACE}/{table}")
                                    Dim request As WebRequest = WebRequest.Create(_uri)
                                    request.Method = "POST"
                                    request.Headers("x-cassandra-token") = DB_APPLICATION_TOKEN
                                    request.ContentType = "application/json"

                                    Dim stringData As String = Json.JsonConvert.SerializeObject(_dict)

                                    Dim data = Encoding.UTF8.GetBytes(stringData)

                                    'request.ContentLength = data.Length

                                    Using newStream = request.GetRequestStream
                                        newStream.Write(data, 0, data.Length)
                                    End Using

                                    Dim _answer As String = ""
                                    Using responseStream = request.GetResponse.GetResponseStream
                                        Dim reader As New StreamReader(responseStream)
                                        _answer = reader.ReadToEnd
                                        reader.Close()
                                    End Using

                                    Invoke(Sub()
                                               Label1.Text += 1
                                           End Sub)

                                    Return _answer
                                End Function))
        End While


        Dim _list = Await Task.WhenAll(T_List)
        dr.Close()

        MessageBox.Show($"Total Time Taken: {_stopWatch.Elapsed.Seconds}")
        _stopWatch.Stop()

    End Sub
End Class