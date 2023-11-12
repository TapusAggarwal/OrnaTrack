Imports ZXing

Public Class KittyRecievedReciept

    Public Property CurrentKitty As Kitty = Nothing

    Public WriteOnly Property RecieptDate As Date
        Set(value As Date)
            DateLB.Text = value.ToShortDateString
        End Set
    End Property

    Public WriteOnly Property KittyNo As Integer
        Set(value As Integer)
            KittyNoLB.Text = value
        End Set
    End Property

    Public WriteOnly Property CustomerName As String
        Set(value As String)
            NameLB.Text = value
        End Set
    End Property

    Public WriteOnly Property PhNo As String
        Set(value As String)
            PhNoLB.Text = value
        End Set
    End Property

    Public WriteOnly Property AmountBeforePayment As Integer
        Set(value As Integer)
            CashInWalletLB.Text = value.ToCurrency(AddSpace:=True)
        End Set
    End Property

    Public WriteOnly Property AmountRecieved As Integer
        Set(value As Integer)
            RecievedLB.Text = value.ToCurrency(AddSpace:=True)
        End Set
    End Property

    Public WriteOnly Property Total As Integer
        Set(value As Integer)
            TotalLB.Text = value.ToCurrency(AddSpace:=True)
        End Set
    End Property

    Public WriteOnly Property First_Month As Date
        Set(value As Date)
            FirstMonthLB.Text = $"{value:MMMM},{Year(value)}"
        End Set
    End Property

    Public WriteOnly Property CompletedTill_Month As Date
        Set(value As Date)
            CompletedTillLB.Text = $"{value:MMMM},{Year(value)}"
        End Set
    End Property

    Public WriteOnly Property Status As Integer
        Set(value As Integer)
            If value = -1 Then
                StatusLB.Text = "Matured"
                StatusLB.ForeColor = Color.Goldenrod
            ElseIf value = 0 Then
                StatusLB.Text = "UpTo Date"
                StatusLB.ForeColor = Color.MediumSeaGreen
            ElseIf value = 1 Then
                StatusLB.Text = "1 Instalment Pending."
            Else
                StatusLB.Text = value & " Instalments Pending."
                StatusLB.ForeColor = Color.Firebrick
            End If
        End Set
    End Property

    Public WriteOnly Property BarCodeData As String
        Set(value As String)
            Dim writer As New BarcodeWriter With {
            .Format = BarcodeFormat.CODABAR
            }
            Barcode.Image = writer.Write(value)
        End Set
    End Property

    Public Sub Initialize()
        With CurrentKitty
            RecieptDate = .Record.Last.Key
            KittyNo = .KittyNo
            CustomerName = .Owner.FullName()
            PhNo = .Owner.PhNo(",")
            AmountRecieved = .Record.Last.Value
            AmountBeforePayment = .GivenAmount - .Record.Last.Value
            Total = .GivenAmount
            First_Month = .Record.First.Key
            CompletedTill_Month = .Record.First.Key.AddMonths(.GetInstalmentsCompleted)
            Status = .GetInstalmentsPending
            BarCodeData = $"{ .KittyUID}000{ .Owner.CustomerID}000{New Random(.GivenAmount).Next}"
        End With
    End Sub

End Class