Imports System.Data.OleDb

Public Class Kitty

    Private _record As New Dictionary(Of Date, Integer)
    Private _availed As Boolean
    Private _initialised As Boolean = False

#Region "Properties"
    Public ReadOnly Property KittyUID As Integer = -1

    Public Property KittyNo As Integer = Nothing

    Public Property KittyType As Integer = 0

    Public Property KittyInterest As Integer = 0

    Public Property Duration As Integer = 0

    Public Property CustomerID As Integer = -1

    Public Property Record As Dictionary(Of Date, Integer)
        Get
            Return _record
        End Get
        Set(value As Dictionary(Of Date, Integer))
            _record = value
        End Set
    End Property

#End Region

    Sub New(Optional UID As Integer = -1)
        If UID = -1 Then Exit Sub
        KittyUID = UID
    End Sub

    Sub Initialize(Optional InitializeCompletely As Boolean = True)
        If KittyUID = -1 Then Exit Sub
        If _initialised Then Exit Sub
        Try
            Dim dr As OleDbDataReader = DataReader("Select * From Kitty_Data Where KittyUID=" & KittyUID)
            While dr.Read
                KittyNo = dr("KittyNo")
                CustomerID = dr("CoustID")
                KittyType = dr("KittyType")
                KittyInterest = dr("Interest")
                Duration = dr("Duration")
                IsAvailed(If(dr("Availed") = "False", False, True))
                If InitializeCompletely Then
                    AddRecord(dr("Dates"))
                End If
                _initialised = True
            End While
        Catch ex As Exception
            MessageBox.Show("Error" + ex.Message)
        End Try
    End Sub

    Sub Save()
        If KittyUID = -1 Then
            If CustomerID = -1 Then
                MessageBox.Show("Attempt To Save A Kitty Without A Customer To Own It. Can't Proceed Further Without A CustomerId.", "Illegal Selection", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            SqlCommand(
                "insert into Kitty_Data (CoustID,KittyNo,KittyType,Dates,Interest,Duration,Availed) values('" &
                CustomerID & "','" & KittyNo & "','" & KittyType & "','" & RecordString() & "','" &
                KittyInterest & "','" & Duration & "','" & IsAvailed() & "')")
        Else
            SqlCommand(
                "UPDATE Kitty_Data set " & "KittyNo='" & KittyNo & "',KittyType='" & KittyType & "',Dates='" & RecordString() &
                "',Interest='" & KittyInterest & "',Duration='" & Duration & "',Availed='" & IsAvailed() & "' WHERE KittyUID=" & KittyUID)
        End If
    End Sub

    Public ReadOnly Property Owner As Customer
        Get
            Try
                Return New Customer(Int(CommonReader("CoustID")))
            Catch ex As Exception
                MessageBox.Show("This Kitty DoesNot Have A Associated Customer With It.", "Illegeal Selection", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return Nothing
            End Try
        End Get
    End Property

    Private Function CommonReader(Field As String)
        Try
            Dim dr As OleDbDataReader = DataReader("Select " & Field & " From Kitty_Data Where KittyUID=" & KittyUID)
            Dim temp As String = Nothing
            While dr.Read
                Try
                    temp = dr(Field)
                Catch ex As Exception
                End Try
            End While
            dr.Close()
            Return temp
        Catch ex As Exception
            MessageBox.Show($"Error [Kitty]/CommonReader: {ex.Message}")
            Return Nothing
        End Try
    End Function

    Public Function AddRecord(_entry As String) As Boolean
        Try
            For Each i As String In _entry.Split(",")
                Dim _entryDate = i.Substring(0, 10).Trim
                Dim _entryAmount As Integer = i.Substring(10)
                If Record.ContainsKey(_entryDate) Then
                    If Record.Item(_entryDate) + _entryAmount < KittyType Then
                        Record.Remove(_entryDate)
                    Else
                        Record.Item(_entryDate) += _entryAmount
                    End If
                Else
                    If _entryAmount >= KittyType Then
                        Record.Add(_entryDate, _entryAmount)
                    End If
                End If
            Next

            Dim sorted = From pair In Record
                         Order By pair.Key

            Record = sorted.ToDictionary(Function(k) k.Key, Function(v) v.Value)
            Return True
        Catch ex As Exception
            MessageBox.Show("Can't Add Entry To Record [Kitty]: " + ex.Message)
            Return False
        End Try
    End Function

    Public Function RecordString(Optional Seperator As String = ",") As String
        Try
            If Record Is Nothing Then Return Nothing
            Return String.Join(",", Record.Select(Function(Kvp) $"{Kvp.Key.ToShortDateString}{Kvp.Value}").ToArray)
        Catch ex As Exception
            MessageBox.Show("Can't Get Record As List [Kitty]: " + ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function TotalAmount() As Integer
        Try
            Return KittyType * Duration
        Catch ex As Exception
            MessageBox.Show("Can't Get Total Amount [Kitty]: " + ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GivenAmount() As Integer
        Try
            Dim total As Integer = Record.Values.Sum()
            Return total
        Catch ex As Exception
            MessageBox.Show("Can't Get Given Amount [Kitty]: " + ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GetInstalmentsCompleted() As Integer
        Try
            Return Int(GivenAmount() / KittyType())
        Catch ex As Exception
            MessageBox.Show("Can't Get Completed Instalments Completed [Kitty]: " + ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GetInstalmentsPending() As Integer  'Instalments Pending Till Date
        Try
            Dim LastDate As Date = Record.Last.Key
            Dim daysbetween As TimeSpan = Today - LastDate
            Dim monthsbetweeen As Integer = Int(daysbetween.Days / 31) '#Instalments Left

            If monthsbetweeen + GetInstalmentsCompleted() > Duration Then 'If There Are More Months Between Last Instalment
                monthsbetweeen = Duration - GetInstalmentsCompleted()
            End If

            If GetInstalments_LeftForMaturity() = 0 Then Return -1 ' If Matured -> Return -1

            Return monthsbetweeen
        Catch ex As Exception
            MessageBox.Show("Can't Get Pending Instalments [Kitty]: " + ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GetInstalments_LeftForMaturity() As Integer 'Instalments Pending For Maturity
        Try
            Return Int(Duration - GetInstalmentsCompleted())
        Catch ex As Exception
            MessageBox.Show("Can't Get Instalments Pending For Maturity [Kitty]: " + ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function IsMatured() As Boolean
        Try
            If GivenAmount() >= KittyType * Duration Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show($"Error Occured While Checking Maturity Of Kitty [Kitty]: {ex.Message}")
            Return False
        End Try
    End Function

    Public Function Status() As String
        If _availed Then
            Return "Availed"
        Else
            If IsMatured() Then
                Return "Matured"
            Else
                Return "Partial"
            End If
        End If
    End Function

    Public Function IsAvailed() As Boolean
        If Not IsMatured() Then
            Return False
        Else
            Return _availed
        End If
    End Function

    Public Sub IsAvailed(value As Boolean)
        If value Then
            If IsMatured() Then
                _availed = value
            Else
                MessageBox.Show("This Kitty Is Not Yet Matured, Can't Avail It.", "Illegal Selection", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            _availed = False
        End If
    End Sub

#Region "Public Shared Function"
    Friend Shared Function GetListOfKittyTypes() As List(Of String)
        Dim temp_list As New List(Of String)
        Try
            Dim dr_kittyType As OleDbDataReader = DataReader("Select KittyType from CBox_Data Where (NOT (KittyType = ''))")
            While dr_kittyType.Read
                temp_list.Add(dr_kittyType("KittyType"))
            End While
            dr_kittyType.Close()
        Catch ex As Exception
            MessageBox.Show("Can't Get List Of KittyTypes [Kitty]: " + ex.Message)
        End Try
        Return temp_list
    End Function

    Friend Shared Function GetListOfKittyIntrests() As List(Of String)
        Dim temp_list As New List(Of String)
        Try
            Dim dr_kittyInterest As OleDbDataReader = DataReader("Select KittyIntrest from CBox_Data Where (NOT (KittyIntrest = ''))")
            While dr_kittyInterest.Read
                temp_list.Add(dr_kittyInterest("KittyIntrest"))
            End While
            dr_kittyInterest.Close()
        Catch ex As Exception
            MessageBox.Show("Can't Get List Of KittyInterests [Kitty]: " + ex.Message)
        End Try
        Return temp_list
    End Function
#End Region

End Class