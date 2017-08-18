using DriveFitnessLibrary.DriveInterfaces;
using System;
using System.Collections.Generic;
using System.Data;

namespace DriveFitnessLibrary.Managers
{
    public class ScheduleManager : IScheduleManager
    {
        IDataBaseExecutable DataBaseManager;
        IGroupManager GroupManager;
        IMessager messager;

        public ScheduleManager(IDataBaseExecutable DataBaseManager, IGroupManager GroupManager, IMessager messager)
        {
            this.DataBaseManager = DataBaseManager;
            this.GroupManager = GroupManager;
            this.messager = messager;
        }

        public void AddNewSchedule(Group group, string day, string time)
        {
            string querry = 
                string.Format("INSERT INTO [drivefitness].[dbo].[Schedule] ([GroupId], [Day], [Time]) " +
                "VALUES ('{0}', '{1}', '{2}');",
                group.ID,
                day,
                time
                );

            DataBaseManager.SendCommand(querry);

            messager.SuccessMessage(
                string.Format("Информация о занятии успешно добавлена в базу данных:{0}" +
                "{1} - {2}: {3}",
                Environment.NewLine,
                group.GroupName,
                day,
                time
                ));
        }

        public void ChangeScheduleInformation(Schedule schedule, string newDay, string newTime)
        {
            string querry = string.Format("UPDATE [drivefitness].[dbo].[Schedule] SET [Day] ='{0}', [Time] = '{1}' WHERE [ScheduleId] = '{2}';",
                newDay,
                newTime,
                schedule.ScheduleId
                );

            DataBaseManager.SendCommand(querry);

            messager.SuccessMessage(
                string.Format("Расписание успешно изменено!"));

            schedule.Day = newDay;
            schedule.Time = newTime;
        }

        public List<Group> GetGroups()
        {
            return GroupManager.GetGroups();
        }

        public List<Schedule> GetSchedules(Group group)
        {
            List<Schedule> SchedulesList = new List<Schedule>();
            DataTable dt = DataBaseManager.GetData(
                string.Format("SELECT * FROM [drivefitness].[dbo].[Schedule] WHERE [GroupId] = '{0}';",
                group.ID
                ));

            DataRow[] rows = dt.Select();
            foreach (var r in rows)
            {
                SchedulesList.Add(new Schedule(
                    (int)r["ScheduleId"],
                    (int)r["GroupId"],
                    (string)r["Day"],
                    (string)r["Time"])
                    );
            }

            return SchedulesList;
        }

        public void RemoveSchedule(Schedule schedule)
        {
            string querry = string.Format("DELETE FROM [drivefitness].[dbo].[Schedule] WHERE [ScheduleId] = '{0}';",
                schedule.ScheduleId
                );

            DataBaseManager.SendCommand(querry);

            messager.SuccessMessage("Расписание занятия успешно удалено!");
        }
    }
}
