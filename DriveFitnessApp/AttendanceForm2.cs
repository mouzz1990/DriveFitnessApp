using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DriveFitnessLibrary.ViewInterfaces;
using DriveFitnessLibrary;
using System.Threading.Tasks;
using System.Threading;
using ZXing;

namespace DriveFitnessApp
{
    public partial class AttendanceForm2 : Form, IAttendanceView
    {
        public AttendanceForm2()
        {
            InitializeComponent();
        }

        public DateTime DateVisit
        {
            get { return dtpDateVisit.Value; }
        }

        public float Price
        {
            get { return (float)numPrice.Value; }
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

        List<Group> groupList;
        string scannedQr;

        public void DisplayGroups(List<Group> group)
        {
            groupList = group;
        }

        public event EventHandler VisitationChecked;

        public event EventHandler FormLoaded;

        private void BtnStartScan_Click(object sender, EventArgs e)
        {
            string filePath;
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.ShowDialog();
                filePath = ofd.FileName;
            }

            BarcodeReader qrDecode = new BarcodeReader(); //чтение QR кода
            Result text = qrDecode.Decode((Bitmap)Bitmap.FromFile(filePath)); //декодирование растрового изображения
            
            scannedQr = text.Text;

            if (VisitationChecked != null)
                VisitationChecked(this, EventArgs.Empty);
        }

        private void AttendanceForm2_Load(object sender, EventArgs e)
        {
            if (FormLoaded != null)
                FormLoaded(this, EventArgs.Empty);
        }
    }
}
