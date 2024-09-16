using biblioteca.Controllers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class Borrowing : Form
    {
        ReaderController myReader = new ReaderController();
        BookController myBook = new BookController();
        public Borrowing()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Home Out = new Home();
            Out.Show();
            this.Hide();
        }
        private string Conexion()
        {
            MySqlConnection conect = new MySqlConnection();
            string server1 = "localhost";
            string port1 = "3306";
            string user1 = "root";
            string pwd1 = "";
            string db1 = "biblioteca_tecoc";
            string con = $"server={server1}; port={port1}; user id={user1}; password={pwd1}; database={db1};";

            return con;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            int IdReaderSelected = int.Parse(cmbReader.SelectedValue.ToString());
            int IdBookSelected = int.Parse(cmbBook.SelectedValue.ToString());
            MySqlConnection con = new MySqlConnection(Conexion());
            int reader = IdReaderSelected;
            int book = IdBookSelected;
            string dateborrowing = dtBorrowing.Value.ToString("yyyy/MM/dd");
            string dateExpiration = dtExpire.Value.ToString("yyyy/MM/dd");
            
            
            try
            {
                string query = $"INSERT INTO prestamo(id_libro, id_lector, fecha_prestamo, fecha_vencimiento) VALUES('{book}','{reader}','{dateborrowing}', '{dateExpiration}')";

                MySqlCommand cmd = new MySqlCommand(query, con);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Prestamo registrado exitosamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException)
            {
                MessageBox.Show("Ha ocurrido un error");
                throw;
                con.Close();
            }

        }

        private void Borrowing_Load(object sender, EventArgs e)
        {
            cmbBook.DataSource = myBook.getBooks();
            cmbBook.DisplayMember = "titulo";
            cmbBook.ValueMember = "id_libro";

            cmbReader.DataSource = myReader.getReaders();
            cmbReader.DisplayMember = "nombre_lector";
            cmbReader.ValueMember = "id_lector";
        }
    }
}
