Imports QRCoder

Public Class QrCodeView
    Private Sub QrCodeView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Tag IsNot Nothing Then
            QrNew(Tag)
        End If
    End Sub

    Public Sub QrNew(qr As String)
        QrBox.Image = Nothing
        Dim gen As New QRCodeGenerator
        Dim data = gen.CreateQrCode(qr, QRCodeGenerator.ECCLevel.Q)
        Dim code As New QRCode(data)
        QrBox.Image = code.GetGraphic(10)
    End Sub

End Class