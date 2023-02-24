Imports System.Text.RegularExpressions
Imports FontAwesome.Sharp
Imports Newtonsoft
Imports Newtonsoft.Json.Linq

Public Class Item
    Private _ParentCategory As Item
    Public Property Name As String = ""
    Public Property ParentCategory As Item
        Get
            Return _ParentCategory
        End Get
        Set
            _ParentCategory = Value
            Attributes.AddRange(_ParentCategory.Attributes)
        End Set
    End Property

    Public Property ItemID As Integer = -1
    Property Attributes As New List(Of Item_Attribute)

    Public Sub New(id As Integer)
        If id = -1 Then Exit Sub
        Using dr As OleDb.OleDbDataReader = DataReader($"Select * From Item_Data Where ID={id}")
            Dim attributesList As String = ""

            While dr.Read
                ItemID = dr("ID")
                Name = dr("ItemName")
                attributesList = dr("Attr_List")
                ParentCategory = New Item(Int(dr("Parent_Ctgr")))
            End While

            For Each i In attributesList.Split(",")
                i = Int(i)
                If i < 0 Then
                    Attributes.RemoveAll(Function(f) f.ID = i)
                Else
                    Attributes.Add(New Item_Attribute(_id:=i))
                End If
            Next
        End Using
    End Sub

    Function Save() As Boolean

        Dim res As Boolean = True

        For Each _attr In Attributes
            If Not _attr.Save() Then
                MessageBox.Show($"Attribute: '{_attr.Name}' Was Not Saved. Because An Error Occured. ERROR_CODE:003", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                res = False
            End If
        Next

        Dim _res1 As Boolean

        If ItemID > 0 Then
            _res1 = SqlCommand($"UPDATE Item_Data SET ItemName='{Name}',Attr_List='{MyAttributes_LIST()}',Parent_Ctgr={_ParentCategory.ItemID} WHERE ID={ItemID}")
        Else
            _res1 = SqlCommand($"INSERT INTO Item_Data (ItemName,Attr_List,Parent_Ctgr) VALUES ('{Name}','{MyAttributes_LIST()}',{_ParentCategory.ItemID})")

            Try
                Using dr As OleDb.OleDbDataReader = DataReader("Select max(ID) From Item_Data")
                    While dr.Read
                        Dim _temp As Integer = dr(0)
                        ItemID = _temp
                    End While
                End Using
            Catch ex As Exception
                _res1 = False
            End Try

        End If

        If _res1 = False Then
            MessageBox.Show("Item Was Not Saved. Because An Error Occured. ERROR_CODE:002", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If

        Return (_res1 And res)

    End Function

    Class Item_Attribute
        Property ID As Integer = -1
        Property Name As String
        Property DataType As String = ""
        Property Attr_Ctg As String
        Property DefaultValue As String
        Property IsCurrency As Boolean = False
        Property IsOptional As Boolean = False
        Property IsConstant As Boolean = False
        Property IsFormula As Boolean = False
        Property Abbreviation As String
        Private ReadOnly _Is_Referenced_In_Formula As Boolean = False
        ReadOnly Property Is_Referenced_In_Formula As Boolean
            Get
                Return _Is_Referenced_In_Formula
            End Get
        End Property

        ReadOnly Property Icon As IconChar
            Get
                If DataType = "" Then
                    Throw New Exception("Attribute Type Not Defined. Can't Get IconChar.")
                    Return Nothing
                End If

                Select Case _DataType
                    Case Item.DataType.Integer_Type
                        Return IconChar.Subscript
                    Case Item.DataType.String_Type
                        Return IconChar.Font
                    Case Item.DataType.Boolean_Type
                        Return IconChar.CheckSquare
                    Case Item.DataType.List_Type
                        Return IconChar.ListUl
                    Case Else
                        Throw New Exception("Attribute Type Not Included In System. Can't Get IconChar.")
                        Return Nothing
                End Select
            End Get
        End Property

        Sub New()
        End Sub

        Sub New(_id As Integer)
            Using dr As OleDb.OleDbDataReader = DataReader($"Select Attribute From Item_Attributes WHERE ID={_id}")
                While dr.Read
                    If IsDBNull(dr(0)) Then Exit While
                    Initialize(dr(0))
                    ID = _id
                End While
            End Using
        End Sub

        Function AttributeAsJson()
            Dim objectDict As New Dictionary(Of String, String) From {
                {"attr_name", Name},
                {"attr_type", DataType},
                {"default_value", DefaultValue},
                {"attr_ctg", Attr_Ctg}
            }

            If IsCurrency Then objectDict.Add("is_currency", "True")
            If IsOptional Then objectDict.Add("is_optional", "True")
            If IsConstant Then objectDict.Add("is_constant", "True")
            If IsFormula Then objectDict.Add("is_formula", "True")

            Return Json.JsonConvert.SerializeObject(objectDict)
        End Function

        Sub Initialize(jsonString As String)
            Dim _json As JObject = JObject.Parse(jsonString)

            With _json
                Name = .SelectToken("attr_name").ToString
                DataType = .SelectToken("attr_type").ToString
                DefaultValue = .SelectToken("default_value").ToString
                Attr_Ctg = .SelectToken("attr_ctg").ToString
                If _json.ContainsKey("is_currency") Then IsCurrency = True
                If _json.ContainsKey("is_optional") Then IsOptional = True
                If _json.ContainsKey("is_constant") Then IsConstant = True
                If _json.ContainsKey("is_formula") Then IsFormula = True
            End With
        End Sub

        Function DependsUpon(_item As Item) As List(Of Item_Attribute)
            If Not IsFormula Then Return New List(Of Item_Attribute)

            Dim x As MatchCollection = Regex.Matches(DefaultValue, "(?<=\{).+?(?=\})")

            Dim DependentAttributes As New List(Of Item_Attribute)

            For Each i In x
                DependentAttributes.Add(_item.Attributes.Where(Function(f) f.Name = i.ToString)(0))
            Next

            Return DependentAttributes

        End Function

        Function Save() As Boolean
            If ID > 0 Then
                Return SqlCommand($"UPDATE Item_Attributes SET Attribute='{AttributeAsJson()}' WHERE ID={ID}")
            Else
                Dim res = SqlCommand($"INSERT INTO Item_Attributes (Attribute) VALUES ('{AttributeAsJson()}')")

                Try
                    Using dr As OleDb.OleDbDataReader = DataReader("Select max(ID) From Item_Attributes")
                        While dr.Read
                            Dim _temp As Integer = dr(0)
                            ID = _temp
                        End While
                    End Using
                Catch ex As Exception
                    Return False
                End Try

                Return res

            End If
        End Function

    End Class

    Public Function MyAttributes_LIST() As String

        Dim _list As New List(Of Integer)

        _list.AddRange(Attributes.Select(Function(f) f.ID))

        For Each i In _ParentCategory.Attributes
            If _list.Remove(i.ID) = False Then _list.Add(-i.ID)
        Next

        Dim _str As String = String.Join(",", _list)
        Return _str
    End Function

    Public Structure DataType
        Const String_Type = "Str"
        Const Boolean_Type = "T/F"
        Const List_Type = "List"
        Const Integer_Type = "Int"
    End Structure

    Public Structure AttributeCategory
        Const Purchase_Type = "Purchase Attr."
        Const Product_Type = "Product Attr."
        Const Sale_Type = "Sale Attribute"
    End Structure

End Class