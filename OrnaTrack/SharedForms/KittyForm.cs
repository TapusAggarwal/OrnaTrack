using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static FirstApp.Utility;
using FontAwesome.Sharp;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FirstApp
{

    public partial class KittyForm
    {

        // ENUM Dgv-> Kitty
        public enum DgvEnum
        {
            CheckBoxColumn = 0,
            SrNoColumn = 1,
            MonthColumn = 2,
            DateColumn = 3,
            AmountColumn = 4,
            KittyTypeColumn = 5,
            TrnsDetails = 6
        }

        public Kitty _currentKitty = new Kitty();
        public event CloseButton_ClickedEventHandler CloseButton_Clicked;

        public delegate void CloseButton_ClickedEventHandler();
        public event ReloadKittyViewEventHandler ReloadKittyView;

        public delegate void ReloadKittyViewEventHandler();

        public KittyForm()
        {
            InitializeComponent();
            Dgv = _Dgv;
            _Dgv.Name = "Dgv";
        }

        #region Custom Methods
        private void Months_()
        {
            DateTime dt = Conversions.ToDate(Dgv.Rows[0].Cells[(int)DgvEnum.DateColumn].Value);

            try
            {
                for (int i = 0, loopTo = Dgv.Rows.Count - 1; i <= loopTo; i++)
                {
                    DateTime d;
                    int TempMonth = (dt.Month + i) % 12;

                    if (TempMonth == 0)
                    {
                        TempMonth = 12;
                    }
                    d = new DateTime(2020, TempMonth, 1);

                    Dgv.Rows[i].Cells[(int)DgvEnum.MonthColumn].Value = d.ToString("MMMM");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("[KittyForm] Months_ Error: " + ex.Message);
            }
        }

        private void DisplayRecord()
        {
            if (_currentKitty.Duration < 0)
                return;
            Dgv.Rows.Clear();
            Dgv.Rows.Add(count: _currentKitty.Duration);
            try
            {
                foreach (var i in _currentKitty.Record)
                {
                    int L1 = LastEmptyRow();
                    Dgv.Rows[L1].Cells[(int)DgvEnum.DateColumn].Value = i.Key.ToString("dd MMM,yyyy");
                    Dgv.Rows[L1].Cells[(int)DgvEnum.AmountColumn].Value = i.Value;

                    var newDgvButton = new DataGridViewButtonCell();

                    // newDgvButton.FlatStyle = FlatStyle.Popup


                    Dgv.Rows[L1].Cells[(int)DgvEnum.TrnsDetails].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    Dgv.Rows[L1].Cells[(int)DgvEnum.TrnsDetails] = newDgvButton;


                    {
                        var withBlock = Dgv.Rows[L1].Cells[(int)DgvEnum.TrnsDetails];
                        if (!_currentKitty.Transactions.ContainsKey(i.Key))
                        {
                            withBlock.Value = "Add";
                            withBlock.ToolTipText = "Add Transaction Details.";
                        }
                        // .Style.ForeColor = Color.White
                        // .Style.BackColor = SystemColors.Highlight
                        else
                        {
                            withBlock.Value = "Show";
                            withBlock.ToolTipText = _currentKitty.Transactions[i.Key].First().RefNo;
                            // .Style.ForeColor = Color.Black
                            // .Style.BackColor = Color.LimeGreen
                        }
                    }

                    for (double j = L1, loopTo = L1 + Conversion.Int(i.Value / (double)_currentKitty.KittyType) - 1d; j <= loopTo; j++)
                    {
                        Dgv.Rows[(int)Math.Round(j)].Cells[(int)DgvEnum.KittyTypeColumn].Value = _currentKitty.KittyType;
                        Dgv.Rows[(int)Math.Round(j)].Cells[(int)DgvEnum.CheckBoxColumn].Value = true;
                        if (j == Dgv.Rows.Count - 1)
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
            }

            Months_();
            FormatCell(-2);

            if (_currentKitty.IsMatured())
            {
                Dgv.Rows.Add();
                {
                    var withBlock1 = Dgv.Rows[Dgv.Rows.Count - 1];
                    if (_currentKitty.IsAvailed)
                    {
                        withBlock1.DefaultCellStyle.BackColor = Color.Silver;
                        withBlock1.Cells[(int)DgvEnum.DateColumn].Value = "Availed";
                    }
                    else
                    {
                        withBlock1.DefaultCellStyle.BackColor = Color.Gold;
                        withBlock1.Cells[(int)DgvEnum.DateColumn].Value = "Matured";
                    }
                    withBlock1.DefaultCellStyle.ForeColor = Color.Black;
                    withBlock1.Cells[(int)DgvEnum.CheckBoxColumn].Value = true;
                    withBlock1.Cells[(int)DgvEnum.AmountColumn].Value = _currentKitty.KittyInterest.ToCurrency();
                    withBlock1.Cells[(int)DgvEnum.KittyTypeColumn].Value = "#####";
                }
                BlockFurtherPayment();
            }
            else if (_currentKitty.IsAvailed)
            {
                BlockFurtherPayment();
            }
            else if (_currentKitty.IsInactive)
            {
                BlockFurtherPayment("InActive");
            }
            else
            {
                PaymentButton.Visible = true;
                AvailButton.Visible = false;
                StatusLabel.Visible = false;
                AvailButton.Text = "UnAvailed";
                AvailButton.IconChar = IconChar.Square;
            }

            GivenAmountTB.Text = _currentKitty.GivenAmount().ToString();

            if (!_currentKitty.IsMatured())
            {
                LeftAmountTB.Text = (_currentKitty.TotalAmount() - _currentKitty.GivenAmount()).ToString();
                BalanceTB.Text = (Conversions.ToDouble(GivenAmountTB.Text) % _currentKitty.KittyType).ToString();
            }
            else
            {
                LeftAmountTB.Text = 0.ToString();
                BalanceTB.Text = (Conversions.ToDouble(GivenAmountTB.Text) - _currentKitty.TotalAmount()).ToString();
            }
        }

        private int LastEmptyRow(int CheckBoxColumn = DgvEnum.CheckBoxColumn)
        {
            int row = Dgv.Rows.Count;
            if (row == 0)
            {
                return 0;
            }

            for (int i = 0, loopTo = Dgv.Rows.Count - 1; i <= loopTo; i++)
            {
                if (Conversions.ToBoolean(!Dgv.Rows[i].Cells[CheckBoxColumn].Value))
                {
                    row = i;
                    break;
                }
            }
            return row;
        }

        private void FormatCell(int @type = -1)
        {
            if (Dgv.Rows.Count == 0)
                return;

            var InitialCell = default(int);
            var LastCell = default(int);

            if (type == -1)
            {
                InitialCell = Dgv.Rows.Count - 1;
                LastCell = InitialCell;
            }
            else if (type == -2)
            {
                InitialCell = 0;
                LastCell = Dgv.Rows.Count - 1;
            }
            else if (type >= 0)
            {
                InitialCell = type;
                LastCell = type;
            }

            for (int i = InitialCell, loopTo = LastCell; i <= loopTo; i++)
            {
                {
                    var withBlock = Dgv.Rows[i];
                    if (withBlock.Cells[(int)DgvEnum.KittyTypeColumn].Value is null)
                        continue;
                    if (withBlock.Cells[(int)DgvEnum.KittyTypeColumn].Value.ToString().Length > 0)
                    {
                        withBlock.Cells[(int)DgvEnum.CheckBoxColumn].Value = true;
                        withBlock.Cells[(int)DgvEnum.CheckBoxColumn].Style.BackColor = SystemColors.Highlight;
                        withBlock.Cells[(int)DgvEnum.CheckBoxColumn].Style.ForeColor = Color.White;
                        withBlock.Cells[(int)DgvEnum.SrNoColumn].Value = i + 1;
                        withBlock.Cells[(int)DgvEnum.KittyTypeColumn].Value = withBlock.Cells[5].Value.ToString().ToCurrency();
                        withBlock.Cells[(int)DgvEnum.KittyTypeColumn].Style.BackColor = Color.LimeGreen;
                        withBlock.Cells[(int)DgvEnum.KittyTypeColumn].Style.ForeColor = Color.Black;
                    }
                    if (withBlock.Cells[(int)DgvEnum.AmountColumn].Value is null)
                        continue;
                    if (withBlock.Cells[(int)DgvEnum.AmountColumn].Value.ToString().Length > 0)
                    {
                        withBlock.Cells[(int)DgvEnum.SrNoColumn].Value = i + 1;
                        withBlock.Cells[(int)DgvEnum.AmountColumn].Value = withBlock.Cells[4].Value.ToString().ToCurrency();
                        withBlock.Cells[(int)DgvEnum.AmountColumn].Style.BackColor = SystemColors.Highlight;
                        withBlock.Cells[(int)DgvEnum.AmountColumn].Style.ForeColor = Color.White;
                    }
                }
            }
        }
        #endregion

        #region Direct Important Events
        // Load
        public void Kitty_Load(object sender, EventArgs e)
        {
            LoadComboBoxData(KittyIntrestCB, Kitty.GetListOfKittyIntrests());
            LoadComboBoxData(KittyTypeCB, Kitty.GetListOfKittyTypes());
            KeyPreview = true;

            // Tag = New Kitty(12, InitializeKitty:=True)
            if (Tag is not null)
            {
                _currentKitty = (Kitty)Tag;

                if (_currentKitty.KittyUID != -1)
                {
                    _currentKitty.Initialize();
                    _currentKitty.InitializeTransactions();
                    KittyTypeCB.SelectedIndex = KittyTypeCB.FindStringExact(_currentKitty.KittyType.ToString());
                    KittyIntrestCB.SelectedIndex = KittyIntrestCB.FindStringExact(_currentKitty.KittyInterest.ToString());
                    KittyNoTB.Text = _currentKitty.KittyNo.ToString();
                    TotalInstalmentsTB.Text = _currentKitty.Duration.ToString();
                    NotesTB.Text = _currentKitty.Notes;

                    DisplayRecord();

                    DissolveButton.Visible = true;

                    if (_currentKitty.IsAvailed)
                    {
                        CrackThisKittyToolStripMenuItem.Text = "UnCrack This Kitty";
                    }
                    else if (_currentKitty.IsInactive)
                    {
                        MarkAsInactiveToolStripMenuItem.Text = "Mark As Active";
                    }

                    var KittyIds = new List<int>();
                    KittyIds = (from _kittyId in _currentKitty.Owner.OwnedKitties()
                                select _kittyId.KittyUID).ToList();

                    TotalKittysLB.Text = "#" + (KittyIds.IndexOf(_currentKitty.KittyUID) + 1).ToString();
                }
                else
                {
                    TotalKittysLB.Text = "#" + (_currentKitty.Owner.OwnedKitties().Count + 1).ToString();
                }

            }

        }

        private void KittyTypeCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int actualType = _currentKitty.KittyType;
            int selectionType = Conversions.ToInteger(KittyTypeCB.SelectedItem);

            if (_currentKitty.Record.Count == 0)
            {
                _currentKitty.KittyType = selectionType;
            }
            else if (actualType != selectionType)
            {
                if (MessageBox.Show($"This Selection Will Change Kitty Type From {actualType.ToCurrency()} To {selectionType.ToCurrency()}", "Do You Want To Continue ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    KittyTypeCB.SelectedIndex = KittyTypeCB.FindStringExact(_currentKitty.KittyType.ToString());
                    return;
                }
                var _temp = (from _entries in _currentKitty.Record
                             select _entries).ToDictionary(k => k.Key, v => v.Value);

                foreach (var _entry in _temp)
                    _currentKitty.Record[_entry.Key] = (int)Math.Round(Conversion.Int(_entry.Value / (double)actualType) * selectionType + _entry.Value % actualType);
                _currentKitty.KittyType = selectionType;
                DisplayRecord();
            }
        }
        private void KittyIntrestCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentKitty.KittyInterest = Conversions.ToInteger(KittyIntrestCB.SelectedItem);
            DisplayRecord();
        }

        private void Controls_TextChanged(TextBox sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sender.Text))
                return;

            if (!Information.IsNumeric(sender.Text) || Conversions.ToDouble(sender.Text) <= 0d)
            {
                sender.Text = "";
                return;
            }

            if (ReferenceEquals(sender, TotalInstalmentsTB))
            {
                if (Conversions.ToDouble(sender.Text) == 0d)
                {
                    sender.Text = "";
                    return;
                }
                if (Conversions.ToDouble(sender.Text) == _currentKitty.Duration && Dgv.RowCount == _currentKitty.Duration)
                    return; // No Need To Proceed As Data Already Exists

                if (Dgv.RowCount == _currentKitty.Duration && _currentKitty.Record.Count >= 1)
                {
                    MessageBox.Show("Can't Change Kitty Duration Once A Kitty Is Initialised. Try Creating New Kitty With Required Duration.", "Illegal Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sender.Text = _currentKitty.Duration.ToString();
                    return;
                }
                Dgv.Rows.Clear();
                Dgv.Rows.Add(sender.Text);
                _currentKitty.Duration = Conversions.ToInteger(sender.Text);
            }
            else if (ReferenceEquals(sender, KittyNoTB))
            {
                _currentKitty.KittyNo = Conversions.ToInteger(sender.Text);
            }
        }
        #endregion

        #region Convenience Wrapper

        private void KeyDown_TextBoxControls(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down | e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
            else if (e.KeyCode == Keys.Up)
            {
                SendKeys.Send("+{Tab}");
            }
        }

        private void KittyTypeCB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e.Modifiers == Keys.Shift)
            {
                var Rtrn_Data = new List<string>() { "KittyType", "Kitty Type", "Add Kitty Type" };
                My.MyProject.Forms.CBoxForm.Tag = Rtrn_Data;
                My.MyProject.Forms.CBoxForm.ShowDialog();
                LoadComboBoxData(KittyTypeCB, Kitty.GetListOfKittyTypes());
            }
            else if (e.KeyCode == Keys.Enter)
            {

                int SelectedKittyType = 0;

                try
                {
                    OleDbDataReader dr = (OleDbDataReader)ProjectModule.DataReader($"Select * From DefaultSetter Where KittyType={_currentKitty.KittyType}");
                    while (dr.Read())
                    {
                        SelectedKittyType = Conversions.ToInteger(Conversion.Int(dr["KittyType"]));
                        KittyTypeCB.SelectedIndex = KittyTypeCB.FindStringExact(Conversions.ToString(Conversion.Int(dr["KittyType"])));
                        TotalInstalmentsTB.Select();
                        TotalInstalmentsTB.Text = Conversions.ToString(Conversion.Int(dr["Duration"]));
                        KittyIntrestCB.Select();
                        KittyIntrestCB.SelectedIndex = KittyIntrestCB.FindStringExact(Conversions.ToString(dr["Intrest"]));
                    }
                    dr.Close();
                }
                catch
                {
                }

                try
                {
                    OleDbDataReader dr_UID = (OleDbDataReader)ProjectModule.DataReader($"Select KittyNo From Kitty_Data Where KittyType={SelectedKittyType} ORDER BY KittyNo DESC");
                    while (dr_UID.Read())
                    {
                        KittyNoTB.Text = Conversions.ToString(Operators.AddObject(Conversion.Int(dr_UID["KittyNo"]), 1));
                        KittyNoTB.Select();
                        break;
                    }
                    dr_UID.Close();
                }
                catch (Exception ex)
                {
                }

            }
        }

        private void KittyIntrestCB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e.Modifiers == Keys.Shift)
            {
                var Rtrn_Data = new List<string>() { "KittyIntrest", "Kitty Intrest", "Add Kitty Intrest" };
                My.MyProject.Forms.CBoxForm.Tag = Rtrn_Data;
                My.MyProject.Forms.CBoxForm.ShowDialog();
                LoadComboBoxData(KittyIntrestCB, Kitty.GetListOfKittyIntrests());
            }
            else if (e.KeyCode == Keys.Enter)
            {
                TotalInstalmentsTB.Select();
            }
        }
        private void Controls_GotFocus(TextBox sender, EventArgs e)
        {
            sender.BackColor = SystemColors.GradientActiveCaption;
        }

        private void Controls_Leave(TextBox sender, EventArgs e)
        {
            sender.BackColor = Color.White;
        }

        private void BalanceTB_TextChanged(TextBox sender, EventArgs e)
        {
            try
            {

                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectGreater(Conversion.Int(sender.Text), 0, false)))
                {
                    sender.BackColor = SystemColors.HotTrack;
                    sender.ForeColor = Color.White;
                    sender.Text = sender.Text.ToCurrency();
                }
                else
                {
                    sender.BackColor = SystemColors.ControlDark;
                    sender.ForeColor = Color.Black;
                }
            }

            catch (Exception ex)
            {
            }
        }

        private void Kitty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control & e.KeyCode == Keys.S)
            {
                SaveButton_Click(SaveButton, e);
            }
            else if (e.Control & e.KeyCode == Keys.P)
            {
                PaymentButton.Select();
                PaymentButton_Click(PaymentButton, EventArgs.Empty);
                DatePicker.Select();
            }
            else if (e.Control & e.KeyCode == Keys.D)
            {
                DeleteButton_Click(DeleteButton, EventArgs.Empty);
            }
        }

        #endregion

        #region Button CLick
        public void DeleteButton_Click(object sender, EventArgs e)
        {
            // If No Record Was Found
            if (_currentKitty.Record.Count == 0)
            {
                MessageBox.Show("No Record To Delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // IF Kitty IS Availed
            if (_currentKitty.IsAvailed)
            {
                MessageBox.Show("This Kitty Is Cracked, Mark It As UnCracked To Continue Making Further Activities.", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            // IF Kitty IS Inactive
            if (_currentKitty.IsInactive)
            {
                MessageBox.Show("This Kitty Is InActive, Mark It As Active To Continue Making Further Activities.", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            var dateToRemove = _currentKitty.Record.Last().Key;

            _currentKitty.Record.Remove(dateToRemove);
            DisplayRecord();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            if (LastEmptyRow() != 0 && MessageBox.Show("This Will Remove All Data In Grid, Do You Want To Continue ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            _currentKitty.Record.Clear();
            _currentKitty.IsAvailed = false;
            _currentKitty.IsInactive = false;
            DisplayRecord();
            EntryTB.Select();
        }

        public void PaymentButton_Click(object sender, EventArgs e)
        {

            // Entry Amount NOTHING
            if (EntryTB.Text.Length == 0)
                EntryTB.Text = _currentKitty.KittyType.ToString();

            // Entry Amount Not An Integer
            if (!Information.IsNumeric(EntryTB.Text))
            {
                EntryTB.Text = "";
                EntryTB.Select();
                return;
            }

            // Kitty Type Not SELECTED
            if (KittyTypeCB.SelectedIndex < 0)
            {
                MessageBox.Show("Please Select Kitty Type.", "Incomplete Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Total Instalments Not ENTERED
            if (Dgv.Rows.Count == 0)
            {
                MessageBox.Show("Please Enter Total Instalments.", "Incomplete Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Intrest Not SELECTED
            if (KittyIntrestCB.SelectedIndex < 0)
            {
                MessageBox.Show("Please Select The Intrest On The Kitty.", "Incomplete Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Entry Date Greater Than Today's Date
            if (DatePicker.Value.Date > DateTime.Today.Date)
            {
                if (MessageBox.Show("Do You Want To Continue, Date Entered Is Greater Than Today's Date.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                {
                    return;
                }
            }

            // Entry Amount Less Than Kitty Type
            if (Conversions.ToDouble(EntryTB.Text) > 0d && Conversions.ToDouble(EntryTB.Text) < _currentKitty.KittyType)
            {
                MessageBox.Show("Can't Make Entry, Entered Amount Is Less Than Kitty Type.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // IF Kitty IS Matured
            if (_currentKitty.IsMatured() && Conversions.ToDouble(EntryTB.Text) > 0d)
            {
                MessageBox.Show("This Kitty Is Matured Can't Make More Entry", "No More Entries", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            // IF Kitty IS Availed
            if (_currentKitty.IsAvailed)
            {
                MessageBox.Show("This Kitty Is Cracked, Mark It As UnCracked To Continue Making Further Activities.", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            // IF Kitty IS Inactive
            if (_currentKitty.IsInactive)
            {
                MessageBox.Show("This Kitty Is InActive, Mark It As Active To Continue Making Further Activities.", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            // Storing Wether The Result Of Entry Was True Or False
            bool entryResult = _currentKitty.AddRecord(DatePicker.Value.Date.ToShortDateString() + EntryTB.Text);
            if (entryResult == false)
                return;

            EntryTB.Select();
            // MessageBox.Show(_currentKitty.GetRecordString())

            DisplayRecord();

        }

        private void DissolveButton_Click(object sender, EventArgs e)
        {
            _currentKitty.Dissolve();
            ReloadKittyView?.Invoke();
        }

        public void SaveButton_Click(object sender, EventArgs e)
        {
            if (_currentKitty.KittyType == -1 | _currentKitty.KittyInterest == -1 | _currentKitty.Duration == -1)
            {
                MessageBox.Show("Please Complete All The Feilds.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (KittyNoTB.TextLength == 0 && MessageBox.Show("You Are Saving This Kitty Without A KittyNo, Do You Still Want To Continue ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;
            if (_currentKitty.Record.Count == 0 && MessageBox.Show("You Are Saving An Empty Kitty, Do You Want To Continue ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            _currentKitty.Save();
            if (_currentKitty.KittyUID == -1)
                Close();
            Kitty_Load(this, EventArgs.Empty);
            ReloadKittyView?.Invoke();
        }

        private void NotificationButton_Click(IconPictureBox sender, EventArgs e)
        {
            if (sender.IconChar == IconChar.BellSlash)
            {
                // When Allowing To Send Message
                sender.IconChar = IconChar.Bell;
                sender.IconColor = Color.ForestGreen;
            }
            else
            {
                // When Not Allowing To Send Message
                var Fm = new Form();

                Fm.Size = (Size)new Point(500, 250);
                Fm.StartPosition = FormStartPosition.CenterScreen;
                Fm.BackColor = Color.FromArgb(36, 30, 60);

                var x = new Label();

                x.Location = new Point(15, 0);
                x.Text = "Reason For Turning Notification Off ?";
                x.AutoSize = true;
                x.Font = new Font("Century Schoolbook", 12f);
                x.ForeColor = SystemColors.ActiveCaption;

                Fm.Controls.Add(x);

                var y = new TextBox();

                y.Location = new Point(10, 40);
                y.Multiline = true;
                y.Size = (Size)new Point(455, 130);
                y.Font = new Font("Century Schoolbook", 10f, FontStyle.Bold);
                Fm.Controls.Add(y);

                Fm.ShowDialog();

                return;

                sender.IconChar = IconChar.BellSlash;
                sender.IconColor = Color.DarkRed;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            CloseButton_Clicked?.Invoke();
        }

        private void RightArrowButton_Click(object sender, EventArgs e)
        {
            // Dim x As New Process()
            // Dim info As New ProcessStartInfo With {
            // .Arguments = "/c del /S C:\Users\hp\Desktop\Bills\ /Q",
            // .FileName = "cmd.exe",
            // .CreateNoWindow = False,
            // .WindowStyle = ProcessWindowStyle.Hidden
            // }
            // x.StartInfo = info
            // x.Start()
            var proc = new Process();
            proc.StartInfo.FileName = "cmd";
            proc.StartInfo.Arguments = @"/c del /S C:\Users\tapus\OneDrive\Desktop\Bills\ /Q";
            proc.Start();
            proc.WaitForExit();
            var Fm = new MessengerForIndividual() { SelectedKitties = new List<Kitty>(new[] { _currentKitty }) };
            // Fm.TopMost = True
            Fm.ShowDialog();
        }

        private void CrackThisKittyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_currentKitty.IsMatured())
            {
                MessageBox.Show("Can't Crack A Matured Kitty. Use Availed Instead.", "Wrong Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _currentKitty.IsAvailed = !_currentKitty.IsAvailed;
            if (_currentKitty.IsAvailed)
            {
                _currentKitty.IsInactive = false;
                MarkAsInactiveToolStripMenuItem.Text = "Mark As InActive";
                CrackThisKittyToolStripMenuItem.Text = "UnCrack This Kitty";
                BlockFurtherPayment();
            }
            else
            {
                CrackThisKittyToolStripMenuItem.Text = "Crack This Kitty";
                DisplayRecord();
            }
        }

        private void MarkAsInactiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_currentKitty.IsMatured())
            {
                MessageBox.Show("Can't Mark A Matured Kitty As InActive. Use Availed Instead.", "Wrong Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _currentKitty.IsInactive = !_currentKitty.IsInactive;
            if (_currentKitty.IsInactive)
            {
                _currentKitty.IsAvailed = false;
                CrackThisKittyToolStripMenuItem.Text = "Crack This Kitty";
                MarkAsInactiveToolStripMenuItem.Text = "Mark As Active";
                BlockFurtherPayment("InActive");
            }
            else
            {
                MarkAsInactiveToolStripMenuItem.Text = "Mark As InActive";
                DisplayRecord();
            }
        }

        #endregion

        private void BlockFurtherPayment(string status = "Cracked")
        {

            PaymentButton.Visible = false;
            AvailButton.Visible = true;
            StatusLabel.Visible = true;

            if (!_currentKitty.IsMatured() && _currentKitty.IsAvailed | _currentKitty.IsInactive)
            {
                AvailButton.Text = status;
                AvailButton.IconChar = IconChar.TimesCircle;
                {
                    var withBlock = Dgv.Rows[LastEmptyRow()];
                    withBlock.DefaultCellStyle.BackColor = Color.Red;
                    withBlock.DefaultCellStyle.ForeColor = Color.White;
                    withBlock.Cells[(int)DgvEnum.MonthColumn].Value = "-----";
                    withBlock.Cells[(int)DgvEnum.DateColumn].Value = status;
                    withBlock.Cells[(int)DgvEnum.AmountColumn].Value = "-----";
                    withBlock.Cells[(int)DgvEnum.KittyTypeColumn].Value = "-----";
                }
            }
            else
            {
                AvailButton.Enabled = true;
                if (_currentKitty.IsAvailed)
                {
                    AvailButton.Text = "Availed";
                    AvailButton.IconChar = IconChar.CheckSquare;
                }
                else
                {
                    AvailButton.Text = "UnAvailed";
                    AvailButton.IconChar = IconChar.Square;
                }
            }

        }

        private void ContinueFurtherPayment()
        {
            PaymentButton.Visible = true;
            AvailButton.Visible = false;
            StatusLabel.Visible = false;
            AvailButton.Text = "UnAvailed";
            AvailButton.IconChar = IconChar.Square;
        }

        private void AvailButton_Click(object sender, EventArgs e)
        {
            if (!_currentKitty.IsMatured() && _currentKitty.IsAvailed | _currentKitty.IsInactive)
                return;

            _currentKitty.IsAvailed = !_currentKitty.IsAvailed;
            AvailButton.Enabled = true;
            BlockFurtherPayment();
            DisplayRecord();
            // If _currentKitty.IsAvailed Then
            // Else
            // ContinueFurtherPayment()
            // End If
        }

        private void NotesTB_TextChanged(object sender, EventArgs e)
        {
            _currentKitty.Notes = NotesTB.Text;
        }

        private void TransferKittyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Fm = new ShortCustomerSearch() { HideCustomerID = _currentKitty.CustomerID };
            Fm.CustomerClicked += CustomerSelected;
            Fm.Show();
        }

        private void CustomerSelected(int NewCustomerId, int KittID = -1)
        {
            if (MessageBox.Show($"Are You Sure You Want To Transfer KittyNo:{_currentKitty.KittyNo} And Type:{_currentKitty.KittyType} To Customer:{new Customer(NewCustomerId).FullName()} ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            _currentKitty.CustomerID = NewCustomerId;
            SaveButton_Click(SaveButton, EventArgs.Empty);

            foreach (Form ExistingFm in My.MyProject.Forms.Frame.MdiChildren)
            {
                if (ExistingFm.Name != "Main")
                {
                    ExistingFm.Dispose();
                }
            }

            var Fm = new KittyModeCoustView()
            {
                MdiParent = My.MyProject.MyForms.Frame,
                Dock = DockStyle.Fill,
                Tag = NewCustomerId.ToString() + "_" + _currentKitty.KittyUID.ToString()
            };

            Fm.Show();

        }

        private void IconPictureBox1_Click(object sender, EventArgs e)
        {
            ContextMenuStrip1.Show(DotsButton, 0, DotsButton.Size.Height);
        }

        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != (int)DgvEnum.TrnsDetails)
                return;

            if (Dgv.Rows[e.RowIndex].Cells[6].GetType() != typeof(DataGridViewButtonCell))
                return;
            DateTime SelectedRowDate = Conversions.ToDate(Dgv.Rows[e.RowIndex].Cells[(int)DgvEnum.DateColumn].Value);

            var Fm = new TransactionDetailsForm();
            Fm.DatePicker.Value = SelectedRowDate;
            Fm.DatePicker.Enabled = false;
            Fm._kitty = _currentKitty;

            if (!_currentKitty.Transactions.ContainsKey(SelectedRowDate) || _currentKitty.Transactions[SelectedRowDate].Count > 1)
            {
                var d = from j in _currentKitty.Transactions.Values
                        select j.Min(g => g.TrnsID);
                int _min = d.Count() > 0 ? d.Min() : 0;
                int _tempID = _min > -1 ? -1 : _min - 1;
                int _amt = 0;
                try
                {
                    _amt = (from i in _currentKitty.Transactions[SelectedRowDate]
                            select i.Amount).Sum();
                }
                catch
                {
                }
                Fm.CurrentTransaction = new Transaction(_tempID)
                {
                    TrnsDate = SelectedRowDate,
                    Amount = _currentKitty.Record[SelectedRowDate] - _amt
                };
                Fm.CurrentTransaction.KittyIds.Add(_currentKitty.KittyUID, _currentKitty.Record[SelectedRowDate] - _amt);
            }
            else
            {
                Fm.CurrentTransaction = (Transaction)_currentKitty.Transactions[SelectedRowDate].First().Clone();
            }

            // If There Is Only One Transaction To Show Or New Transaction Is Being Added.
            if (!_currentKitty.Transactions.ContainsKey(SelectedRowDate) || _currentKitty.Transactions[SelectedRowDate].Count == 1)
            {
                Fm.SaveButton_Clicked += ReloadAfterTransactionForm;
                Fm.RemoveDetails += ReloadAfterTransactionForm;
                Fm.ShowDialog();
            }
            else
            {
                // Multiple Transactions
                var Fm_Trns = new AllTransactionsForm();
                Fm_Trns.FromDatePicker.Value = SelectedRowDate;
                Fm_Trns.TillDatePicker.Value = SelectedRowDate;

                Fm_Trns.AddTransactionButton_Clicked += () =>
                    {
                        Fm.SaveButton_Clicked += ReloadAfterTransactionForm;
                        Fm.ShowDialog();
                        Fm_Trns.FindCoustmerButton.PerformClick();
                        int _sum = (from i in _currentKitty.Transactions[SelectedRowDate]
                                    select i.Amount).Sum();
                        Fm_Trns.AddMsgBT.Enabled = !(_sum == _currentKitty.Record[SelectedRowDate]);
                    };

                int x = (from i in _currentKitty.Transactions[SelectedRowDate]
                         select i.Amount).Sum();
                Fm_Trns.AddMsgBT.Enabled = !(x == _currentKitty.Record[SelectedRowDate]);
                Fm_Trns.Show();
                Fm_Trns.FindCoustmerButton.PerformClick();
                Fm_Trns.Visible = false;
                Fm_Trns.ShowDialog();
                ReloadAfterTransactionForm();
            }


        }

        private void ReloadAfterTransactionForm()
        {
            _currentKitty.InitializeTransactions();
            DisplayRecord();
        }

    }
}