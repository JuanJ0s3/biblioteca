using biblioteca.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca.Controllers
{
    public class UserController
    {
        ConnectionController objCon = new ConnectionController();

        public void InsertUser(UserModel user)
        {
            string query = $"INSERT INTO usuario(nombre_usuario , clave, descripcion) VALUES('{user.nameuser}', '{user.password}', '{user.description}'";
            try
            {
                if(objCon.Connect())
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
    }
}
