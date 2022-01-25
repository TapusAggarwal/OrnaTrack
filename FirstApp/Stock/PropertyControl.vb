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
                    Return DefaultValueTB.Text
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
                    DefaultValueTB.Text = _currentProperty.DefaultValue
                Case Item.DataType.String_Type
                    DefaultValueTB.Visible = True
                    DefaultValueTB.Text = _currentProperty.DefaultValue
                Case Else
                    MessageBox.Show("Invalid DataType")
            End Select

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

End Class