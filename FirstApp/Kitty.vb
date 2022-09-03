Imports System.Data.OleDb
Imports FirstApp.Utility

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

    Public Property TransactionsRecord As New Dictionary(Of Date, String)

    Private Property Initialized As Boolean = False

#End Region

    Sub New(Optional UID As Integer = -1, Optional InitializeKitty As Boolean = False, Optional completely As Boolean = False)
        If UID = -1 Then Exit Sub
        KittyUID = UID
        If InitializeKitty Then Initialize(completely)
    End Sub

    Sub Initialize(Optional InitializeCompletely As Boolean = True)
        If KittyUID = -1 Then Exit Sub
        If Initialized Then Exit Sub
        Try
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
                "INSERT INTO Kitty_Data (CoustID,KittyNo,KittyType,Dates,Interest,Duration,Availed,InActive,Notes,TransactionDetails)" &
                $"VALUES({CustomerID},{KittyNo},{KittyType},'{RecordString()}',{KittyInterest},{Duration},'{IsAvailed}','{IsInactive}','{Notes.Replace("'", apostropheReplacer)}', '{TransactionDetailsString()}')")
        Else
            If CustomerID = -1 Then Exit Sub
            If MessageBox.Show("[Kitty] Do You Want To Update This Kitty ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Exit Sub
            SqlCommand(
                $"UPDATE Kitty_Data set CoustID={CustomerID},KittyNo={KittyNo},KittyType={KittyType},Dates='{RecordString()}',Interest={KittyInterest},Duration={Duration}" &
                $",Availed ='{IsAvailed}',InActive='{IsInactive}',Notes='{Notes.Replace("'", apostropheReplacer)}',TransactionDetails='{TransactionDetailsString()}' WHERE KittyUID={KittyUID}")
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

    Sub InitializeTransactions()
        Dim Transactions As String = ""
        Try
            Dim dr As OleDbDataReader = DataReader("Select TransactionDetails From Kitty_Data Where KittyUID=" & KittyUID)
            While dr.Read
                Try : Transactions = dr("TransactionDetails") : Catch ex As Exception : End Try
            End While
        Catch ex As Exception
            MessageBox.Show("[Kitty]/Initialize Transactions Error: " + ex.Message)
        End Try
        If Transactions IsNot Nothing AndAlso Transactions.Length > 1 Then
            AddTransactionDetails(Transactions)
        End If
    End Sub

    Sub AddTransactionDetails(entry As String)
        Try
            For Each _transaction In Split(entry, "|,|", , CompareMethod.Text)
                If _transaction.Length < 11 Then Continue For
                Dim _date = _transaction.Substring(0, 10).Trim
                Dim _details As String = _transaction.Substring(10)
                TransactionsRecord.Item(_date) = _details
            Next
        Catch ex As Exception
            MessageBox.Show("[Kitty]/AddTransactionDetails Error: " + ex.Message)
        End Try
    End Sub

    Function TransactionDetailsString(Optional Seperator As String = "|,|")
        Try
            If TransactionsRecord Is Nothing Then Return ""
            For Each i In TransactionsRecord.Values
                If i.Length > 1 Then
                    Return String.Join(Seperator, TransactionsRecord.Select(Function(Kvp) $"{Kvp.Key.ToShortDateString}{Kvp.Value}").ToArray)
                End If
            Next
            Return ""
        Catch ex As Exception
            MessageBox.Show("Can't Get TransactionsRecord As List [Kitty]: " + ex.Message)
            Return ""
        End Try
    End Function

    Public Function AddRecord(_entry As String) As Boolean
        Try
            If String.IsNullOrEmpty(_entry) Then Return False
            For Each i As String In _entry.Split(",")
                Dim _entryDate = i.Substring(0, 10).Trim
                Dim _entryAmount As Integer = i.Substring(10)
                If Record.ContainsKey(_entryDate) Then
                    If Record.Item(_entryDate) + _entryAmount < KittyType Then
                        Record.Remove(_entryDate)
                        If TransactionsRecord.ContainsKey(_entryDate) Then TransactionsRecord.Remove(_entryDate)
                    Else
                        Record.Item(_entryDate) += _entryAmount
                    End If
                Else
                    If _entryAmount >= KittyType Then
                        Record.Add(_entryDate, _entryAmount)
                        If Not TransactionsRecord.ContainsKey(_entryDate) Then
                            TransactionsRecord.Add(_entryDate, "")
                        End If
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
            Return String.Join(Seperator, Record.Select(Function(Kvp) $"{Kvp.Key.ToShortDateString}{Kvp.Value}").ToArray)
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