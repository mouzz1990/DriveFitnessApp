using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using DriveFitnessLibrary.DriveInterfaces;

namespace DriveFitnessLibrary.Managers
{
    public class MySqlManager : IDataBaseExecutable
    {
        public static MySqlManager SqlManager { get; set; }
        static readonly string connString = "server=localhost;database=drivefitness;pwd=root;user=root;";

        static MySqlManager()
        {
            if (SqlManager == null)
                SqlManager = new MySqlManager();
        }

        public DataTable GetData(string querryString)
        {
            //creating a connection
            MySqlConnection con = new MySqlConnection(connString);
            con.Open();

            //creating a command
            MySqlCommand command = new MySqlCommand(querryString, con);
            command.ExecuteNonQuery();

            //creating dataadapter 
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();

            //Filling datatable
            adapter.Fill(dt);

            con.Close();

            return dt;
        }

        public void SendCommand(string querryString)
        {
            MySqlConnection con = new MySqlConnection(connString);
            con.Open();
            MySqlCommand command = new MySqlCommand(querryString, con);
            command.ExecuteNonQuery();
            con.Close();
        }

        public string GetNextId(string tableName)
        {
            string querry = string.Format("SELECT auto_increment FROM information_schema.tables WHERE table_name='{0}';", tableName);
            DataTable dt = GetData(querry);

            var sel = dt.Select();
            return sel[0].ItemArray[0].ToString();
        }

        public DataTable GetAttendanceTable(int groupId, DateTime startDate, DateTime endDate)
        {
            //получение всех дат занятий
            string stDt = startDate.ToString("yyyy-MM-dd");
            string enDt = endDate.ToString("yyyy-MM-dd");

            string querry = "call get_attendance_dates_by_group('"
                + stDt + "', '" +
                enDt + "', " +
                groupId +
                ")";

            DataTable DatesVisit = GetData(querry);

            //получение БД по посещяемости занятий
            //!!!!!
            querry = string.Format("SELECT * FROM attendance");
            //querry = string.Format("SELECT * FROM attendance WHERE datevisit >= '{0}' AND datevisit <= {1}", stDt, enDt);

            DataTable Attendance = GetData(querry);

            //получение информации о всех клиентах
            querry = "SELECT * FROM drivefitness.clients " +
                "JOIN groups on groupid = groups.id " +
                "LEFT JOIN subscription on subscriptionid = subscription.id " +
                "WHERE groupid = " + groupId;

            DataTable Clients = GetData(querry);

            //Создание таблицы для ее формирования и вывда в datagridview
            DataTable attendanceTable = new DataTable("Attendance");

            //создание первого столбца  Клиент
            attendanceTable.Columns.Add("Клиент");

            //Получение всех купленных абониментов в установленных сроках
            string subQuerry = string.Format("SELECT * FROM subscription " +
                                                 "LEFT JOIN clients ON clientsubid = clients.id " +
                                                 "WHERE subdate >= '{0}' AND subdate <= '{1}' AND groupid = {2}",
                                                 stDt,
                                                 enDt,
                                                 groupId
                                                 );

            DataTable SubscriptionTable = SqlManager.GetData(subQuerry);
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

        public List<Group> GetGroups()
        {
            List<Group> GroupList = new List<Group>();
            DataTable dt = SqlManager.GetData("SELECT * FROM groups");
            
            
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

        List<Client> GetClients(int groupId)
        {
            List<Client> ClientsList = new List<Client>();
            DataTable dt = SqlManager.GetData("SELECT * FROM clients LEFT JOIN groups on groupid = groups.id LEFT JOIN subscription on subscriptionid = subscription.id WHERE groupid = " + groupId);

            DataRow[] rows = dt.Select();
            foreach (var r in rows)
            {
                Subscription sub = null;
                if (int.TryParse(r["subscriptionid"].ToString(), out int subid))
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
                    //new Group((int)r["groupid"], (string)r["groupname"]),
                    sub
                    )
                    );
            }

            return ClientsList;
        }
    }
}
