Public Class ShowItems

    Dim _list As New Dictionary(Of Integer, Item)
    Dim _currentIndex As Integer = 0

    Private Sub ShowItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dr As OleDb.OleDbDataReader = DataReader("Select * From Stock_Data")

        While dr.Read
            If IsDBNull(dr("ID")) Then Exit While
            _list.Add(Int(dr("ID")), New Item(Int(dr("Ctg_ID"))))
        End While
        dr.Close()

        _list = _list.Reverse.ToDictionary(Function(f) f.Key, Function(f) f.Value)

        LoadData()
    End Sub

    Sub LoadData()
        FlowLayoutPanel1.Controls.Clear()

        For i = _currentIndex To _currentIndex + 10

            Dim _kVal = _list.ElementAt(i)

            Dim x As New ItemsUserControl With {
                .StockID = _kVal.Key,
                .CurrentItem = _kVal.Value
            }

            AddHandler x.DetailsButton.Click, Sub()
                                                  Dim Fm As New StockEntry With {
                                                    .CurrentItem = x.CurrentItem,
                                                    .StockID = x.StockID
                                                  }
                                                  Fm.ShowDialog()
                                                  LoadData()
                                              End Sub


            FlowLayoutPanel1.Controls.Add(x)
        Next

    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        _currentIndex += 10

        If _currentIndex >= _list.Count Then
            _currentIndex = _list.Count
        End If
        LoadData()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        _currentIndex -= 10

        If _currentIndex <= 0 Then
            _currentIndex = 0
        End If
        LoadData()
    End Sub
End Class