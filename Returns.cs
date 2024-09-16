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
    public partial class Returns : Form
    {
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
        public Returns()
        {
            InitializeComponent();

        }
        public void FillGrid(DataGridView dg)
        {
            MySqlConnection con = new MySqlConnection(Conexion());
            MySqlCommand cmd = new MySqlCommand("select * from prestamo", con);
            cmd.CommandType = CommandType.Text;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            //DateTime rewardes_date = rewardes_dtReturn.Value.Date;
            DataTable dt = new DataTable();

            da.Fill(dt);
            dg.DataSource = dt;

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Home Out = new Home();
            Out.Show();
            this.Hide();
        }
        private void SeleccionarDatosDg()
        {
            txtIdReader.Text = dgvBorrowings.Rows[dgvBorrowings.CurrentRow.Index].Cells[2].Value.ToString();
            txtIdBook.Text = dgvBorrowings.Rows[dgvBorrowings.CurrentRow.Index].Cells[1].Value.ToString();
            
            txtIdReader.Focus();
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            SeleccionarDatosDg();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(Conexion());
            int idReader = int.Parse(txtIdReader.Text);
            int idBook = int.Parse(txtIdBook.Text);
            string dateReturn =dtReturn.Value.ToString("yyyy/MM/dd");
            try
            {
                string query = $"INSERT INTO devolucion(id_libro, id_lector, fecha_devolucion) VALUES('{idBook}','{idReader}','{dateReturn}')";

                MySqlCommand cmd = new MySqlCommand(query, con);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Registro añadido exitosamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillGrid(dgvBorrowings);
                txtIdBook.Clear();
                txtIdReader.Clear();
                
            }
            catch (MySqlException)
            {
                MessageBox.Show("Ha ocurrido un error");
                con.Close();
            }
        }

        private void Returns_Load(object sender, EventArgs e)
        {
            FillGrid(dgvBorrowings);
        }
    }
}
