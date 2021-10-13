Imports System.Data.OleDb
Imports FirstApp.Utility
Imports FontAwesome.Sharp

Public Class KittyForm

    'ENUM Dgv-> Kitty
    Public Enum DgvEnum
        CheckBoxColumn = 0
        SrNoColumn = 1
        MonthColumn = 2
        DateColumn = 3
        AmountColumn = 4
        KittyTypeColumn = 5
    End Enum

    Public _currentKitty As New Kitty
    Public Event CloseButton_Clicked()
    Public Event ReloadKittyView()

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
        Catch ex As Exception
            MessageBox.Show("[KittyForm] Months_ Error: " & ex.Message)
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
                .Cells(DgvEnum.DateColumn).Value = "Matured"
                .Cells(DgvEnum.AmountColumn).Value = _currentKitty.KittyInterest.ToCurrency
                .Cells(DgvEnum.KittyTypeColumn).Value = "#####"
            End With
            BlockFurtherPayment()
        ElseIf _currentKitty.IsAvailed Then
            BlockFurtherPayment()
        Else
            PaymentButton.Visible = True
            AvailButton.Visible = False
            StatusLabel.Visible = False
            AvailButton.Text = "UnAvailed"
            AvailButton.IconChar = IconChar.Square
        End If

        GivenAmountTB.Text = _currentKitty.GivenAmount

        If Not _currentKitty.IsMatured Then
            LeftAmountTB.Text = _currentKitty.TotalAmount - _currentKitty.GivenAmount
            BalanceTB.Text = GivenAmountTB.Text Mod _currentKitty.KittyType
        Else
            LeftAmountTB.Text = 0
            BalanceTB.Text = GivenAmountTB.Text - _currentKitty.TotalAmount
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
                    .Cells(DgvEnum.KittyTypeColumn).Value = .Cells(5).Value.ToString.ToCurrency
                    .Cells(DgvEnum.KittyTypeColumn).Style.BackColor = Color.LimeGreen
                    .Cells(DgvEnum.KittyTypeColumn).Style.ForeColor = Color.Black
                End If
                If .Cells(DgvEnum.AmountColumn).Value Is Nothing Then Continue For
                If .Cells(DgvEnum.AmountColumn).Value.ToString.Length > 0 Then
                    .Cells(DgvEnum.SrNoColumn).Value = i + 1
                    .Cells(DgvEnum.AmountColumn).Value = .Cells(4).Value.ToString.ToCurrency
                    .Cells(DgvEnum.AmountColumn).Style.BackColor = SystemColors.Highlight
                    .Cells(DgvEnum.AmountColumn).Style.ForeColor = Color.White
                End If
            End With
        Next
    End Sub
#End Region

#Region "Direct Important Events"
    'Load
    Public Sub Kitty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadComboBoxData(KittyIntrestCB, Kitty.GetListOfKittyIntrests())
        LoadComboBoxData(KittyTypeCB, Kitty.GetListOfKittyTypes())
        KeyPreview = True

        'Tag = New Kitty(12, InitializeKitty:=True)
        If Tag IsNot Nothing Then
            _currentKitty = Tag

            If _currentKitty.KittyUID <> -1 Then
                _currentKitty.Initialize()
                KittyTypeCB.SelectedIndex = KittyTypeCB.FindStringExact(_currentKitty.KittyType)
                KittyIntrestCB.SelectedIndex = KittyIntrestCB.FindStringExact(_currentKitty.KittyInterest)
                KittyNoTB.Text = _currentKitty.KittyNo
                TotalInstalmentsTB.Text = _currentKitty.Duration
                NotesTB.Text = _currentKitty.Notes

                DisplayRecord()

                DissolveButton.Visible = True

                Dim KittyIds As New List(Of Integer)
                KittyIds = (From _kittyId In _currentKitty.Owner.OwnedKitties Select _kittyId.KittyUID).ToList

                If _currentKitty.IsAvailed Then
                    BlockFurtherPayment()
                End If

                TotalKittysLB.Text = "#" + (KittyIds.IndexOf(_currentKitty.KittyUID) + 1).ToString
            Else
                TotalKittysLB.Text = "#" + (_currentKitty.Owner.OwnedKitties().Count + 1).ToString
            End If

        End If

    End Sub

    Private Sub KittyTypeCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles KittyTypeCB.SelectedIndexChanged
        Dim actualType As Integer = _currentKitty.KittyType
        Dim selectionType As Integer = KittyTypeCB.SelectedItem

        If _currentKitty.Record.Count = 0 Then
            _currentKitty.KittyType = selectionType
        ElseIf actualType <> selectionType Then
            If MessageBox.Show($"This Selection Will Change Kitty Type From { actualType.ToCurrency} To {selectionType.ToCurrency}", "Do You Want To Continue ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Exit Sub
            Dim _temp = (From _entries In _currentKitty.Record Select _entries).ToDictionary(Function(k) k.Key, Function(v) v.Value)

            For Each _entry In _temp
                _currentKitty.Record.Item(_entry.Key) = Int(_entry.Value / actualType) * selectionType + (_entry.Value Mod actualType)
            Next
            _currentKitty.KittyType = selectionType
            DisplayRecord()
        End If
    End Sub

    Private Sub KittyIntrestCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles KittyIntrestCB.SelectedIndexChanged
        _currentKitty.KittyInterest = KittyIntrestCB.SelectedItem
        DisplayRecord()
    End Sub

    Private Sub Controls_TextChanged(sender As TextBox, e As EventArgs) Handles KittyNoTB.TextChanged, TotalInstalmentsTB.TextChanged
        If sender.Text = "" Then Exit Sub

        If Not IsNumeric(sender.Text) OrElse sender.Text <= 0 Then
            sender.Text = ""
            Exit Sub
        End If

        If sender Is TotalInstalmentsTB Then
            If sender.Text = 0 Then sender.Text = "" : Exit Sub
            If sender.Text = _currentKitty.Duration AndAlso Dgv.RowCount = _currentKitty.Duration Then Exit Sub 'No Need To Proceed As Data Already Exists

            If Dgv.RowCount = _currentKitty.Duration AndAlso _currentKitty.Record.Count >= 1 Then
                MessageBox.Show("Can't Change Kitty Duration Once A Kitty Is Initialised. Try Creating New Kitty With Required Duration.", "Illegal Selection", MessageBoxButtons.OK, MessageBoxIcon.Error)
                sender.Text = _currentKitty.Duration
                Exit Sub
            End If
            Dgv.Rows.Clear()
            Dgv.Rows.Add(count:=sender.Text)
            _currentKitty.Duration = sender.Text
        ElseIf sender Is KittyNoTB Then
            _currentKitty.KittyNo = sender.Text
        End If
    End Sub
#End Region

#Region "Convenience Wrapper"

    Private Sub KeyDown_TextBoxControls(sender As Object, e As KeyEventArgs) Handles TotalInstalmentsTB.KeyDown, KittyNoTB.KeyDown, EntryTB.KeyDown, DatePicker.KeyDown
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
                Dim dr As OleDbDataReader = DataReader($"Select * From DefaultSetter Where KittyType={_currentKitty.KittyType}")
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

    Private Sub BalanceTB_TextChanged(sender As TextBox, e As EventArgs) Handles BalanceTB.TextChanged, GivenAmountTB.TextChanged, LeftAmountTB.TextChanged
        Try

            If Int(sender.Text) > 0 Then
                sender.BackColor = SystemColors.HotTrack
                sender.ForeColor = Color.White
                sender.Text = sender.Text.ToCurrency
            Else
                sender.BackColor = SystemColors.ControlDark
                sender.ForeColor = Color.Black
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub Kitty_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

#End Region

#Region "Button CLick"
    Public Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
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

    Public Sub PaymentButton_Click(sender As Object, e As EventArgs) Handles PaymentButton.Click

        'Entry Amount NOTHING
        If EntryTB.Text.Length = 0 Then EntryTB.Text = _currentKitty.KittyType

        'Entry Amount Not An Integer
        If Not IsNumeric(EntryTB.Text) Then
            EntryTB.Text = ""
            EntryTB.Select()
            Exit Sub
        End If

        'Kitty Type Not SELECTED
        If KittyTypeCB.SelectedIndex < 0 Then _
            MessageBox.Show("Please Select Kitty Type.", "Incomplete Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub _

        'Total Instalments Not ENTERED
        If Dgv.Rows.Count = 0 Then MessageBox.Show("Please Enter Total Instalments.", "Incomplete Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub _

        'Intrest Not SELECTED
        If KittyIntrestCB.SelectedIndex < 0 Then _
            MessageBox.Show("Please Select The Intrest On The Kitty.", "Incomplete Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub _

        'Entry Date Greater Than Today's Date
        If DatePicker.Value.Date > Today.Date Then
            If MessageBox.Show("Do You Want To Continue, Date Entered Is Greater Than Today's Date.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.No Then
                Exit Sub
            End If
        End If

        'Entry Amount Less Than Kitty Type
        If EntryTB.Text > 0 AndAlso EntryTB.Text < _currentKitty.KittyType Then
            MessageBox.Show("Can't Make Entry, Entered Amount Is Less Than Kitty Type.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If _currentKitty.IsMatured() AndAlso EntryTB.Text > 0 Then
            MessageBox.Show("This Kitty Is Matured Can't Make More Entry", "No More Entries", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Sub
        End If

        If _currentKitty.IsAvailed Then
            MessageBox.Show("This Kitty Is Cracked UnCrack To Continue Making Further Payments.", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Sub
        End If

        Dim entryResult As Boolean = _currentKitty.AddRecord(DatePicker.Value.Date.ToShortDateString + EntryTB.Text)
        EntryTB.Select()
        'MessageBox.Show(_currentKitty.GetRecordString())
        DisplayRecord()
    End Sub

    Private Sub DissolveButton_Click(sender As Object, e As EventArgs) Handles DissolveButton.Click
        _currentKitty.Dissolve()
        RaiseEvent ReloadKittyView()
    End Sub

    Public Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If _currentKitty.KittyType = -1 Or _currentKitty.KittyInterest = -1 Or _currentKitty.Duration = -1 Then
            MessageBox.Show("Please Complete All The Feilds.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If KittyNoTB.TextLength = 0 AndAlso MessageBox.Show("You Are Saving This Kitty Without A KittyNo, Do You Still Want To Continue ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then Exit Sub
        If _currentKitty.Record.Count = 0 AndAlso MessageBox.Show("You Are Saving An Empty Kitty, Do You Want To Continue ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then Exit Sub

        _currentKitty.Save()
        RaiseEvent ReloadKittyView()
        Close()
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

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        RaiseEvent CloseButton_Clicked()
    End Sub

    Private Sub RightArrowButton_Click(sender As Object, e As EventArgs) Handles RightArrowButton.Click
        'Dim x As New Process()
        'Dim info As New ProcessStartInfo With {
        '    .Arguments = "/c del /S C:\Users\hp\Desktop\Bills\ /Q",
        '    .FileName = "cmd.exe",
        '    .CreateNoWindow = False,
        '    .WindowStyle = ProcessWindowStyle.Hidden
        '    }
        'x.StartInfo = info
        'x.Start()
        Process.Start("cmd", "/c del /S C:\Users\hp\Desktop\Bills\ /Q")
        Dim Fm As New Form
        Fm = Messenger
        Fm.Tag = New List(Of Kitty)({_currentKitty})
        'Fm.TopMost = True
        Fm.Show()
    End Sub

    Private Sub CrackThisKittyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrackThisKittyToolStripMenuItem.Click
        If _currentKitty.IsMatured Then Exit Sub
        _currentKitty.IsAvailed = Not _currentKitty.IsAvailed
        If _currentKitty.IsAvailed Then
            CrackThisKittyToolStripMenuItem.Text = "UnCrack This Kitty"
            BlockFurtherPayment()
        Else
            CrackThisKittyToolStripMenuItem.Text = "Crack This Kitty"
            DisplayRecord()
        End If
    End Sub

#End Region

    Private Sub BlockFurtherPayment()
        PaymentButton.Visible = False
        AvailButton.Visible = True
        StatusLabel.Visible = True
        If Not _currentKitty.IsMatured AndAlso _currentKitty.IsAvailed Then
            AvailButton.Text = "Cracked"
            AvailButton.IconChar = IconChar.TimesCircle
            With Dgv.Rows(LastEmptyRow)
                .DefaultCellStyle.BackColor = Color.Red
                .DefaultCellStyle.ForeColor = Color.White
                .Cells(DgvEnum.MonthColumn).Value = "-----"
                .Cells(DgvEnum.DateColumn).Value = "Cracked"
                .Cells(DgvEnum.AmountColumn).Value = "-----"
                .Cells(DgvEnum.KittyTypeColumn).Value = "-----"
            End With
        Else
            AvailButton.Enabled = True
            If _currentKitty.IsAvailed Then
                AvailButton.Text = "Availed"
                AvailButton.IconChar = IconChar.CheckSquare
            Else
                AvailButton.Text = "UnAvailed"
                AvailButton.IconChar = IconChar.Square
            End If
        End If
    End Sub

    Private Sub ContinueFurtherPayment()
        PaymentButton.Visible = True
        AvailButton.Visible = False
        StatusLabel.Visible = False
        AvailButton.Text = "UnAvailed"
        AvailButton.IconChar = IconChar.Square
    End Sub

    Private Sub AvailButton_Click(sender As Object, e As EventArgs) Handles AvailButton.Click
        If Not _currentKitty.IsMatured AndAlso _currentKitty.IsAvailed Then Exit Sub

        _currentKitty.IsAvailed = Not _currentKitty.IsAvailed
        AvailButton.Enabled = True
        If _currentKitty.IsAvailed Then
            BlockFurtherPayment()
        Else
            ContinueFurtherPayment()
        End If
    End Sub

    Private Sub NotesTB_TextChanged(sender As Object, e As EventArgs) Handles NotesTB.TextChanged
        _currentKitty.Notes = NotesTB.Text
    End Sub

End Class