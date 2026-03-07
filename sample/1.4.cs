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

namespace Coffee_Ordering
{
    public partial class form_lg1 : Form
    {
        public form_lg1()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;port=3306;user id=root;password=maiaerica;database=cafe_accdb;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM acctable WHERE username = @Username AND password = @Password";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", txt_email.Text);
                        cmd.Parameters.AddWithValue("@Password", txt_pass.Text);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Login Successful!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            CustomerForm CF = new CustomerForm();
                            CF.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid email or password!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void form_lg1_Load(object sender, EventArgs e)
        {
            txt_pass.UseSystemPasswordChar = true;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            LOGIN LG = new LOGIN();
            LG.Show();
            this.Hide();
        }
    }
}
