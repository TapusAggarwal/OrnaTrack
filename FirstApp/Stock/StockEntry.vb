Imports Newtonsoft

Public Class StockEntry

    Public Property CurrentItem As Item

    Private Sub StockEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If CurrentItem.ItemID < 0 Then Exit Sub

        For Each _property In CurrentItem.MyProperties
            Dim x As New PropertyControl With {
                .CurrentProperty = _property
            }
            FlowLayoutPanel1.Controls.Add(x)
        Next

    End Sub

    Private Sub SaveBT_Click(sender As Object, e As EventArgs) Handles SaveBT.Click

        Dim Entry As New Dictionary(Of String, String)

        For Each cntrl As PropertyControl In FlowLayoutPanel1.Controls
            If cntrl.EnteredData Is Nothing Then Exit Sub
            Entry.Add(cntrl.CurrentProperty.Name, cntrl.EnteredData)
        Next

        If Entry.Count > 0 Then
            Dim entryString As String = Json.JsonConvert.SerializeObject(Entry)
            SqlCommand($"Insert Into Stock_Data (ItemID,ItemEntry) VALUES ('{CurrentItem.ItemID}','{entryString}')")
        End If

    End Sub

End Class