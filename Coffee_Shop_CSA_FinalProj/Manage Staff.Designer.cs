namespace Coffee_Shop_CSA_FinalProj
{
    partial class Managestaff
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
            txtName = new TextBox();
            txtSalary = new TextBox();
            txtPosition = new TextBox();
            txtSearch = new TextBox();
            dataGridView1 = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.BackColor = Color.Moccasin;
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.Location = new Point(57, 135);
            txtName.Name = "txtName";
            txtName.Size = new Size(130, 34);
            txtName.TabIndex = 0;
            txtName.Text = "Name";
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSalary
            // 
            txtSalary.BackColor = Color.Moccasin;
            txtSalary.Font = new Font("Segoe UI", 12F);
            txtSalary.Location = new Point(57, 340);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(130, 34);
            txtSalary.TabIndex = 1;
            txtSalary.Text = "Salary";
            txtSalary.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPosition
            // 
            txtPosition.BackColor = Color.Moccasin;
            txtPosition.Font = new Font("Segoe UI", 12F);
            txtPosition.Location = new Point(57, 186);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(130, 34);
            txtPosition.TabIndex = 2;
            txtPosition.Text = "Position";
            txtPosition.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.Moccasin;
            txtSearch.Font = new Font("Segoe UI", 12F);
            txtSearch.Location = new Point(57, 419);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(130, 34);
            txtSearch.TabIndex = 3;
            txtSearch.Text = "Search";
            txtSearch.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Moccasin;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(217, 123);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(743, 341);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            dataGridView1.Click += dataGridView1_Click;
            dataGridView1.Layout += dataGridView1_Layout;
            // 
            // btnAdd
            // 
            btnAdd.BackgroundImage = Properties.Resources._7;
            btnAdd.Font = new Font("Segoe UI", 12F);
            btnAdd.Location = new Point(373, 505);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 41);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackgroundImage = Properties.Resources._7;
            btnDelete.Font = new Font("Segoe UI", 12F);
            btnDelete.Location = new Point(647, 505);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 41);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackgroundImage = Properties.Resources._7;
            btnUpdate.Font = new Font("Segoe UI", 12F);
            btnUpdate.Location = new Point(510, 505);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(130, 41);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._5;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(0, -3);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(975, 67);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Image = Properties.Resources._5;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(246, 48);
            label1.TabIndex = 12;
            label1.Text = "Manage Staff";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.Moccasin;
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(57, 236);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(130, 34);
            txtEmail.TabIndex = 13;
            txtEmail.Text = "Email";
            txtEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.Moccasin;
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(57, 289);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(130, 34);
            txtPassword.TabIndex = 14;
            txtPassword.Text = "Password";
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // Managestaff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            BackgroundImage = Properties.Resources._1;
            ClientSize = new Size(974, 605);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtSearch);
            Controls.Add(txtPosition);
            Controls.Add(txtSalary);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Name = "Managestaff";
            Text = "Manage Staff";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtSalary;
        private TextBox txtPosition;
        private TextBox txtSearch;
        private DataGridView dataGridView1;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtEmail;
        private TextBox txtPassword;
    }
}