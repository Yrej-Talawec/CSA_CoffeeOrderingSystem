namespace Coffee_Shop_CSA_FinalProj
{
    partial class CustomerInfo
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
            txtBoxCustomerName = new TextBox();
            cmbBoxCustomerType = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            dtpDate = new DateTimePicker();
            btnOrder = new Button();
            btnCustomerInfoToLogin = new Button();
            SuspendLayout();
            // 
            // txtBoxCustomerName
            // 
            txtBoxCustomerName.Location = new Point(175, 31);
            txtBoxCustomerName.Name = "txtBoxCustomerName";
            txtBoxCustomerName.Size = new Size(250, 27);
            txtBoxCustomerName.TabIndex = 1;
            // 
            // cmbBoxCustomerType
            // 
            cmbBoxCustomerType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxCustomerType.FormattingEnabled = true;
            cmbBoxCustomerType.Items.AddRange(new object[] { "[Choose Customer Type]", "Regular", "Student", "Senior", "PWD" });
            cmbBoxCustomerType.Location = new Point(175, 83);
            cmbBoxCustomerType.Name = "cmbBoxCustomerType";
            cmbBoxCustomerType.Size = new Size(250, 28);
            cmbBoxCustomerType.TabIndex = 2;
            cmbBoxCustomerType.SelectedIndexChanged += cmbBoxCustomerType_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 34);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 3;
            label1.Text = "Customer Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 83);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 4;
            label2.Text = "Customer Type:";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(175, 138);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(250, 27);
            dtpDate.TabIndex = 5;
            dtpDate.ValueChanged += dtpDate_ValueChanged_1;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(175, 212);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(94, 29);
            btnOrder.TabIndex = 6;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnCustomerInfoToLogin
            // 
            btnCustomerInfoToLogin.Location = new Point(25, 280);
            btnCustomerInfoToLogin.Name = "btnCustomerInfoToLogin";
            btnCustomerInfoToLogin.Size = new Size(94, 29);
            btnCustomerInfoToLogin.TabIndex = 7;
            btnCustomerInfoToLogin.Text = "Logout";
            btnCustomerInfoToLogin.UseVisualStyleBackColor = true;
            btnCustomerInfoToLogin.Click += btnCustomerInfoToLogin_Click;
            // 
            // CustomerInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 341);
            Controls.Add(btnCustomerInfoToLogin);
            Controls.Add(btnOrder);
            Controls.Add(dtpDate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbBoxCustomerType);
            Controls.Add(txtBoxCustomerName);
            Name = "CustomerInfo";
            Text = "Customer_Info";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtBoxCustomerName;
        private ComboBox cmbBoxCustomerType;
        private Label label1;
        private Label label2;
        private DateTimePicker dtpDate;
        private Button btnOrder;
        private Button btnCustomerInfoToLogin;
    }
}
