namespace Coffee_Ordering
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            comboBoxBeverages = new ComboBox();
            comboBoxType = new ComboBox();
            comboBoxSize = new ComboBox();
            BeverageQty = new NumericUpDown();
            comboBoxPastries = new ComboBox();
            PastryQty = new NumericUpDown();
            button1 = new Button();
            btnClear = new Button();
            BeveragePrice = new TextBox();
            PastriesPrice = new TextBox();
            label12 = new Label();
            textBoxTotal = new TextBox();
            txt_payment = new TextBox();
            txt_total = new TextBox();
            txt_change = new TextBox();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btn_remove = new Button();
            btn_order = new Button();
            listView1 = new ListView();
            button2 = new Button();
            btn_edit = new Button();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)BeverageQty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PastryQty).BeginInit();
            SuspendLayout();
            // 
            // comboBoxBeverages
            // 
            comboBoxBeverages.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBeverages.FlatStyle = FlatStyle.System;
            comboBoxBeverages.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxBeverages.FormattingEnabled = true;
            comboBoxBeverages.Items.AddRange(new object[] { "Espresso", "Americano", "Cappuccino", "Café Latte", "Caramel Macchiato", "Mocha", "Flat White", "Hot Chocolate", "Matcha Latte", "Chai Tea Latte" });
            comboBoxBeverages.Location = new Point(278, 142);
            comboBoxBeverages.Name = "comboBoxBeverages";
            comboBoxBeverages.Size = new Size(275, 36);
            comboBoxBeverages.TabIndex = 0;
            comboBoxBeverages.SelectedIndexChanged += comboBoxBeverages_SelectedIndexChanged;
            // 
            // comboBoxType
            // 
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.Enabled = false;
            comboBoxType.FlatStyle = FlatStyle.System;
            comboBoxType.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "Cold", "Hot" });
            comboBoxType.Location = new Point(278, 207);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(275, 36);
            comboBoxType.TabIndex = 1;
            comboBoxType.SelectedIndexChanged += comboBoxType_SelectedIndexChanged;
            // 
            // comboBoxSize
            // 
            comboBoxSize.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSize.Enabled = false;
            comboBoxSize.FlatStyle = FlatStyle.System;
            comboBoxSize.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxSize.FormattingEnabled = true;
            comboBoxSize.Items.AddRange(new object[] { "Tall", "Grande", "Venti" });
            comboBoxSize.Location = new Point(278, 273);
            comboBoxSize.Name = "comboBoxSize";
            comboBoxSize.Size = new Size(275, 36);
            comboBoxSize.TabIndex = 2;
            comboBoxSize.SelectedIndexChanged += comboBoxSize_SelectedIndexChanged;
            // 
            // BeverageQty
            // 
            BeverageQty.Enabled = false;
            BeverageQty.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BeverageQty.Location = new Point(278, 339);
            BeverageQty.Name = "BeverageQty";
            BeverageQty.Size = new Size(154, 34);
            BeverageQty.TabIndex = 3;
            BeverageQty.ValueChanged += BeverageQty_ValueChanged;
            // 
            // comboBoxPastries
            // 
            comboBoxPastries.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPastries.FlatStyle = FlatStyle.System;
            comboBoxPastries.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxPastries.FormattingEnabled = true;
            comboBoxPastries.Items.AddRange(new object[] { "Brownie", "Blueberry Muffin", "Croissant", "Cinnamon Roll", "Banana Bread", "Cheesecake" });
            comboBoxPastries.Location = new Point(278, 517);
            comboBoxPastries.Name = "comboBoxPastries";
            comboBoxPastries.Size = new Size(275, 36);
            comboBoxPastries.TabIndex = 8;
            comboBoxPastries.SelectedIndexChanged += comboBoxPastries_SelectedIndexChanged;
            // 
            // PastryQty
            // 
            PastryQty.Enabled = false;
            PastryQty.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PastryQty.Location = new Point(278, 582);
            PastryQty.Name = "PastryQty";
            PastryQty.Size = new Size(275, 34);
            PastryQty.TabIndex = 10;
            PastryQty.ValueChanged += PastryQty_ValueChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(1053, 683);
            button1.Name = "button1";
            button1.Size = new Size(108, 42);
            button1.TabIndex = 14;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(916, 683);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(108, 42);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // BeveragePrice
            // 
            BeveragePrice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BeveragePrice.Location = new Point(278, 406);
            BeveragePrice.Name = "BeveragePrice";
            BeveragePrice.ReadOnly = true;
            BeveragePrice.Size = new Size(154, 34);
            BeveragePrice.TabIndex = 16;
            // 
            // PastriesPrice
            // 
            PastriesPrice.BackColor = SystemColors.Window;
            PastriesPrice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PastriesPrice.Location = new Point(278, 643);
            PastriesPrice.Name = "PastriesPrice";
            PastriesPrice.ReadOnly = true;
            PastriesPrice.Size = new Size(275, 34);
            PastriesPrice.TabIndex = 19;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ButtonFace;
            label12.Location = new Point(452, 29);
            label12.Name = "label12";
            label12.Size = new Size(299, 50);
            label12.TabIndex = 29;
            label12.Text = "ORDER DETAILS";
            // 
            // textBoxTotal
            // 
            textBoxTotal.Location = new Point(1187, 66);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.Size = new Size(76, 27);
            textBoxTotal.TabIndex = 31;
            // 
            // txt_payment
            // 
            txt_payment.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_payment.Location = new Point(828, 484);
            txt_payment.Name = "txt_payment";
            txt_payment.Size = new Size(275, 34);
            txt_payment.TabIndex = 33;
            txt_payment.TextChanged += txt_payment_TextChanged;
            // 
            // txt_total
            // 
            txt_total.BackColor = SystemColors.Window;
            txt_total.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_total.Location = new Point(828, 551);
            txt_total.Name = "txt_total";
            txt_total.ReadOnly = true;
            txt_total.Size = new Size(275, 34);
            txt_total.TabIndex = 35;
            txt_total.Click += txt_total_Click;
            txt_total.MouseClick += txt_total_MouseClick;
            // 
            // txt_change
            // 
            txt_change.BackColor = SystemColors.Window;
            txt_change.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_change.Location = new Point(828, 617);
            txt_change.Name = "txt_change";
            txt_change.ReadOnly = true;
            txt_change.Size = new Size(275, 34);
            txt_change.TabIndex = 37;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.WhiteSmoke;
            label13.Location = new Point(66, 137);
            label13.Name = "label13";
            label13.Size = new Size(186, 41);
            label13.TabIndex = 38;
            label13.Text = "BEVERAGES:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.WhiteSmoke;
            label14.Location = new Point(66, 207);
            label14.Name = "label14";
            label14.Size = new Size(93, 41);
            label14.TabIndex = 39;
            label14.Text = "TYPE:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.WhiteSmoke;
            label15.Location = new Point(66, 273);
            label15.Name = "label15";
            label15.Size = new Size(84, 41);
            label15.TabIndex = 40;
            label15.Text = "SIZE:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.WhiteSmoke;
            label16.Location = new Point(66, 339);
            label16.Name = "label16";
            label16.Size = new Size(171, 41);
            label16.TabIndex = 41;
            label16.Text = "QUANTITY:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.WhiteSmoke;
            label17.Location = new Point(66, 399);
            label17.Name = "label17";
            label17.Size = new Size(106, 41);
            label17.TabIndex = 42;
            label17.Text = "PRICE:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(66, 517);
            label1.Name = "label1";
            label1.Size = new Size(154, 41);
            label1.TabIndex = 43;
            label1.Text = "PASTRIES:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(66, 582);
            label2.Name = "label2";
            label2.Size = new Size(171, 41);
            label2.TabIndex = 44;
            label2.Text = "QUANTITY:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(66, 643);
            label3.Name = "label3";
            label3.Size = new Size(106, 41);
            label3.TabIndex = 45;
            label3.Text = "PRICE:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(636, 484);
            label4.Name = "label4";
            label4.Size = new Size(155, 38);
            label4.TabIndex = 46;
            label4.Text = "PAYMENT:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(637, 554);
            label5.Name = "label5";
            label5.Size = new Size(87, 31);
            label5.TabIndex = 47;
            label5.Text = "TOTAL:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(637, 620);
            label6.Name = "label6";
            label6.Size = new Size(114, 31);
            label6.TabIndex = 48;
            label6.Text = "CHANGE:";
            // 
            // btn_remove
            // 
            btn_remove.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_remove.Location = new Point(966, 420);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(98, 33);
            btn_remove.TabIndex = 51;
            btn_remove.Text = "Remove";
            btn_remove.UseVisualStyleBackColor = true;
            btn_remove.Click += btn_remove_Click;
            // 
            // btn_order
            // 
            btn_order.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_order.Location = new Point(727, 420);
            btn_order.Name = "btn_order";
            btn_order.Size = new Size(98, 33);
            btn_order.TabIndex = 52;
            btn_order.Text = "Order";
            btn_order.UseVisualStyleBackColor = true;
            btn_order.Click += btn_order_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(727, 159);
            listView1.Name = "listView1";
            listView1.Size = new Size(337, 239);
            listView1.TabIndex = 53;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(778, 683);
            button2.Name = "button2";
            button2.Size = new Size(108, 42);
            button2.TabIndex = 54;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btn_edit
            // 
            btn_edit.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_edit.Location = new Point(848, 420);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(98, 33);
            btn_edit.TabIndex = 55;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(805, 127);
            label7.Name = "label7";
            label7.Size = new Size(180, 18);
            label7.TabIndex = 56;
            label7.Text = "ORDER INFORMATION";
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1182, 753);
            Controls.Add(label7);
            Controls.Add(btn_edit);
            Controls.Add(button2);
            Controls.Add(listView1);
            Controls.Add(btn_order);
            Controls.Add(btn_remove);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(txt_change);
            Controls.Add(txt_total);
            Controls.Add(txt_payment);
            Controls.Add(textBoxTotal);
            Controls.Add(PastriesPrice);
            Controls.Add(label12);
            Controls.Add(comboBoxPastries);
            Controls.Add(btnClear);
            Controls.Add(comboBoxBeverages);
            Controls.Add(BeveragePrice);
            Controls.Add(comboBoxType);
            Controls.Add(button1);
            Controls.Add(comboBoxSize);
            Controls.Add(BeverageQty);
            Controls.Add(PastryQty);
            Name = "OrderForm";
            Text = "Form2";
            Load += OrderForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)BeverageQty).EndInit();
            ((System.ComponentModel.ISupportInitialize)PastryQty).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button btnClear;
        public ComboBox comboBoxBeverages;
        public ComboBox comboBoxType;
        public ComboBox comboBoxSize;
        public NumericUpDown BeverageQty;
        public ComboBox comboBoxPastries;
        public NumericUpDown PastryQty;
        public TextBox BeveragePrice;
        public TextBox PastriesPrice;
        private Label label12;
        public TextBox textBoxTotal;
        public TextBox txt_payment;
        public TextBox txt_total;
        public TextBox txt_change;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btn_remove;
        private Button btn_order;
        private ListView listView1;
        private Button button2;
        private Button btn_edit;
        private Label label7;
    }
}