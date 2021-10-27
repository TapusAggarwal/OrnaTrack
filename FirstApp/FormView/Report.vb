Public Class Report

    Private Sub LoadRelativeData(KittyType As String, Dgv_temp As DataGridView)
        Dgv_temp.Rows.Clear()
        Dgv_temp.Columns(0).HeaderText = $"KittyType: {KittyType}"

        Dim dr As OleDb.OleDbDataReader = DataReader($"Select KittyUID from Kitty_Data where KittyType={KittyType}")

        Dim dictAbsolute As New Dictionary(Of Integer, List(Of Integer)) From {{0, New List(Of Integer) From {0, 0, 0}}}

        While dr.Read
            Dim _kitty As New Kitty(UID:=dr("KittyUID"), InitializeKitty:=True, completely:=True)
            If _kitty.IsAvailed OrElse _kitty.IsMatured OrElse _kitty.GivenAmount = 0 Then Continue While

            If dictAbsolute.ContainsKey(_kitty.GetInstalmentsPending) Then
                With dictAbsolute.Item(_kitty.GetInstalmentsPending)
                    dictAbsolute.Item(_kitty.GetInstalmentsPending) = New List(Of Integer) From { .Item(0) + 1, .Item(1) + _kitty.GivenAmount, .Item(2) + _kitty.KittyInterest}
                End With
            Else
                dictAbsolute.Add(_kitty.GetInstalmentsPending, New List(Of Integer) From {1, _kitty.GivenAmount, _kitty.KittyInterest})
            End If
        End While

        Dim sorted = From pair In dictAbsolute
                     Order By pair.Key

        For Each i As KeyValuePair(Of Integer, List(Of Integer)) In sorted
            Dgv_temp.Rows.Add()
            If Dgv_temp.Rows.Count = 1 Then
                Dgv_temp.Rows(Dgv_temp.Rows.Count - 1).DefaultCellStyle.BackColor = SystemColors.Highlight
                Dgv_temp.Rows(Dgv_temp.Rows.Count - 1).DefaultCellStyle.ForeColor = Color.White
                Dgv_temp.Rows(Dgv_temp.Rows.Count - 1).Cells(0).Value = "Kitties UpToDate"
                Dgv_temp.Rows(Dgv_temp.Rows.Count - 1).Cells(1).Value = i.Value(0)
            Else
                Dgv_temp.Rows(Dgv_temp.Rows.Count - 1).Cells(0).Value = Str(i.Key) + " Instalment Left"
                Dgv_temp.Rows(Dgv_temp.Rows.Count - 1).Cells(1).Value = i.Value(0)
            End If
            Dgv_temp.Rows(Dgv_temp.Rows.Count - 1).Cells(2).Value = i.Value(1).ToCurrency(True)
            If i.Value(1) = 0 Then
                Dgv_temp.Rows(Dgv_temp.Rows.Count - 1).Cells(3).Value = Int(0).ToCurrency(True)
            Else
                Dgv_temp.Rows(Dgv_temp.Rows.Count - 1).Cells(3).Value = i.Value(2).ToCurrency(True)
            End If
        Next

        Dim TotalKitties As Integer = 0
        Dim TotalAmount As Integer = 0
        Dim TotalInterest As Integer = 0
        For Each i In dictAbsolute.Values
            TotalKitties += i(0)
            TotalAmount += i(1)
            TotalInterest += i(2)
        Next

        Dgv_temp.Rows.Add()
        With Dgv_temp.Rows(Dgv_temp.Rows.GetLastRow(DataGridViewElementStates.Visible))
            .DefaultCellStyle.BackColor = Color.DarkGoldenrod
            .DefaultCellStyle.ForeColor = Color.Black
            .Cells(0).Value = "Total:"
            .Cells(1).Value = TotalKitties
            .Cells(2).Value = TotalAmount.ToCurrency(RemoveSpaces:=True)
            .Cells(3).Value = TotalInterest.ToCurrency(RemoveSpaces:=True)
        End With

        Dgv_temp.Rows.Add()
        With Dgv_temp.Rows(Dgv_temp.Rows.GetLastRow(DataGridViewElementStates.Visible))
            .DefaultCellStyle.BackColor = Color.Goldenrod
            .DefaultCellStyle.ForeColor = Color.Black
            .Cells(0).Value = "UpToDate Kitties:"
            .Cells(1).Value = 0
            .Cells(2).Value = 0
            .Cells(3).Value = 0

            If dictAbsolute.ContainsKey(0) Then
                .Cells(1).Value += dictAbsolute.Item(0)(0)
                .Cells(2).Value += dictAbsolute.Item(0)(1)
                .Cells(3).Value += dictAbsolute.Item(0)(2)
            End If
            If dictAbsolute.ContainsKey(1) Then
                .Cells(1).Value += dictAbsolute.Item(1)(0)
                .Cells(2).Value += dictAbsolute.Item(1)(1)
                .Cells(3).Value += dictAbsolute.Item(1)(2)
            End If

            .Cells(2).Value = .Cells(2).Value.ToString.ToCurrency(RemoveSpaces:=True)
            .Cells(3).Value = .Cells(2).Value.ToString.ToCurrency(RemoveSpaces:=True)
        End With

        Dgv_temp.Rows.Add()
        With Dgv_temp.Rows(Dgv_temp.Rows.GetLastRow(DataGridViewElementStates.Visible))
            .DefaultCellStyle.BackColor = Color.Goldenrod
            .DefaultCellStyle.ForeColor = Color.Black
            .Cells(0).Value = "Late Kitties:"
            .Cells(1).Value = TotalKitties
            .Cells(2).Value = TotalAmount
            .Cells(3).Value = TotalInterest

            If dictAbsolute.ContainsKey(0) Then
                .Cells(1).Value -= dictAbsolute.Item(0)(0)
                .Cells(2).Value -= dictAbsolute.Item(0)(1)
                .Cells(3).Value -= dictAbsolute.Item(0)(2)
            End If
            If dictAbsolute.ContainsKey(1) Then
                .Cells(1).Value -= dictAbsolute.Item(1)(0)
                .Cells(2).Value -= dictAbsolute.Item(1)(1)
                .Cells(3).Value -= dictAbsolute.Item(1)(2)
            End If

            .Cells(2).Value = .Cells(2).Value.ToString.ToCurrency(RemoveSpaces:=True)
            .Cells(3).Value = .Cells(2).Value.ToString.ToCurrency(RemoveSpaces:=True)
        End With

        Dgv_temp.Size = New Point(Dgv_temp.Size.Width, 31 * (Dgv_temp.Rows.Count + 1))

        Dgv_temp.Visible = True

    End Sub


    Private Sub LoadAbsoluteData(KittyType As String, Dgv_temp As DataGridView)

        Dgv_temp.Rows.Clear()
        Dgv_temp.Columns(0).HeaderText = $"KittyType: {KittyType}"

        Dim dr As OleDb.OleDbDataReader = DataReader($"Select KittyUID from Kitty_Data where KittyType={KittyType}")

        Dim dictAbsolute As New Dictionary(Of Integer, List(Of Integer)) From {{0, New List(Of Integer) From {0, 0, 0}}}


        While dr.Read
            Dim _kitty As New Kitty(UID:=dr("KittyUID"), InitializeKitty:=True, completely:=True)
            If _kitty.IsAvailed OrElse _kitty.GivenAmount = 0 Then Continue While
            If dictAbsolute.ContainsKey(_kitty.GetInstalments_LeftForMaturity) Then
                With dictAbsolute.Item(_kitty.GetInstalments_LeftForMaturity)
                    dictAbsolute.Item(_kitty.GetInstalments_LeftForMaturity) = New List(Of Integer) From { .Item(0) + 1, .Item(1) + _kitty.GivenAmount, .Item(2) + _kitty.KittyInterest}
                End With
            Else
                dictAbsolute.Add(_kitty.GetInstalments_LeftForMaturity, New List(Of Integer) From {1, _kitty.GivenAmount, _kitty.KittyInterest})
            End If
        End While

        Dim sorted = From pair In dictAbsolute
                     Order By pair.Key

        For Each i As KeyValuePair(Of Integer, List(Of Integer)) In sorted
            Dgv_temp.Rows.Add()
            If Dgv_temp.Rows.Count = 1 Then
                Dgv_temp.Rows(Dgv_temp.Rows.Count - 1).DefaultCellStyle.BackColor = SystemColors.Highlight
                Dgv_temp.Rows(Dgv_temp.Rows.Count - 1).DefaultCellStyle.ForeColor = Color.White
                Dgv_temp.Rows(Dgv_temp.Rows.Count - 1).Cells(0).Value = "Kitties Matured"
                Dgv_temp.Rows(Dgv_temp.Rows.Count - 1).Cells(1).Value = i.Value(0)
            Else
                Dgv_temp.Rows(Dgv_temp.Rows.Count - 1).Cells(0).Value = Str(i.Key) + " Instalment Left"
                Dgv_temp.Rows(Dgv_temp.Rows.Count - 1).Cells(1).Value = i.Value(0)
            End If
            Dgv_temp.Rows(Dgv_temp.Rows.Count - 1).Cells(2).Value = i.Value(1).ToCurrency(True)
            If i.Value(1) = 0 Then
                Dgv_temp.Rows(Dgv_temp.Rows.Count - 1).Cells(3).Value = Int(0).ToCurrency(True)
            Else
                Dgv_temp.Rows(Dgv_temp.Rows.Count - 1).Cells(3).Value = i.Value(2).ToCurrency(True)
            End If
        Next

        Dgv_temp.Rows.Add()
        With Dgv_temp.Rows(Dgv_temp.Rows.GetLastRow(DataGridViewElementStates.Visible))
            .DefaultCellStyle.BackColor = Color.Gold
            .DefaultCellStyle.ForeColor = Color.Black
            .Cells(0).Value = "Total:"
            Dim TotalKitties As Integer = 0
            Dim TotalAmount As Integer = 0
            Dim TotalInterest As Integer = 0
            For Each i In dictAbsolute.Values
                TotalKitties += i(0)
                TotalAmount += i(1)
                TotalInterest += i(2)
            Next
            .Cells(1).Value = TotalKitties
            .Cells(2).Value = TotalAmount.ToCurrency(RemoveSpaces:=True)
            .Cells(3).Value = TotalInterest.ToCurrency(RemoveSpaces:=True)
        End With

        Dgv_temp.Size = New Point(Dgv_temp.Size.Width, 31 * (Dgv_temp.Rows.Count + 1))

        Dgv_temp.Visible = True
    End Sub


    Private Function ReturnDgv(DgvName As String) As DataGridView
        Dim Dgv1 As New DataGridView

        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()

        Dim Column2 = New DataGridViewTextBoxColumn()
        Dim Column3 = New DataGridViewTextBoxColumn()
        Dim Column1 = New DataGridViewTextBoxColumn()
        Dim Column4 = New DataGridViewTextBoxColumn()


        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleRight
        Column2.DefaultCellStyle = DataGridViewCellStyle9
        Column2.HeaderText = "Instalments"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.SortMode = DataGridViewColumnSortMode.NotSortable
        Column2.Width = 210

        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        Column3.HeaderText = "Kitties"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Resizable = DataGridViewTriState.[True]
        Column3.SortMode = DataGridViewColumnSortMode.NotSortable
        Column3.ToolTipText = "Click To Open A New Form For The Coustmer"
        Column3.Width = 79

        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleRight
        Column1.DefaultCellStyle = DataGridViewCellStyle10
        Column1.HeaderText = "Amount"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 150

        Column4.HeaderText = "Interest"
        Column4.MinimumWidth = 8
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 150

        Dgv1.AllowUserToAddRows = False
        Dgv1.AllowUserToDeleteRows = False
        Dgv1.AllowUserToResizeColumns = False
        Dgv1.AllowUserToResizeRows = False
        DataGridViewCellStyle7.BackColor = Color.FromArgb(224, 224, 224)
        Dgv1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Dgv1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Dgv1.BackgroundColor = Color.FromArgb(32, 32, 50)
        Dgv1.BorderStyle = BorderStyle.None
        Dgv1.CellBorderStyle = DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = SystemColors.Control
        DataGridViewCellStyle8.Font = New Font("Century Schoolbook", 10.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.[True]
        Dgv1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Dgv1.Columns.AddRange(New DataGridViewColumn() {Column2, Column3, Column1, Column4})
        DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = SystemColors.Window
        DataGridViewCellStyle11.Font = New Font("Microsoft Sans Serif", 11.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = DataGridViewTriState.[False]
        Dgv1.DefaultCellStyle = DataGridViewCellStyle11
        Dgv1.EditMode = DataGridViewEditMode.EditProgrammatically
        Dgv1.Location = New Point(4, 5)
        Dgv1.Margin = New Padding(4, 5, 4, 5)
        Dgv1.MultiSelect = False
        Dgv1.Name = DgvName
        Dgv1.ReadOnly = True
        DataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = SystemColors.Control
        DataGridViewCellStyle12.Font = New Font("Microsoft Sans Serif", 10.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = DataGridViewTriState.[True]
        Dgv1.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Dgv1.RowHeadersVisible = False
        Dgv1.RowHeadersWidth = 62
        Dgv1.Size = New Size(592, 568)
        Dgv1.TabIndex = 170
        Return Dgv1
    End Function

    Private Async Sub AbsoluteButton_Click(sender As Object, e As EventArgs) Handles AbsoluteButton.Click
        Try
            With Me
                .Cursor = Cursors.AppStarting
                .Refresh()
            End With
            FlowLayoutPanel1.Controls.Clear()
            Dim dr As OleDb.OleDbDataReader = DataReader("Select DISTINCT KittyType From Kitty_Data")
            While dr.Read
                Dim Dgv1 As DataGridView = ReturnDgv("Hello")
                LoadAbsoluteData(dr(0), Dgv1)
                FlowLayoutPanel1.Controls.Add(Dgv1)
                Await Task.Delay(2500)
            End While
            With Me
                .Cursor = Cursors.Default
                .Refresh()
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Async Sub RelativeButton_Click(sender As Object, e As EventArgs) Handles RelativeButton.Click
        Try
            With Me
                .Cursor = Cursors.AppStarting
                .Refresh()
            End With
            FlowLayoutPanel1.Controls.Clear()
            Dim dr As OleDb.OleDbDataReader = DataReader("Select DISTINCT KittyType From Kitty_Data")
            While dr.Read
                Dim Dgv1 As DataGridView = ReturnDgv("Hello")
                LoadRelativeData(dr(0), Dgv1)
                FlowLayoutPanel1.Controls.Add(Dgv1)
                Await Task.Delay(2500)
            End While
            With Me
                .Cursor = Cursors.Default
                .Refresh()
            End With
        Catch ex As Exception
        End Try
    End Sub
End Class