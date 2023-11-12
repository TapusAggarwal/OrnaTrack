Imports System.Data.OleDb

Public Class SuggestionsPage
    Private Sub SelectBT_Click(sender As Object, e As EventArgs) Handles SelectBT.Click
        Dim clipboardData As String = Clipboard.GetText()

        Dim rows As String() = clipboardData.Split(vbCrLf)

        Dim dt As New DataTable
        For i = 0 To rows(0).Split(vbTab).Length - 1
            dt.Columns.Add($"Column {i}")
            Dim _cntr As New SuggestionControl
            _cntr.Label1.Text = $"Column {i}:"

            AddHandler _cntr.SelectBT.Click, Sub()
                                                 Dim fm As New SelectAttributeForm
                                                 fm.ShowDialog()
                                                 _cntr.CurrentAttribute = fm.SelectedAttribute
                                             End Sub

            FlowLayoutPanel1.Controls.Add(_cntr)
        Next

        For i As Integer = 1 To rows.Length - 1
            If rows(i).Trim() = "" Then Continue For

            Dim row As DataRow = dt.NewRow()
            Dim rowCols As String() = rows(i).Split(vbTab)
            For _idx = 0 To rowCols.Length - 1
                row($"Column {_idx}") = rowCols(_idx)
            Next

            dt.Rows.Add(row)
        Next

        dgv.DataSource = dt

        Dim totalWidth As Integer = 0
        For Each col As DataGridViewColumn In dgv.Columns
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            col.SortMode = DataGridViewColumnSortMode.NotSortable
            totalWidth += col.Width
        Next

        Size = New Point(Size.Width + totalWidth, Size.Height)



    End Sub

    Private Sub SuggestionsPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SaveBT_Click(sender As Object, e As EventArgs) Handles SaveBT.Click

        Dim _mapping As New Dictionary(Of String, Integer)

        For Each column As DataGridViewColumn In dgv.Columns
            _mapping.Add(column.HeaderText, -1)
        Next

        Dim _count As Integer = 0

        For Each i In FlowLayoutPanel1.Controls
            Dim _cntrl As SuggestionControl = CType(i, SuggestionControl)
            If _cntrl.CurrentAttribute Is Nothing Then
                MessageBox.Show("Not All Columns Are Mapped.")
                Exit Sub
            End If
            _mapping(_mapping.ElementAt(_count).Key) = _cntrl.CurrentAttribute.ID
            _count += 1
        Next

        Dim schemaTable As DataTable = myconnection.GetOleDbSchemaTable(OleDbSchemaGuid.Columns,
                                                                New Object() {Nothing, Nothing, "Item_Suggestion", Nothing})

        For Each i In _mapping.Values
            Dim _found As Boolean = False
            For Each _row In schemaTable.Rows
                If _row.ToString = i.ToString Then
                    _found = True
                    Exit For
                End If
            Next
            If _found Then Continue For
            SqlCommand($"ALTER TABLE Item_Suggestion ADD COLUMN {i} TEXT;")
        Next

        For i = 0 To dgv.Rows.Count - 1

            Dim _values As String = ""
            For j = 0 To dgv.Rows(i).Cells.Count - 1
                Dim _item = dgv.Rows(i).Cells(j).Value
                _values += "'" + _item + "',"
            Next
            _values = _values.TrimEnd(","c)


            SqlCommand($"INSERT INTO Item_Suggestion ({String.Join(",", _mapping.Values)}) VALUES({_values})")
        Next

        Close()

    End Sub

End Class