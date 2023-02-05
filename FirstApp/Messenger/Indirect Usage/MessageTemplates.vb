Public Class MessageTemplates

    Private Property MessagesList As List(Of String)

    Private Sub MessageTemplates_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dr As OleDb.OleDbDataReader = DataReader("Select SavedMessages From Message_Data Where id=1")

        While dr.Read
            Try
                Dim SavedMessages As String = ""
                SavedMessages = dr("SavedMessages")

                If SavedMessages.Length < 1 Then Exit Sub

                MessagesList = SavedMessages.Split("|").ToList

                ShowMessages()

            Catch ex As Exception

            End Try
        End While

    End Sub

    Private Sub ShowMessages()
        FlowLayoutPanel1.Controls.Clear()

        Dim MsgIndex As Integer = 1

        For Each i In MessagesList

            If i.Length < 1 Then Continue For

            Dim _lbl As New Label With {
              .Font = New Font("Century Gothic", 12.0!, FontStyle.Bold, GraphicsUnit.Point, 0),
              .Visible = True,
              .AutoEllipsis = True,
              .ForeColor = Color.Green,
              .BackColor = Color.FromArgb(36, 60, 60),
              .Margin = New Padding(5),
              .Tag = MsgIndex
            }

            _lbl.Text = $"{MsgIndex}-" + i

            _lbl.MaximumSize = New Point(500, 0)
            _lbl.AutoSize = True

            FlowLayoutPanel1.Controls.Add(_lbl)

            AddHandler _lbl.Click, Sub(Sender As Label, e As EventArgs)

                                       RemoveHandler EditBT.Click, AddressOf Edit_Click
                                       RemoveHandler DeleteBT.Click, AddressOf DeleteBT_Click
                                       RemoveHandler CancelEditBT.Click, AddressOf CancelBT_Click

                                       If SelectMsgBT.Enabled Then
                                           Dim _selectedLabel As Label = FlowLayoutPanel1.Controls.Item(EditBT.Tag)
                                           _selectedLabel.BackColor = Color.FromArgb(36, 60, 60)
                                       End If

                                       MessageTB.Text = MessagesList(_lbl.Tag - 1)

                                       _lbl.BackColor = SystemColors.ActiveCaption

                                       AddMsgBT.Visible = False
                                       EditBT.Visible = True
                                       DeleteBT.Visible = True
                                       CancelEditBT.Visible = True
                                       SelectMsgBT.Enabled = True
                                       EditBT.Tag = _lbl.Tag - 1

                                       AddHandler EditBT.Click, AddressOf Edit_Click
                                       AddHandler DeleteBT.Click, AddressOf DeleteBT_Click
                                       AddHandler CancelEditBT.Click, AddressOf CancelBT_Click

                                   End Sub

            MsgIndex += 1

        Next
    End Sub

    Private Sub Edit_Click(sender As Object, e As EventArgs)
        If MessageTB.TextLength < 1 Then
            Exit Sub
        End If

        If HandsCheckBox.Checked Then MessageTB.Text = MessageTB.Text.Replace("{hands}", "") + "{hands}"

        MessagesList(EditBT.Tag) = MessageTB.Text
        MessageTB.Text = ""
        ShowMessages()
        SqlCommand($"Update Message_Data set SavedMessages='{String.Join("|", MessagesList)}' Where id=1")

        AddMsgBT.Visible = True
        EditBT.Visible = False
        DeleteBT.Visible = False
        CancelEditBT.Visible = False
        SelectMsgBT.Enabled = False
    End Sub

    Private Sub DeleteBT_Click(sender As Object, e As EventArgs)
        If MessageBox.Show("Are You Sure You Want To Delete This Message Template.", "Confirm Selection", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        MessagesList.RemoveAt(EditBT.Tag)
        SqlCommand($"Update Message_Data set SavedMessages='{String.Join("|", MessagesList)}' Where id=1")
        ShowMessages()
        MessageTB.Text = ""
        MessageTB.Select()
        AddMsgBT.Enabled = True
        EditBT.Visible = False
        DeleteBT.Visible = False
        CancelEditBT.Visible = False

    End Sub

    Private Sub CancelBT_Click(sender As Object, e As EventArgs)
        Dim _lbl As Label = FlowLayoutPanel1.Controls.Item(EditBT.Tag)
        _lbl.BackColor = Color.FromArgb(36, 60, 60)
        SelectMsgBT.Enabled = False
        MessageTB.Text = ""
        MessageTB.ZoomFactor = CSng(0.6)
        MessageTB.Select()

        AddMsgBT.Visible = True
        EditBT.Visible = False
        DeleteBT.Visible = False
        CancelEditBT.Visible = False
        SelectMsgBT.Enabled = False
    End Sub

    Private Sub AddMsgBT_Click(sender As Object, e As EventArgs) Handles AddMsgBT.Click
        If MessageTB.TextLength < 1 Then Exit Sub

        If HandsCheckBox.Checked Then MessageTB.Text = MessageTB.Text.Replace("{hands}", "") + "{hands}"

        MessagesList.Add(MessageTB.Text)

        ShowMessages()

        SqlCommand($"Update Message_Data set SavedMessages='{String.Join("|", MessagesList)}' Where id=1")

        MessageTB.Text = ""
        MessageTB.Select()

    End Sub

    Private Sub MessageTB_TextChanged(sender As Object, e As EventArgs) Handles MessageTB.TextChanged
        If MessageTB.Text.Contains("|") Then
            MessageBox.Show("Character |(Pipe) Is Not Allowed In Message Templates. Use Other Symbols Instead.", "Used Non Accessible Character.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MessageTB.Text = MessageTB.Text.Replace("|", "")
        ElseIf MessageTB.Text.Contains("'") Then
            MessageBox.Show("Character '(Apostrophe) Is Not Allowed In Message Templates. Use Other Symbols Like Double Apostrophe Instead->("").", "Used Non Accessible Character.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MessageTB.Text = MessageTB.Text.Replace("'", "")
        End If

        HandsCheckBox.Checked = MessageTB.Text.Contains("{hands}")

        MessageTB.ZoomFactor = CSng(0.6)
    End Sub

    Public Event MessageSelected(Msg As String)

    Private Sub SelectMsgBT_Click(sender As Object, e As EventArgs) Handles SelectMsgBT.Click
        RaiseEvent MessageSelected(MessagesList(EditBT.Tag))
    End Sub

    Private Sub HandsCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles HandsCheckBox.CheckedChanged
        If HandsCheckBox.Checked AndAlso MessageTB.Text.Replace(" ", "").Length > 1 Then
            MessageTB.Text = MessageTB.Text.Replace("{hands}", "") + "{hands}"
        ElseIf Not HandsCheckBox.Checked AndAlso MessageTB.Text.Replace(" ", "").Length > 1 Then
            MessageTB.Text = MessageTB.Text.Replace("{hands}", "")
        End If
    End Sub
End Class