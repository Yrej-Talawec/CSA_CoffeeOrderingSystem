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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string connStr = "server=localhost;port=3306;user id=root;password=*504487*" +
            ";database=coffee_shop_csa;";
        private void ClearFields()
        {
            txtName.Clear();
            txtPrice.Clear();
            cmbCategory.SelectedIndex = -1;
            chkAvailable.Checked = false;
        }
        private void LoadData()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM beverage_menu", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewMenu.DataSource = dt;
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
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            
            string query = "SELECT DISTINCT category FROM your_table_name";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    cmbCategory.Items.Clear();

                    while (reader.Read())
                    {
                        cmbCategory.Items.Add(reader["category"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            cmbCategoryFilter.SelectedIndex = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string q = "INSERT INTO menu_items(bev_name, category, has_coffee, price, available) VALUES(@n,@c,@p,@a)";
                MySqlCommand cmd = new MySqlCommand(q, conn);

                cmd.Parameters.AddWithValue("@n", txtName.Text);
                cmd.Parameters.AddWithValue("@c", cmbCategory.Text);
                cmd.Parameters.AddWithValue("@p", txtPrice.Text);
                cmd.Parameters.AddWithValue("@a", chkAvailable.Checked);

                cmd.ExecuteNonQuery();
                LoadData();
                ClearFields();
                logRecord("Added to Menu");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewMenu.CurrentRow == null) return;

            int id = Convert.ToInt32(dataGridViewMenu.CurrentRow.Cells["id"].Value);

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string q = "UPDATE beverage_menu SET bev_name=@n, category=@c, price=@p, available=@a WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(q, conn);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@n", txtName.Text);
                cmd.Parameters.AddWithValue("@c", cmbCategory.Text);
                cmd.Parameters.AddWithValue("@p", txtPrice.Text);
                cmd.Parameters.AddWithValue("@a", chkAvailable.Checked);

                cmd.ExecuteNonQuery();
                LoadData();
                ClearFields();
                logRecord("Updated Menu Item");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewMenu.CurrentRow == null) return;

            int id = Convert.ToInt32(dataGridViewMenu.CurrentRow.Cells["id"].Value);

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string q = "DELETE FROM beverage_menu WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(q, conn);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                LoadData();
                logRecord("Removed from Menu");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                string q = "SELECT * FROM menu_items WHERE name LIKE @search";

                if (cmbCategoryFilter.Text != "All")
                {
                    q += " AND category=@cat";
                }

                MySqlDataAdapter da = new MySqlDataAdapter(q, conn);
                da.SelectCommand.Parameters.AddWithValue("@search", "%" + txtSearch.Text + "%");

                if (cmbCategoryFilter.Text != "All")
                {
                    da.SelectCommand.Parameters.AddWithValue("@cat", cmbCategoryFilter.Text);
                }

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewMenu.DataSource = dt;
            }
        }

        private void dataGridViewMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridViewMenu.Rows[e.RowIndex];

                txtName.Text = row.Cells["name"].Value.ToString();
                cmbCategory.Text = row.Cells["category"].Value.ToString();
                txtPrice.Text = row.Cells["price"].Value.ToString();
                chkAvailable.Checked = Convert.ToBoolean(row.Cells["available"].Value);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
