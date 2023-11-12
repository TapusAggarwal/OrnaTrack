Public Class PerUnitTimeControl
    Private _totalAmount As Integer = -1
    Private _totalCount As Integer = -1

    Public Sub MakeOneMonthControl(_thisMonthDates As Dictionary(Of Date, List(Of Kitty)))
        DateLB.Text = _thisMonthDates.First.Key.ToString("MMMM,yyyy")
        Dim _amt As Integer = 0, _count As Integer = 0
        For Each i In _thisMonthDates
            Dim _cntrl As New PerUnitTimeControl
            _cntrl.MakeOneDayControl(i.Key, i.Value)
            _cntrl.Panel2.Size = New Point(_cntrl.Width - 30, _cntrl.Panel2.Height)
            FlowLayoutPanel1.Controls.Add(_cntrl)
            _amt += _cntrl._totalAmount
            _count += _cntrl._totalCount
        Next
        _totalCount = _count
        _totalAmount = _amt
        AmtLB.Text = $"Total:{_amt.ToCurrency}"
        InfoLB.Text = $"Kitty:{_count}"
    End Sub

    Public Sub MakeOneDayControl(_date As Date, _list As List(Of Kitty))
        DateLB.Text = _date.ToString("M")
        Dim _amt As Integer = 0, _count As Integer = 0
        For Each i In _list
            _amt += i.Record.Item(_date)
            _count += 1
            Dim _cntrl As New OneDayControl
            _cntrl.NameLB.Text = i.Owner.FullName
            _cntrl.DateLB.Text = DateLB.Text
            _cntrl.AmtLB.Text = i.Record.Item(_date).ToCurrency
            _cntrl._kitty = i
            FlowLayoutPanel1.Controls.Add(_cntrl)
        Next
        _totalCount = _count
        _totalAmount = _amt
        AmtLB.Text = $"Total:{_amt.ToCurrency}"
        InfoLB.Text = $"Kitty:{_count}"
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        FlowLayoutPanel1.Visible = Not FlowLayoutPanel1.Visible
        If IconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowDown Then
            IconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowUp
        Else
            IconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowDown
        End If
    End Sub

End Class

