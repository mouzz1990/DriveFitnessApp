using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveFitnessLibrary.DriveInterfaces
{
    public interface IScheduleManager
    {
        void AddNewSchedule(Group group, string day, string time);
        void ChangeScheduleInformation(Schedule schedule, string newDay, string newTime);
        void RemoveSchedule(Schedule schedule);

        List<Schedule> GetSchedules(Group group);
        List<Group> GetGroups();
        
    }
}
