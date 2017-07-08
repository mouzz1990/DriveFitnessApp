using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveFitnessLibrary
{
    public class AttendanceEventArgs
    {
        public float Sum { get; set; }
        public DateTime Date { get; set; }

        public AttendanceEventArgs(float sum, DateTime date)
        {
            Sum = sum;
            Date = date;
        }
    }
}
