namespace Coffee_Shop_CSA_FinalProj
{
    partial class Managestaff
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
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            dataGridView1 = new DataGridView();
            Emp_ID = new DataGridViewTextBoxColumn();
            Emp_Email = new DataGridViewTextBoxColumn();
            position = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            button2 = new Button();
            delete = new Button();
            exit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 14);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "Emp_ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 76);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 1;
            label2.Text = "Position";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 43);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 2;
            label3.Text = "Emp_email";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(120, 7);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(120, 73);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(125, 40);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Emp_ID, Emp_Email, position });
            dataGridView1.Location = new Point(12, 261);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(429, 188);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Emp_ID
            // 
            Emp_ID.HeaderText = "Emp_ID";
            Emp_ID.MinimumWidth = 6;
            Emp_ID.Name = "Emp_ID";
            Emp_ID.Width = 125;
            // 
            // Emp_Email
            // 
            Emp_Email.HeaderText = "Emp_Email";
            Emp_Email.MinimumWidth = 6;
            Emp_Email.Name = "Emp_Email";
            Emp_Email.Width = 125;
            // 
            // position
            // 
            position.HeaderText = "Position";
            position.MinimumWidth = 6;
            position.Name = "position";
            position.Width = 125;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(8, 132);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(232, 132);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 8;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            delete.Location = new Point(120, 132);
            delete.Name = "delete";
            delete.Size = new Size(94, 29);
            delete.TabIndex = 9;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            exit.Location = new Point(868, 420);
            exit.Name = "exit";
            exit.Size = new Size(94, 29);
            exit.TabIndex = 11;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = true;
            // 
            // Managestaff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            BackgroundImage = Properties.Resources.kapi;
            ClientSize = new Size(997, 490);
            Controls.Add(exit);
            Controls.Add(delete);
            Controls.Add(button2);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Managestaff";
            Text = "Manage Staff";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private DataGridView dataGridView1;
        private Button btnAdd;
        private Button button2;
        private Button delete;
        private Button exit;
        private DataGridViewTextBoxColumn Emp_ID;
        private DataGridViewTextBoxColumn Emp_Email;
        private DataGridViewTextBoxColumn position;
    }
}