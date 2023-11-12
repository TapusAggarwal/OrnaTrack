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

    public partial class CoustProfileUpdated
    {

        protected Customer _currentCustomer = null;

        public CoustProfileUpdated()
        {
            CreateHandle();
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
        }

        private void CustomerProfile_Load(object sender, EventArgs e)
        {
            LoadComboBoxData(ProfessionCB, Customer.ListOfProfessions());
            LoadComboBoxData(RegionCB, Customer.ListOfRegions());
            KeyPreview = true;

            if (Tag is not null)
            {
                CustomerIdTB.Text = Tag.ToString().Split('_')[0];
                ImageBox.Select();
            }
        }

        public void LoadProfileData(Customer _customer)
        {
            NameTB.Text = _customer.FirstName();
            SirNameTB.Text = _customer.LastName();
            PhoneNoTag1.TagData = _customer.PhNo(",");
            ProfessionCB.SelectedIndex = ProfessionCB.FindStringExact(_customer.Profession());
            RegionCB.SelectedIndex = RegionCB.FindStringExact(_customer.Region());
            AddressTB.Text = _customer.Address();
            Adhaar.Text = _customer.AdhaarNumber();
            if (_customer.IsMarried())
                MarriedCheckBox.Checked = true;
            else
                MarriedCheckBox.Checked = false;
            if (_customer.Gender() == "Male")
            {
                MaleRB.Checked = true;
            }
            else if (_customer.Gender() == "Female")
            {
                FemaleRB.Checked = true;
            }
            else
            {
                MaleRB.Checked = false;
                FemaleRB.Checked = false;
            }
            NotesTB.Text = _customer.Description();
            // CheckRegistrationButton_Click(CheckRegistrationButton, EventArgs.Empty)
        }

        private void CustomerIdTB_TextChanged(TextBox sender, EventArgs e)
        {
            if (!(sender.TextLength == 0))
            {
                _currentCustomer = new Customer(Conversions.ToInteger(sender.Text));
                LoadProfileData(_currentCustomer);
                CheckForSimilarPhNo();
            }
        }


        private void SaveCoustmerButton_Click(object sender, EventArgs e)
        {
            SaveCoustmerButton.Select();
            if (NameTB.TextLength == 0)
            {
                MessageBox.Show("You Have To Enter Name Of The Coustmer To Add New Coustmer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_currentCustomer is not null)
            {
                if (MessageBox.Show("Do You Want To Update Changes Made To Customer Data ?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
                _currentCustomer.UpdatedFirstName = NameTB.Text;
                _currentCustomer.UpdatedLastName = SirNameTB.Text;
                _currentCustomer.UpdatedPhNo = PhoneNoTag1.TagData;
                _currentCustomer.UpdatedProfession = Conversions.ToString(ProfessionCB.SelectedItem);
                _currentCustomer.UpdatedRegion = Conversions.ToString(RegionCB.SelectedItem);
                _currentCustomer.UpdatedAddress = AddressTB.Text;


                foreach (var i in Adhaar.Text)
                {
                    if (!char.IsDigit(i))
                    {
                        MessageBox.Show("Adhaar Number Should Only Contain Numbers. No Alphabets Allowed!!", "Invalid Input", MessageBoxButtons.OK);
                        return;
                    }
                }

                if (!(Adhaar.TextLength == 12) & !(Adhaar.TextLength == 0))
                {
                    MessageBox.Show("Adhaar Number Should Only Be 12 Digits Long.", "Invalid Input", MessageBoxButtons.OK);
                    return;
                }

                _currentCustomer.UpdatedAdhaarNumber = Adhaar.Text;


                if (MarriedCheckBox.Checked)
                    _currentCustomer.UpdatedMarriedStatus = "True";
                else
                    _currentCustomer.UpdatedMarriedStatus = "False";
                if (MaleRB.Checked)
                {
                    _currentCustomer.UpdatedGender = "Male";
                }
                else if (FemaleRB.Checked)
                {
                    _currentCustomer.UpdatedGender = "Female";
                }
                _currentCustomer.UpdatedDescription = NotesTB.Text;
            }
            else
            {
                string _Married;
                string _gender = "";
                if (MaleRB.Checked)
                {
                    _gender = "Male";
                }
                else if (FemaleRB.Checked)
                {
                    _gender = "Female";
                }



                if (MarriedCheckBox.Checked)
                    _Married = "True";
                else
                    _Married = "False";
                if (MessageBox.Show("Do You Want To Save New Member To Customer Data ?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
                ProjectModule.SqlCommand($"INSERT INTO Coustmers_Data (CName,CsName,PhNo,Prof,Region,Address,Gender,Mry,dscrp)" + $"VALUES('{NameTB.Text.Trim()}','{SirNameTB.Text.Trim()}','{PhoneNoTag1.TagData}','{ProfessionCB.SelectedItem}','{RegionCB.SelectedItem}','{AddressTB.Text}','{_gender}','{_Married}','{NotesTB.Text.Trim()}')");

                try
                {
                    System.Data.OleDb.OleDbDataReader dr = (System.Data.OleDb.OleDbDataReader)ProjectModule.DataReader("Select max(SrNo) From Coustmers_Data");
                    while (dr.Read())
                    {
                        int _temp = Conversions.ToInteger(dr[0]);
                        CustomerIdTB.Text = _temp.ToString();
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }

        private void DeleteCoustmerButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer is null)
            {
                MessageBox.Show("Can't Delete Customer That Does Not Exist!", "Illegal Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _currentCustomer.DeleteCustomer();
                Close();
            }
        }

        private void KittyDetailsButton_Click(object sender, EventArgs e)
        {
            var Fm = new KittyView() { Tag = _currentCustomer };
            Fm.ShowDetailsClicked += (_kitty) =>
                {
                    var KittyForm_Fm = new KittyForm() { Tag = _kitty };
                    KittyForm_Fm.ShowDialog();
                    Fm.LoadKittyData(Fm.DgvMain);
                };
            Fm.Show();
        }

        private void CheckForSimilarPhNo()
        {
            ExistingPhNosButton.Visible = false;
            var x = Customer.SharedPhNo(PhoneNoTag1.TagData.Split(','));
            if (x.Count > 1)
            {
                ExistingPhNosButton.Visible = true;
            }
            else if (x.Count == 1)
            {
                if (_currentCustomer is null || Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(x.First(), _currentCustomer.CustomerID, false)))
                {
                    ExistingPhNosButton.Visible = true;
                }
            }
            else
            {
            }
        }

        private void ExistingPhNosButton_Click(object sender, EventArgs e)
        {
            var Fm = new DgvForExistingPhno()
            {
                CurrentPhNo = (from _phno in PhoneNoTag1.TagData.Split(',')
                               select _phno.Trim()).ToArray(),
                ShowInTaskbar = false
            };
            if (_currentCustomer is not null)
                Fm.CurrentCustomer = _currentCustomer;
            Fm.ShowDialog();
            if (Fm.SelectedCustomer >= 0)
            {
                CustomerIdTB.Text = Fm.SelectedCustomer.ToString();
            }
        }

        #region Convenience Wrapper

        // TextBox Colour -> GoldenRod | When Got Focus
        private void TB_GotFocus(TextBox sender, EventArgs e)
        {
            sender.BackColor = Color.Goldenrod;
        }

        // TextBox Colour -> White | When Lost Focus
        private void TB_LostFocus(TextBox Sender, EventArgs e)
        {
            Sender.BackColor = Color.White;
            try
            {
                Sender.Text = Conversions.ToString(Strings.UCase(Sender.Text[0])) + Sender.Text.Substring(1, Sender.TextLength - 1);
            }
            catch
            {
            }
        }

        // Select -> Previous TabIndex | When Up Key Pressed On PhoneNoTag
        private void PhoneNoTag1_UP_keyPressed()
        {
            SendKeys.Send("+{Tab}");
        }

        // Select -> Next TabIndex | When Down Key Pressed On PhoneNoTag
        private void PhoneNoTag1_DOWN_keyPressed()
        {
            SendKeys.Send("{Tab}");
        }

        // KeyDown -> MyBase Key Combination | Shortcut Keys Pressed In Form
        private void CustomerProfile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control & e.KeyCode == Keys.S)
            {
                SaveCoustmerButton_Click(SaveCoustmerButton, EventArgs.Empty);
                // ElseIf (e.Control And e.KeyCode = Keys.K) And LedgerPanel.Visible Then
                // AddKittyButton_Click()
                // ElseIf (e.Control And e.KeyCode = Keys.U) And LedgerPanel.Visible Then
                // AddUdhariButton_Click()
                // ElseIf e.Control And e.KeyCode = Keys.I Then
                // ShowCoustmerID()
                // ElseIf e.Control And e.KeyCode = Keys.D Then
                // DeleteCoustmerButton_Click()
            }
        }

        private void TB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down | e.KeyCode == Keys.Enter)
            {
                try
                {
                    ((dynamic)sender).Text = Operators.AddObject(UCase(((dynamic)sender).Text(0)), ((dynamic)sender).Text.Substring(1, Operators.SubtractObject(((dynamic)sender).TextLength, 1)));
                }
                catch
                {
                }
                SendKeys.Send("{Tab}");
            }
            else if (e.KeyCode == Keys.Up)
            {
                try
                {
                    ((dynamic)sender).Text = Operators.AddObject(UCase(((dynamic)sender).Text(0)), ((dynamic)sender).Text.Substring(1, Operators.SubtractObject(((dynamic)sender).TextLength, 1)));
                }
                catch
                {
                }
                SendKeys.Send("+{Tab}");
            }
        }

        private void IconButton2_Click(object sender, EventArgs e)
        {
            foreach (Form ExistingFm in My.MyProject.Forms.Frame.MdiChildren)
            {
                if (ExistingFm.Name != "Main")
                {
                    var Fm = new KittyModeCoustView()
                    {
                        MdiParent = My.MyProject.MyForms.Frame,
                        Tag = _currentCustomer.CustomerID,
                        Dock = DockStyle.Fill
                    };
                    Fm.Show();
                    ExistingFm.Dispose();
                }
            }
        }

        private void AddKittyButton_Click(object sender, EventArgs e)
        {
            var _tempKitty = new Kitty() { CustomerID = Conversions.ToInteger(_currentCustomer.CustomerID) };
            var KittyForm_Fm = new KittyForm() { Tag = _tempKitty };
            KittyForm_Fm.ShowDialog();
        }

        private void CheckRegistrationButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PhoneNoTag1.TagData))
            {
                MessageBox.Show("First Add Numbers To Check Validity Of Numbers.", "Server Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            PhoneNoTag1.CheckRegistration();
        }

        private void ProfessionCB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e.Modifiers == Keys.Shift) // SHIFT + ENTER
            {
                var Rtrn_Data = new List<string>() { "Profession", "Profession", "Add Profession" };
                My.MyProject.Forms.CBoxForm.Tag = Rtrn_Data;
                My.MyProject.Forms.CBoxForm.ShowDialog();
                LoadComboBoxData(ProfessionCB, Customer.ListOfProfessions());
                return;
            }

            if (e.KeyCode == Keys.Enter) // ENTER CLICK
            {
                SendKeys.Send("{Tab}");
                return;
            }
        }

        private void RegionCB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e.Modifiers == Keys.Shift) // Enter
            {
                var Rtrn_Data = new List<string>() { "Region", "Region", "Add Region" };
                My.MyProject.Forms.CBoxForm.Tag = Rtrn_Data;
                My.MyProject.Forms.CBoxForm.ShowDialog();
                LoadComboBoxData(RegionCB, Customer.ListOfRegions());
                return;
            }

            if (e.KeyCode == Keys.Enter) // ENTER
            {
                SendKeys.Send("{Tab}");
                return;
            }
        }

        private void TB_GotFocus(object sender, EventArgs e)
        {

        }

        private void TB_LostFocus(object sender, EventArgs e)
        {

        }

        #endregion

    }
}