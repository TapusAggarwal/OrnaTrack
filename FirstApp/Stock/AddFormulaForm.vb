Imports System.Text.RegularExpressions

Public Class AddFormulaForm

    Property Attributes As New List(Of Item.Item_Attribute)
    ReadOnly Property FormulaInUse As Boolean
        Get
            Return UseBT.Text IsNot Nothing AndAlso (UseBT.Text = "Don't Use This Calculation")
        End Get
    End Property

    Private Sub AddFormulaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FlowLayoutPanel1.Controls.Clear()

        For Each i In Attributes
            Dim _cntrl As New AttributeControl With {
                .CurrentAttribute = i
            }
            _cntrl.UsedButton.IconChar = FontAwesome.Sharp.IconChar.CheckSquare
            _cntrl.UsedButton.IconColor = Color.ForestGreen

            AddHandler _cntrl.ButtonClick, Sub()
                                               FormulaTB.SelectedText = $"{{{i.Name}}}"
                                           End Sub

            FlowLayoutPanel1.Controls.Add(_cntrl)
        Next

        FormulaTB.Select()
        FormulaTB_KeyDown(FormulaTB, EventArgs.Empty)
    End Sub

    Private Sub FormulaTB_KeyDown(sender As Object, e As EventArgs) Handles FormulaTB.TextChanged
        Dim cursorIndex As Integer = FormulaTB.SelectionStart
        Dim pattern As String = "\{[^{}]*\}|\s+"
        Dim regex As New Regex(pattern)

        FormulaTB.Text = regex.Replace(FormulaTB.Text, Function(match As Match)
                                                           If match.Value.StartsWith("{") Then
                                                               Return match.Value
                                                           Else
                                                               Return String.Join("", match.Value.Split({" "c}, StringSplitOptions.RemoveEmptyEntries))
                                                           End If
                                                       End Function)
        FormulaTB.SelectionStart = cursorIndex

        HighlightWords()
        HighLightOperations()

    End Sub

    Private Sub FormulaTB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FormulaTB.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso
          e.KeyChar = ChrW(Keys.Enter) AndAlso
                      e.KeyChar <> "%" AndAlso
                      e.KeyChar <> "(" AndAlso
                      e.KeyChar <> ")" AndAlso
                      e.KeyChar <> "*" AndAlso
                      e.KeyChar <> "+" AndAlso
                      e.KeyChar <> "-" AndAlso
                      e.KeyChar <> "/" Then

            e.Handled = True
        End If
    End Sub

    Private Sub HighLightOperations()
        Dim wordRegex As New Regex("[%()*+\-/]")
        Dim matches As MatchCollection = wordRegex.Matches(FormulaTB.Text)

        Dim cursorIndex As Integer = FormulaTB.SelectionStart

        For Each match As Match In matches
            FormulaTB.SelectionStart = match.Index
            FormulaTB.SelectionLength = match.Length
            FormulaTB.SelectionColor = Color.Red
        Next

        FormulaTB.SelectionStart = cursorIndex
        FormulaTB.SelectionLength = 0
        FormulaTB.SelectionColor = Color.Black
    End Sub

    Private Sub HighlightWords()
        Dim wordRegex As New Regex("\{[^{}]+\}")
        Dim matches As MatchCollection = wordRegex.Matches(FormulaTB.Text)

        Dim cursorIndex As Integer = FormulaTB.SelectionStart

        FormulaTB.SelectionStart = 0
        FormulaTB.SelectionLength = FormulaTB.TextLength
        FormulaTB.SelectionColor = Color.Black

        For Each match As Match In matches
            FormulaTB.SelectionStart = match.Index
            FormulaTB.SelectionLength = match.Length
            FormulaTB.SelectionColor = SystemColors.Highlight
        Next

        FormulaTB.SelectionStart = cursorIndex
        FormulaTB.SelectionLength = 0
        FormulaTB.SelectionColor = Color.Black

        If matches.Count > 0 Then
            UseBT.Enabled = True
        Else
            UseBT.Enabled = False
            If FormulaInUse Then ToggleUseBT()
        End If

    End Sub

    Private Sub MathOperations_Click(sender As FontAwesome.Sharp.IconButton, e As EventArgs) Handles LeftBracketBT.Click, RightBracketBT.Click, DivideBT.Click, MultiplyBT.Click, PlusBT.Click, MinusBT.Click
        Dim Operation As String = ""

        If sender Is LeftBracketBT Then
            Operation = "("
        ElseIf sender Is RightBracketBT Then
            Operation = ")"
        ElseIf sender Is DivideBT Then
            Operation = "/"
        ElseIf sender Is MultiplyBT Then
            Operation = "*"
        ElseIf sender Is PlusBT Then
            Operation = "+"
        ElseIf sender Is MinusBT Then
            Operation = "-"
        End If

        FormulaTB.SelectedText = Operation
    End Sub

    Public Function ValidateFormulaText() As List(Of Item.Item_Attribute)
        Dim pattern As String = "\{[^{}]+\}|[\d()+\-*\/%]"
        Dim regex As New Regex(pattern)

        If Not regex.IsMatch(FormulaTB.Text) Then
            ' Return an empty list if the text contains invalid characters
            Return New List(Of Item.Item_Attribute)
        End If

        ' Extract the attributes from the text
        Dim matches As MatchCollection = regex.Matches(FormulaTB.Text)
        Dim attributes As New List(Of Item.Item_Attribute)
        For Each match As Match In matches
            If match.Value.StartsWith("{") Then
                Dim _attr = match.Value.Substring(1, match.Value.Length - 2)
                attributes.Add(attributes.Where(Function(f) f.Name = _attr))
            End If
        Next

        Return attributes
    End Function

    Private Sub UseBT_Click(sender As Object, e As EventArgs) Handles UseBT.Click
        ToggleUseBT()
    End Sub

    Public Event UseBT_Toggled()

    Public Sub ToggleUseBT()
        If UseBT.Text = "Don't Use This Calculation" Then
            UseBT.Text = "Use This Calculation"
            UseBT.BackColor = Color.ForestGreen
            UseBT.Location = New Point(1017, UseBT.Location.Y)
        Else
            UseBT.Text = "Don't Use This Calculation"
            UseBT.BackColor = Color.Maroon
            UseBT.Location = New Point(952, UseBT.Location.Y)
        End If
        RaiseEvent UseBT_Toggled()
    End Sub

End Class