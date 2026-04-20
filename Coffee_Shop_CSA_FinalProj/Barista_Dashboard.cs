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

namespace Coffee_Shop_CSA_FinalProj
{
    public partial class Barista_Dashboard : Form
    {
        public Barista_Dashboard()
        {
            InitializeComponent();
        }

        //db connection yrej ver
        string connStr = "server=localhost;port=3306;user id=root;password=*504487*;database=coffee_shop_csa;";

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerInfo startorder = new CustomerInfo();
            startorder.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connStr))
                    {
                        conn.Open();


                        //updated status in users when logging off
                        string updatestatusq = "UPDATE users SET status = 'Logged Off' WHERE user_id = @id and user_role = @role";
                        MySqlCommand updateCmd = new MySqlCommand(updatestatusq, conn);
                        updateCmd.Parameters.AddWithValue("@id", CurrentUser.UserID);
                        updateCmd.Parameters.AddWithValue("@role", CurrentUser.UserRole);
                        updateCmd.ExecuteNonQuery();

                        //Log record
                        string logQuery = "INSERT INTO logs (CUserID, UAction, ADescription) VALUES (@id, @action, @desc)";
                        MySqlCommand logCmd = new MySqlCommand(logQuery, conn);

                        logCmd.Parameters.AddWithValue("@id", CurrentUser.UserID);
                        logCmd.Parameters.AddWithValue("@action", "Logged Off");
                        logCmd.Parameters.AddWithValue("@desc", CurrentUser.UserRole + " logged off");

                        logCmd.ExecuteNonQuery();


                        //set current user to null
                        CurrentUser.UserID = 0;
                        CurrentUser.UserRole = "";

                        // Return to log in screen
                        Login_Page login = new Login_Page();
                        login.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Connection Error: " + ex.Message + "\nPlease contact the administrator.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
