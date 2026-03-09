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
    public partial class ADMINDB : Form
    {
        public ADMINDB()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                CustomerForm login = new CustomerForm();
                login.Show();
                this.Hide();
            }
        }

        private void ADMINDB_Load(object sender, EventArgs e)
        {
            label3.Enabled = false;
            label3.Visible = false;
            dataGridView1.Enabled = false;
            dataGridView1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Enabled = true;
            label3.Visible = true;
            dataGridView1.Enabled = true;
            dataGridView1.Visible = true;

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            label3.Enabled = false;
            label3.Visible = false;
            dataGridView1.Enabled = false;
            dataGridView1.Visible = false;
        }
    }
}
