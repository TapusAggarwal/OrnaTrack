Public Class PreviewKitty

    Public _customer As Customer
    Public _kitty As Kitty

    'Loads A Customer Profile
    Private Sub LoadCustomerProfileData()
        With _customer
            Try
                FullName.Text = .FullName
            Catch : End Try
            Try
                PhNo.Text = .PhNo(",")
            Catch : End Try
            Try
                Gender.Text = .Gender
            Catch : End Try
            Try
                Married.Text = .IsMarried
            Catch : End Try
            Try
                Profession.Text = .Profession
            Catch : End Try
            Try
                Address.Text = .Address
            Catch : End Try
            Try
                Region.Text = .Region
            Catch : End Try
            Try
                'ImageBox.BackgroundImage = Image.FromFile(dr("img"))    'Adding Profile Iamge
            Catch : End Try
        End With
    End Sub

    'Loads A Form Given A Kitty
    Public Sub ShowKittyForm()
        Invoke(Sub()
                   Dim _KittyForm = New KittyForm With {
                       .Tag = _kitty
                   }
                   _KittyForm.DeleteButton.Enabled = False
                   _KittyForm.ResetButton.Enabled = False
                   _KittyForm.SaveButton.Enabled = False
                   _KittyForm.DissolveButton.Enabled = False
                   _KittyForm.PaymentButton.Enabled = False
                   _KittyForm.AvailButton.Enabled = False
                   _KittyForm.DotsButton.Enabled = False
                   Dim Pnl As Panel = _KittyForm.MainPanel
                   Pnl.Dock = DockStyle.Fill
                   _KittyForm.Kitty_Load(_KittyForm, EventArgs.Empty)
                   KittyPanel.Controls.Add(Pnl)
                   AddHandler _KittyForm.ReloadKittyView, Sub()
                                                              ShowKittyForm()
                                                          End Sub
               End Sub)
    End Sub

    Private Sub PreviewKitty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomerProfileData()
        ShowKittyForm()
    End Sub
End Class