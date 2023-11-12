using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FirstApp
{
    public partial class Report
    {
        public Report()
        {
            InitializeComponent();
            Dgv = _Dgv;
            _Dgv.Name = "Dgv";
        }

        private void LoadRelativeData(string KittyType, DataGridView Dgv_temp)
        {
            Dgv_temp.Rows.Clear();
            Dgv_temp.Columns[0].HeaderText = $"KittyType: {KittyType}";

            System.Data.OleDb.OleDbDataReader dr = (System.Data.OleDb.OleDbDataReader)ProjectModule.DataReader($"Select KittyUID from Kitty_Data where KittyType={KittyType}");

            var dictRelative = new Dictionary<int, List<int>>() { { 0, new List<int>() { 0, 0, 0 } } };

            while (dr.Read())
            {
                var _kitty = new Kitty(UID: Conversions.ToInteger(dr["KittyUID"]), InitializeKitty: true, completely: true);
                if (_kitty.IsAvailed || _kitty.IsMatured() || _kitty.GivenAmount() == 0)
                    continue;

                if (dictRelative.ContainsKey(_kitty.GetInstalmentsPending()))
                {
                    {
                        var withBlock = dictRelative[_kitty.GetInstalmentsPending()];
                        dictRelative[_kitty.GetInstalmentsPending()] = new List<int>() { withBlock[0] + 1, withBlock[1] + _kitty.GivenAmount(), withBlock[2] + _kitty.KittyInterest };
                    }
                }
                else
                {
                    dictRelative.Add(_kitty.GetInstalmentsPending(), new List<int>() { 1, _kitty.GivenAmount(), _kitty.KittyInterest });
                }
            }

            var sorted = from pair in dictRelative
                         orderby pair.Key
                         select pair;

            foreach (KeyValuePair<int, List<int>> i in sorted)
            {
                Dgv_temp.Rows.Add();
                if (Dgv_temp.Rows.Count == 1)
                {
                    Dgv_temp.Rows[Dgv_temp.Rows.Count - 1].DefaultCellStyle.BackColor = SystemColors.Highlight;
                    Dgv_temp.Rows[Dgv_temp.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.White;
                    Dgv_temp.Rows[Dgv_temp.Rows.Count - 1].Cells[0].Value = "Kitties UpToDate";
                    Dgv_temp.Rows[Dgv_temp.Rows.Count - 1].Cells[1].Value = i.Value[0];
                }
                else
                {
                    Dgv_temp.Rows[Dgv_temp.Rows.Count - 1].Cells[0].Value = Conversion.Str(i.Key) + " Instalment Left";
                    Dgv_temp.Rows[Dgv_temp.Rows.Count - 1].Cells[1].Value = i.Value[0];
                }
                Dgv_temp.Rows[Dgv_temp.Rows.Count - 1].Cells[2].Value = i.Value[1].ToCurrency(true);
                if (i.Value[1] == 0)
                {
                    Dgv_temp.Rows[Dgv_temp.Rows.Count - 1].Cells[3].Value = Conversion.Int(0).ToCurrency(true);
                }
                else
                {
                    Dgv_temp.Rows[Dgv_temp.Rows.Count - 1].Cells[3].Value = i.Value[2].ToCurrency(true);
                }
            }

            int TotalKitties = 0;
            int TotalAmount = 0;
            int TotalInterest = 0;
            foreach (var i in dictRelative.Values)
            {
                TotalKitties += i[0];
                TotalAmount += i[1];
                TotalInterest += i[2];
            }

            Dgv_temp.Rows.Add();
            {
                var withBlock1 = Dgv_temp.Rows[Dgv_temp.Rows.GetLastRow(DataGridViewElementStates.Visible)];
                withBlock1.DefaultCellStyle.BackColor = Color.DarkGoldenrod;
                withBlock1.DefaultCellStyle.ForeColor = Color.Black;
                withBlock1.Cells[0].Value = "Total:";
                withBlock1.Cells[1].Value = TotalKitties;
                withBlock1.Cells[2].Value = TotalAmount.ToCurrency(AddSpace: true);
                withBlock1.Cells[3].Value = TotalInterest.ToCurrency(AddSpace: true);
            }

            Dgv_temp.Rows.Add();
            {
                var withBlock2 = Dgv_temp.Rows[Dgv_temp.Rows.GetLastRow(DataGridViewElementStates.Visible)];
                withBlock2.DefaultCellStyle.BackColor = Color.Goldenrod;
                withBlock2.DefaultCellStyle.ForeColor = Color.Black;
                withBlock2.Cells[0].Value = "UpToDate Kitties:";
                withBlock2.Cells[1].Value = 0;
                withBlock2.Cells[2].Value = 0;
                withBlock2.Cells[3].Value = 0;

                if (dictRelative.ContainsKey(0))
                {
                    withBlock2.Cells[1].Value += dictRelative[0][0];
                    withBlock2.Cells[2].Value += dictRelative[0][1];
                    withBlock2.Cells[3].Value += dictRelative[0][2];
                }
                if (dictRelative.ContainsKey(1))
                {
                    withBlock2.Cells[1].Value += dictRelative[1][0];
                    withBlock2.Cells[2].Value += dictRelative[1][1];
                    withBlock2.Cells[3].Value += dictRelative[1][2];
                }

                withBlock2.Cells[2].Value = withBlock2.Cells[2].Value.ToString().ToCurrency(AddSpace: true);
                withBlock2.Cells[3].Value = withBlock2.Cells[2].Value.ToString().ToCurrency(AddSpace: true);
            }

            Dgv_temp.Rows.Add();
            {
                var withBlock3 = Dgv_temp.Rows[Dgv_temp.Rows.GetLastRow(DataGridViewElementStates.Visible)];
                withBlock3.DefaultCellStyle.BackColor = Color.Goldenrod;
                withBlock3.DefaultCellStyle.ForeColor = Color.Black;
                withBlock3.Cells[0].Value = "Late Kitties:";
                withBlock3.Cells[1].Value = TotalKitties;
                withBlock3.Cells[2].Value = TotalAmount;
                withBlock3.Cells[3].Value = TotalInterest;

                if (dictRelative.ContainsKey(0))
                {
                    withBlock3.Cells[1].Value -= dictRelative[0][0];
                    withBlock3.Cells[2].Value -= dictRelative[0][1];
                    withBlock3.Cells[3].Value -= dictRelative[0][2];
                }
                if (dictRelative.ContainsKey(1))
                {
                    withBlock3.Cells[1].Value -= dictRelative[1][0];
                    withBlock3.Cells[2].Value -= dictRelative[1][1];
                    withBlock3.Cells[3].Value -= dictRelative[1][2];
                }

                withBlock3.Cells[2].Value = withBlock3.Cells[2].Value.ToString().ToCurrency(AddSpace: true);
                withBlock3.Cells[3].Value = withBlock3.Cells[2].Value.ToString().ToCurrency(AddSpace: true);
            }

            Dgv_temp.Size = (Size)new Point(Dgv_temp.Size.Width, 31 * (Dgv_temp.Rows.Count + 1));

            Dgv_temp.Visible = true;

        }


        private void LoadAbsoluteData(string KittyType, DataGridView Dgv_temp)
        {

            Dgv_temp.Rows.Clear();
            Dgv_temp.Columns[0].HeaderText = $"KittyType: {KittyType}";

            System.Data.OleDb.OleDbDataReader dr = (System.Data.OleDb.OleDbDataReader)ProjectModule.DataReader($"Select KittyUID from Kitty_Data where KittyType={KittyType}");

            var dictAbsolute = new Dictionary<int, List<int>>() { { 0, new List<int>() { 0, 0, 0 } } };


            while (dr.Read())
            {
                var _kitty = new Kitty(UID: Conversions.ToInteger(dr["KittyUID"]), InitializeKitty: true, completely: true);
                if (_kitty.IsAvailed || _kitty.GivenAmount() == 0)
                    continue;
                if (dictAbsolute.ContainsKey(_kitty.GetInstalments_LeftForMaturity()))
                {
                    {
                        var withBlock = dictAbsolute[_kitty.GetInstalments_LeftForMaturity()];
                        dictAbsolute[_kitty.GetInstalments_LeftForMaturity()] = new List<int>() { withBlock[0] + 1, withBlock[1] + _kitty.GivenAmount(), withBlock[2] + _kitty.KittyInterest };
                    }
                }
                else
                {
                    dictAbsolute.Add(_kitty.GetInstalments_LeftForMaturity(), new List<int>() { 1, _kitty.GivenAmount(), _kitty.KittyInterest });
                }
            }

            var sorted = from pair in dictAbsolute
                         orderby pair.Key
                         select pair;

            foreach (KeyValuePair<int, List<int>> i in sorted)
            {
                Dgv_temp.Rows.Add();
                if (Dgv_temp.Rows.Count == 1)
                {
                    Dgv_temp.Rows[Dgv_temp.Rows.Count - 1].DefaultCellStyle.BackColor = SystemColors.Highlight;
                    Dgv_temp.Rows[Dgv_temp.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.White;
                    Dgv_temp.Rows[Dgv_temp.Rows.Count - 1].Cells[0].Value = "Kitties Matured";
                    Dgv_temp.Rows[Dgv_temp.Rows.Count - 1].Cells[1].Value = i.Value[0];
                }
                else
                {
                    Dgv_temp.Rows[Dgv_temp.Rows.Count - 1].Cells[0].Value = Conversion.Str(i.Key) + " Instalment Left";
                    Dgv_temp.Rows[Dgv_temp.Rows.Count - 1].Cells[1].Value = i.Value[0];
                }
                Dgv_temp.Rows[Dgv_temp.Rows.Count - 1].Cells[2].Value = i.Value[1].ToCurrency(true);
                if (i.Value[1] == 0)
                {
                    Dgv_temp.Rows[Dgv_temp.Rows.Count - 1].Cells[3].Value = Conversion.Int(0).ToCurrency(true);
                }
                else
                {
                    Dgv_temp.Rows[Dgv_temp.Rows.Count - 1].Cells[3].Value = i.Value[2].ToCurrency(true);
                }
            }

            Dgv_temp.Rows.Add();
            {
                var withBlock1 = Dgv_temp.Rows[Dgv_temp.Rows.GetLastRow(DataGridViewElementStates.Visible)];
                withBlock1.DefaultCellStyle.BackColor = Color.Gold;
                withBlock1.DefaultCellStyle.ForeColor = Color.Black;
                withBlock1.Cells[0].Value = "Total:";
                int TotalKitties = 0;
                int TotalAmount = 0;
                int TotalInterest = 0;
                foreach (var i in dictAbsolute.Values)
                {
                    TotalKitties += i[0];
                    TotalAmount += i[1];
                    TotalInterest += i[2];
                }
                withBlock1.Cells[1].Value = TotalKitties;
                withBlock1.Cells[2].Value = TotalAmount.ToCurrency(AddSpace: true);
                withBlock1.Cells[3].Value = TotalInterest.ToCurrency(AddSpace: true);
            }

            Dgv_temp.Size = (Size)new Point(Dgv_temp.Size.Width, 31 * (Dgv_temp.Rows.Count + 1));

            Dgv_temp.Visible = true;
        }


        private DataGridView ReturnDgv(string DgvName)
        {
            var Dgv1 = new DataGridView();

            var DataGridViewCellStyle7 = new DataGridViewCellStyle();
            var DataGridViewCellStyle8 = new DataGridViewCellStyle();
            var DataGridViewCellStyle11 = new DataGridViewCellStyle();
            var DataGridViewCellStyle12 = new DataGridViewCellStyle();
            var DataGridViewCellStyle9 = new DataGridViewCellStyle();
            var DataGridViewCellStyle10 = new DataGridViewCellStyle();

            var Column2 = new DataGridViewTextBoxColumn();
            var Column3 = new DataGridViewTextBoxColumn();
            var Column1 = new DataGridViewTextBoxColumn();
            var Column4 = new DataGridViewTextBoxColumn();


            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleRight;
            Column2.DefaultCellStyle = DataGridViewCellStyle9;
            Column2.HeaderText = "Instalments";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column2.Width = 210;

            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column3.HeaderText = "Kitties";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Resizable = DataGridViewTriState.True;
            Column3.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column3.ToolTipText = "Click To Open A New Form For The Coustmer";
            Column3.Width = 79;

            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleRight;
            Column1.DefaultCellStyle = DataGridViewCellStyle10;
            Column1.HeaderText = "Amount";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 150;

            Column4.HeaderText = "Interest";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 150;

            Dgv1.AllowUserToAddRows = false;
            Dgv1.AllowUserToDeleteRows = false;
            Dgv1.AllowUserToResizeColumns = false;
            Dgv1.AllowUserToResizeRows = false;
            DataGridViewCellStyle7.BackColor = Color.FromArgb(224, 224, 224);
            Dgv1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7;
            Dgv1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            Dgv1.BackgroundColor = Color.FromArgb(32, 32, 50);
            Dgv1.BorderStyle = BorderStyle.None;
            Dgv1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle8.BackColor = SystemColors.Control;
            DataGridViewCellStyle8.Font = new Font("Century Schoolbook", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            Dgv1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8;
            Dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv1.Columns.AddRange(new DataGridViewColumn[] { Column2, Column3, Column1, Column4 });
            DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle11.BackColor = SystemColors.Window;
            DataGridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
            DataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            Dgv1.DefaultCellStyle = DataGridViewCellStyle11;
            Dgv1.EditMode = DataGridViewEditMode.EditProgrammatically;
            Dgv1.Location = new Point(4, 5);
            Dgv1.Margin = new Padding(4, 5, 4, 5);
            Dgv1.MultiSelect = false;
            Dgv1.Name = DgvName;
            Dgv1.ReadOnly = true;
            DataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle12.BackColor = SystemColors.Control;
            DataGridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            Dgv1.RowHeadersDefaultCellStyle = DataGridViewCellStyle12;
            Dgv1.RowHeadersVisible = false;
            Dgv1.RowHeadersWidth = 62;
            Dgv1.Size = new Size(592, 568);
            Dgv1.TabIndex = 170;
            return Dgv1;
        }

        private async void AbsoluteButton_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    ref var withBlock = ref this;
                    withBlock.Cursor = Cursors.AppStarting;
                    withBlock.Refresh();
                }
                FlowLayoutPanel1.Controls.Clear();
                System.Data.OleDb.OleDbDataReader dr = (System.Data.OleDb.OleDbDataReader)ProjectModule.DataReader("Select DISTINCT KittyType From Kitty_Data");
                while (dr.Read())
                {
                    var Dgv1 = ReturnDgv("Hello");
                    LoadAbsoluteData(Conversions.ToString(dr[0]), Dgv1);
                    FlowLayoutPanel1.Controls.Add(Dgv1);
                    await Task.Delay(2500);
                }
                {
                    ref var withBlock1 = ref this;
                    withBlock1.Cursor = Cursors.Default;
                    withBlock1.Refresh();
                }
            }
            catch (Exception ex)
            {
            }
        }

        private async void RelativeButton_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    ref var withBlock = ref this;
                    withBlock.Cursor = Cursors.AppStarting;
                    withBlock.Refresh();
                }
                FlowLayoutPanel1.Controls.Clear();
                System.Data.OleDb.OleDbDataReader dr = (System.Data.OleDb.OleDbDataReader)ProjectModule.DataReader("Select DISTINCT KittyType From Kitty_Data");
                while (dr.Read())
                {
                    var Dgv1 = ReturnDgv("Hello");
                    LoadRelativeData(Conversions.ToString(dr[0]), Dgv1);
                    FlowLayoutPanel1.Controls.Add(Dgv1);
                    await Task.Delay(2500);
                }
                {
                    ref var withBlock1 = ref this;
                    withBlock1.Cursor = Cursors.Default;
                    withBlock1.Refresh();
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}