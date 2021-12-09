Imports FirstApp.Utility

Public Class CoustProfileUpdated

    Protected _currentCustomer As Customer = Nothing

    Sub New()
        CreateHandle()
        InitializeComponent()
    End Sub

    Protected Overrides ReadOnly Property createParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property

    Private Sub CustomerProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadComboBoxData(ProfessionCB, Customer.ListOfProfessions)
        LoadComboBoxData(RegionCB, Customer.ListOfRegions)
        KeyPreview = True

        If Tag IsNot Nothing Then
            CustomerIdTB.Text = Tag.ToString.Split("_")(0)
            ImageBox.Select()
        End If
    End Sub

    Private Sub LoadProfileData()
        NameTB.Text = _currentCustomer.FirstName
        SirNameTB.Text = _currentCustomer.LastName
        PhoneNoTag1.TagData = _currentCustomer.PhNo(",")
        ProfessionCB.SelectedIndex = ProfessionCB.FindStringExact(_currentCustomer.Profession)
        RegionCB.SelectedIndex = RegionCB.FindStringExact(_currentCustomer.Region)
        AddressTB.Text = _currentCustomer.Address
        If _currentCustomer.IsMarried() Then MarriedCheckBox.Checked = True Else MarriedCheckBox.Checked = False
        If _currentCustomer.Gender() = "Male" Then
            MaleRB.Checked = True
        ElseIf _currentCustomer.Gender() = "Female" Then
            FemaleRB.Checked = True
        Else
            MaleRB.Checked = False
            FemaleRB.Checked = False
        End If
        NotesTB.Text = _currentCustomer.Description()
        'CheckRegistrationButton_Click(CheckRegistrationButton, EventArgs.Empty)
    End Sub

    Private Sub CustomerIdTB_TextChanged(sender As TextBox, e As EventArgs) Handles CustomerIdTB.TextChanged
        If Not sender.TextLength = 0 Then
            _currentCustomer = New Customer(sender.Text)
            LoadProfileData()
            CheckForSimilarPhNo()
        End If
    End Sub


    Private Sub SaveCoustmerButton_Click(sender As Object, e As EventArgs) Handles SaveCoustmerButton.Click
        SaveCoustmerButton.Select()
        If NameTB.TextLength = 0 Then
            MessageBox.Show("You Have To Enter Name Of The Coustmer To Add New Coustmer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If _currentCustomer IsNot Nothing Then
            If MessageBox.Show("Do You Want To Update Changes Made To Customer Data ?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.No Then Exit Sub
            _currentCustomer.UpdatedFirstName = NameTB.Text
            _currentCustomer.UpdatedLastName = SirNameTB.Text
            _currentCustomer.UpdatedPhNo = PhoneNoTag1.TagData
            _currentCustomer.UpdatedProfession = ProfessionCB.SelectedItem
            _currentCustomer.UpdatedRegion = RegionCB.SelectedItem
            _currentCustomer.UpdatedAddress = AddressTB.Text
            If MarriedCheckBox.Checked Then _currentCustomer.UpdatedMarriedStatus = "True" Else _currentCustomer.UpdatedMarriedStatus = "False"
            If MaleRB.Checked Then
                _currentCustomer.UpdatedGender = "Male"
            ElseIf FemaleRB.Checked Then
                _currentCustomer.UpdatedGender = "Female"
            End If
            _currentCustomer.UpdatedDescription = NotesTB.Text
        Else
            Dim _Married As String
            Dim _gender As String = ""
            If MaleRB.Checked Then
                _gender = "Male"
            ElseIf FemaleRB.Checked Then
                _gender = "Female"
            End If

            If MarriedCheckBox.Checked Then _Married = "True" Else _Married = "False"
            If MessageBox.Show("Do You Want To Save New Member To Customer Data ?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.No Then Exit Sub
            SqlCommand($"INSERT INTO Coustmers_Data (CName,CsName,PhNo,Prof,Region,Address,Gender,Mry,dscrp)" &
                       $"VALUES('{NameTB.Text.Trim}','{SirNameTB.Text.Trim}','{PhoneNoTag1.TagData}','{ProfessionCB.SelectedItem}','{RegionCB.SelectedItem}','{AddressTB.Text}','{_gender}','{_Married}','{NotesTB.Text.Trim}')")

            Try
                Dim dr As OleDb.OleDbDataReader = DataReader("Select max(SrNo) From Coustmers_Data")
                While dr.Read
                    Dim _temp As Integer = dr(0)
                    CustomerIdTB.Text = _temp
                End While
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub DeleteCoustmerButton_Click(sender As Object, e As EventArgs) Handles DeleteCoustmerButton.Click
        If _currentCustomer Is Nothing Then
            MessageBox.Show("Can't Delete Customer That Does Not Exist!", "Illegal Selection", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            _currentCustomer.DeleteCustomer()
            Close()
        End If
    End Sub

    Private Sub KittyDetailsButton_Click(sender As Object, e As EventArgs) Handles KittyDetailsButton.Click
        Dim Fm As New KittyView With {
            .Tag = _currentCustomer
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

    Private Sub CheckForSimilarPhNo() Handles PhoneNoTag1.LeftTextBox
        ExistingPhNosButton.Visible = False
        Dim x As List(Of Integer) = Customer.SharedPhNo(PhoneNoTag1.TagData.Split(","))
        If x.Count > 1 Then
            ExistingPhNosButton.Visible = True
        ElseIf x.Count = 1 Then
            If _currentCustomer Is Nothing OrElse x.First <> _currentCustomer.CustomerID Then
                ExistingPhNosButton.Visible = True
            End If
        Else
        End If
    End Sub

    Private Sub ExistingPhNosButton_Click(sender As Object, e As EventArgs) Handles ExistingPhNosButton.Click
        Dim Fm As New DgvForExistingPhno With {
            .CurrentPhNo = (From _phno In PhoneNoTag1.TagData.Split(",") Select _phno.Trim).ToArray,
            .ShowInTaskbar = False
        }
        If _currentCustomer IsNot Nothing Then Fm.CurrentCustomer = _currentCustomer
        Fm.ShowDialog()
        If Fm.SelectedCustomer >= 0 Then
            CustomerIdTB.Text = Fm.SelectedCustomer
        End If
    End Sub

#Region "Convenience Wrapper"

    'TextBox Colour -> GoldenRod | When Got Focus
    Private Sub TB_GotFocus(sender As TextBox, e As EventArgs) Handles NameTB.GotFocus, SirNameTB.GotFocus, AddressTB.GotFocus
        sender.BackColor = Color.Goldenrod
    End Sub

    'TextBox Colour -> White | When Lost Focus
    Private Sub TB_LostFocus(Sender As TextBox, e As EventArgs) Handles NameTB.LostFocus, SirNameTB.LostFocus, AddressTB.LostFocus
        Sender.BackColor = Color.White
        Try : Sender.Text = UCase(Sender.Text(0)) + Sender.Text.Substring(1, Sender.TextLength - 1)
        Catch
        End Try
    End Sub

    'Select -> Previous TabIndex | When Up Key Pressed On PhoneNoTag
    Private Sub PhoneNoTag1_UP_keyPressed() Handles PhoneNoTag1.UP_keyPressed
        SendKeys.Send("+{Tab}")
    End Sub

    'Select -> Next TabIndex | When Down Key Pressed On PhoneNoTag
    Private Sub PhoneNoTag1_DOWN_keyPressed() Handles PhoneNoTag1.DOWN_keyPressed
        SendKeys.Send("{Tab}")
    End Sub

    'KeyDown -> MyBase Key Combination | Shortcut Keys Pressed In Form
    Private Sub CustomerProfile_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.Control And e.KeyCode = Keys.S) Then
            SaveCoustmerButton_Click(SaveCoustmerButton, EventArgs.Empty)
            'ElseIf (e.Control And e.KeyCode = Keys.K) And LedgerPanel.Visible Then
            '    AddKittyButton_Click()
            'ElseIf (e.Control And e.KeyCode = Keys.U) And LedgerPanel.Visible Then
            '    AddUdhariButton_Click()
            'ElseIf e.Control And e.KeyCode = Keys.I Then
            '    ShowCoustmerID()
            'ElseIf e.Control And e.KeyCode = Keys.D Then
            'DeleteCoustmerButton_Click()
        End If
    End Sub

    Private Sub TB_KeyDown(sender As Object, e As KeyEventArgs) Handles SirNameTB.KeyDown, NameTB.KeyDown, AddressTB.KeyDown
        If (e.KeyCode = Keys.Down) Or (e.KeyCode = Keys.Enter) Then
            Try : sender.Text = UCase(sender.Text(0)) + sender.Text.Substring(1, sender.TextLength - 1)
            Catch
            End Try
            SendKeys.Send("{Tab}")
        ElseIf e.KeyCode = Keys.Up Then
            Try : sender.Text = UCase(sender.Text(0)) + sender.Text.Substring(1, sender.TextLength - 1)
            Catch
            End Try
            SendKeys.Send("+{Tab}")
        End If
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        For Each ExistingFm As Form In Frame.MdiChildren
            If ExistingFm.Name <> "Main" Then
                Dim Fm As New KittyModeCoustView With {
                .MdiParent = Frame,
                .Tag = _currentCustomer.CustomerID,
                .Dock = DockStyle.Fill
                }
                Fm.Show()
                ExistingFm.Dispose()
            End If
        Next
    End Sub

    Private Sub AddKittyButton_Click(sender As Object, e As EventArgs) Handles AddKittyButton.Click
        Dim _tempKitty As New Kitty With {
           .CustomerID = _currentCustomer.CustomerID
       }
        Dim KittyForm_Fm As New KittyForm With {
          .Tag = _tempKitty
          }
        KittyForm_Fm.ShowDialog()
    End Sub

    Private Sub CheckRegistrationButton_Click(sender As Object, e As EventArgs) Handles CheckRegistrationButton.Click
        If PhoneNoTag1.TagData = "" Then
            MessageBox.Show("First Add Numbers To Check Validity Of Numbers.", "Server Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        PhoneNoTag1.CheckRegistration()
    End Sub

    Private Sub ProfessionCB_KeyDown(sender As Object, e As KeyEventArgs) Handles ProfessionCB.KeyDown
        If (e.KeyCode = Keys.Enter AndAlso e.Modifiers = Keys.Shift) Then 'SHIFT + ENTER
            Dim Rtrn_Data As New List(Of String) From {
                    "Profession",
                    "Profession",
                    "Add Profession"
                    }
            CBoxForm.Tag = Rtrn_Data
            CBoxForm.ShowDialog()
            LoadComboBoxData(ProfessionCB, Customer.ListOfProfessions)
            Exit Sub
        End If

        If e.KeyCode = Keys.Enter Then 'ENTER CLICK
            SendKeys.Send("{Tab}")
            Exit Sub
        End If
    End Sub

    Private Sub RegionCB_KeyDown(sender As Object, e As KeyEventArgs) Handles RegionCB.KeyDown
        If (e.KeyCode = Keys.Enter AndAlso e.Modifiers = Keys.Shift) Then 'Enter
            Dim Rtrn_Data As New List(Of String) From {
                    "Region",
                    "Region",
                    "Add Region"
                    }
            CBoxForm.Tag = Rtrn_Data
            CBoxForm.ShowDialog()
            LoadComboBoxData(RegionCB, Customer.ListOfRegions)
            Exit Sub
        End If

        If e.KeyCode = Keys.Enter Then 'ENTER
            SendKeys.Send("{Tab}")
            Exit Sub
        End If
    End Sub

#End Region

End Class