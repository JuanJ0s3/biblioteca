using biblioteca.Controllers;
using biblioteca.Models;
using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Net.Mime.MediaTypeNames;

namespace biblioteca
{
    public partial class Books : Form
    {
        StateController myState = new StateController();
        BookController myBook = new BookController();
        public Books()
        {
            InitializeComponent();

        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            Home Out = new Home();
            Out.Show();
            this.Hide();
        }

        private void Books_Load(object sender, EventArgs e)
        {
            cmbState.DataSource = myState.getState();
            cmbState.DisplayMember = "estado";
            cmbState.ValueMember = "id_estado";
            FillGrid(dgvListBooks);
        }

        public void FillGrid(DataGridView dg)
        {
            MySqlConnection con = new MySqlConnection(Conexion());
            MySqlCommand cmd = new MySqlCommand("select *from libro", con);
            cmd.CommandType = CommandType.Text;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dg.DataSource = dt;

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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(Conexion());
            string title = txtAuthor.Text;
            string author = txtAuthor.Text;
            string gender = txtGender.Text;
            int IdSelected = int.Parse(cmbState.SelectedValue.ToString());
            int id_state = IdSelected;
            try
            {
                string query = $"INSERT INTO libro(titulo, autor, genero, id_estado) VALUES('{title}','{author}','{gender}', {id_state})";

                MySqlCommand cmd = new MySqlCommand(query, con);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Registro añadido exitosamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillGrid(dgvListBooks);
                txtGender.Clear();
                txtAuthor.Clear();
                txtTitle.Clear();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Ha ocurrido un error");
                con.Close();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int sel = int.Parse(dgvListBooks.Rows[dgvListBooks.CurrentRow.Index].Cells[0].Value.ToString());
            if (sel > 0)
            {
                myBook.deleteBook(sel);
                MessageBox.Show("Registro eliminado con exito");
                FillGrid(dgvListBooks);
            }
            else
            {
                MessageBox.Show("No se ha seleccionado Registro ");
            }
        }

        private void SeleccionarDatosDg()
        {
            txtTitle.Text = dgvListBooks.Rows[dgvListBooks.CurrentRow.Index].Cells[1].Value.ToString();
            txtAuthor.Text = dgvListBooks.Rows[dgvListBooks.CurrentRow.Index].Cells[2].Value.ToString();
            txtGender.Text = dgvListBooks.Rows[dgvListBooks.CurrentRow.Index].Cells[3].Value.ToString();
            txtTitle.Focus();
        }
        private void dgvListBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SeleccionarDatosDg();
        }
        private void ModificarLibro()
        {
            string title = txtAuthor.Text;
            string author = txtAuthor.Text;
            string gender = txtGender.Text;
            int IdSelected = int.Parse(cmbState.SelectedValue.ToString());
            int id_state = IdSelected;
            MySqlConnection con = new MySqlConnection(Conexion());
            int sel = int.Parse(dgvListBooks.Rows[dgvListBooks.CurrentRow.Index].Cells[0].Value.ToString());
            if (sel > 0)
            {
                try
                {
                    string query = $"UPDATE libro SET titulo='{title}',autor='{author}',genero='{gender}',id_estado='{id_state}' WHERE id_libro='{sel}'";

                    MySqlCommand cmd = new MySqlCommand(query, con);


                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Registro actualizado exitosamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillGrid(dgvListBooks);
                    txtGender.Clear();
                    txtAuthor.Clear();
                    txtTitle.Clear();
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Ha ocurrido un error");
                    con.Close();

                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ModificarLibro();
            FillGrid(dgvListBooks);
        }
    }
}
