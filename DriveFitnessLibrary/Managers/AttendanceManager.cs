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

        public AttendanceManager(IDataBaseExecutable db, IMessager m, ISubscriptionManager sm)
        {
            DataBaseManager = db;
            messager = m;
            subscriptionManager = sm;
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
                        price
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

        public DataTable GetAttendanceData(Group group, DateTime startDate, DateTime endDate)
        {
            //получение всех дат занятий
            string stDt = startDate.ToString("yyyy-MM-dd");
            string enDt = endDate.ToString("yyyy-MM-dd");

            string querry = string.Format(dtFormatter, "call get_attendance_dates_by_group('{0}','{1}','{2}')",
                startDate,
                endDate,
                group.ID
                );

            DataTable DatesVisit = DataBaseManager.GetData(querry);

            //получение БД по посещяемости занятий
            //!!!!!
            querry = string.Format("SELECT * FROM attendance");
            //querry = string.Format("SELECT * FROM attendance WHERE datevisit >= '{0}' AND datevisit <= {1}", stDt, enDt);

            DataTable Attendance = DataBaseManager.GetData(querry);

            //получение информации о всех клиентах
            querry = "SELECT * FROM drivefitness.clients " +
                "JOIN groups on groupid = groups.id " +
                "LEFT JOIN subscription on subscriptionid = subscription.id " +
                "WHERE groupid = " + group.ID;

            DataTable Clients = DataBaseManager.GetData(querry);

            //Создание таблицы для ее формирования и вывда в datagridview
            DataTable attendanceTable = new DataTable("Attendance");

            //создание первого столбца  Клиент
            attendanceTable.Columns.Add("Клиент");

            //Получение всех купленных абониментов в установленных сроках
            string subQuerry = string.Format(dtFormatter, "SELECT * FROM subscription " +
                                                 "LEFT JOIN clients ON clientsubid = clients.id " +
                                                 "WHERE subdate >= '{0}' AND subdate <= '{1}' AND groupid = {2}",
                                                 startDate,
                                                 endDate,
                                                 group.ID
                                                 );

            DataTable SubscriptionTable = DataBaseManager.GetData(subQuerry);
            //Выборка по покупке абонементов
            var subSel = SubscriptionTable.Select();

            var allSubscriptions = from a in subSel
                                   select new
                                   {
                                       ID = (int)a["id"],
                                       COUNT = (int)a["count"],
                                       SUBPRICE = (float)a["subprice"],
                                       SUBDATE = (DateTime)a["subdate"],
                                       CLIENTID = (int)a["clientsubid"]
                                   };

            //Список дат посещений и покупки абонементов
            List<DateTime> datesList = new List<DateTime>();
            HashSet<DateTime> hashDatesSubBuy = new HashSet<DateTime>();
            HashSet<DateTime> hashVisit = new HashSet<DateTime>();

            //добавление дат покупки абонементов
            foreach (var d in subSel)
            {
                datesList.Add((DateTime)d["subdate"]);
                hashDatesSubBuy.Add((DateTime)d["subdate"]);
            }

            //добавление дат посещений
            foreach (var dates in DatesVisit.Select())
            {
                datesList.Add((DateTime)dates["datevisit"]);
                hashVisit.Add((DateTime)dates["datevisit"]);
            }

            //сортировка списка в хронологическом порядке
            datesList.Sort();

            //заполнение выводимой таблицы датами
            foreach (var d in datesList.Distinct())
            {
                attendanceTable.Columns.Add(new DataColumn(d.ToShortDateString()));
            }

            List<Client> ClientsList = new List<Client>();

            foreach (var client in Clients.Select())
            {
                Subscription subscr;

                if (int.TryParse(client["subscriptionid"].ToString(), out int subid))
                {
                    subscr = new Subscription(
                        subid,
                        (int)client["count"],
                        (float)client["subprice"],
                        (DateTime)client["subdate"],
                        (int)client["clientsubid"]
                        );

                }
                else subscr = null;

                ClientsList.Add(new Client(
                    (int)client["id"],
                    (string)client["name"],
                    (string)client["lastname"],
                    (DateTime)client["birthday"],
                    (string)client["email"],
                    (string)client["telephone"],
                    //new Group((int)client["groupid"], (string)client["groupname"]),
                    subscr

                    ));
            }

            //Заполнение посещаемости клиентов
            var attData = Attendance.Select(string.Format("datevisit >= #{0}# and datevisit <= #{1}#", stDt, enDt));
            foreach (var c in ClientsList)
            {
                foreach (var a in attData)
                {
                    DateTime datevisit = (DateTime)a["datevisit"];
                    string payment = a["payment"].ToString();

                    if (c.ID == (int)a["clientid"])
                    {
                        c.Cash += (float)a["attprice"];

                        //Произведение покупки абонемента в день занятия
                        foreach (var sub in allSubscriptions)
                        {
                            if (sub.CLIENTID == c.ID)
                            {
                                if (sub.SUBDATE == datevisit)
                                {
                                    payment = string.Format("A → {0}", sub.SUBPRICE);
                                }
                            }
                        }

                        c.AttendanceInfo.Add(datevisit, payment);
                    }
                }

                //Подсчет суммы по абонементам купленным в установленные сроки
                foreach (var s in subSel)
                {
                    if (c.ID == (int)s["clientsubid"])
                    {
                        c.Cash += (float)s["subprice"];
                    }
                }
            }

            //Колонка оплата
            attendanceTable.Columns.Add("Оплата");

            //ИТОГО
            float TotalSum = 0;

            //вычитание дат занятий из дат покупки абонементов = даты покупки абонементов не в дату занятия
            hashDatesSubBuy.ExceptWith(hashVisit);

            //заполнение DataTable
            foreach (var client in ClientsList)
            {
                DataRow row = attendanceTable.NewRow();
                row[0] = client;

                //Заполнение покупки абонемента, если абонемент куплен не в дату занятия
                foreach (var cc in allSubscriptions)
                {
                    if (client.ID == cc.CLIENTID)
                    {
                        foreach (var d in hashDatesSubBuy)
                        {
                            for (int i = 0; i < attendanceTable.Columns.Count; i++)
                            {
                                if (cc.SUBDATE.ToShortDateString() == attendanceTable.Columns[i].Caption)
                                    row[i] = string.Format("Купил A : {0}", cc.SUBPRICE);
                            }
                        }
                    }
                }

                //Заполнение дат посещения видом оплаты
                foreach (var dateDict in client.AttendanceInfo)
                {
                    for (int i = 0; i < attendanceTable.Columns.Count; i++)
                    {
                        if (dateDict.Key.ToShortDateString() == attendanceTable.Columns[i].Caption)
                            row[i] = dateDict.Value;
                    }
                }

                row[attendanceTable.Columns.Count - 1] = client.Cash;

                TotalSum += client.Cash;

                attendanceTable.Rows.Add(row);
            }

            //Last Row
            {
                DataRow row = attendanceTable.NewRow();
                row[0] = "Итого:";
                row[attendanceTable.Columns.Count - 1] = TotalSum;
                attendanceTable.Rows.Add(row);
            }

            return attendanceTable;
        }

        public void RemoveAttendance(Client client, DateTime dateVisit)
        {
            throw new NotImplementedException();
        }
    }
}
