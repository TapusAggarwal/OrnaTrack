Public Class TransactionsForm

    Public Enum DgvEnum
        CheckBoxColumn = 0
        SrNoColumn = 1
        DateColumn = 2
        ModeColumn = 3
        AmountColumn = 4
        AccountColumn = 5
        RefNoColumn = 6
        UsedAmtCoulumn = 7
        DetailsButton = 8
    End Enum

    Private Property Dict As New Dictionary(Of Integer, Kitty)
    Public Property ButtonText As String = "Details"

    Public Function GetAllTransactions() As List(Of Transaction)
        Dim dr As OleDb.OleDbDataReader = DataReader("Select * From Transaction_Data")

        Dim _listTrns As New List(Of Transaction)

        While dr.Read
            Dim _trns As New Transaction(dr("TrnsID"))
            _listTrns.Add(_trns)
            For Each i In _trns.KittyIds.Keys
                If Dict.ContainsKey(i) Then Continue For
                Dict.Add(i, New Kitty(i, True, True))
            Next
        End While

        Return _listTrns
    End Function

    Private Sub FindCoustmerButton_Click(sender As Object, e As EventArgs) Handles FindCoustmerButton.Click
        Dgv.Rows.Clear()

        Dim _listTrns As List(Of Transaction) = GetAllTransactions()

        If _listTrns.Count = 0 Then Exit Sub

        Dim sorted = (From pair In _listTrns Order By pair.TrnsDate).Reverse
        _prev = sorted.FirstOrDefault.TrnsDate

        For Each i In sorted
            If i.TrnsDate < FromDatePicker.Value OrElse i.TrnsDate > TillDatePicker.Value Then Continue For
            Dgv.Rows.Add()
            PopulateRow(Dgv.Rows(Dgv.Rows.Count - 1), i)
        Next

    End Sub

    Dim _color As Color = Color.LightGray
    Dim _prev As Date = Nothing

    Public Event RowModified(_row As DataGridViewRow)

    Private Sub PopulateRow(_row As DataGridViewRow, i As Transaction)
        With _row
            Dim _kittyNo As String = String.Join(",", i.KittyIds.Keys.Select(Function(f) Dict(f).KittyNo))
            If _prev <> i.TrnsDate Then _color = If(_color = Color.White, Color.LightGray, Color.White)
            .DefaultCellStyle.BackColor = _color
            .Cells(DgvEnum.DateColumn).Value = i.TrnsDate
            .Cells(DgvEnum.ModeColumn).Value = i.Mode
            .Cells(DgvEnum.AmountColumn).Value = i.Amount.ToCurrency
            .Cells(DgvEnum.AccountColumn).Value = i.Account
            .Cells(DgvEnum.RefNoColumn).Value = i.RefNo
            .Cells(DgvEnum.UsedAmtCoulumn).Value = _kittyNo
            .Cells(DgvEnum.DetailsButton).Value = ButtonText
            .Cells(DgvEnum.DetailsButton).Tag = i.TrnsID
        End With
        _prev = i.TrnsDate
    End Sub

    Public Event Cell_Clicked(_id As Integer)

    Private Sub Dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv.CellClick
        If Not e.ColumnIndex = DgvEnum.DetailsButton OrElse e.RowIndex = -1 Then Exit Sub
        Dim _id As Integer = Dgv.Rows(e.RowIndex).Cells(DgvEnum.DetailsButton).Tag

        If Tag IsNot Nothing Then
            If _id = Tag.TrnsID Then
                MessageBox.Show("You Are Already Using This Transaction With This Kitty.", "Transactions Already In Use", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Exit Sub
            End If
        End If

        RaiseEvent Cell_Clicked(_id)
        If ButtonText = "Select" Then Exit Sub

        Dim Fm As New TransactionDetails
        Dim _trns As New Transaction(_id)
        Fm.DatePicker.Value = _trns.TrnsDate
        Fm.DatePicker.Enabled = False

        Fm.CurrentTransaction = _trns

        AddHandler Fm.SaveButton_Clicked, Sub()
                                              PopulateRow(Dgv.Rows(e.RowIndex), New Transaction(_id))
                                          End Sub
        AddHandler Fm.RemoveDetails, Sub()
                                         Dgv.Rows.RemoveAt(e.RowIndex)
                                     End Sub

        Fm.ShowDialog()
    End Sub

    Public Event AddTransactionButton_Clicked()

    Private Sub AddMsgBT_Click(sender As Object, e As EventArgs) Handles AddMsgBT.Click
        RaiseEvent AddTransactionButton_Clicked()
    End Sub
End Class