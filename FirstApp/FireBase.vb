Imports Google.Cloud.Firestore
Public Class FireBase
    Dim db As FirestoreDb
    Private Sub FireBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim _path As String = AppDomain.CurrentDomain.BaseDirectory + "bj-database.json"
        Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", _path)
        db = FirestoreDb.Create("bj-database")
        MessageBox.Show("Done")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'hi
        Dim coll As CollectionReference = db.Collection("customers_data")

        Dim dr As OleDb.OleDbDataReader = DataReader("Select * From Coustmers_Data")
        While dr.Read

            Dim f = Function(x)
                        Return If(IsDBNull(x), "", x)
                    End Function

            Dim _dict As New Dictionary(Of String, String) From {
                {"srno", f(dr("SrNo"))},
                {"address", f(dr("Address"))},
                {"cname", f(dr("CName"))},
                {"csname", f(dr("CsName"))},
                {"dscrp", f(dr("dscrp"))},
                {"gender", f(dr("Gender"))},
                {"img", f(dr("img"))},
                {"mry", f(dr("Mry"))},
                {"phno", f(dr("PhNo"))},
                {"prof", f(dr("Prof"))},
                {"region", f(dr("Region"))},
                {"review", f(dr("Review"))}
            }

            Task.Run(Sub()
                         coll.AddAsync(_dict)
                         Invoke(Sub()
                                    Label1.Text += 1
                                End Sub)
                     End Sub)
        End While

    End Sub

    Private Sub Add_Document(_dict As Dictionary(Of String, String))
        Dim coll As CollectionReference = db.Collection("customers_data")
        coll.AddAsync(_dict)
    End Sub

End Class