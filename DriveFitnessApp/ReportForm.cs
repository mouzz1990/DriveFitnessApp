using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DriveFitnessLibrary.ViewInterfaces;
using DriveFitnessLibrary;

namespace DriveFitnessApp
{
    public partial class ReportForm : Form, IReportView
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        public Group Group
        {
            get { return (Group)cmbGroup.SelectedItem; }
        }

        public DateTime StartDate
        {
            get { return dtpStartDate.Value; }
        }

        public DateTime EndDate
        {
            get { return dtpEndDate.Value; }
        }

        public event EventHandler ShowReportClicked;
        public event EventHandler ShowGroups;

        private void BtnReport_Click(object sender, EventArgs e)
        {
            if (ShowReportClicked != null)
                ShowReportClicked(this, EventArgs.Empty);
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            if (ShowGroups != null)
                ShowGroups(this, EventArgs.Empty);
        }

        public void DisplayGroups(List<Group> groupList)
        {
            cmbGroup.Items.Clear();

            foreach (var g in groupList)
                cmbGroup.Items.Add(g);

            if (cmbGroup.Items.Count >= 0) cmbGroup.SelectedIndex = 0;
        }

        public void DisplayAttendanceTable(DataTable AttendanceTable)
        {
            dgvReport.DataSource = null;
            dgvReport.Rows.Clear();

            dgvReport.DataSource = AttendanceTable;
            dgvReport.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
