Public Class ShowItems
    Private Sub AddAttributeButton_Click(sender As Object, e As EventArgs) Handles AddAttributeButton.Click
        Dim Fm As New AddItemPage
        Fm.Show()
    End Sub

    Private Sub ShowItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        InitaliseConnection()

        Try : myconnection.Open() : Catch : End Try

        Dim dr As OleDb.OleDbDataReader = DataReader("Select * From Item_Data")

        FlowLayoutPanel1.Controls.Clear()

        While dr.Read
            Dim x As New ItemsUserControl With {
                .ItemId = Int(dr("ID"))
            }
            FlowLayoutPanel1.Controls.Add(x)
        End While

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        FlowLayoutPanel1.Controls.Clear()

        Dim dr As OleDb.OleDbDataReader = DataReader("Select * From Item_Data")

        While dr.Read
            Dim x As New ItemsUserControl With {
                .ItemId = Int(dr("ID"))
            }
            FlowLayoutPanel1.Controls.Add(x)
        End While
    End Sub
End Class