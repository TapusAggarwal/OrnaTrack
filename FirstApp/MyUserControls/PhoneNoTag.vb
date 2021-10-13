Public Class PhoneNoTag

    Protected _data As String

    Public Property TagData As String

        Get
            Dim My_Data = ""
            For Each TB As TextBox In FlowLayoutPanel1.Controls
                If TB.TextLength = 10 Then
                    My_Data += TB.Text + ", "
                End If
            Next
            Try
                My_Data = My_Data.Substring(0, My_Data.Length - 2)
            Catch ex As Exception
                My_Data = ""
            End Try
            Return My_Data
        End Get
        Set(value As String)

            If value.Length < 10 Then
                For Each textbox As TextBox In FlowLayoutPanel1.Controls
                    If textbox IsNot InitialTB Then
                        FlowLayoutPanel1.Controls.Remove(textbox)
                    End If
                Next
                InitialTB.Text = ""
                Exit Property
            End If
            Dim TB As New TextBox
            TB = InitialTB
            FlowLayoutPanel1.Controls.Clear()
            FlowLayoutPanel1.Controls.Add(TB)
            InitialTB.Text = ""
            Dim a = 3
            For Each no In value.Split(",")
                no = no.Trim
                If InitialTB.Text = "" Then
                    InitialTB.Text = no
                    Continue For
                End If
                Dim DynamicTB As New TextBox With {
                        .Font = InitialTB.Font,
                        .Size = InitialTB.Size,
                        .TabIndex = a
                    }
                AddHandler DynamicTB.KeyDown, AddressOf TB_KeyDownEvent
                AddHandler DynamicTB.Leave, AddressOf TB_Leave
                AddHandler DynamicTB.GotFocus, AddressOf TB_GotFocus
                FlowLayoutPanel1.Controls.Add(DynamicTB)
                DynamicTB.Text = no
                a += 1
            Next

        End Set
    End Property

    Public Event UP_keyPressed()
    Public Event DOWN_keyPressed()

    Private Sub TB_KeyDownEvent(sender As TextBox, e As KeyEventArgs) Handles InitialTB.KeyDown

        If sender.TextLength = 0 Or sender.TextLength = 10 Then
            If e.KeyCode = Keys.Up Then
                InitialTB.Select()
                RaiseEvent UP_keyPressed()
                Exit Sub
            ElseIf e.KeyCode = Keys.Down Then
                InitialTB.Select()
                RaiseEvent DOWN_keyPressed()
                Exit Sub
            End If
        End If

        If e.KeyCode = Keys.Enter Then
            If FlowLayoutPanel1.Controls.Count >= 4 Then
                RaiseEvent DOWN_keyPressed()
            End If
            If sender.TextLength <> 10 Then
                MessageBox.Show("PhNo Must Be 10 Digit Long This No Is " & sender.TextLength & " Digit Long.",
                            "Typing Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                sender.Select()
                Exit Sub
            Else
                Dim DynamicTB As New TextBox With {
                .Font = InitialTB.Font,
                .Size = InitialTB.Size,
                .WordWrap = False
            }
                AddHandler DynamicTB.KeyDown, AddressOf TB_KeyDownEvent
                AddHandler DynamicTB.Leave, AddressOf TB_Leave
                AddHandler DynamicTB.GotFocus, AddressOf TB_GotFocus
                FlowLayoutPanel1.Controls.Add(DynamicTB)
                DynamicTB.Select()
            End If
        End If

    End Sub

    Private Sub TB_Leave(sender As TextBox, e As EventArgs) Handles InitialTB.Leave

        If sender.TextLength > 0 AndAlso sender.TextLength <> 10 Then
            MessageBox.Show("PhNo Must Be 10 Digit Long This No Is " & sender.TextLength & " Digit Long.",
                            "Typing Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sender.Select()
            Exit Sub
        End If

        sender.BackColor = Color.White

        If sender.TextLength = 0 And sender IsNot ActiveControl Then

            If sender Is InitialTB Then
                TagData = TagData 'Gets Data From The Get Method And Then Sets It
            Else
                FlowLayoutPanel1.Controls.Remove(sender)
                If FlowLayoutPanel1.Controls.Count >= 4 Then
                    Exit Sub
                End If
            End If

        End If

    End Sub

    Private Sub TB_GotFocus(sender As TextBox, e As EventArgs) Handles InitialTB.GotFocus
        For Each TB As TextBox In FlowLayoutPanel1.Controls
            TB.BackColor = Color.White
        Next
        ActiveControl.BackColor = Color.Goldenrod
    End Sub

End Class