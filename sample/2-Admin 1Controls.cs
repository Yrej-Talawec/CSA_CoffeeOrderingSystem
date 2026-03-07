using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Ordering
{
    public partial class ac : Form
    {
        public ac()
        {
            InitializeComponent();
        }
        private void btn_brt_Click(object sender, EventArgs e)
        {
            _2_Admin_Acc brtForm = new _2_Admin_Acc();
            brtForm.Show();
            this.Hide();
        }
        private void btn_view_Click(object sender, EventArgs e)
        {
            Order_Info brtForm = new Order_Info();
            brtForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LOGIN lg = new LOGIN();
            lg.Show();
            this.Hide();
        }

        private void ac_Load(object sender, EventArgs e)
        {

        }
    }
}
