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
    public class BookController
    {
        ConnectionController objCon = new ConnectionController();
        public void insertBook(BookModel newbook)
        {


            string query = $"INSERT INTO libro(titulo, autor, genero, id_estado) VALUES('{newbook.title}','{newbook.author}','{newbook.gender}', {newbook.id_state})";
            try
            {
                if (objCon.Connect())
                {
                    MySqlCommand cmd = new MySqlCommand(query, objCon.getConection());
                    cmd.ExecuteNonQuery();
                    objCon.CloseConnection();
                }
            }
            catch (MySqlException)
            {
                throw;
            }

        }

        public DataTable getBooks()
        {
            DataTable tBook = new DataTable();
            string query = "SELECT * FROM libro";
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

        
        public void deleteBook(int idBook)
        {

            //bool response = false;
            string query = $"DELETE FROM libro WHERE id_libro ="+idBook;
            try
            {
                if (objCon.Connect())
                {
                    MySqlCommand cmd = new MySqlCommand(query, objCon.getConection());
                    cmd.ExecuteNonQuery();
                    objCon.CloseConnection();
                    //response=true;
                }
            }
            catch (MySqlException)
            {
                throw;
                //response = false;
            }
            //return response;
        }

        public DataTable getGender()
        {
            DataTable tBook = new DataTable();
            string query = "SELECT id_libro, genero FROM libro";
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

        public DataTable getAuthor()
        {
            DataTable tBook = new DataTable();
            string query = "SELECT id_libro, autor FROM libro";
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

        public DataTable getTitle()
        {
            DataTable tBook = new DataTable();
            string query = "SELECT id_libro, titulo FROM libro";
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
