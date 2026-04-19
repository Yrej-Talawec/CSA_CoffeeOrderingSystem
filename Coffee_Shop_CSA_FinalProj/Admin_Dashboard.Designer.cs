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
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnstaff
            // 
            btnstaff.Image = Properties.Resources._7;
            btnstaff.Location = new Point(133, 200);
            btnstaff.Margin = new Padding(3, 2, 3, 2);
            btnstaff.Name = "btnstaff";
            btnstaff.Size = new Size(114, 22);
            btnstaff.TabIndex = 1;
            btnstaff.Text = "Manage Staff";
            btnstaff.UseVisualStyleBackColor = true;
            btnstaff.Click += btnstaff_Click;
            // 
            // btnmenu
            // 
            btnmenu.Image = Properties.Resources._7;
            btnmenu.Location = new Point(133, 150);
            btnmenu.Margin = new Padding(3, 2, 3, 2);
            btnmenu.Name = "btnmenu";
            btnmenu.Size = new Size(114, 22);
            btnmenu.TabIndex = 2;
            btnmenu.Text = "Edit Menu";
            btnmenu.UseVisualStyleBackColor = true;
            btnmenu.Click += btnmenu_Click;
            // 
            // btnreports
            // 
            btnreports.Image = Properties.Resources._7;
            btnreports.Location = new Point(133, 258);
            btnreports.Margin = new Padding(3, 2, 3, 2);
            btnreports.Name = "btnreports";
            btnreports.Size = new Size(114, 22);
            btnreports.TabIndex = 3;
            btnreports.Text = "Check Reports";
            btnreports.UseVisualStyleBackColor = true;
            btnreports.Click += btnreports_Click;
            // 
            // btnlogout
            // 
            btnlogout.Image = Properties.Resources._7;
            btnlogout.Location = new Point(133, 314);
            btnlogout.Margin = new Padding(3, 2, 3, 2);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(114, 22);
            btnlogout.TabIndex = 4;
            btnlogout.Text = "Logout";
            btnlogout.UseVisualStyleBackColor = true;
            btnlogout.Click += btnlogout_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Moccasin;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(352, 114);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(488, 339);
            dataGridView1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Image = Properties.Resources._8;
            label2.Location = new Point(352, 85);
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
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.Cream_Playful_Retro_Coffee_Shop_Sign_A4_Document__10_;
            pictureBox2.Location = new Point(-1, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(265, 37);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.Cream_Playful_Retro_Coffee_Shop_Sign_A4_Document__14_;
            pictureBox3.Location = new Point(44, 67);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(286, 385);
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // Admin_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources._1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(852, 464);
            Controls.Add(pictureBox2);
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
            Text = "ta";
            Load += Admin_Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}