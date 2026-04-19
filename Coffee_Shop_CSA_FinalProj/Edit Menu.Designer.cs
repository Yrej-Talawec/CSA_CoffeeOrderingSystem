namespace Coffee_Shop_CSA_FinalProj
{
    partial class Form1
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
            dataGridViewMenu = new DataGridView();
            txtName = new TextBox();
            txtSearch = new TextBox();
            txtPrice = new TextBox();
            cmbCategory = new ComboBox();
            cmbCategoryFilter = new ComboBox();
            chkAvailable = new CheckBox();
            btnUpdate = new Button();
            btnAdd = new Button();
            btnClear = new Button();
            btnSearch = new Button();
            btnDelete = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewMenu
            // 
            dataGridViewMenu.BackgroundColor = Color.Moccasin;
            dataGridViewMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMenu.Location = new Point(345, 68);
            dataGridViewMenu.Margin = new Padding(3, 2, 3, 2);
            dataGridViewMenu.Name = "dataGridViewMenu";
            dataGridViewMenu.RowHeadersWidth = 51;
            dataGridViewMenu.Size = new Size(495, 375);
            dataGridViewMenu.TabIndex = 0;
            dataGridViewMenu.CellClick += dataGridViewMenu_CellClick;
            // 
            // txtName
            // 
            txtName.BackColor = Color.Moccasin;
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.Location = new Point(30, 80);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(119, 29);
            txtName.TabIndex = 1;
            txtName.Text = "Name";
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.Moccasin;
            txtSearch.Font = new Font("Segoe UI", 12F);
            txtSearch.Location = new Point(30, 172);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(119, 29);
            txtSearch.TabIndex = 2;
            txtSearch.Text = "Search";
            txtSearch.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPrice
            // 
            txtPrice.BackColor = Color.Moccasin;
            txtPrice.Font = new Font("Segoe UI", 12F);
            txtPrice.Location = new Point(30, 126);
            txtPrice.Margin = new Padding(3, 2, 3, 2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(119, 29);
            txtPrice.TabIndex = 3;
            txtPrice.Text = "Price";
            txtPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // cmbCategory
            // 
            cmbCategory.BackColor = Color.Moccasin;
            cmbCategory.Font = new Font("Segoe UI", 12F);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(196, 80);
            cmbCategory.Margin = new Padding(3, 2, 3, 2);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(119, 29);
            cmbCategory.TabIndex = 4;
            cmbCategory.Text = "Category";
            // 
            // cmbCategoryFilter
            // 
            cmbCategoryFilter.BackColor = Color.Moccasin;
            cmbCategoryFilter.Font = new Font("Segoe UI", 12F);
            cmbCategoryFilter.FormattingEnabled = true;
            cmbCategoryFilter.Location = new Point(196, 126);
            cmbCategoryFilter.Margin = new Padding(3, 2, 3, 2);
            cmbCategoryFilter.Name = "cmbCategoryFilter";
            cmbCategoryFilter.Size = new Size(119, 29);
            cmbCategoryFilter.TabIndex = 5;
            cmbCategoryFilter.Text = "CategoryFilter";
            // 
            // chkAvailable
            // 
            chkAvailable.AutoSize = true;
            chkAvailable.BackColor = Color.Moccasin;
            chkAvailable.Font = new Font("Segoe UI", 12F);
            chkAvailable.Location = new Point(196, 172);
            chkAvailable.Margin = new Padding(3, 2, 3, 2);
            chkAvailable.Name = "chkAvailable";
            chkAvailable.Size = new Size(92, 25);
            chkAvailable.TabIndex = 6;
            chkAvailable.Text = "Available";
            chkAvailable.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F);
            btnUpdate.Image = Properties.Resources._7;
            btnUpdate.Location = new Point(78, 312);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(183, 31);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F);
            btnAdd.Image = Properties.Resources._7;
            btnAdd.Location = new Point(78, 277);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(183, 31);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F);
            btnClear.Image = Properties.Resources._7;
            btnClear.Location = new Point(78, 347);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(183, 31);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 12F);
            btnSearch.Image = Properties.Resources._7;
            btnSearch.Location = new Point(78, 242);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(183, 31);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F);
            btnDelete.Image = Properties.Resources._7;
            btnDelete.Location = new Point(78, 382);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(183, 31);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Image = Properties.Resources._5;
            label1.Location = new Point(11, 10);
            label1.Name = "label1";
            label1.Size = new Size(206, 37);
            label1.TabIndex = 14;
            label1.Text = "Manage Menu";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._5;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(853, 50);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1;
            ClientSize = new Size(852, 454);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnDelete);
            Controls.Add(btnSearch);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(chkAvailable);
            Controls.Add(cmbCategoryFilter);
            Controls.Add(cmbCategory);
            Controls.Add(txtPrice);
            Controls.Add(txtSearch);
            Controls.Add(dataGridViewMenu);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Edit_Menu";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewMenu;
        private TextBox txtName;
        private TextBox txtSearch;
        private TextBox txtPrice;
        private ComboBox cmbCategory;
        private ComboBox cmbCategoryFilter;
        private CheckBox chkAvailable;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnClear;
        private Button btnSearch;
        private Button btnDelete;
        private Label label1;
        private PictureBox pictureBox1;
    }
}