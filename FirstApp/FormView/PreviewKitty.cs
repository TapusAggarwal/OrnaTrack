using System;
using System.Drawing;
using System.Windows.Forms;
using static FirstApp.Utility;
using Microsoft.VisualBasic.CompilerServices;

namespace FirstApp
{

    public partial class PreviewKitty
    {

        public Kitty _kitty;
        private readonly CoustProfileUpdated FmProfile = new CoustProfileUpdated();
        private KittyForm _KittyForm;

        public PreviewKitty()
        {
            InitializeComponent();
        }

        // Loads A Form Given A Kitty
        public void ShowKittyForm()
        {
            Invoke(new Action(() =>
                {
                    _KittyForm = new KittyForm() { Tag = _kitty };
                    _KittyForm.DissolveButton.Enabled = false;
                    // _KittyForm.DeleteButton.Enabled = False
                    // _KittyForm.ResetButton.Enabled = False
                    // _KittyForm.SaveButton.Enabled = False
                    // _KittyForm.PaymentButton.Enabled = False
                    // _KittyForm.AvailButton.Enabled = False
                    // _KittyForm.DotsButton.Enabled = False
                    var Pnl = _KittyForm.MainPanel;
                    Pnl.Dock = DockStyle.Fill;
                    _KittyForm.Kitty_Load(_KittyForm, EventArgs.Empty);
                    KittyPanel.Controls.Add(Pnl);
                    _KittyForm.ReloadKittyView += () => ShowKittyForm();
                    KittyIdTB.Text = _kitty.KittyUID.ToString();
                }));
        }

        private void Me_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (_KittyForm is null)
                    return;
                if (e.Control & e.KeyCode == Keys.S)
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
            }
            catch
            {
            }
        }

        private void PreviewKitty_Load(object sender, EventArgs e)
        {
            try
            {
                KeyPreview = true;
                var pnl = FmProfile.ProfilePanel;
                pnl.Dock = DockStyle.Fill;
                pnl.BackColor = Color.FromArgb(36, 30, 60);
                Panel1.Controls.Add(pnl);
                LoadComboBoxData(FmProfile.ProfessionCB, Customer.ListOfProfessions());
                LoadComboBoxData(FmProfile.RegionCB, Customer.ListOfRegions());
                FmProfile.LoadProfileData(_customer: _kitty.Owner);
                ShowKittyForm();
            }
            catch (Exception ex)
            {
            }
        }

        private void SaveCoustmerButton_Click(object sender, EventArgs e)
        {
            SaveCoustmerButton.Select();
            if (_kitty.Owner is not null)
            {
                if (MessageBox.Show("Do You Want To Update Changes Made To Customer Data ?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
                if (FmProfile.NameTB.TextLength == 0)
                {
                    MessageBox.Show("You Have To Enter Name Of The Coustmer To Add New Coustmer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                {
                    ref var withBlock = ref this.FmProfile;
                    _kitty.Owner.UpdatedFirstName = withBlock.NameTB.Text;
                    _kitty.Owner.UpdatedLastName = withBlock.SirNameTB.Text;
                    _kitty.Owner.UpdatedPhNo = withBlock.PhoneNoTag1.TagData;
                    _kitty.Owner.UpdatedProfession = Conversions.ToString(withBlock.ProfessionCB.SelectedItem);
                    _kitty.Owner.UpdatedRegion = Conversions.ToString(withBlock.RegionCB.SelectedItem);
                    _kitty.Owner.UpdatedAddress = withBlock.AddressTB.Text;
                    if (withBlock.MarriedCheckBox.Checked)
                        _kitty.Owner.UpdatedMarriedStatus = "True";
                    else
                        _kitty.Owner.UpdatedMarriedStatus = "False";
                    if (withBlock.MaleRB.Checked)
                    {
                        _kitty.Owner.UpdatedGender = "Male";
                    }
                    else if (withBlock.FemaleRB.Checked)
                    {
                        _kitty.Owner.UpdatedGender = "Female";
                    }
                }
            }
        }

        private void AllKittiesBT_Click(object sender, EventArgs e)
        {
            var Fm = new KittyView() { Tag = _kitty.Owner };
            Fm.ShowDetailsClicked += (_kitty) =>
                {
                    var KittyForm_Fm = new KittyForm() { Tag = _kitty };
                    KittyForm_Fm.ShowDialog();
                    Fm.LoadKittyData(Fm.DgvMain);
                };
            Fm.Show();
        }
    }
}