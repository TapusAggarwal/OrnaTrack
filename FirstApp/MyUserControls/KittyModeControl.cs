using System;
using System.Drawing;
using Microsoft.VisualBasic.CompilerServices;

namespace FirstApp
{
    public partial class KittyModeControl
    {

        private string ImagePath = "";

        public string CoustName
        {
            get
            {
                return NameParam.Text;
            }
            set
            {
                NameParam.Text = value;
            }
        }

        public string SrNo
        {
            get
            {
                return SrNoParam.Text.Split('#')[0];
            }
            set
            {
                SrNoParam.Text = "#" + value;
            }
        }

        public string PhNo
        {
            get
            {
                return PhNoParam.Text;
            }
            set
            {
                PhNoParam.Text = value;
            }
        }

        public string CoustID
        {
            get
            {
                return CoustmerIdParam.Text;
            }
            set
            {
                CoustmerIdParam.Text = value;
            }
        }

        public string KittyID
        {
            get
            {
                return KittyIDParam.Text;
            }
            set
            {
                KittyIDParam.Text = value;
            }
        }

        public string Status
        {
            get
            {
                return InstPendingParam.Text;
            }
            set
            {
                InstPendingParam.Text = value;
                if (value == "Availed" | value == "InActive" | value == "Cracked")
                {
                    InstPendingParam.ForeColor = Color.Gray;
                    KittyTypeParam.ForeColor = Color.Gray;
                    KittyNoParam.ForeColor = Color.Gray;
                }
                else if (value == "Matured")
                {
                    InstPendingParam.ForeColor = Color.Goldenrod;
                    KittyTypeParam.ForeColor = Color.Goldenrod;
                    KittyNoParam.ForeColor = Color.Goldenrod;
                }
                InstLeftParam.Visible = false;
            }
        }

        // -2 = Availed(Gray), -1 = Matured(Goldenrod), 0 = None Pending(Green), Rest = Pending(Red)
        public int InstalmentsPending
        {
            get
            {
                return Conversions.ToInteger(InstPendingParam.Text);
            }
            set
            {
                if (value == 0)
                {
                    InstPendingParam.Text = $"Pending: {value}";
                    InstPendingParam.ForeColor = Color.Green;
                    KittyTypeParam.ForeColor = Color.Green;
                    KittyNoParam.ForeColor = Color.Green;
                    InstLeftParam.ForeColor = Color.Green;
                }
                else
                {
                    InstPendingParam.Text = $"Pending: {value}";
                    InstPendingParam.ForeColor = Color.FromArgb(200, 0, 0);
                    KittyTypeParam.ForeColor = Color.FromArgb(200, 0, 0);
                    KittyNoParam.ForeColor = Color.FromArgb(200, 0, 0);
                    InstLeftParam.ForeColor = Color.FromArgb(200, 0, 0);
                }
            }
        }

        public int InstalmentsLeft
        {
            get
            {
                return Conversions.ToInteger(InstLeftParam.Text);
            }
            set
            {
                InstLeftParam.Text = $"Left: {value}";
            }
        }

        public string KittyType
        {
            get
            {
                return KittyTypeParam.Text;
            }
            set
            {
                KittyTypeParam.Text = value;
            }
        }

        public string KittyNo
        {
            get
            {
                return KittyNoParam.Text;
            }
            set
            {
                KittyNoParam.Text = Conversions.ToDouble(value) > 0d ? value : "";
            }
        }

        public string SetImage
        {
            get
            {
                return ImagePath;
            }
            set
            {
                try
                {
                    ImageParam.BackgroundImage = Image.FromFile(value);
                }
                catch (Exception ex)
                {
                }
                ImagePath = value;
            }
        }

        public event DetailsButton_ClickedEventHandler DetailsButton_Clicked;

        public delegate void DetailsButton_ClickedEventHandler(int CustomerId, int KittyID);

        public KittyModeControl()
        {
            InitializeComponent();
            DetailsButton = _DetailsButton;
            _DetailsButton.Name = "DetailsButton";
        }

        public void DetailsButton_Click()
        {
            DetailsButton_Clicked?.Invoke(Conversions.ToInteger(CoustID), Conversions.ToInteger(KittyID));
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void DetailsButton_Click(object sender, EventArgs e) => DetailsButton_Click();

    }
}