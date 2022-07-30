Public Class MessageSender

    Public Property SelectedKitties As New List(Of Kitty)

    Dim MessagesList As New List(Of String)

    Structure Templates
        Const Greeting = "{Greet}"
        Const CoustName = "{CoustName}"
        Const CoustPhNo = "{CoustPhNo}"
        Const KittyType = "{KittyType}"
        Const KittyNo = "{KittyNo}"
        Const InstalmentsCompleted = "{InstCompl}"
        Const PeriodIntalmentsCompleted = "{InstCompMonth}"
        Const GivenAmount = "{GivenAmt}"
        Const InstalmentsPending = "{InstPend}"
        Const PeriodInstalmentsPending = "{InstPendMonth}"
        Const PendingAmount = "{PendingAmt}"
    End Structure

#Region "Direct Method Events"
    Private Sub CoustNameButton_Click(sender As Object, e As EventArgs) Handles CoustNameButton.Click
        MessageTB.SelectedText = Templates.CoustName
        MessageTB.Select()
        SendKeys.Send("{End}")
    End Sub

    Private Sub CoustNameButton_MouseHover(sender As Object, e As EventArgs) Handles CoustNameButton.MouseHover
        If ToolTipChB.Checked Then
            ToolTip1.Show("Add Coustmer's Name To The Message" & Environment.NewLine & "Ex: Tapus Aggarwal", CoustNameButton, 3000)
        End If
    End Sub

    Private Sub PhNo_Click(sender As Object, e As EventArgs) Handles PhNoButton.Click
        MessageTB.SelectedText = Templates.CoustPhNo
        MessageTB.Select()
        SendKeys.Send("{End}")
    End Sub

    Private Sub PhNoButton_MouseHover(sender As Object, e As EventArgs) Handles PhNoButton.MouseHover
        If ToolTipChB.Checked Then
            ToolTip1.Show("Add Coustmer's PhNo To The Message" & Environment.NewLine & "Ex: 9882960863,9816057863", PhNoButton, 3000)
        End If
    End Sub

    Private Sub KittyTypeButton_Click(sender As Object, e As EventArgs) Handles KittyTypeButton.Click
        MessageTB.SelectedText = Templates.KittyType
        MessageTB.Select()
        SendKeys.Send("{End}")
    End Sub

    Private Sub KittyTypeButton_MouseHover(sender As Object, e As EventArgs) Handles KittyTypeButton.MouseHover
        If ToolTipChB.Checked Then
            ToolTip1.Show("Adds KittyType To The Message" & Environment.NewLine & "Ex: ₹2,000", KittyTypeButton, 3000)
        End If
    End Sub

    Private Sub KittyNoButton_Click(sender As Object, e As EventArgs) Handles KittyNoButton.Click
        MessageTB.SelectedText = Templates.KittyNo
        MessageTB.Select()
        SendKeys.Send("{End}")
    End Sub

    Private Sub KittyNoButton_MouseHover(sender As Object, e As EventArgs) Handles KittyNoButton.MouseHover
        If ToolTipChB.Checked Then
            ToolTip1.Show("Adds KittyNo To The Message" & Environment.NewLine & "Ex: 984", KittyNoButton, 3000)
        End If
    End Sub

    Private Sub InstCompletedButton_Click(sender As Object, e As EventArgs) Handles InstCompletedButton.Click
        MessageTB.SelectedText = Templates.InstalmentsCompleted
        MessageTB.Select()
        SendKeys.Send("{End}")
    End Sub

    Private Sub InstCompletedButton_MouseHover(sender As Object, e As EventArgs) Handles InstCompletedButton.MouseHover
        If ToolTipChB.Checked Then
            ToolTip1.Show("Adds Till Date Instalments Completed To The Message" & Environment.NewLine & "Ex: 3", InstCompletedButton, 3000)
        End If
    End Sub

    Private Sub CompMonthButton_Click(sender As Object, e As EventArgs) Handles CompMonthButton.Click
        MessageTB.SelectedText = Templates.PeriodIntalmentsCompleted
        MessageTB.Select()
        SendKeys.Send("{End}")
    End Sub

    Private Sub CompMonthButton_MouseHover(sender As Object, e As EventArgs) Handles CompMonthButton.MouseHover
        If ToolTipChB.Checked Then
            ToolTip1.Show($"Adds Till Date Instalments Completed As Months To The Message{Environment.NewLine}Ex1: Dec(2020){Environment.NewLine}Ex2: Dec(2020),Jan(2021){Environment.NewLine}Ex3: Dec(2020)-Feb(2021)", InstCompletedButton, 4000)
        End If
    End Sub

    Private Sub GivenAmountButton_Click(sender As Object, e As EventArgs) Handles GivenAmountButton.Click
        MessageTB.SelectedText = Templates.GivenAmount
        MessageTB.Select()
        SendKeys.Send("{End}")
    End Sub

    Private Sub GivenAmountButton_MouseHover(sender As Object, e As EventArgs) Handles GivenAmountButton.MouseHover
        If ToolTipChB.Checked Then
            ToolTip1.Show($"Adds Till Date Given Amount To The Message{Environment.NewLine}Ex: ₹4,000", GivenAmountButton, 3000)
        End If
    End Sub

    Private Sub PendingInstButton_Click(sender As Object, e As EventArgs) Handles PendingInstButton.Click
        MessageTB.SelectedText = Templates.InstalmentsPending
        MessageTB.Select()
        SendKeys.Send("{End}")
    End Sub

    Private Sub PendingInstButton_MouseHover(sender As Object, e As EventArgs) Handles PendingInstButton.MouseHover
        If ToolTipChB.Checked Then
            ToolTip1.Show("Adds Total Instalments Pending To The Message" & Environment.NewLine & "Ex: 2", InstCompletedButton, 3000)
        End If
    End Sub

    Private Sub PendingMonthButton_Click(sender As Object, e As EventArgs) Handles PendingMonthButton.Click
        MessageTB.SelectedText = Templates.PeriodInstalmentsPending
        MessageTB.Select()
        SendKeys.Send("{End}")
    End Sub

    Private Sub PendingMonthButton_MouseHover(sender As Object, e As EventArgs) Handles PendingMonthButton.MouseHover
        If ToolTipChB.Checked Then
            ToolTip1.Show($"Adds Total Instalments Pending As Months To The Message{Environment.NewLine}Ex1: Dec(2020){Environment.NewLine}Ex2: Dec(2020),Jan(2021){Environment.NewLine}Ex3: Dec(2020)-Feb(2021)", PendingMonthButton, 4000)
        End If
    End Sub

    Private Sub PendingAmountButton_Click(sender As Object, e As EventArgs) Handles PendingAmountButton.Click
        MessageTB.SelectedText = Templates.PendingAmount
        MessageTB.Select()
        SendKeys.Send("{End}")
    End Sub

    Private Sub PendingAmountButton_MouseHover(sender As Object, e As EventArgs) Handles PendingAmountButton.MouseHover
        If ToolTipChB.Checked Then
            ToolTip1.Show($"Adds Total Pending Amount To The Message{Environment.NewLine}Ex: ₹3,000", GivenAmountButton, 3000)
        End If
    End Sub

    Private Sub GreetButton_Click(sender As Object, e As EventArgs) Handles GreetButton.Click
        MessageTB.SelectedText = Templates.Greeting
        MessageTB.Select()
        SendKeys.Send("{End}")
    End Sub

    Private Sub GreetButton_MouseHover(sender As Object, e As EventArgs) Handles GreetButton.MouseHover
        If ToolTipChB.Checked Then
            ToolTip1.Show($"Adds A Greeting To Template.{Environment.NewLine}Ex: {MessagePreviewForm.Greet()}", GreetButton, 3000)
        End If
    End Sub
#End Region

    Private Sub MessageSender_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitaliseConnection()
        Try : myconnection.Open() : Catch : End Try

        ImagePanel.Visible = False
        Size = New Point(Width - ImagePanel.Width + 7, Height)

        MessageTB.Text = "{Greet}
Dear, {CoustName} Ji
{CoustPhNo}
Your Kitty Of {KittyType}({KittyNo})
Is Due From-: {InstPendMonth}
Instalment Pending({InstPend}) = {PendingAmt}
Instalments Completed({InstCompl})-: {InstCompMonth}
You Can Also Pay Online Account Info Below."

    End Sub

    Private Sub ToolTipChB_CheckedChanged(sender As Object, e As EventArgs) Handles ToolTipChB.CheckedChanged
        If Not ToolTipChB.Checked Then
            ToolTip1.Hide(Me)
        End If
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

                                       If AddMsgBT.Enabled = False Then
                                           Dim _selectedLabel As Label = FlowLayoutPanel1.Controls.Item(EditBT.Tag)
                                           _selectedLabel.BackColor = Color.FromArgb(36, 60, 60)
                                       End If

                                       MessageTB.Text = MessagesList(_lbl.Tag - 1)
                                       MessageTB.ZoomFactor = CSng(0.6)


                                       _lbl.BackColor = SystemColors.ActiveCaption

                                       EditBT.Visible = True
                                       DeleteBT.Visible = True
                                       CancelEditBT.Visible = True
                                       AddMsgBT.Enabled = False
                                       EditBT.Tag = _lbl.Tag - 1

                                       AddHandler EditBT.Click, AddressOf Edit_Click
                                       AddHandler DeleteBT.Click, AddressOf DeleteBT_Click
                                       AddHandler CancelEditBT.Click, AddressOf CancelBT_Click

                                   End Sub

            MsgIndex += 1

        Next
    End Sub

    Private Sub AddMsgBT_Click(sender As Object, e As EventArgs) Handles AddMsgBT.Click
        If MessageTB.TextLength < 1 Then Exit Sub

        If HandsCheckBox.Checked Then MessageTB.Text = MessageTB.Text.Replace("{hands}", "") + "{hands}"

        MessagesList.Add(MessageTB.Text)

        ShowMessages()

        MessageTB.Text = ""
        MessageTB.Select()
    End Sub

    Private Sub Edit_Click(sender As Object, e As EventArgs)
        If MessageTB.TextLength < 1 Then
            Exit Sub
        End If

        If HandsCheckBox.Checked Then MessageTB.Text = MessageTB.Text.Replace("{hands}", "") + "{hands}"

        MessagesList(EditBT.Tag) = MessageTB.Text
        MessageTB.Text = ""
        ShowMessages()

        AddMsgBT.Enabled = True
        EditBT.Visible = False
        DeleteBT.Visible = False
        CancelEditBT.Visible = False
    End Sub

    Private Sub DeleteBT_Click(sender As Object, e As EventArgs)
        If MessageBox.Show("Are You Sure You Want To Delete This Message Template.", "Confirm Selection", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        MessagesList.RemoveAt(EditBT.Tag)
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
        MessageTB.Text = ""
        MessageTB.Select()

        AddMsgBT.Enabled = True
        EditBT.Visible = False
        DeleteBT.Visible = False
        CancelEditBT.Visible = False
    End Sub

    Private Sub PreviewBT_Click(sender As Object, e As EventArgs) Handles PreviewBT.Click
        Using Fm As New MessagePreviewForm
            Fm.SelectedKitties = SelectedKitties
            Dim MessageText As String = String.Join($"{Environment.NewLine}{Environment.NewLine}<Next Message>{Environment.NewLine}{Environment.NewLine}", MessagesList)

            Dim imgPaths As New List(Of String)

            For Each cntrl In ImagePanel.Controls
                Try
                    Dim imgBox As PictureBox = cntrl
                    imgPaths.Add(imgBox.ImageLocation)
                Catch ex As Exception
                End Try
            Next

            SqlCommand($"Update Message_Data set MessageText='{MessageText}' where id=1")
            SqlCommand($"Update Message_Data set ImagePaths='{String.Join(",", imgPaths)}' where id=1")

            Fm.ClearPrevious()
            Fm.ShowDialog()
        End Using
    End Sub

    Private Sub AddImageBT_Click(sender As Object, e As EventArgs) Handles AddImageBT.Click
        Try

            Dim img As New OpenFileDialog With {
                .Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"
            }
            If img.ShowDialog = DialogResult.OK Then
                Dim ImageBox As New PictureBox With {
                    .Image = Image.FromFile(img.FileName),
                    .ImageLocation = img.FileName,
                    .Size = New Point(.Image.Width, .Image.Height),
                    .SizeMode = PictureBoxSizeMode.Zoom
                }

                If ImageBox.Height > 300 Then
                    ImageBox.Height = 300
                End If

                If ImageBox.Width > 280 Then
                    ImageBox.Width = 280
                End If

                ImagePanel.Controls.Add(ImageBox)

                AddHandler ImageBox.DoubleClick, Sub()
                                                     ImagePanel.Controls.Remove(ImageBox)
                                                     If ImagePanel.Controls.Count = 0 Then
                                                         ImageRemoveLB.Visible = False
                                                         ImagePanel.Visible = False
                                                         Size = New Point(Width - ImagePanel.Width + 7, Height)
                                                     End If
                                                 End Sub

                If ImagePanel.Visible = False Then
                    ImageRemoveLB.Visible = True
                    ImagePanel.Visible = True
                    Size = New Point(Width + ImagePanel.Width - 7, Height)
                End If

            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub SavedTemplatesBT_Click(sender As Object, e As EventArgs) Handles SavedTemplatesBT.Click
        Dim Fm As New MessageTemplates

        AddHandler Fm.MessageSelected, Sub(Msg As String)
                                           MessageTB.Text = Msg
                                           Fm.Close()
                                       End Sub

        Fm.Show()

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

    Private Sub HandsCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles HandsCheckBox.CheckedChanged
        If HandsCheckBox.Checked AndAlso MessageTB.Text.Replace(" ", "").Length > 1 Then
            MessageTB.Text = MessageTB.Text.Replace("{hands}", "") + "{hands}"
        ElseIf Not HandsCheckBox.Checked AndAlso MessageTB.Text.Replace(" ", "").Length > 1 Then
            MessageTB.Text = MessageTB.Text.Replace("{hands}", "")
        End If
    End Sub
End Class

'ReadOnly SelectedColour As Color = Color.Wheat
'ReadOnly UnselectedColour As Color = Color.Transparent
'ReadOnly OverColour As Color = Color.FromArgb(36, 30, 70)

'Private Sub BoldButton_Click_1() Handles BoldButton.Click
'    If Not String.IsNullOrWhiteSpace(MessageTB.SelectedText) Then

'        If MessageTB.SelectionFont.Style = FontStyle.Bold Then
'            MessageTB.SelectionFont = New Font(MessageTB.Font.FontFamily, MessageTB.SelectionFont.Size,
'                                                   FontStyle.Regular)
'        Else
'            'MessageTB.SelectionFont = New Font(MessageTB.Font.FontFamily, MessageTB.SelectionFont.Size, FontStyle.Bold)
'            'PreviewTB.Select()
'            MessageTB.Text = MakeBold(MessageTB.Text, MessageTB.SelectedText)
'            'PreviewTB.SelectionStart = MessageTB.SelectionStart
'            'PreviewTB.SelectionLength = MessageTB.SelectionLength
'            'PreviewTB.SelectedText = $"'{PreviewTB.SelectedText}'"
'        End If
'    End If

'    MessageTB.Select()
'    SendKeys.Send("{End}")
'End Sub

'Private Function MakeBold(allstring As String, toFind As String) As String
'    Return allstring.Replace(toFind, [String].Format("'{0}'", toFind))
'End Function

'Private Sub ItalicButton_Click() Handles ItalicButton.Click
'    If String.IsNullOrWhiteSpace(MessageTB.SelectedText) Then Exit Sub
'    If MessageTB.SelectionFont.Style = FontStyle.Italic Then
'        MessageTB.SelectionFont = New Font(MessageTB.Font.FontFamily, MessageTB.SelectionFont.Size,
'                                               FontStyle.Regular)
'    Else
'        MessageTB.SelectionFont = New Font(MessageTB.Font.FontFamily, MessageTB.SelectionFont.Size, FontStyle.Italic)
'    End If
'    MessageTB_SelectionChanged()
'    MessageTB.Select()
'End Sub

'Private Sub UnderlineButton_Click() Handles UnderlinedButton.Click
'    If String.IsNullOrWhiteSpace(MessageTB.SelectedText) Then Exit Sub
'    If MessageTB.SelectionFont.Style = FontStyle.Underline Then
'        MessageTB.SelectionFont = New Font(MessageTB.Font.FontFamily, MessageTB.SelectionFont.Size,
'                                               FontStyle.Regular)
'    Else
'        MessageTB.SelectionFont = New Font(MessageTB.Font.FontFamily, MessageTB.SelectionFont.Size,
'                                               FontStyle.Underline)
'    End If
'    MessageTB_SelectionChanged()
'    MessageTB.Select()
'End Sub

'Private Sub StrikeoutButton_Click() Handles StrikeoutButton.Click
'    If String.IsNullOrWhiteSpace(MessageTB.SelectedText) Then Exit Sub
'    If MessageTB.SelectionFont.Style = FontStyle.Strikeout Then
'        MessageTB.SelectionFont = New Font(MessageTB.Font.FontFamily, MessageTB.SelectionFont.Size,
'                                               FontStyle.Regular)
'    Else
'        MessageTB.SelectionFont = New Font(MessageTB.Font.FontFamily, MessageTB.SelectionFont.Size,
'                                               FontStyle.Strikeout)
'    End If
'    MessageTB_SelectionChanged()
'    MessageTB.Select()
'End Sub

'Private Sub RedoButton_Click(sender As Object, e As EventArgs) Handles RedoButton.Click
'    MessageTB.Redo()
'End Sub

'Private Sub UndoButton_Click(sender As Object, e As EventArgs) Handles UndoButton.Click
'    MessageTB.Undo()
'End Sub

'Private Sub MessageTB_SelectionChanged() Handles MessageTB.SelectionChanged
'    'Updates the properties for the selected text
'    Try
'        If MessageTB.SelectionFont.Style = FontStyle.Bold Then
'            BoldButton.BackColor = SelectedColour
'            BoldButton.FlatAppearance.MouseOverBackColor = SelectedColour
'            BoldButton.FlatAppearance.MouseDownBackColor = UnselectedColour
'        Else
'            BoldButton.FlatAppearance.MouseOverBackColor = OverColour
'            BoldButton.FlatAppearance.MouseDownBackColor = SelectedColour
'            BoldButton.BackColor = UnselectedColour
'        End If
'        If MessageTB.SelectionFont.Style = FontStyle.Italic Then
'            ItalicButton.FlatAppearance.MouseOverBackColor = SelectedColour
'            ItalicButton.FlatAppearance.MouseDownBackColor = UnselectedColour
'            ItalicButton.BackColor = SelectedColour
'        Else
'            ItalicButton.FlatAppearance.MouseOverBackColor = OverColour
'            ItalicButton.FlatAppearance.MouseDownBackColor = SelectedColour
'            ItalicButton.BackColor = UnselectedColour
'        End If
'        If MessageTB.SelectionFont.Style = FontStyle.Underline Then
'            UnderlinedButton.FlatAppearance.MouseOverBackColor = SelectedColour
'            UnderlinedButton.FlatAppearance.MouseDownBackColor = UnselectedColour
'            UnderlinedButton.BackColor = SelectedColour
'        Else
'            UnderlinedButton.FlatAppearance.MouseOverBackColor = OverColour
'            UnderlinedButton.FlatAppearance.MouseDownBackColor = SelectedColour
'            UnderlinedButton.BackColor = UnselectedColour
'        End If
'        If MessageTB.SelectionFont.Style = FontStyle.Strikeout Then
'            StrikeoutButton.FlatAppearance.MouseOverBackColor = SelectedColour
'            StrikeoutButton.FlatAppearance.MouseDownBackColor = UnselectedColour
'            StrikeoutButton.BackColor = SelectedColour
'        Else
'            StrikeoutButton.FlatAppearance.MouseOverBackColor = OverColour
'            StrikeoutButton.FlatAppearance.MouseDownBackColor = SelectedColour
'            StrikeoutButton.BackColor = UnselectedColour
'        End If
'    Catch ex As Exception
'    End Try
'End Sub

'Private Sub MessageTB_TextChanged(sender As Object, e As EventArgs) Handles MessageTB.TextChanged
'    PreviewTB.Text = PreviewTB.Text.Replace("a", "")
'    'PreviewTB.Text = MessageTB.Text
'End Sub

'Private Sub SendButton_Click(sender As Object, e As EventArgs) Handles SendButton.Click
'    Dim dr As OleDb.OleDbDataReader = DataReader("Select SrNo From Coustmers_Data")

'End Sub

'Private Sub MessageSender_Load(sender As Object, e As EventArgs) Handles MyBase.Load

'End Sub

'Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click

'End Sub


'{Greet}
'Dear, {CoustName}
'Your Kitty({KittyNo}-{KittyType})
'Is Due From - {InstPendMonth}
'Pending Amt. - {PendingAmt}
'Instalments Completed - {InstCompl}:{InstCompMonth}
'You Can Also Pay Online Account Info Below.