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
using System.Data;

namespace Coffee_Ordering
{
    public partial class _2_Admin_Acc : Form
    {
        string connectionString = "Server=localhost;Port=3306;Database=cafe_accdb;Uid=root;Pwd=maiaerica;";
        public _2_Admin_Acc()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM acctable";
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }
        private void LoadAdminAccounts()
        {
            string connStr = "server=localhost;port=3306;user id=root;password=maiaerica;database=coffeedb;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT username, password FROM admin_accounts";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void _2_Admin_Acc_Load_1(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_name.Text) ||
            string.IsNullOrWhiteSpace(txt_add.Text) ||
            string.IsNullOrWhiteSpace(txt_un.Text) ||
            string.IsNullOrWhiteSpace(txt_pass.Text) ||
            string.IsNullOrWhiteSpace(txt_ct.Text))
            {
                MessageBox.Show("Please fill out all fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(txt_name.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Name must contain letters only.", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string contact = txt_ct.Text.Trim();
            if (contact.Length != 11 || !System.Text.RegularExpressions.Regex.IsMatch(contact, @"^[0-9]+$"))
            {
                MessageBox.Show("Contact number must be exactly 11 digits and contain numbers only.", "Invalid Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string username = txt_un.Text.Trim();
            if (username.Length < 4)
            {
                MessageBox.Show("Username must be at least 4 characters long.", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txt_pass.Text.Length > 50)
            {
                MessageBox.Show("Password must not exceed 50 characters.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = "server=localhost;port=3306;user id=root;password=maiaerica;database=cafe_accdb;";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string query = "INSERT INTO acctable (`Name`, `Contact Number`, `Address`, `Username`, `Password`) " +
                                   "VALUES (@Name, @ContactNumber, @Address, @Username, @Password)";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Name", txt_name.Text.Trim());
                    cmd.Parameters.AddWithValue("@ContactNumber", contact);
                    cmd.Parameters.AddWithValue("@Address", txt_add.Text.Trim());
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", txt_pass.Text.Trim());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Account saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData();

                    txt_name.Clear();
                    txt_un.Clear();
                    txt_pass.Clear();
                    txt_add.Clear();
                    txt_ct.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_name.Clear();
            txt_un.Clear();
            txt_pass.Clear();
            txt_add.Clear();
            txt_ct.Clear();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            ac add = new ac();
            add.Show();
            this.Hide();
        }

        private void txt_age_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

