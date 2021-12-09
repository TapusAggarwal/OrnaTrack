Public Class MessageSender

    Structure Templates
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
        ToolTip1.Show("Add Coustmer's Name To The Message" & Environment.NewLine & "Ex: Tapus Aggarwal", CoustNameButton, 3000)
    End Sub

    Private Sub PhNo_Click(sender As Object, e As EventArgs) Handles PhNoButton.Click
        MessageTB.SelectedText = Templates.CoustPhNo
        MessageTB.Select()
        SendKeys.Send("{End}")
    End Sub

    Private Sub PhNoButton_MouseHover(sender As Object, e As EventArgs) Handles PhNoButton.MouseHover
        ToolTip1.Show("Add Coustmer's PhNo To The Message" & Environment.NewLine & "Ex: 9882960863,9816057863", PhNoButton, 3000)
    End Sub

    Private Sub KittyTypeButton_Click(sender As Object, e As EventArgs) Handles KittyTypeButton.Click
        MessageTB.SelectedText = Templates.KittyType
        MessageTB.Select()
        SendKeys.Send("{End}")
    End Sub

    Private Sub KittyTypeButton_MouseHover(sender As Object, e As EventArgs) Handles KittyTypeButton.MouseHover
        ToolTip1.Show("Adds KittyType To The Message" & Environment.NewLine & "Ex: ₹2,000", KittyTypeButton, 3000)
    End Sub

    Private Sub KittyNoButton_Click(sender As Object, e As EventArgs) Handles KittyNoButton.Click
        MessageTB.SelectedText = Templates.KittyNo
        MessageTB.Select()
        SendKeys.Send("{End}")
    End Sub

    Private Sub KittyNoButton_MouseHover(sender As Object, e As EventArgs) Handles KittyNoButton.MouseHover
        ToolTip1.Show("Adds KittyNo To The Message" & Environment.NewLine & "Ex: 984", KittyNoButton, 3000)
    End Sub

    Private Sub InstCompletedButton_Click(sender As Object, e As EventArgs) Handles InstCompletedButton.Click
        MessageTB.SelectedText = Templates.InstalmentsCompleted
        MessageTB.Select()
        SendKeys.Send("{End}")
    End Sub

    Private Sub InstCompletedButton_MouseHover(sender As Object, e As EventArgs) Handles InstCompletedButton.MouseHover
        ToolTip1.Show("Adds Till Date Instalments Completed To The Message" & Environment.NewLine & "Ex: 3", InstCompletedButton, 3000)
    End Sub

    Private Sub CompMonthButton_Click(sender As Object, e As EventArgs) Handles CompMonthButton.Click
        MessageTB.SelectedText = Templates.PeriodIntalmentsCompleted
        MessageTB.Select()
        SendKeys.Send("{End}")
    End Sub

    Private Sub CompMonthButton_MouseHover(sender As Object, e As EventArgs) Handles CompMonthButton.MouseHover
        ToolTip1.Show($"Adds Till Date Instalments Completed As Months To The Message{Environment.NewLine}Ex1: Dec(2020){Environment.NewLine}Ex2: Dec(2020),Jan(2021){Environment.NewLine}Ex3: Dec(2020)-Feb(2021)", InstCompletedButton, 4000)
    End Sub

    Private Sub GivenAmountButton_Click(sender As Object, e As EventArgs) Handles GivenAmountButton.Click
        MessageTB.SelectedText = Templates.GivenAmount
        MessageTB.Select()
        SendKeys.Send("{End}")
    End Sub

    Private Sub GivenAmountButton_MouseHover(sender As Object, e As EventArgs) Handles GivenAmountButton.MouseHover
        ToolTip1.Show($"Adds Till Date Given Amount To The Message{Environment.NewLine}Ex: ₹4,000", GivenAmountButton, 3000)
    End Sub

    Private Sub PendingInstButton_Click(sender As Object, e As EventArgs) Handles PendingInstButton.Click
        MessageTB.SelectedText = Templates.InstalmentsPending
        MessageTB.Select()
        SendKeys.Send("{End}")
    End Sub

    Private Sub PendingInstButton_MouseHover(sender As Object, e As EventArgs) Handles PendingInstButton.MouseHover
        ToolTip1.Show("Adds Total Instalments Pending To The Message" & Environment.NewLine & "Ex: 2", InstCompletedButton, 3000)
    End Sub

    Private Sub PendingMonthButton_Click(sender As Object, e As EventArgs) Handles PendingMonthButton.Click
        MessageTB.SelectedText = Templates.PeriodInstalmentsPending
        MessageTB.Select()
        SendKeys.Send("{End}")
    End Sub

    Private Sub PendingMonthButton_MouseHover(sender As Object, e As EventArgs) Handles PendingMonthButton.MouseHover
        ToolTip1.Show($"Adds Total Instalments Pending As Months To The Message{Environment.NewLine}Ex1: Dec(2020){Environment.NewLine}Ex2: Dec(2020),Jan(2021){Environment.NewLine}Ex3: Dec(2020)-Feb(2021)", PendingMonthButton, 4000)
    End Sub

    Private Sub PendingAmountButton_Click(sender As Object, e As EventArgs) Handles PendingAmountButton.Click
        MessageTB.SelectedText = Templates.PendingAmount
        MessageTB.Select()
        SendKeys.Send("{End}")
    End Sub

    Private Sub PendingAmountButton_MouseHover(sender As Object, e As EventArgs) Handles PendingAmountButton.MouseHover
        ToolTip1.Show($"Adds Total Pending Amount To The Message{Environment.NewLine}Ex: ₹3,000", GivenAmountButton, 3000)
    End Sub
#End Region

    Public Function ReplaceTemplateWithDetails(_kitty As Kitty, _text As String)
        _kitty.Initialize(True)
        With _kitty
            _text = _text.Replace(Templates.CoustName, .Owner.FullName())
            _text = _text.Replace(Templates.CoustPhNo, .Owner.PhNo(","))
            _text = _text.Replace(Templates.KittyType, .KittyType.ToCurrency(True))
            _text = _text.Replace(Templates.KittyNo, .KittyNo)
            _text = _text.Replace(Templates.InstalmentsCompleted, .GetInstalmentsCompleted)

            Dim FirstDate As Date = .Record.First.Key
            Dim InstComp As Integer = .GetInstalmentsCompleted
            Dim InstPending As Integer = .GetInstalmentsPending

            If InstComp = 1 Then
                _text = _text.Replace(Templates.PeriodInstalmentsPending, $"{ FirstDate:MMM}({ FirstDate:yyyy})")
            ElseIf InstComp = 2 Then
                _text = _text.Replace(Templates.PeriodInstalmentsPending, $"{ FirstDate:MMM}({ FirstDate:yyyy}),{ FirstDate.AddMonths(1):MMM}({ FirstDate.AddMonths(1):yyyy})")
            Else
                _text = _text.Replace(Templates.PeriodInstalmentsPending, $"{ FirstDate:MMM}({ FirstDate:yyyy})-{ FirstDate.AddMonths(InstComp - 1):MMM}({ FirstDate.AddMonths(InstComp - 1):yyyy})")
            End If

            _text = _text.Replace(Templates.GivenAmount, .GivenAmount.ToCurrency(True))
            _text = _text.Replace(Templates.InstalmentsPending, InstPending)

            If InstPending = 1 Then
                _text = _text.Replace(Templates.PeriodInstalmentsPending, $"{ FirstDate.AddMonths(InstComp):MMM}({ FirstDate.AddMonths(InstComp):yyyy})")
            ElseIf InstPending = 2 Then
                _text = _text.Replace(Templates.PeriodInstalmentsPending, $"{ FirstDate.AddMonths(InstComp):MMM}({ FirstDate.AddMonths(InstComp):yyyy}),{ FirstDate.AddMonths(InstComp + 1):MMM}({ FirstDate.AddMonths(InstComp + 1):yyyy})")
            Else
                _text = _text.Replace(Templates.PeriodInstalmentsPending, $"{ FirstDate.AddMonths(InstComp):MMM}({ FirstDate.AddMonths(InstComp):yyyy})+{ FirstDate.AddMonths(InstComp + InstPending - 1):MMM}({ FirstDate.AddMonths(InstComp + InstPending - 1):yyyy})")
            End If

            _text = _text.Replace(Templates.PendingAmount, Int(InstPending * .KittyType).ToCurrency(True))

        End With

        Return _text
    End Function

    Private Sub MessageSender_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MessageTB_FontChanged(sender As Object, e As EventArgs) Handles MessageTB.FontChanged
        MessageBox.Show(MessageTB.Font.Size)
    End Sub

    Private Sub SendButton_Click(sender As Object, e As EventArgs) Handles SendButton.Click
        MessageBox.Show(MessageTB.Font.Size)
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