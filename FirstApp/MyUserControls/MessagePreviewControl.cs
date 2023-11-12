using System;
using System.Drawing;

namespace FirstApp
{
    public partial class MessagePreviewControl
    {

        private string _status = "NotSent";
        private bool _enabled = true;
        private int _srno = -1;



        public new bool Enabled
        {
            get
            {
                return _enabled;
            }
            set
            {
                if (value)
                {
                    Panel1.Enabled = true;
                    Label1.Enabled = true;
                    CloseButton.BackColor = Color.FromArgb(65, 0, 0);
                    CloseButton.FlatAppearance.MouseDownBackColor = Color.Red;
                    CloseButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 0, 0);
                    CloseButton.IconChar = FontAwesome.Sharp.IconChar.Times;
                }
                else
                {
                    Panel1.Enabled = false;
                    Label1.Enabled = false;
                    CloseButton.BackColor = Color.FromArgb(0, 65, 0);
                    CloseButton.FlatAppearance.MouseDownBackColor = Color.Green;
                    CloseButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 90, 0);
                    CloseButton.IconChar = FontAwesome.Sharp.IconChar.Check;
                }
                _enabled = value;
            }
        }

        public string Status
        {
            get
            {
                return _status;
            }
            set
            {
                if (value == "NotSent")
                    return;

                StatusLB.Visible = true;
                switch (value ?? "")
                {
                    case "fail":
                        {
                            StatusLB.Text = $"+91{PhNo}: Failed";
                            StatusLB.ForeColor = Color.Red;
                            SendBT.Text = "Retry";
                            SendBT.IconChar = FontAwesome.Sharp.IconChar.RedoAlt;
                            SendBT.Enabled = true;
                            break;
                        }
                    case "Sending":
                        {
                            StatusLB.Text = $"+91{PhNo}: Sending..";
                            StatusLB.ForeColor = Color.Goldenrod;
                            SendBT.Text = "Wait";
                            SendBT.IconChar = FontAwesome.Sharp.IconChar.Spinner;
                            SendBT.Enabled = false;
                            break;
                        }
                    case "pass":
                        {
                            StatusLB.Text = $"+91{PhNo}: Sent";
                            StatusLB.ForeColor = Color.Green;
                            SendBT.Text = "Done";
                            SendBT.IconChar = FontAwesome.Sharp.IconChar.Check;
                            SendBT.Enabled = false;
                            break;
                        }

                    default:
                        {
                            StatusLB.Text = $"+91{PhNo}: {value}";
                            StatusLB.ForeColor = Color.Red;
                            SendBT.Text = "Retry";
                            SendBT.IconChar = FontAwesome.Sharp.IconChar.RedoAlt;
                            SendBT.Enabled = true;
                            break;
                        }
                }
                _status = value;
            }
        }

        public string PhNo { get; set; }

        public string PreviewText
        {
            set
            {
                Label1.Text = value;
                if (Label1.Width > Width)
                {
                    Size = new Size(Label1.Width, Height);
                }
                if (Label1.Height > Height)
                {
                    Size = new Size(Width, Label1.Height + Height);
                }
            }
        }

        public int SrNo
        {
            set
            {
                _srno = value;
                SrNoLB.Text = $"#{value}";
            }
            get
            {
                return _srno;
            }
        }

        public Kitty CurrentKitty { get; set; }

        public event DetailsButton_ClickedEventHandler DetailsButton_Clicked;

        public delegate void DetailsButton_ClickedEventHandler(MessagePreviewControl sender);

        public MessagePreviewControl()
        {
            InitializeComponent();
        }

        private void DetailsButton_Click(object sender, EventArgs e)
        {
            DetailsButton_Clicked?.Invoke(this);
        }

        public event CloseBT_ClickedEventHandler CloseBT_Clicked;

        public delegate void CloseBT_ClickedEventHandler(MessagePreviewControl sender);

        private void CloseButton_Click(object sender, EventArgs e)
        {
            CloseBT_Clicked?.Invoke(this);
        }

        public event SendBT_ClickedEventHandler SendBT_Clicked;

        public delegate void SendBT_ClickedEventHandler(MessagePreviewControl sender);

        private void SendBT_Click(object sender, EventArgs e)
        {
            SendBT_Clicked?.Invoke(this);
        }

        public event TestMessageClickedEventHandler TestMessageClicked;

        public delegate void TestMessageClickedEventHandler(MessagePreviewControl sender);

        private void IconButton1_Click(object sender, EventArgs e)
        {
            TestMessageClicked?.Invoke(this);
        }
    }
}