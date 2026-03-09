using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class CustomerForm : Form
    {
        

        public CustomerForm()
        {
            InitializeComponent();
            cboCustomerType.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text) || cboCustomerType.SelectedIndex == -1)
            {
                MessageBox.Show("Please complete all customer details.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else
            {
                OrderForm form2 = new OrderForm();
                form2.CustomerInfo = new CustomerInfo
                {
                    CustomerName = txtCustomerName.Text,
                    CustomerType = cboCustomerType.Text,
                    DateStamp = DateTime.Now
                };

                this.Hide();
                form2.Show();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Form4 loginad = new Form4();
            loginad.Show();
            this.Hide();
        }
    }
}
