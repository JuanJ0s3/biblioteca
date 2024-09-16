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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            Form1 Out = new Form1();
            Out.Show();
            this.Hide();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            Books Out = new Books();
            Out.Show();
            this.Hide();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            ReadersForm Out= new ReadersForm();
            Out.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reports Out = new Reports();
            Out.Show();
            this.Hide();
        }

        private void btnBorrowing_Click(object sender, EventArgs e)
        {
            Borrowing Out = new Borrowing();
            Out.Show();
            this.Hide();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Returns Out = new Returns();
            Out.Show();
            this.Hide();
        }
    }
}
