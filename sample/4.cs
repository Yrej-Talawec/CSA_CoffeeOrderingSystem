using Coffee_Ordering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Coffee_Ordering
{
    public partial class OrderForm : Form
    {
        private Form previousForm;
        public static OrderForm instance;
        private SummaryForm form;
        private double grandTotal = 0;
        private SummaryForm summaryForm;

        private string customerName;
        private string customerType;
        private string orderDate;

        private bool isEditing = false;
        private ListViewItem itemBeingEdited = null;

        private double totalPrice = 0;

        public OrderForm(Form prevForm, string name, string type, string date)
        {
            InitializeComponent();
            instance = this;


            previousForm = prevForm;
            customerName = name;
            customerType = type;
            orderDate = date;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("Please add at least one order before proceeding.",
                                "No Orders", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_total.Text))
            {
                MessageBox.Show("Please calculate the total first.",
                                "Missing Total", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_payment.Text))
            {
                MessageBox.Show("Please enter a payment amount.",
                                "Missing Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txt_total.Text, out double total))
                total = 0;
            if (!double.TryParse(txt_payment.Text, out double payment))
                payment = 0;
            if (!double.TryParse(txt_change.Text, out double change))
                change = 0;


            double discountRate = 0.0;
            if (customerType == "Senior Citizen" || customerType == "PWD")
                discountRate = 0.20;
            else if (customerType == "Student")
                discountRate = 0.05;
            else
                discountRate = 0.0;

            double vatRate = 0.12;
            double vatAmount = total * vatRate;
            double discountedAmount = total - (total * discountRate);
            double finalTotal = discountedAmount + vatAmount;

            txt_total.Text = finalTotal.ToString("F2");

            if (payment < finalTotal)
            {
                MessageBox.Show("Insufficient payment amount. Please enter enough to cover the total.",
                                "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txt_change.Text = (payment - finalTotal).ToString("F2");

            SummaryForm summaryForm = new SummaryForm(customerName, customerType, orderDate,
                listView1, finalTotal, payment, double.Parse(txt_change.Text));

            summaryForm.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Hide(); 
        }

        private void comboBoxPastries_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPastries.SelectedIndex != -1)
            {
                PastryQty.Enabled = true;

                if (PastryQty.Value == 0)
                    PastryQty.Value = 1;

                if (comboBoxPastries.SelectedIndex == 0)
                    pastriesPrice = 85;
                else if (comboBoxPastries.SelectedIndex == 1)
                    pastriesPrice = 90;
                else if (comboBoxPastries.SelectedIndex == 2)
                    pastriesPrice = 80;
                else if (comboBoxPastries.SelectedIndex == 3)
                    pastriesPrice = 95;
                else if (comboBoxPastries.SelectedIndex == 4)
                    pastriesPrice = 88;
                else if (comboBoxPastries.SelectedIndex == 5)
                    pastriesPrice = 110;

                int totalPastry = pastriesPrice * (int)PastryQty.Value;
                PastriesPrice.Text = totalPastry.ToString("F2");
                UpdateTotal();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            comboBoxBeverages.SelectedIndex = -1;
            comboBoxPastries.SelectedIndex = -1;
            comboBoxType.SelectedIndex = -1;
            comboBoxSize.SelectedIndex = -1;
            BeverageQty.Value = 0;
            PastryQty.Value = 0;
            txt_payment.Text = "";
            txt_change.Text = "";
            txt_total.Text = "";

            comboBoxType.Enabled = false;
            comboBoxSize.Enabled = false;
            BeverageQty.Enabled = false;
            PastryQty.Enabled = false;
        }

        int sizePrice = 0;
        int pastriesPrice = 0;

        private void comboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBeverages.SelectedIndex != -1 && comboBoxType.SelectedIndex != -1 && comboBoxSize.SelectedIndex != -1)
            {
                string beverage = comboBoxBeverages.Text;
                string type = comboBoxType.Text;
                string size = comboBoxSize.Text;

                double basePrice = 0;

                if (beverage == "Espresso") basePrice = 100;
                else if (beverage == "Americano") basePrice = 110;
                else if (beverage == "Cappuccino") basePrice = 120;
                else if (beverage == "Café Latte") basePrice = 130;
                else if (beverage == "Caramel Macchiato") basePrice = 140;
                else if (beverage == "Mocha") basePrice = 135;
                else if (beverage == "Flat White") basePrice = 125;
                else if (beverage == "Hot Chocolate") basePrice = 115;
                else if (beverage == "Matcha Latte") basePrice = 130;
                else if (beverage == "Chai Tea Latte") basePrice = 120;

                if (type == "Cold")
                    basePrice += 10;

                if (size == "Grande")
                    basePrice += 10;
                else if (size == "Venti")
                    basePrice += 20;

                double totalBeverage = basePrice * (double)BeverageQty.Value;

                BeveragePrice.Text = totalBeverage.ToString("F2");
            }
            else
            {
                BeveragePrice.Text = "0.00";
            }
        }

        private void PastryQty_ValueChanged(object sender, EventArgs e)
        {
            int totalPastry = pastriesPrice * (int)PastryQty.Value;
            PastriesPrice.Text = totalPastry.ToString("F2");
            UpdateTotal();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }



        private void BeverageQty_ValueChanged(object sender, EventArgs e)
        {
            comboBoxSize_SelectedIndexChanged(sender, e);
        }

        private void txt_payment_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txt_payment.Text, out double payment))
            {
                if (double.TryParse(txt_total.Text, out double total))
                {
                    double change = payment - total;

                    if (change < 0)
                        txt_change.Text = "0.00";
                    else
                        txt_change.Text = change.ToString("F2");
                }
                else
                {
                    txt_change.Text = "";
                }
            }
            else
            {
                txt_change.Text = "";
            }
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }

        private void UpdateTotal()
        {

            int totalBev = sizePrice * (int)BeverageQty.Value;
            int totalPastry = pastriesPrice * (int)PastryQty.Value;

            BeveragePrice.Text = totalBev.ToString("F2");
            PastriesPrice.Text = totalPastry.ToString("F2");
        }
        private void txt_total_MouseClick(object sender, MouseEventArgs e)
        {

        }
        private void comboBoxBeverages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBeverages.SelectedIndex != -1)
            {
                comboBoxType.Enabled = true;
                comboBoxSize.Enabled = true;
                BeverageQty.Enabled = true;

                BeveragePrice.Text = "0.00";
                sizePrice = 0;
            }
        }

        private void txt_total_Click(object sender, EventArgs e)
        {
            if (comboBoxPastries.SelectedIndex != -1)
            {
                PastryQty.Enabled = true;

                if (comboBoxPastries.SelectedIndex == 0) pastriesPrice = 80;
                else if (comboBoxPastries.SelectedIndex == 1) pastriesPrice = 100;
                else if (comboBoxPastries.SelectedIndex == 2) pastriesPrice = 80;
                else if (comboBoxPastries.SelectedIndex == 3) pastriesPrice = 90;
                else if (comboBoxPastries.SelectedIndex == 4) pastriesPrice = 85;
                else if (comboBoxPastries.SelectedIndex == 5) pastriesPrice = 120;
            }

            int totalPastry = pastriesPrice * (int)PastryQty.Value;
            PastriesPrice.Text = totalPastry.ToString("F2");

            int basePrice = 0;

            if (comboBoxBeverages.SelectedIndex != -1 && comboBoxType.SelectedIndex != -1 && comboBoxSize.SelectedIndex != -1)
            {
                string beverage = comboBoxBeverages.Text;
                string type = comboBoxType.Text;
                string size = comboBoxSize.Text;

                if (beverage == "Espresso") basePrice = 100;
                else if (beverage == "Americano") basePrice = 110;
                else if (beverage == "Cappuccino") basePrice = 120;
                else if (beverage == "Café Latte") basePrice = 130;
                else if (beverage == "Caramel Macchiato") basePrice = 140;
                else if (beverage == "Mocha") basePrice = 135;
                else if (beverage == "Flat White") basePrice = 125;
                else if (beverage == "Hot Chocolate") basePrice = 115;
                else if (beverage == "Matcha Latte") basePrice = 130;
                else if (beverage == "Chai Tea Latte") basePrice = 120;

                if (type == "Cold")
                    basePrice += 10;

                if (size == "Grande")
                    basePrice += 10;
                else if (size == "Venti")
                    basePrice += 20;
            }

            int totalBev = basePrice * (int)BeverageQty.Value;
            BeveragePrice.Text = totalBev.ToString("F2");

            double total = totalBev + totalPastry;
            txt_total.Text = total.ToString("F2");
        }
        private void OrderForm_Load_1(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Add("ORDER", 180);
            listView1.Columns.Add("QTY", 80);
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
        }

        private void ClearInputs()
        {
            comboBoxBeverages.SelectedIndex = -1;
            comboBoxPastries.SelectedIndex = -1;
            comboBoxType.SelectedIndex = -1;
            comboBoxSize.SelectedIndex = -1;
            BeverageQty.Value = 0;
            PastryQty.Value = 0;
            BeveragePrice.Text = "0.00";
            PastriesPrice.Text = "0.00";
            txt_payment.Clear();
            txt_change.Clear();

            comboBoxType.Enabled = false;
            comboBoxSize.Enabled = false;
            BeverageQty.Enabled = false;
            PastryQty.Enabled = false;
        }
        private void btn_order_Click(object sender, EventArgs e)
        {
            if (comboBoxBeverages.SelectedIndex == -1 && string.IsNullOrWhiteSpace(comboBoxPastries.Text))
            {
                MessageBox.Show("Please select at least one beverage or pastry.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if ((comboBoxBeverages.SelectedIndex != -1 && BeverageQty.Value <= 0) &&
                (string.IsNullOrWhiteSpace(comboBoxPastries.Text) || PastryQty.Value <= 0))
            {
                MessageBox.Show("Please select an item and quantity.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double bevPrice = 0;
            double pasPrice = 0;

            if (comboBoxBeverages.SelectedIndex != -1 && comboBoxType.SelectedIndex != -1 && comboBoxSize.SelectedIndex != -1)
                bevPrice = GetBeveragePrice(comboBoxBeverages.Text, comboBoxType.Text, comboBoxSize.Text, (int)BeverageQty.Value);

            if (!string.IsNullOrWhiteSpace(comboBoxPastries.Text))
                pasPrice = GetPastryPrice(comboBoxPastries.Text, (int)PastryQty.Value);

            double orderTotal = bevPrice + pasPrice;

            if (orderTotal <= 0)
            {
                MessageBox.Show("Please select an item and quantity.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (isEditing && itemBeingEdited != null)
            {
                string newName = comboBoxBeverages.SelectedIndex != -1 ? comboBoxBeverages.Text : comboBoxPastries.Text;
                string newQty = comboBoxBeverages.SelectedIndex != -1 ? BeverageQty.Value.ToString() : PastryQty.Value.ToString();

                itemBeingEdited.SubItems[0].Text = newName;
                itemBeingEdited.SubItems[1].Text = newQty;

                isEditing = false;
                itemBeingEdited = null;
            }
            else
            {
                if (bevPrice > 0 && comboBoxBeverages.SelectedIndex != -1 && BeverageQty.Value > 0)
                    AddOrUpdateListView(comboBoxBeverages.Text, (int)BeverageQty.Value);

                if (!string.IsNullOrWhiteSpace(comboBoxPastries.Text) && PastryQty.Value > 0)
                {
                    pasPrice = GetPastryPrice(comboBoxPastries.Text, (int)PastryQty.Value);

                    if (pasPrice > 0)
                        AddOrUpdateListView(comboBoxPastries.Text, (int)PastryQty.Value);
                }
            }

            grandTotal = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                string name = item.SubItems[0].Text;
                int qty = int.Parse(item.SubItems[1].Text);

                double price = 0;

                if (comboBoxBeverages.Items.Contains(name))
                {
                    price = GetBeveragePrice(name, "Hot", "Small", qty);
                }
                else
                {
                    price = GetPastryPrice(name, qty);
                }

                grandTotal += price;
            }

            txt_total.Text = grandTotal.ToString("F2");

            ClearInputs();
        }

        private void BeveragePrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            itemBeingEdited = listView1.SelectedItems[0];
            isEditing = true;

            string itemName = itemBeingEdited.SubItems[0].Text;
            string quantity = itemBeingEdited.SubItems[1].Text;

            if (comboBoxBeverages.Items.Contains(itemName))
            {
                comboBoxBeverages.Text = itemName;
                BeverageQty.Value = int.Parse(quantity);
                comboBoxPastries.SelectedIndex = -1;
                PastryQty.Value = 0;
            }
            else if (comboBoxPastries.Items.Contains(itemName))
            {
                comboBoxPastries.Text = itemName;
                PastryQty.Value = int.Parse(quantity);
                comboBoxBeverages.SelectedIndex = -1;
                BeverageQty.Value = 0;
            }

            MessageBox.Show("You can now edit your order. Click 'Order' again to update it.", "Edit Mode", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private double GetBeveragePrice(string beverage, string type, string size, int qty)
        {
            double basePrice = 0;

            if (beverage == "Espresso") basePrice = 100;
            else if (beverage == "Americano") basePrice = 110;
            else if (beverage == "Cappuccino") basePrice = 120;
            else if (beverage == "Café Latte") basePrice = 130;
            else if (beverage == "Caramel Macchiato") basePrice = 140;
            else if (beverage == "Mocha") basePrice = 135;
            else if (beverage == "Flat White") basePrice = 125;
            else if (beverage == "Hot Chocolate") basePrice = 115;
            else if (beverage == "Matcha Latte") basePrice = 130;
            else if (beverage == "Chai Tea Latte") basePrice = 120;

            if (type == "Cold")
                basePrice += 10;
            if (size == "Grande")
                basePrice += 10;
            else if (size == "Venti")
                basePrice += 20;

            return basePrice * qty;
        }

        private double GetPastryPrice(string pastry, int qty)
        {
            double basePrice = 0;

            if (pastry == "Brownie") basePrice = 85;
            else if (pastry == "Blueberry Muffin") basePrice = 90;
            else if (pastry == "Croissant") basePrice = 80;
            else if (pastry == "Cinnamon Roll") basePrice = 95;
            else if (pastry == "Banana Bread") basePrice = 88;
            else if (pastry == "Cheesecake") basePrice = 110;

            return basePrice * qty;
        }
        private void AddOrUpdateListView(string itemName, int qty)
        {
            bool found = false;

            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[0].Text == itemName)
                {
                    int currentQty = int.Parse(item.SubItems[1].Text);
                    item.SubItems[1].Text = (currentQty + qty).ToString();
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                ListViewItem newItem = new ListViewItem(itemName);
                newItem.SubItems.Add(qty.ToString());
                listView1.Items.Add(newItem);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_remove_Click(object sender, EventArgs e)
        {

        }
    }
}

