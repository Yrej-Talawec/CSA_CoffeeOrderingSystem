using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Managestaff : Form
    {
        public Managestaff()
        {
            InitializeComponent();
        }
        string connStr = "server=localhost;port=3306;user id=root;password=*504487*;database=coffee_shop_csa;";
        private void Form1_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                LoadData();
            }
        }
        private void LoadData()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT * FROM user";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void logRecord(string action)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                //Log record
                string logQuery = "INSERT INTO logs (CUserID, UAction, ADescription) VALUES (@id, @action, @desc)";
                MySqlCommand logCmd = new MySqlCommand(logQuery, conn);

                logCmd.Parameters.AddWithValue("@id", CurrentUser.UserID);
                logCmd.Parameters.AddWithValue("@action", action);
                logCmd.Parameters.AddWithValue("@desc", $"{CurrentUser.UserRole} {action}");

                logCmd.ExecuteNonQuery();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string q = "INSERT INTO users(user_name, user_email, user_password, user_role, salary) VALUES(@n, @e, @p,@r,@s)";
                MySqlCommand cmd = new MySqlCommand(q, conn);

                cmd.Parameters.AddWithValue("@n", txtName.Text);
                cmd.Parameters.AddWithValue("@e", txtEmail.Text);
                cmd.Parameters.AddWithValue("@p", txtPassword.Text);
                cmd.Parameters.AddWithValue("@r", txtPosition.Text);
                cmd.Parameters.AddWithValue("@s", txtSalary.Text);

                cmd.ExecuteNonQuery();
                LoadData();
                logRecord("Added a staff");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string q = "UPDATE employees SET name=@n, position=@p, salary=@s WHERE id=@id";
                    MySqlCommand cmd = new MySqlCommand(q, conn);

                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@n", txtName.Text);
                    cmd.Parameters.AddWithValue("@p", txtPosition.Text);
                    cmd.Parameters.AddWithValue("@s", txtSalary.Text);

                    cmd.ExecuteNonQuery();
                    LoadData();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string q = "DELETE FROM users WHERE id=@id";
                    MySqlCommand cmd = new MySqlCommand(q, conn);

                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();

                    LoadData();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string q = "SELECT * FROM employees WHERE name LIKE @search OR position LIKE @search";

                MySqlDataAdapter da = new MySqlDataAdapter(q, conn);
                da.SelectCommand.Parameters.AddWithValue("@search", "%" + txtSearch.Text + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];

                txtName.Text = row.Cells["name"].Value.ToString();
                txtPosition.Text = row.Cells["position"].Value.ToString();
                txtSalary.Text = row.Cells["salary"].Value.ToString();
            }
        }
    }
}
