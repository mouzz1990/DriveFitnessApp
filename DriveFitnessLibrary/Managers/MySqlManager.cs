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
        static readonly string connString = "server=192.168.0.1;database=drivefitness;pwd=root;user=root;";

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

        //public DataTable GetAttendanceTable(int groupId, DateTime startDate, DateTime endDate)
        //{
            
        //}

        //public List<Group> GetGroups()
        //{
        //    List<Group> GroupList = new List<Group>();
        //    DataTable dt = SqlManager.GetData("SELECT * FROM groups");
            
            
        //    DataRow[] rows = dt.Select();
        //    foreach (var r in rows)
        //    {
        //        GroupList.Add(new Group(
        //            (int)r["id"], 
        //            (string)r["groupname"], 
        //            GetClients((int)r["id"]))
        //            );
        //    }

        //    return GroupList;
        //}

        //List<Client> GetClients(int groupId)
        //{
        //    List<Client> ClientsList = new List<Client>();
        //    DataTable dt = SqlManager.GetData("SELECT * FROM clients " +
        //        "LEFT JOIN groups on groupid = groups.id " +
        //        "LEFT JOIN subscription on subscriptionid = subscription.id " +
        //        "WHERE groupid = " + groupId);

        //    DataRow[] rows = dt.Select();
        //    foreach (var r in rows)
        //    {
        //        Subscription sub = null;
        //        if (int.TryParse(r["subscriptionid"].ToString(), out int subid))
        //        {
        //            sub = new Subscription(
        //                (int)r["subscriptionid"],
        //                (int)r["count"],
        //                (float)r["subprice"],
        //                (DateTime)r["subdate"],
        //                (int)r["clientsubid"]
        //                );
        //        }

        //        ClientsList.Add(new Client(
        //            (int)r["id"],
        //            (string)r["name"],
        //            (string)r["lastname"],
        //            (DateTime)r["birthday"],
        //            (string)r["email"],
        //            (string)r["telephone"],
        //            //new Group((int)r["groupid"], (string)r["groupname"]),
        //            sub
        //            )
        //            );
        //    }

        //    return ClientsList;
        //}

    }
}
