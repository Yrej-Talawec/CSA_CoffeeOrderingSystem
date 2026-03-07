namespace Coffee_Ordering
{
    partial class CustomerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            txtBoxName = new TextBox();
            button1 = new Button();
            label12 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            comboBoxCustomerType = new ComboBox();
            DateToday = new DateTimePicker();
            SuspendLayout();
            // 
            // txtBoxName
            // 
            txtBoxName.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxName.Location = new Point(542, 163);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(394, 43);
            txtBoxName.TabIndex = 1;
            txtBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(1010, 664);
            button1.Name = "button1";
            button1.Size = new Size(94, 45);
            button1.TabIndex = 6;
            button1.Text = "NEXT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Tahoma", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Transparent;
            label12.Location = new Point(350, 68);
            label12.Name = "label12";
            label12.Size = new Size(401, 45);
            label12.TabIndex = 33;
            label12.Text = "CUSTOMER DETAILS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(230, 165);
            label3.Name = "label3";
            label3.Size = new Size(278, 41);
            label3.TabIndex = 34;
            label3.Text = "CUSTOMER NAME:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(230, 287);
            label1.Name = "label1";
            label1.Size = new Size(259, 41);
            label1.TabIndex = 35;
            label1.Text = "CUSTOMER TYPE:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(230, 403);
            label2.Name = "label2";
            label2.Size = new Size(98, 41);
            label2.TabIndex = 36;
            label2.Text = "DATE:";
            // 
            // comboBoxCustomerType
            // 
            comboBoxCustomerType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCustomerType.FlatStyle = FlatStyle.System;
            comboBoxCustomerType.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxCustomerType.FormattingEnabled = true;
            comboBoxCustomerType.Items.AddRange(new object[] { "Regular", "PWD", "Senior Citizen", "Student" });
            comboBoxCustomerType.Location = new Point(542, 287);
            comboBoxCustomerType.Name = "comboBoxCustomerType";
            comboBoxCustomerType.Size = new Size(394, 45);
            comboBoxCustomerType.TabIndex = 2;
            comboBoxCustomerType.SelectedIndexChanged += comboBoxCustomerType_SelectedIndexChanged;
            // 
            // DateToday
            // 
            DateToday.CalendarFont = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DateToday.Enabled = false;
            DateToday.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DateToday.Format = DateTimePickerFormat.Short;
            DateToday.Location = new Point(542, 403);
            DateToday.Name = "DateToday";
            DateToday.Size = new Size(225, 43);
            DateToday.TabIndex = 30;
            DateToday.Value = new DateTime(2025, 10, 13, 0, 0, 0, 0);
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1182, 763);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label12);
            Controls.Add(DateToday);
            Controls.Add(button1);
            Controls.Add(txtBoxName);
            Controls.Add(comboBoxCustomerType);
            Name = "CustomerForm";
            Text = "CUSTOMER FORM";
            Load += CustomerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public TextBox txtBoxName;
        public ComboBox comboBoxCustomerType;
        private Button button1;
        private System.Windows.Forms.DateTimePicker DateToday;
        private Label label12;
        private Label label3;
        private Label label1;
        private Label label2;
    }
}
