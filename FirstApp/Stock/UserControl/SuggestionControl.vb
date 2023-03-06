﻿Public Class SuggestionControl
    Private _Attribute As Item.Item_Attribute

    Private _currentAttribute As Item.Item_Attribute

    Public Property CurrentAttribute As Item.Item_Attribute
        Get
            Return _currentAttribute
        End Get
        Set(value As Item.Item_Attribute)
            _currentAttribute = value
            If value Is Nothing Then Exit Property
            With _currentAttribute
                AttrIconBT.Visible = True
                Label2.Visible = True
                AttrIconBT.Text = $"{{{ .DataType}{If(.IsCurrency, "-₹", "")}}} { .Name}" + If(.IsOptional, "*", "")
                If .IsConstant Then
                    AttrIconBT.Font = New Font(AttrIconBT.Font, FontStyle.Underline)
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
End Class
