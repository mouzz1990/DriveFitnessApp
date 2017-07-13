using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DriveFitnessLibrary.DriveInterfaces;
using DriveFitnessLibrary.ViewInterfaces;
using DriveFitnessLibrary.Managers;

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
