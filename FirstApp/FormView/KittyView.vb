Public Class KittyView

    Protected _currentCustomer As Customer

    'ENUM Dgv-> KittyView
    Public Enum DgvEnum
        CheckBoxColumn = 0
        SrNoColumn = 1
        KittyNoColumn = 2
        KittyTypeColumn = 3
        PendingInstalments = 4
        GivenAmountColumn = 5
        TotalAmountColumn = 6
        StatusColumn = 7
        DetailsButtonColumn = 8
        MakeEntryColumn = 9
        KittyIDColumn = 10
    End Enum

    'ENUM MessageDGv-> KittyView
    Public Enum MessageDgvEnum
        CheckBoxColumn = 0
        SrNoColumn = 1
        KittyNoColumn = 2
        KittyTypeColumn = 3
        PendingInstalments = 4
        GivenAmountColumn = 5
        TotalAmountColumn = 6
        StatusColumn = 7
        MessageBoxColumn = 8
        KittyIDColumn = 9
    End Enum

    Public Event ShowDetailsClicked(_kitty As Kitty)

    'FUNCTION:- Loads Kitty Data On To A DataGridView
    Public Sub LoadKittyData(Dgv As DataGridView)
        Dgv.Rows.Clear()
        Dim LastInstalmentList = ""
        Try
            'Looping Through All Owned Kitties
            For Each _kitty In _currentCustomer.OwnedKitties.OrderBasedOnStatus()

                Dgv.Rows.Add()
                Dim RowNo As Integer = Dgv.Rows.Count - 1

                'Adding Corresponding Values
                With Dgv.Rows(RowNo)
                    .Cells(DgvEnum.KittyNoColumn).Value = If(_kitty.KittyNo > 0, _kitty.KittyNo, "")
                    .Cells(DgvEnum.KittyTypeColumn).Value = _kitty.KittyType.ToCurrency
                    .Cells(DgvEnum.GivenAmountColumn).Value = _kitty.GivenAmount.ToCurrency
                    .Cells(DgvEnum.TotalAmountColumn).Value = $"{_kitty.TotalAmount.ToCurrency} + {_kitty.KittyInterest.ToCurrency}"
                    .Cells(DgvEnum.PendingInstalments).Value = _kitty.PendingInstalmentsInWords(IncludeInstalmentWord:=True)
                    .Cells(DgvEnum.StatusColumn).Value = _kitty.Status
                    If Dgv Is DgvMessage Then
                        .Cells(MessageDgvEnum.KittyIDColumn).Value = _kitty
                    Else
                        .Cells(DgvEnum.KittyIDColumn).Value = _kitty
                    End If
                End With

                With Dgv.Rows(RowNo).Cells(DgvEnum.PendingInstalments).Style
                    If _kitty.GetInstalmentsPending = -1 Or _kitty.GetInstalmentsPending >= 1 Then
                        .ForeColor = Color.Red
                    Else
                        .ForeColor = Color.Green
                    End If
                End With

                If _kitty.IsMatured Or _kitty.IsAvailed Or _kitty.IsInactive Then
                    With Dgv.Rows(RowNo)
                        .Cells(DgvEnum.CheckBoxColumn).Value = True
                        .Cells(DgvEnum.PendingInstalments).Value = String.Empty
                        .Cells(DgvEnum.CheckBoxColumn).Style.BackColor = SystemColors.Highlight
                        .Cells(DgvEnum.CheckBoxColumn).Style.ForeColor = SystemColors.Highlight
                        .Cells(DgvEnum.GivenAmountColumn).Style.BackColor = SystemColors.Highlight
                        .Cells(DgvEnum.TotalAmountColumn).Style.BackColor = SystemColors.Highlight
                        .Cells(DgvEnum.GivenAmountColumn).Style.ForeColor = Color.White
                        .Cells(DgvEnum.TotalAmountColumn).Style.ForeColor = Color.White
                        If _kitty.IsInactive Then .Cells(DgvEnum.StatusColumn).Style.ForeColor = Color.Silver
                        If _kitty.IsMatured Then .Cells(DgvEnum.StatusColumn).Style.ForeColor = Color.Gold
                        If _kitty.IsAvailed Then .Cells(DgvEnum.StatusColumn).Style.ForeColor = Color.Red
                    End With
                End If

            Next
        Catch ex As Exception
            MessageBox.Show($"[Kittyview] LoadKittyData : {ex.Message}")
        End Try

        SrNoUpdate(Dgv, DgvEnum.SrNoColumn)
    End Sub

    Public Sub KittyView_Load() Handles MyBase.Load
        _currentCustomer = Tag
        LoadKittyData(DgvMain)
    End Sub

    'EVENT:- ShowDetailsBUTTON MakeEntryBUTTON CLICK->(Shows KittyForm / UpdatesKittyID / ReLoadsKittyData)
    Public Sub Dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvMain.CellClick
        If e.RowIndex < 0 OrElse e.ColumnIndex < DgvEnum.DetailsButtonColumn Then Exit Sub

        Dim _kitty As Kitty = DgvMain.Rows(e.RowIndex).Cells(DgvEnum.KittyIDColumn).Value

        If e.ColumnIndex = DgvEnum.DetailsButtonColumn Then         'EVENT-> (Show Details) Click On Dvg

            'Invoke Event To Reload KittyView Data Because Changes Are Made TO Kitty
            RaiseEvent ShowDetailsClicked(_kitty)

        ElseIf e.ColumnIndex = DgvEnum.MakeEntryColumn Then         'EVENT-> Make Entry Click On Dvg

            If _kitty.IsMatured Then 'Raising Error:- When Making Entry On Matured Kitty's
                MessageBox.Show("[KittyView] This Kitty Is Matured, Can't Make Entry.", "EntryError")
                Exit Sub
            End If

            If _kitty.IsAvailed Then
                MessageBox.Show("[KittyView] This Kitty Is Cracked UnCrack To Continue Making Further Payments.", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Sub
            End If

            If MessageBox.Show($"Entry Of Amount {_kitty.KittyType.ToCurrency} To {_kitty.Owner.FullName("-")}", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Exit Sub

            _kitty.AddRecord(Today.Date.ToShortDateString + _kitty.KittyType.ToString)
            _kitty.Save()
            LoadKittyData(DgvMain)
        End If
    End Sub

    'EVENT:- Message CheckBox Checked->(Shows Message Dgv) 
    Private Sub MarriedCheckBox_CheckedChanged(sender As CheckBox, e As EventArgs) _
        Handles MessageCheckBox.CheckedChanged
        If sender.Checked Then
            LoadKittyData(DgvMessage)
            DgvMain.Visible = False
            DgvMessage.Visible = True
        Else
            DgvMain.Visible = True
            DgvMessage.Visible = False
            ActivateButton(Activate:=False)
        End If
    End Sub

    'FUNCTION:- Activate Send Message Button
    Private Sub ActivateButton(Activate As Boolean)
        If Activate Then
            SendMessageButton.ForeColor = Color.MediumPurple
            SendMessageButton.Enabled = True
        Else
            SendMessageButton.ForeColor = Color.DimGray
            SendMessageButton.Enabled = False
        End If
    End Sub

    'EVENT:- CheckBox On Message Dgv Clicked->(Checks CheckBox / Activates Button)
    Private Sub DgvMessage_CellClick(sender As DataGridView, e As DataGridViewCellEventArgs) Handles DgvMessage.CellClick
        If e.ColumnIndex = MessageDgvEnum.MessageBoxColumn And e.RowIndex >= 0 Then
            With sender.Rows(e.RowIndex).Cells(e.ColumnIndex)
                If .Value Then
                    .Value = False
                Else
                    .Value = True
                End If
            End With

            For i = 0 To sender.Rows.Count - 1
                If sender.Rows(i).Cells(DgvEnum.DetailsButtonColumn).Value Then
                    ActivateButton(Activate:=True)
                    Exit Sub
                End If
            Next
            ActivateButton(Activate:=False)
        End If
    End Sub

    Private Sub SendMessageButton_Click(sender As Object, e As EventArgs) Handles SendMessageButton.Click
        Dim SelectedKitty As New List(Of Kitty)
        For RowNo = 0 To DgvMessage.Rows.Count - 1
            If DgvMessage.Rows(RowNo).Cells(MessageDgvEnum.MessageBoxColumn).Value Then
                SelectedKitty.Add(DgvMessage.Rows(RowNo).Cells(MessageDgvEnum.KittyIDColumn).Value)
            End If
        Next

        Dim Fm As New Form
        Fm = Messenger
        Fm.Tag = SelectedKitty
        Fm.Show()
    End Sub

End Class