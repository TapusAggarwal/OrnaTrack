Public Class DgvForExistingPhno

    Public Property CurrentCustomer As Customer = Nothing
    Public Property CurrentPhNo As String()
    Public Property SelectedCustomer As Integer = -1
    Private Sub DgvForExistingPhno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dgv.Rows.Clear()

        For Each ID As Integer In Customer.SharedPhNo(CurrentPhNo)
            Dim Record As New Customer(ID)
            If CurrentCustomer IsNot Nothing AndAlso CurrentCustomer.CustomerID = Record.CustomerID Then Continue For

            Dgv.Rows.Add()
            Dgv.Rows(Dgv.Rows.Count - 1).Cells(0).Value = Record.FullName
            Dgv.Rows(Dgv.Rows.Count - 1).Cells(1).Value = Record.PhNo(",")
            Dgv.Rows(Dgv.Rows.Count - 1).Cells(3).Value = Record.CustomerID
        Next
    End Sub

    Private Sub Dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv.CellClick
        Try
            If e.RowIndex >= 0 AndAlso e.ColumnIndex = 2 Then
                SelectedCustomer = Dgv.Rows(e.RowIndex).Cells(3).Value
                Close()
            End If
        Catch ex As Exception
            MessageBox.Show("DgvForExistingPhNo/CellClick Error: " & ex.Message)
        End Try
    End Sub
End Class