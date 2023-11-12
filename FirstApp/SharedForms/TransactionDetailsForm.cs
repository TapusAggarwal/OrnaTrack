using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static FirstApp.Utility;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FirstApp
{

    public partial class TransactionDetailsForm
    {

        public Transaction CurrentTransaction { get; set; } = null;
        public Kitty _kitty { get; set; } = null;
        private int _initalHeight = 0;

        public TransactionDetailsForm()
        {
            InitializeComponent();
            DataGridView1 = _DataGridView1;
            _DataGridView1.Name = "DataGridView1";
        }

        private void PaymentModeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(PaymentModeCB.SelectedItem, "Cash", false)))
            {
                TransferedToCB.Enabled = false;
                ReferenceNoTB.Enabled = false;
            }
            else
            {
                TransferedToCB.Enabled = true;
                ReferenceNoTB.Enabled = true;
            }
        }

        public event SaveButton_ClickedEventHandler SaveButton_Clicked;

        public delegate void SaveButton_ClickedEventHandler();

        private void SaveButton_Click(object sender, EventArgs e)
        {

            if (PaymentModeCB.SelectedItem is null)
            {
                MessageBox.Show("Can't Save Changes Without A Known Payment Mode.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(TransferedToCB.SelectedItem, "BankTransfer", false)) && TransferedToCB.SelectedItem is null)
            {
                MessageBox.Show("Can't Save Changes Without A Known Account To Which Money Was Transfered To.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                CurrentTransaction.TrnsDate = DatePicker.Value;
                CurrentTransaction.Mode = Conversions.ToString(PaymentModeCB.SelectedItem);
                CurrentTransaction.Account = Conversions.ToString(TransferedToCB.SelectedItem);
                CurrentTransaction.Amount = Conversions.ToInteger(TotalAmtTB.Text);
                CurrentTransaction.RefNo = ReferenceNoTB.Text;
                CurrentTransaction.Notes = NotesTB.Text;

                int _amtMapped = CurrentTransaction.KittyIds.Sum(f => f.Value);
                if (CurrentTransaction.Amount < _amtMapped)
                {
                    MessageBox.Show("Transaction Amount Is Less Than The Amount It Is Mapped For.", "Amount Not Sufficient", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }

                CurrentTransaction.Save();
                SaveButton_Clicked?.Invoke();
            }
            catch (Exception ex)
            {

            }

            Close();

        }

        private void TransactionDetails_Load(object sender, EventArgs e)
        {
            _initalHeight = Size.Height;
            LoadComboBoxData(PaymentModeCB, Kitty.GetListOfPaymentModes());
            LoadComboBoxData(TransferedToCB, Kitty.GetListOfAccounts());

            if (CurrentTransaction is not null)
            {
                {
                    var withBlock = CurrentTransaction;
                    PaymentModeCB.SelectedIndex = PaymentModeCB.FindStringExact(withBlock.Mode);
                    TransferedToCB.SelectedIndex = TransferedToCB.FindStringExact(withBlock.Account);
                    TotalAmtTB.Text = withBlock.Amount.ToString();
                    if (withBlock.Amount == -1)
                    {
                        TotalAmtTB.Text = withBlock.KittyIds.Sum(f => f.Value).ToString();
                    }
                    ReferenceNoTB.Text = withBlock.RefNo;
                    NotesTB.Text = withBlock.Notes;
                }
                ShowKitties();
            }
            Text = $"TransactionDetails For: {CurrentTransaction.TrnsDate.ToShortDateString()}";
            PaymentModeCB.Select();

            if (_kitty is null)
                return;

            if (CurrentTransaction.KittyIds[_kitty.KittyUID] < _kitty.Record[CurrentTransaction.TrnsDate])
            {
                OnlineTransactionsBT.Visible = true;
            }

            if (CurrentTransaction.TrnsID < 0)
            {
                OnlineTransactionsBT.Visible = true;
                DeleteBT.Visible = false;
            }

        }

        private void ShowKitties()
        {
            DataGridView1.Rows.Clear();
            Size = (Size)new Point(Size.Width, _initalHeight);
            DataGridView1.Size = (Size)new Point(820, 50);
            int _index = 1;
            foreach (var i in CurrentTransaction.InitialisedKitty)
            {
                DataGridView1.Rows.Add();
                DataGridView1.Size = (Size)new Point(DataGridView1.Size.Width, DataGridView1.Size.Height + 34);
                {
                    var withBlock = DataGridView1.Rows[DataGridView1.Rows.Count - 1];
                    withBlock.Cells[0].Value = _index;
                    withBlock.Cells[1].Value = i.KittyUID;
                    withBlock.Cells[2].Value = i.KittyNo;
                    withBlock.Cells[3].Value = i.Owner.FullName();
                    withBlock.Cells[4].Value = CurrentTransaction.KittyIds[i.KittyUID].ToCurrency();
                    withBlock.Cells[5].Value = "Change";
                    withBlock.Cells[5].Tag = i;
                }
                _index += 1;
            }
            Size = (Size)new Point(Size.Width, Size.Height + DataGridView1.Size.Height - 25);
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 & e.RowIndex >= 0)
            {
                Kitty _taggedKitty = (Kitty)DataGridView1.Rows[e.RowIndex].Cells[5].Tag;
                int _inp = -1;
                try
                {
                    string x = Interaction.InputBox($"Enter The Amount That KittyNo:'{_taggedKitty.KittyNo}' Should Use From This Transaction (Ex. 2000).{Constants.vbNewLine}(Enter 0 To REMOVE This Kitty From This Transaction.)", "Enter The Changed Amount");
                    _inp = Conversions.ToInteger(string.IsNullOrEmpty(x) ? -1 : x);
                    if (_inp == -1)
                        return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Can't Accept '{_inp}' As A Valid Integer. Amount Should Be An Integer Without Any Characters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (_inp > 0)
                {
                    int _usedAmount = CurrentTransaction.KittyIds.Where(f => f.Key != _taggedKitty.KittyUID).Sum(f => f.Value);
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectGreater(_inp + _usedAmount, Conversion.Int(TotalAmtTB.Text), false)))
                    {
                        MessageBox.Show("Entered Amount Is Greater Than Transaction Amount Can't Make The Requested Changes.", "Amount Exeeds Transaction", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return;
                    }
                    _taggedKitty.Initialize(true);
                    if (_taggedKitty.Record[CurrentTransaction.TrnsDate] < _inp)
                    {
                        MessageBox.Show($"Entered Amount Is Greater Than The Amount That Was Entered In The Selected Kitty On Date: {CurrentTransaction.TrnsDate.ToShortDateString()}.", "Amount Exeeds KittyAmount", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return;
                    }
                    CurrentTransaction.KittyIds[_taggedKitty.KittyUID] = _inp;
                }

                if (_taggedKitty is null)
                    return;
                if (_inp == 0)
                {
                    if (_taggedKitty.KittyUID == _kitty.KittyUID && CurrentTransaction.TrnsID < 0)
                    {
                        MessageBox.Show("This Kitty Has To Be Mapped With This Transaction In Order To Successfully Create An New Entry. Delete This Entry If You Want To Remove This Transaction", "Can't Remove This Kitty", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return;
                    }
                    CurrentTransaction.KittyIds.Remove(_taggedKitty.KittyUID);
                }
                else if (CurrentTransaction.KittyIds[_kitty.KittyUID] < _kitty.Record[CurrentTransaction.TrnsDate])
                {
                    OnlineTransactionsBT.Visible = true;
                }

                ShowKitties();
            }
        }

        private void DissolveButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public event RemoveDetailsEventHandler RemoveDetails;

        public delegate void RemoveDetailsEventHandler();

        private void IconButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are You Sure You Want To Remove Transaction Details Of The Payment Made On {CurrentTransaction.TrnsDate.ToShortDateString()}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            CurrentTransaction.Delete();
            RemoveDetails?.Invoke();
            Close();
        }

        private void PaymentModeCB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e.Modifiers == Keys.Shift)
            {
                var Rtrn_Data = new List<string>() { "PaymentModes", "Payment Mode", "Add Payment Mode" };
                My.MyProject.Forms.CBoxForm.Tag = Rtrn_Data;
                My.MyProject.Forms.CBoxForm.ShowDialog();
                LoadComboBoxData(PaymentModeCB, Kitty.GetListOfPaymentModes());
            }
            else if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void TransferedToCB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e.Modifiers == Keys.Shift)
            {
                var Rtrn_Data = new List<string>() { "Accounts", "Accounts", "Add Accounts" };
                My.MyProject.Forms.CBoxForm.Tag = Rtrn_Data;
                My.MyProject.Forms.CBoxForm.ShowDialog();
                LoadComboBoxData(TransferedToCB, Kitty.GetListOfAccounts());
            }
            else if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void ReferenceNoTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void Control_GotFocus(Control sender, EventArgs e)
        {
            sender.BackColor = SystemColors.Highlight;
            sender.ForeColor = SystemColors.Window;
        }

        private void Control_LostFocus(Control sender, EventArgs e)
        {
            sender.BackColor = SystemColors.Window;
            sender.ForeColor = SystemColors.WindowText;
        }

        private void TotalAmtTB_GotFocus(object sender, EventArgs e)
        {
            try
            {
                TotalAmtTB.Text = Conversions.ToString(Conversion.Int(TotalAmtTB.Text));
            }
            catch
            {
            }
        }

        private void TotalAmtTB_Leave(object sender, EventArgs e)
        {
            try
            {
                TotalAmtTB.Text = TotalAmtTB.Text.ToCurrency();
                CurrentTransaction.Amount = Conversions.ToInteger(Conversion.Int(TotalAmtTB.Text));
            }
            catch
            {
                TotalAmtTB.Text = "";
            }
        }

        private void OnlineTransactionsBT_Click(object sender, EventArgs e)
        {
            var Fm = new AllTransactionsForm();
            Fm.FromDatePicker.Value = CurrentTransaction.TrnsDate;
            Fm.TillDatePicker.Value = CurrentTransaction.TrnsDate;
            Fm.ButtonText = "Select";
            Fm.Tag = CurrentTransaction;

            Close();
            Fm.Show();
            Fm.FindCoustmerButton.PerformClick();
            Fm.Visible = false;
            Fm.Cell_Clicked += (_id) =>
                {
                    var _trns = new Transaction(_id);
                    if (string.IsNullOrEmpty(_trns.Mode))
                    {
                        MessageBox.Show("Selected Transaction Not Found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return;
                    }
                    Fm.Close();
                    _trns.KittyIds.Add(_kitty.KittyUID, _kitty.Record[CurrentTransaction.TrnsDate]);
                    _trns.Save();
                    SaveButton_Clicked?.Invoke();
                };

            Fm.AddTransactionButton_Clicked += () =>
                {
                    var Fm_Trns = new TransactionDetailsForm();
                    Fm_Trns.DatePicker.Value = CurrentTransaction.TrnsDate;
                    Fm_Trns.DatePicker.Enabled = false;
                    Fm_Trns._kitty = _kitty;

                    var d = from j in _kitty.Transactions.Values
                            select j.Min(g => g.TrnsID);
                    int _min = d.Count() > 0 ? d.Min() : 0;
                    int _tempID = _min > -1 ? -1 : _min - 1;
                    int _amt = 0;
                    try
                    {
                        _amt = (from i in _kitty.Transactions[CurrentTransaction.TrnsDate]
                                select i.Amount).Sum();
                    }
                    catch
                    {
                    }
                    Fm_Trns.CurrentTransaction = new Transaction(_tempID)
                    {
                        TrnsDate = CurrentTransaction.TrnsDate,
                        Amount = _kitty.Record[CurrentTransaction.TrnsDate] - _amt
                    };
                    Fm_Trns.CurrentTransaction.KittyIds.Add(_kitty.KittyUID, _kitty.Record[CurrentTransaction.TrnsDate] - _amt);
                    Fm_Trns._kitty = _kitty;

                    Fm_Trns.SaveButton_Clicked += () =>
{
                        Fm_Trns.Close();
                        Fm.Close();
                        SaveButton_Clicked?.Invoke();
                    };

                    Fm_Trns.ShowDialog();
                };

            Fm.ShowDialog();
        }

    }
}