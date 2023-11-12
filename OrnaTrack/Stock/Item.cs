using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json.Linq;

namespace FirstApp
{

    public class Item
    {
        private Item _ParentCategory;
        public string Name { get; set; } = "";
        public Item ParentCategory
        {
            get
            {
                return _ParentCategory;
            }
            set
            {
                _ParentCategory = value;
                Attributes.AddRange(_ParentCategory.Attributes);
            }
        }

        public int ItemID { get; set; } = -1;
        public List<Item_Attribute> Attributes { get; set; } = new List<Item_Attribute>();

        public Item(int id)
        {
            if (id == -1)
                return;
            using (System.Data.OleDb.OleDbDataReader dr = (System.Data.OleDb.OleDbDataReader)ProjectModule.DataReader($"Select * From Item_Data Where ID={id}"))
            {
                string attributesList = "";

                while (dr.Read())
                {
                    ItemID = Conversions.ToInteger(dr["ID"]);
                    Name = Conversions.ToString(dr["ItemName"]);
                    attributesList = Conversions.ToString(dr["Attr_List"]);
                    ParentCategory = new Item(Conversions.ToInteger(Conversion.Int(dr["Parent_Ctgr"])));
                }

                foreach (var i in attributesList.Split(','))
                {
                    if (string.IsNullOrEmpty(i))
                        continue;
                    i = Conversions.ToString(Conversion.Int(i));
                    if (Conversions.ToDouble(i) < 0d)
                    {
                        Attributes.RemoveAll(f => f.ID == Conversions.ToDouble(i));
                    }
                    else
                    {
                        Attributes.Add(new Item_Attribute(_id: Conversions.ToInteger(i)));
                    }
                }
            }
        }

        public bool Save()
        {

            bool res = true;

            foreach (var _attr in Attributes)
            {
                if (!_attr.Save())
                {
                    MessageBox.Show($"Attribute: '{_attr.Name}' Was Not Saved. Because An Error Occured. ERROR_CODE:003", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    res = false;
                }
            }

            bool _res1;

            if (ItemID > 0)
            {
                _res1 = ProjectModule.SqlCommand($"UPDATE Item_Data SET ItemName='{Name}',Attr_List='{MyAttributes_LIST()}',Parent_Ctgr={_ParentCategory.ItemID} WHERE ID={ItemID}");
            }
            else
            {
                _res1 = ProjectModule.SqlCommand($"INSERT INTO Item_Data (ItemName,Attr_List,Parent_Ctgr) VALUES ('{Name}','{MyAttributes_LIST()}',{_ParentCategory.ItemID})");

                try
                {
                    using (System.Data.OleDb.OleDbDataReader dr = (System.Data.OleDb.OleDbDataReader)ProjectModule.DataReader("Select max(ID) From Item_Data"))
                    {
                        while (dr.Read())
                        {
                            int _temp = Conversions.ToInteger(dr[0]);
                            ItemID = _temp;
                        }
                    }
                }
                catch (Exception ex)
                {
                    _res1 = false;
                }

            }

            if (_res1 == false)
            {
                MessageBox.Show("Item Was Not Saved. Because An Error Occured. ERROR_CODE:002", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return _res1 & res;

        }

        public class Item_Attribute
        {
            public int ID { get; set; } = -1;
            public string Name { get; set; }
            public string DataType { get; set; } = "";
            public string Attr_Ctg { get; set; }
            public string DefaultValue { get; set; }
            public bool IsCurrency { get; set; } = false;
            public bool IsOptional { get; set; } = false;
            public bool IsConstant { get; set; } = false;
            public bool IsFormula { get; set; } = false;
            public string Abbreviation { get; set; }
            private readonly bool _Is_Referenced_In_Formula = false;
            public bool Is_Referenced_In_Formula
            {
                get
                {
                    return _Is_Referenced_In_Formula;
                }
            }

            public IconChar Icon
            {
                get
                {
                    if (string.IsNullOrEmpty(DataType))
                    {
                        throw new Exception("Attribute Type Not Defined. Can't Get IconChar.");
                        return default;
                    }

                    switch (DataType ?? "")
                    {
                        case Item.DataType.Integer_Type:
                            {
                                return IconChar.Subscript;
                            }
                        case Item.DataType.String_Type:
                            {
                                return IconChar.Font;
                            }
                        case Item.DataType.Boolean_Type:
                            {
                                return IconChar.CheckSquare;
                            }
                        case Item.DataType.List_Type:
                            {
                                return IconChar.ListUl;
                            }

                        default:
                            {
                                throw new Exception("Attribute Type Not Included In System. Can't Get IconChar.");
                                return default;
                            }
                    }
                }
            }

            public Item_Attribute()
            {
            }

            public Item_Attribute(int _id)
            {
                using (System.Data.OleDb.OleDbDataReader dr = (System.Data.OleDb.OleDbDataReader)ProjectModule.DataReader($"Select Attribute From Item_Attributes WHERE ID={_id}"))
                {
                    while (dr.Read())
                    {
                        if (dr[0] is DBNull)
                            break;
                        Initialize(Conversions.ToString(dr[0]));
                        ID = _id;
                    }
                }
            }

            public object AttributeAsJson()
            {
                var objectDict = new Dictionary<string, string>() { { "attr_name", Name }, { "attr_type", DataType }, { "default_value", DefaultValue }, { "attr_ctg", Attr_Ctg } };

                if (IsCurrency)
                    objectDict.Add("is_currency", "True");
                if (IsOptional)
                    objectDict.Add("is_optional", "True");
                if (IsConstant)
                    objectDict.Add("is_constant", "True");
                if (IsFormula)
                    objectDict.Add("is_formula", "True");

                return Newtonsoft.Json.JsonConvert.SerializeObject(objectDict);
            }

            public void Initialize(string jsonString)
            {
                var _json = JObject.Parse(jsonString);

                Name = _json.SelectToken("attr_name").ToString();
                DataType = _json.SelectToken("attr_type").ToString();
                DefaultValue = _json.SelectToken("default_value").ToString();
                Attr_Ctg = _json.SelectToken("attr_ctg").ToString();
                if (_json.ContainsKey("is_currency"))
                    IsCurrency = true;
                if (_json.ContainsKey("is_optional"))
                    IsOptional = true;
                if (_json.ContainsKey("is_constant"))
                    IsConstant = true;
                if (_json.ContainsKey("is_formula"))
                    IsFormula = true;
            }

            public List<Item_Attribute> DependsUpon(Item _item)
            {
                if (!IsFormula)
                    return new List<Item_Attribute>();

                var x = Regex.Matches(DefaultValue, @"(?<=\{).+?(?=\})");

                var DependentAttributes = new List<Item_Attribute>();

                foreach (var i in x)
                    DependentAttributes.Add(_item.Attributes.Where(f => (f.Name ?? "") == (i.ToString() ?? "")).ElementAtOrDefault(0));

                return DependentAttributes;

            }

            public bool Save()
            {
                if (ID > 0)
                {
                    return ProjectModule.SqlCommand($"UPDATE Item_Attributes SET Attribute='{AttributeAsJson()}' WHERE ID={ID}");
                }
                else
                {
                    bool res = ProjectModule.SqlCommand($"INSERT INTO Item_Attributes (Attribute) VALUES ('{AttributeAsJson()}')");

                    try
                    {
                        using (System.Data.OleDb.OleDbDataReader dr = (System.Data.OleDb.OleDbDataReader)ProjectModule.DataReader("Select max(ID) From Item_Attributes"))
                        {
                            while (dr.Read())
                            {
                                int _temp = Conversions.ToInteger(dr[0]);
                                ID = _temp;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }

                    return res;

                }
            }

        }

        public string MyAttributes_LIST()
        {

            var _list = new List<int>();

            _list.AddRange(Attributes.Select(f => f.ID));

            foreach (var i in _ParentCategory.Attributes)
            {
                if (_list.Remove(i.ID) == false)
                    _list.Add(-i.ID);
            }

            string _str = string.Join(",", _list);
            return _str;
        }

        public struct DataType
        {
            public const string String_Type = "Str";
            public const string Boolean_Type = "T/F";
            public const string List_Type = "List";
            public const string Integer_Type = "Int";
        }

        public struct AttributeCategory
        {
            public const string Purchase_Type = "Purchase Attr.";
            public const string Product_Type = "Product Attr.";
            public const string Sale_Type = "Sale Attribute";
        }

    }
}