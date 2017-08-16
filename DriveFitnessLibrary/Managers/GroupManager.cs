using DriveFitnessLibrary.DriveInterfaces;
using System;
using System.Collections.Generic;
using System.Data;

namespace DriveFitnessLibrary.Managers
{
    public class GroupManager : IGroupManager
    {
        IDataBaseExecutable DataBaseManager;
        IMessager messager;

        public GroupManager(IDataBaseExecutable dbe, IMessager mess)
        {
            DataBaseManager = dbe;
            messager = mess;
        }

        public void AddNewGroup(string groupName)
        {
            string querry = string.Format("INSERT INTO [drivefitness].[dbo].[Group] ([GroupName]) VALUES ('{0}');",
                groupName
                );

            DataBaseManager.SendCommand(querry);
            messager.SuccessMessage(string.Format("Новая группа \"{0}\" создана.", groupName));
        }

        public void ChangeGroupInfo(Group group, string newGroupName)
        {
            string querry = string.Format("UPDATE [drivefitness].[dbo].[Group] SET [GroupName] ='{0}' WHERE [GroupId] = '{1}';",
                newGroupName,
                group.ID
                );

            DataBaseManager.SendCommand(querry);

            messager.SuccessMessage(string.Format("Название группы \"{0}\" изменено на \"{1}\"", 
                group.GroupName,
                newGroupName
                ));

            group.GroupName = newGroupName;
        }

        public List<Client> GetClients(int groupId)
        {
            List<Client> ClientsList = new List<Client>();
            DataTable dt = DataBaseManager.GetData(
                "SELECT * FROM [drivefitness].[dbo].[Client] " +
                "LEFT JOIN [drivefitness].[dbo].[Group] on [drivefitness].[dbo].[Client].[GroupId] = [drivefitness].[dbo].[Group].[GroupId] " +
                "LEFT JOIN [drivefitness].[dbo].[Subscription] on [drivefitness].[dbo].[Client].[SubscriptionId] = [drivefitness].[dbo].[Subscription].[SubscriptionId] " +
                "WHERE [drivefitness].[dbo].[Client].[GroupId] = " + groupId);

            DataRow[] rows = dt.Select();
            foreach (var r in rows)
            {
                Subscription sub = null;
                int subid;
                if (int.TryParse(r["SubscriptionId"].ToString(), out subid))
                {
                    sub = new Subscription(
                        (int)r["SubscriptionId"],
                        (int)r["SubscriptionCountExcercise"],
                        (float)r["SubscriptionPrice"],
                        (DateTime)r["SubscriptionDate"],
                        (int)r["ClientSubscriptionId"]
                        );
                }

                ClientsList.Add(new Client(
                    (int)r["ClientId"],
                    (string)r["ClientName"],
                    (string)r["ClientLastname"],
                    (DateTime)r["ClientBirthday"],
                    (string)r["ClientEmail"],
                    (string)r["ClientTelephone"],
                    sub)
                    );
            }

            return ClientsList;
        }

        public List<Group> GetGroups()
        {
            List<Group> GroupList = new List<Group>();
            DataTable dt = DataBaseManager.GetData("SELECT * FROM [drivefitness].[dbo].[Group]");


            DataRow[] rows = dt.Select();
            foreach (var r in rows)
            {
                GroupList.Add(new Group(
                    (int)r["GroupId"],
                    (string)r["GroupName"],
                    GetClients((int)r["GroupId"]))
                    );
            }

            return GroupList;
        }

        public void RemoveGroup(Group group)
        {
            if (group.ClientsList.Count != 0)
            {
                throw new RemoveGroupException(
                    string.Format("Удаление невозможно! В группе \"{0}\" находятся клиенты{1}{1}Сначала удалите или переведите клиентов в другую группу.",
                    group.GroupName,
                    Environment.NewLine)
                    );
            }

            string querry = string.Format("DELETE FROM [drivefitness].[dbo].[Group] WHERE [GroupId] = '{0}';",
                group.ID
                );

            DataBaseManager.SendCommand(querry);

            messager.SuccessMessage(string.Format("Группа \"{0}\" удалена.", group.GroupName));
        }
    }
}
