Public Class PreviewCustomers

    Public PreviewList As New List(Of Kitty)

    Private Function ListOF_KittyModeControl(KittyList As List(Of Kitty)) As List(Of Task(Of KittyModeControl))
        If KittyList.Count = 0 Then Return Nothing

        Dim T_List As New List(Of Task(Of KittyModeControl))

        For Each _kitty As Kitty In KittyList
            T_List.Add(Task.Run(Function()
                                    Dim CoustmerPanel As New KittyModeControl
                                    With CoustmerPanel
                                        .CoustName = _kitty.Owner.FullName
                                        .PhNo = _kitty.Owner.PhNo(",")
                                        .SetImage = ""
                                        If _kitty.IsAvailed Then
                                            .LastInstalmentDate = -2
                                        ElseIf _kitty.IsMatured Then
                                            .LastInstalmentDate = -1
                                        Else
                                            .LastInstalmentDate = _kitty.GetInstalmentsPending
                                        End If
                                        .KittyType = _kitty.KittyType()
                                        Try
                                            .KittyNo = _kitty.KittyNo
                                        Catch ex As Exception
                                            .KittyType = ""
                                        End Try
                                        .CoustID = _kitty.Owner.CustomerID
                                        .KittyID = _kitty.KittyUID
                                    End With
                                    Return CoustmerPanel
                                End Function))
        Next

        Return T_List

    End Function

    Private Async Sub PreviewCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If PreviewList.Count = 0 Then Exit Sub
        Dim T_List = Nothing
        With Me
            .Cursor = Cursors.AppStarting
            .Refresh()
        End With

        KeyPreview = True

        T_List = ListOF_KittyModeControl(PreviewList)

        FlowLayoutPanel1.Controls.Clear()

        If T_List IsNot Nothing AndAlso T_List.Count Then

            Dim res = Await Task.WhenAll(T_List)
            FlowLayoutPanel1.Visible = False
            FlowLayoutPanel1.Controls.Clear()
            Dim a As Integer = 0
            For Each i In res
                a += 1
                FlowLayoutPanel1.Controls.Add(i)
                Dim x As KittyModeControl = i
                AddHandler x.DetailsButton_Clicked, AddressOf ControlButton_Clicked
                x.SrNo = a
            Next
            FlowLayoutPanel1.Visible = True
            GC.Collect()

        End If

        With Me
            .Cursor = Cursors.Default
            .Refresh()
        End With

        FlowLayoutPanel1.Select()
    End Sub

    Public Sub ControlButton_Clicked(CustomerID As Integer, KittyID As Integer)
        Using Fm As New PreviewKitty With {
            ._customer = New Customer(CustID:=CustomerID),
            ._kitty = New Kitty(KittyID, True, True)
        }
            Fm.ShowDialog()
        End Using
    End Sub

    Private Sub PreviewCustomers_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'MessageBox.Show(FlowLayoutPanel1.VerticalScroll.Value)
        FlowLayoutPanel1.VerticalScroll.SmallChange = 240
        Try
            If e.KeyCode = Keys.Up Then
                Dim change As Integer = FlowLayoutPanel1.VerticalScroll.Value - FlowLayoutPanel1.VerticalScroll.SmallChange
                FlowLayoutPanel1.AutoScrollPosition = New Point(0, change)
            ElseIf e.KeyCode = Keys.Down Then
                Dim change As Integer = FlowLayoutPanel1.VerticalScroll.Value + FlowLayoutPanel1.VerticalScroll.SmallChange
                FlowLayoutPanel1.AutoScrollPosition = New Point(0, change)
            End If
        Catch ex As Exception
        End Try

    End Sub
End Class