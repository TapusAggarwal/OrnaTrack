Imports FontAwesome.Sharp

Public Class Folder
    Inherits UserControl

    Private _backColor As Color
    Private _icon As FontAwesome.Sharp.IconChar

    <ComponentModel.Browsable(True)>
    Public Overrides Property BackColor As Color
        Get
            Return _backColor
        End Get
        Set(value As Color)
            BackPanel.BackColor = value
        End Set
    End Property

    <ComponentModel.Browsable(True)>
    Public Property Icon As FontAwesome.Sharp.IconChar
        Get
            Return _icon
        End Get
        Set(value As FontAwesome.Sharp.IconChar)
            Btn.IconChar = value
            _icon = value
            Invalidate()
        End Set
    End Property

End Class
