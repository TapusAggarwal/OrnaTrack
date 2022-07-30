Public Class Graph

    Dim payments2019 As New Dictionary(Of Integer, Integer)
    Dim payments2020 As New Dictionary(Of Integer, Integer)
    Dim payments2021 As New Dictionary(Of Integer, Integer)
    Dim payments2022 As New Dictionary(Of Integer, Integer)

    Dim paymentsCount As New Dictionary(Of String, Integer)

    Private Sub Graph_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim given As Integer = 0
        Dim interest As Integer = 0
        Dim avail As Integer = 0

        For i = 1 To 581

            Dim _kitty As New Kitty(UID:=i, InitializeKitty:=True, completely:=True)

            If _kitty.Record.Count = 0 Then Continue For

            Select Case _kitty.Record.First.Key.Year
                Case 2019
                    If payments2019.ContainsKey(_kitty.Record.First.Key.Month) Then
                        payments2019(_kitty.Record.First.Key.Month) += 1
                    Else
                        payments2019.Add(_kitty.Record.First.Key.Month, 1)
                    End If
                Case 2020
                    If payments2020.ContainsKey(_kitty.Record.First.Key.Month) Then
                        payments2020(_kitty.Record.First.Key.Month) += 1
                    Else
                        payments2020.Add(_kitty.Record.First.Key.Month, 1)
                    End If
                Case 2021
                    If payments2021.ContainsKey(_kitty.Record.First.Key.Month) Then
                        payments2021(_kitty.Record.First.Key.Month) += 1
                    Else
                        payments2021.Add(_kitty.Record.First.Key.Month, 1)
                    End If
                Case 2022
                    If payments2022.ContainsKey(_kitty.Record.First.Key.Month) Then
                        payments2022(_kitty.Record.First.Key.Month) += 1
                    Else
                        payments2022.Add(_kitty.Record.First.Key.Month, 1)
                    End If
            End Select

            given += _kitty.GivenAmount
            interest += _kitty.KittyInterest

            If _kitty.IsAvailed Then
                avail += _kitty.GivenAmount
            End If

        Next

        Dim sorted2019 = From pair In payments2019
                         Order By pair.Key

        For Each i In sorted2019
            Dim lbl As New Label
            lbl.Text = $"{i.Key},2019-{i.Value}"
            lbl.AutoSize = True
            FlowLayoutPanel2019.Controls.Add(lbl)
        Next

        Dim sorted2020 = From pair In payments2020
                         Order By pair.Key

        For Each i In sorted2020
            Dim lbl As New Label
            lbl.Text = $"{i.Key},2020-{i.Value}"
            lbl.AutoSize = True
            FlowLayoutPanel2020.Controls.Add(lbl)
        Next

        Dim sorted2021 = From pair In payments2021
                         Order By pair.Key

        For Each i In sorted2021
            Dim lbl As New Label
            lbl.Text = $"{i.Key},2021-{i.Value}"
            lbl.AutoSize = True
            FlowLayoutPanel2021.Controls.Add(lbl)
        Next

        Dim sorted2022 = From pair In payments2022
                         Order By pair.Key

        For Each i In sorted2022
            Dim lbl As New Label
            lbl.Text = $"{i.Key},2022-{i.Value}"
            lbl.AutoSize = True
            FlowLayoutPanel2022.Controls.Add(lbl)
        Next


        Label1.Text = given
        Label2.Text = interest
        Label3.Text = avail

    End Sub

    Private Sub TillDateAmount()

        For i = 1 To 581

            Dim _kitty As New Kitty(UID:=i, InitializeKitty:=True, completely:=True)

            For Each pair In _kitty.Record

                Dim _date As Tuple(Of Integer, Integer) = New Tuple(Of Integer, Integer)(pair.Key.Month, pair.Key.Year)
                Dim _amount As Integer = pair.Value

                If _date.Item2 = 2019 Then
                    If payments2019.ContainsKey(_date.Item1) Then
                        payments2019.Item(_date.Item1) += _amount
                    Else
                        payments2019.Add(_date.Item1, _amount)
                    End If
                End If

                If _date.Item2 = 2020 Then
                    If payments2020.ContainsKey(_date.Item1) Then
                        payments2020.Item(_date.Item1) += _amount
                    Else
                        payments2020.Add(_date.Item1, _amount)
                    End If
                End If

                If _date.Item2 = 2021 Then
                    If payments2021.ContainsKey(_date.Item1) Then
                        payments2021.Item(_date.Item1) += _amount
                    Else
                        payments2021.Add(_date.Item1, _amount)
                    End If
                End If

                If _date.Item2 = 2022 Then
                    If payments2022.ContainsKey(_date.Item1) Then
                        payments2022.Item(_date.Item1) += _amount
                    Else
                        payments2022.Add(_date.Item1, _amount)
                    End If
                End If

            Next

        Next

        Dim sorted2019 = From pair In payments2019
                         Order By pair.Key

        For Each i In sorted2019
            Dim lbl As New Label
            lbl.Text = $"{i.Key},2019-{i.Value}"
            lbl.AutoSize = True
            FlowLayoutPanel2019.Controls.Add(lbl)
        Next

        Dim sorted2020 = From pair In payments2020
                         Order By pair.Key

        For Each i In sorted2020
            Dim lbl As New Label
            lbl.Text = $"{i.Key},2020-{i.Value}"
            lbl.AutoSize = True
            FlowLayoutPanel2020.Controls.Add(lbl)
        Next

        Dim sorted2021 = From pair In payments2021
                         Order By pair.Key

        For Each i In sorted2021
            Dim lbl As New Label
            lbl.Text = $"{i.Key},2021-{i.Value}"
            lbl.AutoSize = True
            FlowLayoutPanel2021.Controls.Add(lbl)
        Next

        Dim sorted2022 = From pair In payments2022
                         Order By pair.Key

        For Each i In sorted2022
            Dim lbl As New Label
            lbl.Text = $"{i.Key},2022-{i.Value}"
            lbl.AutoSize = True
            FlowLayoutPanel2022.Controls.Add(lbl)
        Next

    End Sub

End Class
