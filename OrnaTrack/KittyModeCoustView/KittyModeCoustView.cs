using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FirstApp
{

    public partial class KittyModeCoustView
    {

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
        }

        protected Customer _Customer;
        public int _KittyID_Book = default;
        public KittyForm _KittyForm;
        public bool BookMode = false;
        protected List<int> BookList = new List<int>();

        protected bool ReviewMode = false;
        protected bool _reviewed = false;

        public KittyModeCoustView()
        {
            InitializeComponent();
        }

        #region Load Customer And Kitty Data
        // Load -> CustomerId TextBox Text = TAG(CustomerId)
        public void CoustProfileUpdated_Load()
        {
            KeyPreview = true;
            CustomerIdTB.Text = Tag.ToString().Split('_')[0].Trim();
            if (Prev_SessionToolStripMenuItem.Checked)
            {
                Prev_SessionToolStripMenuItem_Click(Prev_SessionToolStripMenuItem, EventArgs.Empty);
            }

            // List Of KittyTypes For Book Mode
            foreach (var i in Kitty.GetListOfKittyTypes())
            {
                var x = new ToolStripMenuItem()
                {
                    Checked = true,
                    CheckOnClick = true,
                    Text = i.ToString()
                };
                BookModeSelectedTypes.Items.Add(x);

                x.CheckedChanged += (ToolStripMenuItem _sender, EventArgs _e) =>
                    {
                        BookModeSelectedTypes.Show(DotsButton, 0, DotsButton.Size.Height);
                        if (BookMode)
                        {
                            ShowBook();
                        }
                    };
            }

        }

        // Loading Data On Text Changed Event
        public void CoustmerIdTB_TextChanged(object sender, EventArgs e)
        {
            if (CustomerIdTB.TextLength == 0)
            {
                Dispose();
                My.MyProject.Forms.Frame.NewCoustmerButton_Click();
            }

            _Customer = new Customer(Conversions.ToInteger(CustomerIdTB.Text.Trim()));

            if (CustomerIdTB.TextLength > 0)
            {
                LoadCustomerProfileData();
                LoadCustomerKittyData();
                UpdateBookModeIndexes();
                if (ReviewMode)
                {
                    System.Data.OleDb.OleDbDataReader dr = (System.Data.OleDb.OleDbDataReader)ProjectModule.DataReader($"Select Review From Coustmers_Data Where SrNo={_Customer.CustomerID}");
                    while (dr.Read())
                    {
                        try
                        {
                            if (dr["Review"].ToString().Split('_')[1] == "False")
                            {
                                _reviewed = false;
                            }
                            else
                            {
                                _reviewed = true;
                            }
                        }
                        catch (Exception ex)
                        {
                        }
                    }
                    UpdateReview();
                }
            }
        }

        // First Load Customer Profile
        private void LoadCustomerProfileData()
        {
            {
                ref var withBlock = ref _Customer;
                try
                {
                    FullName.Text = withBlock.FullName();
                }
                catch
                {
                }
                try
                {
                    PhNo.Text = withBlock.PhNo(",");
                }
                catch
                {
                }
                try
                {
                    Gender.Text = withBlock.Gender();
                }
                catch
                {
                }
                try
                {
                    Married.Text = Conversions.ToString(withBlock.IsMarried());
                }
                catch
                {
                }
                try
                {
                    Profession.Text = withBlock.Profession();
                }
                catch
                {
                }
                try
                {
                    Address.Text = withBlock.Address();
                }
                catch
                {
                }
                try
                {
                    RegionData.Text = withBlock.Region();
                }
                catch
                {
                }
                try
                {
                }
                catch
                {
                    // ImageBox.BackgroundImage = Image.FromFile(dr("img"))    'Adding Profile Iamge
                }
                if (Customer.SharedPhNo(_Customer.GetPhNo().ToArray()).Count > 1)
                {
                    ExistingPhNosButton.Visible = true;
                }
                else
                {
                    ExistingPhNosButton.Visible = false;
                }
            }

        }

        // Second Load Kitty View Data
        private void LoadCustomerKittyData()
        {
            KittyView _KittyView;
            _KittyView = new KittyView() { Tag = _Customer };

            _KittyView.DgvMain.Columns[9].Visible = false; // Button That Makes Direct Entry "Make Entry" Button
            PanelView.Controls.Clear();
            var Pnl = _KittyView.SharingPanel;
            Pnl.Dock = DockStyle.Fill;
            PanelView.Controls.Add(Pnl);
            _KittyView.KittyView_Load();

            _KittyView.ShowDetailsClicked += (_kitty) =>
                {
                    KittyIdTB.Text = "";
                    KittyIdTB.Text = _kitty.KittyUID.ToString();
                };

            int _count = _Customer.OwnedKitties().Count;
            if (_count == 1)
            {
                KittyIdTB.Text = _Customer.OwnedKitties().First().KittyUID.ToString();
            }
            else if (_count == 0)
            {
                KittyIdTB.Text = "";
            }

            if (!string.IsNullOrEmpty(KittyIdTB.Text))
            {
                var _temp = new Kitty(Conversions.ToInteger(KittyIdTB.Text.Trim()), true);
                if (_temp.CustomerID == -1)
                {
                    KittyIdTB.Text = "";
                }
            }

        }

        // KittyID TextBox Text=Tag.split(_)(1)
        private void KittyModeCoustView_Shown(object sender, EventArgs e)
        {
            var x1 = new Thread(() => { if (Tag.ToString().Split('_').Count() > 1) { KittyIdTB.Invoke(new Action(() => KittyIdTB.Text = Tag.ToString().Split('_')[1])); } }) { Priority = ThreadPriority.Lowest };
            x1.Start();
        }

        // Call Load Kitty Data Method
        private void KittyIdTB_TextChanged(object sender, EventArgs e)
        {
            RemoveControls();
            if (KittyIdTB.TextLength != 0)
            {
                ShowKittyForm(new Kitty(Conversions.ToInteger(KittyIdTB.Text.Trim()), InitializeKitty: true, true));
            }
        }

        // Loads A Form Given A Kitty
        public void ShowKittyForm(Kitty _tempKitty)
        {
            Invoke(new Action(() =>
                {
                    _KittyForm = new KittyForm() { Tag = _tempKitty };
                    var Pnl = _KittyForm.MainPanel;
                    Pnl.Dock = DockStyle.Fill;
                    RemoveControls();
                    ShowLabel.Visible = false;
                    _KittyForm.Kitty_Load(_KittyForm, EventArgs.Empty);
                    KittyPanel.Controls.Add(Pnl);
                    _KittyForm.CloseButton_Clicked += () => RemoveControls();
                    _KittyForm.ReloadKittyView += () => LoadCustomerKittyData();
                    CustomerIdTB.Text = _tempKitty.CustomerID.ToString();
                }));
        }

        // SHIFT + ENTER -> For Manually Changing CustomerID And KittyID
        private void CoustmerIdTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e.Modifiers == Keys.Shift)
            {
                if (MessageBox.Show("This Feature Is Only For DevUse: To Manually Change The ID. Do You Still Want To Continue?", "Data Loss Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                string Id = Interaction.InputBox("Enter The New Id.(This May Lead To Unexpected Errors)", "Enter ID");
                if (!Information.IsNumeric(((dynamic)sender).text))
                    return;
                ((dynamic)sender).Text = Id;
            }
        }

        // Makes IDs Visible
        public void ShowCoustmerID()
        {
            try
            {
                CustomerIdTB.Invoke(new Action(() =>
                    {
                        CustomerIdTB.Visible = true;
                        KittyIdTB.Visible = true;
                    }));
            }
            catch (Exception ex)
            {
            }
        }

        // Removes All Controls From Kitty Panel Except ShowLabel
        public void RemoveControls()
        {
            foreach (var i in KittyPanel.Controls)
            {
                if (!ReferenceEquals(i, ShowLabel))
                    KittyPanel.Controls.Remove((Control)i);
            }
        }

        // Hides Show Label If Control IS Added TO Panel OR Shows It If Removed
        private void KittyPanel_ControlAdded()
        {
            if (KittyPanel.Controls.Count == 1)
            {
                ShowLabel.Visible = true;
            }
        }

        #endregion

        #region Direct Important Methods
        // Customer Details Button Click
        private void CustomerDetailsButton_Click(object sender, EventArgs e)
        {
            foreach (Form ExistingFm in My.MyProject.Forms.Frame.MdiChildren)
            {
                if (ExistingFm.Name != "Main")
                {
                    var Fm = new CoustProfileUpdated()
                    {
                        MdiParent = My.MyProject.MyForms.Frame,
                        Dock = DockStyle.Fill,
                        Tag = _Customer.CustomerID
                    };
                    Fm.Show();
                    ExistingFm.Dispose();
                }
            }

        }

        // ExistingPhNo Button Click
        private void ExistingPhNosButton_Click(object sender, EventArgs e)
        {
            var Fm = new DgvForExistingPhno()
            {
                CurrentPhNo = _Customer.GetPhNo().ToArray(),
                CurrentCustomer = _Customer,
                ShowInTaskbar = false
            };
            Fm.ShowDialog();
            if (Fm.SelectedCustomer >= 0)
            {
                CustomerIdTB.Text = Fm.SelectedCustomer.ToString();
            }
        }

        // KeyBoard ShortCuts
        private void Me_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Control & e.KeyCode == Keys.K)
                {
                    AddKittyButton_Click(AddKittyButton, EventArgs.Empty);
                }
                if (_KittyForm is not null)
                {
                    if (e.Control & e.KeyCode == Keys.I)
                    {
                        _KittyForm.MarkAsInactiveToolStripMenuItem.PerformClick();
                    }
                    else if (e.Control & e.KeyCode == Keys.C)
                    {
                        _KittyForm.CrackThisKittyToolStripMenuItem.PerformClick();
                    }
                    else if (e.Control & e.KeyCode == Keys.S)
                    {
                        _KittyForm.SaveButton_Click(_KittyForm.SaveButton, e);
                    }
                    else if (e.Control & e.KeyCode == Keys.P)
                    {
                        _KittyForm.PaymentButton.Select();
                        _KittyForm.PaymentButton_Click(_KittyForm.PaymentButton, e);
                        _KittyForm.DatePicker.Select();
                    }
                    else if (e.Control & e.KeyCode == Keys.D)
                    {
                        _KittyForm.DeleteButton_Click(_KittyForm.DeleteButton, e);
                        _KittyForm.DatePicker.Select();
                    }
                    else if (e.Control & e.KeyCode == Keys.B)
                    {
                        BookModeButton_Click(BookModeButton, EventArgs.Empty);
                    }
                    else if (e.Control & e.KeyCode == Keys.J)
                    {
                        JumpToKittyNoButton_Click(JumpToKittyNoButton, EventArgs.Empty);
                    }
                    else if (e.Control & e.KeyCode == Keys.Right)
                    {
                        NextKittyButton_Click(NextKittyButton, EventArgs.Empty);
                    }
                    else if (e.Control & e.KeyCode == Keys.Left)
                    {
                        PrevKittyButton_Click(PrevKittyButton, EventArgs.Empty);
                    }
                }
            }
            catch
            {
            }
        }

        // AddKitty Button
        private void AddKittyButton_Click(object sender, EventArgs e)
        {
            var _tempKitty = new Kitty() { CustomerID = Conversions.ToInteger(_Customer.CustomerID) };
            var KittyForm_Fm = new KittyForm() { Tag = _tempKitty };
            KittyForm_Fm.ShowDialog();
            LoadCustomerKittyData();
        }

        #endregion

        #region BookMode
        public void BookModeButton_Click(object sender, EventArgs e)
        {
            if (KittyIdTB.Text.Length == 0)
                return;

            BookList.Clear();

            BookMode = !BookMode;

            if (BookMode)
            {
                ShowBook();
            }
            if (!BookMode)
            {
                BookModeButton.IconColor = Color.Silver;
                KittyInfoLabel.Visible = false;
                PrevKittyButton.Visible = false;
                NextKittyButton.Visible = false;
                JumpToKittyNoButton.Visible = false;
            }
        }

        private void ShowBook()
        {
            string[] selectedTypes = (from _items in BookModeSelectedTypes.Items
                                      where _items.Checked == true
                                      select _items.Text).ToArray();

            if (selectedTypes.Count() == 0)
            {
                MessageBox.Show("First Select Kitty Types To Be Included In BookMode. By Clicking On Three Dots.");
                return;
            }

            string _condition = "";

            foreach (var i in selectedTypes)
            {
                if (Array.IndexOf(selectedTypes, i) == 0)
                {
                    _condition += $"KittyType={i}";
                }
                else
                {
                    _condition += $" OR KittyType={i}";
                }
            }

            BookList.Clear();

            System.Data.OleDb.OleDbDataReader dr = (System.Data.OleDb.OleDbDataReader)ProjectModule.DataReader($"Select KittyUID From Kitty_Data Where ({_condition}) ORDER BY KittyNo ASC");
            while (dr.Read())
                BookList.Add(Conversions.ToInteger(dr["KittyUID"]));

            if (!selectedTypes.Contains(_KittyForm._currentKitty.KittyType.ToString()))
            {
                MessageBox.Show("You Have Not Selected Kitty Type Of Currently Opened Kitty. This Will Jump Back To Zero.");
                _KittyID_Book = BookList.First();
                KittyIdTB.Text = _KittyID_Book.ToString();
            }


            KittyInfoLabel.Visible = true;
            PrevKittyButton.Visible = true;
            NextKittyButton.Visible = true;
            JumpToKittyNoButton.Visible = true;
            BookModeButton.IconColor = Color.PaleGreen;
            UpdateBookModeIndexes();
        }

        private void UpdateBookModeIndexes()
        {
            if (!BookMode)
                return;
            _KittyID_Book = Conversions.ToInteger(KittyIdTB.Text);
            KittyInfoLabel.Text = $"{_KittyForm._currentKitty.KittyType.ToCurrency(true)} : #{_KittyForm._currentKitty.KittyNo}: {new Kitty(BookList.First(), true).KittyNo}-{new Kitty(BookList.Last(), true).KittyNo}";
            int Index = CurrentIndex();
            if (Index == 0)
                PrevKittyButton.Enabled = false;
            else
                PrevKittyButton.Enabled = true;
            if (Index == BookList.Count - 1)
                NextKittyButton.Enabled = false;
            else
                NextKittyButton.Enabled = true;
        }

        private int CurrentIndex()
        {
            return BookList.IndexOf(_KittyID_Book);
        }

        private object _active = null;
        private object _inActive = null;
        private object _availed = null;
        private object _matured = null;
        private object _cracked = null;

        private void NextKittyButton_Click(object sender, EventArgs e)
        {
            int _currentIndex = CurrentIndex();
            string _status = new Kitty(BookList[_currentIndex + 1], true, true).Status();

            if (_active is not null)
            {
                if (Conversions.ToBoolean(_status == "InActive" && !((dynamic)_inActive).Checked || _status == "Availed" && !((dynamic)_availed).Checked || _status == "Cracked" && !((dynamic)_cracked).Checked || _status == "Matured" && !((dynamic)_matured).Checked || _status == "Partial" && !((dynamic)_active).Checked))
                {

                    _KittyID_Book = BookList[_currentIndex + 1];
                    NextKittyButton.PerformClick();
                    return;
                }
            }
            KittyIdTB.Text = BookList[_currentIndex + 1].ToString();
            UpdateBookModeIndexes();
        }

        private void PrevKittyButton_Click(object sender, EventArgs e)
        {
            int _currentIndex = CurrentIndex();
            string _status = new Kitty(BookList[_currentIndex - 1], true, true).Status();

            if (_active is not null)
            {
                if (Conversions.ToBoolean(_status == "InActive" && !((dynamic)_inActive).Checked || _status == "Availed" && !((dynamic)_availed).Checked || _status == "Cracked" && !((dynamic)_cracked).Checked || _status == "Matured" && !((dynamic)_matured).Checked || _status == "Partial" && !((dynamic)_active).Checked))
                {

                    _KittyID_Book = BookList[_currentIndex - 1];
                    PrevKittyButton.PerformClick();
                    return;
                }
            }
            KittyIdTB.Text = new Kitty(BookList[CurrentIndex() - 1]).KittyUID.ToString();
            UpdateBookModeIndexes();
        }

        private void JumpToKittyNoButton_Click(object sender, EventArgs e)
        {
            string EnteredKittyNo = Interaction.InputBox("Enter The New KittyNo To Which You Want To Jump To.", "Enter KittyNo");
            if (!Information.IsNumeric(EnteredKittyNo))
            {
                if (string.IsNullOrEmpty(EnteredKittyNo))
                    return;
                MessageBox.Show("KittyNo Must Be An Integer. Try Again", "Illegal Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                JumpToKittyNoButton_Click(sender, e);
                return;
            }
            foreach (var id in BookList)
            {
                var _tempKitty = new Kitty(id, InitializeKitty: true);
                if (_tempKitty.KittyNo == Conversions.ToDouble(EnteredKittyNo))
                {
                    KittyIdTB.Text = BookList[BookList.IndexOf(_tempKitty.KittyUID)].ToString();
                    UpdateBookModeIndexes();
                    return;
                }
            }
            string[] selectedTypes = (from _items in BookModeSelectedTypes.Items
                                      where _items.Checked == true
                                      select _items.Text).ToArray();

            MessageBox.Show($"There Is No Kitty Saved With KittyTypes-{string.Join(" OR ", selectedTypes)} And KittyNo-{EnteredKittyNo}. Try Selecting More KittyTypes Or Use Another KittyNo.", "No Result Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        #endregion

        private void ContextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            System.Data.OleDb.OleDbDataReader dr = (System.Data.OleDb.OleDbDataReader)ProjectModule.DataReader("SELECT * From Coustmers_Data");
            int SessionNo = -1;

            while (dr.Read())
            {
                try
                {
                    SessionNo = Conversions.ToInteger(dr["Review"].ToString().Split('_')[0]);
                    if (SessionNo <= 0)
                    {
                        SessionNo = -1;
                    }
                }
                catch (Exception ex)
                {
                }
                break;
            }

            if (SessionNo == -1)
            {
                Prev_SessionToolStripMenuItem.Visible = false;
            }
            else
            {
                Prev_SessionToolStripMenuItem.Visible = true;
                Prev_SessionToolStripMenuItem.Text = $"Prev_Sess: SessionID:{SessionNo}";
            }
        }

        private void Prev_SessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReviewMode = true;
            ReviewButton.Visible = true;
            if (ReviewMode)
            {
                System.Data.OleDb.OleDbDataReader dr = (System.Data.OleDb.OleDbDataReader)ProjectModule.DataReader($"Select Review From Coustmers_Data Where SrNo={_Customer.CustomerID}");
                while (dr.Read())
                {
                    try
                    {
                        if (dr["Review"].ToString().Split('_')[1] == "False")
                        {
                            _reviewed = false;
                        }
                        else
                        {
                            _reviewed = true;
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                }
                UpdateReview();
            }
        }

        private void StartNewReviewSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbDataReader dr = (System.Data.OleDb.OleDbDataReader)ProjectModule.DataReader("SELECT * From Coustmers_Data");
            int SessionNo = -1;

            while (dr.Read())
            {
                try
                {
                    SessionNo = Conversions.ToInteger(dr["Review"].ToString().Split('_')[0]);
                    if (SessionNo <= 0)
                    {
                        SessionNo = -1;
                    }
                }
                catch (Exception ex)
                {
                }
                break;
            }
            if (SessionNo != -1)
            {
                ProjectModule.SqlCommand($"UPDATE Coustmers_Data set Review='{SessionNo + 1}_False'");
            }
            else
            {
                ProjectModule.SqlCommand($"UPDATE Coustmers_Data set Review='1_False'");
            }
        }

        private void IconButton1_Click(object sender, EventArgs e)
        {
            if (ReviewMode)
            {
                _reviewed = !_reviewed;
                UpdateReview();
            }
        }

        public void UpdateReview()
        {
            System.Data.OleDb.OleDbDataReader dr = (System.Data.OleDb.OleDbDataReader)ProjectModule.DataReader("SELECT * From Coustmers_Data");
            int SessionNo = -1;

            while (dr.Read())
            {
                try
                {
                    SessionNo = Conversions.ToInteger(dr["Review"].ToString().Split('_')[0]);
                    if (SessionNo <= 0)
                    {
                        SessionNo = -1;
                    }
                }
                catch (Exception ex)
                {
                }
                break;
            }

            if (SessionNo == -1)
                return;

            if (_reviewed)
            {
                ReviewButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
                ReviewButton.IconColor = Color.Gold;
                ProjectModule.SqlCommand($"UPDATE Coustmers_Data set Review='{SessionNo}_True' WHERE SrNo={_Customer.CustomerID}");
            }
            else
            {
                ReviewButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
                ReviewButton.IconColor = Color.MediumPurple;
                ProjectModule.SqlCommand($"UPDATE Coustmers_Data set Review='{SessionNo}_False' WHERE SrNo={_Customer.CustomerID}");
            }
        }

        private void DotsButton_Click(object sender, EventArgs e)
        {

            if (BookModeSelectedTypes.Visible)
            {
                BookModeSelectedTypes.Hide();
                return;
            }

            var _alreadyAddedTypes = new List<int>();

            // Collecting Already Added Items To The MenuStrip
            foreach (ToolStripMenuItem i in BookModeSelectedTypes.Items)
                _alreadyAddedTypes.Add(Conversions.ToInteger(i.Text));

            // Adding All The Types That Are Not Already Added
            foreach (var i in Kitty.GetListOfKittyTypes())
            {
                if (_alreadyAddedTypes.Contains(i))
                {
                    _alreadyAddedTypes.Remove(i);
                    continue;
                }
                var x = new ToolStripMenuItem()
                {
                    Checked = true,
                    CheckOnClick = true,
                    Text = i.ToString()
                };
                BookModeSelectedTypes.Items.Add(x);

                x.CheckedChanged += (_sender, _e) =>
                    {
                        int _count = (from _items in BookModeSelectedTypes.Items
                                      where _items.Checked == true
                                      select _items).Count();
                        if (_count == 0)
                        {
                            _sender.Checked = true;
                            return;
                        }
                        BookModeSelectedTypes.Show(DotsButton, 0, DotsButton.Size.Height);
                        if (BookMode)
                        {
                            ShowBook();
                        }
                    };

            }

            // Removing Items That Are Not In ListOfKittyTypes
            foreach (var i in _alreadyAddedTypes)
            {

                var x = from _items in BookModeSelectedTypes.Items
                        where Conversions.ToDouble(_items.Text) == (double)i
                        select _items;

                if (x.Count() > 0)
                {
                    BookModeSelectedTypes.Items.Remove(x.ElementAtOrDefault(0));
                }
            }

            BookModeSelectedTypes.Show(DotsButton, 0, DotsButton.Size.Height);
        }

        private void ContextMenuStrip2_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void IconPictureBox1_Click(object sender, EventArgs e)
        {
            if (ContextMenuStrip2.Visible)
            {
                ContextMenuStrip2.Hide();
            }

            if (ContextMenuStrip2.Items.Count == 0)
            {
                foreach (var i in new List<string>(new[] { "Active", "InActive", "Availed", "Cracked", "Matured" }))
                {
                    var x = new ToolStripMenuItem()
                    {
                        Checked = true,
                        CheckOnClick = true,
                        Text = i,
                        Name = $"{i}BookCB"
                    };
                    ContextMenuStrip2.Items.Add(x);
                    x.CheckedChanged += (ToolStripMenuItem _sender, EventArgs _e) =>
                        {
                            ContextMenuStrip2.Show(IconPictureBox1, 0, IconPictureBox1.Size.Height);
                            if (BookMode)
                            {
                                ShowBook();
                            }
                        };
                }
                {
                    var withBlock = ContextMenuStrip2.Items;
                    _active = withBlock[withBlock.IndexOfKey("ActiveBookCB")];
                    _inActive = withBlock[withBlock.IndexOfKey("InActiveBookCB")];
                    _availed = withBlock[withBlock.IndexOfKey("AvailedBookCB")];
                    _cracked = withBlock[withBlock.IndexOfKey("CrackedBookCB")];
                    _matured = withBlock[withBlock.IndexOfKey("MaturedBookCB")];
                }

            }

            ContextMenuStrip2.Show(IconPictureBox1, 0, IconPictureBox1.Size.Height);
        }

        private void CoustProfileUpdated_Load(object sender, EventArgs e) => CoustProfileUpdated_Load();
        private void KittyPanel_ControlAdded(object sender, ControlEventArgs e) => KittyPanel_ControlAdded();
    }
}