using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace FirstApp
{
    public partial class AllTransactionsForm
    {

        public enum DgvEnum
        {
            CheckBoxColumn = 0,
            SrNoColumn = 1,
            DateColumn = 2,
            ModeColumn = 3,
            AmountColumn = 4,
            AccountColumn = 5,
            RefNoColumn = 6,
            UsedAmtCoulumn = 7,
            DetailsButton = 8
        }

        private Dictionary<int, Kitty> Dict { get; set; } = new Dictionary<int, Kitty>();
        public string ButtonText { get; set; } = "Details";

        public AllTransactionsForm()
        {
            InitializeComponent();
            Dgv = _Dgv;
            _Dgv.Name = "Dgv";
        }

        public List<Transaction> GetAllTransactions()
        {
            System.Data.OleDb.OleDbDataReader dr = (System.Data.OleDb.OleDbDataReader)ProjectModule.DataReader("Select * From Transaction_Data");

            var _listTrns = new List<Transaction>();

            while (dr.Read())
            {
                var _trns = new Transaction(Conversions.ToInteger(dr["TrnsID"]));
                _listTrns.Add(_trns);
                foreach (var i in _trns.KittyIds.Keys)
                {
                    if (Dict.ContainsKey(i))
                        continue;
                    Dict.Add(i, new Kitty(i, true, true));
                }
            }

            return _listTrns;
        }

        private void FindCoustmerButton_Click(object sender, EventArgs e)
        {
            Dgv.Rows.Clear();

            var _listTrns = GetAllTransactions();

            if (_listTrns.Count == 0)
                return;

            var sorted = (from pair in _listTrns
                          orderby pair.TrnsDate
                          select pair).Reverse();
            _prev = sorted.FirstOrDefault().TrnsDate;

            foreach (var i in sorted)
            {
                if (i.TrnsDate < FromDatePicker.Value || i.TrnsDate > TillDatePicker.Value)
                    continue;
                Dgv.Rows.Add();
                PopulateRow(Dgv.Rows[Dgv.Rows.Count - 1], i);
            }

        }

        private Color _color = Color.LightGray;
        private DateTime _prev = default;

        public event RowModifiedEventHandler RowModified;

        public delegate void RowModifiedEventHandler(DataGridViewRow _row);

        private void PopulateRow(DataGridViewRow _row, Transaction i)
        {
            string _kittyNo = string.Join(",", i.KittyIds.Keys.Select(f => Dict[f].KittyNo));
            if (_prev != i.TrnsDate)
                _color = _color == Color.White ? Color.LightGray : Color.White;
            _row.DefaultCellStyle.BackColor = _color;
            _row.Cells[(int)DgvEnum.DateColumn].Value = i.TrnsDate;
            _row.Cells[(int)DgvEnum.ModeColumn].Value = i.Mode;
            _row.Cells[(int)DgvEnum.AmountColumn].Value = i.Amount.ToCurrency();
            _row.Cells[(int)DgvEnum.AccountColumn].Value = i.Account;
            _row.Cells[(int)DgvEnum.RefNoColumn].Value = i.RefNo;
            _row.Cells[(int)DgvEnum.UsedAmtCoulumn].Value = _kittyNo;
            _row.Cells[(int)DgvEnum.DetailsButton].Value = ButtonText;
            _row.Cells[(int)DgvEnum.DetailsButton].Tag = i.TrnsID;
            _prev = i.TrnsDate;
        }

        public event Cell_ClickedEventHandler Cell_Clicked;

        public delegate void Cell_ClickedEventHandler(int _id);

        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.ColumnIndex == (int)DgvEnum.DetailsButton) || e.RowIndex == -1)
                return;
            int _id = Conversions.ToInteger(Dgv.Rows[e.RowIndex].Cells[(int)DgvEnum.DetailsButton].Tag);

            if (Tag is not null)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(_id, ((dynamic)Tag).TrnsID, false)))
                {
                    MessageBox.Show("You Are Already Using This Transaction With This Kitty.", "Transactions Already In Use", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
            }

            Cell_Clicked?.Invoke(_id);
            if (ButtonText == "Select")
                return;

            var Fm = new TransactionDetailsForm();
            var _trns = new Transaction(_id);
            Fm.DatePicker.Value = _trns.TrnsDate;
            Fm.DatePicker.Enabled = false;

            Fm.CurrentTransaction = _trns;

            Fm.SaveButton_Clicked += () => PopulateRow(Dgv.Rows[e.RowIndex], new Transaction(_id));
            Fm.RemoveDetails += () => Dgv.Rows.RemoveAt(e.RowIndex);

            Fm.ShowDialog();
        }

        public event AddTransactionButton_ClickedEventHandler AddTransactionButton_Clicked;

        public delegate void AddTransactionButton_ClickedEventHandler();

        private void AddMsgBT_Click(object sender, EventArgs e)
        {
            AddTransactionButton_Clicked?.Invoke();
        }
    }
}