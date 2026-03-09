using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CoffeeShop
{
    public partial class OrderForm : Form
    {
        private List<string> orders = new List<string>();
        private decimal totalBill = 0;
        private Menu menu = new Menu();

        public CustomerInfo CustomerInfo { get; set; }



        public OrderForm()
        {
            InitializeComponent();

            cboOrderName.DropDownStyle = ComboBoxStyle.DropDownList;
            cboType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSize.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            SummaryForm formSummary = new SummaryForm
            {
                CustomerInfo = this.CustomerInfo,  
                Orders = this.orders,
                TotalBill = this.totalBill
            };

            this.Hide();
            formSummary.Show();
        }

        private void cboOrderName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (cboOrderName.SelectedIndex == -1 ||
        cboType.SelectedIndex == -1 ||
        (cboSize.Enabled && cboSize.SelectedIndex == -1) ||
        string.IsNullOrWhiteSpace(txtQty.Text))
            {
                MessageBox.Show("Please complete all fields before proceeding.",
                                "Incomplete Input",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtQty.Text, out int qty) || qty <= 0)
            {
                MessageBox.Show("Quantity must be valid.");
                return;
            }

            string drink = cboOrderName.Text;
            string type = cboType.Text;
            string size = cboSize.Enabled ? cboSize.Text : "N/A";
            decimal price = menu.GetPrice(type, drink, size);
            decimal amount = price * qty;
            totalBill += amount;
            string orderLine = $"{drink} - {type} - {size} - {qty}pc - {amount}php";
            orders.Add(orderLine);
            txtDetails.Text += orderLine + Environment.NewLine;
            lblTotal.Text = $"TOTAL: PHP{totalBill}";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtQty.Clear();
            txtDetails.Text = string.Empty;
            cboOrderName.SelectedIndex = -1;
            cboType.SelectedIndex = -1;
            cboSize.SelectedIndex = -1;
            cboSize.Enabled = true;
            lblTotal.Text = "TOTAL: 0 php";
            totalBill = 0;
        }

        private void txtDetails_TextChanged(object sender, EventArgs e)
        {

        }
    }
}