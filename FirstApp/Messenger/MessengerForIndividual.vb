Public Class MessengerForIndividual

    Public Property SelectedKitties As New List(Of Kitty)

    Private Sub MessengerForIndividual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitaliseConnection()
        Try : myconnection.Open() : Catch : End Try

        If SelectedKitties.Count = 1 Then
            If SelectedKitties(0).GetInstalmentsPending > 0 Then
                TemplateBT.PerformClick()
            Else
                ReceiptBT.PerformClick()
            End If
        Else
            ReceiptBT.PerformClick()
        End If

    End Sub

    Private Sub ReceiptBT_Click(sender As Object, e As EventArgs) Handles ReceiptBT.Click
        TemplateBT.IconColor = Color.White
        ReceiptBT.IconColor = Color.Lime
        Dim x As New RecieptMessenger With {
            .ListOfKitties = SelectedKitties,
            .TopMost = False,
            .TopLevel = False
        }
        Panel1.Controls.Clear()
        Panel1.Controls.Add(x)
        x.Show()
    End Sub

    Private Sub TemplateBT_Click(sender As Object, e As EventArgs) Handles TemplateBT.Click
        ReceiptBT.IconColor = Color.White
        TemplateBT.IconColor = Color.Lime
        Dim x As New MessageAndImageSender With {
            .SelectedKitties = SelectedKitties,
            .TopMost = False,
            .TopLevel = False
        }
        Panel1.Controls.Clear()
        Panel1.Controls.Add(x)
        x.Show()
    End Sub
End Class