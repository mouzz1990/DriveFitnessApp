using System;
using System.Data;

namespace DriveFitnessLibrary.DriveInterfaces
{
    public interface IReportManager
    {
        DataTable GetAttendanceData(Group group, DateTime startDate, DateTime endDate);
    }
}
