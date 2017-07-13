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
            pbWebCam.SizeMode = PictureBoxSizeMode.CenterImage;
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

            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            reader = new BarcodeReader();
            reader.Options.PossibleFormats = new List<BarcodeFormat>();
            reader.Options.PossibleFormats.Add(BarcodeFormat.QR_CODE);


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
            videoSource = new VideoCaptureDevice(videoDevices[lbDevices.SelectedIndex].MonikerString);
            videoSource.NewFrame += VideoSource_NewFrame;
            videoSource.Start();
        }

        private void VideoSource_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();

            pbWebCam.Image = bitmap;

            Result result = reader.Decode((Bitmap)eventArgs.Frame.Clone());

            if (result != null)
            {
                SetResult(result.Text);
            }
        }

        private void AttendanceVideoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoSource != null)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
        }
    }
}
