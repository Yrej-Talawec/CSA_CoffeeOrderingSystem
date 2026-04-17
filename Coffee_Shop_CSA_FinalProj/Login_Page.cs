using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Coffee_Shop_CSA_FinalProj
{
    public partial class Login_Page : Form
    {
        string connStr = "server=localhost;port=3306;user id=root;password=*504487*;database=coffee_shop_csa;";

        public Login_Page()
        {
            InitializeComponent();
        }

        private void Login_Page_Load(object sender, EventArgs e)
        {

        }

        private void txtBoxPassword_TextChanged(object sender, EventArgs e)
        {
            txtBoxPassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 1. Validation: Ensure no empty fields
            if (string.IsNullOrWhiteSpace(txtBoxEmail.Text) && string.IsNullOrWhiteSpace(txtBoxPassword.Text))
            {
                MessageBox.Show("Please enter your Email and Password.", "Missing Information",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxEmail.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtBoxEmail.Text))
            {
                MessageBox.Show("Email field is empty. Please enter your email.", "Missing Information",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxEmail.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtBoxPassword.Text))
            {
                MessageBox.Show("Password field is empty. Please enter your password.", "Missing Information",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxPassword.Focus();
                return;
            }

            // 2. Extra Validation: Ensure it's a gmail address (matches your DB constraint)
            if (!txtBoxEmail.Text.Trim().ToLower().EndsWith("@gmail.com"))
            {
                MessageBox.Show("Invalid format. Please use a @gmail.com account.", "Login Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    // 
                    string sql = "SELECT user_id, user_role FROM users WHERE user_email = @email AND user_password = @pass";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@email", txtBoxEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", txtBoxPassword.Text.Trim());

                    // ExecuteScalar gets the 'user_role' (Admin or Barista)
                    MySqlDataReader reader = cmd.ExecuteReader();


                    if (reader.Read())
                    {
                        int userId = Convert.ToInt32(reader["user_id"]);
                        string userRole = reader["user_role"].ToString();
                        reader.Close(); 

                        //updated status in users when user logs in
                        string updatestatusq = "UPDATE users SET status = 'Logged In' WHERE user_id = @id";
                        MySqlCommand updateCmd = new MySqlCommand(updatestatusq, conn);
                        updateCmd.Parameters.AddWithValue("@id", userId);
                        updateCmd.ExecuteNonQuery();

                        //Log record
                        string logQuery = "INSERT INTO logs (CUserID, UAction, ADescription) VALUES (@id, @action, @desc)";
                        MySqlCommand logCmd = new MySqlCommand(logQuery, conn);

                        logCmd.Parameters.AddWithValue("@id", userId);
                        logCmd.Parameters.AddWithValue("@action", "Logged In");
                        logCmd.Parameters.AddWithValue("@desc", userRole + " logged in");

                        logCmd.ExecuteNonQuery();



                        // 4. Role-Based Redirection
                        if (userRole == "Admin")
                        {
                            MessageBox.Show("Welcome, Administrator!", "Admin Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Admin_Dashboard adminForm = new Admin_Dashboard();
                            adminForm.Show();
                        }
                        else if (userRole == "Barista")
                        {
                            MessageBox.Show("Welcome, Barista!", "Staff Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //WAIT LANG TTOOOOOOOOOOOO
                            //Customer_Info orderForm = new Customer_Info();
                            //orderForm.Show();
                            CustomerInfo orderForm = new CustomerInfo();
                            orderForm.Show();
                            this.Hide();
                        }

                        // Success! Hide the login screen
                        this.Hide();
                    }
                    else
                    {
                        // No match found
                        MessageBox.Show("Invalid Email or Password.", "Access Denied",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                        txtBoxPassword.Clear();
                        txtBoxEmail.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Error: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
