using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Ordering
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string un = txt_un.Text;
            string password = txt_pass.Text;

            if (un == "admin_oaknbeans" && password == "admin123")
            {
                MessageBox.Show(
                "Login successful! Welcome Admin.",
                "Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );

                ac main = new ac();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid email or password. Please try again.",
                                "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            LOGIN LG = new LOGIN();
            LG.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txt_pass.UseSystemPasswordChar = true;
        }
    }
}
