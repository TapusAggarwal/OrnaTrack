using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace FirstApp
{
    public partial class KittyView
    {

        protected Customer _currentCustomer;

        // ENUM Dgv-> KittyView
        public enum DgvEnum
        {
            CheckBoxColumn = 0,
            SrNoColumn = 1,
            KittyNoColumn = 2,
            KittyTypeColumn = 3,
            PendingInstalments = 4,
            GivenAmountColumn = 5,
            TotalAmountColumn = 6,
            StatusColumn = 7,
            DetailsButtonColumn = 8,
            MakeEntryColumn = 9,
            KittyIDColumn = 10
        }

        // ENUM MessageDGv-> KittyView
        public enum MessageDgvEnum
        {
            CheckBoxColumn = 0,
            SrNoColumn = 1,
            KittyNoColumn = 2,
            KittyTypeColumn = 3,
            PendingInstalments = 4,
            GivenAmountColumn = 5,
            TotalAmountColumn = 6,
            StatusColumn = 7,
            MessageBoxColumn = 8,
            KittyIDColumn = 9
        }

        public event ShowDetailsClickedEventHandler ShowDetailsClicked;

        public delegate void ShowDetailsClickedEventHandler(Kitty _kitty);

        public KittyView()
        {
            InitializeComponent();
        }

        // FUNCTION:- Loads Kitty Data On To A DataGridView
        public void LoadKittyData(DataGridView Dgv)
        {
            Dgv.Rows.Clear();
            string LastInstalmentList = "";
            try
            {
                // Looping Through All Owned Kitties
                foreach (var _kitty in _currentCustomer.OwnedKitties().OrderBasedOnStatus())
                {

                    Dgv.Rows.Add();
                    int RowNo = Dgv.Rows.Count - 1;

                    // Adding Corresponding Values
                    {
                        var withBlock = Dgv.Rows[RowNo];
                        withBlock.Cells[(int)DgvEnum.KittyNoColumn].Value = _kitty.KittyNo > 0 ? _kitty.KittyNo : "";
                        withBlock.Cells[(int)DgvEnum.KittyTypeColumn].Value = _kitty.KittyType.ToCurrency();
                        withBlock.Cells[(int)DgvEnum.GivenAmountColumn].Value = _kitty.GivenAmount().ToCurrency();
                        withBlock.Cells[(int)DgvEnum.TotalAmountColumn].Value = $"{_kitty.TotalAmount().ToCurrency()} + {_kitty.KittyInterest.ToCurrency()}";
                        withBlock.Cells[(int)DgvEnum.PendingInstalments].Value = _kitty.PendingInstalmentsInWords(IncludeInstalmentWord: true);
                        withBlock.Cells[(int)DgvEnum.StatusColumn].Value = _kitty.Status();
                        if (ReferenceEquals(Dgv, DgvMessage))
                        {
                            withBlock.Cells[(int)MessageDgvEnum.KittyIDColumn].Value = _kitty;
                        }
                        else
                        {
                            withBlock.Cells[(int)DgvEnum.KittyIDColumn].Value = _kitty;
                        }
                    }

                    {
                        var withBlock1 = Dgv.Rows[RowNo].Cells[(int)DgvEnum.PendingInstalments].Style;
                        if (_kitty.GetInstalmentsPending() == -1 | _kitty.GetInstalmentsPending() >= 1)
                        {
                            withBlock1.ForeColor = Color.Red;
                        }
                        else
                        {
                            withBlock1.ForeColor = Color.Green;
                        }
                    }

                    if (_kitty.IsMatured() | _kitty.IsAvailed | _kitty.IsInactive)
                    {
                        {
                            var withBlock2 = Dgv.Rows[RowNo];
                            withBlock2.Cells[(int)DgvEnum.CheckBoxColumn].Value = true;
                            withBlock2.Cells[(int)DgvEnum.PendingInstalments].Value = string.Empty;
                            withBlock2.Cells[(int)DgvEnum.CheckBoxColumn].Style.BackColor = SystemColors.Highlight;
                            withBlock2.Cells[(int)DgvEnum.CheckBoxColumn].Style.ForeColor = SystemColors.Highlight;
                            withBlock2.Cells[(int)DgvEnum.GivenAmountColumn].Style.BackColor = SystemColors.Highlight;
                            withBlock2.Cells[(int)DgvEnum.TotalAmountColumn].Style.BackColor = SystemColors.Highlight;
                            withBlock2.Cells[(int)DgvEnum.GivenAmountColumn].Style.ForeColor = Color.White;
                            withBlock2.Cells[(int)DgvEnum.TotalAmountColumn].Style.ForeColor = Color.White;
                            if (_kitty.IsInactive)
                                withBlock2.Cells[(int)DgvEnum.StatusColumn].Style.ForeColor = Color.Silver;
                            if (_kitty.IsMatured())
                                withBlock2.Cells[(int)DgvEnum.StatusColumn].Style.ForeColor = Color.Gold;
                            if (_kitty.IsAvailed)
                                withBlock2.Cells[(int)DgvEnum.StatusColumn].Style.ForeColor = Color.Red;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"[Kittyview] LoadKittyData : {ex.Message}");
            }

            ProjectModule.SrNoUpdate(Dgv, (int)DgvEnum.SrNoColumn);
        }

        public void KittyView_Load()
        {
            _currentCustomer = (Customer)Tag;
            LoadKittyData(DgvMain);
        }

        // EVENT:- ShowDetailsBUTTON MakeEntryBUTTON CLICK->(Shows KittyForm / UpdatesKittyID / ReLoadsKittyData)
        public void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < (int)DgvEnum.DetailsButtonColumn)
                return;

            Kitty _kitty = (Kitty)DgvMain.Rows[e.RowIndex].Cells[(int)DgvEnum.KittyIDColumn].Value;

            if (e.ColumnIndex == (int)DgvEnum.DetailsButtonColumn)         // EVENT-> (Show Details) Click On Dvg
            {

                // Invoke Event To Reload KittyView Data Because Changes Are Made TO Kitty
                ShowDetailsClicked?.Invoke(_kitty);
            }

            else if (e.ColumnIndex == (int)DgvEnum.MakeEntryColumn)         // EVENT-> Make Entry Click On Dvg
            {

                if (_kitty.IsMatured()) // Raising Error:- When Making Entry On Matured Kitty's
                {
                    MessageBox.Show("[KittyView] This Kitty Is Matured, Can't Make Entry.", "EntryError");
                    return;
                }

                if (_kitty.IsAvailed)
                {
                    MessageBox.Show("[KittyView] This Kitty Is Cracked UnCrack To Continue Making Further Payments.", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                if (MessageBox.Show($"Entry Of Amount {_kitty.KittyType.ToCurrency()} To {_kitty.Owner.FullName("-")}", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                _kitty.AddRecord(DateTime.Today.Date.ToShortDateString() + _kitty.KittyType.ToString());
                _kitty.Save();
                LoadKittyData(DgvMain);
            }
        }

        // EVENT:- Message CheckBox Checked->(Shows Message Dgv) 
        private void MarriedCheckBox_CheckedChanged(CheckBox sender, EventArgs e)
        {
            if (sender.Checked)
            {
                LoadKittyData(DgvMessage);
                DgvMain.Visible = false;
                DgvMessage.Visible = true;
            }
            else
            {
                DgvMain.Visible = true;
                DgvMessage.Visible = false;
                ActivateButton(Activate: false);
            }
        }

        // FUNCTION:- Activate Send Message Button
        private void ActivateButton(bool Activate)
        {
            if (Activate)
            {
                SendMessageButton.ForeColor = Color.MediumPurple;
                SendMessageButton.Enabled = true;
            }
            else
            {
                SendMessageButton.ForeColor = Color.DimGray;
                SendMessageButton.Enabled = false;
            }
        }

        // EVENT:- CheckBox On Message Dgv Clicked->(Checks CheckBox / Activates Button)
        private void DgvMessage_CellClick(DataGridView sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == (int)MessageDgvEnum.MessageBoxColumn & e.RowIndex >= 0)
            {
                {
                    var withBlock = sender.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    if (Conversions.ToBoolean(withBlock.Value))
                    {
                        withBlock.Value = false;
                    }
                    else
                    {
                        withBlock.Value = true;
                    }
                }

                for (int i = 0, loopTo = sender.Rows.Count - 1; i <= loopTo; i++)
                {
                    if (Conversions.ToBoolean(sender.Rows[i].Cells[(int)DgvEnum.DetailsButtonColumn].Value))
                    {
                        ActivateButton(Activate: true);
                        return;
                    }
                }
                ActivateButton(Activate: false);
            }
        }

        private void SendMessageButton_Click(object sender, EventArgs e)
        {
            var SelectedKitties = new List<Kitty>();
            for (int RowNo = 0, loopTo = DgvMessage.Rows.Count - 1; RowNo <= loopTo; RowNo++)
            {
                if (Conversions.ToBoolean(DgvMessage.Rows[RowNo].Cells[(int)MessageDgvEnum.MessageBoxColumn].Value))
                {
                    SelectedKitties.Add((Kitty)DgvMessage.Rows[RowNo].Cells[(int)MessageDgvEnum.KittyIDColumn].Value);
                }
            }

            var Fm = new MessengerForIndividual() { SelectedKitties = SelectedKitties };

            Fm.Show();
        }

        private void KittyView_Load(object sender, EventArgs e) => KittyView_Load();

    }
}