Public Class ItemsUserControl

    Public WriteOnly Property ItemId As Integer
        Set(value As Integer)
            CurrentItem = New Item(value)
            ItemNameParam.Text = CurrentItem.Name
            TotalPropertiesParam.Text = CurrentItem.MyProperties.Count
        End Set
    End Property

    Public Property CurrentItem As Item

    Private Sub DetailsButton_Click(sender As Object, e As EventArgs) Handles DetailsButton.Click
        Dim Fm As New AddItemPage With {
            .CurrentItem = CurrentItem
        }
        Fm.Show()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim Fm As New StockEntry
        Fm.CurrentItem = CurrentItem
        Fm.Show()
    End Sub
End Class
