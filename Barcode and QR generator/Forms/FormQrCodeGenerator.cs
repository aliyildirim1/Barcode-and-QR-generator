using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;
using ZXing;

namespace Barcode_and_QR_generator.Forms
{
    public partial class FormQrCodeGenerator : Form
    {
        public FormQrCodeGenerator()
        {
            InitializeComponent();
        }

        private void btnGenerateQr_Click(object sender, EventArgs e)
        {

            string qrData = tbxQrImageData.Text;
            //string qrImageFileName = tbxQrImageFileName.Text;

            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(qrData, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            pictureBox1.Image = code.GetGraphic(30);
            

            /*
            //Create barcode writer object
            BarcodeWriter<Bitmap> barcodeW = new BarcodeWriter<Bitmap>();
             
             //Specify barcode format -->QR
             barcodeW.Format = BarcodeFormat.QR_CODE;
            //Burn data into qr image and save image to specified location with a specified name
            
             barcodeW.Write(qrData).Save(@"C:\qr\" + qrImageFileName + ".png");
             //get image back into the picturebox
             pictureBox1.Image=Image.FromFile(@"C:\qr\" + qrImageFileName + ".png");

            
             
             */
        }
    }
}
