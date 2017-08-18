using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveFitnessLibrary
{
    public class Schedule
    {
        public int ScheduleId { get; set; }
        public int GroupId { get; set; }
        public string Day { get; set; }
        public string Time { get; set; }

        public Schedule(int id, int grId, string day, string time)
        {
            ScheduleId = id;
            GroupId = grId;
            Day = day;
            Time = time;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", Day, Time);
        }
    }
}
