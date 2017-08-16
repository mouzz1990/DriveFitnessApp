using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using DriveFitnessLibrary.DriveInterfaces;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace DriveFitnessLibrary.Managers
{
    public class ReportManager : IReportManager
    {
        IDataBaseExecutable DataBaseManager;
        IMessager messager;
        DateTimeFormatter dtFormatter;

        public ReportManager(IDataBaseExecutable DataBaseManager, IMessager messager)
        {
            this.DataBaseManager = DataBaseManager;
            this.messager = messager;
            dtFormatter = new DateTimeFormatter();
        }

        public DataTable GetAttendanceData(Group group, DateTime startDate, DateTime endDate)
        {
            //получение всех дат занятий
            string stDt = startDate.ToString("yyyy-MM-dd");
            string enDt = endDate.ToString("yyyy-MM-dd");

            string querry = string.Format(dtFormatter,
                "SELECT DISTINCT DateVisit FROM [drivefitness].[dbo].[Attendance] " +
                "JOIN [drivefitness].[dbo].[Client] on [drivefitness].[dbo].[Attendance].[ClientId] = [drivefitness].[dbo].[Client].[ClientId] " +
                "WHERE [DateVisit] >= '{0}' " +
                "and [DateVisit] <= '{1}' " +
                "and [GroupId] = '{2}' ORDER BY [DateVisit]; ",
                //"call get_attendance_dates_by_group('{0}','{1}','{2}')",
                startDate,
                endDate,
                group.ID
                );

            DataTable DatesVisit = DataBaseManager.GetData(querry);

            //получение БД по посещяемости занятий
            //!!!!!
            querry = string.Format("SELECT * FROM [drivefitness].[dbo].[Attendance]");
            //querry = string.Format("SELECT * FROM attendance WHERE datevisit >= '{0}' AND datevisit <= {1}", stDt, enDt);

            DataTable Attendance = DataBaseManager.GetData(querry);

            //получение информации о всех клиентах
            querry = "SELECT * FROM [drivefitness].[dbo].[Client] " +
                "JOIN [drivefitness].[dbo].[Group] on [drivefitness].[dbo].[Client].[GroupId] = [drivefitness].[dbo].[Group].[GroupId] " +
                "LEFT JOIN [drivefitness].[dbo].[Subscription] on [drivefitness].[dbo].[Client].[SubscriptionId] = [drivefitness].[dbo].[Subscription].[SubscriptionId] " +
                "WHERE [drivefitness].[dbo].[Group].[GroupId] = " + group.ID;

            DataTable Clients = DataBaseManager.GetData(querry);

            //Создание таблицы для ее формирования и вывда в datagridview
            DataTable attendanceTable = new DataTable("Attendance");

            //создание первого столбца  Клиент
            attendanceTable.Columns.Add("Клиент");

            //Получение всех купленных абониментов в установленных сроках
            string subQuerry = string.Format(dtFormatter, "SELECT * FROM [drivefitness].[dbo].[Subscription] " +
                                                 "LEFT JOIN [drivefitness].[dbo].[Client] ON [drivefitness].[dbo].[Subscription].[ClientSubscriptionId] = [drivefitness].[dbo].[Client].[ClientId] " +
                                                 "WHERE [SubscriptionDate] >= '{0}' AND [SubscriptionDate]<= '{1}' AND [GroupId] = {2}",
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
                                       ID = (int)a["SubscriptionId"],
                                       COUNT = (int)a["SubscriptionCountExcercise"],
                                       SUBPRICE = (float)a["SubscriptionPrice"],
                                       SUBDATE = (DateTime)a["SubscriptionDate"],
                                       CLIENTID = (int)a["ClientSubscriptionId"]
                                   };

            //Список дат посещений и покупки абонементов
            List<DateTime> datesList = new List<DateTime>();
            HashSet<DateTime> hashDatesSubBuy = new HashSet<DateTime>();
            HashSet<DateTime> hashVisit = new HashSet<DateTime>();

            //добавление дат покупки абонементов
            foreach (var d in subSel)
            {
                datesList.Add((DateTime)d["SubscriptionDate"]);
                hashDatesSubBuy.Add((DateTime)d["SubscriptionDate"]);
            }

            //добавление дат посещений
            foreach (var dates in DatesVisit.Select())
            {
                datesList.Add((DateTime)dates["DateVisit"]);
                hashVisit.Add((DateTime)dates["DateVisit"]);
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
                int subid;
                if (int.TryParse(client["SubscriptionId"].ToString(), out subid))
                {
                    subscr = new Subscription(
                        subid,
                        (int)client["SubscriptionCountExcercise"],
                        (float)client["SubscriptionPrice"],
                        (DateTime)client["SubscriptionDate"],
                        (int)client["ClientSubscriptionId"]
                        );

                }
                else subscr = null;

                ClientsList.Add(new Client(
                    (int)client["ClientId"],
                    (string)client["ClientName"],
                    (string)client["ClientLastname"],
                    (DateTime)client["ClientBirthday"],
                    (string)client["ClientEmail"],
                    (string)client["ClientTelephone"],
                    //new Group((int)client["groupid"], (string)client["groupname"]),
                    subscr

                    ));
            }

            //Заполнение посещаемости клиентов
            var attData = Attendance.Select(string.Format("DateVisit >= #{0}# and DateVisit <= #{1}#", stDt, enDt));
            foreach (var c in ClientsList)
            {
                foreach (var a in attData)
                {
                    DateTime datevisit = (DateTime)a["DateVisit"];
                    string payment = a["Payment"].ToString();

                    if (c.ID == (int)a["ClientId"])
                    {
                        c.Cash += (float)a["AttendancePrice"];

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
                    if (c.ID == (int)s["ClientSubscriptionId"])
                    {
                        c.Cash += (float)s["SubscriptionPrice"];
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

        public void CreateReport(DataTable data, string saveToPath)
        {
            if (data == null)
            {
                messager.ErrorMessage("Ошибка получения отчетной таблицы! Повторите попытку или обратитесь к разработчику.");
                return;
            }

            if (string.IsNullOrEmpty(saveToPath) || string.IsNullOrWhiteSpace(saveToPath))
            {
                messager.ErrorMessage(string.Format("Ошибка в указанном пути файла:{1}\"{0}\",{1}укажите правильный путь и имя файла!", 
                    saveToPath,
                    Environment.NewLine
                    ));

                return;
            }

            if (!Directory.Exists(Path.GetDirectoryName(saveToPath)))
                Directory.CreateDirectory(Path.GetDirectoryName(saveToPath));

            try
            {
                Excel.Application eApp = new Excel.Application();
                Excel.Workbook wBook = eApp.Workbooks.Add();
                Excel.Worksheet wSheet = wBook.Worksheets.Add();

                for (int i = 0; i < data.Columns.Count; i++)
                {
                    wSheet.Cells[1, i + 1] = data.Columns[i].ColumnName;
                }

                for (int i = 0; i < data.Rows.Count; i++)
                {
                    for (int j = 0; j < data.Columns.Count; j++)
                    {
                        wSheet.Cells[i + 2, j + 1] = data.Rows[i][j];
                    }
                }

                //finding a last cell
                Excel.Range r1 = wSheet.Cells.get_End(Excel.XlDirection.xlToRight);
                Excel.Range r2 = wSheet.Cells.get_End(Excel.XlDirection.xlDown);

                string rightEnd = r1.get_Address().Split('$')[1];   //letter
                string bottomEnd = r2.get_Address().Split('$')[2];  //number

                //last cell address
                string lastCell = rightEnd + bottomEnd;
                
                //painting grid
                List<Excel.XlBordersIndex> borders = new List<Excel.XlBordersIndex>()
                {
                    Excel.XlBordersIndex.xlEdgeRight,
                    Excel.XlBordersIndex.xlEdgeLeft,
                    Excel.XlBordersIndex.xlEdgeBottom,
                    Excel.XlBordersIndex.xlEdgeTop,
                    Excel.XlBordersIndex.xlInsideHorizontal,
                    Excel.XlBordersIndex.xlInsideVertical
                };

                foreach (Excel.XlBordersIndex brd in borders)
                {
                    Excel.Range r = wSheet.get_Range("A1", lastCell);

                    r.Borders[brd].Weight = Excel.XlBorderWeight.xlThin;
                    r.Borders[brd].LineStyle = Excel.XlLineStyle.xlContinuous;
                    r.Borders[brd].ColorIndex = 0;
                }

                wSheet.get_Range("A1", lastCell).Font.Size = 14;

                wSheet.Columns.AutoFit();

                wBook.SaveAs(saveToPath);
                eApp.Visible = true;
            }
            catch
            {
                messager.ErrorMessage(string.Format("Ошибка создания документа Microsoft Office Excel - \"{0}\"{1}{1}Обратитесь к разработчику!", 
                    Path.GetFileName(saveToPath),
                    Environment.NewLine
                    ));
            }
        }
    }
}
