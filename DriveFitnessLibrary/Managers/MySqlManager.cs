using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using DriveFitnessLibrary.DriveInterfaces;
using System.Data.SqlClient;

namespace DriveFitnessLibrary.Managers
{
    public class MySqlManager : IDataBaseExecutable
    {
        static readonly string connString = @"Data Source=MOUZZ-ПК\SQLEXPRESS;Initial Catalog=drivefitness;Integrated Security=True";
        public static MySqlManager SqlManager { get; set; }
        
        static MySqlManager()
        {
            if (SqlManager == null)
                SqlManager = new MySqlManager();
        }

        public DataTable GetData(string queryyString)
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand command = new SqlCommand(queryyString, con);
            command.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            con.Close();
            return dt;
        }
        
        public void SendCommand(string querryString)
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand command = new SqlCommand(querryString, con);
            command.ExecuteNonQuery();
            con.Close();
        }

        public string GetNextId(string tableName)
        {
            string querry = string.Format("SELECT IDENT_CURRENT('{0}')+1;", tableName);
            DataTable dt = GetData(querry);

            var sel = dt.Select();
            return sel[0].ItemArray[0].ToString();
        }
    }
}
