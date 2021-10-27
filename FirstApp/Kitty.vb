Imports System.Data.OleDb
Imports FirstApp.Utility

Public Class Kitty

    Private _record As New Dictionary(Of Date, Integer)
    Private ReadOnly apostrope As String = "{#}"

#Region "Properties"
    Public ReadOnly Property KittyUID As Integer = -1

    Public Property KittyNo As Integer = -1

    Public Property KittyType As Integer = -1

    Public Property KittyInterest As Integer = -1

    Public Property Duration As Integer = -1

    Public Property CustomerID As Integer = -1

    Public Property Notes As String = ""

    Public Property IsAvailed As Boolean = False

    Public Property Record As Dictionary(Of Date, Integer)
        Get
            Return _record
        End Get
        Set(value As Dictionary(Of Date, Integer))
            _record = value
        End Set
    End Property

#End Region

    Sub New(Optional UID As Integer = -1, Optional InitializeKitty As Boolean = False, Optional completely As Boolean = False)
        If UID = -1 Then Exit Sub
        KittyUID = UID
        If InitializeKitty Then Initialize(completely)
    End Sub

    Sub Initialize(Optional InitializeCompletely As Boolean = True)
        If KittyUID = -1 Then Exit Sub
        Try
            Dim dr As OleDbDataReader = DataReader("Select * From Kitty_Data Where KittyUID=" & KittyUID)
            While dr.Read
                KittyNo = dr("KittyNo")
                CustomerID = dr("CoustID")
                KittyType = dr("KittyType")
                KittyInterest = dr("Interest")
                Duration = dr("Duration")
                IsAvailed = If(dr("Availed") = "False", False, True)
                Try : Notes = dr("Notes").ToString.Replace(apostrope, "'") : Catch : End Try
                If InitializeCompletely Then
                    Record.Clear()
                    AddRecord(dr("Dates"))
                End If
            End While
        Catch ex As Exception
            MessageBox.Show("[Kitty]/Initialize Error: " + ex.Message)
        End Try
    End Sub

    Sub Save()
        If KittyUID = -1 Then
            If CustomerID = -1 Then
                MessageBox.Show("[Kitty] Attempt To Save A Kitty Without A Customer To Own It. Can't Proceed Further Without A CustomerId.", "Illegal Selection", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If MessageBox.Show("[Kitty] Do You Want To Add New Kitty ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Exit Sub
            SqlCommand(
                "INSERT INTO Kitty_Data (CoustID,KittyNo,KittyType,Dates,Interest,Duration,Availed,Notes)" &
                $"VALUES({CustomerID},{KittyNo},{KittyType},'{RecordString()}',{KittyInterest},{Duration},'{IsAvailed}','{Notes.Replace("'", apostrope)}')")
        Else
            If CustomerID = -1 Then Exit Sub
            If MessageBox.Show("[Kitty] Do You Want To Update This Kitty ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Exit Sub
            SqlCommand(
                $"UPDATE Kitty_Data set CoustID={CustomerID},KittyNo={KittyNo},KittyType={KittyType},Dates='{RecordString()}',Interest={KittyInterest},Duration={Duration}" &
                $",Availed ='{IsAvailed()}',Notes='{Notes.Replace("'", apostrope)}' WHERE KittyUID={KittyUID}")
        End If
    End Sub

    Public Sub Dissolve()
        Try
            If MessageBox.Show("Are You Sure That You Want To Dissolve This Kitty ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Exit Sub
            SqlCommand("DELETE FROM Kitty_Data WHERE KittyUID=" & KittyUID)
        Catch ex As Exception
            MessageBox.Show($"Error [Kitty]/Dissolve: {ex.Message}")
        End Try
    End Sub

    Public ReadOnly Property Owner As Customer
        Get
            Try
                Return New Customer(CustomerID)
            Catch ex As Exception
                MessageBox.Show("Error [Kitty]/Owner This Kitty DoesNot Have A Associated Customer With It.", "Illegeal Selection", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return Nothing
            End Try
        End Get
    End Property

    Public Function AddRecord(_entry As String) As Boolean
        Try
            If String.IsNullOrEmpty(_entry) Then Return False
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
            If Record.Count = 0 Then Return -1
            Dim FirstDate As Date = Record.First.Key
            Dim monthsbetweeen As Integer = MonthDifference(Today, FirstDate) '#Expected Given Instalments

            monthsbetweeen -= GetInstalmentsCompleted() - 1

            If monthsbetweeen > GetInstalments_LeftForMaturity() Then
                monthsbetweeen = GetInstalments_LeftForMaturity()
            End If

            If GetInstalments_LeftForMaturity() = 0 Then Return -1 ' If Matured -> Return -1

            If monthsbetweeen < 0 Then Return 0 Else Return monthsbetweeen 'If SomeBody Paid More Than Necessary
        Catch ex As Exception
            MessageBox.Show("Can't Get Pending Instalments [Kitty]: " + ex.Message)
            Return -1
        End Try
    End Function

    'Public Function GetInstalmentsPending1() As Integer  'Instalments Pending Till Date
    '    Try
    '        If Record.Count = 0 Then Return -1
    '        Dim FirstMonth As Integer = Record.First.Key.Month
    '        Dim daysbetween As TimeSpan = Today - LastDate
    '        Dim monthsbetweeen As Integer = Int(daysbetween.Days / 31) '#Instalments Left

    '        If monthsbetweeen + GetInstalmentsCompleted() > Duration Then 'If There Are More Months Between Last Instalment
    '            monthsbetweeen = Duration - GetInstalmentsCompleted()
    '        End If

    '        If GetInstalments_LeftForMaturity() = 0 Then Return -1 ' If Matured -> Return -1

    '        If monthsbetweeen < 0 Then Return 0 Else Return monthsbetweeen 'If SomeBody Paid More Than Necessary
    '    Catch ex As Exception
    '        MessageBox.Show("Can't Get Pending Instalments [Kitty]: " + ex.Message)
    '        Return -1
    '    End Try
    'End Function

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
        If IsAvailed Then
            If IsMatured() Then
                Return "Availed"
            Else
                Return "Cracked"
            End If
        Else
            If IsMatured() Then
                Return "Matured"
            Else
                Return "Partial"
            End If
        End If
    End Function

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