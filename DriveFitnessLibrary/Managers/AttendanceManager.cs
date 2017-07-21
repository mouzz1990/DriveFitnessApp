using DriveFitnessLibrary.DriveInterfaces;
using System;
using System.Collections.Generic;
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
            messager = subscriptionManager.messager;
            
            dtFormatter = new DateTimeFormatter();
        }

        public void AddAttendance(Client client, DateTime dateVisit, float price)
        {
            if (client == null) 
            {
                messager.ErrorMessage("Клиент не найден. Операция отменена.");
                return;
            }

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
                if (CheckSubscriptionAttendanceDate(client, dateVisit))
                {
                    AddAttendanceBySubscription(client, dateVisit);
                }
                else
                {
                    messager.ErrorMessage(
                        string.Format("Ошибка учета посещения. Абонмент был приобретен: \"{0}\", а занятие фиксируется: \"{1}\"{2}{2}Пожалуйста проверьте вводимые данные.",
                        client.Subscription.SubDate.ToShortDateString(),
                        dateVisit.ToShortDateString(),
                        Environment.NewLine)
                        );

                    return;
                }
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
            //string priceString = price.ToString().Replace(',', '.');

            string querry = string.Format(
                    dtFormatter,
                    "INSERT INTO `drivefitness`.`attendance` (`clientid`, `datevisit`, `payment`, `attprice`) " +
                "VALUES ('{0}', '{1}', '{2}', '{3}');",
                        client.ID,
                        dateVisit,
                        price,
                        price
                        //priceString,
                        //priceString
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

        bool CheckSubscriptionAttendanceDate(Client client, DateTime dateVisit)
        {
            if (client.Subscription.SubDate <= dateVisit)
                return true;

            return false;
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
            if (!CheckAttendance(client, dateVisit))
            {
                string querry = string.Format(dtFormatter,
                    "DELETE FROM `drivefitness`.`attendance` WHERE `clientid`='{0}' AND `datevisit`='{1}';",
                    client.ID,
                    dateVisit
                    );

                DataBaseManager.SendCommand(querry);

                messager.SuccessMessage(string.Format("Посещение клиента \"{0}\"успешно удалено!", 
                    client
                    ));
            }
            else
            {
                messager.ErrorMessage(string.Format("Клиент \"{0}\"не посещал занятие: {1}.{2}{2}Операция отменена.",
                    client,
                    dateVisit.ToShortDateString(),
                    Environment.NewLine
                    ));
            }
        }

        public List<DateTime> GetAttendanceDates(Client client)
        {
            string querry = string.Format(
                "SELECT `datevisit` FROM `drivefitness`.`attendance` WHERE `clientid`='{0}'",
                client.ID
                );

            DataTable datesTable = DataBaseManager.GetData(querry);

            List<DateTime> datesList = new List<DateTime>();

            foreach (var date in datesTable.Select())
            {
                datesList.Add((DateTime)date["datevisit"]);
            }

            return datesList;
        }
    }
}
