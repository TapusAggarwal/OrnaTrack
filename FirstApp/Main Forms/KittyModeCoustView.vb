Imports System.Data.OleDb
Imports System.Threading

Public Class KittyModeCoustView
    '    Sub New()
    '        InitializeComponent()
    '    End Sub

    '    Protected Overrides ReadOnly Property createParams As CreateParams
    '        Get
    '            Dim cp As CreateParams = MyBase.CreateParams
    '            cp.ExStyle = cp.ExStyle Or &H2000000
    '            Return cp
    '        End Get
    '    End Property

    '    Public BookMode As Boolean = False
    '    Public CoustmerID As String = -1
    '    Public Fm_KittyView As KittyView = Nothing
    '    Public Fm_KittyForm As KittyForm = Nothing
    '    Dim ExistingNumber As New Dictionary(Of String, List(Of String))
    '    Dim TotalKitties As Integer = 0
    '    Dim BookDict As New Dictionary(Of Integer, List(Of String))
    '    Dim current_id As Integer

    '    'EVENT:- CoustmerID Added
    '    Public Sub CoustmerIdTB_TextChanged() Handles CoustmerIdTB.TextChanged
    '        CoustmerID = CoustmerIdTB.Text
    '        If CoustmerIdTB.TextLength = 0 Then
    '            Dispose()
    '            Frame.NewCoustmerButton_Click()
    '        End If
    '        If CoustmerIdTB.TextLength > 0 Then
    '            RemoveControls()    'Clears KittyForm Before Opening Duplicate Customers
    '            CalculateTotalKitties()
    '            LoadCoustmerProfileData()
    '            LoadKittyViewData()
    '            CheckForDuplicatePhNo(PhNo.Text, False)
    '        End If
    '    End Sub

    '    'FUNCTION:- Load Form Data Also Coustmer's Full Data If Asked
    '    Public Sub CoustProfileUpdated_Load() Handles Me.Load
    '        CoustmerIdTB.Text = Tag.ToString.Split("_")(0)
    '        KeyPreview = True
    '    End Sub

    '    Private Sub Me_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
    '        Try
    '            If e.Control And e.KeyCode = Keys.I Then
    '                ShowCoustmerID()
    '                KittyIdTB.Visible = True
    '            ElseIf e.Control And e.KeyCode = Keys.N Then
    '                AddKittyButton_Click()
    '            End If
    '            If Fm_KittyForm IsNot Nothing Then
    '                If e.Control And e.KeyCode = Keys.S Then
    '                    Fm_KittyForm.SaveButton_Click(Fm_KittyForm.SaveButton, e)
    '                ElseIf e.Control And e.KeyCode = Keys.P Then
    '                    Fm_KittyForm.PaymentButton.Select()
    '                    Fm_KittyForm.PaymentButton_Click()
    '                    Fm_KittyForm.DatePicker.Select()
    '                ElseIf e.Control And e.KeyCode = Keys.D Then
    '                    Fm_KittyForm.DeleteButton_Click()
    '                    Fm_KittyForm.DatePicker.Select()
    '                End If
    '            End If
    '        Catch
    '        End Try
    '    End Sub

    '    'CallBack Function To Be Used By KittyView To Send Back KittyId
    '    Public Sub ShowKittyForm(KittyId As String)
    '        RemoveControls()        'Removes Previosly Opened KittyForm
    '        Dim T_Data As New List(Of String) From {
    '                CoustmerID,
    '                KittyId,
    '                1,
    '                "kittymode"
    '                }
    '        Invoke(Sub()
    '                   Fm_KittyForm = New KittyForm With {
    '                       .Tag = T_Data
    '                   }
    '                   Dim Pnl As Panel = Fm_KittyForm.MainPanel
    '                   Pnl.Dock = DockStyle.Fill
    '                   RemoveControls()
    '                   ShowLabel.Visible = False
    '                   Fm_KittyForm.Kitty_Load()
    '                   KittyPanel.Controls.Add(Pnl)
    '               End Sub)
    '    End Sub

    '#Region "FUNCTION:- Load Customer Profile"

    '    Private Sub LoadCoustmerProfileData()
    '        Dim dr As OleDbDataReader = DataReader("select * from Coustmers_Data Where SrNo=" & CoustmerID)
    '        While dr.Read
    '            Try
    '                FullName.Text = dr("CName").ToString.Trim     'Adding Name
    '            Catch : End Try
    '            Try
    '                FullName.Text = dr("CName").ToString.Trim & " " & dr("CsName").ToString.Trim     'Adding SirName
    '            Catch : End Try
    '            Try
    '                PhNo.Text = dr("PhNo")                        'Adding Phone Number
    '            Catch : End Try
    '            Try
    '                Profession.Text = dr("Prof").ToString.Trim                  'Adding Proffesion
    '            Catch : End Try
    '            Try
    '                Address.Text = dr("Address").ToString.Trim                          'Adding Address
    '            Catch : End Try
    '            Try
    '                Gender.Text = dr("Gender")      'Adding Male/Female
    '            Catch : End Try
    '            Try
    '                ImageBox.BackgroundImage = Image.FromFile(dr("img"))    'Adding Profile Iamge
    '            Catch : End Try
    '            Try
    '                Married.Text = dr("Mry")                          'Checking If Married 
    '            Catch : End Try
    '        End While
    '        dr.Close()
    '    End Sub
    '#End Region

    '#Region "FUNCTION:- Checks For All Customers With Same Numbers as this customer"
    '    Private Function CheckForDuplicatePhNo(PhNo As String, Optional SaveMsg As Boolean = True)
    '        If PhNo.Length < 10 Then
    '            Return False
    '        End If
    '        ExistingNumber.Clear()
    '        For Each No In PhNo.Split(",")
    '            No = No.Trim
    '            If myconnection.State <> ConnectionState.Open Then
    '                myconnection.Open()
    '            End If
    '            Dim dr As OleDbDataReader = DataReader("select * from Coustmers_Data Where PhNo like '%" & No & "%'")
    '            Try
    '                While dr.Read
    '                    If dr("CName").ToString.Length > 0 And dr("SrNo") <> CoustmerID Then
    '                        ExistingNumber.Add(dr("CName") & " " & dr("CsName"), New List(Of String)({dr("PhNo"), dr("SrNo")}))
    '                    End If
    '                End While
    '                dr.Close()
    '            Catch ex As Exception
    '                MessageBox.Show("Error: CheckForDuplaicatePhNo -> " & ex.Message)
    '            End Try
    '        Next
    '        'If SaveMsg Then
    '        '    Dim Ans As String = MessageBox.Show("There Are Coustmers Sharing The PhNo (" & PhNo & ") To Check Them Click The Button On The Right Side Of PhNo's.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
    '        'End If
    '        If ExistingNumber.Count > 0 Then
    '            ExistingPhNosButton.Invoke(Sub()
    '                                           ExistingPhNosButton.Visible = True
    '                                       End Sub)
    '            Return True
    '        Else
    '            ExistingPhNosButton.Invoke(Sub()
    '                                           ExistingPhNosButton.Visible = False
    '                                       End Sub)
    '            Return False
    '        End If
    '    End Function
    '#End Region

    '    'BUTTON:- Add Kitty
    '    Public Sub AddKittyButton_Click() Handles AddKittyButton.Click
    '        TotalKitties = 0
    '        Dim dr As OleDbDataReader =
    '                DataReader("Select Status,KittyNo from Kitty_Data Where CoustID='" & CoustmerID & "'")
    '        Dim KittyNo As New List(Of String)
    '        While dr.Read : TotalKitties += 1 : End While
    '        dr.Close()
    '        myconnection.Close()
    '        Dim T_Data As New List(Of String) From {
    '                CoustmerID,
    '                TotalKitties + 1,
    '                0,
    '                "kittymode"
    '                }
    '        Dim Fm As New Form
    '        Fm = KittyForm
    '        Fm.Tag = T_Data
    '        Fm.ShowDialog()
    '        CalculateTotalKitties()
    '    End Sub

    '#Region "FUNCTION:- Load Kitty View Data"
    '    Public Sub LoadKittyViewData()
    '        Fm_KittyView = New KittyView
    '        Fm_KittyView.Tag = New List(Of String)({CoustmerIdTB.Text, "callback"})
    '        Fm_KittyView.DgvMain.Columns(9).Visible = False
    '        PanelView.Controls.Clear()
    '        Dim Pnl As Panel = Fm_KittyView.SharingPanel
    '        Pnl.Dock = DockStyle.Fill
    '        PanelView.Controls.Add(Pnl)
    '        Fm_KittyView.KittyView_Load()
    '        KittyPanel_ControlAdded()
    '    End Sub
    '#End Region

    '#Region "FUNCTION:-Calculate Total Kitties"
    '    Private Sub CalculateTotalKitties()
    '        TotalKitties += 1
    '        Dim dr As OleDbDataReader =
    '                DataReader("Select Status,KittyNo from Kitty_Data Where CoustID='" & CoustmerID & "'")
    '        While dr.Read
    '            TotalKitties += 1
    '        End While
    '        dr.Close()
    '    End Sub
    '#End Region

    '    'BUTTON:- ConnectedKittys
    '    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles ConnectKittys.Click
    '        ConnectedKittyView.Tag = CoustmerID
    '        ConnectedKittyView.ShowDialog()
    '        ConnectedKittyView.Dispose()
    '        CalculateTotalKitties()
    '    End Sub

    '    Public Sub ShowCoustmerID()
    '        Try
    '            CoustmerIdTB.Invoke(Sub()
    '                                    CoustmerIdTB.Visible = True
    '                                End Sub)
    '        Catch ex As Exception
    '        End Try
    '    End Sub

    '    Private Sub CoustmerIdTB_KeyDown(sender As Object, e As KeyEventArgs) Handles CoustmerIdTB.KeyDown, KittyIdTB.KeyDown
    '        If (e.KeyCode = Keys.Enter AndAlso e.Modifiers = Keys.Shift) Then
    '            If Not WantToContinue("This Feature Is Only For DevUse: To Manually Change The ID. Do You Still Want To Continue?", "Data Loss Warning") Then Exit Sub
    '            Dim Id As String = InputBox("Enter The New Id.(This May Lead To Unexpected Errors)", "Enter ID")
    '            sender.Text = Id
    '        End If
    '    End Sub

    '    Private Sub ConnectionLabel_Click(sender As Object, e As EventArgs) Handles ExistingPhNosButton.Click
    '        Dim Tag_Data As New ArrayList From {
    '            ExistingNumber,
    '            "callback"
    '        }
    '        DgvForExistingPhno.Tag = Tag_Data
    '        DgvForExistingPhno.ShowInTaskbar = False
    '        DgvForExistingPhno.ShowDialog()
    '        DgvForExistingPhno.Dispose()
    '    End Sub

    '    Public Sub RemoveControls()
    '        For Each i In KittyPanel.Controls
    '            If i IsNot ShowLabel Then KittyPanel.Controls.Remove(i)
    '        Next
    '    End Sub

    '    Private Sub KittyIdTB_TextChanged(sender As Object, e As EventArgs) Handles KittyIdTB.TextChanged
    '        Try
    '            If KittyIdTB.Text = "" Then
    '                RemoveControls()
    '                Exit Sub
    '            End If
    '            ShowKittyForm(KittyIdTB.Text)

    '        Catch ex As Exception
    '        End Try
    '    End Sub

    '    Private Sub KittyModeCoustView_Closed(sender As Object, e As EventArgs) Handles Me.Closed
    '        PanelView.Controls.Clear()
    '        KittyPanel.Controls.Clear()
    '    End Sub

    '    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
    '        For Each ExistingFm As Form In Frame.MdiChildren
    '            If ExistingFm.Name <> "Main" Then
    '                Dim Fm As New CoustProfileUpdated With {
    '                .MdiParent = Frame,
    '                .Dock = DockStyle.Fill,
    '                .Tag = CoustmerID
    '                }
    '                Fm.Show()
    '                ExistingFm.Dispose()
    '            End If
    '        Next

    '    End Sub

    '    Private Sub KittyModeCoustView_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    '        Dim x1 As Thread = New Thread(Sub()
    '                                          If Tag.ToString.Split("_").Count > 1 Then
    '                                              KittyIdTB.Invoke(Sub()
    '                                                                   KittyIdTB.Text = Tag.ToString.Split("_")(1)
    '                                                               End Sub)
    '                                              'ShowKittyForm(Tag.ToString.Split("_")(1))
    '                                          End If
    '                                      End Sub) With {
    '            .Priority = ThreadPriority.Lowest
    '                                      }
    '        x1.Start()
    '    End Sub

    '    Private Sub AddKittyButton_Click(sender As Object, e As EventArgs) Handles AddKittyButton.Click

    '    End Sub

    '    Private Sub KittyPanel_ControlAdded() Handles KittyPanel.ControlAdded, KittyPanel.ControlRemoved
    '        If KittyPanel.Controls.Count = 1 Then
    '            ShowLabel.Visible = True
    '            KittyInfoLabel.Visible = False : PrevKittyButton.Visible = False : NextKittyButton.Visible = False
    '        Else
    '            ShowLabel.Visible = False
    '            If KittyIdTB.Text.Length = 0 Or CoustmerIdTB.Text.Length = 0 Then Exit Sub
    '            If BookMode Then
    '                KittyInfoLabel.Visible = True : PrevKittyButton.Visible = True : NextKittyButton.Visible = True
    '                Dim dr As OleDbDataReader = DataReader("Select KittyType,KittyNo From Kitty_Data Where KittyID='" & KittyIdTB.Text & "' AND CoustID='" & CoustmerIdTB.Text & "'")
    '                While dr.Read
    '                    If dr("KittyNo").GetType IsNot GetType(DBNull) And dr("KittyType").GetType IsNot GetType(DBNull) Then
    '                        KittyInfoLabel.Text = "₹" + dr("KittyType") + ": #" + dr("KittyNo") + ": "

    '                        Dim dr_range As OleDbDataReader = DataReader("Select * From Kitty_Data Where KittyType='" & dr("KittyType") & "'")
    '                        Dim range As New List(Of Integer)
    '                        While dr_range.Read
    '                            Try
    '                                Dim x As Integer = dr_range("KittyNo")
    '                                range.Add(x)
    '                            Catch ex As Exception
    '                            End Try
    '                        End While
    '                        KittyInfoLabel.Text += Str(range.Min).Trim + "-" + Str(range.Max).Trim + "[" & range.Count & "]"
    '                    End If
    '                    Exit While
    '                End While
    '                dr.Close()

    '            End If
    '        End If
    '    End Sub

    '    Sub OpenBookMode()
    '        KittyPanel_ControlAdded()
    '        Dim KittyType As Integer = KittyInfoLabel.Text.Split(":")(0)
    '        Dim KittyNo As Integer
    '        Try
    '            For Each i As Char In KittyInfoLabel.Text.Split(":")(1).Replace("#", "").Trim
    '                If Not IsNumeric(i) Then
    '                    Error "KittyNo Is Not An Integer."
    '                End If
    '            Next
    '            KittyNo = KittyInfoLabel.Text.Split(":")(1).Replace("#", "")
    '        Catch ex As Exception
    '            MessageBox.Show("Error: Kitty Number Of This Kitty Is Not An Integer. Try Changing It To An Integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '            BookMode = False
    '            Exit Sub
    '        End Try
    '        BookModeButton.IconColor = Color.PaleGreen


    '        Dim dr_range As OleDbDataReader = DataReader("Select CoustID,KittyID,KittyNo From Kitty_Data Where KittyType='" & KittyType & "'")
    '        Dim temp_dict As New Dictionary(Of List(Of String), Integer)
    '        While dr_range.Read
    '            Try
    '                temp_dict.Add(New List(Of String) From {dr_range("CoustID"), dr_range("KittyID"), dr_range("KittyNo")}, dr_range("KittyNo"))
    '            Catch ex As Exception
    '            End Try
    '        End While
    '        dr_range.Close()

    '        Dim sorted = From pair In temp_dict
    '                     Order By pair.Value
    '        Dim srno As Integer = 0
    '        For Each i In sorted
    '            srno += 1
    '            BookDict.Add(srno, i.Key)
    '            If i.Key(0) <> CoustmerIdTB.Text Then Continue For
    '            If i.Key(1) <> KittyIdTB.Text Then Continue For
    '            If i.Key(2) <> KittyNo Then Continue For
    '            current_id = srno
    '        Next
    '        If current_id = BookDict.Count Then NextKittyButton.Enabled = False Else NextKittyButton.Enabled = True
    '        If current_id = 1 Then PrevKittyButton.Enabled = False Else PrevKittyButton.Enabled = True
    '    End Sub

    '    Public Sub BookModeButton_Click() Handles BookModeButton.Click
    '        If KittyIdTB.Text.Length = 0 Or CoustmerIdTB.Text.Length = 0 Then Exit Sub
    '        BookMode = Not BookMode
    '        If BookMode Then
    '            OpenBookMode()
    '        End If
    '        If Not BookMode Then
    '            BookModeButton.IconColor = Color.Silver
    '            KittyInfoLabel.Visible = False : PrevKittyButton.Visible = False : NextKittyButton.Visible = False
    '        End If
    '    End Sub

    '    Private Sub NextKittyButton_Click(sender As Object, e As EventArgs) Handles NextKittyButton.Click
    '        Try
    '            current_id += 1
    '            CoustmerIdTB.Text = BookDict.Item(current_id)(0)
    '            KittyIdTB.Text = ""
    '            KittyIdTB.Text = BookDict.Item(current_id)(1)
    '        Catch ex As Exception
    '        End Try
    '        If current_id = BookDict.Count Then NextKittyButton.Enabled = False Else NextKittyButton.Enabled = True
    '        If current_id = 1 Then PrevKittyButton.Enabled = False Else PrevKittyButton.Enabled = True
    '    End Sub

    '    Private Sub PrevKittyButton_Click(sender As Object, e As EventArgs) Handles PrevKittyButton.Click
    '        Try
    '            current_id -= 1
    '            CoustmerIdTB.Text = BookDict.Item(current_id)(0)
    '            KittyIdTB.Text = ""
    '            KittyIdTB.Text = BookDict.Item(current_id)(1)
    '        Catch ex As Exception
    '        End Try
    '        If current_id = BookDict.Count Then NextKittyButton.Enabled = False Else NextKittyButton.Enabled = True
    '        If current_id = 1 Then PrevKittyButton.Enabled = False Else PrevKittyButton.Enabled = True
    '    End Sub
End Class