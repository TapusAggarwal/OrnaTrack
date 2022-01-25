﻿Imports FontAwesome.Sharp
Imports Newtonsoft
Imports Newtonsoft.Json.Linq

Public Class Item

    Public Property Name As String = ""

    Public Property ItemID As Integer = -1

    Public Sub New()

    End Sub

    Public Sub New(id As Integer)
        Dim dr As OleDb.OleDbDataReader = DataReader($"Select * From Item_Data Where ID={id}")
        Dim propertiesJson As String = ""

        While dr.Read
            ItemID = dr("ID")
            Name = dr("ItemName")
            propertiesJson = dr("ItemProperties")
        End While

        For Each i In propertiesJson.Split(";")
            MyProperties.Add(New Item_Property(_json:=i))
        Next

    End Sub

    Class Item_Property
        Property IsCurrency As Boolean = False
        Property IsOptional As Boolean = False
        Property IsConstant As Boolean = False
        Property Name As String
        Property DataType As String = ""
        Property DefaultValue As String

        'Property IsCurrency As Boolean
        '    Get
        '        Return _IsCurrency
        '    End Get
        '    Set(value As Boolean)
        '        If value = True AndAlso Not (Type = DataType.Integer_Type) Then
        '            MessageBox.Show("Only Integers Are Allowed To Be Declared As Currency.", "Illegal Selection")
        '            Exit Property
        '        End If
        '        _IsCurrency = value
        '    End Set
        'End Property
        'Property IsOptional As Boolean
        '    Get
        '        Return _IsOptional
        '    End Get
        '    Set(value As Boolean)
        '        _IsOptional = value
        '    End Set
        'End Property
        'Property IsConstant As Boolean
        '    Get
        '        Return _IsConstant
        '    End Get
        '    Set(value As Boolean)
        '        _IsConstant = value
        '    End Set
        'End Property

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
                {"default_value", DefaultValue}
            }

            If IsCurrency Then objectDict.Add("is_currency", "True")
            If IsOptional Then objectDict.Add("is_optional", "True")
            If IsConstant Then objectDict.Add("is_constant", "True")

            Return Json.JsonConvert.SerializeObject(objectDict)
        End Function

        Sub Initialize(jsonString As String)
            Dim _json As JObject = JObject.Parse(jsonString)

            With _json
                If .SelectToken("feature_name").ToString.Length >= 1 Then Name = .SelectToken("feature_name").ToString
                If .SelectToken("feature_type").ToString.Length >= 1 Then DataType = .SelectToken("feature_type").ToString
                If .SelectToken("default_value").ToString.Length >= 1 Then DefaultValue = .SelectToken("default_value").ToString
                If _json.ContainsKey("is_currency") Then IsCurrency = True
                If _json.ContainsKey("is_optional") Then IsOptional = True
                If _json.ContainsKey("is_constant") Then IsConstant = True
            End With
        End Sub

    End Class

    Property MyProperties As New List(Of Item_Property)

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

End Class