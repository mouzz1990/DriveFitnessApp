using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveFitnessLibrary
{
    public class Client : Person
    {
        public Group GroupClient { get; private set; }
        public int ID { get; private set; }
        public Subscription Subscription { get; set; }
        public Dictionary<DateTime, string> AttendanceInfo;
        public float Cash;

        public event EventHandler<AttendanceEventArgs> ClientVisited;

        public Client(string n, string l, DateTime b, string e, string t, Group g, int id, Subscription sub)
            :base(n,l,b,e,t)
        {
            GroupClient = g;
            ID = id;
            Subscription = sub;
            AttendanceInfo = new Dictionary<DateTime, string>();
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
