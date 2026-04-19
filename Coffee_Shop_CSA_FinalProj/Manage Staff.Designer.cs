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
            btnSearch = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 173);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(110, 23);
            txtName.TabIndex = 0;
            txtName.Text = "name";
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(12, 222);
            txtSalary.Margin = new Padding(3, 2, 3, 2);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(110, 23);
            txtSalary.TabIndex = 1;
            txtSalary.Text = "Salary";
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(12, 197);
            txtPosition.Margin = new Padding(3, 2, 3, 2);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(110, 23);
            txtPosition.TabIndex = 2;
            txtPosition.Text = "postion";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 247);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(110, 23);
            txtSearch.TabIndex = 3;
            txtSearch.Text = "Search";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(482, 169);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(262, 141);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            dataGridView1.Click += dataGridView1_Click;
            dataGridView1.Layout += dataGridView1_Layout;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(313, 288);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 22);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(10, 288);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 22);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(111, 288);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(82, 22);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(210, 288);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(82, 22);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._5;
            pictureBox1.Location = new Point(0, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(853, 50);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.Cream_Playful_Retro_Coffee_Shop_Sign_A4_Document__11_;
            pictureBox2.Location = new Point(0, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 36);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // Managestaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            BackgroundImage = Properties.Resources._8;
            ClientSize = new Size(852, 464);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnSearch);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Controls.Add(txtSearch);
            Controls.Add(txtPosition);
            Controls.Add(txtSalary);
            Controls.Add(txtName);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Managestaff";
            Text = "Manage Staff";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Button btnSearch;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}