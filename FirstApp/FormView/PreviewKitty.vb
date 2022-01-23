Imports FirstApp.Utility

Public Class PreviewKitty

    Public _kitty As Kitty
    ReadOnly FmProfile As New CoustProfileUpdated
    Dim _KittyForm As KittyForm

    'Loads A Form Given A Kitty
    Public Sub ShowKittyForm()
        Invoke(Sub()
                   _KittyForm = New KittyForm With {
                       .Tag = _kitty
                   }
                   _KittyForm.DissolveButton.Enabled = False
                   '_KittyForm.DeleteButton.Enabled = False
                   '_KittyForm.ResetButton.Enabled = False
                   '_KittyForm.SaveButton.Enabled = False
                   '_KittyForm.PaymentButton.Enabled = False
                   '_KittyForm.AvailButton.Enabled = False
                   '_KittyForm.DotsButton.Enabled = False
                   Dim Pnl As Panel = _KittyForm.MainPanel
                   Pnl.Dock = DockStyle.Fill
                   _KittyForm.Kitty_Load(_KittyForm, EventArgs.Empty)
                   KittyPanel.Controls.Add(Pnl)
                   AddHandler _KittyForm.ReloadKittyView, Sub()
                                                              ShowKittyForm()
                                                          End Sub
               End Sub)
    End Sub

    Private Sub Me_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            If _KittyForm Is Nothing Then Exit Sub
            If e.Control And e.KeyCode = Keys.S Then
                _KittyForm.SaveButton_Click(_KittyForm.SaveButton, e)
            ElseIf e.Control And e.KeyCode = Keys.P Then
                _KittyForm.PaymentButton.Select()
                _KittyForm.PaymentButton_Click(_KittyForm.PaymentButton, e)
                _KittyForm.DatePicker.Select()
            ElseIf e.Control And e.KeyCode = Keys.D Then
                _KittyForm.DeleteButton_Click(_KittyForm.DeleteButton, e)
                _KittyForm.DatePicker.Select()
            End If
        Catch
        End Try
    End Sub

    Private Sub PreviewKitty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            KeyPreview = True
            Dim pnl As Panel = FmProfile.ProfilePanel
            pnl.Dock = DockStyle.Fill
            pnl.BackColor = Color.FromArgb(36, 30, 60)
            Panel1.Controls.Add(pnl)
            LoadComboBoxData(FmProfile.ProfessionCB, Customer.ListOfProfessions)
            LoadComboBoxData(FmProfile.RegionCB, Customer.ListOfRegions)
            FmProfile.LoadProfileData(_customer:=_kitty.Owner)
            ShowKittyForm()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub SaveCoustmerButton_Click(sender As Object, e As EventArgs) Handles SaveCoustmerButton.Click
        SaveCoustmerButton.Select()
        If _kitty.Owner IsNot Nothing Then
            If MessageBox.Show("Do You Want To Update Changes Made To Customer Data ?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.No Then Exit Sub
            If FmProfile.NameTB.TextLength = 0 Then
                MessageBox.Show("You Have To Enter Name Of The Coustmer To Add New Coustmer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            With FmProfile
                _kitty.Owner.UpdatedFirstName = .NameTB.Text
                _kitty.Owner.UpdatedLastName = .SirNameTB.Text
                _kitty.Owner.UpdatedPhNo = .PhoneNoTag1.TagData
                _kitty.Owner.UpdatedProfession = .ProfessionCB.SelectedItem
                _kitty.Owner.UpdatedRegion = .RegionCB.SelectedItem
                _kitty.Owner.UpdatedAddress = .AddressTB.Text
                If .MarriedCheckBox.Checked Then _kitty.Owner.UpdatedMarriedStatus = "True" Else _kitty.Owner.UpdatedMarriedStatus = "False"
                If .MaleRB.Checked Then
                    _kitty.Owner.UpdatedGender = "Male"
                ElseIf .FemaleRB.Checked Then
                    _kitty.Owner.UpdatedGender = "Female"
                End If
            End With
        End If
    End Sub

    Private Sub AllKittiesBT_Click(sender As Object, e As EventArgs) Handles AllKittiesBT.Click
        Dim Fm As New KittyView With {
            .Tag = _kitty.Owner
        }
        AddHandler Fm.ShowDetailsClicked, Sub(_kitty As Kitty)
                                              Dim KittyForm_Fm As New KittyForm With {
                                                .Tag = _kitty
                                                }
                                              KittyForm_Fm.ShowDialog()
                                              Fm.LoadKittyData(Fm.DgvMain)
                                          End Sub
        Fm.Show()
    End Sub
End Class