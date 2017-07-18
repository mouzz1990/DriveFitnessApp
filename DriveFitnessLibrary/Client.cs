using System;
using System.Collections.Generic;

namespace DriveFitnessLibrary
{
    [Serializable]
    public class Client : Person
    {
        public Subscription Subscription { get; set; }

        public Dictionary<DateTime, string> AttendanceInfo;
        
        [NonSerialized]
        public float Cash;

        public event EventHandler<AttendanceEventArgs> ClientVisited;

        public Client(string n, string l, DateTime b, string e, string t)
            : base(n, l, b, e, t)
        { }

        public Client(int id, string n, string l, DateTime b, string e, string t)
            : base(id, n, l, b, e, t)
        {
            AttendanceInfo = new Dictionary<DateTime, string>();
        }
        public Client(int id, string n, string l, DateTime b, string e, string t, Subscription sub)
            :this(id, n, l, b, e, t)
        {
            Subscription = sub;
        }

        public void CheckVisitation(float sum, DateTime date)
        {
            AttendanceEventArgs atEvArg = new AttendanceEventArgs(sum, date);

            if (ClientVisited != null)
                ClientVisited(this, atEvArg);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
