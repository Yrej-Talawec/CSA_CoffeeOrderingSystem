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
            ((System.ComponentModel.ISupportInitialize)dataGridViewMenu).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewMenu
            // 
            dataGridViewMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMenu.Location = new Point(443, 51);
            dataGridViewMenu.Name = "dataGridViewMenu";
            dataGridViewMenu.RowHeadersWidth = 51;
            dataGridViewMenu.Size = new Size(300, 188);
            dataGridViewMenu.TabIndex = 0;
            dataGridViewMenu.CellClick += dataGridViewMenu_CellClick;
            // 
            // txtName
            // 
            txtName.Location = new Point(88, 51);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 1;
            txtName.Text = "name";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(88, 117);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(125, 27);
            txtSearch.TabIndex = 2;
            txtSearch.Text = "Search";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(88, 84);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 3;
            txtPrice.Text = "Price";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(242, 50);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(151, 28);
            cmbCategory.TabIndex = 4;
            cmbCategory.Text = "Category";
            // 
            // cmbCategoryFilter
            // 
            cmbCategoryFilter.FormattingEnabled = true;
            cmbCategoryFilter.Location = new Point(242, 84);
            cmbCategoryFilter.Name = "cmbCategoryFilter";
            cmbCategoryFilter.Size = new Size(151, 28);
            cmbCategoryFilter.TabIndex = 5;
            cmbCategoryFilter.Text = "CategoryFilter";
            // 
            // chkAvailable
            // 
            chkAvailable.AutoSize = true;
            chkAvailable.Location = new Point(263, 163);
            chkAvailable.Name = "chkAvailable";
            chkAvailable.Size = new Size(93, 24);
            chkAvailable.TabIndex = 6;
            chkAvailable.Text = "Available";
            chkAvailable.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(22, 241);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(22, 206);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(22, 346);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(22, 311);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(22, 276);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Controls.Add(txtName);
            Controls.Add(dataGridViewMenu);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMenu).EndInit();
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
    }
}