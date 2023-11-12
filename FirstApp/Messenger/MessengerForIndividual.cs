using System;
using System.Collections.Generic;
using System.Drawing;

namespace FirstApp
{
    public partial class MessengerForIndividual
    {

        public List<Kitty> SelectedKitties { get; set; } = new List<Kitty>();

        public MessengerForIndividual()
        {
            InitializeComponent();
        }

        private void MessengerForIndividual_Load(object sender, EventArgs e)
        {
            ProjectModule.InitaliseConnection();
            try
            {
                ProjectModule.myconnection.Open();
            }
            catch
            {
            }

            if (SelectedKitties.Count == 1)
            {
                if (SelectedKitties[0].GetInstalmentsPending() > 0)
                {
                    TemplateBT.PerformClick();
                }
                else
                {
                    ReceiptBT.PerformClick();
                }
            }
            else
            {
                ReceiptBT.PerformClick();
            }

        }

        private void ReceiptBT_Click(object sender, EventArgs e)
        {
            TemplateBT.IconColor = Color.White;
            ReceiptBT.IconColor = Color.Lime;
            var x = new RecieptMessenger()
            {
                ListOfKitties = SelectedKitties,
                TopMost = false,
                TopLevel = false
            };
            Panel1.Controls.Clear();
            Panel1.Controls.Add(x);
            x.Show();
        }

        private void TemplateBT_Click(object sender, EventArgs e)
        {
            ReceiptBT.IconColor = Color.White;
            TemplateBT.IconColor = Color.Lime;
            var x = new MessageAndImageSender()
            {
                SelectedKitties = SelectedKitties,
                TopMost = false,
                TopLevel = false
            };
            Panel1.Controls.Clear();
            Panel1.Controls.Add(x);
            x.Show();
        }
    }
}