Public Class ItemsUserControl
    Private _StockID As Integer
    Public Property CurrentItem As Item
    Public Property StockID As Integer
        Get
            Return _StockID
        End Get
        Set
            _StockID = Value

            Dim dr As OleDb.OleDbDataReader = DataReader($"Select img_path From Stock_Data Where ID={StockID}")
            While dr.Read
                If Not IsDBNull(dr(0)) Then
                    ImageBox.ImageLocation = dr(0)
                End If
            End While

        End Set
    End Property

    Private Sub DetailsButton_Click(sender As Object, e As EventArgs) Handles DetailsButton.Click

    End Sub

End Class
