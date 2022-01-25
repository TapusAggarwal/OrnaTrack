Public Class AttributeControl

    Private _currentProperty As Item.Item_Property

    Public Property CurrentProperty As Item.Item_Property
        Get
            Return _currentProperty
        End Get
        Set(value As Item.Item_Property)
            _currentProperty = value
            Size = New Point(Size.Width + TextRenderer.MeasureText($"{{{_currentProperty.DataType}}} {_currentProperty.Name}*", AttrIconBT.Font).Width, Height)
            AttrIconBT.Text = $"{{{_currentProperty.DataType}}} {_currentProperty.Name}*"
            DefValueLB.Text = _currentProperty.DefaultValue
        End Set
    End Property

End Class
