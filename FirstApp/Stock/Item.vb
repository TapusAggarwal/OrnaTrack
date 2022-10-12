Imports System.Text.RegularExpressions
Imports FontAwesome.Sharp
Imports Newtonsoft
Imports Newtonsoft.Json.Linq

Public Class Item

    Public Property Name As String = ""

    Public Property ItemID As Integer = -1
    Property MyProperties As New List(Of Item_Property)

    Public Sub New(id As Integer)
        If id = -1 Then Exit Sub
        Dim dr As OleDb.OleDbDataReader = DataReader($"Select * From Item_Data Where ID={id}")
        Dim propertiesJson As String = ""

        While dr.Read
            ItemID = dr("ID")
            Name = dr("ItemName")
            propertiesJson = dr("ItemAttr")
        End While

        For Each i In propertiesJson.Split(";")
            MyProperties.Add(New Item_Property(_json:=i))
        Next
    End Sub

    Class Item_Property
        Property IsCurrency As Boolean = False
        Property IsOptional As Boolean = False
        Property IsConstant As Boolean = False
        Property IsFormula As Boolean = False
        Property Name As String
        Property DataType As String = ""
        Property DefaultValue As String
        Property Attr_Ctg As String

        ReadOnly Property Icon As IconChar
            Get
                If DataType = "" Then
                    Throw New Exception("Attribute Type Not Defined. Can't Get IconChar.")
                    Return Nothing
                End If

                Select Case _DataType
                    Case Item.DataType.Integer_Type
                        Return IconChar.Superscript
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

        Sub New(_json As String)
            Initialize(_json)
        End Sub

        Function PropertyAsJson()
            Dim objectDict As New Dictionary(Of String, String) From {
                {"feature_name", Name},
                {"feature_type", DataType},
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
                Name = .SelectToken("feature_name").ToString
                DataType = .SelectToken("feature_type").ToString
                DefaultValue = .SelectToken("default_value").ToString
                Attr_Ctg = .SelectToken("attr_ctg").ToString
                If _json.ContainsKey("is_currency") Then IsCurrency = True
                If _json.ContainsKey("is_optional") Then IsOptional = True
                If _json.ContainsKey("is_constant") Then IsConstant = True
                If _json.ContainsKey("is_formula") Then IsFormula = True
            End With
        End Sub

        Function DependsUpon(_item As Item) As List(Of Item_Property)
            If Not IsFormula Then Return New List(Of Item_Property)

            Dim x As MatchCollection = Regex.Matches(DefaultValue, "(?<=\{).+?(?=\})")

            Dim DependentProperties As New List(Of Item_Property)

            For Each i In x
                DependentProperties.Add(_item.MyProperties.Where(Function(f) f.Name = i.ToString)(0))
            Next

            Return DependentProperties

        End Function

    End Class

    Public Function MyProperties_JSON() As String
        Dim _json As String = String.Join(";", MyProperties.Select(Function(f) f.PropertyAsJson).ToList)
        Return _json
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