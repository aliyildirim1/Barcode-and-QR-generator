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
            

            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(qrData, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);

            var bmp = code.GetGraphic(5);
            pictureBox1.Image = bmp;
            SaveQR(bmp);
            

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
        private void SaveQR(Bitmap bitmap)

        {
            string qrImageFileName = tbxQrImageFileName.Text;
            var directoryPath = Application.StartupPath + "\\Images";
            if(!Directory.Exists(directoryPath))
                Directory.CreateDirectory(directoryPath);

            var fileName =  qrImageFileName + ".jpg";
            fileName = directoryPath + "\\" + fileName;

            bitmap.Save(fileName,System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
