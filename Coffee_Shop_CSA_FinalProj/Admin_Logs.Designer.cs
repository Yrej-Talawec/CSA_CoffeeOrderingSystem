namespace Coffee_Shop_CSA_FinalProj
{
    partial class Admin_Logs
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            cbfilter = new ComboBox();
            cbaction = new ComboBox();
            label2 = new Label();
            btnsearch = new Button();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Moccasin;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 178);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(828, 265);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Image = Properties.Resources._8;
            label1.Location = new Point(106, 77);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 4;
            label1.Text = "Filter by Category:";
            label1.Click += label1_Click;
            // 
            // cbfilter
            // 
            cbfilter.FormattingEnabled = true;
            cbfilter.Location = new Point(106, 94);
            cbfilter.Margin = new Padding(3, 2, 3, 2);
            cbfilter.Name = "cbfilter";
            cbfilter.Size = new Size(167, 23);
            cbfilter.TabIndex = 5;
            cbfilter.SelectedIndexChanged += cbfilter_SelectedIndexChanged_1;
            // 
            // cbaction
            // 
            cbaction.FormattingEnabled = true;
            cbaction.Location = new Point(306, 94);
            cbaction.Margin = new Padding(3, 2, 3, 2);
            cbaction.Name = "cbaction";
            cbaction.Size = new Size(146, 23);
            cbaction.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Image = Properties.Resources._8;
            label2.Location = new Point(306, 77);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 8;
            label2.Text = "Filter by Action";
            label2.Click += label2_Click;
            // 
            // btnsearch
            // 
            btnsearch.BackgroundImage = Properties.Resources._7;
            btnsearch.Location = new Point(665, 129);
            btnsearch.Margin = new Padding(3, 2, 3, 2);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(82, 22);
            btnsearch.TabIndex = 9;
            btnsearch.Text = "Search";
            btnsearch.UseVisualStyleBackColor = true;
            btnsearch.Click += btnsearch_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Image = Properties.Resources._8;
            label3.Location = new Point(491, 78);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 10;
            label3.Text = "Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(491, 96);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(257, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._5;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(853, 50);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Image = Properties.Resources._5;
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(178, 37);
            label4.TabIndex = 13;
            label4.Text = "Admin Logs";
            // 
            // Admin_Logs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1;
            ClientSize = new Size(852, 454);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(btnsearch);
            Controls.Add(label2);
            Controls.Add(cbaction);
            Controls.Add(cbfilter);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Admin_Logs";
            Text = "Admin_Logs";
            Load += Admin_Logs_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Label label1;
        private ComboBox cbfilter;
        private ComboBox cbaction;
        private Label label2;
        private Button btnsearch;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBox1;
        private Label label4;
    }
}