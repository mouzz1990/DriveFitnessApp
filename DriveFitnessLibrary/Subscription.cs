using System;

namespace DriveFitnessLibrary
{
    [Serializable]
    public class Subscription
    {
        public int ID { get; private set; }
        public int CountTraining { get; private set; }
        public float SubPrice { get; private set; }
        public DateTime SubDate { get; private set; }
        public DateTime? SubCloseDate { get; private set; }
        public int ClientId { get; set; }

        public event EventHandler CountTrainingChanged;

        public static Subscription CreateNewSubscription(int count, float subpr, DateTime dt)
        {
            return new Subscription(count, subpr, dt);
        }

        private Subscription(int count, float subpr, DateTime dt)
        {
            CountTraining = count;
            SubPrice = subpr;
            SubDate = dt;
        }

        public Subscription(int id, int count, float subpr, DateTime dt, int clientId) : 
            this(count, subpr, dt)
        {
            ID = id;
            ClientId = clientId;
        }

        public void SubtractVisitation()
        {
            if (CountTraining > 0)
            {
                CountTraining--;

                if (CountTrainingChanged != null)
                    CountTrainingChanged(this, EventArgs.Empty);
            }

            else throw new Exception("На счету абонемента нет занятий!");
        }

        public override string ToString()
        {
            return CountTraining.ToString();
        }
    }
}
