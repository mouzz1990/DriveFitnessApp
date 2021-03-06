﻿using System;

namespace DriveFitnessLibrary
{
    public class AttendanceEventArgs : EventArgs
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
