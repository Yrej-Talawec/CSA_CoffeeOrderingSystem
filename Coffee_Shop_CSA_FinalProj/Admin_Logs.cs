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
    public partial class Admin_Logs : Form
    {
        public Admin_Logs()
        {
            InitializeComponent();
        }
        string connStr = "server=localhost;port=3306;user id=root;password=coffeeshop;database=coffee_shop_csa;";

        private void LoadData()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT * FROM logs";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    dataGridView1.Columns["CUserID"].HeaderText = "ID";
                    dataGridView1.Columns["username"].HeaderText = "Username";
                    dataGridView1.Columns["status"].HeaderText = "Account Status";
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Connection Error: " + ex.Message, "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void Admin_Logs_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
