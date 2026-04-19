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
            comboBox2 = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 149);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 353);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 9);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 4;
            label1.Text = "Filter by Category:";
            label1.Click += label1_Click;
            // 
            // cbfilter
            // 
            cbfilter.FormattingEnabled = true;
            cbfilter.Location = new Point(42, 32);
            cbfilter.Name = "cbfilter";
            cbfilter.Size = new Size(190, 28);
            cbfilter.TabIndex = 5;
            // 
            // cbaction
            // 
            cbaction.FormattingEnabled = true;
            cbaction.Location = new Point(327, 32);
            cbaction.Name = "cbaction";
            cbaction.Size = new Size(151, 28);
            cbaction.TabIndex = 6;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(408, 101);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(327, 9);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 8;
            label2.Text = "Filter by Action";
            label2.Click += label2_Click;
            // 
            // Admin_Logs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 514);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(cbaction);
            Controls.Add(cbfilter);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Admin_Logs";
            Text = "Admin_Logs";
            Load += Admin_Logs_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Label label1;
        private ComboBox cbfilter;
        private ComboBox cbaction;
        private ComboBox comboBox2;
        private Label label2;
    }
}