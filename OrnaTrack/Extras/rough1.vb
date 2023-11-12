Imports System.Data.OleDb
Imports System.IO

Public Class rough1
    Private Sub rough1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim schemaTable As DataTable = myconnection.GetOleDbSchemaTable(OleDbSchemaGuid.Columns,
                                                                        New Object() {Nothing, Nothing, "Stock_Data", Nothing})

        For Each row As DataRow In schemaTable.Rows
            MessageBox.Show(row("COLUMN_NAME"))
        Next

    End Sub
End Class