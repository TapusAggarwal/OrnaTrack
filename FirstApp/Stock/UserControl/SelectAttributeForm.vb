Public Class SelectAttributeForm

    Property SelectedAttribute As Item.Item_Attribute

    Private Sub SelectAttributeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dr As OleDb.OleDbDataReader = DataReader("Select ID From Item_Attributes")
        Dim _attributes As New List(Of Item.Item_Attribute)

        While dr.Read
            _attributes.Add(New Item.Item_Attribute(Int(dr(0))))
        End While

        For Each i In _attributes
            Dim _cntrl As New AttributeControl With {
                .CurrentAttribute = i
            }
            _cntrl.UsedButton.IconChar = FontAwesome.Sharp.IconChar.CheckSquare
            _cntrl.UsedButton.IconColor = Color.ForestGreen

            AddHandler _cntrl.ButtonClick, Sub()
                                               SelectedAttribute = _cntrl.CurrentAttribute
                                               Close()
                                           End Sub

            FlowLayoutPanel1.Controls.Add(_cntrl)
        Next

    End Sub
End Class