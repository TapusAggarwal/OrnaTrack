Public Class KittyModeControl

    Dim ImagePath As String = ""
    Dim OrignalDate As String = ""

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
            Return OrignalDate
        End Get
        Set
            'Dim result As String = LastInstallmentInWords(Value, Complete:=True)
            'LastInstalmentParam.Text = result.Split(",")(0)
            'If result.Split(",")(1) < 31 Then
            '    KittyNoParam.ForeColor = Color.LimeGreen
            '    KittyTypeParam.ForeColor = Color.LimeGreen
            '    LastInstalmentParam.ForeColor = Color.LimeGreen
            'End If
            OrignalDate = Value
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
            KittyNoParam.Text = Value
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

    Public Sub DetailsButton_Click() Handles DetailsButton.Click
        For Each ExistingFm As Form In Frame.MdiChildren
            If ExistingFm.Name <> "Main" Then
                ExistingFm.Dispose()
            End If
        Next


        Dim Fm As New CoustProfileUpdated With {
            .MdiParent = Frame,
            .Dock = DockStyle.Fill,
            .Tag = CoustID
        }
        Fm.Show()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Dispose()
    End Sub


End Class
