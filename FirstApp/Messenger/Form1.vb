Public Class Form1
    ReadOnly Kitties As New Dictionary(Of Integer, Dictionary(Of String, List(Of Kitty)))
    ReadOnly SelectedMatured As New List(Of Kitty)
    ReadOnly SelectedAvailed As New List(Of Kitty)
    ReadOnly instalmentsLeft As New Dictionary(Of Integer, List(Of Kitty))
    ReadOnly instalmentsPending As New Dictionary(Of Integer, List(Of Kitty))

    ReadOnly SelectedKitties As New List(Of Kitty)

    Private Sub KittyItemsVisibility(state As Boolean)
        KittyTypeCList.Visible = state
        MaturedChB.Visible = state
        AvailedChB.Visible = state
        InstalmentsLeftCList.Visible = state
    End Sub

    Private Sub KittySelectionChB_CheckedChanged(sender As Object, e As EventArgs) Handles KittySelectionChB.CheckedChanged
        If CustomerSelectionChB.Checked And KittySelectionChB.Checked = True Then
            CustomerSelectionChB.Checked = False
        End If

        CustomerSelectionChB.Enabled = True
        KittySelectionChB.Enabled = False

        If KittySelectionChB.Checked Then
            KittyTypeCList.Visible = True
            Kitties.Clear()
            With Me
                .Cursor = Cursors.AppStarting
                .Refresh()
            End With

            Dim dr As OleDb.OleDbDataReader = DataReader("Select KittyUID From Kitty_Data")
            While dr.Read
                Dim _temp As New Kitty(UID:=dr("KittyUID"), InitializeKitty:=True, completely:=True)
                If Not Kitties.ContainsKey(_temp.KittyType) Then
                    Dim _hashMap As New Dictionary(Of String, List(Of Kitty)) From {
                        {"active", New List(Of Kitty)},
                        {"matured", New List(Of Kitty)},
                        {"availed", New List(Of Kitty)}
                    }
                    Kitties.Add(_temp.KittyType, _hashMap)
                End If
                If _temp.IsAvailed Then
                    Kitties.Item(_temp.KittyType).Item("availed").Add(_temp)
                ElseIf _temp.IsMatured Then
                    Kitties.Item(_temp.KittyType).Item("matured").Add(_temp)
                ElseIf _temp.GivenAmount > 0 Then
                    Kitties.Item(_temp.KittyType).Item("active").Add(_temp)
                End If
            End While

            dr.Close()

            KittyTypeCList.Items.Clear()
            Dim total As Integer = 0
            For Each i In Kitties : total += i.Value.Item("active").Count : Next
            KittyTypeCList.Items.Add($"All({total})")

            For Each i In Kitties
                KittyTypeCList.Items.Add($"{i.Key} ({i.Value.Item("active").Count + i.Value.Item("matured").Count + i.Value.Item("availed").Count})")
            Next

            With Me
                .Cursor = Cursors.Default
                .Refresh()
            End With

            GC.Collect()

        Else
            KittyItemsVisibility(state:=False)
        End If
    End Sub

    Private Sub CustomerSelectionChB_CheckedChanged(sender As Object, e As EventArgs) Handles CustomerSelectionChB.CheckedChanged
        If KittySelectionChB.Checked And CustomerSelectionChB.Checked = True Then KittySelectionChB.Checked = False

        CustomerSelectionChB.Enabled = False
        KittySelectionChB.Enabled = True

        If CustomerSelectionChB.Checked Then
            For i As Integer = 0 To KittyTypeCList.Items.Count - 1
                KittyTypeCList.SetItemChecked(i, False)
            Next
            KittyTypeCList.Visible = False
        End If
    End Sub

    Private Sub UpdateInstalmentsLeft(Optional AddSelection As Integer = -1, Optional RemoveSelection As Integer = -1)

        Dim x As New List(Of Integer)
        For Each i In KittyTypeCList.CheckedItems

            Try
                If KittyTypeCList.GetItemChecked(KittyTypeCList.Items.IndexOf(i)) Then
                    x.Add(Int(i.ToString.Split("(")(0)))
                End If
            Catch ex As Exception
            End Try

        Next

        Try
            If AddSelection <> -1 Then
                x.Add(AddSelection)
            ElseIf RemoveSelection <> -1 Then
                x.Remove(RemoveSelection)
            End If
        Catch ex As Exception
        End Try


        x = x.Distinct.ToList

        SelectedMatured.Clear()
        SelectedAvailed.Clear()

        Dim _active As New List(Of Kitty)

        For Each i In x
            SelectedMatured.AddRange(Kitties.Item(i).Item("matured"))
            SelectedAvailed.AddRange(Kitties.Item(i).Item("availed"))
            _active.AddRange(Kitties.Item(i).Item("active"))
        Next

        If SelectedMatured.Count > 0 Then
            MaturedChB.Enabled = True
            MaturedChB.Text = $"Matured ({SelectedMatured.Count})"
        Else
            MaturedChB.Enabled = False
            MaturedChB.Text = "Matured"
        End If

        If SelectedAvailed.Count > 0 Then
            AvailedChB.Enabled = True
            AvailedChB.Text = $"Availed ({SelectedAvailed.Count})"
        Else
            AvailedChB.Enabled = False
            AvailedChB.Text = "Availed"
        End If

        InstalmentsLeftCList.Items.Clear()
        instalmentsLeft.Clear()

        For Each i In _active
            If instalmentsLeft.ContainsKey(i.GetInstalments_LeftForMaturity) Then
                instalmentsLeft.Item(i.GetInstalments_LeftForMaturity).Add(i)
            Else
                instalmentsLeft.Add(i.GetInstalments_LeftForMaturity, New List(Of Kitty) From {i})
            End If
        Next

        instalmentsLeft.Remove(0)

        Dim sorted = From pair In instalmentsLeft
                     Order By pair.Key

        Dim total As Integer = 0
        For Each i In sorted
            total += i.Value.Count
            If i.Key = 1 Then
                InstalmentsLeftCList.Items.Add($"{i.Key} Instalment Left ({i.Value.Count})")
            Else
                InstalmentsLeftCList.Items.Add($"{i.Key} Instalments Left ({i.Value.Count})")
            End If
        Next
        InstalmentsLeftCList.Items.Insert(0, $"All ({total})")
        InstalmentsPendingCList.Visible = False

        UpdateInstalmentsPending()

    End Sub

    Private Sub UpdateInstalmentsPending(Optional AddSelection As Integer = -1, Optional RemoveSelection As Integer = -1)
        Dim x As New List(Of Integer)
        For Each i In InstalmentsLeftCList.CheckedItems

            Try
                If InstalmentsLeftCList.GetItemChecked(InstalmentsLeftCList.Items.IndexOf(i)) Then
                    x.Add(Int(i.ToString.Split(" ")(0)))
                End If
            Catch ex As Exception
            End Try

        Next

        Try
            If AddSelection <> -1 Then
                x.Add(AddSelection)
            ElseIf RemoveSelection <> -1 Then
                x.Remove(RemoveSelection)
            End If
        Catch ex As Exception
        End Try

        InstalmentsPendingCList.Items.Clear()
        instalmentsPending.Clear()

        x = x.Distinct.ToList

        For Each i In x
            For Each _kitty In instalmentsLeft.Item(i)
                If instalmentsPending.ContainsKey(_kitty.GetInstalmentsPending) Then
                    instalmentsPending.Item(_kitty.GetInstalmentsPending).Add(_kitty)
                Else
                    instalmentsPending.Add(_kitty.GetInstalmentsPending, New List(Of Kitty) From {_kitty})
                End If
            Next
        Next

        Dim sorted = From pair In instalmentsPending
                     Order By pair.Key

        Dim total As Integer = 0
        For Each i In sorted
            total += i.Value.Count
            If i.Key = 1 Then
                InstalmentsPendingCList.Items.Add($"{i.Key} Instalment Pending ({i.Value.Count})")
            Else
                InstalmentsPendingCList.Items.Add($"{i.Key} Instalments Pending ({i.Value.Count})")
            End If
        Next
        InstalmentsPendingCList.Items.Insert(0, $"All ({total})")

        UpdateSelectedKitty()

    End Sub

    Private Sub UpdateSelectedKitty(Optional AddSelection As Integer = -1, Optional RemoveSelection As Integer = -1)
        SelectedKitties.Clear()

        Dim x As New List(Of Integer)
        For Each i In InstalmentsPendingCList.CheckedItems

            Try
                If InstalmentsPendingCList.GetItemChecked(InstalmentsPendingCList.Items.IndexOf(i)) Then
                    x.Add(Int(i.ToString.Split(" ")(0)))
                End If
            Catch ex As Exception
            End Try

        Next

        Try
            If AddSelection <> -1 Then
                x.Add(AddSelection)
            ElseIf RemoveSelection <> -1 Then
                x.Remove(RemoveSelection)
            End If
        Catch ex As Exception
        End Try

        x = x.Distinct.ToList

        For Each i In x
            For Each _kitty In instalmentsPending.Item(i)
                SelectedKitties.Add(_kitty)
            Next
        Next

        If MaturedChB.Checked Then
            SelectedKitties.AddRange(SelectedMatured)
        End If
        If AvailedChB.Checked Then
            SelectedKitties.AddRange(SelectedAvailed)
        End If

        If SelectedKitties.Count = 0 Then
            SelectedCustomersLB.Text = 0
            PreviewBT.Enabled = False
            SendButton.Enabled = False
        Else
            SelectedCustomersLB.Text = SelectedKitties.Count
            PreviewBT.Enabled = True
            SendButton.Enabled = True
        End If


    End Sub

    Private Sub InstalmentsPendingCList_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles InstalmentsPendingCList.ItemCheck
        If InstalmentsPendingCList.Items.Item(e.Index).ToString.Split(" ")(0).Trim = "All" AndAlso e.NewValue = CheckState.Checked Then
            For i = 1 To InstalmentsPendingCList.Items.Count - 1
                InstalmentsPendingCList.SetItemChecked(i, True)
            Next
        ElseIf InstalmentsPendingCList.Items.Item(e.Index).ToString.Split(" ")(0).Trim = "All" AndAlso e.NewValue = CheckState.Unchecked AndAlso e.CurrentValue = CheckState.Checked Then
            If InstalmentsPendingCList.CheckedItems.Count = InstalmentsPendingCList.Items.Count Then
                For i = 1 To InstalmentsPendingCList.Items.Count - 1
                    InstalmentsPendingCList.SetItemChecked(i, False)
                Next
            End If
        End If

        If e.NewValue = CheckState.Unchecked Then
            If InstalmentsPendingCList.Items.Item(e.Index).ToString.Split(" ")(0).Trim <> "All" AndAlso e.NewValue = CheckState.Unchecked Then
                InstalmentsPendingCList.Refresh()
                RemoveHandler InstalmentsPendingCList.ItemCheck, AddressOf InstalmentsPendingCList_ItemCheck
                InstalmentsPendingCList.SetItemChecked(0, False)
                AddHandler InstalmentsPendingCList.ItemCheck, AddressOf InstalmentsPendingCList_ItemCheck
            End If
        End If


        Dim Selection As Integer = -1
        Try
            Selection = Int(InstalmentsPendingCList.Items.Item(e.Index).ToString.Split(" ")(0).Trim)
        Catch ex As Exception
        End Try

        If Selection = -1 Then Exit Sub


        If e.NewValue = CheckState.Checked Then
            UpdateSelectedKitty(Selection)
        Else
            UpdateSelectedKitty(-1, Selection)
        End If

    End Sub

    Private Sub InstalmentsLeftCList_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles InstalmentsLeftCList.ItemCheck
        'PreviewBT.Enabled = False
        If InstalmentsLeftCList.Items.Item(e.Index).ToString.Split(" ")(0).Trim = "All" AndAlso e.NewValue = CheckState.Checked Then
            For i = 1 To InstalmentsLeftCList.Items.Count - 1
                InstalmentsLeftCList.SetItemChecked(i, True)
            Next
        ElseIf InstalmentsLeftCList.Items.Item(e.Index).ToString.Split(" ")(0).Trim = "All" AndAlso e.NewValue = CheckState.Unchecked AndAlso e.CurrentValue = CheckState.Checked Then
            If InstalmentsLeftCList.CheckedItems.Count = InstalmentsLeftCList.Items.Count Then
                For i = 1 To InstalmentsLeftCList.Items.Count - 1
                    InstalmentsLeftCList.SetItemChecked(i, False)
                Next
            End If
        End If

        If e.NewValue = CheckState.Unchecked Then
            If InstalmentsLeftCList.Items.Item(e.Index).ToString.Split(" ")(0).Trim <> "All" AndAlso e.NewValue = CheckState.Unchecked Then
                InstalmentsLeftCList.Refresh()
                RemoveHandler InstalmentsLeftCList.ItemCheck, AddressOf InstalmentsLeftCList_ItemCheck
                InstalmentsLeftCList.SetItemChecked(0, False)
                AddHandler InstalmentsLeftCList.ItemCheck, AddressOf InstalmentsLeftCList_ItemCheck
            End If
            If InstalmentsLeftCList.CheckedItems.Count = 1 Then
                InstalmentsPendingCList.Visible = False
            End If
        End If

        If e.NewValue = CheckState.Checked AndAlso InstalmentsLeftCList.CheckedItems.Count = 0 Then
            InstalmentsPendingCList.Visible = True
        End If

        Dim Selection As Integer = -1
        Try
            Selection = Int(InstalmentsLeftCList.Items.Item(e.Index).ToString.Split(" ")(0).Trim)
        Catch ex As Exception
        End Try

        If Selection = -1 Then Exit Sub

        If e.NewValue = CheckState.Checked Then
            UpdateInstalmentsPending(Selection)
        Else
            UpdateInstalmentsPending(-1, Selection)
        End If

    End Sub

    Private Sub KittyTypeCList_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles KittyTypeCList.ItemCheck

        If KittyTypeCList.Items.Item(e.Index).ToString.Split("(")(0).Trim = "All" AndAlso e.NewValue = CheckState.Checked Then
            For i = 1 To KittyTypeCList.Items.Count - 1
                KittyTypeCList.SetItemChecked(i, True)
            Next
        ElseIf KittyTypeCList.Items.Item(e.Index).ToString.Split("(")(0).Trim = "All" AndAlso e.NewValue = CheckState.Unchecked AndAlso e.CurrentValue = CheckState.Checked Then
            If KittyTypeCList.CheckedItems.Count = KittyTypeCList.Items.Count Then
                For i = 1 To KittyTypeCList.Items.Count - 1
                    KittyTypeCList.SetItemChecked(i, False)
                Next
            End If
        End If

        If e.NewValue = CheckState.Unchecked Then
            If KittyTypeCList.Items.Item(e.Index).ToString.Split("(")(0).Trim <> "All" AndAlso e.NewValue = CheckState.Unchecked Then
                KittyTypeCList.Refresh()
                RemoveHandler KittyTypeCList.ItemCheck, AddressOf KittyTypeCList_ItemCheck
                KittyTypeCList.SetItemChecked(0, False)
                AddHandler KittyTypeCList.ItemCheck, AddressOf KittyTypeCList_ItemCheck
            End If
            If KittyTypeCList.CheckedItems.Count = 1 Then
                KittyItemsVisibility(state:=False)
                KittyTypeCList.Visible = True
            End If
        End If

        If e.NewValue = CheckState.Checked AndAlso KittyTypeCList.CheckedItems.Count = 0 Then
            KittyItemsVisibility(state:=True)
        End If

        Dim Selection As Integer = -1
        Try
            Selection = Int(KittyTypeCList.Items.Item(e.Index).ToString.Split("(")(0).Trim)
        Catch ex As Exception
        End Try

        If Selection = -1 Then Exit Sub

        If e.NewValue = CheckState.Checked Then
            UpdateInstalmentsLeft(Selection)
        Else
            UpdateInstalmentsLeft(-1, Selection)
        End If

    End Sub

    Private Sub PreviewBT_Click(sender As Object, e As EventArgs) Handles PreviewBT.Click
        PreviewCustomers.PreviewList = SelectedKitties
        PreviewCustomers.Show()
    End Sub

    Private Sub MaturedChB_CheckedChanged(sender As Object, e As EventArgs) Handles MaturedChB.CheckedChanged, AvailedChB.CheckedChanged
        UpdateSelectedKitty()
    End Sub

    Private Sub SendButton_Click(sender As Object, e As EventArgs) Handles SendButton.Click
        Using Fm As New MessageSender
            Fm.SelectedKitties = SelectedKitties
            Fm.ShowDialog()
        End Using
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim Fm As New MessagePreviewForm

        Try
            Dim x As String = ""
            Dim dr As OleDb.OleDbDataReader = DataReader("Select Sent From Message_Data where id=1")
            While dr.Read
                x = dr(0)
            End While
            If x.Length > 10 Then
                Fm.SentList = x.Split(",").ToList
            End If
        Catch ex As Exception
        End Try

        Try
            Dim x As String = ""
            Dim dr As OleDb.OleDbDataReader = DataReader("Select Failed From Message_Data where id=1")
            While dr.Read
                x = dr(0)
            End While
            If x.Length > 10 Then
                Fm.FailedList = x.Split(",").ToList
            End If
        Catch ex As Exception
        End Try

        Try
            Dim x As String = ""
            Dim dr As OleDb.OleDbDataReader = DataReader("Select UnRegistered From Message_Data where id=1")
            While dr.Read
                x = dr(0)
            End While
            If x.Length > 10 Then
                Fm.UnRegisteredList = x.Split(",").ToList
            End If
        Catch ex As Exception
        End Try

        Try
            Dim x As String = ""
            Dim dr As OleDb.OleDbDataReader = DataReader("Select Removed From Message_Data where id=1")
            While dr.Read
                x = dr(0)
            End While
            If x.Length > 10 Then
                Fm.RemovedList = x.Split(",").ToList
            End If
        Catch ex As Exception
        End Try

        Try
            Dim x As String = ""
            Dim dr As OleDb.OleDbDataReader = DataReader("Select Initial From Message_Data where id=1")
            While dr.Read
                x = dr(0)
            End While

            Dim Messages As New List(Of Tuple(Of String, Kitty))

            For Each i In x.Split(",")
                Messages.Add(New Tuple(Of String, Kitty)(i.Split("_")(0), New Kitty(i.Split("_")(1), True, True)))
            Next

            Fm.MessagesToSend = Messages

        Catch ex As Exception
        End Try

        Try
            Dim x As Integer = -1
            Dim dr As OleDb.OleDbDataReader = DataReader("Select CurrentControlsValue From Message_Data where id=1")
            While dr.Read
                x = Int(dr(0))
            End While
            If x > 0 Then
                Fm.CurrentControlsValue = x
            End If
        Catch ex As Exception

        End Try

        Fm.ShowDialog()

    End Sub

End Class