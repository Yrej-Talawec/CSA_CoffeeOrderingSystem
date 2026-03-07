using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.DataFormats;

namespace Coffee_Ordering
{
    public partial class CustomerForm : Form
    {
        public static CustomerForm instance;
        public CustomerForm()
        {
            InitializeComponent();
            instance = this;
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            DateToday.Value = DateTime.Today;
            DateToday.Enabled = false;
        }
        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxName.Text) || string.IsNullOrWhiteSpace(comboBoxCustomerType.Text))
            {
                MessageBox.Show("Please fill out your name and customer type first.",
                                "Missing Information",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            string name = txtBoxName.Text;
            string type = comboBoxCustomerType.Text;
            string date = DateToday.Value.ToString("MM/dd/yyyy");

            OrderForm orderForm = new OrderForm(this, name, type, date);
            orderForm.Show();
            this.Hide();
        }

        private void comboBoxCustomerType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

