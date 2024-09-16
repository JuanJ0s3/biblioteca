using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca.Controllers
{
    public class ConnectionController
    {
        MySqlConnection conect = new MySqlConnection();
        static string server1 = "localhost";
        static string port1 = "3306";
        static string user1 = "root";
        static string pwd1 = "";
        static string db1 = "biblioteca_tecoc";
        string stringConnection = $"server={server1}; port={port1}; user id={user1}; password={pwd1}; database={db1};";

        public bool Connect()
        {
            try
            {
                conect.ConnectionString = stringConnection;
                conect.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                conect.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public MySqlConnection getConection()
        {
            return conect;
        }

    }
}
