using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bigbrew
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && maskedTextBox1.Text == "admin")
            {
                ADMINDB admin = new ADMINDB();
                admin.Show();
                this.Hide();
            }
            else if (textBox1.Text == "barista" && maskedTextBox1.Text == "barista")
            {
                BARISTADB barista = new BARISTADB();
                barista.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {
            maskedTextBox1.PasswordChar = '*';
        }
    }
}
