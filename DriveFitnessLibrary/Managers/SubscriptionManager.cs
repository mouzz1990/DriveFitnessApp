﻿using DriveFitnessLibrary.DriveInterfaces;
using System;

namespace DriveFitnessLibrary.Managers
{
    public class SubscriptionManager : ISubscriptionManager
    {
        
        public IDataBaseExecutable DataBaseManager { get; set; }
        public IMessager messager { get; set; }
        DateTimeFormatter dtFormatter = new DateTimeFormatter();

        public SubscriptionManager(IDataBaseExecutable db, IMessager mes)
        {
            DataBaseManager = db;
            messager = mes;
        }

        public void AddNewSubscription(Client client, Subscription subscription)
        {
            string subNextId = DataBaseManager.GetNextId("subscription");
            string price = subscription.SubPrice.ToString().Replace(',', '.');

            string querry = string.Format(dtFormatter,
                "INSERT INTO `drivefitness`.`subscription` " +
                "(`count`, `subprice`, `subdate`, `clientsubid`)" +
                " VALUES ('{0}', '{1}', '{2}', '{3}');",
            subscription.CountTraining,
            price,
            subscription.SubDate,
            client.ID
            );

            DataBaseManager.SendCommand(querry);
        }

        public void CloseSubscription(Client client)
        {
            string delQuerry = string.Format(
                "UPDATE `drivefitness`.`clients` SET `subscriptionid`=NULL WHERE `id`='{0}';",
                        client.Subscription.ClientId
                        );

            DataBaseManager.SendCommand(delQuerry);

            messager.SuccessMessage(
                string.Format("Абонемент клиента закрыт!{0}{0}Абонемент был приобретен: {1}",
                Environment.NewLine,
                client.Subscription.SubDate.ToShortDateString())
                );
            
            client.Subscription = null;
        }

        public void DecreaseSubscriptionCount(Client client)
        {
            client.Subscription.SubtractVisitation();

            string querry = string.Format("UPDATE `drivefitness`.`subscription` SET `count`='{0}' WHERE `id`='{1}';",
                    client.Subscription.CountTraining,
                    client.Subscription.ID);

            DataBaseManager.SendCommand(querry);

            messager.SuccessMessage(
                string.Format("Зафиксировано посещение клиента {0}.{1}{1}На абонементе осталось занятий: {2}.",
                client,
                Environment.NewLine,
                client.Subscription.CountTraining)
                );
        }
        
        public void ChangeSubscriptionData(Client client, int newCount, float newPrice, DateTime dateBuy)
        {
            string querry = string.Format(dtFormatter,
                "UPDATE `drivefitness`.`subscription` SET `count`='{0}', `subprice`='{1}', `subdate`='{2}' WHERE `id`='{3}';",
                newCount,
                newPrice,
                dateBuy,
                client.Subscription.ID
                );

            DataBaseManager.SendCommand(querry);

            messager.SuccessMessage(string.Format(
                "Информация об абонементе клиента \"{0}\" успешно изменена.",
                client
                )
                );
        }

        public void RemoveSubscription(Client client)
        {
            string delQuerry = string.Format(
                "UPDATE `drivefitness`.`clients` SET `subscriptionid`=NULL WHERE `id`='{0}';",
                        client.Subscription.ClientId
                        );

            DataBaseManager.SendCommand(delQuerry);

            string querry = string.Format("DELETE FROM `drivefitness`.`subscription` WHERE `id`='{0}';",
                client.Subscription.ID
                );

            DataBaseManager.SendCommand(querry);

            messager.SuccessMessage(
                string.Format("Абонемент клиента \"{1}\" удален!{0}{0}Информация об абонементе полностью удалена из базы данных.",
                Environment.NewLine,
                client.Subscription.SubDate.ToShortDateString())
                );
        }
    }
}
