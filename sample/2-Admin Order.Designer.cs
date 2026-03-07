namespace Coffee_Ordering
{
    partial class Order_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order_Info));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button2 = new Button();
            button1 = new Button();
            btn_del_data = new Button();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            tabPage2 = new TabPage();
            label1 = new Label();
            btn_s = new Button();
            button3 = new Button();
            btn_a = new Button();
            dataGridView2 = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(-2, -3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1494, 859);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackgroundImage = (Image)resources.GetObject("tabPage1.BackgroundImage");
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(btn_del_data);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 3, 3, 3);
            tabPage1.Size = new Size(1486, 826);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(1157, 749);
            button2.Name = "button2";
            button2.Size = new Size(98, 53);
            button2.TabIndex = 55;
            button2.Text = "BACK";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(1173, 16);
            button1.Name = "button1";
            button1.Size = new Size(98, 53);
            button1.TabIndex = 54;
            button1.Text = "Data\r\nArchive";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_del_data
            // 
            btn_del_data.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_del_data.Location = new Point(1032, 749);
            btn_del_data.Name = "btn_del_data";
            btn_del_data.Size = new Size(98, 53);
            btn_del_data.TabIndex = 53;
            btn_del_data.Text = "DATA\r\nDELETE";
            btn_del_data.UseVisualStyleBackColor = true;
            btn_del_data.Click += btn_del_data_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 85);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1214, 605);
            dataGridView1.TabIndex = 39;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(429, 16);
            label2.Name = "label2";
            label2.Size = new Size(526, 53);
            label2.TabIndex = 38;
            label2.Text = "ORDER INFORMATION";
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = (Image)resources.GetObject("tabPage2.BackgroundImage");
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(btn_s);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(btn_a);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 3, 3, 3);
            tabPage2.Size = new Size(1486, 826);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(575, 23);
            label1.Name = "label1";
            label1.Size = new Size(154, 36);
            label1.TabIndex = 1;
            label1.Text = "ARCHIVE";
            // 
            // btn_s
            // 
            btn_s.BackColor = Color.FromArgb(113, 98, 75);
            btn_s.Location = new Point(567, 15);
            btn_s.Name = "btn_s";
            btn_s.Size = new Size(168, 55);
            btn_s.TabIndex = 5;
            btn_s.Text = "button4";
            btn_s.UseVisualStyleBackColor = false;
            btn_s.Click += btn_s_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(1131, 755);
            button3.Name = "button3";
            button3.Size = new Size(123, 51);
            button3.TabIndex = 4;
            button3.Text = "BACK";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btn_a
            // 
            btn_a.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_a.Location = new Point(601, 755);
            btn_a.Name = "btn_a";
            btn_a.Size = new Size(138, 51);
            btn_a.TabIndex = 3;
            btn_a.Text = "Archive";
            btn_a.UseVisualStyleBackColor = true;
            btn_a.Click += btn_a_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(34, 91);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(1221, 648);
            dataGridView2.TabIndex = 0;
            // 
            // Order_Info
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1285, 845);
            Controls.Add(tabControl1);
            Name = "Order_Info";
            Text = "a";
            Load += Order_Info_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private Label label2;
        private TabPage tabPage2;
        private Button button2;
        private Button button1;
        private Button btn_del_data;
        private Label label1;
        private DataGridView dataGridView2;
        private Button button3;
        private Button btn_a;
        private Button btn_s;
    }
}