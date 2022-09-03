Imports Newtonsoft.Json

Public Class Form4

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        InitaliseConnection()
        Try : myconnection.Open() : Catch : End Try

        Dim refNos As New List(Of String)

        Dim _kitties As New Dictionary(Of Integer, Kitty)

        Dim dr As OleDb.OleDbDataReader = DataReader("Select * From Kitty_Data Where TransactionDetails <> ''")
        Dim w As Integer = 0
        While dr.Read
            Dim x As New Kitty(dr("KittyUID"), True, True)
            x.InitializeTransactions()

            _kitties.Add(x.KittyUID, x)

            For Each i In x.TransactionsRecord.Values
                If i = "" Then Continue For
                Dim SavedData As Linq.JObject = Linq.JObject.Parse(i)
                Dim _val As String = SavedData.SelectToken("RefNo")
                If _val = "" Then Continue For
                If _val.Contains("/") Then Continue For
                If _val.Contains("S") Then
                    If _val.StartsWith("SBIN") Then
                        refNos.Add(_val.Replace("SBIN", "") + $"-UID:{x.KittyUID}-KittyNo:{x.KittyNo}")
                    End If
                    Continue For
                End If
                For Each _ref In _val.Split(",")
                    refNos.Add(_ref + $"-UID:{x.KittyUID}-KittyNo:{x.KittyNo}")
                Next
            Next
        End While


        Dim y = refNos.Select(Function(f) f.Split("-")(0)).ToList

        Dim _copy As New List(Of String)
        _copy.AddRange(refNos)

        For Each i In y
            Dim _selected = _copy.Where(Function(f) f.StartsWith(i))
            If _selected.Count = 1 Then
                _copy.Remove(_selected(0))
            End If
        Next

        Dim dsa As String = String.Join("
", _copy)

        MessageBox.Show($"Total: {refNos.Count}, Duplicate: {refNos.Count - y.Count}")

    End Sub



End Class

'1.  203809592659-UID:355-KittyNo:1004
'2.  215809114940-UID:355-KittyNo:1004
'3.  209947531263-UID:384-KittyNo:994
'4.  134208177627-UID:386-KittyNo:1080
'5.  134208177627-UID:387-KittyNo:1081
'6.  215594021909-UID:388-KittyNo:995
'7.  209947531263-UID:438-KittyNo:1062
'8.  203809592659-UID:481-KittyNo:1000
'9.  215809114940-UID:481-KittyNo:1000
'10. 134208177627-UID:506-KittyNo:1098
'11. 215594021909-UID:506-KittyNo:1098
'12. 134208177627-UID:507-KittyNo:1099
'13. 215279470622-UID:521-KittyNo:998
'14. 215279470622-UID:562-KittyNo:1120