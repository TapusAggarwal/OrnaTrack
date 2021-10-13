Public Class Main
    Dim ControlLimit As Integer = 12

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NameTB.Select()
    End Sub

    Private Async Sub SearchTextBoxes_TextChanged(sender As TextBox, e As EventArgs) Handles NameTB.TextChanged, PhNoTB.TextChanged, KittyNoTB.TextChanged

        If sender.TextLength Then

            Dim T_List As New List(Of Task(Of KittyModeControl))

            Dim newSearchRecord As Integer() = Nothing

            Dim InitalName As String = NameTB.Text
            Dim InitalPhNo As String = PhNoTB.Text
            Dim InitalKittyNo As String = KittyNoTB.Text

            If NameTB.TextLength Then
                newSearchRecord = Customer.SearchByName(NameTB.Text)
            ElseIf PhNoTB.TextLength Then
                newSearchRecord = Customer.SearchByPhNo(InitalPhNo)
            ElseIf KittyNoTB.TextLength Then
                T_List = Customer.ListOF_KittyModeControl(IDs:=Customer.SearchByKittyNo(InitalKittyNo, ControlLimit), isKittyID:=True)
            End If

            If newSearchRecord Is Nothing Then
                FlowLayoutPanel1.Controls.Clear()
                GC.Collect()
            Else
                T_List = Customer.ListOF_KittyModeControl(IDs:=newSearchRecord, MaxLimit:=12)
            End If

            FlowLayoutPanel1.Controls.Clear()

            If T_List IsNot Nothing AndAlso T_List.Count Then
                Dim res = Await Task.WhenAll(T_List)
                FlowLayoutPanel1.Visible = False
                FlowLayoutPanel1.Controls.Clear()
                If NameTB.Text = InitalName And PhNoTB.Text = InitalPhNo And KittyNoTB.Text = InitalKittyNo Then
                    For Each i In res
                        FlowLayoutPanel1.Controls.Add(i)
                    Next
                    FlowLayoutPanel1.Visible = True
                    GC.Collect()
                End If
            End If

        Else
            FlowLayoutPanel1.Controls.Clear()
            GC.Collect()
        End If

    End Sub

    Private Sub KittyNoTB_TextChanged(sender As TextBox, e As EventArgs) Handles KittyNoTB.TextChanged, PhNoTB.TextChanged

        If Not IsNumeric(sender.Text) Then
            Dim temp_var As String = sender.Text
            If temp_var.Length Then
                NameTB.Text = temp_var
                NameTB.Select()
                SendKeys.Send("{End}")
            End If
            sender.Clear()
        End If

    End Sub

    'Private Sub FindCoustmerButton_Click(sender As Object, e As EventArgs) Handles FindCoustmerButton.Click
    '    Dim y As New KittyModeControl
    '    AddHandler y.WhiteButtonClicked, Sub(_sender As Object, _e As EventArgs)
    '                                         MessageBox.Show("This Event Is Handled")
    '                                     End Sub

    '    Dim x As New Form With {
    '        .Text = "User Control",
    '        .FormBorderStyle = FormBorderStyle.None,
    '        .TopLevel = True,
    '        .MaximizeBox = False,
    '        .MinimizeBox = False,
    '        .ClientSize = y.Size,
    '        .StartPosition = FormStartPosition.CenterScreen,
    '        .BackColor = Color.FromArgb(36, 35, 80)
    '    }
    '    y.Dock = DockStyle.Fill
    '    x.Controls.Add(y)
    '    x.ShowDialog()
    'End Sub

End Class