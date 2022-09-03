Imports System.Data.OleDb
Imports FirstApp.Utility
Imports Newtonsoft.Json

Public Class Kitty
    Implements IEquatable(Of Kitty)

#Region "Properties"
    Public ReadOnly Property KittyUID As Integer = -1

    Public Property KittyNo As Integer = -1

    Public Property KittyType As Integer = -1

    Public Property KittyInterest As Integer = -1

    Public Property Duration As Integer = -1

    Public Property CustomerID As Integer = -1

    Public Property Notes As String = ""

    Public Property IsAvailed As Boolean = False

    Public Property IsInactive As Boolean = False

    Public Property Record As New Dictionary(Of Date, Integer)
    Public Property Transactions As New Dictionary(Of Date, List(Of Transaction))

    Private Property Initialized As Boolean = False

    Public ReadOnly Property Owner As Customer
        Get
            Try
                Return New Customer(CustomerID)
            Catch ex As Exception
                MessageBox.Show("Error [Kitty]/Owner This Kitty DoesNot Have A Associated Customer With It.", "Wrong Selection", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return Nothing
            End Try
        End Get
    End Property

#End Region

    Sub New(Optional UID As Integer = -1, Optional InitializeKitty As Boolean = False, Optional completely As Boolean = False)
        If UID = -1 Then Exit Sub
        KittyUID = UID
        If InitializeKitty Then Initialize(completely)
    End Sub

    Sub Initialize(Optional InitializeCompletely As Boolean = True)
        If KittyUID = -1 Then Exit Sub
        If Initialized Then Exit Sub
        Dim dr As OleDbDataReader = DataReader("Select * From Kitty_Data Where KittyUID=" & KittyUID)
        While dr.Read
            KittyNo = dr("KittyNo")
            CustomerID = dr("CoustID")
            KittyType = dr("KittyType")
            KittyInterest = dr("Interest")
            Duration = dr("Duration")
            IsAvailed = If(dr("Availed") = "False", False, True)
            IsInactive = If(dr("InActive") = "False", False, True)
            Try : Notes = dr("Notes").ToString.Replace(apostropheReplacer, "'") : Catch : End Try
            If InitializeCompletely Then
                AddRecord(dr("Dates"))
                Initialized = True
            End If
        End While
        dr.Close()

    End Sub

    Sub Save()
        If KittyUID = -1 Then
            If CustomerID = -1 Then
                MessageBox.Show("[Kitty] Attempt To Save A Kitty Without A Customer To Own It. Can't Proceed Further Without A CustomerId.", "Illegal Selection", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If MessageBox.Show("[Kitty] Do You Want To Add New Kitty ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Exit Sub
            SqlCommand(
                "INSERT INTO Kitty_Data (CoustID,KittyNo,KittyType,Dates,Interest,Duration,Availed,InActive,Notes)" &
                $"VALUES({CustomerID},{KittyNo},{KittyType},'{RecordString()}',{KittyInterest},{Duration},'{IsAvailed}','{IsInactive}','{Notes.Replace("'", apostropheReplacer)}')")
        Else
            If CustomerID = -1 Then Exit Sub
            If MessageBox.Show("[Kitty] Do You Want To Update This Kitty ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Exit Sub
            SqlCommand(
                $"UPDATE Kitty_Data set CoustID={CustomerID},KittyNo={KittyNo},KittyType={KittyType},Dates='{RecordString()}',Interest={KittyInterest},Duration={Duration}" &
                $",Availed ='{IsAvailed}',InActive='{IsInactive}',Notes='{Notes.Replace("'", apostropheReplacer)}' WHERE KittyUID={KittyUID}")
        End If
    End Sub

    Public Sub Dissolve()
        Try
            If MessageBox.Show("Are You Sure That You Want To Dissolve This Kitty ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Exit Sub
            SqlCommand($"DELETE FROM Kitty_Data WHERE KittyUID={KittyUID}")
        Catch ex As Exception
            MessageBox.Show($"Error [Kitty]/Dissolve: {ex.Message}")
        End Try
    End Sub

    Sub InitializeTransactions()
        Transactions.Clear()
        Dim dr As OleDbDataReader = DataReader($"Select TrnsID From Transaction_Data Where KittyIds LIKE '%,{KittyUID},%'")
        While dr.Read
            Dim _trns As New Transaction(dr(0))
            If Not Transactions.ContainsKey(_trns.TrnsDate) Then
                Transactions.Add(_trns.TrnsDate, New List(Of Transaction)({_trns}))
            Else
                Transactions(_trns.TrnsDate).Add(_trns)
            End If
        End While
        dr.Close()
    End Sub

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
                        Record(_entryDate) += _entryAmount
                    End If
                Else
                    If _entryAmount >= KittyType Then Record.Add(_entryDate, _entryAmount)
                End If
            Next

            Dim sorted = From pair In Record
                         Order By pair.Key

            Record = sorted.ToDictionary(Function(k) k.Key, Function(v) v.Value)

            For Each i In Transactions.Where(Function(f) Not Record.ContainsKey(f.Key))

            Next

            Return True
        Catch ex As Exception
            MessageBox.Show("Can't Add Entry To Record [Kitty]: " + ex.Message)
            Return False
        End Try
    End Function

    Public Function RecordString(Optional Seperator As String = ",") As String
        If Record Is Nothing Then Return Nothing
        Return String.Join(Seperator, Record.Select(Function(f) $"{f.Key.ToShortDateString}{f.Value}").ToArray)
    End Function

    Public Function TotalAmount() As Integer
        Return KittyType * Duration
    End Function

    Public Function GivenAmount() As Integer
        Return Record.Values.Sum()
    End Function

    Public Function GetInstalmentsCompleted() As Integer
        Return Int(GivenAmount() / KittyType())
    End Function

    Public Function GetInstalmentsPending() As Integer  'Instalments Pending Till Date
        If Record.Count = 0 Then Return Nothing
        Dim FirstDate As Date = Record.First.Key

        Dim ExpectedDate As Date = FirstDate
        Dim ExpectedInstalments As Integer = 0

        While ExpectedDate < Today  ' Adding One To Get Instalments Expected Until Today (It Will Add One Extra Month At Last)
            ExpectedDate = ExpectedDate.AddMonths(1)
            ExpectedInstalments += 1
        End While

        ExpectedInstalments -= 1 ' Subtracting One To Get Instalments Expected Until Today

        ExpectedInstalments -= GetInstalmentsCompleted() - 1 ' Subtracting Instalments Given And One More Instalment That Is The First Instalment

        If ExpectedInstalments > GetInstalments_LeftForMaturity() Then ' If Instalments Due Past The Date Of Maturity
            ExpectedInstalments = GetInstalments_LeftForMaturity()
        End If

        If GetInstalments_LeftForMaturity() = 0 Then Return -1 ' If Matured -> Return -1

        If ExpectedInstalments < 0 Then 'If SomeBody Paid More Than Necessary
            Return 0
        Else
            Return ExpectedInstalments
        End If
    End Function

    Public Function GetInstalments_LeftForMaturity() As Integer 'Instalments Pending For Maturity
        Return Int(Duration - GetInstalmentsCompleted())
    End Function

    Public Function IsMatured() As Boolean
        If GivenAmount() >= KittyType * Duration Then
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' <code>Status =: Availed, Cracked, InActive, Matured, Partial</code>
    ''' </summary>
    ''' <returns>Status Of The Given Kitty</returns>
    Public Function Status() As String
        If IsAvailed Then
            If IsMatured() Then
                Return "Availed"
            Else
                Return "Cracked"
            End If
        ElseIf IsInactive Then
            Return "InActive"
        Else
            If IsMatured() Then
                Return "Matured"
            Else
                Return "Partial"
            End If
        End If
    End Function

#Region "Public Shared Function"
    Friend Shared Function GetListOfKittyTypes() As List(Of Integer)
        Dim temp_list As New List(Of Integer)
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

    Friend Shared Function GetListOfKittyIntrests() As List(Of Integer)
        Dim temp_list As New List(Of Integer)
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

    Friend Shared Function GetListOfPaymentModes() As List(Of String)
        Dim temp_list As New List(Of String)
        Try
            Dim dr_Modes As OleDbDataReader = DataReader("Select PaymentModes from CBox_Data Where (NOT (PaymentModes = ''))")
            While dr_Modes.Read
                temp_list.Add(dr_Modes("PaymentModes"))
            End While
            dr_Modes.Close()
        Catch ex As Exception
            MessageBox.Show("Can't Get List Of PaymentModes [Kitty]: " + ex.Message)
        End Try
        Return temp_list
    End Function

    Friend Shared Function GetListOfAccounts() As List(Of String)
        Dim temp_list As New List(Of String)
        Try
            Dim dr_Accounts As OleDbDataReader = DataReader("Select Accounts from CBox_Data Where (NOT (Accounts = ''))")
            While dr_Accounts.Read
                temp_list.Add(dr_Accounts("Accounts"))
            End While
            dr_Accounts.Close()
        Catch ex As Exception
            MessageBox.Show("Can't Get List Of Accounts [Kitty]: " + ex.Message)
        End Try
        Return temp_list
    End Function

    Public Function Equals(other As Kitty) As Boolean Implements IEquatable(Of Kitty).Equals
        Return other IsNot Nothing AndAlso
               KittyUID = other.KittyUID
    End Function

#End Region

End Class

Public Class Transaction
    Implements ICloneable
    Public Property TrnsID As Integer = -1
    Public Property TrnsDate As Date
    Public Property Mode As String = ""
    Public Property Account As String
    Public Property Amount As Integer = -1
    Public Property RefNo As String
    Public Property Notes As String
    Public Property KittyIds As New Dictionary(Of Integer, Integer)
    Public ReadOnly Property InitialisedKitty As List(Of Kitty)
        Get
            Return (From i In KittyIds Select New Kitty(i.Key, True)).ToList
        End Get
    End Property

    Public Sub New(_id As Integer)
        If _id = -1 Then Exit Sub
        Dim dr As OleDbDataReader = DataReader($"Select * From Transaction_Data Where TrnsID={_id}")
        While dr.Read
            TrnsDate = Date.Parse(dr("TrnsDate"))
            Mode = dr("Mode")
            Account = dr("Account")
            Amount = dr("Amount")
            RefNo = If(IsDBNull(dr("RefNo")), "", dr("RefNo"))

            If Not IsDBNull(dr("KittyIds")) Then
                For Each i In dr("KittyIds").ToString.Split(",")
                    If Not i.Length > 0 Then Continue For
                    KittyIds.Add(Int(i), -1)
                Next
                Dim _index As Integer = 0
                For Each i In dr("Structure").ToString.Split(",")
                    If Not i.Length > 0 Then Continue For
                    KittyIds(KittyIds.ElementAt(_index).Key) = Int(i)
                    _index += 1
                Next
            End If

            Notes = If(IsDBNull(dr("Notes")), "", dr("Notes"))
        End While
        dr.Close()
        TrnsID = _id
    End Sub

    Public Function Save() As Integer
        If TrnsID < 0 Then
            Dim res = SqlCommand("Insert Into Transaction_Data (TrnsDate,Mode,Account,Amount,RefNo,KittyIds,Notes,Structure) " &
                       $"Values ('{TrnsDate.ToShortDateString}','{Mode}','{Account}','{Amount}','{RefNo}',',{String.Join(",", KittyIds.Keys)},','{Notes}','{String.Join(",", KittyIds.Values)}')")
            If res Then
                Dim dr As OleDbDataReader = DataReader("Select Max(TrnsID) From Transaction_Data")
                While dr.Read
                    If Not IsDBNull(dr(0)) Then
                        TrnsID = Int(dr(0))
                        Return Int(dr(0))
                    End If
                End While
            End If
        Else
            SqlCommand("Update Transaction_Data Set " &
                       $"TrnsDate='{TrnsDate.ToShortDateString}',Mode='{Mode}',Account='{Account}',Amount='{Amount}',RefNo='{RefNo}'" &
                       $",KittyIds=',{String.Join(",", KittyIds.Keys)},',Notes='{Notes}',Structure='{String.Join(",", KittyIds.Values)}' Where TrnsID={TrnsID}")
        End If
        Return -1
    End Function

    Public Sub Delete(Optional _kittyID As Integer = -1)
        If _kittyID <> -1 Then
            If KittyIds.Count > 1 Then
                KittyIds.Remove(_kittyID)
            End If
        End If
        SqlCommand($"Delete From Transaction_Data Where TrnsID={TrnsID}")
    End Sub

    Public Overrides Function GetHashCode() As Integer
        Return (TrnsID, TrnsDate, Mode, Account, Amount, RefNo, KittyIds, Notes).GetHashCode()
    End Function

    Public Function Clone() As Object Implements ICloneable.Clone
        Dim x = MemberwiseClone()
        x.KittyIds = (From i In KittyIds).ToDictionary(Function(g) g.Key, Function(g) g.Value)
        Return x
    End Function
End Class