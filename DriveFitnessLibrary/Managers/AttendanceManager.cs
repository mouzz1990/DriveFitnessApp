using DriveFitnessLibrary.DriveInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;

namespace DriveFitnessLibrary.Managers
{
    public class AttendanceManager : IAttendanceManager
    {
        IDataBaseExecutable DataBaseManager;
        IMessager messager;
        ISubscriptionManager subscriptionManager;
        DateTimeFormatter dtFormatter;

        public AttendanceManager(ISubscriptionManager sm)
        {
            subscriptionManager = sm;
            DataBaseManager = subscriptionManager.DataBaseManager;
            messager = sm.messager;
            
            dtFormatter = new DateTimeFormatter();
        }

        public void AddAttendance(Client client, DateTime dateVisit, float price)
        {
            if (!CheckAttendance(client, dateVisit))
            {
                messager.ExclamationMessage(
                    string.Format("Посещение клиента {0} уже зафиксировано!{1}{1}Повторная запись не фиксируется в базе данных!",
                    client, Environment.NewLine)
                    );

                return;
            }

            if (client.Subscription == null)
            {
                AddAttendanceByCash(client, dateVisit, price);
            }
            else
            {
                AddAttendanceBySubscription(client, dateVisit);
            }
        }

        bool CheckAttendance(Client client, DateTime dateVisit)
        {
            string querryCheck = string.Format(
                dtFormatter,
                "SELECT * FROM attendance WHERE clientid = '{0}' AND datevisit = '{1}'",
                client.ID,
                dateVisit
                );

            DataTable dt = DataBaseManager.GetData(querryCheck);

            if (dt.Rows.Count > 0)
                return false;
            
            return true;
        }

        void AddAttendanceByCash(Client client, DateTime dateVisit, float price)
        {
            string priceString = price.ToString().Replace(',', '.');

            string querry = string.Format(
                    dtFormatter,
                    "INSERT INTO `drivefitness`.`attendance` (`clientid`, `datevisit`, `payment`, `attprice`) " +
                "VALUES ('{0}', '{1}', '{2}', '{3}');",
                        client.ID,
                        dateVisit,
                        priceString,
                        priceString
                        );

            string paymnt = "Наличный расчет " + price + " грн.";

            messager.SuccessMessage(
                string.Format("Посещение клиента {3} зафиксировано - {0}!{1}{1}{2}",
                dateVisit.ToShortDateString(),
                Environment.NewLine,
                paymnt,
                client
                )
            );

            DataBaseManager.SendCommand(querry);
        }

        void AddAttendanceBySubscription(Client client, DateTime dateVisit)
        {
            string querry = string.Format(
                    dtFormatter,
                    "INSERT INTO `drivefitness`.`attendance` (`clientid`, `datevisit`, `payment`, `attprice`)" +
                    "VALUES ('{0}', '{1}', '{2}', '{3}');",
                        client.ID,
                        dateVisit,
                        "А",
                        0
                        );

            DataBaseManager.SendCommand(querry);

            subscriptionManager.DecreaseSubscriptionCount(client);

            if (client.Subscription.CountTraining == 0)
            {
                subscriptionManager.CloseSubscription(client);
            }
        }

        public void RemoveAttendance(Client client, DateTime dateVisit)
        {
            throw new NotImplementedException();
        }
    }
}
