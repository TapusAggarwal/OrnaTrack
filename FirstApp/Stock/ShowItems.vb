Public Class ShowItems

    Private Sub ShowItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dr As OleDb.OleDbDataReader = DataReader("Select * From Stock_Data")

        FlowLayoutPanel1.Controls.Clear()

        While dr.Read
            If IsDBNull(dr("ID")) Then Exit While
            Dim x As New ItemsUserControl With {
                .StockID = Int(dr("ID")),
                .CurrentItem = New Item(Int(dr("Ctg_ID")))
            }

            AddHandler x.DetailsButton.Click, Sub()
                                                  Dim Fm As New StockEntry With {
                                                    .CurrentItem = x.CurrentItem,
                                                    .StockID = x.StockID
                                                  }
                                                  Fm.ShowDialog()
                                                  ShowItems_Load(sender, e)
                                              End Sub

            FlowLayoutPanel1.Controls.Add(x)
        End While

    End Sub

End Class