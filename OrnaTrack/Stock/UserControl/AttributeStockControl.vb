Imports System.Net.Http

Public Class AttributeStockControl

    Private _currentAttribute As Item.Item_Attribute

    Public ReadOnly Property EnteredData As String
        Get
            Select Case _currentAttribute.DataType
                Case Item.DataType.Boolean_Type
                    Return TrueChB.Checked
                Case Item.DataType.List_Type
                    If ListValues.SelectedIndex < 0 Then
                        MessageBox.Show($"No Data Entered In {_currentAttribute.Name} Attribute.")
                        Return Nothing
                    End If
                    Return ListValues.SelectedItem
                Case Item.DataType.Integer_Type
                    Dim x = DefaultValueTB_ReadableData()
                    Return x
                Case Item.DataType.String_Type
                    Dim x = DefaultValueTB_ReadableData()
                    Return x
                Case Item.DataType.Date_Type
                    Return DateTimePicker1.Value
                Case Else
                    Return Nothing
                    MessageBox.Show("Invalid DataType")
            End Select
        End Get
    End Property

    Public Property CurrentAttribute As Item.Item_Attribute
        Set(value As Item.Item_Attribute)
            _currentAttribute = value

            AttributeLB.Text = _currentAttribute.Name
            Size = New Point(Size.Width + TextRenderer.MeasureText(_currentAttribute.Name, AttributeLB.Font).Width, Size.Height)

            DefaultValueTB.Visible = False
            TrueChB.Visible = False
            FalseChB.Visible = False
            ListValues.Visible = False

            Select Case _currentAttribute.DataType

                Case Item.DataType.Boolean_Type

                    TrueChB.Visible = True
                    FalseChB.Visible = True
                    If _currentAttribute.DefaultValue = "True" Then
                        TrueChB.Checked = True
                    Else
                        FalseChB.Checked = True
                    End If


                Case Item.DataType.List_Type

                    ListValues.Visible = True
                    ListValues.Items.AddRange(_currentAttribute.DefaultValue.Split("`")(1).Split(","))
                    ListValues.SelectedIndex = ListValues.FindStringExact(_currentAttribute.DefaultValue.Split("`")(0))


                Case Item.DataType.Integer_Type

                    DefaultValueTB.Visible = True
                    If Not _currentAttribute.IsFormula Then
                        DefaultValueTB.Text = _currentAttribute.DefaultValue

                        If _currentAttribute.IsCurrency Then
                            DefaultValueTB.Text = DefaultValueTB.Text.ToCurrency()
                        End If

                    Else
                        DefaultValueTB.Text = "{RULE}"
                        DefaultValueTB.ReadOnly = True
                    End If


                Case Item.DataType.String_Type

                    DefaultValueTB.Visible = True
                    DefaultValueTB.Text = _currentAttribute.DefaultValue

                Case Item.DataType.Date_Type

                    DateTimePicker1.Visible = True
                    DateTimePicker1.Value = DateTime.Now

                Case Else

                    MessageBox.Show("Invalid DataType")


            End Select

            DefaultValueTB.ReadOnly = _currentAttribute.IsConstant

        End Set
        Get
            Return _currentAttribute
        End Get
    End Property

    Private Sub TrueChB_CheckedChanged(sender As Object, e As EventArgs) Handles TrueChB.CheckedChanged
        If TrueChB.Checked Then FalseChB.Checked = False
        If Not (TrueChB.Checked) And Not (FalseChB.Checked) Then TrueChB.Checked = True
    End Sub

    Private Sub FalseChB_CheckedChanged(sender As Object, e As EventArgs) Handles FalseChB.CheckedChanged
        If FalseChB.Checked Then TrueChB.Checked = False
        If Not (TrueChB.Checked) And Not (FalseChB.Checked) Then FalseChB.Checked = True
    End Sub

    Private Sub DefaultValueTB_Leave(sender As Object, e As EventArgs) Handles DefaultValueTB.Leave
        If _currentAttribute.IsFormula Then Exit Sub

        Dim _newVal = DefaultValueTB_ReadableData()
        If _newVal = "" Then
            _newVal = _currentAttribute.DefaultValue
        End If

        If _currentAttribute.IsCurrency Then
            _newVal = DefaultValueTB.Text.ToCurrency()
        End If

        DefaultValueTB.Text = _newVal

        'If _currentAttribute.Name = "HUID" AndAlso DefaultValueTB.Text <> "" Then
        '    If CheckUIDExists(DefaultValueTB.Text) Then
        '        DefaultValueTB.ForeColor = Color.Green
        '    Else
        '        DefaultValueTB.ForeColor = Color.Red
        '    End If
        'End If

    End Sub



    Private Sub DefaultValueTB_GotFocus(sender As Object, e As EventArgs) Handles DefaultValueTB.GotFocus
        If _currentAttribute.IsFormula Then Exit Sub
        If DefaultValueTB.Text = "" Then Exit Sub
        If _currentAttribute.DataType = Item.DataType.Integer_Type Then
            DefaultValueTB.Text = CDbl(DefaultValueTB.Text)
        End If
        If DefaultValueTB.Text = CurrentAttribute.DefaultValue Then DefaultValueTB.Text = ""
        SendKeys.Send("{End}")
    End Sub

    Private Sub DefaultValueTB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DefaultValueTB.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
            Exit Sub
        End If
        If e.KeyChar = "'" Then
            e.Handled = True
        End If
        If _currentAttribute.DataType <> Item.DataType.Integer_Type Then Exit Sub
        If DefaultValueTB.Text.Contains(".") AndAlso e.KeyChar = "." Then e.Handled = True
        If DefaultValueTB.Text.Contains("-") AndAlso e.KeyChar = "-" Then e.Handled = True
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "-" AndAlso e.KeyChar <> vbBack Then
            e.Handled = True
        End If

    End Sub

    Private Function DefaultValueTB_ReadableData() As String
        If _currentAttribute.DataType <> Item.DataType.Integer_Type Then Return DefaultValueTB.Text

        Try
            Return CDbl(DefaultValueTB.Text)
        Catch ex As Exception
            Return ""
        End Try
    End Function

End Class