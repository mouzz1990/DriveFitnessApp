using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using DriveFitnessLibrary.ViewInterfaces;
using DriveFitnessLibrary;
using System.IO;

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

        public DataTable AttendanceTable
        {
            get { return dgvReport.DataSource as DataTable; }
        }
        
        public string SaveFileTo
        {
            get { return _saveFileTo; }
        }
    
        public event EventHandler ShowReportClicked;
        public event EventHandler ShowGroups;
        public event EventHandler SaveReportClicked;

        private void BtnReport_Click(object sender, EventArgs e)
        {
            if (ShowReportClicked != null)
                ShowReportClicked(this, EventArgs.Empty);

            BtnToExcel.Visible = true;
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

        string _saveFileTo;

        private void BtnToExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.InitialDirectory = string.Format(@"{0}\Reports",Environment.CurrentDirectory);
            sfd.Filter = "Microsoft Office Excel Document|*.xlsx|Microsoft Office Excel 97-2003 Document|*.xls";

            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _saveFileTo = sfd.FileName;

                if (SaveReportClicked != null)
                    SaveReportClicked(this, EventArgs.Empty);
            }
        }


    }
}
