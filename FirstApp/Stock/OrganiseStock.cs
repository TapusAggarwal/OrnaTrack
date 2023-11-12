using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FirstApp
{

    public partial class OrganiseStock
    {

        private int _width = -1;
        private int _height = -1;

        public OrganiseStock()
        {
            InitializeComponent();
        }

        private void OrganiseStock_Load(object sender, EventArgs e)
        {

        }

        private void MakePlace()
        {
            FlowLayoutPanel1.Controls.Clear();
            int.TryParse(TrayWidthTB.Text, out _width);
            int.TryParse(TrayHeightTB.Text, out _height);

            for (int i = 0, loopTo = _width * _height - 1; i <= loopTo; i++)
            {
                var _cntrl = new ItemsUserControl();
                FlowLayoutPanel1.Controls.Add(_cntrl);
            }

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            MakePlace();
        }

        private void TrayHeightTB_TextChanged(object sender, EventArgs e)
        {
            MakePlace();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbDataReader dr = (System.Data.OleDb.OleDbDataReader)ProjectModule.DataReader("Select * From Stock_Data");

            var _list = new List<double>();
            int _count = 0;
            while (dr.Read())
            {
                _count += 1;
                string _str = dr["Item_Data"].ToString();
                int _id = Conversions.ToInteger(dr["ID"]);
                var jsonObject = JsonConvert.DeserializeObject<JObject>(_str);

                try
                {
                    double _weight = jsonObject["12"].ToObject<double>();
                    _list.Add(_weight);
                }
                catch (Exception ex)
                {
                }

            }



            double sum = _list.Sum();
            string g = "";

        }
    }
}