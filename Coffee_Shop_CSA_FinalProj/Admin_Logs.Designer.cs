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
            cbfilter.SelectedIndexChanged += cbfilter_SelectedIndexChanged_1;
            // 
            // cbaction
            // 
            cbaction.FormattingEnabled = true;
            cbaction.Location = new Point(271, 32);
            cbaction.Name = "cbaction";
            cbaction.Size = new Size(166, 28);
            cbaction.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(271, 9);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 8;
            label2.Text = "Filter by Action";
            label2.Click += label2_Click;
            // 
            // btnsearch
            // 
            btnsearch.Location = new Point(681, 79);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(94, 29);
            btnsearch.TabIndex = 9;
            btnsearch.Text = "Search";
            btnsearch.UseVisualStyleBackColor = true;
            btnsearch.Click += btnsearch_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(482, 11);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 10;
            label3.Text = "Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(482, 34);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(293, 27);
            dateTimePicker1.TabIndex = 11;
            // 
            // Admin_Logs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 514);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(btnsearch);
            Controls.Add(label2);
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
        private Label label2;
        private Button btnsearch;
        private Label label3;
        private DateTimePicker dateTimePicker1;
    }
}