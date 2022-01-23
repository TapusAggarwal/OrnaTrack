Imports System.Data.OleDb

Public Class Customer

    Sub New(CustID As Integer)
        CustomerID = CustID
    End Sub

    Public Overrides Function Equals(obj As Object) As Boolean
        If obj Is Nothing OrElse Not Me.GetType.Equals(obj.GetType) Then
            Return False
        Else
            Return DirectCast(obj, Customer).CustomerID = CustomerID
        End If
    End Function

    Public ReadOnly Property CustomerID = -1

#Region "Shared Functions"
    Friend Shared Function SearchByKittyNo(KittyNo As String, Optional MaxLimit As Integer = -1) As Integer()
        Dim SearchResult As New List(Of Integer)

        If MaxLimit <> -1 Then
            Dim dr_count As OleDbDataReader = DataReader("Select Count(*) From Kitty_Data Where KittyNo Like '%" & KittyNo & "%'")
            While dr_count.Read
                If Int(dr_count(0)) > MaxLimit Then Return Nothing
            End While
        End If

        Dim dr_search As OleDbDataReader = DataReader("Select KittyUID From Kitty_Data Where KittyNo Like'%" & KittyNo & "%'")
        While dr_search.Read
            SearchResult.Add(Int(dr_search("KittyUID")))
        End While
        dr_search.Close()

        Return SearchResult.ToArray

    End Function

    Friend Shared Function SearchByPhNo(PhNo As String) As Integer()

        Dim SearchResult As New List(Of Integer)

        Dim dr_search As OleDbDataReader = DataReader("Select SrNo From Coustmers_Data Where PhNo Like '%" & PhNo & "%'")
        While dr_search.Read
            SearchResult.Add(Int(dr_search("SrNo")))
        End While
        dr_search.Close()

        Return SearchResult.ToArray

    End Function

    Friend Shared Function SearchByName(Name As String) As Integer()

        Dim SearchResult As New List(Of Integer)

        If Name.Split(" ").Count > 1 Then

            Dim dr As OleDbDataReader = DataReader("Select SrNo From Coustmers_Data Where (CName Like '%" & Name.Split(" ")(0) & "%') AND (CsName Like '%" & Name.Split(" ")(1) & "%')")
            While dr.Read
                SearchResult.Add(Int(dr("SrNo")))
            End While
            dr.Close()

        Else

            Dim dr As OleDbDataReader = DataReader("Select SrNo From Coustmers_Data Where CName Like '%" & Name & "%'")
            While dr.Read
                SearchResult.Add(Int(dr("SrNo")))
            End While
            dr.Close()

            dr = DataReader("Select SrNo From Coustmers_Data Where CsName Like '%" & Name & "%'")
            While dr.Read
                SearchResult.Add(Int(dr("SrNo")))
            End While
            dr.Close()

        End If

        Return SearchResult.ToArray

    End Function

    Friend Shared Function ListOF_KittyModeControl(IDs As Integer(), Optional MaxLimit As Integer = -1, Optional isKittyID As Boolean = False) As List(Of Task(Of KittyModeControl))
        If IDs Is Nothing OrElse IDs.Count = 0 Then Return Nothing
        If MaxLimit <> -1 AndAlso IDs.Count > MaxLimit Then Return Nothing

        Dim T_List As New List(Of Task(Of KittyModeControl))
        Dim KittyIds As New List(Of Kitty)

        If isKittyID Then
            For Each Id As Integer In IDs
                KittyIds.Add(New Kitty(Id, True, True))
            Next
        Else
            For Each Id As Integer In IDs
                Dim i As New Customer(Id)
                KittyIds.AddRange(i.OwnedKitties(True, True))
            Next
        End If

        For Each KittyId As Kitty In KittyIds
            T_List.Add(Task.Run(Function()
                                    Dim CoustmerPanel As New KittyModeControl
                                    With CoustmerPanel
                                        .CoustName = KittyId.Owner.FullName
                                        .PhNo = KittyId.Owner.PhNo(",")
                                        .SetImage = ""
                                        If KittyId.IsAvailed Then
                                            .InstalmentsPending = -2
                                        ElseIf KittyId.IsMatured Then
                                            .InstalmentsPending = -1
                                        Else
                                            .InstalmentsPending = KittyId.GetInstalmentsPending
                                            .InstalmentsLeft = KittyId.GetInstalments_LeftForMaturity
                                        End If
                                        .KittyType = KittyId.KittyType()
                                        Try
                                            .KittyNo = KittyId.KittyNo
                                        Catch ex As Exception
                                            .KittyType = ""
                                        End Try
                                        .CoustID = KittyId.Owner.CustomerID
                                        .KittyID = KittyId.KittyUID
                                    End With
                                    Return CoustmerPanel
                                End Function))
        Next

        Return T_List

    End Function

    Friend Shared Function ListOF_ActiveKittyControl(IDs As Integer(), Optional MaxLimit As Integer = -1) As List(Of Task(Of ActiveKittyControl))
        If IDs Is Nothing Then Return Nothing
        If MaxLimit <> -1 AndAlso IDs.Count > MaxLimit Then Return Nothing

        Dim T_List As New List(Of Task(Of ActiveKittyControl))

        For Each Id As Integer In IDs
            Dim _customer = New Customer(Id)
            T_List.Add(Task.Run(Function()
                                    Dim CoustmerPanel As New ActiveKittyControl
                                    With CoustmerPanel
                                        .CoustName = _customer.FullName
                                        .PhNo = _customer.PhNo(",")
                                        .SetImage = ""
                                        .CoustID = _customer.CustomerID
                                        .ActiveKitty = _customer.OwnedKitties.Count
                                    End With
                                    Return CoustmerPanel
                                End Function))
        Next

        Return T_List

    End Function

#End Region

    Public Function OwnedKitties(Optional initialise As Boolean = False, Optional completely As Boolean = False) As List(Of Kitty)
        Dim Result As New List(Of Kitty)
        Try
            Dim dr_KittyUID As OleDbDataReader = DataReader($"Select KittyUID From Kitty_Data Where CoustID={CustomerID} ORDER BY KittyUID ASC")
            While dr_KittyUID.Read
                Result.Add(New Kitty(dr_KittyUID("KittyUID"), initialise, completely))
            End While
            dr_KittyUID.Close()
            Return Result
        Catch ex As Exception
            MessageBox.Show($"Error [Customer/OwnedCustomer()]: {ex.Message}", "Error In Customer Class", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public Sub DeleteCustomer()
        Try
            If MessageBox.Show("Are You Sure That You Permanently Want To Delete This Customet?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Exit Sub
            Try : SqlCommand($"DELETE FROM Coustmers_Data WHERE SrNo={CustomerID}") : Catch : End Try
            Try : SqlCommand($"DELETE FROM Kitty_Data WHERE CoustID={CustomerID}") : Catch : End Try
            'Try : SqlCommand($"DELETE FROM Udhari_Data WHERE CoustID={CustomerID}") : Catch : End Try
        Catch ex As Exception
            MessageBox.Show($"Error [Customer/DeleteCustomer]: {ex.Message}", "Error In Customer Class", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#Region "Customer Name"
    Public Function FirstName() As String
        Try
            Dim dr_firstName As OleDbDataReader = DataReader("Select CName From Coustmers_Data Where SrNo=" & CustomerID)
            Dim temp_name As String = ""
            While dr_firstName.Read
                Try : temp_name = dr_firstName("CName") : Catch ex As Exception : End Try
            End While
            dr_firstName.Close()
            Try
                temp_name = temp_name.Replace(apostropheReplacer, "'")
                Return temp_name.Trim
            Catch ex As Exception
                Return Nothing
            End Try
        Catch ex As Exception
            MessageBox.Show($"Error [Customer/FirstName]: {ex.Message}", "Error In Customer Class", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public WriteOnly Property UpdatedFirstName As String
        Set(value As String)
            If String.IsNullOrEmpty(value) Then Exit Property
            value = value.Replace("'", apostropheReplacer)
            SqlCommand("UPDATE Coustmers_Data set CName='" & value.Trim & "' Where SrNo=" & CustomerID)
        End Set
    End Property

    Public Function LastName() As String
        Try
            Dim dr_sirName As OleDbDataReader = DataReader("Select CsName From Coustmers_Data Where SrNo=" & CustomerID)
            Dim temp_name As String = ""
            While dr_sirName.Read
                Try
                    temp_name = dr_sirName("CsName")
                Catch ex As Exception
                    Return Nothing
                End Try
            End While
            dr_sirName.Close()
            Try
                temp_name = temp_name.Replace(apostropheReplacer, "'")
                Return temp_name.Trim
            Catch ex As Exception
                Return Nothing
            End Try
        Catch ex As Exception
            MessageBox.Show($"Error [Customer/LastName]: {ex.Message}", "Error In Customer Class", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public WriteOnly Property UpdatedLastName As String
        Set(value As String)
            If Not String.IsNullOrEmpty(value) Then
                value = value.Replace("'", apostropheReplacer)
            End If
            SqlCommand("UPDATE Coustmers_Data set CsName='" & value.Trim & "' Where SrNo=" & CustomerID)
        End Set
    End Property

    Public Function FullName(Optional seprator As String = " ") As String
        Try
            If LastName.Length > 0 Then
                Return FirstName() + seprator + LastName()
            Else
                Return FirstName()
            End If
        Catch ex As Exception
            MessageBox.Show($"Error [Customer/FullName]: {ex.Message}", "Error In Customer Class", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function
#End Region

#Region "CustomerPhoneNo"
    Public WriteOnly Property UpdatedPhNo As String
        Set(value As String)
            If String.IsNullOrEmpty(value) Then Exit Property
            SqlCommand("UPDATE Coustmers_Data set PhNo='" & value & "' Where SrNo=" & CustomerID)
        End Set
    End Property

    Public Function PhNo(seperator As String) As String
        Try
            Return String.Join(seperator, GetPhNo())
        Catch ex As Exception
            MessageBox.Show($"Error [Customer/GetPhNo]: {ex.Message}", "Error In Customer Class", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public Function GetPhNo() As List(Of String)
        Try
            Dim dr_phno As OleDbDataReader = DataReader("Select PhNo From Coustmers_Data Where SrNo=" & CustomerID)
            Dim temp_phno As New List(Of String)
            While dr_phno.Read
                Try
                    For Each no In dr_phno("PhNo").ToString.Split(",")
                        temp_phno.Add(no.Replace(" ", ""))
                    Next
                Catch ex As Exception
                    temp_phno = Nothing
                End Try
            End While
            dr_phno.Close()
            Return temp_phno
        Catch ex As Exception
            MessageBox.Show($"Error [Customer/GetPhNo]: {ex.Message}", "Error In Customer Class", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public Shared Function SharedPhNo(_phnos As String()) As List(Of Integer)

        Dim _sharedMembers As New List(Of Integer)

        For Each _no In _phnos
            If String.IsNullOrEmpty(_no) Or String.IsNullOrWhiteSpace(_no) Then Continue For
            For Each _NewcustomerID As Integer In SearchByPhNo(_no.Trim)
                _sharedMembers.Add(_NewcustomerID)
            Next
        Next

        Return _sharedMembers.Distinct().ToList()
    End Function
#End Region

#Region "CustomerProfession"
    Public Function Profession() As String
        Try
            If CustomerID = -1 Then Return Nothing
            Dim dr_profession As OleDbDataReader = DataReader("Select Prof From Coustmers_Data Where SrNo=" & CustomerID)
            Dim temp_profession As String = Nothing
            While dr_profession.Read
                Try
                    temp_profession = dr_profession("Prof")
                Catch ex As Exception
                End Try
            End While
            Try
                Return temp_profession.Replace(apostropheReplacer, "'")
            Catch ex As Exception
                Return Nothing
            End Try
        Catch ex As Exception
            MessageBox.Show($"Error [Customer/Profession()]: {ex.Message}", "Error In Customer Class", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public WriteOnly Property UpdatedProfession As String
        Set(value As String)
            If String.IsNullOrEmpty(value) Then Exit Property
            value = value.Replace("'", apostropheReplacer)
            SqlCommand("UPDATE Coustmers_Data set Prof='" & value & "' Where SrNo=" & CustomerID)
        End Set
    End Property

    Friend Shared Function ListOfProfessions() As List(Of String)
        Dim temp_list As New List(Of String)
        Try
            Dim dr_profession As OleDbDataReader =
                    DataReader("select Profession from CBox_Data Where (NOT (Profession = ''))")
            While dr_profession.Read
                temp_list.Add(dr_profession("Profession"))
            End While
            dr_profession.Close()
        Catch ex As Exception
        End Try
        Return temp_list
    End Function

#End Region

#Region "CustomerRegion"
    Public Function Region() As String
        Try
            Dim dr_region As OleDbDataReader = DataReader("Select Region From Coustmers_Data Where SrNo=" & CustomerID)
            Dim temp_region As String = Nothing
            While dr_region.Read
                Try
                    temp_region = dr_region("Region")
                Catch ex As Exception
                End Try
            End While
            dr_region.Close()
            Try
                Return temp_region.Replace(apostropheReplacer, "'")
            Catch ex As Exception
                Return Nothing
            End Try
        Catch ex As Exception
            MessageBox.Show($"Error [Customer/Region]: {ex.Message}", "Error In Customer Class", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public WriteOnly Property UpdatedRegion As String
        Set(value As String)
            If String.IsNullOrEmpty(value) Then Exit Property
            value = value.Replace("'", apostropheReplacer)
            SqlCommand("UPDATE Coustmers_Data set Region='" & value & "' Where SrNo=" & CustomerID)
        End Set
    End Property

    Friend Shared Function ListOfRegions() As List(Of String)
        Dim temp_list As New List(Of String)
        Try
            Dim dr_region As OleDbDataReader =
                    DataReader("select Region from CBox_Data Where (NOT (Region = ''))")
            While dr_region.Read
                temp_list.Add(dr_region("Region"))
            End While
            dr_region.Close()
        Catch ex As Exception
            MessageBox.Show($"Error [Customer/Region]: {ex.Message}", "Error In Customer Class", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return temp_list
    End Function
#End Region

#Region "CustomerAddress"
    Public Function Address() As String
        Try
            Dim dr_address As OleDbDataReader = DataReader("Select Address From Coustmers_Data Where SrNo=" & CustomerID)
            Dim temp_address As String = Nothing
            While dr_address.Read
                Try
                    temp_address = dr_address("Address")
                Catch ex As Exception
                End Try
            End While
            dr_address.Close()
            Try
                Return temp_address.Replace(apostropheReplacer, "'")
            Catch ex As Exception
                Return Nothing
            End Try
        Catch ex As Exception
            MessageBox.Show($"Error [Customer/Address]: {ex.Message}", "Error In Customer Class", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public WriteOnly Property UpdatedAddress As String
        Set(value As String)
            value = value.Replace("'", apostropheReplacer)
            SqlCommand("UPDATE Coustmers_Data set Address='" & value & "' Where SrNo=" & CustomerID)
        End Set
    End Property
#End Region

#Region "CustomerDescription"
    Public Function Description() As String
        Try
            Dim dr_description As OleDbDataReader = DataReader("Select dscrp From Coustmers_Data Where SrNo=" & CustomerID)
            Dim temp_description As String = Nothing
            While dr_description.Read
                Try
                    temp_description = dr_description("dscrp")
                Catch ex As Exception
                End Try
            End While
            dr_description.Close()
            Try
                Return temp_description.Replace(apostropheReplacer, "'")
            Catch ex As Exception
                Return Nothing
            End Try
        Catch ex As Exception
            MessageBox.Show($"Error [Customer/Description]: {ex.Message}", "Error In Customer Class", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public WriteOnly Property UpdatedDescription As String
        Set(value As String)
            value = value.Replace("'", apostropheReplacer)
            SqlCommand("UPDATE Coustmers_Data set dscrp='" & value & "' Where SrNo=" & CustomerID)
        End Set
    End Property
#End Region

#Region "Married"
    Public Function IsMarried() As Boolean
        Try
            Dim dr_isMarried As OleDbDataReader = DataReader("Select Mry From Coustmers_Data Where SrNo=" & CustomerID)
            Dim temp_result As Boolean = False
            While dr_isMarried.Read
                Try : temp_result = If(dr_isMarried("Mry") = "True", temp_result = True) : Catch ex As Exception : End Try
            End While
            dr_isMarried.Close()
            Return temp_result
        Catch ex As Exception
            MessageBox.Show($"Error [Customer/IsMarried]: {ex.Message}", "Error In Customer Class", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public WriteOnly Property UpdatedMarriedStatus As String
        Set(value As String)
            SqlCommand("UPDATE Coustmers_Data set Mry='" & value & "' Where SrNo=" & CustomerID)
        End Set
    End Property
#End Region

#Region "Gender"
    Public Function Gender() As String
        Try
            Dim dr_gender As OleDbDataReader = DataReader("Select Gender From Coustmers_Data Where SrNo=" & CustomerID)
            Dim temp_gender As String = ""
            While dr_gender.Read
                Try : temp_gender = dr_gender("Gender") : Catch ex As Exception : End Try
            End While
            dr_gender.Close()
            Return temp_gender
        Catch ex As Exception
            MessageBox.Show($"Error [Customer/Gender()]: {ex.Message}", "Error In Customer Class", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public WriteOnly Property UpdatedGender As String
        Set(value As String)
            SqlCommand("UPDATE Coustmers_Data set Gender='" & value & "' Where SrNo=" & CustomerID)
        End Set
    End Property
#End Region

End Class

Public Class Utility
    Public Shared Sub LoadComboBoxData(cBox As ComboBox, List As List(Of String))
        Try
            cBox.Items.Clear()
            For Each item In List
                cBox.Items.Add(item)
            Next
            cBox.DropDownStyle = ComboBoxStyle.DropDownList
        Catch ex As Exception
            MessageBox.Show($"Class: [Utility/Error]: {ex.Message}", "Error In Utility Class", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Shared Function MonthDifference(ByVal first As DateTime, ByVal second As DateTime) As Integer
        Dim x = DateDiff(DateInterval.Day, second.Date, first.Date)
        Return x / 31
        Return Math.Abs((first.Month - second.Month) + 12 * (first.Year - second.Year))
    End Function

End Class