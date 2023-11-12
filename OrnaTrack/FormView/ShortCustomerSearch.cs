using System;
using System.Collections;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FirstApp
{
    public partial class ShortCustomerSearch
    {
        private const int MaxLimit = 6;
        public int HideCustomerID = -1;

        public ShortCustomerSearch()
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
            string InitalPhNo = PhNoTB.Text;
            string InitalKittyNo = KittyNoTB.Text;

            if (Conversions.ToBoolean(NameTB.TextLength))
            {
                newSearchRecord = Customer.SearchByName(NameTB.Text);
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

            if (Conversions.ToBoolean(T_List is not null && ((dynamic)T_List).Count))
            {
                var res = await Task.WhenAll(T_List);
                FlowLayoutPanel1.Visible = false;
                FlowLayoutPanel1.Controls.Clear();
                if ((NameTB.Text ?? "") == (InitalName ?? "") & (PhNoTB.Text ?? "") == (InitalPhNo ?? "") & (KittyNoTB.Text ?? "") == (InitalKittyNo ?? ""))
                {
                    foreach (var i in (IEnumerable)res)
                    {
                        FlowLayoutPanel1.Controls.Add((Control)i);
                        try
                        {
                            KittyModeControl x = (KittyModeControl)i;
                            x.DetailsButton_Clicked += ControlButton_Clicked;
                            x.DetailsButton.Text = "Select";
                            if (HideCustomerID != -1 && Conversions.ToDouble(x.CoustID) == HideCustomerID)
                            {
                                x.Enabled = false;
                            }
                        }
                        catch (Exception ex)
                        {
                            ActiveKittyControl x = (ActiveKittyControl)i;
                            x.DetailsButton_Clicked += (_) => this.ControlButton_Clicked();
                            x.DetailsButton.Text = "Select";
                            if (HideCustomerID != -1 && Conversions.ToDouble(x.CoustID) == HideCustomerID)
                            {
                                x.Enabled = false;
                            }
                        }
                    }
                    FlowLayoutPanel1.Visible = true;
                    GC.Collect();
                }
            }
        }

        public event CustomerClickedEventHandler CustomerClicked;

        public delegate void CustomerClickedEventHandler(int CustomerID, int KittyID);

        private void ControlButton_Clicked(int CustomerID, int KittyID = -1)
        {
            CustomerClicked?.Invoke(CustomerID, KittyID);
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
                ShowResults(6);
            }

        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
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