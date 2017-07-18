using System;
using System.Collections.Generic;
using System.Data;

namespace DriveFitnessLibrary.DriveInterfaces
{
    public interface IAttendanceManager
    {
        void AddAttendance(Client client, DateTime dateVisit, float price);
        void RemoveAttendance(Client client, DateTime dateVisit);
        List<DateTime> GetAttendanceDates(Client client);
    }
}
