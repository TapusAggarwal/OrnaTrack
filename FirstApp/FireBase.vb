Imports Google.Cloud.Firestore
Public Class FireBase
    Dim db As FirestoreDb
    Private Async Sub FireBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim _path As String = AppDomain.CurrentDomain.BaseDirectory + "bj-database.json"
        Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", _path)
        db = Await FirestoreDb.CreateAsync("bj-database")
        MessageBox.Show("Done")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UploadAllKitties()
    End Sub

    Private Sub UploadAllKitties()
        Dim coll As CollectionReference = db.Collection("kitty_data")

        Dim dr As OleDb.OleDbDataReader = DataReader("Select * From Kitty_Data")
        While dr.Read

            Dim f = Function(x)
                        Return If(IsDBNull(x), "", x)
                    End Function
            Dim _id As Integer
            Dim _kitty As Kitty = Nothing
            Try
                _id = f(dr("KittyUID"))
                _kitty = New Kitty(_id, True, True)
            Catch ex As Exception
                Continue While
            End Try

            Dim _dict As New Dictionary(Of String, Object) From {
                {"CustomerID", _kitty.CustomerID},
                {"KittyNo", _kitty.KittyNo},
                {"KittyType", _kitty.KittyType},
                {"RecordString", _kitty.RecordString},
                {"Interest", _kitty.KittyInterest},
                {"Duration", _kitty.Duration},
                {"IsInactive", _kitty.IsInactive},
                {"IsAvailed", _kitty.IsAvailed},
                {"ConnectedTo", f(dr("ConnectedTo"))},
                {"Notes", f(dr("Notes"))}
            }

            Task.Run(Sub()
                         Dim id As Integer = _id
                         Dim doc As DocumentReference = coll.Document(id)
                         Dim _result = doc.SetAsync(_dict)
                         Invoke(Sub()
                                    Label1.Text += 1
                                End Sub)
                     End Sub)
        End While
    End Sub

    Private Sub UploadAllCustomers()
        'hi
        Dim coll As CollectionReference = db.Collection("customers_data")

        Dim dr As OleDb.OleDbDataReader = DataReader("Select * From Coustmers_Data")
        While dr.Read

            Dim f = Function(x)
                        Return If(IsDBNull(x), "", x)
                    End Function
            Dim _id As Integer
            Try
                _id = f(dr("SrNo"))
            Catch ex As Exception
                Continue While
            End Try
            Dim _dict As New Dictionary(Of String, Object) From {
                {"FirstName", f(dr("CName"))},
                {"LastName", f(dr("CsName"))},
                {"PhNo", f(dr("PhNo"))},
                {"Address", f(dr("Address"))},
                {"Region", f(dr("Region"))},
                {"Description", f(dr("dscrp"))},
                {"Gender", f(dr("Gender"))},
                {"Profession", f(dr("Prof"))},
                {"IsMarried", If(f(dr("Mry")) = "True", True, False)},
                {"img", f(dr("img"))},
                {"review", f(dr("Review"))}
            }

            Task.Run(Sub()
                         Dim id As Integer = _id
                         Dim doc As DocumentReference = coll.Document(id)
                         doc.SetAsync(_dict)
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