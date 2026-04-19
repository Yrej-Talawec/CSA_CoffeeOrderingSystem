namespace Coffee_Shop_CSA_FinalProj
{
    partial class Admin_Dashboard
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
            label1 = new Label();
            btnstaff = new Button();
            btnmenu = new Button();
            btnreports = new Button();
            btnlogout = new Button();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 13);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 0;
            label1.Text = "Admin Dashboard";
            // 
            // btnstaff
            // 
            btnstaff.Location = new Point(22, 58);
            btnstaff.Name = "btnstaff";
            btnstaff.Size = new Size(130, 29);
            btnstaff.TabIndex = 1;
            btnstaff.Text = "Manage Staff";
            btnstaff.UseVisualStyleBackColor = true;
            btnstaff.Click += btnstaff_Click;
            // 
            // btnmenu
            // 
            btnmenu.Location = new Point(22, 93);
            btnmenu.Name = "btnmenu";
            btnmenu.Size = new Size(130, 29);
            btnmenu.TabIndex = 2;
            btnmenu.Text = "Edit Menu";
            btnmenu.UseVisualStyleBackColor = true;
            btnmenu.Click += btnmenu_Click;
            // 
            // btnreports
            // 
            btnreports.Location = new Point(22, 128);
            btnreports.Name = "btnreports";
            btnreports.Size = new Size(130, 29);
            btnreports.TabIndex = 3;
            btnreports.Text = "Check Reports";
            btnreports.UseVisualStyleBackColor = true;
            btnreports.Click += btnreports_Click;
            // 
            // btnlogout
            // 
            btnlogout.Location = new Point(22, 163);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(130, 29);
            btnlogout.TabIndex = 4;
            btnlogout.Text = "Logout";
            btnlogout.UseVisualStyleBackColor = true;
            btnlogout.Click += btnlogout_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(245, 128);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(501, 262);
            dataGridView1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(245, 93);
            label2.Name = "label2";
            label2.Size = new Size(174, 20);
            label2.TabIndex = 6;
            label2.Text = "Current Users Logged in?";
            // 
            // Admin_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.kape;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(912, 493);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(btnlogout);
            Controls.Add(btnreports);
            Controls.Add(btnmenu);
            Controls.Add(btnstaff);
            Controls.Add(label1);
            Name = "Admin_Dashboard";
            Text = "ta";
            Load += Admin_Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnstaff;
        private Button btnmenu;
        private Button btnreports;
        private Button btnlogout;
        private DataGridView dataGridView1;
        private Label label2;
    }
}