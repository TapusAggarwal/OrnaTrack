Imports System.IO
Imports System.Net
Imports Newtonsoft
Imports WebSocket4Net

Public Class StockEntry

    Public Property CurrentItem As Item

    Private Sub StockEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If CurrentItem.ItemID < 0 Then Exit Sub

        For Each _property In CurrentItem.MyProperties
            Dim x As New PropertyControl With {
                .CurrentProperty = _property,
                .Name = _property.Name
            }


            'AddHandler x.ButtonCLick,
            '    Sub()

            '        Dim formula As String = _property.DefaultValue

            '        For Each i As PropertyControl In FlowLayoutPanel1.Controls
            '            If Not formula.Contains($"{{{i.CurrentProperty.Name}}}") Then Continue For
            '            formula = formula.Replace($"{{{i.CurrentProperty.Name}}}", i.EnteredData)
            '        Next

            '        Dim equation As String = formula
            '        Dim result As Integer = New DataTable().Compute(equation, Nothing)
            '        x.DefaultValueTB.Text = result

            '        _property.DependsUpon(CurrentItem)

            '    End Sub
            If _property.Attr_Ctg = Item.AttributeCategory.Purchase_Type Then
                PurchaseFP.AddControl(x)
                PurchaseFP.AutoReSize()
            ElseIf _property.Attr_Ctg = Item.AttributeCategory.Product_Type Then
                ProductFP.AddControl(x)
                ProductFP.AutoReSize()
            Else
                SaleFP.AddControl(x)
                SaleFP.AutoReSize()
            End If
        Next

        'For Each _property In CurrentItem.MyProperties
        '    If _property.IsFormula Then

        '        Dim DependentProperties As List(Of Item.Item_Property) = _property.DependsUpon(CurrentItem)

        '        For Each i In DependentProperties
        '            Dim _control As PropertyControl = FlowLayoutPanel1.Controls.Find(i.Name, True)(0)
        '            AddHandler _control.DefaultValueTB.TextChanged,
        '                Sub()
        '                    Dim formula As String = _property.DefaultValue

        '                    For Each _prp In DependentProperties
        '                        Dim _cntrl As PropertyControl = FlowLayoutPanel1.Controls.Find(_prp.Name, True)(0)
        '                        formula = formula.Replace($"{{{_prp.Name}}}", _cntrl.EnteredData)
        '                    Next

        '                    Try
        '                        Dim equation As String = formula
        '                        Dim result As String = CDbl(New DataTable().Compute(equation, Nothing))

        '                        Dim _ruleControl As PropertyControl = FlowLayoutPanel1.Controls.Find(_property.Name, True)(0)

        '                        _ruleControl.DefaultValueTB.Text = result
        '                    Catch ex As Exception
        '                        MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '                    End Try
        '                End Sub
        '        Next

        'End If
        'Next

    End Sub

    Private Sub SaveBT_Click(sender As Object, e As EventArgs) Handles SaveBT.Click

        'Dim Entry As New Dictionary(Of String, String)

        'For Each cntrl As PropertyControl In FlowLayoutPanel1.Controls
        '    If cntrl.EnteredData Is Nothing Then Exit Sub
        '    Entry.Add(cntrl.CurrentProperty.Name, cntrl.EnteredData)
        'Next

        'If Entry.Count > 0 Then
        '    Dim entryString As String = Json.JsonConvert.SerializeObject(Entry)
        '    SqlCommand($"Insert Into Stock_Data (ItemID,ItemEntry) VALUES ('{CurrentItem.ItemID}','{entryString}')")
        'End If

    End Sub

    Public Sub UpdateImage(e As MessageReceivedEventArgs)
        Dim req As WebRequest = WebRequest.Create($"http://{My.Settings.connection_url}?purpose=latest_images")
        req.Method = "POST"

        ' Get the response and extract the base64 encoded string
        Dim response As WebResponse = req.GetResponse()
        Dim streamReader As New StreamReader(response.GetResponseStream())
        Dim base64String As String = streamReader.ReadToEnd()

        ' Convert the base64 encoded string to a byte array
        Dim imageBytes As Byte() = Convert.FromBase64String(base64String)

        ' Convert the byte array to an image
        Using memoryStream As New MemoryStream(imageBytes)
            Dim image As Image = Image.FromStream(memoryStream)
            ImageBox.Invoke(Sub()
                                ImageBox.Image = New Bitmap(image)
                            End Sub)
            ' Do something with the image, such as display it
        End Using

    End Sub

    'Private Sub ImageBox_Click(sender As Object, e As EventArgs) Handles ImageBox.Click
    '    UpdateImage()
    'End Sub

    Private Sub ExistingPhNosButton_Click(sender As Object, e As EventArgs) Handles ListenPhNoBT.Click
        If ListenPhNoBT.IconChar = FontAwesome.Sharp.IconChar.EyeSlash Then
            Dim fm As Frame = Nothing
            For Each _form As Form In Application.OpenForms
                If TypeOf _form IsNot Frame Then Continue For
                fm = _form
                Exit For
            Next

            fm?.ConnectionLabel_Click()
            ListenPhNoBT.IconChar = FontAwesome.Sharp.IconChar.Eye
        Else
            StartListeningForMessages(My.Settings.ListenerPhNo)
        End If
    End Sub

    Private Sub ChangeListenerPhNoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeListenerPhNoToolStripMenuItem.Click
        Dim newPhno As String = InputBox($"Enter New PhNo With Country Code Which Will Be Used As A Listener. Add Comma To Add Multiple Numbers).{vbNewLine}Current PhNo: {My.Settings.ListenerPhNo}", "Listener PhNo")
        If newPhno.Length < 12 Then Exit Sub
        My.Settings.ListenerPhNo = newPhno
        StartListeningForMessages(newPhno)
    End Sub

    Private Sub StartListeningForMessages(phno As String)

        Dim fm As Frame = Nothing
        For Each _form As Form In Application.OpenForms
            If TypeOf _form IsNot Frame Then Continue For
            fm = _form
            Exit For
        Next

        fm?.ConnectionLabel_Click()


        AddHandler fm.State_Changed,
            Sub(newState, oldState)

                For Each i In phno.Split(",")
                    Dim req As WebRequest = WebRequest.Create($"http://{My.Settings.connection_url}?purpose=listen_phno&phno={i}&listen='true'")
                    req.Method = "POST"
                    req.Timeout = 3000
                    Using request As WebResponse = req.GetResponse
                        Using reader As New StreamReader(request.GetResponseStream)
                            Dim response As String = reader.ReadToEnd

                            If response = "added" Then
                                MessageBox.Show($"PhNo:{i} Added As A New Listener", "Success")
                                AddHandler fm.NewMessage_Socket, AddressOf UpdateImage
                                My.Settings.ListenerPhNo = i
                                ListenPhNoBT.IconChar = FontAwesome.Sharp.IconChar.EyeSlash
                            Else
                                MessageBox.Show($"Can't Add PhNo: {i} Either This No. Is Not Registered With Whatsapp Or An Internal Error Occured.")
                            End If
                        End Using
                    End Using
                Next
            End Sub


    End Sub

End Class