Imports System.Data.OleDb
Imports System.Runtime.CompilerServices

Module ProjectModule
    Public myconnection As New OleDbConnection

    Public Structure Variables
        Shared ConnectionString As String =
                "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\Desktop\FirstApp_database.accdb"
    End Structure

    Sub InitaliseConnection()
        Try : myconnection.ConnectionString = Variables.ConnectionString : Catch : End Try
    End Sub

    'FUNCTION:- SQL Command
    Function SqlCommand(cmd As String, Optional CloseConnection As Boolean = True) As Boolean
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

    <Extension>
    Public Function OrderBasedOnStatus(_list As List(Of Kitty)) As List(Of Kitty)

        Dim imMature As New List(Of Kitty)
        Dim Matured As New List(Of Kitty)
        Dim Availed As New List(Of Kitty)

        'Adding Kitty To Respective Lists
        For Each _kitty As Kitty In _list
            _kitty.Initialize()
            If _kitty.IsMatured Then
                If _kitty.IsAvailed Then
                    Availed.Add(_kitty)
                Else
                    Matured.Add(_kitty)
                End If
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
            Return $"{pendingInst} Instalments Pending"
        End If
    End Function

End Module