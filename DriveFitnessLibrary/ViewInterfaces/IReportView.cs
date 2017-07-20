using System;
using System.Collections.Generic;
using System.Data;

namespace DriveFitnessLibrary.ViewInterfaces
{
    public interface IReportView
    {
        Group Group { get; }
        DateTime StartDate { get; }
        DateTime EndDate { get; }

        DataTable AttendanceTable { get; }
        string SaveFileTo { get; }

        void DisplayGroups(List<Group> groupList);
        void DisplayAttendanceTable(DataTable AttendanceTable);

        event EventHandler ShowReportClicked;
        event EventHandler ShowGroups;
        event EventHandler SaveReportClicked;
    }
}
