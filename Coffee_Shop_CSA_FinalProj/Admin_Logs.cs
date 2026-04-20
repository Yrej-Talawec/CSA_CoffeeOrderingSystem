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
            cbaction.DropDownStyle = ComboBoxStyle.DropDownList;
            tableOptions();
            cbaction.Enabled = false;
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
            cbaction.Items.Add("Added to Menu");
            cbaction.Items.Add("Updated Menu Item");
            cbaction.Items.Add("Removed from Menu");
        }

        private void staffOptions()
        {
            cbaction.Items.Add("Added a staff");
            cbaction.Items.Add("Removed a staff");
            cbaction.Items.Add("Updated a staff");
        }

        private void logOptions()
        {
            cbaction.Items.Add("Logged In");
            cbaction.Items.Add("Logged Off");
            cbaction.Items.Add("Added to Menu");
            cbaction.Items.Add("Updated Menu Item");
            cbaction.Items.Add("Removed from Menu");
            cbaction.Items.Add("Added a staff");
            cbaction.Items.Add("Removed a staff");
            cbaction.Items.Add("Updated a staff");
        }

        private void previousOrderOptions()
        {
            cbaction.Items.Add("View Previous Orders");
            cbaction.Items.Add("Export Previous Orders");
        }

        string selectedfilter = "";
        string selectedaction = "";


        private void LoadData()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                string query = "SELECT * FROM logs WHERE 1=1";

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;

                // 🔹 Category filter (cbfilter)
                if (cbfilter.SelectedItem != null && cbfilter.SelectedItem.ToString() != "All Logs")
                {
                    query += " AND LogCategory = @category";
                    cmd.Parameters.AddWithValue("@category", cbfilter.SelectedItem.ToString());
                }

                // 🔹 Action filter
                if (cbaction.SelectedItem != null && cbaction.SelectedItem.ToString() != "")
                {
                    query += " AND UAction = @action";
                    cmd.Parameters.AddWithValue("@action", cbaction.SelectedItem.ToString());
                }


                query += " ORDER BY TimeCreated DESC";

                cmd.CommandText = query;

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void cbfilter_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbfilter.SelectedItem == null) return;

            string selected = cbfilter.SelectedItem.ToString();

            cbaction.Enabled = true;
            cbaction.Items.Clear();
            cbaction.SelectedItem = null; // reset action

            if (selected == "All Logs")
            {
                logOptions();
            }
            else if (selected == "Edit Menu")
            {
                MenuOptions();
            }
            else if (selected == "Staff Management")
            {
                staffOptions();
            }
            else if (selected == "Previous Orders")
            {
                previousOrderOptions();
            }

            LoadData();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

        }

        private void cbaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
