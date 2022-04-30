using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Video;
using ZXing;

namespace Barcode_and_QR_generator.Forms
{
    public partial class FormQrCodeScanner : Form
    {
        public FormQrCodeScanner()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        FilterInfoCollection filter;
        VideoCaptureDevice captureDevice;
        private void FormQrCodeScanner_Load(object sender, EventArgs e)
        {
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo filterInfo in filter)
                comboBox_camera.Items.Add(filterInfo.Name);
            comboBox_camera.SelectedIndex = 0;  
            
        }
        private void button_scan_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filter[comboBox_camera.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void FormQrCodeScanner_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(captureDevice.IsRunning)
                captureDevice.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pictureBox.Image != null)
            {

                var reader = new ZXing.Windows.Compatibility.BarcodeReader();
                //BarcodeReader barcode = new BarcodeReader();

                Result result = reader.Decode((Bitmap)pictureBox.Image);
                if(result != null)
                {
                    textBox_display.Text= result.ToString();
                    timer1.Stop();
                    if (captureDevice.IsRunning)
                        captureDevice.Stop();
                }
            }
        }

        
    }
}
