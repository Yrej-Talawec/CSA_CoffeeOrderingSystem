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
        string connStr = "server=localhost;port=3306;user id=root;password=coffeeshop;database=coffee_shop_csa;";
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
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM menu_items", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewMenu.DataSource = dt;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();

            cmbCategory.Items.AddRange(new string[] { "Meals", "Drinks", "Desserts", "Snacks" });
            cmbCategoryFilter.Items.AddRange(new string[] { "All", "Meals", "Drinks", "Desserts", "Snacks" });
            cmbCategoryFilter.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string q = "INSERT INTO menu_items(name, category, price, available) VALUES(@n,@c,@p,@a)";
                MySqlCommand cmd = new MySqlCommand(q, conn);

                cmd.Parameters.AddWithValue("@n", txtName.Text);
                cmd.Parameters.AddWithValue("@c", cmbCategory.Text);
                cmd.Parameters.AddWithValue("@p", txtPrice.Text);
                cmd.Parameters.AddWithValue("@a", chkAvailable.Checked);

                cmd.ExecuteNonQuery();
                LoadData();
                ClearFields();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewMenu.CurrentRow == null) return;

            int id = Convert.ToInt32(dataGridViewMenu.CurrentRow.Cells["id"].Value);

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string q = "UPDATE menu_items SET name=@n, category=@c, price=@p, available=@a WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(q, conn);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@n", txtName.Text);
                cmd.Parameters.AddWithValue("@c", cmbCategory.Text);
                cmd.Parameters.AddWithValue("@p", txtPrice.Text);
                cmd.Parameters.AddWithValue("@a", chkAvailable.Checked);

                cmd.ExecuteNonQuery();
                LoadData();
                ClearFields();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewMenu.CurrentRow == null) return;

            int id = Convert.ToInt32(dataGridViewMenu.CurrentRow.Cells["id"].Value);

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string q = "DELETE FROM menu_items WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(q, conn);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                LoadData();
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
