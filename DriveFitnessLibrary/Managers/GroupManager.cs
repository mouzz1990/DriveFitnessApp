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
            string querry = string.Format("INSERT INTO `drivefitness`.`groups` (`groupname`) VALUES ('{0}');",
                groupName
                );

            DataBaseManager.SendCommand(querry);
            messager.SuccessMessage(string.Format("Новая группа \"{0}\" создана.", groupName));
        }

        public void ChangeGroupInfo(Group group, string newGroupName)
        {
            string querry = string.Format("UPDATE `drivefitness`.`groups` SET `groupname`='{0}' WHERE `id`='{1}';",
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
                "SELECT * FROM clients " +
                "LEFT JOIN groups on groupid = groups.id " +
                "LEFT JOIN subscription on subscriptionid = subscription.id " +
                "WHERE groupid = " + groupId);

            DataRow[] rows = dt.Select();
            foreach (var r in rows)
            {
                Subscription sub = null;
                int subid;
                if (int.TryParse(r["subscriptionid"].ToString(), out subid))
                {
                    sub = new Subscription(
                        (int)r["subscriptionid"],
                        (int)r["count"],
                        (float)r["subprice"],
                        (DateTime)r["subdate"],
                        (int)r["clientsubid"]
                        );
                }

                ClientsList.Add(new Client(
                    (int)r["id"],
                    (string)r["name"],
                    (string)r["lastname"],
                    (DateTime)r["birthday"],
                    (string)r["email"],
                    (string)r["telephone"],
                    sub)
                    );
            }

            return ClientsList;
        }

        public List<Group> GetGroups()
        {
            List<Group> GroupList = new List<Group>();
            DataTable dt = DataBaseManager.GetData("SELECT * FROM groups");


            DataRow[] rows = dt.Select();
            foreach (var r in rows)
            {
                GroupList.Add(new Group(
                    (int)r["id"],
                    (string)r["groupname"],
                    GetClients((int)r["id"]))
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

            string querry = string.Format("DELETE FROM `drivefitness`.`groups` WHERE `id`='{0}';",
                group.ID
                );

            DataBaseManager.SendCommand(querry);

            messager.SuccessMessage(string.Format("Группа \"{0}\" удалена.", group.GroupName));
        }
    }
}
