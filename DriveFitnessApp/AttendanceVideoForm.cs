using DriveFitnessLibrary.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DriveFitnessLibrary;
using AForge.Video.DirectShow;
using ZXing;

namespace DriveFitnessApp
{
    public partial class AttendanceVideoForm : Form, IAttendanceView
    {
        public AttendanceVideoForm()
        {
            InitializeComponent();
            pbWebCam.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public DateTime DateVisit { get { return dateTimePicker1.Value; } }

        public float Price { get { return (float)numericUpDown1.Value; } }

        public event EventHandler VisitationChecked;
        public event EventHandler FormLoaded;

        List<Group> groupList;
        string scannedQr;

        public void DisplayGroups(List<Group> group)
        {
            groupList = group;
        }

        public Client GetClient()
        {
            string s = scannedQr.Split(':')[0];

            foreach (var g in groupList)
            {
                foreach (var c in g.ClientsList)
                {
                    if (c.ID == int.Parse(s))
                        return c;
                }
            }

            return null;
        }

        private void AttendanceVideoForm_Load(object sender, EventArgs e)
        {
            if (FormLoaded != null)
                FormLoaded(this, EventArgs.Empty);

            isStarted = false;
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            reader = new BarcodeReader();
            reader.Options.PossibleFormats = new List<BarcodeFormat>() { BarcodeFormat.QR_CODE };
            //reader.Options.PossibleFormats.Add(BarcodeFormat.QR_CODE);

            if (videoDevices.Count > 0)
            {
                foreach (FilterInfo d in videoDevices)
                {
                    lbDevices.Items.Add(d.Name);
                }
                lbDevices.SelectedIndex = 0;
            }
        }

        FilterInfoCollection videoDevices;
        VideoCaptureDevice videoSource;
        BarcodeReader reader;
        bool isStarted;
        
        delegate void SetStringDelegate(string parameter);

        void SetResult(string result)
        {
            if (!InvokeRequired)
                txbResult.Text = result;
            else
                Invoke(new SetStringDelegate(SetResult), new object[] { result });
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (!isStarted)
            {
                if (lbDevices.Items.Count > 0)
                {
                    StartScan();
                }
                else
                    MessageBox.Show(string.Format("К компьютеру не подключена Web-камера.{0}{0}Пожалуйста подключите Web-камеру и перезагрузите окно программы",
                        Environment.NewLine
                        ),
                        "Ошибка подключение Web-камеры", MessageBoxButtons.OK, MessageBoxIcon.Error
                        );
            }
            else
            {
                StopScan();
            }
        }

        private void VideoSource_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {

            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();

            pbWebCam.Image = bitmap;

            Result result = reader.Decode((Bitmap)eventArgs.Frame.Clone());

            if (result != null)
            {
                SetResult(result.Text);
                scannedQr = result.Text;

                if (VisitationChecked != null)
                    VisitationChecked(this, EventArgs.Empty);
                
                StopScan();
            }
        }

        private void AttendanceVideoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopScan();
        }

        void StartScan()
        {
            videoSource = new VideoCaptureDevice(videoDevices[lbDevices.SelectedIndex].MonikerString);
            videoSource.NewFrame += VideoSource_NewFrame;
            videoSource.Start();
            BtnStart.Text = "Стоп";
            isStarted = true;
        }

        void StopScan()
        {
            if (videoSource != null)
            {
                videoSource.SignalToStop();
                videoSource.NewFrame -= VideoSource_NewFrame;
                //videoSource.WaitForStop();
                pbWebCam.Image = new Bitmap(300, 300);
                txbResult.Text = string.Empty;
                BtnStart.Text = "Старт";
                isStarted = false;
            }
        }
    }
}
