using System;
using System.Windows.Forms;
using DriveFitnessLibrary.DriveInterfaces;
using DriveFitnessLibrary.Presenters;

namespace DriveFitnessApp
{
    public partial class AttendanceSelectForm : Form
    {
        IAttendanceManager attMgr;
        IGroupManager grMgr;
        AttendancePresenter ptPres;

        public AttendanceSelectForm(IAttendanceManager attMgr, IGroupManager grMgr)
        {
            InitializeComponent();

            this.attMgr = attMgr;
            this.grMgr = grMgr;
        }

        private void BtnAuto_Click(object sender, EventArgs e)
        {
            AttendanceVideoForm avf = new AttendanceVideoForm();
            this.ptPres = new AttendancePresenter(attMgr, grMgr, avf);

            avf.ShowDialog();
        }

        private void BtnManual_Click(object sender, EventArgs e)
        {
            AttendanceForm atf = new AttendanceForm();
            this.ptPres = new AttendancePresenter(attMgr, grMgr, atf);

            atf.ShowDialog();
        }
    }
}
