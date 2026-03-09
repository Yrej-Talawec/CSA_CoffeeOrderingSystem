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
    public partial class SummaryForm : Form
    {
        public CustomerInfo CustomerInfo { get; set; }
        public List<string> Orders { get; set; }
        public decimal TotalBill { get; set; }

        public SummaryForm()

        {
            InitializeComponent();
        }

    private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SummaryForm_Load_1(object sender, EventArgs e)
        {
            if (CustomerInfo != null)
            {
                lblName.Text = $"Customer Name: {CustomerInfo.CustomerName}";
                lblType.Text = $"Customer Type: {CustomerInfo.CustomerType}";
                lblD.Text = $"Date: {CustomerInfo.DateStamp}";
            }

            if (Orders != null)
            {
                foreach (var order in Orders)
                {
                    lstOrders.Items.Add(order);
                }
            }

            txtTotal.Text = $"PHP{TotalBill}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtPayment.Text, out decimal payment) || payment <= 0)
            {
                MessageBox.Show("Please enter a valid payment amount.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (payment < TotalBill)
            {
                MessageBox.Show("Insufficient payment.", "Payment Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal change = payment - TotalBill;
            txtChange.Text = $"PHP{change}";
        }

        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Order Submitted", "Thank You!",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }
    }

    }

