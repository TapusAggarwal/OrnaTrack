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
        TrnsDetails = 6
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
        If _currentKitty.Duration < 0 Then Exit Sub
        Dgv.Rows.Clear()
        Dgv.Rows.Add(count:=_currentKitty.Duration)
        Try
            For Each i In _currentKitty.Record
                Dim L1 As Integer = LastEmptyRow()
                Dgv.Rows(L1).Cells(DgvEnum.DateColumn).Value = i.Key.ToString("dd MMM,yyyy")
                Dgv.Rows(L1).Cells(DgvEnum.AmountColumn).Value = i.Value

                Dim newDgvButton As New DataGridViewButtonCell

                'newDgvButton.FlatStyle = FlatStyle.Popup


                Dgv.Rows(L1).Cells(DgvEnum.TrnsDetails).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                Dgv.Rows(L1).Cells(DgvEnum.TrnsDetails) = newDgvButton


                With Dgv.Rows(L1).Cells(DgvEnum.TrnsDetails)
                    If Not _currentKitty.Transactions.ContainsKey(i.Key) Then
                        .Value = "Add"
                        .ToolTipText = "Add Transaction Details."
                        '.Style.ForeColor = Color.White
                        '.Style.BackColor = SystemColors.Highlight
                    Else
                        .Value = "Show"
                        .ToolTipText = _currentKitty.Transactions.Item(i.Key).First.RefNo
                        '.Style.ForeColor = Color.Black
                        '.Style.BackColor = Color.LimeGreen
                    End If
                End With

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
                If _currentKitty.IsAvailed Then
                    .DefaultCellStyle.BackColor = Color.Silver
                    .Cells(DgvEnum.DateColumn).Value = "Availed"
                Else
                    .DefaultCellStyle.BackColor = Color.Gold
                    .Cells(DgvEnum.DateColumn).Value = "Matured"
                End If
                .DefaultCellStyle.ForeColor = Color.Black
                .Cells(DgvEnum.CheckBoxColumn).Value = True
                .Cells(DgvEnum.AmountColumn).Value = _currentKitty.KittyInterest.ToCurrency
                .Cells(DgvEnum.KittyTypeColumn).Value = "#####"
            End With
            BlockFurtherPayment()
        ElseIf _currentKitty.IsAvailed Then
            BlockFurtherPayment()
        ElseIf _currentKitty.IsInactive Then
            BlockFurtherPayment("InActive")
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
                _currentKitty.InitializeTransactions()
                KittyTypeCB.SelectedIndex = KittyTypeCB.FindStringExact(_currentKitty.KittyType)
                KittyIntrestCB.SelectedIndex = KittyIntrestCB.FindStringExact(_currentKitty.KittyInterest)
                KittyNoTB.Text = _currentKitty.KittyNo
                TotalInstalmentsTB.Text = _currentKitty.Duration
                NotesTB.Text = _currentKitty.Notes

                DisplayRecord()

                DissolveButton.Visible = True

                If _currentKitty.IsAvailed Then
                    CrackThisKittyToolStripMenuItem.Text = "UnCrack This Kitty"
                ElseIf _currentKitty.IsInactive Then
                    MarkAsInactiveToolStripMenuItem.Text = "Mark As Active"
                End If

                Dim KittyIds As New List(Of Integer)
                KittyIds = (From _kittyId In _currentKitty.Owner.OwnedKitties Select _kittyId.KittyUID).ToList

                TotalKittysLB.Text = "#" + (KittyIds.IndexOf(_currentKitty.KittyUID) + 1).ToString
            Else
                TotalKittysLB.Text = "#" + (_currentKitty.Owner.OwnedKitties().Count + 1).ToString
            End If

        End If

    End Sub

    Private Sub KittyTypeCB_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles KittyTypeCB.SelectionChangeCommitted
        Dim actualType As Integer = _currentKitty.KittyType
        Dim selectionType As Integer = KittyTypeCB.SelectedItem

        If _currentKitty.Record.Count = 0 Then
            _currentKitty.KittyType = selectionType
        ElseIf actualType <> selectionType Then
            If MessageBox.Show($"This Selection Will Change Kitty Type From { actualType.ToCurrency} To {selectionType.ToCurrency}", "Do You Want To Continue ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                KittyTypeCB.SelectedIndex = KittyTypeCB.FindStringExact(_currentKitty.KittyType)
                Exit Sub
            End If
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
            Dim Rtrn_Data As New List(Of String) From {
                    "KittyType",
                    "Kitty Type",
                    "Add Kitty Type"
                    }
            CBoxForm.Tag = Rtrn_Data
            CBoxForm.ShowDialog()
            LoadComboBoxData(KittyTypeCB, Kitty.GetListOfKittyTypes)
        ElseIf (e.KeyCode = Keys.Enter) Then

            Dim SelectedKittyType As Integer = 0

            Try
                Dim dr As OleDbDataReader = DataReader($"Select * From DefaultSetter Where KittyType={_currentKitty.KittyType}")
                While dr.Read
                    SelectedKittyType = Int(dr("KittyType"))
                    KittyTypeCB.SelectedIndex = KittyTypeCB.FindStringExact(Int(dr("KittyType")))
                    TotalInstalmentsTB.Select()
                    TotalInstalmentsTB.Text = Int(dr("Duration"))
                    KittyIntrestCB.Select()
                    KittyIntrestCB.SelectedIndex = KittyIntrestCB.FindStringExact(dr("Intrest"))
                End While
                dr.Close()
            Catch
            End Try

            Try
                Dim dr_UID As OleDbDataReader = DataReader($"Select KittyNo From Kitty_Data Where KittyType={SelectedKittyType} ORDER BY KittyNo DESC")
                While dr_UID.Read
                    KittyNoTB.Text = Int(dr_UID("KittyNo")) + 1
                    KittyNoTB.Select()
                    Exit While
                End While
                dr_UID.Close()
            Catch ex As Exception
            End Try

        End If
    End Sub

    Private Sub KittyIntrestCB_KeyDown(sender As Object, e As KeyEventArgs) Handles KittyIntrestCB.KeyDown
        If (e.KeyCode = Keys.Enter AndAlso e.Modifiers = Keys.Shift) Then
            Dim Rtrn_Data As New List(Of String) From {
                    "KittyIntrest",
                    "Kitty Intrest",
                    "Add Kitty Intrest"
                    }
            CBoxForm.Tag = Rtrn_Data
            CBoxForm.ShowDialog()
            LoadComboBoxData(KittyIntrestCB, Kitty.GetListOfKittyIntrests)
        ElseIf (e.KeyCode = Keys.Enter) Then
            TotalInstalmentsTB.Select()
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
        'If No Record Was Found
        If _currentKitty.Record.Count = 0 Then
            MessageBox.Show("No Record To Delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'IF Kitty IS Availed
        If _currentKitty.IsAvailed Then
            MessageBox.Show("This Kitty Is Cracked, Mark It As UnCracked To Continue Making Further Activities.", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Sub
        End If

        'IF Kitty IS Inactive
        If _currentKitty.IsInactive Then
            MessageBox.Show("This Kitty Is InActive, Mark It As Active To Continue Making Further Activities.", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Sub
        End If

        Dim dateToRemove As Date = _currentKitty.Record.Last.Key

        _currentKitty.Record.Remove(dateToRemove)
        DisplayRecord()
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        If LastEmptyRow() <> 0 AndAlso MessageBox.Show("This Will Remove All Data In Grid, Do You Want To Continue ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If
        _currentKitty.Record.Clear()
        _currentKitty.IsAvailed = False
        _currentKitty.IsInactive = False
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
            MessageBox.Show("Please Select Kitty Type.", "Incomplete Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub

        'Total Instalments Not ENTERED
        If Dgv.Rows.Count = 0 Then MessageBox.Show("Please Enter Total Instalments.", "Incomplete Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub

        'Intrest Not SELECTED
        If KittyIntrestCB.SelectedIndex < 0 Then _
            MessageBox.Show("Please Select The Intrest On The Kitty.", "Incomplete Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub

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

        ' IF Kitty IS Matured
        If _currentKitty.IsMatured() AndAlso EntryTB.Text > 0 Then
            MessageBox.Show("This Kitty Is Matured Can't Make More Entry", "No More Entries", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Sub
        End If

        'IF Kitty IS Availed
        If _currentKitty.IsAvailed Then
            MessageBox.Show("This Kitty Is Cracked, Mark It As UnCracked To Continue Making Further Activities.", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Sub
        End If

        'IF Kitty IS Inactive
        If _currentKitty.IsInactive Then
            MessageBox.Show("This Kitty Is InActive, Mark It As Active To Continue Making Further Activities.", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Sub
        End If

        'Storing Wether The Result Of Entry Was True Or False
        Dim entryResult As Boolean = _currentKitty.AddRecord(DatePicker.Value.Date.ToShortDateString + EntryTB.Text)
        If entryResult = False Then Exit Sub

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
        If _currentKitty.KittyUID = -1 Then Close()
        Kitty_Load(Me, EventArgs.Empty)
        RaiseEvent ReloadKittyView()
    End Sub

    Private Sub NotificationButton_Click(sender As IconPictureBox, e As EventArgs) Handles NotificationButton.Click
        With sender
            If .IconChar = IconChar.BellSlash Then
                ' When Allowing To Send Message
                .IconChar = IconChar.Bell
                .IconColor = Color.ForestGreen
            Else
                ' When Not Allowing To Send Message
                Dim Fm As New Form

                Fm.Size = New Point(500, 250)
                Fm.StartPosition = FormStartPosition.CenterScreen
                Fm.BackColor = Color.FromArgb(36, 30, 60)

                Dim x As New Label

                x.Location = New Point(15, 0)
                x.Text = "Reason For Turning Notification Off ?"
                x.AutoSize = True
                x.Font = New Font("Century Schoolbook", 12)
                x.ForeColor = SystemColors.ActiveCaption

                Fm.Controls.Add(x)

                Dim y As New TextBox

                y.Location = New Point(10, 40)
                y.Multiline = True
                y.Size = New Point(455, 130)
                y.Font = New Font("Century Schoolbook", 10, FontStyle.Bold)
                Fm.Controls.Add(y)

                Fm.ShowDialog()

                Exit Sub

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
        Dim proc As New Process()
        proc.StartInfo.FileName = "cmd"
        proc.StartInfo.Arguments = "/c del /S C:\Users\hp\Desktop\Bills\ /Q"
        proc.Start()
        proc.WaitForExit()
        Dim Fm As New MessengerForIndividual With {
            .SelectedKitties = New List(Of Kitty)({_currentKitty})
        }
        'Fm.TopMost = True
        Fm.ShowDialog()
    End Sub

    Private Sub CrackThisKittyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrackThisKittyToolStripMenuItem.Click
        If _currentKitty.IsMatured Then
            MessageBox.Show("Can't Crack A Matured Kitty. Use Availed Instead.", "Wrong Selection", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        _currentKitty.IsAvailed = Not _currentKitty.IsAvailed
        If _currentKitty.IsAvailed Then
            _currentKitty.IsInactive = False
            MarkAsInactiveToolStripMenuItem.Text = "Mark As InActive"
            CrackThisKittyToolStripMenuItem.Text = "UnCrack This Kitty"
            BlockFurtherPayment()
        Else
            CrackThisKittyToolStripMenuItem.Text = "Crack This Kitty"
            DisplayRecord()
        End If
    End Sub

    Private Sub MarkAsInactiveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarkAsInactiveToolStripMenuItem.Click
        If _currentKitty.IsMatured Then
            MessageBox.Show("Can't Mark A Matured Kitty As InActive. Use Availed Instead.", "Wrong Selection", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        _currentKitty.IsInactive = Not _currentKitty.IsInactive
        If _currentKitty.IsInactive Then
            _currentKitty.IsAvailed = False
            CrackThisKittyToolStripMenuItem.Text = "Crack This Kitty"
            MarkAsInactiveToolStripMenuItem.Text = "Mark As Active"
            BlockFurtherPayment("InActive")
        Else
            MarkAsInactiveToolStripMenuItem.Text = "Mark As InActive"
            DisplayRecord()
        End If
    End Sub

#End Region

    Private Sub BlockFurtherPayment(Optional status As String = "Cracked")

        PaymentButton.Visible = False
        AvailButton.Visible = True
        StatusLabel.Visible = True

        If Not _currentKitty.IsMatured AndAlso (_currentKitty.IsAvailed Or _currentKitty.IsInactive) Then
            AvailButton.Text = status
            AvailButton.IconChar = IconChar.TimesCircle
            With Dgv.Rows(LastEmptyRow)
                .DefaultCellStyle.BackColor = Color.Red
                .DefaultCellStyle.ForeColor = Color.White
                .Cells(DgvEnum.MonthColumn).Value = "-----"
                .Cells(DgvEnum.DateColumn).Value = status
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
        If Not _currentKitty.IsMatured AndAlso (_currentKitty.IsAvailed Or _currentKitty.IsInactive) Then Exit Sub

        _currentKitty.IsAvailed = Not _currentKitty.IsAvailed
        AvailButton.Enabled = True
        BlockFurtherPayment()
        DisplayRecord()
        'If _currentKitty.IsAvailed Then
        'Else
        '    ContinueFurtherPayment()
        'End If
    End Sub

    Private Sub NotesTB_TextChanged(sender As Object, e As EventArgs) Handles NotesTB.TextChanged
        _currentKitty.Notes = NotesTB.Text
    End Sub

    Private Sub TransferKittyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransferKittyToolStripMenuItem.Click
        Dim Fm As New ShortCustomerSearch With {
            .HideCustomerID = _currentKitty.CustomerID
        }
        AddHandler Fm.CustomerClicked, AddressOf CustomerSelected
        Fm.Show()
    End Sub

    Private Sub CustomerSelected(NewCustomerId As Integer, Optional KittID As Integer = -1)
        If MessageBox.Show($"Are You Sure You Want To Transfer KittyNo:{_currentKitty.KittyNo} And Type:{_currentKitty.KittyType} To Customer:{New Customer(NewCustomerId).FullName} ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Exit Sub
        _currentKitty.CustomerID = NewCustomerId
        SaveButton_Click(SaveButton, EventArgs.Empty)

        For Each ExistingFm As Form In Frame.MdiChildren
            If ExistingFm.Name <> "Main" Then
                ExistingFm.Dispose()
            End If
        Next

        Dim Fm As New KittyModeCoustView With {
            .MdiParent = Frame,
            .Dock = DockStyle.Fill,
            .Tag = NewCustomerId.ToString + "_" + _currentKitty.KittyUID.ToString
        }

        Fm.Show()

    End Sub

    Private Sub IconPictureBox1_Click(sender As Object, e As EventArgs) Handles DotsButton.Click
        ContextMenuStrip1.Show(DotsButton, 0, DotsButton.Size.Height)
    End Sub

    Private Sub Dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv.CellClick
        If e.RowIndex < 0 OrElse e.ColumnIndex <> DgvEnum.TrnsDetails Then Exit Sub

        If Dgv.Rows(e.RowIndex).Cells(6).GetType <> GetType(DataGridViewButtonCell) Then Exit Sub
        Dim SelectedRowDate As Date = Dgv.Rows(e.RowIndex).Cells(DgvEnum.DateColumn).Value

        Dim Fm As New TransactionDetails
        Fm.DatePicker.Value = SelectedRowDate
        Fm.DatePicker.Enabled = False
        Fm._kitty = _currentKitty

        If Not _currentKitty.Transactions.ContainsKey(SelectedRowDate) OrElse _currentKitty.Transactions(SelectedRowDate).Count > 1 Then
            Dim d = From j In _currentKitty.Transactions.Values Select j.Min(Function(g) g.TrnsID)
            Dim _min = If(d.Count > 0, d.Min(), 0)
            Dim _tempID As Integer = If(_min > -1, -1, _min - 1)
            Dim _amt As Integer = 0
            Try : _amt = (From i In _currentKitty.Transactions(SelectedRowDate) Select i.Amount).Sum() : Catch : End Try
            Fm.CurrentTransaction = New Transaction(_tempID) With {
                .TrnsDate = SelectedRowDate,
                .Amount = _currentKitty.Record(SelectedRowDate) - _amt
            }
            Fm.CurrentTransaction.KittyIds.Add(_currentKitty.KittyUID, _currentKitty.Record(SelectedRowDate) - _amt)
        Else
            Fm.CurrentTransaction = _currentKitty.Transactions(SelectedRowDate).First.Clone()
        End If

        'If There Is Only One Transaction To Show Or New Transaction Is Being Added.
        If Not _currentKitty.Transactions.ContainsKey(SelectedRowDate) OrElse _currentKitty.Transactions(SelectedRowDate).Count = 1 Then
            AddHandler Fm.SaveButton_Clicked, AddressOf ReloadAfterTransactionForm
            AddHandler Fm.RemoveDetails, AddressOf ReloadAfterTransactionForm
            Fm.ShowDialog()
        Else
            'Multiple Transactions
            Dim Fm_Trns As New TransactionsForm
            Fm_Trns.FromDatePicker.Value = SelectedRowDate
            Fm_Trns.TillDatePicker.Value = SelectedRowDate

            AddHandler Fm_Trns.AddTransactionButton_Clicked, Sub()
                                                                 AddHandler Fm.SaveButton_Clicked, AddressOf ReloadAfterTransactionForm
                                                                 Fm.ShowDialog()
                                                                 Fm_Trns.FindCoustmerButton.PerformClick()
                                                                 Dim _sum = (From i In _currentKitty.Transactions(SelectedRowDate) Select i.Amount).Sum()
                                                                 Fm_Trns.AddMsgBT.Enabled = Not (_sum = _currentKitty.Record(SelectedRowDate))
                                                             End Sub

            Dim x = (From i In _currentKitty.Transactions(SelectedRowDate) Select i.Amount).Sum()
            Fm_Trns.AddMsgBT.Enabled = Not (x = _currentKitty.Record(SelectedRowDate))
            Fm_Trns.Show()
            Fm_Trns.FindCoustmerButton.PerformClick()
            Fm_Trns.Visible = False
            Fm_Trns.ShowDialog()
            ReloadAfterTransactionForm()
        End If


    End Sub

    Private Sub ReloadAfterTransactionForm()
        _currentKitty.InitializeTransactions()
        DisplayRecord()
    End Sub

End Class