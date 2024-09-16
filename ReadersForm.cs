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
    public partial class ReadersForm : Form
    {
        public ReadersForm()
        {
            InitializeComponent();
            FillGrid(dgvListReaders);
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
        public void FillGrid(DataGridView dg)
        {
            MySqlConnection con = new MySqlConnection(Conexion());
            MySqlCommand cmd = new MySqlCommand("select * from lector", con);
            cmd.CommandType = CommandType.Text;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dg.DataSource = dt;

        }
        private void btnOut_Click(object sender, EventArgs e)
        {
            Home Out = new Home();
            Out.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(Conexion());
            string name = txtName.Text;
            string id_number = txtIdNumber.Text;
            string phone = txtPhone.Text;
            try
            {
                string query = $"INSERT INTO lector(nombre_lector, id_identificacion, telefono) VALUES('{name}','{id_number}','{phone}')";

                MySqlCommand cmd = new MySqlCommand(query, con);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Registro añadido exitosamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillGrid(dgvListReaders);
                txtName.Clear();
                txtIdNumber.Clear();
                txtPhone.Clear();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Ha ocurrido un error");
                con.Close();
            }

        }
        private void ModificarLibro()
        {
            string name = txtName.Text;
            string id_number = txtIdNumber.Text;
            string phone = txtPhone.Text;
            MySqlConnection con = new MySqlConnection(Conexion());
            int sel = int.Parse(dgvListReaders.Rows[dgvListReaders.CurrentRow.Index].Cells[0].Value.ToString());
            if (sel > 0)
            {
                try
                {
                    string query = $"UPDATE lector SET nombre_lector='{name}',num_identificacion='{id_number}',telefono='{phone}' WHERE id_lector='{sel}'";

                    MySqlCommand cmd = new MySqlCommand(query, con);


                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Registro actualizado exitosamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillGrid(dgvListReaders);
                    txtName.Clear();
                    txtIdNumber.Clear();
                    txtPhone.Clear();
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
            FillGrid(dgvListReaders);
        }
        private void SeleccionarDatosDg()
        {
            txtName.Text = dgvListReaders.Rows[dgvListReaders.CurrentRow.Index].Cells[1].Value.ToString();
            txtIdNumber.Text = dgvListReaders.Rows[dgvListReaders.CurrentRow.Index].Cells[2].Value.ToString();
            txtPhone.Text = dgvListReaders.Rows[dgvListReaders.CurrentRow.Index].Cells[3].Value.ToString();
            txtName.Focus();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SeleccionarDatosDg();
        }

        private void ReadersForm_Load(object sender, EventArgs e)
        {

        }
    }
}
