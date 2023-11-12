using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FirstApp
{
    public partial class AllStock
    {

        private Dictionary<int, Item> _list = new Dictionary<int, Item>();
        private int _currentIndex = 0;

        public AllStock()
        {
            InitializeComponent();
        }

        private void ShowItems_Load(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbDataReader dr = (System.Data.OleDb.OleDbDataReader)ProjectModule.DataReader("Select * From Stock_Data");

            while (dr.Read())
            {
                if (dr["ID"] is DBNull)
                    break;
                _list.Add(Conversions.ToInteger(Conversion.Int(dr["ID"])), new Item(Conversions.ToInteger(Conversion.Int(dr["Ctg_ID"]))));
            }
            dr.Close();

            _list = _list.Reverse().ToDictionary(f => f.Key, f => f.Value);

            LoadData();
        }

        public void LoadData()
        {
            FlowLayoutPanel1.Controls.Clear();

            for (int i = _currentIndex, loopTo = _currentIndex + 10; i <= loopTo; i++)
            {

                var _kVal = _list.ElementAt(i);

                var x = new ItemsUserControl()
                {
                    StockID = _kVal.Key,
                    CurrentItem = _kVal.Value
                };

                x.DetailsButton.Click += () =>
                    {
                        var Fm = new StockEntry()
                        {
                            CurrentItem = x.CurrentItem,
                            StockID = x.StockID
                        };
                        Fm.ShowDialog();
                        LoadData();
                    };


                FlowLayoutPanel1.Controls.Add(x);
            }

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            _currentIndex += 10;

            if (_currentIndex >= _list.Count)
            {
                _currentIndex = _list.Count;
            }
            LoadData();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            _currentIndex -= 10;

            if (_currentIndex <= 0)
            {
                _currentIndex = 0;
            }
            LoadData();
        }
    }
}