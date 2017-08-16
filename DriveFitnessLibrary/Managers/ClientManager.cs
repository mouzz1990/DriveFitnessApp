using DriveFitnessLibrary.DriveInterfaces;
using System;

namespace DriveFitnessLibrary.Managers
{
    public class ClientManager : IClientManager
    {
        IDataBaseExecutable DataBaseManager;
        IMessager messager;
        ISubscriptionManager subscriptionManager;
        DateTimeFormatter dtFormatter;

        public ClientManager(IDataBaseExecutable dbm, IMessager mes)
        {
            DataBaseManager = dbm;
            messager = mes;
            dtFormatter = new DateTimeFormatter();
        }

        public ClientManager(IDataBaseExecutable dbm, IMessager mes, ISubscriptionManager subman)
        {
            DataBaseManager = dbm;
            messager = mes;
            subscriptionManager = subman;
            dtFormatter = new DateTimeFormatter();
        }

        public void AddNewClient(Client client, Group group)
        {
            string querry = string.Format(dtFormatter,
                "INSERT INTO [drivefitness].[dbo].[Client] " +
                "([GroupId], [ClientName], [ClientLastname], [ClientBirthday], [ClientEmail], [ClientTelephone]) " +
                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}'); ",
                //"call add_new_client('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                group.ID,
                client.Name,
                client.LastName,
                client.Birthday,
                client.Email,
                client.Telephone
                );

            DataBaseManager.SendCommand(querry);

            messager.SuccessMessage(string.Format("Клиент \"{0}\" добавлен в базу данных.", client));
        }

        public void BuySubscription(Client client, Subscription subscription)
        {
            string subNextId = DataBaseManager.GetNextId("Subscription");

            subscriptionManager.AddNewSubscription(client, subscription);

            string querry = string.Format(
                "UPDATE [drivefitness].[dbo].[Client] SET [SubscriptionId] ='{0}' WHERE [ClientId] ='{1}';",
                subNextId,
                client.ID
                );

            DataBaseManager.SendCommand(querry);

            //messager.SuccessMessage(string.Format("Абонемент выдан клиенту: {0}", client));

            messager.SuccessMessage(string.Format("Клиенту \"{3}\" добавлен новый абонемент:{0}Занятий: {1}, Стоимость: {2}",
                Environment.NewLine,
                subscription.CountTraining,
                subscription.SubPrice,
                client
                ));
        }

        public void ChangeClientInformation(Client client, Group group)
        {
            string querry = string.Format(dtFormatter,
                "UPDATE [drivefitness].[dbo].[Client] " +
                "SET [GroupId] = '{1}', " +
                "[ClientName] = '{2}', " +
                "[ClientLastname] = '{3}', " +
                "[ClientBirthday] = '{4}', " +
                "[ClientEmail] = '{5}', " +
                "[ClientTelephone] = '{6}' " +
                "WHERE [ClientId] = '{0}'; ",
                //"call change_client_info('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')",
                client.ID,
                group.ID,
                client.Name,
                client.LastName,
                client.Birthday,
                client.Email,
                client.Telephone
                );

            DataBaseManager.SendCommand(querry);

            messager.SuccessMessage(string.Format("Информация о клиенте \"{0}\" успешно изменена", client));
        }

        public void RemoveClient(Client client)
        {
            if (client.Subscription != null)
                subscriptionManager.RemoveSubscription(client);

            string querry = string.Format("DELETE FROM [drivefitness].[dbo].[Client] WHERE [ClientId] ='{0}'", client.ID);
                DataBaseManager.SendCommand(querry);

                messager.SuccessMessage(string.Format("Информация о клиенте \"{0}\" успешно удалена из базы данных.", client));
        }
    }
}
