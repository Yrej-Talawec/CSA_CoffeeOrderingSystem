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
            btnstaff = new Button();
            btnmenu = new Button();
            btnreports = new Button();
            btnlogout = new Button();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnstaff
            // 
            btnstaff.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnstaff.Image = Properties.Resources._7;
            btnstaff.Location = new Point(85, 197);
            btnstaff.Margin = new Padding(3, 2, 3, 2);
            btnstaff.Name = "btnstaff";
            btnstaff.Size = new Size(114, 33);
            btnstaff.TabIndex = 1;
            btnstaff.Text = "Manage Staff";
            btnstaff.UseVisualStyleBackColor = true;
            btnstaff.Click += btnstaff_Click;
            // 
            // btnmenu
            // 
            btnmenu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnmenu.Image = Properties.Resources._7;
            btnmenu.Location = new Point(85, 114);
            btnmenu.Margin = new Padding(3, 2, 3, 2);
            btnmenu.Name = "btnmenu";
            btnmenu.Size = new Size(114, 31);
            btnmenu.TabIndex = 2;
            btnmenu.Text = "Edit Menu";
            btnmenu.UseVisualStyleBackColor = true;
            btnmenu.Click += btnmenu_Click;
            // 
            // btnreports
            // 
            btnreports.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnreports.Image = Properties.Resources._7;
            btnreports.Location = new Point(85, 275);
            btnreports.Margin = new Padding(3, 2, 3, 2);
            btnreports.Name = "btnreports";
            btnreports.Size = new Size(121, 36);
            btnreports.TabIndex = 3;
            btnreports.Text = "Check Reports";
            btnreports.UseVisualStyleBackColor = true;
            btnreports.Click += btnreports_Click;
            // 
            // btnlogout
            // 
            btnlogout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnlogout.Image = Properties.Resources._7;
            btnlogout.Location = new Point(85, 374);
            btnlogout.Margin = new Padding(3, 2, 3, 2);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(114, 33);
            btnlogout.TabIndex = 4;
            btnlogout.Text = "Logout";
            btnlogout.UseVisualStyleBackColor = true;
            btnlogout.Click += btnlogout_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Moccasin;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(290, 83);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(550, 360);
            dataGridView1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Image = Properties.Resources._8;
            label2.Location = new Point(308, 66);
            label2.Name = "label2";
            label2.Size = new Size(139, 15);
            label2.TabIndex = 6;
            label2.Text = "Current Users Logged in?";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._5;
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(853, 50);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.Cream_Playful_Retro_Coffee_Shop_Sign_A4_Document__14_;
            pictureBox3.BackgroundImageLayout = ImageLayout.Center;
            pictureBox3.Location = new Point(-1, 49);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(285, 404);
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Image = Properties.Resources._5;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(255, 37);
            label1.TabIndex = 10;
            label1.Text = "Admin Dashboard";
            // 
            // Admin_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources._1;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(852, 454);
            Controls.Add(label1);
            Controls.Add(btnlogout);
            Controls.Add(btnreports);
            Controls.Add(btnmenu);
            Controls.Add(btnstaff);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox3);
            Margin = new Padding(3, 2, 3, 2);
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
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label label1;
    }
}