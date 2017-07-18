using System;
using DriveFitnessLibrary.DriveInterfaces;
using DriveFitnessLibrary.ViewInterfaces;
using System.Data;

namespace DriveFitnessLibrary.Presenters
{
    public class ReportPresenter
    {
        IReportView view;
        IReportManager reportManager;
        IGroupManager groupManager;

        public ReportPresenter(IReportManager reportManager, IGroupManager groupManager, IReportView view)
        {
            this.reportManager = reportManager;
            this.groupManager = groupManager;
            this.view = view;

            view.ShowGroups += new EventHandler(view_ShowGroups);
            view.ShowReportClicked += new EventHandler(view_ShowReportClicked);
        }

        void view_ShowReportClicked(object sender, EventArgs e)
        {
            Group group = view.Group;
            DateTime startDate = view.StartDate;
            DateTime endDate = view.EndDate;

            DataTable attendanceTable = reportManager.GetAttendanceData(group, startDate, endDate);

            view.DisplayAttendanceTable(attendanceTable);
        }

        void view_ShowGroups(object sender, EventArgs e)
        {
            view.DisplayGroups(groupManager.GetGroups());
        }


    }
}
