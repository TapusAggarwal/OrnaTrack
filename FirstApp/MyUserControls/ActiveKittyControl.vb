Public Class ActiveKittyControl
    Dim OrignalDate As String = ""
    Dim ImagePath As String = ""

    Public Property CoustName As String
        Get
            Return NameParam.Text
        End Get
        Set
            NameParam.Text = Value
        End Set
    End Property

    Public Property SrNo As String
        Get
            Return SrNoParam.Text.Split("#")(0)
        End Get
        Set
            SrNoParam.Text = "#" & Value
        End Set
    End Property

    Public Property PhNo As String
        Get
            Return PhNoParam.Text
        End Get
        Set
            PhNoParam.Text = Value
        End Set
    End Property

    Public Property CoustID As String
        Get
            Return CoustmerIdParam.Text
        End Get
        Set
            CoustmerIdParam.Text = Value
        End Set
    End Property

    Public Property ActiveKitty As String
        Get
            Return ActiveKittyParam.Text
        End Get
        Set
            'If Value = 0 Then
            '    NeverLabel.Visible = True
            '    ActiveKittyLabel.Visible = False
            '    ActiveKittyParam.Visible = False
            'Else
            ActiveKittyParam.Text = Value
            'End If
        End Set
    End Property

    Public Property SetImage As String
        Get
            Return ImagePath
        End Get
        Set
            Try
                ImageParam.BackgroundImage = Image.FromFile(Value)
            Catch ex As Exception
            End Try
            ImagePath = Value
        End Set
    End Property

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Dispose()
    End Sub

    Public Event DetailsButton_Clicked(CustomerID As Integer)

    Public Sub DetailsButton_Click() Handles DetailsButton.Click
        RaiseEvent DetailsButton_Clicked(CoustID)
    End Sub

End Class
