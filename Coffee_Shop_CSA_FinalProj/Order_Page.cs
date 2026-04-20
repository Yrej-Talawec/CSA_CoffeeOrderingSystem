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
    public partial class Order_Page : Form
    {
        string connStr = "server=localhost;user=root;password=*504487*;database=coffee_shop_csa;";

        string customerName;
        string customerType;
        double customerDiscount;

        double grandTotal = 0;

        bool isEditing = false;
        ListViewItem itemBeingEdited = null;

        Stack<(ListViewItem item, int index)> undoStack = new Stack<(ListViewItem, int)>();

        double finalTotal = 0;

        public Order_Page(string name, string type, double discount)
        {
            InitializeComponent();
            customerName = name;
            customerType = type;
            customerDiscount = discount;
        }

        private void Order_Page_Load(object sender, EventArgs e)
        {
            LoadBeverages();

            ListOfOrders.View = View.Details;
            ListOfOrders.Columns.Add("Beverage", 120);
            ListOfOrders.Columns.Add("Type", 80);
            ListOfOrders.Columns.Add("Size", 80);
            ListOfOrders.Columns.Add("Sugar", 100);
            ListOfOrders.Columns.Add("Qty", 50);
            ListOfOrders.Columns.Add("Price", 80);
            ListOfOrders.Columns.Add("Disc Price", 100);
            ListOfOrders.FullRowSelect = true;
            ListOfOrders.GridLines = true;

            if (customerDiscount == 0)
            {
                ListOfOrders.Columns[6].Width = 0;

                labelDiscount.Visible = false;
                labelDiscountedPrice.Visible = false;

                txtBoxDiscount.Visible = false;
                txtBoxDiscountedPrice.Visible = false;
            }
        }

        private void LoadBeverages()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string query = "SELECT bev_name FROM beverage_menu";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    cmbBoxBeverage.Items.Clear();

                    while (reader.Read())
                    {
                        cmbBoxBeverage.Items.Add(reader["bev_name"].ToString());
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Error: " + ex.Message);
            }
        }

        private void ComputePrice()
        {
            if (cmbBoxBeverage.SelectedIndex == -1 ||
                cmbBoxType.SelectedIndex == -1 ||
                cmbBoxSize.SelectedIndex == -1)
            {
                txtBoxPrice.Text = "0.00";
                txtBoxDiscount.Text = "0.00";
                txtBoxDiscountedPrice.Text = "0.00";
                return;
            }

            double basePrice = 0;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string query = "SELECT price FROM beverage_menu WHERE bev_name=@name";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", cmbBoxBeverage.Text);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        basePrice = Convert.ToDouble(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (cmbBoxType.Text == "Cold")
            {
                basePrice = basePrice + 10;
            }

            if (cmbBoxSize.Text == "Medium")
            {
                basePrice = basePrice + 10;
            }
            else if (cmbBoxSize.Text == "Large")
            {
                basePrice = basePrice + 20;
            }

            double quantity = (double)BeverageQty.Value;
            double subtotal = basePrice * quantity;

            double discountAmount = subtotal * customerDiscount;
            double finalPrice = subtotal - discountAmount;

            txtBoxPrice.Text = subtotal.ToString("F2");

            if (customerDiscount == 0)
            {
                txtBoxDiscount.Text = "0.00";
                txtBoxDiscountedPrice.Text = subtotal.ToString("F2");
            }
            else
            {
                txtBoxDiscount.Text = discountAmount.ToString("F2");
                txtBoxDiscountedPrice.Text = finalPrice.ToString("F2");
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (cmbBoxBeverage.SelectedIndex == -1 ||
                cmbBoxType.SelectedIndex == -1 ||
                cmbBoxSize.SelectedIndex == -1 ||
                BeverageQty.Value <= 0)
            {
                MessageBox.Show("Complete the order first!");
                return;
            }

            string bev = cmbBoxBeverage.Text;
            string type = cmbBoxType.Text;
            string size = cmbBoxSize.Text;
            string sugar = cmbBoxSugarLevel.Text;
            int qty = (int)BeverageQty.Value;
            double price = double.Parse(txtBoxPrice.Text);
            double discountAmount = price * customerDiscount;
            double discountedPrice = price - discountAmount;

            if (isEditing && itemBeingEdited != null)
            {
                itemBeingEdited.SubItems[0].Text = bev;
                itemBeingEdited.SubItems[1].Text = type;
                itemBeingEdited.SubItems[2].Text = size;
                itemBeingEdited.SubItems[3].Text = sugar;
                itemBeingEdited.SubItems[4].Text = qty.ToString();
                itemBeingEdited.SubItems[5].Text = price.ToString("F2");
                itemBeingEdited.SubItems[6].Text = discountedPrice.ToString("F2");

                isEditing = false;
                itemBeingEdited = null;

                MessageBox.Show("Order updated!");
            }
            else
            {
                ListViewItem item = new ListViewItem(bev);
                item.SubItems.Add(type);
                item.SubItems.Add(size);
                item.SubItems.Add(sugar);
                item.SubItems.Add(qty.ToString());
                item.SubItems.Add(price.ToString("F2"));
                item.SubItems.Add(discountedPrice.ToString("F2"));

                ListOfOrders.Items.Add(item);

                MessageBox.Show("Order Added!");
            }

            RecalculateTotal();
            ClearInputs();
        }

        private void RecalculateTotal()
        {
            double total = 0;
            double originalTotal = 0;

            foreach (ListViewItem item in ListOfOrders.Items)
            {
                double discountedPrice = double.Parse(item.SubItems[6].Text);
                double originalPrice = double.Parse(item.SubItems[5].Text);

                total += discountedPrice;
                originalTotal += originalPrice;
            }

            double discountAmount = originalTotal - total;

            if (customerDiscount == 0)
            {
                txtBoxTotal.Text = originalTotal.ToString("F2");
                txtBoxDiscount.Text = "0.00";
                txtBoxDiscountedPrice.Text = originalTotal.ToString("F2");

                finalTotal = originalTotal;
            }
            else
            {
                txtBoxTotal.Text = total.ToString("F2");
                txtBoxDiscount.Text = discountAmount.ToString("F2");
                txtBoxDiscountedPrice.Text = total.ToString("F2");

                finalTotal = total;
            }

        }

        private void ClearInputs()
        {
            cmbBoxBeverage.SelectedIndex = -1;
            cmbBoxType.SelectedIndex = -1;
            cmbBoxSize.SelectedIndex = -1;
            cmbBoxSugarLevel.SelectedIndex = -1;
            BeverageQty.Value = 0;

            txtBoxPrice.Text = "0.00";
            txtBoxDiscount.Text = "0.00";
            txtBoxDiscountedPrice.Text = "0.00";
        }

        private void cmbBoxBeverage_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComputePrice();
        }

        private void cmbBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComputePrice();
        }

        private void cmbBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComputePrice();
        }

        private void BeverageQty_ValueChanged(object sender, EventArgs e)
        {
            ComputePrice();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ListOfOrders.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item to edit.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            itemBeingEdited = ListOfOrders.SelectedItems[0];
            isEditing = true;

            cmbBoxBeverage.Text = itemBeingEdited.SubItems[0].Text;
            cmbBoxType.Text = itemBeingEdited.SubItems[1].Text;
            cmbBoxSize.Text = itemBeingEdited.SubItems[2].Text;
            cmbBoxSugarLevel.Text = itemBeingEdited.SubItems[3].Text;
            BeverageQty.Value = int.Parse(itemBeingEdited.SubItems[4].Text);

            MessageBox.Show("You can now edit your order. Click 'Add Order' again to update it.",
                "Edit Mode", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (ListOfOrders.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item to remove.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to remove this item?",
                "Confirm Remove",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ListViewItem selectedItem = ListOfOrders.SelectedItems[0];

                undoStack.Push(((ListViewItem)selectedItem.Clone(), selectedItem.Index));

                ListOfOrders.Items.Remove(selectedItem);

                RecalculateTotal();

                MessageBox.Show("Item removed! Click UNDO if this was a mistake.");
            }
        }

        private void cmbBoxSugarLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComputePrice();
        }

        private void txtBoxPayment_TextChanged(object sender, EventArgs e)
        {
            double payment;

            if (double.TryParse(txtBoxPayment.Text, out payment))
            {
                double change = payment - finalTotal;

                if (change < 0)
                {
                    txtBoxChange.Text = "0.00";
                }
                else
                {
                    txtBoxChange.Text = change.ToString("F2");
                }
            }
            else
            {
                txtBoxChange.Text = "";
            }
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            double total;
            double payment;

            if (ListOfOrders.Items.Count == 0)
            {
                MessageBox.Show("No orders yet!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            total = finalTotal;

            if (!double.TryParse(txtBoxPayment.Text, out payment))
            {
                MessageBox.Show("Enter valid payment.", "Error");
                return;
            }

            if (payment < total)
            {
                MessageBox.Show("Insufficient payment!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double change = payment - total;

            MessageBox.Show("Creating receipt...");

            //////////////////////////////////////////////Receipt_Form receipt = new Receipt_Form(customerName, customerDiscount, ListOfOrders, total, payment, change);

            //receipt.Show();
            //this.Hide();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (undoStack.Count == 0)
            {
                MessageBox.Show("Nothing to undo.", "Info");
                return;
            }

            var last = undoStack.Pop();

            if (last.index >= 0 && last.index <= ListOfOrders.Items.Count)
            {
                ListOfOrders.Items.Insert(last.index, last.item);
            }
            else
            {
                ListOfOrders.Items.Add(last.item);
            }

            RecalculateTotal();

            MessageBox.Show("Last removed item restored!", "Undo Successful");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        { 
            DialogResult result = MessageBox.Show("Are you sure you to clear?", "Return to Customer Info",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Information cleared", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
            }
            else
            {

            }
        }

        private void btnReturnCustomerInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerInfo customerInfo = new CustomerInfo();
            customerInfo.Show();
        }
    }
}
