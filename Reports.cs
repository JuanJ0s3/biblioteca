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
    public partial class Reports : Form
    {
        BookController myBook = new BookController();
        public Reports()
        {
            InitializeComponent();
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
        private void FillcmbTitle()
        {

            cmbFill.DisplayMember = "titulo";
            cmbFill.ValueMember = "id_libro";
            cmbFill.DataSource = myBook.getTitle();
        }
        private void FillcmbGender()
        {

            cmbFill.DisplayMember = "genero";
            cmbFill.ValueMember = "id_libro";
            cmbFill.DataSource = myBook.getGender();
        }
        private void FillcmbAuthor()
        {

            cmbFill.DisplayMember = "autor";
            cmbFill.ValueMember = "id_libro";
            cmbFill.DataSource = myBook.getAuthor();
        }
        private void Reports_Load(object sender, EventArgs e)
        {
            //FillcmbTitle();
            //FillcmbGender();
            //FillcmbAuthor();




        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            Home Out = new Home();
            Out.Show();
            this.Hide();
        }
        public void FillActualState(DataGridView dg)
        {
            MySqlConnection con = new MySqlConnection(Conexion());
            MySqlCommand cmd = new MySqlCommand("select * from libro", con);
            cmd.CommandType = CommandType.Text;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dg.DataSource = dt;

        }
        private void btnActualState_Click(object sender, EventArgs e)
        {
            FillActualState(dgvReports);
        }
        public void FillMoreBorrowings(DataGridView dg)
        {
            MySqlConnection con = new MySqlConnection(Conexion());
            MySqlCommand cmd = new MySqlCommand("select * from libro l INNER JOIN (SELECT * " +
                "FROM prestamo GROUP BY id_libro HAVING COUNT(*)>1) p ON l.id_libro=p.id_libro;", con);
            cmd.CommandType = CommandType.Text;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dg.DataSource = dt;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            FillMoreBorrowings(dgvReports);
        }

        private void btnExpirateBooks_Click(object sender, EventArgs e)
        {

        }

        public void FillGender(DataGridView dg)
        {
            MySqlConnection con = new MySqlConnection(Conexion());
            MySqlCommand cmd = new MySqlCommand("select * from libro", con);
            cmd.CommandType = CommandType.Text;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dg.DataSource = dt;

        }
        private void btnTitle_Click(object sender, EventArgs e)
        {
            //query

        }

        private void btnAuthor_Click(object sender, EventArgs e)
        {

        }

        private void btnGender_Click(object sender, EventArgs e)
        {

            FillcmbTitle();
            cmbFill.Refresh();
        }

        private void cmbFill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAuthor_Click_1(object sender, EventArgs e)
        {

            FillcmbAuthor();
            cmbFill.Refresh();
        }

        private void btnGender_Click_1(object sender, EventArgs e)
        {

            FillcmbGender();
            cmbFill.Refresh();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(checkedListBox1.GetItemChecked(0)== true)
            {
                txtFill.Text = "titulo";
            }
            else
                if(checkedListBox1.GetItemChecked(1)== true)
                {
                txtFill.Text = "autor";
            }
            else
                if (checkedListBox1.GetItemChecked(2) == true)
                {
                    txtFill.Text = "genero";
                }
        }
    }
}
