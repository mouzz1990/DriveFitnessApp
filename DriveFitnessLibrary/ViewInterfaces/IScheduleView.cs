using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveFitnessLibrary.ViewInterfaces
{
    public interface IScheduleView
    {
        Group Group { get; }
        Schedule Schedule { get; }

        string ScheduleDay { get; }
        string ScheduleTime { get; }

        void DisplayGroups(List<Group> groups);
        void DisplaySchedules(List<Schedule> schedules);

        event EventHandler FormLoaded;
        event EventHandler ScheduleRequired;
        event EventHandler AddNewScheduleClicked;
        event EventHandler ChangeScheduleClicked;
        event EventHandler RemoveScheduleClicked;
    }
}
