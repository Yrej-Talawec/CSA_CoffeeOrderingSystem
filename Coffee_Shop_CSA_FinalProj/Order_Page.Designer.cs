namespace Coffee_Shop_CSA_FinalProj
{
    partial class Order_Page
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbBoxBeverage = new ComboBox();
            cmbBoxType = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            btnAddOrder = new Button();
            cmbBoxSize = new ComboBox();
            label3 = new Label();
            BeverageQty = new NumericUpDown();
            txtBoxPrice = new TextBox();
            label4 = new Label();
            label5 = new Label();
            ListOfOrders = new ListView();
            btnEdit = new Button();
            btnRemove = new Button();
            label6 = new Label();
            cmbBoxSugarLevel = new ComboBox();
            txtBoxTotal = new TextBox();
            label7 = new Label();
            txtBoxPayment = new TextBox();
            txtBoxChange = new TextBox();
            label8 = new Label();
            label9 = new Label();
            btnProceed = new Button();
            btnUndo = new Button();
            txtBoxDiscount = new TextBox();
            txtBoxDiscountedPrice = new TextBox();
            labelDiscount = new Label();
            labelDiscountedPrice = new Label();
            label10 = new Label();
            label11 = new Label();
            pictureBox1 = new PictureBox();
            btnClear = new Button();
            btnReturnCustomerInfo = new Button();
            ((System.ComponentModel.ISupportInitialize)BeverageQty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmbBoxBeverage
            // 
            cmbBoxBeverage.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxBeverage.Font = new Font("Segoe UI", 12F);
            cmbBoxBeverage.FormattingEnabled = true;
            cmbBoxBeverage.Location = new Point(111, 108);
            cmbBoxBeverage.Name = "cmbBoxBeverage";
            cmbBoxBeverage.Size = new Size(274, 36);
            cmbBoxBeverage.TabIndex = 0;
            cmbBoxBeverage.SelectedIndexChanged += cmbBoxBeverage_SelectedIndexChanged;
            // 
            // cmbBoxType
            // 
            cmbBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxType.Font = new Font("Segoe UI", 12F);
            cmbBoxType.FormattingEnabled = true;
            cmbBoxType.Items.AddRange(new object[] { "[Choose Type]", "Hot", "Cold" });
            cmbBoxType.Location = new Point(85, 163);
            cmbBoxType.Name = "cmbBoxType";
            cmbBoxType.Size = new Size(76, 36);
            cmbBoxType.TabIndex = 1;
            cmbBoxType.SelectedIndexChanged += cmbBoxType_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Image = Properties.Resources._8;
            label1.Location = new Point(12, 111);
            label1.Name = "label1";
            label1.Size = new Size(96, 28);
            label1.TabIndex = 2;
            label1.Text = "Beverage:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Image = Properties.Resources._8;
            label2.Location = new Point(16, 233);
            label2.Name = "label2";
            label2.Size = new Size(51, 28);
            label2.TabIndex = 3;
            label2.Text = "Size:";
            // 
            // btnAddOrder
            // 
            btnAddOrder.BackgroundImage = Properties.Resources._7;
            btnAddOrder.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddOrder.Location = new Point(131, 304);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(106, 38);
            btnAddOrder.TabIndex = 4;
            btnAddOrder.Text = "Add Order";
            btnAddOrder.UseVisualStyleBackColor = true;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // cmbBoxSize
            // 
            cmbBoxSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxSize.Font = new Font("Segoe UI", 12F);
            cmbBoxSize.FormattingEnabled = true;
            cmbBoxSize.Items.AddRange(new object[] { "[Choose Size]", "Small", "Medium", "Large" });
            cmbBoxSize.Location = new Point(85, 229);
            cmbBoxSize.Name = "cmbBoxSize";
            cmbBoxSize.Size = new Size(76, 36);
            cmbBoxSize.TabIndex = 5;
            cmbBoxSize.SelectedIndexChanged += cmbBoxSize_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Image = Properties.Resources._8;
            label3.Location = new Point(16, 169);
            label3.Name = "label3";
            label3.Size = new Size(57, 28);
            label3.TabIndex = 6;
            label3.Text = "Type:";
            // 
            // BeverageQty
            // 
            BeverageQty.Font = new Font("Segoe UI", 12F);
            BeverageQty.Location = new Point(351, 163);
            BeverageQty.Name = "BeverageQty";
            BeverageQty.Size = new Size(98, 34);
            BeverageQty.TabIndex = 7;
            BeverageQty.ValueChanged += BeverageQty_ValueChanged;
            // 
            // txtBoxPrice
            // 
            txtBoxPrice.Font = new Font("Segoe UI", 12F);
            txtBoxPrice.Location = new Point(153, 394);
            txtBoxPrice.Name = "txtBoxPrice";
            txtBoxPrice.ReadOnly = true;
            txtBoxPrice.Size = new Size(102, 34);
            txtBoxPrice.TabIndex = 8;
            txtBoxPrice.Text = "0.00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Image = Properties.Resources._8;
            label4.Location = new Point(225, 221);
            label4.Name = "label4";
            label4.Size = new Size(92, 28);
            label4.TabIndex = 9;
            label4.Text = "Quantity:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Image = Properties.Resources._8;
            label5.Location = new Point(16, 400);
            label5.Name = "label5";
            label5.Size = new Size(58, 28);
            label5.TabIndex = 10;
            label5.Text = "Price:";
            // 
            // ListOfOrders
            // 
            ListOfOrders.BackColor = Color.Moccasin;
            ListOfOrders.Location = new Point(467, 73);
            ListOfOrders.Name = "ListOfOrders";
            ListOfOrders.Size = new Size(493, 448);
            ListOfOrders.TabIndex = 11;
            ListOfOrders.UseCompatibleStateImageBehavior = false;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 12F);
            btnEdit.Image = Properties.Resources._7;
            btnEdit.Location = new Point(437, 543);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 41);
            btnEdit.TabIndex = 12;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Segoe UI", 12F);
            btnRemove.Image = Properties.Resources._7;
            btnRemove.Location = new Point(555, 543);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(112, 41);
            btnRemove.TabIndex = 13;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Image = Properties.Resources._8;
            label6.Location = new Point(237, 165);
            label6.Name = "label6";
            label6.Size = new Size(0, 28);
            label6.TabIndex = 14;
            label6.Click += label6_Click;
            // 
            // cmbBoxSugarLevel
            // 
            cmbBoxSugarLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxSugarLevel.Font = new Font("Segoe UI", 12F);
            cmbBoxSugarLevel.FormattingEnabled = true;
            cmbBoxSugarLevel.Items.AddRange(new object[] { "0%", "25%", "50%", "75%", "100%" });
            cmbBoxSugarLevel.Location = new Point(339, 221);
            cmbBoxSugarLevel.Name = "cmbBoxSugarLevel";
            cmbBoxSugarLevel.Size = new Size(110, 36);
            cmbBoxSugarLevel.TabIndex = 15;
            cmbBoxSugarLevel.SelectedIndexChanged += cmbBoxSugarLevel_SelectedIndexChanged;
            // 
            // txtBoxTotal
            // 
            txtBoxTotal.Font = new Font("Segoe UI", 12F);
            txtBoxTotal.Location = new Point(386, 402);
            txtBoxTotal.Name = "txtBoxTotal";
            txtBoxTotal.ReadOnly = true;
            txtBoxTotal.Size = new Size(75, 34);
            txtBoxTotal.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Image = Properties.Resources._8;
            label7.Location = new Point(284, 405);
            label7.Name = "label7";
            label7.Size = new Size(58, 28);
            label7.TabIndex = 17;
            label7.Text = "Total:";
            // 
            // txtBoxPayment
            // 
            txtBoxPayment.Font = new Font("Segoe UI", 12F);
            txtBoxPayment.Location = new Point(386, 441);
            txtBoxPayment.Name = "txtBoxPayment";
            txtBoxPayment.Size = new Size(75, 34);
            txtBoxPayment.TabIndex = 18;
            txtBoxPayment.TextChanged += txtBoxPayment_TextChanged;
            // 
            // txtBoxChange
            // 
            txtBoxChange.Font = new Font("Segoe UI", 12F);
            txtBoxChange.Location = new Point(386, 482);
            txtBoxChange.Name = "txtBoxChange";
            txtBoxChange.ReadOnly = true;
            txtBoxChange.Size = new Size(75, 34);
            txtBoxChange.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Image = Properties.Resources._8;
            label8.Location = new Point(284, 439);
            label8.Name = "label8";
            label8.Size = new Size(91, 28);
            label8.TabIndex = 20;
            label8.Text = "Payment:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Image = Properties.Resources._8;
            label9.Location = new Point(283, 482);
            label9.Name = "label9";
            label9.Size = new Size(82, 28);
            label9.TabIndex = 21;
            label9.Text = "Change:";
            // 
            // btnProceed
            // 
            btnProceed.Font = new Font("Segoe UI", 12F);
            btnProceed.Image = Properties.Resources._7;
            btnProceed.Location = new Point(829, 543);
            btnProceed.Name = "btnProceed";
            btnProceed.Size = new Size(131, 41);
            btnProceed.TabIndex = 22;
            btnProceed.Text = "Proceed";
            btnProceed.UseVisualStyleBackColor = true;
            btnProceed.Click += btnProceed_Click;
            // 
            // btnUndo
            // 
            btnUndo.Font = new Font("Segoe UI", 12F);
            btnUndo.Image = Properties.Resources._7;
            btnUndo.Location = new Point(674, 543);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(112, 41);
            btnUndo.TabIndex = 23;
            btnUndo.Text = "Undo";
            btnUndo.UseVisualStyleBackColor = true;
            btnUndo.Click += btnUndo_Click;
            // 
            // txtBoxDiscount
            // 
            txtBoxDiscount.Font = new Font("Segoe UI", 12F);
            txtBoxDiscount.Location = new Point(151, 437);
            txtBoxDiscount.Name = "txtBoxDiscount";
            txtBoxDiscount.ReadOnly = true;
            txtBoxDiscount.Size = new Size(102, 34);
            txtBoxDiscount.TabIndex = 24;
            txtBoxDiscount.Text = "0.00";
            // 
            // txtBoxDiscountedPrice
            // 
            txtBoxDiscountedPrice.Font = new Font("Segoe UI", 12F);
            txtBoxDiscountedPrice.Location = new Point(188, 481);
            txtBoxDiscountedPrice.Name = "txtBoxDiscountedPrice";
            txtBoxDiscountedPrice.ReadOnly = true;
            txtBoxDiscountedPrice.Size = new Size(75, 34);
            txtBoxDiscountedPrice.TabIndex = 25;
            txtBoxDiscountedPrice.Text = "0.00";
            // 
            // labelDiscount
            // 
            labelDiscount.AutoSize = true;
            labelDiscount.Font = new Font("Segoe UI", 12F);
            labelDiscount.ForeColor = SystemColors.ControlLightLight;
            labelDiscount.Image = Properties.Resources._8;
            labelDiscount.Location = new Point(15, 441);
            labelDiscount.Name = "labelDiscount";
            labelDiscount.Size = new Size(93, 28);
            labelDiscount.TabIndex = 26;
            labelDiscount.Text = "Discount:";
            // 
            // labelDiscountedPrice
            // 
            labelDiscountedPrice.AutoSize = true;
            labelDiscountedPrice.Font = new Font("Segoe UI", 12F);
            labelDiscountedPrice.ForeColor = SystemColors.ControlLightLight;
            labelDiscountedPrice.Image = Properties.Resources._8;
            labelDiscountedPrice.Location = new Point(14, 484);
            labelDiscountedPrice.Name = "labelDiscountedPrice";
            labelDiscountedPrice.Size = new Size(162, 28);
            labelDiscountedPrice.TabIndex = 27;
            labelDiscountedPrice.Text = "Discounted Price:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Image = Properties.Resources._8;
            label10.Location = new Point(225, 167);
            label10.Name = "label10";
            label10.Size = new Size(116, 28);
            label10.TabIndex = 28;
            label10.Text = "Sugar Level:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Image = Properties.Resources._5;
            label11.Location = new Point(14, 12);
            label11.Name = "label11";
            label11.Size = new Size(119, 48);
            label11.TabIndex = 30;
            label11.Text = "Order";
            label11.Click += label11_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._5;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(975, 67);
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // btnClear
            // 
            btnClear.BackgroundImage = Properties.Resources._7;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(302, 304);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(83, 39);
            btnClear.TabIndex = 31;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnReturnCustomerInfo
            // 
            btnReturnCustomerInfo.BackgroundImage = Properties.Resources._7;
            btnReturnCustomerInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReturnCustomerInfo.Location = new Point(25, 544);
            btnReturnCustomerInfo.Name = "btnReturnCustomerInfo";
            btnReturnCustomerInfo.Size = new Size(83, 39);
            btnReturnCustomerInfo.TabIndex = 32;
            btnReturnCustomerInfo.Text = "Return";
            btnReturnCustomerInfo.UseVisualStyleBackColor = true;
            btnReturnCustomerInfo.Click += btnReturnCustomerInfo_Click;
            // 
            // Order_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1;
            ClientSize = new Size(974, 605);
            Controls.Add(btnReturnCustomerInfo);
            Controls.Add(btnClear);
            Controls.Add(btnUndo);
            Controls.Add(btnProceed);
            Controls.Add(btnRemove);
            Controls.Add(btnEdit);
            Controls.Add(label11);
            Controls.Add(pictureBox1);
            Controls.Add(label10);
            Controls.Add(labelDiscountedPrice);
            Controls.Add(labelDiscount);
            Controls.Add(txtBoxDiscountedPrice);
            Controls.Add(txtBoxDiscount);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtBoxChange);
            Controls.Add(txtBoxPayment);
            Controls.Add(label7);
            Controls.Add(txtBoxTotal);
            Controls.Add(cmbBoxSugarLevel);
            Controls.Add(label6);
            Controls.Add(ListOfOrders);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtBoxPrice);
            Controls.Add(BeverageQty);
            Controls.Add(label3);
            Controls.Add(cmbBoxSize);
            Controls.Add(btnAddOrder);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbBoxType);
            Controls.Add(cmbBoxBeverage);
            Name = "Order_Page";
            Text = "Order_Page";
            Load += Order_Page_Load;
            ((System.ComponentModel.ISupportInitialize)BeverageQty).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbBoxBeverage;
        private ComboBox cmbBoxType;
        private Label label1;
        private Label label2;
        private Button btnAddOrder;
        private ComboBox cmbBoxSize;
        private Label label3;
        private NumericUpDown BeverageQty;
        private TextBox txtBoxPrice;
        private Label label4;
        private Label label5;
        private ListView ListOfOrders;
        private Button btnEdit;
        private Button btnRemove;
        private Label label6;
        private ComboBox cmbBoxSugarLevel;
        private TextBox txtBoxTotal;
        private Label label7;
        private TextBox txtBoxPayment;
        private TextBox txtBoxChange;
        private Label label8;
        private Label label9;
        private Button btnProceed;
        private Button btnUndo;
        private TextBox txtBoxDiscount;
        private TextBox txtBoxDiscountedPrice;
        private Label labelDiscount;
        private Label labelDiscountedPrice;
        private Label label10;
        private Label label11;
        private PictureBox pictureBox1;
        private Button btnClear;
        private Button btnReturnCustomerInfo;
    }
}