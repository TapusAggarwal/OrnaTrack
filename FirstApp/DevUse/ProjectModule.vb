Imports System.Data.OleDb
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.IO
Imports WebSocket4Net

Module ProjectModule
    Public myconnection As New OleDbConnection
    Public WebSocket As WebSocket
    Public state As String = ""

    Public Structure Variables
        Shared ConnectionString As String =
                "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\repos\TapusAggarwal\FirstApp-ReBuild\FirstApp_database.accdb"
    End Structure

    Sub InitaliseConnection()
        Try : myconnection.ConnectionString = Variables.ConnectionString : Catch : End Try
    End Sub

    'FUNCTION:- SQL Command
    Function SqlCommand(cmd As String, Optional CloseConnection As Boolean = False) As Boolean
        Try
            If myconnection.State = 0 Then myconnection.Open()
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
    Function ServerHttpRequest(command As Dictionary(Of String, String)) As String
        Dim rawresponse As String = Nothing
        Try
            Dim url = "http://localhost:3966?"
            For Each comm In command
                url += comm.Key + "=" + comm.Value + "&"
            Next
            url = url.Substring(0, url.Length - 1)
            If String.IsNullOrWhiteSpace(url) Then Return Nothing
            Dim req As WebRequest = WebRequest.Create(url.Trim)
            req.Method = "POST"
            Dim response = DirectCast(req.GetResponse(), HttpWebResponse)
            Dim reader = New StreamReader(response.GetResponseStream())
            rawresponse = reader.ReadToEnd().ToString()
        Catch ex As Exception
            'MessageBox.Show(String.Format("An error occurred:{0}{0}{1}",
            '                                  vbCrLf, ex.Message),
            '                    "Exception Thrown",
            '                    MessageBoxButtons.OK,
            '                    MessageBoxIcon.Warning)
        End Try
        Return rawresponse
    End Function


    'Function: Check's If A Number Is Registered With Watsapp Returns true, false or Nothing In Case When Server Does Not Respond
    Function Isregistered(PhNo As String)
        Dim ResponseString As String = Nothing
        Dim dict As New Dictionary(Of String, String) From {
                {"purpose", "is_registered"},
                {"phno", "91" & PhNo}
            }
        Try
            ResponseString = ServerHttpRequest(dict)
            Return ResponseString
        Catch ex As Exception
            Return ResponseString
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
            If _kitty.IsMatured Then
                Matured.Add(_kitty)
            ElseIf _kitty.IsAvailed Then
                Availed.Add(_kitty)
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

End Module