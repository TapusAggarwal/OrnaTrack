Public Class AttributeControl

    Private _currentProperty As Item.Item_Property

    Public Property CurrentProperty As Item.Item_Property
        Get
            Return _currentProperty
        End Get
        Set(value As Item.Item_Property)
            _currentProperty = value
            With _currentProperty
                AttrIconBT.Text = $"{{{ .DataType}{If(.IsCurrency, "-₹", "")}}} { .Name}" + If(.IsOptional, "*", "")
                If .IsConstant Then
                    AttrIconBT.Font = New Font(AttrIconBT.Font, FontStyle.Underline)
                    Label1.Text = "Fix. Val:"
                End If
                Size = New Point(Size.Width + TextRenderer.MeasureText(AttrIconBT.Text, AttrIconBT.Font).Width + 2, Height)
                If .IsFormula Then
                    DefValueLB.Text = "{RULE}"
                ElseIf .DataType = Item.DataType.List_Type Then
                    DefValueLB.Text = .DefaultValue.Split("`")(0)
                Else
                    DefValueLB.Text = .DefaultValue
                End If

                AttrIconBT.IconChar = .Icon
            End With

        End Set
    End Property

    Public Event ButtonClick(_property As Item.Item_Property)
    Private Sub UsedButton_Click(sender As Object, e As EventArgs) Handles UsedButton.Click
        RaiseEvent ButtonClick(_currentProperty)
    End Sub

End Class
