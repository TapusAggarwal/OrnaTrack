using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FirstApp
{

    public partial class SuggestionsPage
    {
        public SuggestionsPage()
        {
            InitializeComponent();
            dgv = _dgv;
            _dgv.Name = "dgv";
        }
        private void SelectBT_Click(object sender, EventArgs e)
        {
            string clipboardData = Clipboard.GetText();

            string[] rows = clipboardData.Split(Conversions.ToChar(Constants.vbCrLf));

            var dt = new DataTable();
            for (int i = 0, loopTo = rows[0].Split(Conversions.ToChar(Constants.vbTab)).Length - 1; i <= loopTo; i++)
            {
                dt.Columns.Add($"Column {i}");
                var _cntr = new SuggestionControl();
                _cntr.Label1.Text = $"Column {i}:";

                _cntr.SelectBT.Click += () =>
                    {
                        var fm = new SelectAttributeForm();
                        fm.ShowDialog();
                        _cntr.CurrentAttribute = fm.SelectedAttribute;
                    };

                FlowLayoutPanel1.Controls.Add(_cntr);
            }

            for (int i = 1, loopTo1 = rows.Length - 1; i <= loopTo1; i++)
            {
                if (string.IsNullOrEmpty(rows[i].Trim()))
                    continue;

                var row = dt.NewRow();
                string[] rowCols = rows[i].Split(Conversions.ToChar(Constants.vbTab));
                for (int _idx = 0, loopTo2 = rowCols.Length - 1; _idx <= loopTo2; _idx++)
                    row[$"Column {_idx}"] = rowCols[_idx];

                dt.Rows.Add(row);
            }

            dgv.DataSource = dt;

            int totalWidth = 0;
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
                totalWidth += col.Width;
            }

            Size = (Size)new Point(Size.Width + totalWidth, Size.Height);



        }

        private void SuggestionsPage_Load(object sender, EventArgs e)
        {

        }

        private void SaveBT_Click(object sender, EventArgs e)
        {

            var _mapping = new Dictionary<string, int>();

            foreach (DataGridViewColumn column in dgv.Columns)
                _mapping.Add(column.HeaderText, -1);

            int _count = 0;

            foreach (var i in FlowLayoutPanel1.Controls)
            {
                SuggestionControl _cntrl = (SuggestionControl)i;
                if (_cntrl.CurrentAttribute is null)
                {
                    MessageBox.Show("Not All Columns Are Mapped.");
                    return;
                }
                _mapping[_mapping.ElementAt(_count).Key] = _cntrl.CurrentAttribute.ID;
                _count += 1;
            }

            var schemaTable = ProjectModule.myconnection.GetOleDbSchemaTable(OleDbSchemaGuid.Columns, new object[] { null, null, "Item_Suggestion", null });

            foreach (var i in _mapping.Values)
            {
                bool _found = false;
                foreach (var _row in schemaTable.Rows)
                {
                    if ((_row.ToString() ?? "") == (i.ToString() ?? ""))
                    {
                        _found = true;
                        break;
                    }
                }
                if (_found)
                    continue;
                ProjectModule.SqlCommand($"ALTER TABLE Item_Suggestion ADD COLUMN {i} TEXT;");
            }

            for (int i = 0, loopTo = dgv.Rows.Count - 1; i <= loopTo; i++)
            {

                string _values = "";
                for (int j = 0, loopTo1 = dgv.Rows[i].Cells.Count - 1; j <= loopTo1; j++)
                {
                    var _item = dgv.Rows[i].Cells[j].Value;
                    _values = Conversions.ToString(_values + Operators.AddObject(Operators.AddObject("'", _item), "',"));
                }
                _values = _values.TrimEnd(',');


                ProjectModule.SqlCommand($"INSERT INTO Item_Suggestion ({string.Join(",", _mapping.Values)}) VALUES({_values})");
            }

            Close();

        }

    }
}