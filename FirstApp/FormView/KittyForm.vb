Imports System.Data.OleDb
Imports FirstApp.Utility
Imports FontAwesome.Sharp

Public Class KittyForm

    'ENUM Dgv-> KittyForm
    Enum DgvEnum
        CheckBoxColumn = 0
        SrNoColumn = 1
        MonthColumn = 2
        DateColumn = 3
        AmountColumn = 4
        KittyTypeColumn = 5
    End Enum

    Protected _currentKitty As New Kitty


#Region "Custom Methods"
    Private Sub Months_()
        Dim dt As Date = Dgv.Rows(0).Cells(DgvEnum.DateColumn).Value

        Try
            For i = 0 To Dgv.Rows.Count - 1
                Dim d As Date
                Dim TempMonth As Integer = (dt.Month + i) Mod 12

                If TempMonth = 0 Then
                    TempMonth = 12
                End If
                d = New Date(2020, TempMonth, 1)

                Dgv.Rows(i).Cells(DgvEnum.MonthColumn).Value = d.ToString("MMMM")
            Next
            'If Matured Then
            '    Dgv.Rows(Dgv.Rows.Count - 1).Cells(DgvEnum.MonthColumn).Value = ""
            'End If
        Catch ex As Exception
            MessageBox.Show("KittyForm Months_ Error: " & ex.Message)
        End Try
    End Sub

    Private Sub DisplayRecord()
        Dgv.Rows.Clear()
        Dgv.Rows.Add(count:=_currentKitty.Duration)
        Try
            For Each i In _currentKitty.Record
                Dim L1 As Integer = LastEmptyRow()
                Dgv.Rows(L1).Cells(DgvEnum.DateColumn).Value = i.Key
                Dgv.Rows(L1).Cells(DgvEnum.AmountColumn).Value = i.Value

                For j = L1 To L1 + Int(i.Value / _currentKitty.KittyType) - 1
                    Dgv.Rows(j).Cells(DgvEnum.KittyTypeColumn).Value = _currentKitty.KittyType
                    Dgv.Rows(j).Cells(DgvEnum.CheckBoxColumn).Value = True
                    If j = Dgv.Rows.Count - 1 Then Exit For
                Next
            Next
        Catch ex As Exception
        End Try

        Months_()
        FormatCell(-2)

        If _currentKitty.IsMatured() Then
            Dgv.Rows.Add()
            With Dgv.Rows(Dgv.Rows.Count - 1)
                .DefaultCellStyle.BackColor = Color.Gold
                .DefaultCellStyle.ForeColor = Color.Black
                .Cells(DgvEnum.CheckBoxColumn).Value = True
                .Cells(DgvEnum.AmountColumn).Value = Format(_currentKitty.KittyInterest, "C0")
                .Cells(DgvEnum.KittyTypeColumn).Value = "#####"
            End With
        End If

        GivenAmountTB.Text = _currentKitty.GivenAmount

        If Not _currentKitty.IsMatured Then
            LeftAmountTB.Text = _currentKitty.TotalAmount - _currentKitty.GivenAmount
            BalanceTB.Text = GivenAmountTB.Text Mod _currentKitty.KittyType
        Else
            LeftAmountTB.Text = 0
            BalanceTB.Text = GivenAmountTB.Text - _currentKitty.TotalAmount
            MessageBox.Show("This Kitty Is Matured Can't Make More Entry", "No More Entries", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End If

    End Sub

    Private Function LastEmptyRow(Optional CheckBoxColumn As Integer = DgvEnum.CheckBoxColumn) As Integer
        Dim row As Integer = Dgv.Rows.Count
        If row = 0 Then
            Return 0
        End If

        For i = 0 To Dgv.Rows.Count - 1
            If Not Dgv.Rows(i).Cells(CheckBoxColumn).Value Then
                row = i
                Exit For
            End If
        Next
        Return row
    End Function

    Private Sub FormatCell(Optional type As Integer = -1)
        If Dgv.Rows.Count = 0 Then Exit Sub

        Dim InitialCell As Integer
        Dim LastCell As Integer

        If type = -1 Then
            InitialCell = Dgv.Rows.Count - 1
            LastCell = InitialCell
        ElseIf type = -2 Then
            InitialCell = 0
            LastCell = Dgv.Rows.Count - 1
        ElseIf type >= 0 Then
            InitialCell = type
            LastCell = type
        End If

        For i As Integer = InitialCell To LastCell
            With Dgv.Rows(i)
                If .Cells(DgvEnum.KittyTypeColumn).Value Is Nothing Then Continue For
                If .Cells(DgvEnum.KittyTypeColumn).Value.ToString.Length > 0 Then
                    .Cells(DgvEnum.CheckBoxColumn).Value = True
                    .Cells(DgvEnum.CheckBoxColumn).Style.BackColor = SystemColors.Highlight
                    .Cells(DgvEnum.CheckBoxColumn).Style.ForeColor = Color.White
                    .Cells(DgvEnum.SrNoColumn).Value = i + 1
                    .Cells(DgvEnum.KittyTypeColumn).Value = Format(.Cells(5).Value, "C0")
                    .Cells(DgvEnum.KittyTypeColumn).Style.BackColor = Color.LimeGreen
                    .Cells(DgvEnum.KittyTypeColumn).Style.ForeColor = Color.Black
                End If
                If .Cells(DgvEnum.AmountColumn).Value Is Nothing Then Continue For
                If .Cells(DgvEnum.AmountColumn).Value.ToString.Length > 0 Then
                    .Cells(DgvEnum.SrNoColumn).Value = i + 1
                    .Cells(DgvEnum.AmountColumn).Value = Format(.Cells(4).Value, "C0")
                    .Cells(DgvEnum.AmountColumn).Style.BackColor = SystemColors.Highlight
                    .Cells(DgvEnum.AmountColumn).Style.ForeColor = Color.White
                End If
            End With
        Next
    End Sub
#End Region

    Private Sub KittyForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadComboBoxData(KittyIntrestCB, Kitty.GetListOfKittyIntrests())
        LoadComboBoxData(KittyTypeCB, Kitty.GetListOfKittyTypes())
        KeyPreview = True

        '_currentKitty = New Kitty(10)
        '_currentKitty.Initialize()

        'KittyTypeCB.SelectedIndex = KittyTypeCB.FindStringExact(_currentKitty.KittyType)
        'KittyIntrestCB.SelectedIndex = KittyIntrestCB.FindStringExact(_currentKitty.KittyInterest)
        'KittyNoTB.Text = _currentKitty.KittyNo
        'TotalInstalmentsTB.Text = _currentKitty.Duration

        'EntryToDgv()
    End Sub

    Private Sub KittyTypeCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles KittyTypeCB.SelectedIndexChanged
        _currentKitty.KittyType = KittyTypeCB.SelectedItem
    End Sub

    Private Sub KittyIntrestCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles KittyIntrestCB.SelectedIndexChanged
        _currentKitty.KittyInterest = KittyIntrestCB.SelectedItem
    End Sub

    Private Sub KittyForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control And e.KeyCode = Keys.S Then
            SaveButton_Click(SaveButton, e)
        ElseIf e.Control And e.KeyCode = Keys.P Then
            PaymentButton.Select()
            PaymentButton_Click(PaymentButton, EventArgs.Empty)
            DatePicker.Select()
        ElseIf e.Control And e.KeyCode = Keys.D Then
            DeleteButton_Click(DeleteButton, EventArgs.Empty)
        End If
    End Sub

    Private Sub Controls_TextChanged(sender As TextBox, e As EventArgs) Handles KittyNoTB.TextChanged, TotalInstalmentsTB.TextChanged
        If sender.Text = "" Then Exit Sub

        If Not IsNumeric(sender.Text) OrElse sender.Text <= 0 Then
            MessageBox.Show("This Selection Must Be An Integer. Try Removing Non Numeric Characters.", "Illegeal Entry", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sender.Text = sender.Text.Substring(0, sender.TextLength - 1)
            SendKeys.Send("{End}")
            Exit Sub
        End If

        If sender Is TotalInstalmentsTB Then
            If sender.Text = 0 Then sender.Text = "" : Exit Sub
            Dgv.Rows.Clear()
            Dgv.Rows.Add(count:=sender.Text)
            _currentKitty.Duration = sender.Text
            ElseIf sender Is KittyNoTB Then
                _currentKitty.KittyNo = sender.Text
            End If
    End Sub

#Region "Button CLick"
    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If _currentKitty.Record.Count = 0 Then
            MessageBox.Show("No Record To Delete.", "Error")
            Exit Sub
        End If

        If MessageBox.Show("This Will Delete Last Kitty Entry Do You Want To Continue ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        _currentKitty.Record.Remove(_currentKitty.Record.Last.Key)
        DisplayRecord()
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        If LastEmptyRow() <> 0 AndAlso MessageBox.Show("This Will Remove All Data In Grid, Do You Want To Continue ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If
        _currentKitty.Record.Clear()
        DisplayRecord()
        EntryTB.Select()
    End Sub

    Private Sub PaymentButton_Click(sender As Object, e As EventArgs) Handles PaymentButton.Click

        'Entry Amount NOTHING
        If EntryTB.Text.Length = 0 Then EntryTB.Text = _currentKitty.KittyType

        'Entry Amount Not An Integer
        If Not IsNumeric(EntryTB.Text) Then
            EntryTB.Text = ""
            EntryTB.Select()
            Exit Sub
        End If

        ''Kitty Type Not SELECTED
        'If KittyTypeCB.SelectedIndex < 0 Then _
        '    MessageBox.Show("Please Select Kitty Type.", "Incomplete Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub _

        ''Total Instalments Not ENTERED
        'If Dgv.Rows.Count = 0 Then MessageBox.Show("Please Enter Total Instalments.", "Incomplete Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub _

        ''Intrest Not SELECTED
        'If KittyIntrestCB.SelectedIndex < 0 Then _
        '    MessageBox.Show("Please Select The Intrest On The Kitty.", "Incomplete Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub _

        ''Entry Date Greater Than Today's Date
        'If DatePicker.Value.Date > Today.Date Then
        '    If MessageBox.Show("Do You Want To Continue, Date Entered Is Greater Than Today's Date.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.No Then
        '        Exit Sub
        '    End If
        'End If

        ''Entry Amount Less Than Kitty Type
        'If EntryTB.Text > _currentKitty.KittyType Then
        '    MessageBox.Show("Can't Make Entry, Entered Amount Is Less Than Kitty Type.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    Exit Sub
        'End If

        If _currentKitty.IsMatured() AndAlso EntryTB.Text > 0 Then
            MessageBox.Show("This Kitty Is Matured Can't Make More Entry")
            Exit Sub
        End If

        Dim entryResult As Boolean = _currentKitty.AddRecord(DatePicker.Value.Date.ToShortDateString + EntryTB.Text)
        EntryTB.Select()
        'MessageBox.Show(_currentKitty.GetRecordString())
        DisplayRecord()
    End Sub

    Private Sub DissolveButton_Click(sender As Object, e As EventArgs) Handles DissolveButton.Click
        MessageBox.Show(_currentKitty.RecordString())
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        _currentKitty.Save()
    End Sub

    Private Sub NotificationButton_Click(sender As IconPictureBox, e As EventArgs) Handles NotificationButton.Click
        With sender
            If .IconChar = IconChar.BellSlash Then
                .IconChar = IconChar.Bell
                .IconColor = Color.ForestGreen
            Else
                .IconChar = IconChar.BellSlash
                .IconColor = Color.DarkRed
            End If
        End With
    End Sub

#End Region

#Region "Convenience Wrapper"

    Private Sub KeyDown_TextBoxControls(sender As Object, e As KeyEventArgs) Handles KittyNoTB.KeyDown, TotalInstalmentsTB.KeyDown, EntryTB.KeyDown, DatePicker.KeyDown
        Dim example = "Hello"

        If (e.KeyCode = Keys.Down) Or (e.KeyCode = Keys.Enter) Then
            SendKeys.Send("{Tab}")
        ElseIf e.KeyCode = Keys.Up Then
            SendKeys.Send("+{Tab}")
        End If
    End Sub

    Private Sub KittyTypeCB_KeyDown(sender As Object, e As KeyEventArgs) Handles KittyTypeCB.KeyDown
        If (e.KeyCode = Keys.Enter AndAlso e.Modifiers = Keys.Shift) Then
            'Dim Rtrn_Data As New List(Of String) From {
            '        "KittyType",
            '        "Kitty Type",
            '        "Add Kitty Type"
            '        }
            'CBoxForm.Tag = Rtrn_Data
            'CBoxForm.ShowDialog()
            'LoadCombobox("KittyType", KittyTypeCB)
        ElseIf (e.KeyCode = Keys.Enter) Then
            Try
                Dim dr As OleDbDataReader = DataReader("Select * From DefaultSetter Where KittyType='" & _currentKitty.KittyType & "'")
                While dr.Read
                    KittyTypeCB.SelectedIndex = KittyTypeCB.FindStringExact(Int(dr("KittyType")))
                    TotalInstalmentsTB.Select()
                    TotalInstalmentsTB.Text = Int(dr("Duration"))
                    KittyIntrestCB.Select()
                    KittyIntrestCB.SelectedIndex = KittyIntrestCB.FindStringExact(dr("Intrest"))
                    KittyNoTB.Select()
                End While
                dr.Close()
            Catch
            End Try
        End If
    End Sub

    Private Sub Controls_GotFocus(sender As TextBox, e As EventArgs) Handles TotalInstalmentsTB.GotFocus, KittyNoTB.GotFocus, EntryTB.GotFocus
        sender.BackColor = SystemColors.GradientActiveCaption
    End Sub

    Private Sub Controls_Leave(sender As TextBox, e As EventArgs) Handles TotalInstalmentsTB.Leave, KittyNoTB.Leave, EntryTB.Leave
        sender.BackColor = Color.White
    End Sub

    Private Sub BalanceTB_TextChanged(sender As Object, e As EventArgs) Handles BalanceTB.TextChanged, GivenAmountTB.TextChanged, LeftAmountTB.TextChanged
        Try
            sender.Text = Format(Int(sender.Text), "C0")

            If Int(sender.Text) > 0 Then
                sender.BackColor = SystemColors.HotTrack
                sender.ForeColor = Color.White
            Else
                sender.BackColor = SystemColors.ControlDark
                sender.ForeColor = Color.Black
            End If

        Catch ex As Exception
        End Try
    End Sub
#End Region


End Class