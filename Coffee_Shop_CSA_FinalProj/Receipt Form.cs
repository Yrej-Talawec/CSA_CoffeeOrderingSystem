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
    public partial class Receipt_Form : Form
    {
        public Receipt_Form(string cName, double cDiscount, string OrderList, string total, string pay, string payment_change)
        {
            InitializeComponent();
        }

        private void Receipt_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
