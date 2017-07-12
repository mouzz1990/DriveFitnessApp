using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DriveFitnessLibrary.ViewInterfaces
{
    public interface IReportView
    {
        Group Group { get; }
        DateTime StartDate { get; }
        DateTime EndDate { get; }

        void DisplayGroups(List<Group> groupList);
        void DisplayAttendanceTable(DataTable AttendanceTable);

        event EventHandler ShowReportClicked;
        event EventHandler ShowGroups;
    }
}
