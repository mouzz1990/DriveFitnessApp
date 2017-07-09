using System;
using System.Data;

namespace DriveFitnessLibrary.DriveInterfaces
{
    public interface IAttendanceManager
    {
        void AddAttendance(Client client, DateTime dateVisit, float price);
        void RemoveAttendance(Client client, DateTime dateVisit);
        DataTable GetAttendanceData(Group group, DateTime startDate, DateTime endDate);
    }
}
