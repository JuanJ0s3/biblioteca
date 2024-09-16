using biblioteca.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca.Controllers
{
    public class StateController
    {
        ConnectionController objCon = new ConnectionController();

        public DataTable getState()
        {
            DataTable tState = new DataTable();
            string query = "SELECT * FROM estado_libro";
            try
            {
                if (objCon.Connect())
                {
                    MySqlCommand cmd = new MySqlCommand(query, objCon.getConection());
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(tState);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return tState;

        }
    }
}
