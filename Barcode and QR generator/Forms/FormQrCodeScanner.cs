using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using AForge;


using AForge.Video.DirectShow;
using AForge.Video;
using ZXing;
using ZXing.Aztec;
using ZXing.Windows.Compatibility;

namespace Barcode_and_QR_generator.Forms
{
    public partial class FormQrCodeScanner : Form
    {
        public int islemdurumu = 0;
        private FilterInfoCollection videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);   
        private VideoCaptureDevice captureDevice=null;
        public int selected = 0;
        public int kamerabaslat = 0;



        public FormQrCodeScanner()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormQrCodeScanner_Load(object sender, EventArgs e)
        {
           
            foreach (FilterInfo filterInfo in videoDevices)
                comboBox_camera.Items.Add(filterInfo.Name);
            comboBox_camera.SelectedIndex = 0;
        }
        private void button_scan_Click(object sender, EventArgs e)
        {
            selected = comboBox_camera.SelectedIndex;
            if (islemdurumu == 0)
            {
                if (kamerabaslat > 0) return;
                try
                {
                    captureDevice = new VideoCaptureDevice(videoDevices[selected].MonikerString);
                    captureDevice.NewFrame += new NewFrameEventHandler(CaptureDevice_NewFrame);
                    captureDevice.Start(); kamerabaslat = 1;
                    timer1.Start();
                }
                catch
                {
                    MessageBox.Show("Restart The Program");
                    if (!(captureDevice == null))
                        if (captureDevice.IsRunning)
                        {
                            captureDevice.SignalToStop();
                            captureDevice = null;
                        }
                }
            }

            //captureDevice = new VideoCaptureDevice(filter[comboBox_camera.SelectedIndex].MonikerString);
            //captureDevice.NewFrame += new NewFrameEventHandler(CaptureDevice_NewFrame);
            //captureDevice.Start();

        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void FormQrCodeScanner_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                captureDevice.SignalToStop();
                captureDevice = null;
                if (!(captureDevice == null))
                {
                    captureDevice.Stop();
                    captureDevice = null;
                }
            }
            catch { }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {

                BarcodeReader reader = new BarcodeReader();
                //BarcodeReader barcode = new BarcodeReader();

                Result result = reader.Decode((Bitmap)pictureBox.Image);
                if (result != null)
                {
                    textBox_display.Text = result.ToString();
                    timer1.Stop();
                    
                }
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            try
            {
                captureDevice.SignalToStop();
                captureDevice = null;
                if (!(captureDevice == null))
                {
                    captureDevice.Stop();
                    captureDevice = null;
                }
            }
            catch { }
            Application.Exit();
        }
    }
}
