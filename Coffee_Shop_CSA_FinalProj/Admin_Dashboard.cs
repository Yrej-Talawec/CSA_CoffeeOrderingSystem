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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnstaff_Click(object sender, EventArgs e)
        {
            Managestaff nextForm = new Managestaff();
            nextForm.Show();
            this.Close();
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {

        }
    }
}
