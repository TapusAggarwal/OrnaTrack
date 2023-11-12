using System;
using System.Drawing;
using Microsoft.VisualBasic.CompilerServices;

namespace FirstApp
{
    public partial class ActiveKittyControl
    {
        private string OrignalDate = "";
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

        public string ActiveKitty
        {
            get
            {
                return ActiveKittyParam.Text;
            }
            set
            {
                // If Value = 0 Then
                // NeverLabel.Visible = True
                // ActiveKittyLabel.Visible = False
                // ActiveKittyParam.Visible = False
                // Else
                ActiveKittyParam.Text = value;
                // End If
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

        public ActiveKittyControl()
        {
            InitializeComponent();
            DetailsButton = _DetailsButton;
            _DetailsButton.Name = "DetailsButton";
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public event DetailsButton_ClickedEventHandler DetailsButton_Clicked;

        public delegate void DetailsButton_ClickedEventHandler(int CustomerID);

        public void DetailsButton_Click()
        {
            DetailsButton_Clicked?.Invoke(Conversions.ToInteger(CoustID));
        }

        private void DetailsButton_Click(object sender, EventArgs e) => DetailsButton_Click();

    }
}