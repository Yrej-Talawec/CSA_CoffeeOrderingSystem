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
using System.Windows.Forms.VisualStyles;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;

namespace Coffee_Ordering
{
    public partial class SummaryForm : Form
    {
        public SummaryForm(string customerName, string customerType, string orderDate,
                    ListView listViewOrders, double total, double payment, double change)
        {
            InitializeComponent();

            StringBuilder summary = new StringBuilder();

            summary.AppendLine($"Customer Name: {customerName}");
            summary.AppendLine($"Customer Type: {customerType}");
            summary.AppendLine($"Date: {orderDate}");
            summary.AppendLine();
            summary.AppendLine("Orders:");
            summary.AppendLine("----------------------------------");

            foreach (ListViewItem item in listViewOrders.Items)
            {
                string beverage = item.SubItems.Count > 0 ? item.SubItems[0].Text : "";
                string qty = item.SubItems.Count > 1 ? item.SubItems[1].Text : "";

                summary.AppendLine($"{beverage}");
                summary.AppendLine($"   Qty: {qty}");
                summary.AppendLine();
            }

            summary.AppendLine("----------------------------------");

            double discountRate = GetDiscountRate(customerType);
            double discountAmount = (total / 1.12) * discountRate;
            double vatAmount = total - (total / 1.12);

            summary.AppendLine($"Discount Applied: {discountRate * 100}%");
            summary.AppendLine($"Discount Amount: ₱{discountAmount:F2}");
            summary.AppendLine($"VAT (12%): ₱{vatAmount:F2}");
            summary.AppendLine("----------------------------------");
            summary.AppendLine($"Total: ₱{total:F2}");
            summary.AppendLine($"Payment: ₱{payment:F2}");
            summary.AppendLine($"Change: ₱{change:F2}");

            txt_Summary.Text = summary.ToString();
        }

        private double GetDiscountRate(string type)
        {
            if (type == "Senior Citizen" || type == "PWD")
                return 0.20;
            else if (type == "Student")
                return 0.05;
            else
                return 0.0;
        }

        public SummaryForm()
        {
            InitializeComponent();
        }
        private void SummaryForm_Load(object sender, EventArgs e)
        {

        }

        private void txtBoxSetSizePrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxChange_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerForm nextForm = new CustomerForm();
            nextForm.Show();
            this.Hide();
        }

        private void textBoxTotalPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void listbox_sum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_receipt_Click(object sender, EventArgs e)
        {
            try
            {
                string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "OakAndBeansReceipts");
                if (!Directory.Exists(folder)) Directory.CreateDirectory(folder);

                string filename = $"OakAndBeans_Receipt_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                string filePath = Path.Combine(folder, filename);

                iTextSharp.text.Rectangle pageSize = new iTextSharp.text.Rectangle(280f, 700f);
                Document doc = new Document(pageSize, 10f, 10f, 10f, 10f);
                PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
                doc.Open();

                var headerFont = FontFactory.GetFont(FontFactory.COURIER_BOLD, 12, BaseColor.BLACK);
                var itemFont = FontFactory.GetFont(FontFactory.COURIER, 9, BaseColor.BLACK);
                var boldItem = FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, BaseColor.BLACK);
                var smallFont = FontFactory.GetFont(FontFactory.COURIER, 8, BaseColor.DARK_GRAY);

                Paragraph header = new Paragraph("OAK AND BEANS CAFÉ", headerFont) { Alignment = Element.ALIGN_CENTER };
                doc.Add(header);
                doc.Add(new Paragraph("Freshly Brewed Happiness ☕", itemFont) { Alignment = Element.ALIGN_CENTER });
                doc.Add(new Paragraph("Tel: (02) 1234-5678", smallFont) { Alignment = Element.ALIGN_CENTER });
                doc.Add(new Paragraph(" ", itemFont));
                doc.Add(new Paragraph("------------------------------------------", itemFont));

                string[] lines = txt_Summary.Text.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);

                string customerName = "", customerType = "", date = "";
                foreach (string line in lines)
                {
                    if (line.StartsWith("Customer Name")) customerName = line.Split(':')[1].Trim();
                    if (line.StartsWith("Customer Type")) customerType = line.Split(':')[1].Trim();
                    if (line.StartsWith("Date")) date = line.Split(':')[1].Trim();

                    if (line.StartsWith("Customer Name") || line.StartsWith("Customer Type") || line.StartsWith("Date"))
                        doc.Add(new Paragraph(line.Trim(), itemFont));
                }
                doc.Add(new Paragraph("------------------------------------------", itemFont));
                doc.Add(new Paragraph("ITEMS", boldItem));
                doc.Add(new Paragraph(" ", itemFont));
                string connStr = "server=localhost;port=3306;database=coffeedb;uid=root;pwd=maiaerica;";
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    string query = "INSERT INTO order_table (`CUSTOMER NAME`, `CUSTOMER TYPE`, `DATE`, `ORDER`, `QTY`, `DISCOUNT`, `DISCOUNT AMOUNT`, `PAYMENT`, `TOTAL`) " +
                                   "VALUES (@name, @type, @date, @order, @qty, @discount, @discountAmt, @payment, @total)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        List<(string item, int qty)> items = new List<(string, int)>();

                        int discount = 0;
                        decimal discountAmount = 0;
                        decimal vat = 0;
                        decimal total = 0;
                        decimal change = 0;
                        decimal payment = 0;

                        string currentItem = "";
                        int itemQty = 0;
                        foreach (string raw in lines)
                        {
                            string line = raw.Trim();
                            if (string.IsNullOrWhiteSpace(line)) continue;

                            if (line.StartsWith("Discount Applied"))
                                int.TryParse(line.Split(':')[1].Replace("%", "").Trim(), out discount);
                            else if (line.StartsWith("Discount Amount"))
                                decimal.TryParse(line.Split(':')[1].Replace("₱", "").Replace(",", "").Trim(), out discountAmount);
                            else if (line.StartsWith("VAT"))
                                decimal.TryParse(line.Split(':')[1].Replace("₱", "").Replace(",", "").Trim(), out vat);
                            else if (line.StartsWith("Total"))
                                decimal.TryParse(line.Split(':')[1].Replace("₱", "").Replace(",", "").Trim(), out total);
                            else if (line.StartsWith("Payment", StringComparison.OrdinalIgnoreCase))
                                decimal.TryParse(line.Split(':')[1].Replace("₱", "").Replace("PHP", "").Replace(",", "").Trim(), out payment);
                            else if (line.StartsWith("Change"))
                                decimal.TryParse(line.Split(':')[1].Replace("₱", "").Replace(",", "").Trim(), out change);
                            else if (!line.StartsWith("Qty:") && !line.StartsWith("Price:") &&
                                     !line.StartsWith("Discount") && !line.StartsWith("VAT") &&
                                     !line.StartsWith("Total") && !line.StartsWith("Payment") && !line.StartsWith("Change") &&
                                     !line.StartsWith("Customer"))
                            {
                                currentItem = line;
                            }
                            else if (line.StartsWith("Qty:"))
                            {
                                int.TryParse(line.Replace("Qty:", "").Trim(), out itemQty);
                                if (!string.IsNullOrEmpty(currentItem))
                                    items.Add((currentItem, itemQty));
                            }
                        }
                        foreach (var item in items)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@name", customerName);
                            cmd.Parameters.AddWithValue("@type", customerType);
                            cmd.Parameters.AddWithValue("@date", date);
                            cmd.Parameters.AddWithValue("@order", item.item);
                            cmd.Parameters.AddWithValue("@qty", item.qty);
                            cmd.Parameters.AddWithValue("@discount", discount);
                            cmd.Parameters.AddWithValue("@discountAmt", discountAmount);
                            cmd.Parameters.AddWithValue("@payment", payment);
                            cmd.Parameters.AddWithValue("@total", total);
                            cmd.ExecuteNonQuery();

                            doc.Add(new Paragraph($"{item.item}\n   Qty: {item.qty}", itemFont));
                        }

                        doc.Add(new Paragraph("------------------------------------------", itemFont));
                        doc.Add(new Paragraph("BILL SUMMARY", boldItem));
                        doc.Add(new Paragraph($" Discount Applied:      {discount}%", itemFont));
                        doc.Add(new Paragraph($" Discount Amount:     ₱{discountAmount:F2}", itemFont));
                        doc.Add(new Paragraph($" VAT (12%):           ₱{vat:F2}", itemFont));
                        doc.Add(new Paragraph($" Total:              ₱{total:F2}", boldItem));
                        doc.Add(new Paragraph($" Payment:           ₱{payment:F2}", itemFont));
                        doc.Add(new Paragraph($" Change:            ₱{change:F2}", boldItem));
                    }
                }
                doc.Add(new Paragraph("------------------------------------------", itemFont));
                doc.Add(new Paragraph("Thank you for visiting!", itemFont) { Alignment = Element.ALIGN_CENTER });
                doc.Add(new Paragraph("See you again at Oak and Beans Café!", smallFont) { Alignment = Element.ALIGN_CENTER });
                doc.Add(new Paragraph(DateTime.Now.ToString("MMMM dd, yyyy hh:mm tt"), smallFont) { Alignment = Element.ALIGN_CENTER });
                doc.Close();

                Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
                MessageBox.Show("Receipt created successfully and data saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating receipt or saving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void rec_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LOGIN lg = new LOGIN();
            lg.Show();
            this.Hide();

        }

        private void rec_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            
        }
    }
}
