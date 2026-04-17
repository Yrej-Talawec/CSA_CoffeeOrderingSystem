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
            ((System.ComponentModel.ISupportInitialize)BeverageQty).BeginInit();
            SuspendLayout();
            // 
            // cmbBoxBeverage
            // 
            cmbBoxBeverage.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxBeverage.FormattingEnabled = true;
            cmbBoxBeverage.Location = new Point(120, 24);
            cmbBoxBeverage.Name = "cmbBoxBeverage";
            cmbBoxBeverage.Size = new Size(274, 28);
            cmbBoxBeverage.TabIndex = 0;
            cmbBoxBeverage.SelectedIndexChanged += cmbBoxBeverage_SelectedIndexChanged;
            // 
            // cmbBoxType
            // 
            cmbBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxType.FormattingEnabled = true;
            cmbBoxType.Items.AddRange(new object[] { "[Choose Type]", "Hot", "Cold" });
            cmbBoxType.Location = new Point(121, 65);
            cmbBoxType.Name = "cmbBoxType";
            cmbBoxType.Size = new Size(76, 28);
            cmbBoxType.TabIndex = 1;
            cmbBoxType.SelectedIndexChanged += cmbBoxType_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 24);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 2;
            label1.Text = "Beverage:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 110);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 3;
            label2.Text = "Size:";
            // 
            // btnAddOrder
            // 
            btnAddOrder.Location = new Point(193, 154);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(94, 29);
            btnAddOrder.TabIndex = 4;
            btnAddOrder.Text = "Add Order";
            btnAddOrder.UseVisualStyleBackColor = true;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // cmbBoxSize
            // 
            cmbBoxSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxSize.FormattingEnabled = true;
            cmbBoxSize.Items.AddRange(new object[] { "[Choose Size]", "Small", "Medium", "Large" });
            cmbBoxSize.Location = new Point(121, 110);
            cmbBoxSize.Name = "cmbBoxSize";
            cmbBoxSize.Size = new Size(76, 28);
            cmbBoxSize.TabIndex = 5;
            cmbBoxSize.SelectedIndexChanged += cmbBoxSize_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 68);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 6;
            label3.Text = "Type:";
            // 
            // BeverageQty
            // 
            BeverageQty.Location = new Point(303, 111);
            BeverageQty.Name = "BeverageQty";
            BeverageQty.Size = new Size(85, 27);
            BeverageQty.TabIndex = 7;
            BeverageQty.ValueChanged += BeverageQty_ValueChanged;
            // 
            // txtBoxPrice
            // 
            txtBoxPrice.Location = new Point(123, 205);
            txtBoxPrice.Name = "txtBoxPrice";
            txtBoxPrice.ReadOnly = true;
            txtBoxPrice.Size = new Size(102, 27);
            txtBoxPrice.TabIndex = 8;
            txtBoxPrice.Text = "0.00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(207, 111);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 9;
            label4.Text = "Quantity:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 205);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 10;
            label5.Text = "Price:";
            // 
            // ListOfOrders
            // 
            ListOfOrders.Location = new Point(432, 24);
            ListOfOrders.Name = "ListOfOrders";
            ListOfOrders.Size = new Size(501, 241);
            ListOfOrders.TabIndex = 11;
            ListOfOrders.UseCompatibleStateImageBehavior = false;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(432, 288);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(71, 29);
            btnEdit.TabIndex = 12;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(545, 288);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(73, 29);
            btnRemove.TabIndex = 13;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(206, 69);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 14;
            label6.Click += label6_Click;
            // 
            // cmbBoxSugarLevel
            // 
            cmbBoxSugarLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxSugarLevel.FormattingEnabled = true;
            cmbBoxSugarLevel.Items.AddRange(new object[] { "0%", "25%", "50%", "75%", "100%" });
            cmbBoxSugarLevel.Location = new Point(303, 65);
            cmbBoxSugarLevel.Name = "cmbBoxSugarLevel";
            cmbBoxSugarLevel.Size = new Size(86, 28);
            cmbBoxSugarLevel.TabIndex = 15;
            cmbBoxSugarLevel.SelectedIndexChanged += cmbBoxSugarLevel_SelectedIndexChanged;
            // 
            // txtBoxTotal
            // 
            txtBoxTotal.Location = new Point(314, 208);
            txtBoxTotal.Name = "txtBoxTotal";
            txtBoxTotal.ReadOnly = true;
            txtBoxTotal.Size = new Size(75, 27);
            txtBoxTotal.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(242, 212);
            label7.Name = "label7";
            label7.Size = new Size(45, 20);
            label7.TabIndex = 17;
            label7.Text = "Total:";
            // 
            // txtBoxPayment
            // 
            txtBoxPayment.Location = new Point(314, 247);
            txtBoxPayment.Name = "txtBoxPayment";
            txtBoxPayment.Size = new Size(75, 27);
            txtBoxPayment.TabIndex = 18;
            txtBoxPayment.TextChanged += txtBoxPayment_TextChanged;
            // 
            // txtBoxChange
            // 
            txtBoxChange.Location = new Point(314, 288);
            txtBoxChange.Name = "txtBoxChange";
            txtBoxChange.ReadOnly = true;
            txtBoxChange.Size = new Size(75, 27);
            txtBoxChange.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(242, 247);
            label8.Name = "label8";
            label8.Size = new Size(68, 20);
            label8.TabIndex = 20;
            label8.Text = "Payment:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(241, 289);
            label9.Name = "label9";
            label9.Size = new Size(62, 20);
            label9.TabIndex = 21;
            label9.Text = "Change:";
            // 
            // btnProceed
            // 
            btnProceed.Location = new Point(794, 288);
            btnProceed.Name = "btnProceed";
            btnProceed.Size = new Size(139, 29);
            btnProceed.TabIndex = 22;
            btnProceed.Text = "Proceed";
            btnProceed.UseVisualStyleBackColor = true;
            btnProceed.Click += btnProceed_Click;
            // 
            // btnUndo
            // 
            btnUndo.Location = new Point(651, 288);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(54, 29);
            btnUndo.TabIndex = 23;
            btnUndo.Text = "Undo";
            btnUndo.UseVisualStyleBackColor = true;
            btnUndo.Click += btnUndo_Click;
            // 
            // txtBoxDiscount
            // 
            txtBoxDiscount.Location = new Point(122, 248);
            txtBoxDiscount.Name = "txtBoxDiscount";
            txtBoxDiscount.ReadOnly = true;
            txtBoxDiscount.Size = new Size(102, 27);
            txtBoxDiscount.TabIndex = 24;
            txtBoxDiscount.Text = "0.00";
            // 
            // txtBoxDiscountedPrice
            // 
            txtBoxDiscountedPrice.Location = new Point(150, 289);
            txtBoxDiscountedPrice.Name = "txtBoxDiscountedPrice";
            txtBoxDiscountedPrice.ReadOnly = true;
            txtBoxDiscountedPrice.Size = new Size(75, 27);
            txtBoxDiscountedPrice.TabIndex = 25;
            txtBoxDiscountedPrice.Text = "0.00";
            // 
            // labelDiscount
            // 
            labelDiscount.AutoSize = true;
            labelDiscount.Location = new Point(21, 247);
            labelDiscount.Name = "labelDiscount";
            labelDiscount.Size = new Size(70, 20);
            labelDiscount.TabIndex = 26;
            labelDiscount.Text = "Discount:";
            // 
            // labelDiscountedPrice
            // 
            labelDiscountedPrice.AutoSize = true;
            labelDiscountedPrice.Location = new Point(19, 289);
            labelDiscountedPrice.Name = "labelDiscountedPrice";
            labelDiscountedPrice.Size = new Size(123, 20);
            labelDiscountedPrice.TabIndex = 27;
            labelDiscountedPrice.Text = "Discounted Price:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(209, 68);
            label10.Name = "label10";
            label10.Size = new Size(88, 20);
            label10.TabIndex = 28;
            label10.Text = "Sugar Level:";
            // 
            // Order_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 397);
            Controls.Add(label10);
            Controls.Add(labelDiscountedPrice);
            Controls.Add(labelDiscount);
            Controls.Add(txtBoxDiscountedPrice);
            Controls.Add(txtBoxDiscount);
            Controls.Add(btnUndo);
            Controls.Add(btnProceed);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtBoxChange);
            Controls.Add(txtBoxPayment);
            Controls.Add(label7);
            Controls.Add(txtBoxTotal);
            Controls.Add(cmbBoxSugarLevel);
            Controls.Add(label6);
            Controls.Add(btnRemove);
            Controls.Add(btnEdit);
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
    }
}