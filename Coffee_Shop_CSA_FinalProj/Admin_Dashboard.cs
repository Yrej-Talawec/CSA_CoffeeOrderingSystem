using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Shop_CSA_FinalProj
{
    public partial class Admin_Dashboard : Form
    {
        public Admin_Dashboard()
        {
            InitializeComponent();
        }

        //db connection
        string connStr = "server=localhost;port=3306;user id=root;password=*504487*;database=coffee_shop_csa;";

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnstaff_Click(object sender, EventArgs e)
        {
            Managestaff nextForm = new Managestaff();
            nextForm.Show();

        }

        private void btnmenu_Click(object sender, EventArgs e)
        {

        }

        private void btnreports_Click(object sender, EventArgs e)
        {
            Admin_Logs al = new Admin_Logs();
            al.Show();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
