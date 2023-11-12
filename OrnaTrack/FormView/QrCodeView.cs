using System;
using Microsoft.VisualBasic.CompilerServices;
using QRCoder;

namespace FirstApp
{

    public partial class QrCodeView
    {
        public QrCodeView()
        {
            InitializeComponent();
        }
        private void QrCodeView_Load(object sender, EventArgs e)
        {
            if (Tag is not null)
            {
                QrNew(Conversions.ToString(Tag));
            }
        }

        public void QrNew(string qr)
        {
            QrBox.Image = null;
            var gen = new QRCodeGenerator();
            var data = gen.CreateQrCode(qr, QRCodeGenerator.ECCLevel.Q);
            var code = new QRCode(data);
            QrBox.Image = code.GetGraphic(10);
        }

    }
}