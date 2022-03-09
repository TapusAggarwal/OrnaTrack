Imports System.Threading

Public Class KittyModeCoustView

    Protected Overrides ReadOnly Property createParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property

    Protected _Customer As Customer
    Public _KittyID_Book As Integer = Nothing
    Public _KittyForm As KittyForm
    Public BookMode As Boolean = False
    Protected BookList As New List(Of Integer)

    Protected ReviewMode As Boolean = False
    Protected _reviewed As Boolean = False

#Region "Load Customer And Kitty Data"
    'Load -> CustomerId TextBox Text = TAG(CustomerId)
    Public Sub CoustProfileUpdated_Load() Handles Me.Load
        KeyPreview = True
        CustomerIdTB.Text = Tag.ToString.Split("_")(0).Trim
        If Prev_SessionToolStripMenuItem.Checked Then
            Prev_SessionToolStripMenuItem_Click(Prev_SessionToolStripMenuItem, EventArgs.Empty)
        End If

        'List Of KittyTypes For Book Mode
        For Each i In Kitty.GetListOfKittyTypes
            Dim x As New ToolStripMenuItem With {
                .Checked = True,
                .CheckOnClick = True,
                .Text = i
            }
            BookModeSelectedTypes.Items.Add(x)

            AddHandler x.CheckedChanged, Sub(_sender As ToolStripMenuItem, _e As EventArgs)
                                             BookModeSelectedTypes.Show(DotsButton, 0, DotsButton.Size.Height)
                                             If BookMode Then
                                                 ShowBook()
                                             End If
                                         End Sub
        Next

    End Sub

    'Loading Data On Text Changed Event
    Public Sub CoustmerIdTB_TextChanged(sender As Object, e As EventArgs) Handles CustomerIdTB.TextChanged
        If CustomerIdTB.TextLength = 0 Then
            Dispose()
            Frame.NewCoustmerButton_Click()
        End If

        _Customer = New Customer(CustomerIdTB.Text.Trim)

        If CustomerIdTB.TextLength > 0 Then
            LoadCustomerProfileData()
            LoadCustomerKittyData()
            UpdateBookModeIndexes()
            If ReviewMode Then
                Dim dr As OleDb.OleDbDataReader = DataReader($"Select Review From Coustmers_Data Where SrNo={_Customer.CustomerID}")
                While dr.Read
                    Try
                        If dr("Review").ToString.Split("_")(1) = "False" Then
                            _reviewed = False
                        Else
                            _reviewed = True
                        End If
                    Catch ex As Exception
                    End Try
                End While
                UpdateReview()
            End If
        End If
    End Sub

    'First Load Customer Profile
    Private Sub LoadCustomerProfileData()
        With _Customer
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
            If Customer.SharedPhNo(_Customer.GetPhNo.ToArray).Count > 1 Then
                ExistingPhNosButton.Visible = True
            Else
                ExistingPhNosButton.Visible = False
            End If
        End With

    End Sub

    'Second Load Kitty View Data
    Private Sub LoadCustomerKittyData()
        Dim _KittyView As KittyView
        _KittyView = New KittyView With {
            .Tag = _Customer
        }

        _KittyView.DgvMain.Columns(9).Visible = False ' Button That Makes Direct Entry "Make Entry" Button
        PanelView.Controls.Clear()
        Dim Pnl As Panel = _KittyView.SharingPanel
        Pnl.Dock = DockStyle.Fill
        PanelView.Controls.Add(Pnl)
        _KittyView.KittyView_Load()

        AddHandler _KittyView.ShowDetailsClicked, Sub(_kitty As Kitty)
                                                      KittyIdTB.Text = ""
                                                      KittyIdTB.Text = _kitty.KittyUID
                                                  End Sub

        Dim _count As Integer = _Customer.OwnedKitties.Count
        If _count = 1 Then
            KittyIdTB.Text = _Customer.OwnedKitties.First.KittyUID
        ElseIf _count = 0 Then
            KittyIdTB.Text = ""
        End If

        If Not String.IsNullOrEmpty(KittyIdTB.Text) Then
            Dim _temp As New Kitty(KittyIdTB.Text.Trim, True)
            If _temp.CustomerID = -1 Then
                KittyIdTB.Text = ""
            End If
        End If

    End Sub

    'KittyID TextBox Text=Tag.split(_)(1)
    Private Sub KittyModeCoustView_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim x1 As New Thread(Sub()
                                 If Tag.ToString.Split("_").Count > 1 Then
                                     KittyIdTB.Invoke(Sub()
                                                          KittyIdTB.Text = Tag.ToString.Split("_")(1)
                                                      End Sub)
                                 End If
                             End Sub) With {
            .Priority = ThreadPriority.Lowest
                                      }
        x1.Start()
    End Sub

    'Call Load Kitty Data Method
    Private Sub KittyIdTB_TextChanged(sender As Object, e As EventArgs) Handles KittyIdTB.TextChanged
        RemoveControls()
        If KittyIdTB.TextLength <> 0 Then
            ShowKittyForm(New Kitty(KittyIdTB.Text.Trim, InitializeKitty:=True, True))
        End If
    End Sub

    'Loads A Form Given A Kitty
    Public Sub ShowKittyForm(_tempKitty As Kitty)
        Invoke(Sub()
                   _KittyForm = New KittyForm With {
                       .Tag = _tempKitty
                   }
                   Dim Pnl As Panel = _KittyForm.MainPanel
                   Pnl.Dock = DockStyle.Fill
                   RemoveControls()
                   ShowLabel.Visible = False
                   _KittyForm.Kitty_Load(_KittyForm, EventArgs.Empty)
                   KittyPanel.Controls.Add(Pnl)
                   AddHandler _KittyForm.CloseButton_Clicked, Sub()
                                                                  RemoveControls()
                                                              End Sub
                   AddHandler _KittyForm.ReloadKittyView, Sub()
                                                              LoadCustomerKittyData()
                                                          End Sub
                   CustomerIdTB.Text = _tempKitty.CustomerID
               End Sub)
    End Sub

    'SHIFT + ENTER -> For Manually Changing CustomerID And KittyID
    Private Sub CoustmerIdTB_KeyDown(sender As Object, e As KeyEventArgs) Handles CustomerIdTB.KeyDown, KittyIdTB.KeyDown
        If (e.KeyCode = Keys.Enter AndAlso e.Modifiers = Keys.Shift) Then
            If MessageBox.Show("This Feature Is Only For DevUse: To Manually Change The ID. Do You Still Want To Continue?", "Data Loss Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Exit Sub
            Dim Id As String = InputBox("Enter The New Id.(This May Lead To Unexpected Errors)", "Enter ID")
            If Not IsNumeric(sender.text) Then Exit Sub
            sender.Text = Id
        End If
    End Sub

    'Makes IDs Visible
    Public Sub ShowCoustmerID()
        Try
            CustomerIdTB.Invoke(Sub()
                                    CustomerIdTB.Visible = True
                                    KittyIdTB.Visible = True
                                End Sub)
        Catch ex As Exception
        End Try
    End Sub

    'Removes All Controls From Kitty Panel Except ShowLabel
    Public Sub RemoveControls()
        For Each i In KittyPanel.Controls
            If i IsNot ShowLabel Then KittyPanel.Controls.Remove(i)
        Next
    End Sub

    'Hides Show Label If Control IS Added TO Panel OR Shows It If Removed
    Private Sub KittyPanel_ControlAdded() Handles KittyPanel.ControlAdded, KittyPanel.ControlRemoved
        If KittyPanel.Controls.Count = 1 Then
            ShowLabel.Visible = True
        End If
    End Sub

#End Region

#Region "Direct Important Methods"
    'Customer Details Button Click
    Private Sub CustomerDetailsButton_Click(sender As Object, e As EventArgs) Handles CustomerDetailsButton.Click
        For Each ExistingFm As Form In Frame.MdiChildren
            If ExistingFm.Name <> "Main" Then
                Dim Fm As New CoustProfileUpdated With {
                .MdiParent = Frame,
                .Dock = DockStyle.Fill,
                .Tag = _Customer.CustomerID
                }
                Fm.Show()
                ExistingFm.Dispose()
            End If
        Next

    End Sub

    'ExistingPhNo Button Click
    Private Sub ExistingPhNosButton_Click(sender As Object, e As EventArgs) Handles ExistingPhNosButton.Click
        Dim Fm As New DgvForExistingPhno With {
            .CurrentPhNo = _Customer.GetPhNo.ToArray,
            .CurrentCustomer = _Customer,
            .ShowInTaskbar = False
        }
        Fm.ShowDialog()
        If Fm.SelectedCustomer >= 0 Then
            CustomerIdTB.Text = Fm.SelectedCustomer
        End If
    End Sub

    'KeyBoard ShortCuts
    Private Sub Me_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.Control And e.KeyCode = Keys.K Then
                AddKittyButton_Click(AddKittyButton, EventArgs.Empty)
            End If
            If _KittyForm IsNot Nothing Then
                If e.Control And e.KeyCode = Keys.I Then
                    _KittyForm.MarkAsInactiveToolStripMenuItem.PerformClick()
                ElseIf e.Control And e.KeyCode = Keys.C Then
                    _KittyForm.CrackThisKittyToolStripMenuItem.PerformClick()
                ElseIf e.Control And e.KeyCode = Keys.S Then
                    _KittyForm.SaveButton_Click(_KittyForm.SaveButton, e)
                ElseIf e.Control And e.KeyCode = Keys.P Then
                    _KittyForm.PaymentButton.Select()
                    _KittyForm.PaymentButton_Click(_KittyForm.PaymentButton, e)
                    _KittyForm.DatePicker.Select()
                ElseIf e.Control And e.KeyCode = Keys.D Then
                    _KittyForm.DeleteButton_Click(_KittyForm.DeleteButton, e)
                    _KittyForm.DatePicker.Select()
                ElseIf e.Control And e.KeyCode = Keys.B Then
                    BookModeButton_Click(BookModeButton, EventArgs.Empty)
                ElseIf e.Control And e.KeyCode = Keys.J Then
                    JumpToKittyNoButton_Click(JumpToKittyNoButton, EventArgs.Empty)
                ElseIf e.Control And e.KeyCode = Keys.Right Then
                    NextKittyButton_Click(NextKittyButton, EventArgs.Empty)
                ElseIf e.Control And e.KeyCode = Keys.Left Then
                    PrevKittyButton_Click(PrevKittyButton, EventArgs.Empty)
                End If
            End If
        Catch
        End Try
    End Sub

    'AddKitty Button
    Private Sub AddKittyButton_Click(sender As Object, e As EventArgs) Handles AddKittyButton.Click
        Dim _tempKitty As New Kitty With {
            .CustomerID = _Customer.CustomerID
        }
        Dim KittyForm_Fm As New KittyForm With {
          .Tag = _tempKitty
          }
        KittyForm_Fm.ShowDialog()
        LoadCustomerKittyData()
    End Sub

#End Region

#Region "BookMode"
    Public Sub BookModeButton_Click(sender As Object, e As EventArgs) Handles BookModeButton.Click
        If KittyIdTB.Text.Length = 0 Then Exit Sub

        BookList.Clear()

        BookMode = Not BookMode

        If BookMode Then
            ShowBook()
        End If
        If Not BookMode Then
            BookModeButton.IconColor = Color.Silver
            KittyInfoLabel.Visible = False : PrevKittyButton.Visible = False : NextKittyButton.Visible = False : JumpToKittyNoButton.Visible = False
        End If
    End Sub

    Private Sub ShowBook()
        Dim selectedTypes = (From _items As ToolStripMenuItem In BookModeSelectedTypes.Items Where _items.Checked = True Select _items.Text).ToArray

        If selectedTypes.Count = 0 Then
            MessageBox.Show("First Select Kitty Types To Be Included In BookMode. By Clicking On Three Dots.")
            Exit Sub
        End If

        Dim _condition As String = ""

        For Each i In selectedTypes
            If Array.IndexOf(selectedTypes, i) <> 0 Then
                _condition += $" OR KittyType={i}"
            Else
                _condition += $"KittyType={i}"
            End If
        Next

        BookList.Clear()

        Dim dr As OleDb.OleDbDataReader = DataReader($"Select KittyUID From Kitty_Data Where ({_condition}) ORDER BY KittyNo ASC")
        While dr.Read
            BookList.Add(dr("KittyUID"))
        End While

        If Not selectedTypes.Contains(_KittyForm._currentKitty.KittyType) Then
            MessageBox.Show("You Have Not Selected Kitty Type Of Currently Opened Kitty. This Will Jump Back To Zero.")
            _KittyID_Book = BookList.First
            KittyIdTB.Text = _KittyID_Book
        End If


        KittyInfoLabel.Visible = True : PrevKittyButton.Visible = True : NextKittyButton.Visible = True : JumpToKittyNoButton.Visible = True
        BookModeButton.IconColor = Color.PaleGreen
        UpdateBookModeIndexes()
    End Sub

    Private Sub UpdateBookModeIndexes()
        If Not BookMode Then Exit Sub
        _KittyID_Book = KittyIdTB.Text
        KittyInfoLabel.Text = $"{_KittyForm._currentKitty.KittyType.ToCurrency(RemoveSpaces:=True)} : #{_KittyForm._currentKitty.KittyNo}: {New Kitty(BookList.First, True).KittyNo}-{New Kitty(BookList.Last, True).KittyNo}"
        Dim Index As Integer = CurrentIndex()
        If Index = 0 Then PrevKittyButton.Enabled = False Else PrevKittyButton.Enabled = True
        If Index = BookList.Count - 1 Then NextKittyButton.Enabled = False Else NextKittyButton.Enabled = True
    End Sub

    Private Function CurrentIndex() As Integer
        Return BookList.IndexOf(_KittyID_Book)
    End Function

    Private Sub NextKittyButton_Click(sender As Object, e As EventArgs) Handles NextKittyButton.Click
        Dim _currentIndex As Integer = CurrentIndex()
        KittyIdTB.Text = BookList.Item(_currentIndex + 1)
        UpdateBookModeIndexes()
    End Sub

    Private Sub PrevKittyButton_Click(sender As Object, e As EventArgs) Handles PrevKittyButton.Click
        KittyIdTB.Text = New Kitty(BookList.Item(CurrentIndex() - 1)).KittyUID
        UpdateBookModeIndexes()
    End Sub

    Private Sub JumpToKittyNoButton_Click(sender As Object, e As EventArgs) Handles JumpToKittyNoButton.Click
        Dim EnteredKittyNo As String = InputBox("Enter The New KittyNo To Which You Want To Jump To.", "Enter KittyNo")
        If Not IsNumeric(EnteredKittyNo) Then
            If EnteredKittyNo = "" Then Exit Sub
            MessageBox.Show("KittyNo Must Be An Integer. Try Again", "Illegal Selection", MessageBoxButtons.OK, MessageBoxIcon.Error)
            JumpToKittyNoButton_Click(sender, e)
            Exit Sub
        End If
        For Each id In BookList
            Dim _tempKitty As New Kitty(id, InitializeKitty:=True)
            If _tempKitty.KittyNo = EnteredKittyNo Then
                KittyIdTB.Text = BookList.Item(BookList.IndexOf(_tempKitty.KittyUID))
                UpdateBookModeIndexes()
                Exit Sub
            End If
        Next
        Dim selectedTypes = (From _items As ToolStripMenuItem In BookModeSelectedTypes.Items Where _items.Checked = True Select _items.Text).ToArray

        MessageBox.Show($"There Is No Kitty Saved With KittyTypes-{String.Join(" OR ", selectedTypes)} And KittyNo-{EnteredKittyNo}. Try Selecting More KittyTypes Or Use Another KittyNo.", "No Result Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

#End Region

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        Dim dr As OleDb.OleDbDataReader = DataReader("SELECT * From Coustmers_Data")
        Dim SessionNo As Integer = -1

        While dr.Read
            Try
                SessionNo = dr("Review").ToString.Split("_")(0)
                If SessionNo <= 0 Then
                    SessionNo = -1
                End If
            Catch ex As Exception
            End Try
            Exit While
        End While

        If SessionNo = -1 Then
            Prev_SessionToolStripMenuItem.Visible = False
        Else
            Prev_SessionToolStripMenuItem.Visible = True
            Prev_SessionToolStripMenuItem.Text = $"Prev_Sess: SessionID:{SessionNo}"
        End If
    End Sub

    Private Sub Prev_SessionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Prev_SessionToolStripMenuItem.Click
        ReviewMode = True
        ReviewButton.Visible = True
        If ReviewMode Then
            Dim dr As OleDb.OleDbDataReader = DataReader($"Select Review From Coustmers_Data Where SrNo={_Customer.CustomerID}")
            While dr.Read
                Try
                    If dr("Review").ToString.Split("_")(1) = "False" Then
                        _reviewed = False
                    Else
                        _reviewed = True
                    End If
                Catch ex As Exception
                End Try
            End While
            UpdateReview()
        End If
    End Sub

    Private Sub StartNewReviewSessionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartNewReviewSessionToolStripMenuItem.Click
        Dim dr As OleDb.OleDbDataReader = DataReader("SELECT * From Coustmers_Data")
        Dim SessionNo As Integer = -1

        While dr.Read
            Try
                SessionNo = dr("Review").ToString.Split("_")(0)
                If SessionNo <= 0 Then
                    SessionNo = -1
                End If
            Catch ex As Exception
            End Try
            Exit While
        End While
        If SessionNo <> -1 Then
            SqlCommand($"UPDATE Coustmers_Data set Review='{SessionNo + 1}_False'")
        Else
            SqlCommand($"UPDATE Coustmers_Data set Review='1_False'")
        End If
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles ReviewButton.Click
        If ReviewMode Then
            _reviewed = Not _reviewed
            UpdateReview()
        End If
    End Sub

    Sub UpdateReview()
        Dim dr As OleDb.OleDbDataReader = DataReader("SELECT * From Coustmers_Data")
        Dim SessionNo As Integer = -1

        While dr.Read
            Try
                SessionNo = dr("Review").ToString.Split("_")(0)
                If SessionNo <= 0 Then
                    SessionNo = -1
                End If
            Catch ex As Exception
            End Try
            Exit While
        End While

        If SessionNo = -1 Then Exit Sub

        If _reviewed Then
            ReviewButton.IconFont = FontAwesome.Sharp.IconFont.Solid
            ReviewButton.IconColor = Color.Gold
            SqlCommand($"UPDATE Coustmers_Data set Review='{SessionNo}_True' WHERE SrNo={_Customer.CustomerID}")
        Else
            ReviewButton.IconFont = FontAwesome.Sharp.IconFont.Auto
            ReviewButton.IconColor = Color.MediumPurple
            SqlCommand($"UPDATE Coustmers_Data set Review='{SessionNo}_False' WHERE SrNo={_Customer.CustomerID}")
        End If
    End Sub

    Private Sub DotsButton_Click(sender As Object, e As EventArgs) Handles DotsButton.Click

        If BookModeSelectedTypes.Visible Then
            BookModeSelectedTypes.Hide()
            Exit Sub
        End If

        Dim _alreadyAddedTypes As New List(Of Integer)

        ' Collecting Already Added Items To The MenuStrip
        For Each i As ToolStripMenuItem In BookModeSelectedTypes.Items
            _alreadyAddedTypes.Add(i.Text)
        Next

        ' Adding All The Types That Are Not Already Added
        For Each i In Kitty.GetListOfKittyTypes
            If _alreadyAddedTypes.Contains(i) Then
                _alreadyAddedTypes.Remove(i)
                Continue For
            End If
            Dim x As New ToolStripMenuItem With {
                .Checked = True,
                .CheckOnClick = True,
                .Text = i
            }
            BookModeSelectedTypes.Items.Add(x)

            AddHandler x.CheckedChanged, Sub(_sender As ToolStripMenuItem, _e As EventArgs)
                                             BookModeSelectedTypes.Show(DotsButton, 0, DotsButton.Size.Height)
                                             If BookMode Then
                                                 ShowBook()
                                             End If
                                         End Sub

        Next

        ' Removing Items That Are Not In ListOfKittyTypes
        For Each i In _alreadyAddedTypes

            Dim x = From _items As ToolStripMenuItem In BookModeSelectedTypes.Items
                    Where _items.Text = i

            If x.Count > 0 Then
                BookModeSelectedTypes.Items.Remove(x(0))
            End If
        Next

        BookModeSelectedTypes.Show(DotsButton, 0, DotsButton.Size.Height)
    End Sub

End Class