Public Class MessageSender

    ReadOnly SelectedColour As Color = Color.Wheat
    ReadOnly UnselectedColour As Color = Color.Transparent
    ReadOnly OverColour As Color = Color.FromArgb(36, 30, 70)

    Private Sub BoldButton_Click_1() Handles BoldButton.Click
        If Not String.IsNullOrWhiteSpace(MessageTB.SelectedText) Then

            If MessageTB.SelectionFont.Style = FontStyle.Bold Then
                MessageTB.SelectionFont = New Font(MessageTB.Font.FontFamily, MessageTB.SelectionFont.Size,
                                                   FontStyle.Regular)
            Else
                'MessageTB.SelectionFont = New Font(MessageTB.Font.FontFamily, MessageTB.SelectionFont.Size, FontStyle.Bold)
                'PreviewTB.Select()
                MessageTB.Text = MakeBold(MessageTB.Text, MessageTB.SelectedText)
                'PreviewTB.SelectionStart = MessageTB.SelectionStart
                'PreviewTB.SelectionLength = MessageTB.SelectionLength
                'PreviewTB.SelectedText = $"'{PreviewTB.SelectedText}'"
            End If
        End If

        MessageTB.Select()
        SendKeys.Send("{End}")
    End Sub

    Private Function MakeBold(allstring As String, toFind As String) As String
        Return allstring.Replace(toFind, [String].Format("'{0}'", toFind))
    End Function

    Private Sub ItalicButton_Click() Handles ItalicButton.Click
        If String.IsNullOrWhiteSpace(MessageTB.SelectedText) Then Exit Sub
        If MessageTB.SelectionFont.Style = FontStyle.Italic Then
            MessageTB.SelectionFont = New Font(MessageTB.Font.FontFamily, MessageTB.SelectionFont.Size,
                                               FontStyle.Regular)
        Else
            MessageTB.SelectionFont = New Font(MessageTB.Font.FontFamily, MessageTB.SelectionFont.Size, FontStyle.Italic)
        End If
        MessageTB_SelectionChanged()
        MessageTB.Select()
    End Sub

    Private Sub UnderlineButton_Click() Handles UnderlinedButton.Click
        If String.IsNullOrWhiteSpace(MessageTB.SelectedText) Then Exit Sub
        If MessageTB.SelectionFont.Style = FontStyle.Underline Then
            MessageTB.SelectionFont = New Font(MessageTB.Font.FontFamily, MessageTB.SelectionFont.Size,
                                               FontStyle.Regular)
        Else
            MessageTB.SelectionFont = New Font(MessageTB.Font.FontFamily, MessageTB.SelectionFont.Size,
                                               FontStyle.Underline)
        End If
        MessageTB_SelectionChanged()
        MessageTB.Select()
    End Sub

    Private Sub StrikeoutButton_Click() Handles StrikeoutButton.Click
        If String.IsNullOrWhiteSpace(MessageTB.SelectedText) Then Exit Sub
        If MessageTB.SelectionFont.Style = FontStyle.Strikeout Then
            MessageTB.SelectionFont = New Font(MessageTB.Font.FontFamily, MessageTB.SelectionFont.Size,
                                               FontStyle.Regular)
        Else
            MessageTB.SelectionFont = New Font(MessageTB.Font.FontFamily, MessageTB.SelectionFont.Size,
                                               FontStyle.Strikeout)
        End If
        MessageTB_SelectionChanged()
        MessageTB.Select()
    End Sub

    Private Sub RedoButton_Click(sender As Object, e As EventArgs) Handles RedoButton.Click
        MessageTB.Redo()
    End Sub

    Private Sub UndoButton_Click(sender As Object, e As EventArgs) Handles UndoButton.Click
        MessageTB.Undo()
    End Sub

    Private Sub MessageTB_SelectionChanged() Handles MessageTB.SelectionChanged
        'Updates the properties for the selected text
        Try
            If MessageTB.SelectionFont.Style = FontStyle.Bold Then
                BoldButton.BackColor = SelectedColour
                BoldButton.FlatAppearance.MouseOverBackColor = SelectedColour
                BoldButton.FlatAppearance.MouseDownBackColor = UnselectedColour
            Else
                BoldButton.FlatAppearance.MouseOverBackColor = OverColour
                BoldButton.FlatAppearance.MouseDownBackColor = SelectedColour
                BoldButton.BackColor = UnselectedColour
            End If
            If MessageTB.SelectionFont.Style = FontStyle.Italic Then
                ItalicButton.FlatAppearance.MouseOverBackColor = SelectedColour
                ItalicButton.FlatAppearance.MouseDownBackColor = UnselectedColour
                ItalicButton.BackColor = SelectedColour
            Else
                ItalicButton.FlatAppearance.MouseOverBackColor = OverColour
                ItalicButton.FlatAppearance.MouseDownBackColor = SelectedColour
                ItalicButton.BackColor = UnselectedColour
            End If
            If MessageTB.SelectionFont.Style = FontStyle.Underline Then
                UnderlinedButton.FlatAppearance.MouseOverBackColor = SelectedColour
                UnderlinedButton.FlatAppearance.MouseDownBackColor = UnselectedColour
                UnderlinedButton.BackColor = SelectedColour
            Else
                UnderlinedButton.FlatAppearance.MouseOverBackColor = OverColour
                UnderlinedButton.FlatAppearance.MouseDownBackColor = SelectedColour
                UnderlinedButton.BackColor = UnselectedColour
            End If
            If MessageTB.SelectionFont.Style = FontStyle.Strikeout Then
                StrikeoutButton.FlatAppearance.MouseOverBackColor = SelectedColour
                StrikeoutButton.FlatAppearance.MouseDownBackColor = UnselectedColour
                StrikeoutButton.BackColor = SelectedColour
            Else
                StrikeoutButton.FlatAppearance.MouseOverBackColor = OverColour
                StrikeoutButton.FlatAppearance.MouseDownBackColor = SelectedColour
                StrikeoutButton.BackColor = UnselectedColour
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub MessageTB_TextChanged(sender As Object, e As EventArgs) Handles MessageTB.TextChanged
        PreviewTB.Text = PreviewTB.Text.Replace("a", "")
        'PreviewTB.Text = MessageTB.Text
    End Sub

    Private Sub SendButton_Click(sender As Object, e As EventArgs) Handles SendButton.Click
        Dim dr As OleDb.OleDbDataReader = DataReader("Select SrNo From Coustmers_Data")

    End Sub

    Private Sub MessageSender_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class