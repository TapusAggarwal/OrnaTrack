Public Class PropertyControl

    Private _currentProperty As Item.Item_Property

    Public ReadOnly Property EnteredData
        Get
            Select Case _currentProperty.DataType
                Case Item.DataType.Boolean_Type
                    Return TrueChB.Checked
                Case Item.DataType.List_Type
                    If ListValues.SelectedIndex < 0 Then
                        MessageBox.Show($"No Data Entered In {_currentProperty.Name} Property.")
                        Return Nothing
                    End If
                    Return ListValues.SelectedItem
                Case Item.DataType.Integer_Type
                    If DefaultValueTB.TextLength = 0 Then
                        MessageBox.Show($"No Data Entered In {_currentProperty.Name} Property.")
                        Return Nothing
                    End If
                    Return CDbl(DefaultValueTB.Text)
                Case Item.DataType.String_Type
                    If DefaultValueTB.TextLength = 0 Then
                        MessageBox.Show($"No Data Entered In {_currentProperty.Name} Property.")
                        Return Nothing
                    End If
                    Return DefaultValueTB.Text
                Case Else
                    Return Nothing
                    MessageBox.Show("Invalid DataType")
            End Select
        End Get
    End Property

    Public Property CurrentProperty As Item.Item_Property
        Set(value As Item.Item_Property)
            _currentProperty = value

            PropertyLB.Text = _currentProperty.Name
            Size = New Point(Size.Width + TextRenderer.MeasureText(_currentProperty.Name, PropertyLB.Font).Width, Size.Height)

            DefaultValueTB.Visible = False
            TrueChB.Visible = False
            FalseChB.Visible = False
            ListValues.Visible = False

            Select Case _currentProperty.DataType
                Case Item.DataType.Boolean_Type
                    TrueChB.Visible = True
                    FalseChB.Visible = True
                    If _currentProperty.DefaultValue = "True" Then
                        TrueChB.Checked = True
                    Else
                        FalseChB.Checked = True
                    End If
                Case Item.DataType.List_Type
                    ListValues.Visible = True
                    ListValues.Items.AddRange(_currentProperty.DefaultValue.Split("`")(1).Split(","))
                    ListValues.SelectedIndex = ListValues.FindStringExact(_currentProperty.DefaultValue.Split("`")(0))
                Case Item.DataType.Integer_Type
                    DefaultValueTB.Visible = True
                    If _currentProperty.IsFormula Then
                        DefaultValueTB.Text = "{RULE}"
                        DefaultValueTB.ReadOnly = True
                        Try
                            AddHandler DefaultValueTB.TextChanged,
                                 Sub()
                                     DefaultValueTB.Text = DefaultValueTB.Text.ToCurrency()
                                 End Sub
                        Catch ex As Exception

                        End Try
                    Else
                        DefaultValueTB.Text = _currentProperty.DefaultValue
                    End If
                Case Item.DataType.String_Type
                    DefaultValueTB.Visible = True
                    DefaultValueTB.Text = _currentProperty.DefaultValue
                Case Else
                    MessageBox.Show("Invalid DataType")
            End Select

            DefaultValueTB.ReadOnly = _currentProperty.IsConstant

        End Set
        Get
            Return _currentProperty
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

    Private Sub DefaultValueTB_TextChanged(sender As Object, e As EventArgs) Handles DefaultValueTB.TextChanged
        If _currentProperty.IsFormula Then Exit Sub
        Dim filteredText As String = DefaultValueTB.Text

        Dim cursorIndex As Integer = DefaultValueTB.SelectionStart

        If _currentProperty.DataType = Item.DataType.Integer_Type Then
            While filteredText.Length > 1 AndAlso filteredText(0) = "0" AndAlso filteredText(1) <> "."
                filteredText = filteredText.Substring(1)
            End While
            For Each i In filteredText
                Dim ascVal As Integer = Asc(i)
                If i = "." Then
                    If filteredText.Split(".").Count = 2 Then
                        Continue For
                    End If
                End If

                If ascVal < 48 Or ascVal > 57 Then
                    MessageBox.Show($"Invalid Character Found ('{i}'). This Property Is Declared As Integer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    filteredText = filteredText.Replace(i, "")
                End If
            Next
            If filteredText = "" Then
                filteredText = 0
            End If
        Else
            If filteredText.Contains("'") Then
                MessageBox.Show($"Invalid Character Found ('). Strings Can Not Contain Apostrophe.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                filteredText = filteredText.Replace("'", "")
            End If
        End If

        If DefaultValueTB.Text <> filteredText Then
            Try
                DefaultValueTB.Text = CDbl(filteredText)
                SendKeys.Send("{End}")
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub DefaultValueTB_Leave(sender As Object, e As EventArgs) Handles DefaultValueTB.Leave
        If _currentProperty.IsCurrency Then
            RemoveHandler DefaultValueTB.TextChanged, AddressOf DefaultValueTB_TextChanged
            Try
                DefaultValueTB.Text = DefaultValueTB.Text.ToCurrency()
            Catch ex As Exception
            End Try
            AddHandler DefaultValueTB.TextChanged, AddressOf DefaultValueTB_TextChanged
        End If
    End Sub

    Private Sub DefaultValueTB_GotFocus(sender As Object, e As EventArgs) Handles DefaultValueTB.GotFocus
        If _currentProperty.IsCurrency Then
            Try
                DefaultValueTB.Text = Int(DefaultValueTB.Text)
            Catch ex As Exception
            End Try
        End If
    End Sub

End Class