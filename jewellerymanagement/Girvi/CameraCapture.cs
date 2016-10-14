using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace JewelleryManagement.Girvi
{
    public partial class CameraCapture : Form
    {
        private FilterInfoCollection WebCam;
        private VideoCaptureDevice Cam;

        public string ProfilePic, Document1, Documennt2, Document3, KhatawanoNo;

        public CameraCapture()
        {
            InitializeComponent();
        }

        public CameraCapture(string KhatawaniNumber)
        {
            InitializeComponent();
            KhatawanoNo = KhatawaniNumber;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            WebCam = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo videoCaptureDevice in WebCam)
            {
                cmbCameraDevice.Items.Add(videoCaptureDevice.Name);
            }
            cmbCameraDevice.SelectedIndex = 0;
        
        }

        private void bttn_SaveProfilePic_Click(object sender, EventArgs e)
        {
            StopCamera();
            pictureBox1.Image.Save(Environment.CurrentDirectory + "\\Images\\ProfileKhatawaniNo_" + KhatawanoNo + ".jpeg");
            ProfilePic = "ProfileKhatawaniNo_" + KhatawanoNo + ".jpeg";
            DialogResult drReportPrint = MessageBox.Show("Photo Saved");
       
        }

        public void Cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bit = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = bit;
        }



        private void bttn_Start_Click(object sender, EventArgs e)
        {
            startCamera();
        }

        private void startCamera()
        {
            Cam = new VideoCaptureDevice(WebCam[cmbCameraDevice.SelectedIndex].MonikerString);
            Cam.NewFrame += new NewFrameEventHandler(Cam_NewFrame);
            Cam.Start();
        }

        private void bttn_capture_Click(object sender, EventArgs e)
        {
            StopCamera();
            DialogResult drReportPrint = MessageBox.Show("Photo Capture");
        }

        private void StopCamera()
        {
            if (Cam.IsRunning)
            {
                Cam.Stop();
            
                Cam.WaitForStop();
            }
        }

        private void bttn_SaveDoc1_Click(object sender, EventArgs e)
        {
           
            StopCamera();
            pictureBox1.Image.Save(Environment.CurrentDirectory + "\\Images\\Document1KhatawaniNo_" + KhatawanoNo + ".jpeg");
            Document1 = "Document1KhatawaniNo_" + KhatawanoNo + ".jpeg";
            DialogResult drReportPrint = MessageBox.Show("Document1 Uploaded");
            startCamera();
        }

        private void bttn_SaveDoc2_Click(object sender, EventArgs e)
        {
            StopCamera();
            pictureBox1.Image.Save(Environment.CurrentDirectory + "\\Images\\Documennt2KhatawaniNo_" + KhatawanoNo + ".jpeg");
            Documennt2 = "Documennt2KhatawaniNo_" + KhatawanoNo + ".jpeg";
            DialogResult drReportPrint = MessageBox.Show("Document2 Uploaded");
            startCamera();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StopCamera();
            pictureBox1.Image.Save(Environment.CurrentDirectory + "\\Images\\Document3KhatawaniNo_" + KhatawanoNo + ".jpeg");
            Document3 = "Document3KhatawaniNo_" + KhatawanoNo + ".jpeg";
            DialogResult drReportPrint = MessageBox.Show("Document2 Uploaded");
            startCamera();
        }

        private void bttn_Stop_Click(object sender, EventArgs e)
        {
            StopCamera();
        }


    }
}
