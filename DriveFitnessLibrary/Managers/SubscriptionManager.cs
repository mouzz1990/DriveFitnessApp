using DriveFitnessLibrary.DriveInterfaces;
using System;

namespace DriveFitnessLibrary.Managers
{
    public class SubscriptionManager : ISubscriptionManager
    {
        DateTimeFormatter dtFormatter = new DateTimeFormatter();

        public void AddNewSubscription(Client client, Subscription subscription)
        {
            string querry = string.Format(dtFormatter,
                "INSERT INTO `drivefitness`.`subscription` " +
                "(`count`, `subprice`, `subdate`, `clientsubid`)" +
                " VALUES ('{0}', '{1}', '{2}', '{3}');",
            subscription.CountTraining,
            subscription.SubPrice,
            subscription.SubDate,
            client.ID
            );

            MySqlManager.SqlManager.SendCommand(querry);
        }

        public void CloseSubscription(Client client)
        {
            throw new NotImplementedException();
        }

        public void DecreaseSubscriptionCount(Client client)
        {
            throw new NotImplementedException();
        }
    }
}
