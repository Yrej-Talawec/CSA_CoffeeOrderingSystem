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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Dashboard));
            btnstaff = new Button();
            btnmenu = new Button();
            btnreports = new Button();
            btnlogout = new Button();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnstaff
            // 
            btnstaff.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnstaff.Image = Properties.Resources._7;
            btnstaff.Location = new Point(81, 215);
            btnstaff.Name = "btnstaff";
            btnstaff.Size = new Size(130, 44);
            btnstaff.TabIndex = 1;
            btnstaff.Text = "Manage Staff";
            btnstaff.UseVisualStyleBackColor = true;
            btnstaff.Click += btnstaff_Click;
            // 
            // btnmenu
            // 
            btnmenu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnmenu.Image = Properties.Resources._7;
            btnmenu.Location = new Point(81, 141);
            btnmenu.Name = "btnmenu";
            btnmenu.Size = new Size(130, 41);
            btnmenu.TabIndex = 2;
            btnmenu.Text = "Edit Menu";
            btnmenu.UseVisualStyleBackColor = true;
            btnmenu.Click += btnmenu_Click;
            // 
            // btnreports
            // 
            btnreports.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnreports.Image = Properties.Resources._7;
            btnreports.Location = new Point(81, 294);
            btnreports.Name = "btnreports";
            btnreports.Size = new Size(130, 44);
            btnreports.TabIndex = 3;
            btnreports.Text = "Check Reports";
            btnreports.UseVisualStyleBackColor = true;
            btnreports.Click += btnreports_Click;
            // 
            // btnlogout
            // 
            btnlogout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnlogout.Image = Properties.Resources._7;
            btnlogout.Location = new Point(81, 490);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(130, 44);
            btnlogout.TabIndex = 4;
            btnlogout.Text = "Logout";
            btnlogout.UseVisualStyleBackColor = true;
            btnlogout.Click += btnlogout_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Moccasin;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(316, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(643, 473);
            dataGridView1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._5;
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(975, 67);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(-1, 64);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(295, 547);
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Image = Properties.Resources._5;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(331, 48);
            label1.TabIndex = 10;
            label1.Text = "Admin Dashboard";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Image = Properties.Resources._8;
            label2.Location = new Point(352, 88);
            label2.Name = "label2";
            label2.Size = new Size(174, 20);
            label2.TabIndex = 6;
            label2.Text = "Current Users Logged in?";
            label2.Click += label2_Click;
            // 
            // Admin_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources._1;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(971, 605);
            Controls.Add(label1);
            Controls.Add(btnlogout);
            Controls.Add(btnreports);
            Controls.Add(btnmenu);
            Controls.Add(btnstaff);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox3);
            Name = "Admin_Dashboard";
            Text = "Admin_Dashboard";
            Load += Admin_Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnstaff;
        private Button btnmenu;
        private Button btnreports;
        private Button btnlogout;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
    }
}