using System;
using System.Collections;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FirstApp
{
    public partial class Main
    {
        private const int MaxLimit = 6;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            NameTB.Select();
        }

        private async void ShowResults(int Limit)
        {
            object T_List = null;

            int[] newSearchRecord = null;

            string InitalName = NameTB.Text;
            string InitalPhNo = PhNoTB.Text.Replace("'", "");
            string InitalKittyNo = KittyNoTB.Text.Replace("'", "");

            if (Conversions.ToBoolean(NameTB.TextLength))
            {
                newSearchRecord = Customer.SearchByName(InitalName);
                KittyNoTB.Clear();
                PhNoTB.Clear();
            }
            else if (Conversions.ToBoolean(PhNoTB.TextLength))
            {
                newSearchRecord = Customer.SearchByPhNo(InitalPhNo);
            }
            else if (Conversions.ToBoolean(KittyNoTB.TextLength))
            {
                KittyMode1.Checked = true;
                T_List = Customer.ListOF_KittyModeControl(IDs: Customer.SearchByKittyNo(InitalKittyNo, Limit), isKittyID: true);
            }

            if (newSearchRecord is null)
            {
                FlowLayoutPanel1.Controls.Clear();
                GC.Collect();
            }
            else if (!KittyMode1.Checked)
            {
                T_List = Customer.ListOF_ActiveKittyControl(IDs: newSearchRecord, MaxLimit: Limit);
            }
            else
            {
                T_List = Customer.ListOF_KittyModeControl(IDs: newSearchRecord, MaxLimit: Limit);
                if (T_List is null || Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(((dynamic)T_List).count, 0, false)))
                {
                    var _temp = Customer.ListOF_ActiveKittyControl(IDs: newSearchRecord, MaxLimit: Limit);
                    if (_temp is not null && _temp.Count > 0)
                    {
                        KittyMode1.Checked = false;
                        return;
                    }
                }
            }

            FlowLayoutPanel1.Controls.Clear();

            {
                ref var withBlock = ref this;
                withBlock.Cursor = Cursors.AppStarting;
                withBlock.Refresh();
            }

            if (Conversions.ToBoolean(T_List is not null && ((dynamic)T_List).Count))
            {
                var res = await Task.WhenAll(T_List);
                FlowLayoutPanel1.Visible = false;
                FlowLayoutPanel1.Controls.Clear();
                if ((NameTB.Text ?? "") == (InitalName ?? "") & (PhNoTB.Text ?? "") == (InitalPhNo ?? "") & (KittyNoTB.Text ?? "") == (InitalKittyNo ?? ""))
                {
                    int a = 0;
                    foreach (var i in (IEnumerable)res)
                    {
                        a += 1;
                        FlowLayoutPanel1.Controls.Add((Control)i);
                        try
                        {
                            KittyModeControl x = (KittyModeControl)i;
                            x.SrNo = a.ToString();
                            x.DetailsButton_Clicked += KittyNoControl_Clicked;
                        }
                        catch (Exception ex)
                        {
                            ActiveKittyControl x = (ActiveKittyControl)i;
                            x.SrNo = a.ToString();
                            x.DetailsButton_Clicked += (_) => this.KittyNoControl_Clicked();
                        }
                    }
                    FlowLayoutPanel1.Visible = true;
                    GC.Collect();
                    if (FlowLayoutPanel1.Controls.Count == 1)
                    {
                        foreach (var i in FlowLayoutPanel1.Controls)
                        {
                            try
                            {
                                ((dynamic)i).DetailsButton_Click();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
            }

            {
                ref var withBlock1 = ref this;
                withBlock1.Cursor = Cursors.Default;
                withBlock1.Refresh();
            }

        }

        private void KittyNoControl_Clicked(int CustomerID, int KittyID = -1)
        {
            foreach (Form ExistingFm in My.MyProject.Forms.Frame.MdiChildren)
            {
                if (ExistingFm.Name != "Main")
                {
                    ExistingFm.Dispose();
                }
            }

            if (KittyID != -1)
            {
                var Fm = new KittyModeCoustView()
                {
                    MdiParent = My.MyProject.MyForms.Frame,
                    Dock = DockStyle.Fill,
                    Tag = CustomerID.ToString()
                };
                Fm.Tag += "_" + KittyID.ToString();
                Fm.Show();
            }
            else
            {
                var Fm = new CoustProfileUpdated()
                {
                    MdiParent = My.MyProject.MyForms.Frame,
                    Dock = DockStyle.Fill,
                    Tag = CustomerID.ToString()
                };
                Fm.Show();
            }

        }

        private void SearchTextBoxes_TextChanged(TextBox sender, EventArgs e)
        {
            if (sender.TextLength == 0)
            {
                FlowLayoutPanel1.Controls.Clear();
                GC.Collect();
            }
            else
            {
                if (Conversions.ToString(sender.Text[0]) == "=")
                    return;
                ShowResults(6);
            }

        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(((dynamic)sender).TextLength, 0, false)))
                    return;
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(((dynamic)sender).Text(0), "=", false)))
                {
                    if (!Information.IsNumeric(((dynamic)sender).text.replace("=", "")))
                        return;
                    if (ReferenceEquals(sender, KittyNoTB))
                    {
                        var _kitty = new Kitty(Conversions.ToInteger(((dynamic)sender).text.replace("=", "")), true);
                        if (_kitty.KittyType == -1)
                        {
                            MessageBox.Show("Kitty ID Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        KittyNoControl_Clicked(_kitty.CustomerID, _kitty.KittyUID);
                    }
                    else if (ReferenceEquals(sender, NameTB))
                    {
                        var customer = new Customer(Conversions.ToInteger(((dynamic)sender).text.replace("=", "")));
                        if (customer.FirstName() is null)
                            return;
                        KittyNoControl_Clicked(Conversions.ToInteger(customer.CustomerID));
                    }
                }

                FindCoustmerButton_Click(FindCoustmerButton, e);
                return;
            }
            else if (e.KeyCode == Keys.Up)
            {
                SendKeys.Send("+{Tab}");
            }
            else if (e.KeyCode == Keys.Down)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void KittyNoTB_TextChanged(TextBox sender, EventArgs e)
        {
            if (sender.TextLength == 0)
                return;
            if (Conversions.ToString(sender.Text[0]) == "=")
                return;
            if (!Information.IsNumeric(sender.Text))
            {
                string temp_var = sender.Text;
                if (Conversions.ToBoolean(temp_var.Length))
                {
                    NameTB.Text = temp_var;
                    NameTB.Select();
                    SendKeys.Send("{End}");
                }
                sender.Clear();
            }
            else
            {
                NameTB.Clear();
                if (ReferenceEquals(sender, PhNoTB))
                {
                    KittyNoTB.Clear();
                }
                else
                {
                    PhNoTB.Clear();
                }
            }

        }

        private void FindCoustmerButton_Click(object sender, EventArgs e)
        {
            ShowResults(-1);
        }

        private void KittyMode1_CheckedChanged(object sender, EventArgs e)
        {
            FindCoustmerButton_Click(FindCoustmerButton, EventArgs.Empty);
            NameTB.Select();

        }

    }
}