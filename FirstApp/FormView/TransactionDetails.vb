Imports FirstApp.Utility
Imports Newtonsoft.Json

Public Class TransactionDetails

    Public Property TransactionDate As New Date

    Private Sub PaymentModeCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PaymentModeCB.SelectedIndexChanged
        If PaymentModeCB.SelectedItem = "Cash" Then
            TransferedToCB.Enabled = False
            ReferenceNoTB.Enabled = False
        Else
            TransferedToCB.Enabled = True
            ReferenceNoTB.Enabled = True
        End If
    End Sub

    Public Event SaveButton_Clicked(JsonString)

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click

        Dim dict As New Dictionary(Of String, String) From {
            {"Mode", PaymentModeCB.SelectedItem},
            {"Account", TransferedToCB.SelectedItem},
            {"RefNo", ReferenceNoTB.Text},
            {"Settled", SettledChB.Checked},
            {"Notes", NotesTB.Text}
        }

        If dict.Item("Mode") Is Nothing Then
            MessageBox.Show("Can't Save Changes Without A Known Payment Mode.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf dict.Item("Mode") = "BankTransfer" AndAlso dict.Item("Account") Is Nothing Then
            MessageBox.Show("Can't Save Changes Without A Known Account To Which Money Was Transfered To.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            Dim dictString As String = JsonConvert.SerializeObject(dict, Formatting.Indented)

            RaiseEvent SaveButton_Clicked(dictString)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub TransactionDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadComboBoxData(PaymentModeCB, Kitty.GetListOfPaymentModes())
        LoadComboBoxData(TransferedToCB, Kitty.GetListOfAccounts())

        Text = $"TransactionDetails For:{TransactionDate.ToShortDateString}"

        If Tag IsNot Nothing AndAlso Tag.ToString.Length > 1 Then
            Dim SavedData As Linq.JObject = Linq.JObject.Parse(Tag)
            PaymentModeCB.SelectedIndex = PaymentModeCB.FindStringExact(SavedData.SelectToken("Mode"))
            TransferedToCB.SelectedIndex = TransferedToCB.FindStringExact(SavedData.SelectToken("Account"))
            ReferenceNoTB.Text = SavedData.SelectToken("RefNo")
            NotesTB.Text = SavedData.SelectToken("Notes")
            If SavedData.SelectToken("Settled") = "True" Then
                SettledChB.Checked = True
            Else
                SettledChB.Checked = False
            End If
        End If
        PaymentModeCB.Select()
    End Sub

    Private Sub DissolveButton_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Public Event RemoveDetails()

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        If MessageBox.Show($"Are You Sure You Want To Remove Transaction Details Of The Payment Made On {TransactionDate.ToShortDateString}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Exit Sub
        RaiseEvent RemoveDetails()
    End Sub

    Private Sub SettledChB_CheckedChanged(sender As Object, e As EventArgs) Handles SettledChB.CheckedChanged
        If SettledChB.Checked = False Then
            SettledChB.ForeColor = Color.Red
        Else
            SettledChB.ForeColor = Color.Green
        End If
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

    Private Sub ReferenceNoTB_KeyDown(sender As Object, e As KeyEventArgs) Handles ReferenceNoTB.KeyDown
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
End Class