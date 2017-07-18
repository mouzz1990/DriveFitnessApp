using System;
using DriveFitnessLibrary.DriveInterfaces;
using DriveFitnessLibrary.ViewInterfaces;

namespace DriveFitnessLibrary.Presenters
{
    public class AttendancePresenter
    {
        IAttendanceManager attendanceManager;
        IGroupManager groupManager;
        IAttendanceView view;

        public AttendancePresenter(IAttendanceManager attendanceManager, IGroupManager groupManager, IAttendanceView view)
        {
            this.attendanceManager = attendanceManager;
            this.groupManager = groupManager;
            this.view = view;

            view.VisitationChecked += new EventHandler(view_VisitationChecked);
            view.FormLoaded += new EventHandler(view_FormLoaded);
            view.ClientChanged += View_ClientChanged;
            view.VisitationDeleted += View_VisitationDeleted;
        }

        private void View_VisitationDeleted(object sender, EventArgs e)
        {
            attendanceManager.RemoveAttendance(view.GetClient(), view.DateVisit);
        }

        private void View_ClientChanged(object sender, EventArgs e)
        {
            Client client = view.GetClient();
            view.DisplayVisitedDates(attendanceManager.GetAttendanceDates(client));
        }

        void view_FormLoaded(object sender, EventArgs e)
        {
            view.DisplayGroups(groupManager.GetGroups());
        }

        void view_VisitationChecked(object sender, EventArgs e)
        {
            Client client = view.GetClient();

            DateTime dateVisitation = view.DateVisit;
            float price = view.Price;

            attendanceManager.AddAttendance(client, dateVisitation, price);
        }
    }
}
