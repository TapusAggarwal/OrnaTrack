Public Class KittyModeControl

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

    Public Property KittyID As String
        Get
            Return KittyIDParam.Text
        End Get
        Set
            KittyIDParam.Text = Value
        End Set
    End Property

    Public Property LastInstalmentDate As String
        Get
            Return LastInstalmentParam.Text
        End Get
        Set
            LastInstalmentParam.Text = Value
        End Set
    End Property

    Public Property KittyType As String
        Get
            Return KittyTypeParam.Text
        End Get
        Set
            KittyTypeParam.Text = Value
        End Set
    End Property

    Public Property KittyNo As String
        Get
            Return KittyNoParam.Text
        End Get
        Set
            KittyNoParam.Text = If(Value > 0, Value, "")
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

    Public Event DetailsButton_Clicked(CustomerId As Integer, KittyID As Integer)

    Public Sub DetailsButton_Click() Handles DetailsButton.Click
        RaiseEvent DetailsButton_Clicked(CoustID, KittyID)
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Dispose()
    End Sub

End Class
