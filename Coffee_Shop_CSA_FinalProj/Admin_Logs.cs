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
            cbfilter.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        string connStr = "server=localhost;port=3306;user id=root;password=*504487*;database=coffee_shop_csa;";
        private void tableOptions()
        {
            cbfilter.Items.Add("All Logs");
            cbfilter.Items.Add("Edit Menu");
            cbfilter.Items.Add("Staff Management");
            cbfilter.Items.Add("Previous Orders");
        }

        private void MenuOptions()
        {
            cbaction.Items.Add("Insert Item");
            cbaction.Items.Add("Update Menu");
            cbaction.Items.Add("Delete Item");
        }

        private void staffOptions()
        {
            cbaction.Items.Add("Insert Staff");
            cbaction.Items.Add("Update Staff");
            cbaction.Items.Add("Delete Staff");
        }

        private void defaultOptions()
        {
            MenuOptions();
            staffOptions();
        }


        private void LoadData()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT * FROM logs WHERE UAction = @category";

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbfilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
