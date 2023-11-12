using System;
using System.Drawing;
using System.Linq;
using ZXing;

namespace FirstApp
{

    public partial class KittyRecievedReciept
    {

        public Kitty CurrentKitty { get; set; } = null;

        public DateTime RecieptDate
        {
            set
            {
                DateLB.Text = value.ToShortDateString();
            }
        }

        public int KittyNo
        {
            set
            {
                KittyNoLB.Text = value.ToString();
            }
        }

        public string CustomerName
        {
            set
            {
                NameLB.Text = value;
            }
        }

        public string PhNo
        {
            set
            {
                PhNoLB.Text = value;
            }
        }

        public int AmountBeforePayment
        {
            set
            {
                CashInWalletLB.Text = value.ToCurrency(AddSpace: true);
            }
        }

        public int AmountRecieved
        {
            set
            {
                RecievedLB.Text = value.ToCurrency(AddSpace: true);
            }
        }

        public int Total
        {
            set
            {
                TotalLB.Text = value.ToCurrency(AddSpace: true);
            }
        }

        public DateTime First_Month
        {
            set
            {
                FirstMonthLB.Text = $"{value:MMMM},{System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetYear(value)}";
            }
        }

        public DateTime CompletedTill_Month
        {
            set
            {
                CompletedTillLB.Text = $"{value:MMMM},{System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.GetYear(value)}";
            }
        }

        public int Status
        {
            set
            {
                if (value == -1)
                {
                    StatusLB.Text = "Matured";
                    StatusLB.ForeColor = Color.Goldenrod;
                }
                else if (value == 0)
                {
                    StatusLB.Text = "UpTo Date";
                    StatusLB.ForeColor = Color.MediumSeaGreen;
                }
                else if (value == 1)
                {
                    StatusLB.Text = "1 Instalment Pending.";
                }
                else
                {
                    StatusLB.Text = value + " Instalments Pending.";
                    StatusLB.ForeColor = Color.Firebrick;
                }
            }
        }

        public string BarCodeData
        {
            set
            {
                var writer = new BarcodeWriter() { Format = BarcodeFormat.CODABAR };
                Barcode.Image = writer.Write(value);
            }
        }

        public KittyRecievedReciept()
        {
            InitializeComponent();
        }

        public void Initialize()
        {
            {
                var withBlock = CurrentKitty;
                RecieptDate = withBlock.Record.Last().Key;
                KittyNo = withBlock.KittyNo;
                CustomerName = withBlock.Owner.FullName();
                PhNo = withBlock.Owner.PhNo(",");
                AmountRecieved = withBlock.Record.Last().Value;
                AmountBeforePayment = withBlock.GivenAmount() - withBlock.Record.Last().Value;
                Total = withBlock.GivenAmount();
                First_Month = withBlock.Record.First().Key;
                CompletedTill_Month = withBlock.Record.First().Key.AddMonths(withBlock.GetInstalmentsCompleted());
                Status = withBlock.GetInstalmentsPending();
                BarCodeData = $"{withBlock.KittyUID}000{withBlock.Owner.CustomerID}000{new Random(withBlock.GivenAmount()).Next()}";
            }
        }

    }
}