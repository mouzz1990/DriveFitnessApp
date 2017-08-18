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
using DriveFitnessLibrary.ViewInterfaces;

namespace DriveFitnessApp
{
    public partial class ScheduleForm : Form, IScheduleView
    {
        public ScheduleForm()
        {
            InitializeComponent();
        }

        public Group Group { get { return (Group)cmbGroup.SelectedItem; } }

        public Schedule Schedule {get { return (Schedule)lbSchedule.SelectedItem; } }

        public string ScheduleDay { get { return txbDay.Text; } }

        public string ScheduleTime { get { return txbTime.Text; } }

        public event EventHandler FormLoaded;
        public event EventHandler AddNewScheduleClicked;
        public event EventHandler ChangeScheduleClicked;
        public event EventHandler RemoveScheduleClicked;
        public event EventHandler ScheduleRequired;

        private void BtnChangeInfo_Click(object sender, EventArgs e)
        {
            if (ChangeScheduleClicked != null)
                ChangeScheduleClicked(this, EventArgs.Empty);
        }

        private void BtnAddNewSchedule_Click(object sender, EventArgs e)
        {
            if (AddNewScheduleClicked != null)
                AddNewScheduleClicked(this, EventArgs.Empty);
        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {
            if (FormLoaded != null)
                FormLoaded(this, EventArgs.Empty);

            BtnChangeInfo.Visible = false;
            BtnRemove.Visible = false;
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (RemoveScheduleClicked != null)
                RemoveScheduleClicked(this, EventArgs.Empty);
        }

        public void DisplayGroups(List<Group> groups)
        {
            cmbGroup.Items.Clear();

            foreach (var g in groups)
                cmbGroup.Items.Add(g);

            if (groups.Count > 0)
                cmbGroup.SelectedIndex = 0;
        }

        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ScheduleRequired != null)
                ScheduleRequired(this, EventArgs.Empty);
        }

        public void DisplaySchedules(List<Schedule> schedules)
        {
            lbSchedule.Items.Clear();

            foreach (var s in schedules)
                lbSchedule.Items.Add(s);

            if (schedules.Count > 0)
                lbSchedule.SelectedIndex = 0;
        }

        private void rbAddNew_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAddNew.Checked)
            {
                BtnAddNewSchedule.Visible = true;

                BtnChangeInfo.Visible = false;
                BtnRemove.Visible = false;

                txbDay.Text = string.Empty;
                txbTime.Text = string.Empty;
            }
        }

        private void rbChange_CheckedChanged(object sender, EventArgs e)
        {
            if (rbChange.Checked)
            {
                BtnAddNewSchedule.Visible = false;

                BtnChangeInfo.Visible = true;
                BtnRemove.Visible = true;

                txbDay.Text = Schedule.Day;
                txbTime.Text = Schedule.Time;
            }
        }

        private void lbSchedule_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbChange.Checked)
            {
                txbDay.Text = Schedule.Day;
                txbTime.Text = Schedule.Time;
            }
            else
            {
                txbDay.Text = string.Empty;
                txbTime.Text = string.Empty;
            }
        }
    }
}
