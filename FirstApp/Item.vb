Imports FontAwesome.Sharp
Imports Newtonsoft
Imports Newtonsoft.Json.Linq

Public Class Item

    Property MyFeatures As New List(Of Feature)

    Class Feature
        Private _IsCurrency As Boolean = False
        Private _IsOptional As Boolean = False
        Private _IsConstant As Boolean = False
        Property Name As String
        Property Type As String = ""
        Property DefaultValue As Object
        Property IsCurrency As Boolean
            Get
                Return _IsCurrency
            End Get
            Set(value As Boolean)
                If value = True AndAlso Not (Type = DataType.Integer_Type) Then
                    MessageBox.Show("Only Integers Are Allowed To Be Declared As Currency.", "Illegal Selection")
                    Exit Property
                End If
                _IsCurrency = value
            End Set
        End Property
        Property IsOptional As Boolean
            Get
                Return _IsOptional
            End Get
            Set(value As Boolean)
                _IsOptional = value
            End Set
        End Property
        Property IsConstant As Boolean
            Get
                Return _IsConstant
            End Get
            Set(value As Boolean)
                _IsConstant = value
            End Set
        End Property
        ReadOnly Property Icon As IconChar
            Get
                If Type = "" Then
                    Throw New Exception("Attribute Type Not Defined. Can't Get IconChar.")
                    Return Nothing
                End If

                Select Case _Type
                    Case DataType.Integer_Type
                        Return IconChar.Superscript
                    Case DataType.String_Type
                        Return IconChar.Font
                    Case DataType.Boolean_Type
                        Return IconChar.CheckSquare
                    Case DataType.List_Type
                        Return IconChar.ListUl
                    Case Else
                        Throw New Exception("Attribute Type Not Included In System. Can't Get IconChar.")
                        Return Nothing
                End Select
            End Get
        End Property

        Sub New()
        End Sub

        Sub New(_name As String, _type As String, _defaultValue As Object, Optional _isCurrency As Boolean = False, Optional _isOptional As Boolean = False, Optional _isConstant As Boolean = False)
            Name = _name
            Type = _type

            IsCurrency = _isCurrency
            IsOptional = _isOptional
            IsConstant = _isConstant
        End Sub
        Function FeaturesAsJson()
            Dim objectDict As New Dictionary(Of String, String) From {
                {"feature_name", Name},
                {"feature_type", Type},
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
                If .SelectToken("feature_type").ToString.Length >= 1 Then Type = .SelectToken("feature_type").ToString
                If .SelectToken("default_value").ToString.Length >= 1 Then DefaultValue = .SelectToken("default_value").ToString
                If _json.ContainsKey("is_currency") Then IsCurrency = True
                If _json.ContainsKey("is_optional") Then IsOptional = True
                If _json.ContainsKey("is_constant") Then IsConstant = True
            End With
        End Sub

    End Class

    Public Structure DataType
        Const String_Type = "Str"
        Const Boolean_Type = "T/F"
        Const List_Type = "List"
        Const Integer_Type = "Int"
    End Structure

    Public Shared DataType_List As New List(Of String) From {
        DataType.String_Type,
        DataType.Boolean_Type,
        DataType.List_Type,
        DataType.Integer_Type
    }

End Class