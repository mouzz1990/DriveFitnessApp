using System;

namespace DriveFitnessLibrary
{
    public class Subscription
    {
        public int ID { get; private set; }
        public int CountTraining { get; private set; }
        public float SubPrice { get; private set; }
        public DateTime SubDate { get; private set; }
        public DateTime? SubCloseDate { get; private set; }
        public int ClientId { get; set; }

        public event EventHandler CountTrainingChanged;

        public Subscription(int id, int count, float subpr, DateTime dt, int clientId)
        {
            ID = id;
            CountTraining = count;
            SubPrice = subpr;
            SubDate = dt;
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
