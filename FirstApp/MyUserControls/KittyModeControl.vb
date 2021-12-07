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

    ' -2 = Availed(Gray), -1 = Matured(Goldenrod), 0 = None Pending(Green), Rest = Pending(Red)
    Public Property InstalmentsPending As Integer
        Get
            Return InstPendingParam.Text
        End Get
        Set
            If Value = -2 Then
                InstPendingParam.Text = "Availed"
                InstPendingParam.ForeColor = Color.Gray
                KittyTypeParam.ForeColor = Color.Gray
                KittyNoParam.ForeColor = Color.Gray
                InstLeftParam.Visible = False
            ElseIf Value = -1 Then
                InstPendingParam.Text = "Matured"
                InstPendingParam.ForeColor = Color.Goldenrod
                KittyTypeParam.ForeColor = Color.Goldenrod
                KittyNoParam.ForeColor = Color.Goldenrod
                InstLeftParam.Visible = False
            ElseIf Value = 0 Then
                InstPendingParam.Text = $"Pending: {Value}"
                InstPendingParam.ForeColor = Color.Green
                KittyTypeParam.ForeColor = Color.Green
                KittyNoParam.ForeColor = Color.Green
                InstLeftParam.ForeColor = Color.Green
            Else
                InstPendingParam.Text = $"Pending: {Value}"
                InstPendingParam.ForeColor = Color.FromArgb(200, 0, 0)
                KittyTypeParam.ForeColor = Color.FromArgb(200, 0, 0)
                KittyNoParam.ForeColor = Color.FromArgb(200, 0, 0)
                InstLeftParam.ForeColor = Color.FromArgb(200, 0, 0)
            End If
        End Set
    End Property

    Public Property InstalmentsLeft As Integer
        Get
            Return InstLeftParam.Text
        End Get
        Set(value As Integer)
            InstLeftParam.Text = $"Left: {value}"
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
