Imports System.Data.OleDb
Public Class BookMode

    Private Sub Kittyreport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dr_Types As OleDbDataReader = DataReader("Select DISTINCT KittyType From Kitty_Data")
        While dr_Types.Read
            If dr_Types("KittyType").GetType Is GetType(DBNull) Then Exit Sub
            Dim dr_UID As OleDbDataReader = DataReader($"Select KittyUID From Kitty_Data Where KittyType={dr_Types(0)} ORDER BY KittyNo ASC")
            Dim BookList As New List(Of Integer)

            While dr_UID.Read
                BookList.Add(dr_UID("KittyUID"))
            End While

            Dgv.Rows.Add()
            Dgv.Rows(Dgv.Rows.Count - 1).Cells(0).Value = dr_Types("KittyType").ToString.ToCurrency(AddSpace:=True)
            Dgv.Rows(Dgv.Rows.Count - 1).Cells(1).Value = $"{New Kitty(BookList.First, True).KittyNo}-{New Kitty(BookList.Last, True).KittyNo}"
            Dgv.Rows(Dgv.Rows.Count - 1).Cells(2).Value = BookList.Count
            dr_UID.Close()

            Dgv.Rows(Dgv.Rows.Count - 1).Cells(4).Value = Str(New Kitty(BookList.First).CustomerID) & "_" & Str(BookList.First)
        End While
    End Sub

    Private Sub Dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv.CellClick
        If e.RowIndex >= 0 And e.ColumnIndex = 3 Then
            For Each ExistingFm As Form In Frame.MdiChildren
                If ExistingFm.Name <> "Main" Then
                    ExistingFm.Dispose()
                End If
            Next

            Dim Fm As New KittyModeCoustView With {
                .MdiParent = Frame,
                .Tag = Dgv.Rows(e.RowIndex).Cells(4).Value,
                .Dock = DockStyle.Fill
            }
            Close()
            Fm.Show()
        End If
    End Sub
End Class