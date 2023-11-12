Imports OrnaTrack.Utility

Public Class TransactionDetailsForm

    Public Property CurrentTransaction As Transaction = Nothing
    Public Property _kitty As Kitty = Nothing
    Dim _initalHeight As Integer = 0

    Private Sub PaymentModeCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PaymentModeCB.SelectedIndexChanged
        If PaymentModeCB.SelectedItem = "Cash" Then
            TransferedToCB.Enabled = False
            ReferenceNoTB.Enabled = False
        Else
            TransferedToCB.Enabled = True
            ReferenceNoTB.Enabled = True
        End If
    End Sub

    Public Event SaveButton_Clicked()

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click

        If PaymentModeCB.SelectedItem Is Nothing Then
            MessageBox.Show("Can't Save Changes Without A Known Payment Mode.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If TransferedToCB.SelectedItem = "BankTransfer" AndAlso TransferedToCB.SelectedItem Is Nothing Then
            MessageBox.Show("Can't Save Changes Without A Known Account To Which Money Was Transfered To.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            CurrentTransaction.TrnsDate = DatePicker.Value
            CurrentTransaction.Mode = PaymentModeCB.SelectedItem
            CurrentTransaction.Account = TransferedToCB.SelectedItem
            CurrentTransaction.Amount = TotalAmtTB.Text
            CurrentTransaction.RefNo = ReferenceNoTB.Text
            CurrentTransaction.Notes = NotesTB.Text

            Dim _amtMapped As Integer = CurrentTransaction.KittyIds.Sum(Function(f) f.Value)
            If CurrentTransaction.Amount < _amtMapped Then
                MessageBox.Show("Transaction Amount Is Less Than The Amount It Is Mapped For.", "Amount Not Sufficient", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Exit Sub
            End If

            CurrentTransaction.Save()
            RaiseEvent SaveButton_Clicked()
        Catch ex As Exception

        End Try

        Close()

    End Sub

    Private Sub TransactionDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _initalHeight = Size.Height
        LoadComboBoxData(PaymentModeCB, Kitty.GetListOfPaymentModes())
        LoadComboBoxData(TransferedToCB, Kitty.GetListOfAccounts())

        If CurrentTransaction IsNot Nothing Then
            With CurrentTransaction
                PaymentModeCB.SelectedIndex = PaymentModeCB.FindStringExact(.Mode)
                TransferedToCB.SelectedIndex = TransferedToCB.FindStringExact(.Account)
                TotalAmtTB.Text = .Amount
                If .Amount = -1 Then
                    TotalAmtTB.Text = .KittyIds.Sum(Function(f) f.Value)
                End If
                ReferenceNoTB.Text = .RefNo
                NotesTB.Text = .Notes
            End With
            ShowKitties()
        End If
        Text = $"TransactionDetails For: {CurrentTransaction.TrnsDate.ToShortDateString}"
        PaymentModeCB.Select()

        If _kitty Is Nothing Then Exit Sub

        If CurrentTransaction.KittyIds(_kitty.KittyUID) < _kitty.Record(CurrentTransaction.TrnsDate) Then
            OnlineTransactionsBT.Visible = True
        End If

        If CurrentTransaction.TrnsID < 0 Then
            OnlineTransactionsBT.Visible = True
            DeleteBT.Visible = False
        End If

    End Sub

    Private Sub ShowKitties()
        DataGridView1.Rows.Clear()
        Size = New Point(Size.Width, _initalHeight)
        DataGridView1.Size = New Point(820, 50)
        Dim _index As Integer = 1
        For Each i In CurrentTransaction.InitialisedKitty
            DataGridView1.Rows.Add()
            DataGridView1.Size = New Point(DataGridView1.Size.Width, DataGridView1.Size.Height + 34)
            With DataGridView1.Rows(DataGridView1.Rows.Count - 1)
                .Cells(0).Value = _index
                .Cells(1).Value = i.KittyUID
                .Cells(2).Value = i.KittyNo
                .Cells(3).Value = i.Owner.FullName
                .Cells(4).Value = CurrentTransaction.KittyIds(i.KittyUID).ToCurrency
                .Cells(5).Value = "Change"
                .Cells(5).Tag = i
            End With
            _index += 1
        Next
        Size = New Point(Size.Width, Size.Height + DataGridView1.Size.Height - 25)
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.ColumnIndex = 5 And e.RowIndex >= 0 Then
            Dim _taggedKitty As Kitty = DataGridView1.Rows(e.RowIndex).Cells(5).Tag
            Dim _inp As Integer = -1
            Try
                Dim x = InputBox($"Enter The Amount That KittyNo:'{_taggedKitty.KittyNo}' Should Use From This Transaction (Ex. 2000).{vbNewLine}(Enter 0 To REMOVE This Kitty From This Transaction.)", "Enter The Changed Amount")
                _inp = If(x = "", -1, x)
                If _inp = -1 Then Exit Sub
            Catch ex As Exception
                MessageBox.Show($"Can't Accept '{_inp}' As A Valid Integer. Amount Should Be An Integer Without Any Characters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

            If _inp > 0 Then
                Dim _usedAmount As Integer = CurrentTransaction.KittyIds.Where(Function(f) f.Key <> _taggedKitty.KittyUID).Sum(Function(f) f.Value)
                If _inp + _usedAmount > Int(TotalAmtTB.Text) Then
                    MessageBox.Show("Entered Amount Is Greater Than Transaction Amount Can't Make The Requested Changes.", "Amount Exeeds Transaction", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Exit Sub
                End If
                _taggedKitty.Initialize(True)
                If _taggedKitty.Record(CurrentTransaction.TrnsDate) < _inp Then
                    MessageBox.Show($"Entered Amount Is Greater Than The Amount That Was Entered In The Selected Kitty On Date: {CurrentTransaction.TrnsDate.ToShortDateString}.", "Amount Exeeds KittyAmount", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Exit Sub
                End If
                CurrentTransaction.KittyIds(_taggedKitty.KittyUID) = _inp
            End If

            If _taggedKitty Is Nothing Then Exit Sub
            If _inp = 0 Then
                If _taggedKitty.KittyUID = _kitty.KittyUID AndAlso CurrentTransaction.TrnsID < 0 Then
                    MessageBox.Show("This Kitty Has To Be Mapped With This Transaction In Order To Successfully Create An New Entry. Delete This Entry If You Want To Remove This Transaction", "Can't Remove This Kitty", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Exit Sub
                End If
                CurrentTransaction.KittyIds.Remove(_taggedKitty.KittyUID)
            Else
                If CurrentTransaction.KittyIds(_kitty.KittyUID) < _kitty.Record(CurrentTransaction.TrnsDate) Then
                    OnlineTransactionsBT.Visible = True
                End If
            End If

            ShowKitties()
        End If
    End Sub

    Private Sub DissolveButton_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Public Event RemoveDetails()

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles DeleteBT.Click
        If MessageBox.Show($"Are You Sure You Want To Remove Transaction Details Of The Payment Made On {CurrentTransaction.TrnsDate.ToShortDateString}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Exit Sub
        CurrentTransaction.Delete()
        RaiseEvent RemoveDetails()
        Close()
    End Sub

    Private Sub PaymentModeCB_KeyDown(sender As Object, e As KeyEventArgs) Handles PaymentModeCB.KeyDown
        If (e.KeyCode = Keys.Enter AndAlso e.Modifiers = Keys.Shift) Then
            Dim Rtrn_Data As New List(Of String) From {
                    "PaymentModes",
                    "Payment Mode",
                    "Add Payment Mode"
                    }
            CBoxForm.Tag = Rtrn_Data
            CBoxForm.ShowDialog()
            LoadComboBoxData(PaymentModeCB, Kitty.GetListOfPaymentModes)
        ElseIf e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub TransferedToCB_KeyDown(sender As Object, e As KeyEventArgs) Handles TransferedToCB.KeyDown
        If (e.KeyCode = Keys.Enter AndAlso e.Modifiers = Keys.Shift) Then
            Dim Rtrn_Data As New List(Of String) From {
                    "Accounts",
                    "Accounts",
                    "Add Accounts"
                    }
            CBoxForm.Tag = Rtrn_Data
            CBoxForm.ShowDialog()
            LoadComboBoxData(TransferedToCB, Kitty.GetListOfAccounts)
        ElseIf e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub ReferenceNoTB_KeyDown(sender As Object, e As KeyEventArgs) Handles ReferenceNoTB.KeyDown, TotalAmtTB.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub Control_GotFocus(sender As Control, e As EventArgs) Handles PaymentModeCB.GotFocus, TransferedToCB.GotFocus, ReferenceNoTB.GotFocus
        sender.BackColor = SystemColors.Highlight
        sender.ForeColor = SystemColors.Window
    End Sub

    Private Sub Control_LostFocus(sender As Control, e As EventArgs) Handles PaymentModeCB.LostFocus, TransferedToCB.LostFocus, ReferenceNoTB.LostFocus
        sender.BackColor = SystemColors.Window
        sender.ForeColor = SystemColors.WindowText
    End Sub

    Private Sub TotalAmtTB_GotFocus(sender As Object, e As EventArgs) Handles TotalAmtTB.GotFocus
        Try : TotalAmtTB.Text = Int(TotalAmtTB.Text) : Catch : End Try
    End Sub

    Private Sub TotalAmtTB_Leave(sender As Object, e As EventArgs) Handles TotalAmtTB.Leave
        Try
            TotalAmtTB.Text = TotalAmtTB.Text.ToCurrency()
            CurrentTransaction.Amount = Int(TotalAmtTB.Text)
        Catch
            TotalAmtTB.Text = ""
        End Try
    End Sub

    Private Sub OnlineTransactionsBT_Click(sender As Object, e As EventArgs) Handles OnlineTransactionsBT.Click
        Dim Fm As New AllTransactionsForm
        Fm.FromDatePicker.Value = CurrentTransaction.TrnsDate
        Fm.TillDatePicker.Value = CurrentTransaction.TrnsDate
        Fm.ButtonText = "Select"
        Fm.Tag = CurrentTransaction

        Close()
        Fm.Show()
        Fm.FindCoustmerButton.PerformClick()
        Fm.Visible = False
        AddHandler Fm.Cell_Clicked, Sub(_id As Integer)
                                        Dim _trns As New Transaction(_id)
                                        If _trns.Mode = "" Then
                                            MessageBox.Show("Selected Transaction Not Found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                                            Exit Sub
                                        End If
                                        Fm.Close()
                                        _trns.KittyIds.Add(_kitty.KittyUID, _kitty.Record(CurrentTransaction.TrnsDate))
                                        _trns.Save()
                                        RaiseEvent SaveButton_Clicked()
                                    End Sub

        AddHandler Fm.AddTransactionButton_Clicked, Sub()
                                                        Dim Fm_Trns As New TransactionDetailsForm
                                                        Fm_Trns.DatePicker.Value = CurrentTransaction.TrnsDate
                                                        Fm_Trns.DatePicker.Enabled = False
                                                        Fm_Trns._kitty = _kitty

                                                        Dim d = From j In _kitty.Transactions.Values Select j.Min(Function(g) g.TrnsID)
                                                        Dim _min = If(d.Count > 0, d.Min(), 0)
                                                        Dim _tempID As Integer = If(_min > -1, -1, _min - 1)
                                                        Dim _amt As Integer = 0
                                                        Try : _amt = (From i In _kitty.Transactions(CurrentTransaction.TrnsDate) Select i.Amount).Sum() : Catch : End Try
                                                        Fm_Trns.CurrentTransaction = New Transaction(_tempID) With {
                                                            .TrnsDate = CurrentTransaction.TrnsDate,
                                                            .Amount = _kitty.Record(CurrentTransaction.TrnsDate) - _amt
                                                        }
                                                        Fm_Trns.CurrentTransaction.KittyIds.Add(_kitty.KittyUID, _kitty.Record(CurrentTransaction.TrnsDate) - _amt)
                                                        Fm_Trns._kitty = _kitty

                                                        AddHandler Fm_Trns.SaveButton_Clicked, Sub()
                                                                                                   Fm_Trns.Close()
                                                                                                   Fm.Close()
                                                                                                   RaiseEvent SaveButton_Clicked()
                                                                                               End Sub

                                                        Fm_Trns.ShowDialog()
                                                    End Sub

        Fm.ShowDialog()
    End Sub

End Class