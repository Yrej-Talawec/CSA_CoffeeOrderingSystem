using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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
                OrderForm barista = new OrderForm();
                barista.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
             
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            maskedTextBox1.PasswordChar = '*';
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            CustomerForm form = new CustomerForm();
            form.Show();
            this.Hide();
        }
    }
}
