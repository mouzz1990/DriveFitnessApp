using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DriveFitnessLibrary.DriveInterfaces
{
    public interface IReportManager
    {
        DataTable GetAttendanceData(Group group, DateTime startDate, DateTime endDate);
    }
}
