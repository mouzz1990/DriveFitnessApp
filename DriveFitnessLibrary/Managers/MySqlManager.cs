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
    }
}
