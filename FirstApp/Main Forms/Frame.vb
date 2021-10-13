Imports FontAwesome.Sharp

Public Class Frame

    Private Declare Auto Function SetWindowLong Lib "User32.Dll" (hWnd As IntPtr, nIndex As Integer, dwNewLong As Integer) As Integer
    Private Declare Auto Function GetWindowLong Lib "User32.Dll" (hWnd As IntPtr, nIndex As Integer) As Integer
    Private Const GWL_EXSTYLE = (-20)
    Private Const WS_EX_CLIENTEDGE = &H200

    Protected Overrides ReadOnly Property createParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property

#Region "Me.Load"
    Private Sub Frame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '' Fade in when started
        Me.Opacity = 0
        Dim tmr As New Timer With {
                .Interval = 2
                }
        tmr.Start()
        AddHandler tmr.Tick, Sub()
                                 Me.Opacity += 0.1
                                 If Me.Opacity = 1 Then tmr.Stop()
                             End Sub

        For Each c As Control In Me.Controls()
            If TypeOf (c) Is MdiClient Then
                c.BackColor = Color.DimGray
                Dim windowLong As Integer = GetWindowLong(c.Handle, GWL_EXSTYLE)
                windowLong = windowLong And (Not WS_EX_CLIENTEDGE)
                SetWindowLong(c.Handle, GWL_EXSTYLE, windowLong)
                c.Width = c.Width + 1
                Exit For
            End If
        Next
        For Each ctl As Control In Me.Controls
            If TypeOf ctl Is MdiClient Then
                'got the control, so cast it
                Dim mdiClientControl = DirectCast(ctl, MdiClient)
                'undock it
                mdiClientControl.Dock = DockStyle.None
                'resize it
                mdiClientControl.Bounds = Me.ClientRectangle
                mdiClientControl.Height += 20
                mdiClientControl.Width += 20
                'set the anchors
                mdiClientControl.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right Or
                                          AnchorStyles.Top

                'bail out
                Exit For
            End If
        Next

        InitaliseConnection()
        Try : myconnection.Open() : Catch : End Try

        WindowState = FormWindowState.Maximized
        QuickSearchButton_Click(QuickSearchButton, e)
        KeyPreview = True
    End Sub
#End Region

    Public Sub New()
        InitializeComponent()
        DoubleBuffered = True
        'Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub

    Public Sub QuickSearchButton_Click(sender As Object, e As EventArgs) Handles QuickSearchButton.Click
        If Main.IsMdiChild Then
            Main.Activate()
        Else
            Make_MdiChild(Main, Nothing)
        End If
        SidePanel()
    End Sub

    Public Sub NewCoustmerButton_Click() Handles NewCoustmerButton.Click
        For Each i As Form In MdiChildren
            If i.Name <> "Main" Then
                i.Dispose()
            End If
        Next
        Dim Fm As New CoustProfileUpdated With {
            .MdiParent = Me,
            .Dock = DockStyle.Fill,
            .Tag = Tag
        }
        Fm.Show()
    End Sub

    Private Sub LeftArrowButton_Click(sender As Object, e As EventArgs) Handles LeftArrowButton.Click, RightArrowButton.Click
        'If Main Is ActiveMdiChild Then CoustProfileUpdated.Activate() Else Main.Activate()
        SendKeys.SendWait("^{Tab}")
    End Sub

    Private Sub SendMessageButton_Click(sender As Object, e As EventArgs) Handles SendMessageButton.Click
        SidePanel()
    End Sub

    Private Sub SidePanelButton_Click(sender As Object, e As EventArgs) Handles SidePanelButton.Click
        SidePanel(True)
    End Sub

    Private Sub SidePanel(Optional click = False)
        If Not PanelMenu.Visible And click Then
            PanelMenu.Visible = True
        Else
            PanelMenu.Visible = False
        End If
    End Sub

#Region "All KeyDown Events Ex.-Ctrl+S"
    Private Sub Frame_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            If (e.Control And e.KeyCode = Keys.B) Then
                'BookMode.ShowDialog()
                '    Dim Ans As String = InputBox("Enter Kitty Type To Check Last Entry.", "Find Last Entry")
                '    Dim dr As OleDbDataReader = DataReader($"Select KittyNo from Kitty_Data Where KittyType='{Ans}'")
                '    'Dim Max = 0, min = 1000000
                '    'While dr.Read
                '    '    Try
                '    '        If Max < Int(dr("KittyNo")) Then Max = Int(dr("KittyNo"))
                '    '        If min > Int(dr("KittyNo")) Then min = Int(dr("KittyNo"))
                '    '    Catch ex As Exception
                '    '    End Try
                '    'End While
                '    'myconnection.Close()
                '    'dr.Close()
                '    'If ActiveMdiChild Is Main Then
                '    '    Main.KittyNoTB.Text = Max
                '    '    Main.FindClick(sender, e)
                '    '    MessageBox.Show($"KittyType-{Ans} Range- {min}-{Max}")
                '    '    Exit Sub
                '    'End If
                '    'MessageBox.Show($"KittyType-{Ans} Range- {min}-{Max}")
                Exit Sub
            End If
            If (e.Control And e.KeyCode = Keys.R) Then
                'Report.Show()
                Exit Sub
            End If
            If e.Control And e.KeyCode = Keys.N Then
                NewCoustmerButton_Click()
                Exit Sub
            End If
            If e.Control And e.KeyCode = Keys.Q Then
                QuickSearchButton_Click(QuickSearchButton, e)
                Main.NameTB.Select()
                Exit Sub
            End If
        Catch ex As Exception
        End Try
    End Sub

#End Region

    Private Sub IconCurrentForm_Click(sender As Object, e As EventArgs)
        Close()
        'If Not WantToContinue("Do You Want To Put system on sleep.", "Confirm") Then Exit Sub
        'Application.SetSuspendState(PowerState.Suspend, True, False)
    End Sub

    Private Sub Frame_MdiChildActivate() Handles Me.MdiChildActivate
        Dim ButtonsOreientaion As New Threading.Thread(Sub()
                                                           Invoke(Sub()
                                                                      If MdiChildren.Count <= 1 Then
                                                                          LeftArrowButton.ForeColor = Color.Black
                                                                          LeftArrowButton.Enabled = False
                                                                          RightArrowButton.ForeColor = Color.Black
                                                                          RightArrowButton.Enabled = False
                                                                          Exit Sub
                                                                      End If
                                                                      If ActiveMdiChild Is Main Then
                                                                          RightArrowButton.ForeColor = Color.LightGreen
                                                                          RightArrowButton.Enabled = True
                                                                          LeftArrowButton.ForeColor = Color.Black
                                                                          LeftArrowButton.Enabled = False
                                                                      Else
                                                                          LeftArrowButton.ForeColor = Color.LightGreen
                                                                          LeftArrowButton.Enabled = True
                                                                          RightArrowButton.ForeColor = Color.Black
                                                                          RightArrowButton.Enabled = False
                                                                      End If
                                                                  End Sub)
                                                       End Sub) With {
            .IsBackground = True,
            .Priority = Threading.ThreadPriority.AboveNormal
                                                                          }
        ButtonsOreientaion.Start()
    End Sub

    Public Sub Make_MdiChild(Fm As Form, Tag As Object)
        Try
            For Each ExistingFm As Form In MdiChildren
                If ExistingFm Is Fm Then
                    ExistingFm.Dispose()
                End If
            Next
            Fm.MdiParent = Me
            Fm.Tag = Tag
            Fm.Dock = DockStyle.Fill
            Fm.Show()
            'make_thread.Abort()
        Catch ex As Exception
            MessageBox.Show($"Error: (Make_MdiChild/Frame)-> {ex.Message}")
        End Try
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Close()
    End Sub

    Private Sub WindowsRestoreButton_Click(sender As Object, e As EventArgs) Handles WindowsRestoreButton.Click
        If WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
            WindowsRestoreButton.IconChar = IconChar.WindowRestore
            Refresh()
            For Each fm As Form In MdiChildren
                fm.Refresh()
            Next
        Else
            Me.WindowState = FormWindowState.Normal
            WindowsRestoreButton.IconChar = IconChar.WindowMaximize
            Me.Location = New Point(0, 0)
            Refresh()
            For Each fm As Form In MdiChildren
                fm.Refresh()
            Next
        End If
        Me.Select()
    End Sub

    Private Sub WindowsMinimizeButton_Click(sender As Object, e As EventArgs) Handles WindowsMinimizeButton.Click
        Me.WindowState = FormWindowState.Minimized
        Me.Select()
    End Sub

    Private Sub Frame_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Refresh()
        For Each fm As Form In MdiChildren
            fm.Refresh()
        Next
    End Sub

End Class