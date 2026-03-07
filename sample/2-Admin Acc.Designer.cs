namespace Coffee_Ordering
{
    partial class _2_Admin_Acc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_2_Admin_Acc));
            label3 = new Label();
            label12 = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            txt_name = new TextBox();
            txt_un = new TextBox();
            txt_pass = new TextBox();
            button1 = new Button();
            btn_clear = new Button();
            btn_back = new Button();
            label5 = new Label();
            txt_add = new TextBox();
            dataGridView1 = new DataGridView();
            txt_ct = new TextBox();
            label6 = new Label();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(45, 134);
            label3.Name = "label3";
            label3.Size = new Size(237, 41);
            label3.TabIndex = 35;
            label3.Text = "BARISTA NAME:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Tahoma", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Transparent;
            label12.Location = new Point(21, 58);
            label12.Name = "label12";
            label12.Size = new Size(471, 45);
            label12.TabIndex = 36;
            label12.Text = "ADD BARISTA ACCOUNT";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(45, 262);
            label1.Name = "label1";
            label1.Size = new Size(294, 41);
            label1.TabIndex = 37;
            label1.Text = "CONTACT NUMBER:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(45, 325);
            label2.Name = "label2";
            label2.Size = new Size(184, 41);
            label2.TabIndex = 38;
            label2.Text = "USERNAME:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(45, 393);
            label4.Name = "label4";
            label4.Size = new Size(186, 41);
            label4.TabIndex = 39;
            label4.Text = "PASSWORD:";
            // 
            // txt_name
            // 
            txt_name.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_name.Location = new Point(376, 141);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(617, 34);
            txt_name.TabIndex = 41;
            txt_name.TextChanged += txt_name_TextChanged;
            // 
            // txt_un
            // 
            txt_un.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_un.Location = new Point(376, 332);
            txt_un.Name = "txt_un";
            txt_un.Size = new Size(617, 34);
            txt_un.TabIndex = 43;
            // 
            // txt_pass
            // 
            txt_pass.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_pass.Location = new Point(376, 393);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(617, 34);
            txt_pass.TabIndex = 44;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(1036, 219);
            button1.Name = "button1";
            button1.Size = new Size(109, 47);
            button1.TabIndex = 45;
            button1.Text = "SAVE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_clear
            // 
            btn_clear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_clear.Location = new Point(1036, 305);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(109, 47);
            btn_clear.TabIndex = 46;
            btn_clear.Text = "CLEAR";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_back
            // 
            btn_back.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_back.Location = new Point(1049, 681);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(109, 47);
            btn_back.TabIndex = 47;
            btn_back.Text = "BACK";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(45, 199);
            label5.Name = "label5";
            label5.Size = new Size(156, 41);
            label5.TabIndex = 48;
            label5.Text = "ADDRESS:";
            // 
            // txt_add
            // 
            txt_add.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_add.Location = new Point(376, 206);
            txt_add.Name = "txt_add";
            txt_add.Size = new Size(617, 34);
            txt_add.TabIndex = 49;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(156, 501);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(823, 227);
            dataGridView1.TabIndex = 53;
            // 
            // txt_ct
            // 
            txt_ct.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_ct.Location = new Point(376, 269);
            txt_ct.Name = "txt_ct";
            txt_ct.Size = new Size(617, 34);
            txt_ct.TabIndex = 54;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(436, 456);
            label6.Name = "label6";
            label6.Size = new Size(281, 28);
            label6.TabIndex = 55;
            label6.Text = "Barista Account Information";
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // _2_Admin_Acc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1182, 753);
            Controls.Add(label6);
            Controls.Add(txt_ct);
            Controls.Add(dataGridView1);
            Controls.Add(txt_add);
            Controls.Add(label5);
            Controls.Add(btn_back);
            Controls.Add(btn_clear);
            Controls.Add(button1);
            Controls.Add(txt_pass);
            Controls.Add(txt_un);
            Controls.Add(txt_name);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label12);
            Controls.Add(label3);
            Name = "_2_Admin_Acc";
            Load += _2_Admin_Acc_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label12;
        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox txt_name;
        private TextBox txt_un;
        private TextBox txt_pass;
        private Button button1;
        private Button btn_clear;
        private Button btn_back;
        private Label label5;
        private TextBox txt_add;
        private DataGridView dataGridView1;
        private TextBox txt_ct;
        private Label label6;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}