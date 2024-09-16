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
    public class ReaderController
    {
        ConnectionController objCon = new ConnectionController();

        public void InsertUser(ReaderModel reader)
        {
            string query = $"INSERT INTO lector(nombre_lector , num_identificacion, telefono) VALUES('{reader.name}', '{reader.id_number}', '{reader.phone}'";
            try
            {
                if (objCon.Connect())
                {
                    MySqlCommand cmd = new MySqlCommand(query, objCon.getConection());
                    cmd.ExecuteNonQuery();
                    objCon.CloseConnection();
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        public DataTable getReaders()
        {
            DataTable tBook = new DataTable();
            string query = "SELECT * FROM lector";
            try
            {
                if (objCon.Connect())
                {
                    MySqlCommand cmd = new MySqlCommand(query, objCon.getConection());
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(tBook);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return tBook;

        }
    }
}

