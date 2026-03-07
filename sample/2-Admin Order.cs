using MySql.Data.MySqlClient;
using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Coffee_Ordering
{
    public partial class Order_Info : Form
    {
        string connectionString = "server=localhost;port=3306;database=coffeedb;uid=root;pwd=maiaerica;";

        public Order_Info()
        {
            InitializeComponent();
            LoadOrders();
            LoadArchive();
        }

        public void LoadOrders()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM order_table";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        public void LoadArchive()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM order_table";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
            }
        }
        private void btn_arc_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView2.CurrentRow.Cells["id"].Value);

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string copyQuery = "INSERT INTO order_table SELECT * FROM archive_table WHERE id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(copyQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }

                    string deleteQuery = "DELETE FROM archive_table WHERE id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadOrders();
                LoadArchive();

                MessageBox.Show("Order successfully restored to active list!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select an archived order to restore.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_del_data_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("There are no records to delete.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete ALL records from the table?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                if (dataGridView1.DataSource is DataTable dt)
                {
                    dt.Clear();
                }
                else
                {
                    dataGridView1.Rows.Clear();
                }
                MessageBox.Show("All records have been deleted.",
                                "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void btn_a_Click(object sender, EventArgs e)
        {
            LoadOrders();
            tabControl1.SelectedTab = tabPage1;
            MessageBox.Show("Orders have been archived successfully!",
                            "Archive Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void btn_s_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
       "Are you sure you want to delete ALL records? This will also reset the IDs.",
       "Confirm Delete All",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    string connStr = "server=localhost;port=3306;user id=root;password=maiaerica;database=coffeedb;";
                    using (MySqlConnection conn = new MySqlConnection(connStr))
                    {
                        conn.Open();

                        string deleteQuery = "DELETE FROM order_table;";
                        using (MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, conn))
                        {
                            deleteCmd.ExecuteNonQuery();
                        }

                        string resetQuery = "ALTER TABLE order_table AUTO_INCREMENT = 1;";
                        using (MySqlCommand resetCmd = new MySqlCommand(resetQuery, conn))
                        {
                            resetCmd.ExecuteNonQuery();
                        }

                        conn.Close();
                    }

                    if (dataGridView1 != null)
                        dataGridView1.DataSource = null;
                    if (dataGridView2 != null)
                        dataGridView2.DataSource = null;

                    dataGridView1.Rows.Clear();
                    dataGridView2.Rows.Clear();

                    MessageBox.Show("All records deleted successfully, and IDs have been reset!",
                                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while clearing data: " + ex.Message,
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ac add = new ac();
            add.Show();
            this.Hide();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Order_Info_Load(object sender, EventArgs e)
        {

        }
    }
}
