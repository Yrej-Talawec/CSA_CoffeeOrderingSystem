namespace Coffee_Shop_CSA_FinalProj
{
    public partial class CustomerInfo : Form
    {
        public CustomerInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpDate_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Now;
            dtpDate.Enabled = false;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (string.IsNullOrWhiteSpace(txtBoxCustomerName.Text))
            {
                errorMessage += "- Customer Name is required.\n";
            }


            if (cmbBoxCustomerType.SelectedIndex <= 0)
            {
                errorMessage += "- Please select a Customer Type.\n";
            }

            if (errorMessage != "")
            {
                MessageBox.Show("Please complete the following:\n\n" + errorMessage,
                                "Missing Information", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            double discount = 0;
            string type = cmbBoxCustomerType.SelectedItem.ToString();

            if (type == "Student")
            {
                discount = 0.05;
            }
            else if (type == "Senior" || type == "PWD")
            {
                discount = 0.10;
            }

            string summary = $"Customer: {txtBoxCustomerName.Text}\n" +
                     $"Type: {type}\n" + $"Discount: {discount * 100}%\n\n" +
                     "Is this information correct?";

            DialogResult result = MessageBox.Show(summary, "Confirm Order",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Order Confirmed! Proceeding...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Order_Page OrderPage = new Order_Page(txtBoxCustomerName.Text, cmbBoxCustomerType.Text, discount);
                OrderPage.Show();
                this.Hide();
            }
            else
            {

            }
        }

        private void cmbBoxCustomerType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCustomerInfoToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
