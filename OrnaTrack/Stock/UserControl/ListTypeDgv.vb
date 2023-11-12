Public Class ListTypeDgv

    Public Property ListItems As New List(Of String)

    Private Sub LoadItems()
        Dgv.Rows.Clear()
        For Each i In ListItems
            Dgv.Rows.Add()
            Dgv.Rows(Dgv.Rows.Count - 1).Cells(0).Value = Dgv.Rows.Count
            Dgv.Rows(Dgv.Rows.Count - 1).Cells(1).Value = i
        Next
        ItemTB.Text = ""
        ItemTB.Select()
    End Sub

    Private Sub AddBT_Click(sender As Object, e As EventArgs) Handles AddBT.Click
        If ItemTB.Text.Length <= 0 Then Exit Sub
        If ListItems.Contains(ItemTB.Text) Then MessageBox.Show("All Items Must Be Distinct.")
        ListItems.Add(ItemTB.Text)
        LoadItems()
    End Sub

    Private Sub EditBT_Click(sender As Object, e As EventArgs) Handles EditBT.Click
        Dim CurrentIndex As Integer = Dgv.CurrentRow.Index
        If CurrentIndex < 0 Then Exit Sub
        If ItemTB.Text.Length <= 0 Then Exit Sub
        ListItems(CurrentIndex) = ItemTB.Text
        LoadItems()
    End Sub

    Private Sub DeleteBT_Click(sender As Object, e As EventArgs) Handles DeleteBT.Click
        If Dgv.CurrentRow.Index < 0 Then Exit Sub
        ListItems.Remove(Dgv.CurrentRow.Cells(1).Value)
        LoadItems()
    End Sub

    Private Sub UpBT_Click(sender As Object, e As EventArgs) Handles UpBT.Click
        If Dgv.CurrentRow.Index <= 0 Then Exit Sub
        Dim newIndex As Integer = Dgv.CurrentRow.Index - 1
        Dim currentItem As String = Dgv.CurrentRow.Cells(1).Value
        DeleteBT_Click(sender, e)
        ListItems.Insert(newIndex, currentItem)
        LoadItems()
        Dgv.Rows(newIndex).Cells(0).Selected = True
    End Sub

    Private Sub DownBT_Click(sender As Object, e As EventArgs) Handles DownBT.Click
        If Dgv.CurrentRow.Index = Dgv.Rows.Count - 1 Then Exit Sub
        Dim newIndex As Integer = Dgv.CurrentRow.Index + 1
        Dim currentItem As String = Dgv.CurrentRow.Cells(1).Value
        DeleteBT_Click(sender, e)
        ListItems.Insert(newIndex, currentItem)
        LoadItems()
        Dgv.Rows(newIndex).Cells(0).Selected = True
    End Sub

    Private Sub Dgv_SelectionChanged(sender As Object, e As EventArgs) Handles Dgv.SelectionChanged
        If Dgv.CurrentRow.Index < 0 Then Exit Sub
        ItemTB.Text = Dgv.CurrentRow.Cells(1).Value
        ItemTB.Select()
    End Sub

    Public Event Submit_CLick()

    Private Sub SubmitBT_Click(sender As Object, e As EventArgs) Handles SubmitBT.Click
        RaiseEvent Submit_CLick()
    End Sub

    Public Event Cancel_CLick()
    Private Sub CancelBT_Click(sender As Object, e As EventArgs) Handles CancelBT.Click
        RaiseEvent Cancel_CLick()
    End Sub

    Private Sub ListTypeDgv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadItems()
    End Sub
End Class