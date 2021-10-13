Imports System.Data.OleDb

Public Class Customer

    Protected _customerID As Integer = -1

    Sub New(CustID As Integer)
        _customerID = CustID
    End Sub

    Public Function GetCustomerID() As Object
        Return _customerID
    End Function

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
        If IDs Is Nothing Then Return Nothing

        Dim T_List As New List(Of Task(Of KittyModeControl))
        Dim KittyIds As New List(Of Kitty)

        If isKittyID Then
            For Each Id As Integer In IDs
                KittyIds.Add(New Kitty(Id))
            Next
        Else
            For Each Id As Integer In IDs
                Dim i As New Customer(Id)
                KittyIds.AddRange(i.OwnedKitties)
                If KittyIds.Count > MaxLimit AndAlso MaxLimit <> -1 Then
                    Return Nothing
                End If
            Next
        End If

        For Each KittyId As Kitty In KittyIds
            T_List.Add(Task.Run(Function()
                                    KittyId.Initialize(InitializeCompletely:=False)
                                    Dim CoustmerPanel As New KittyModeControl
                                    With CoustmerPanel
                                        .CoustName = KittyId.Owner.FullName
                                        .PhNo = KittyId.Owner.PhNo(",")
                                        .SetImage = ""
                                        .LastInstalmentDate = ""
                                        .KittyType = KittyId.KittyType()
                                        Try
                                            .KittyNo = KittyId.KittyNo
                                        Catch ex As Exception
                                            .KittyType = ""
                                        End Try
                                        .CoustID = KittyId.Owner.GetCustomerID()
                                        .KittyID = KittyId.KittyUID
                                    End With
                                    Return CoustmerPanel
                                End Function))
        Next

        Return T_List

    End Function
#End Region

    Public Function OwnedKitties() As List(Of Kitty)
        Dim Result As New List(Of Kitty)
        Try
            Dim dr_KittyUID As OleDbDataReader = DataReader("Select KittyUID From Kitty_Data Where CoustID=" & GetCustomerID())
            While dr_KittyUID.Read
                Result.Add(New Kitty(dr_KittyUID("KittyUID")))
            End While
            dr_KittyUID.Close()
            Return Result
        Catch ex As Exception
            MessageBox.Show($"Error [Customer/OwnedCustomer()]: {ex.Message}", "Error In Customer Class", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public Function DeleteCustomer() As Boolean
        Try
            Dim customerExists As Boolean = True

            Try
                Dim dr_checkExists As OleDbDataReader = DataReader($"Select CName From Customers_Data Where SrNo={_customerID}")
                While dr_checkExists.Read
                    customerExists = dr_checkExists("CName").ToString.Length > 0
                End While
            Catch ex As Exception
            End Try

            If customerExists Then

                Try : SqlCommand("DELETE FROM Coustmers_Data WHERE SrNo=" & GetCustomerID() & "") : Catch : End Try
                Try : SqlCommand("DELETE FROM Kitty_Data WHERE CoustID='" & GetCustomerID() & "'") : Catch : End Try
                Try : SqlCommand("DELETE FROM Udhari_Data WHERE CoustID='" & GetCustomerID() & "'") : Catch : End Try

                Try
                    Dim dr_checkExists As OleDbDataReader = DataReader($"Select CName From Customers_Data Where SrNo={_customerID}")
                    While dr_checkExists.Read
                        customerExists = dr_checkExists("CName").ToString.Length > 0
                    End While
                Catch ex As Exception
                End Try

                If Not customerExists Then
                    Return True
                Else
                    Return False
                End If

            Else
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show($"Error [Customer/DeleteCustomer]: {ex.Message}", "Error In Customer Class", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

#Region "Customer Name"
    Public Function FirstName() As String
        Try
            Dim dr_firstName As OleDbDataReader = DataReader("Select CName From Coustmers_Data Where SrNo=" & _customerID)
            Dim temp_name As String = Nothing
            While dr_firstName.Read
                Try : temp_name = dr_firstName("CName") : Catch ex As Exception : End Try
            End While
            dr_firstName.Close()
            Return temp_name.Trim
        Catch ex As Exception
            MessageBox.Show($"Error [Customer/FirstName]: {ex.Message}", "Error In Customer Class", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public WriteOnly Property UpdatedFirstName As String
        Set(value As String)
            SqlCommand("UPDATE Coustmers_Data set CName='" & value.Trim & "' Where SrNo=" & _customerID)
        End Set
    End Property

    Public Function LastName() As String
        Try
            Dim dr_sirName As OleDbDataReader = DataReader("Select CsName From Coustmers_Data Where SrNo=" & _customerID)
            Dim temp_name As String = Nothing
            While dr_sirName.Read
                Try : temp_name = dr_sirName("CsName") : Catch ex As Exception : End Try
            End While
            dr_sirName.Close()
            Return temp_name.Trim
        Catch ex As Exception
            MessageBox.Show($"Error [Customer/LastName]: {ex.Message}", "Error In Customer Class", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public WriteOnly Property UpdatedLastName As String
        Set(value As String)
            SqlCommand("UPDATE Coustmers_Data set CsName='" & value.Trim & "' Where SrNo=" & _customerID)
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
            SqlCommand("UPDATE Coustmers_Data set PhNo='" & value & "' Where SrNo=" & _customerID)
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
            Dim dr_phno As OleDbDataReader = DataReader("Select PhNo From Coustmers_Data Where SrNo=" & _customerID)
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

    'Friend Shared Function SharedPhNo() As List(Of Customer)

    'End Function
#End Region

#Region "CustomerProfession"
    Public Function Profession() As String
        Try
            Dim dr_profession As OleDbDataReader = DataReader("Select Prof From Coustmers_Data Where SrNo=" & _customerID)
            Dim temp_profession As String = Nothing
            While dr_profession.Read
                Try
                    temp_profession = dr_profession("Prof")
                Catch ex As Exception
                End Try
            End While
            dr_profession.Close()
            Return temp_profession
        Catch ex As Exception
            MessageBox.Show($"Error [Customer/Profession()]: {ex.Message}", "Error In Customer Class", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public WriteOnly Property UpdatedProfession As String
        Set(value As String)
            SqlCommand("UPDATE Coustmers_Data set Prof='" & value & "' Where SrNo=" & _customerID)
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
            Dim dr_region As OleDbDataReader = DataReader("Select Addrs From Coustmers_Data Where SrNo=" & _customerID)
            Dim temp_region As String = Nothing
            While dr_region.Read
                Try
                    temp_region = dr_region("Addrs")
                Catch ex As Exception
                End Try
            End While
            dr_region.Close()
            Return temp_region
        Catch ex As Exception
            MessageBox.Show($"Error [Customer/Region]: {ex.Message}", "Error In Customer Class", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public WriteOnly Property UpdatedRegion As String
        Set(value As String)
            SqlCommand("UPDATE Coustmers_Data set Addrs='" & value & "' Where SrNo=" & _customerID)
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
            Dim dr_address As OleDbDataReader = DataReader("Select Address From Coustmers_Data Where SrNo=" & _customerID)
            Dim temp_address As String = Nothing
            While dr_address.Read
                Try
                    temp_address = dr_address("Address")
                Catch ex As Exception
                End Try
            End While
            dr_address.Close()
            Return temp_address
        Catch ex As Exception
            MessageBox.Show($"Error [Customer/Address]: {ex.Message}", "Error In Customer Class", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public WriteOnly Property UpdatedAddress As String
        Set(value As String)
            SqlCommand("UPDATE Coustmers_Data set Address='" & value & "' Where SrNo=" & _customerID)
        End Set
    End Property
#End Region

#Region "CustomerDescription"
    Public Function Description() As String
        Try
            Dim dr_description As OleDbDataReader = DataReader("Select dscrp From Coustmers_Data Where SrNo=" & _customerID)
            Dim temp_description As String = Nothing
            While dr_description.Read
                Try
                    temp_description = dr_description("dscrp")
                Catch ex As Exception
                End Try
            End While
            dr_description.Close()
            Return temp_description
        Catch ex As Exception
            MessageBox.Show($"Error [Customer/Description]: {ex.Message}", "Error In Customer Class", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public WriteOnly Property UpdatedDescription As String
        Set(value As String)
            SqlCommand("UPDATE Coustmers_Data set dscrp='" & value & "' Where SrNo=" & _customerID)
        End Set
    End Property
#End Region

#Region "Married"
    Public Function IsMarried() As Boolean
        Try
            Dim dr_isMarried As OleDbDataReader = DataReader("Select Mry From Coustmers_Data Where SrNo=" & _customerID)
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
            SqlCommand("UPDATE Coustmers_Data set Mry='" & value & "' Where SrNo=" & _customerID)
        End Set
    End Property
#End Region

#Region "Gender"
    Public Function Gender() As String
        Try
            Dim dr_gender As OleDbDataReader = DataReader("Select Gender From Coustmers_Data Where SrNo=" & _customerID)
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
            SqlCommand("UPDATE Coustmers_Data set Gender='" & value & "' Where SrNo=" & _customerID)
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

End Class