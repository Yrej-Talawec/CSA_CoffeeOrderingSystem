namespace Coffee_Ordering
{
    partial class SummaryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SummaryForm));
            label12 = new Label();
            btn_receipt = new Button();
            btn_exit = new Button();
            button1 = new Button();
            button2 = new Button();
            txt_Summary = new RichTextBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Tahoma", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Transparent;
            label12.Location = new Point(367, 33);
            label12.Name = "label12";
            label12.Size = new Size(448, 45);
            label12.TabIndex = 32;
            label12.Text = "SUMMARY OF RECEIPT";
            // 
            // btn_receipt
            // 
            btn_receipt.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_receipt.Location = new Point(376, 608);
            btn_receipt.Name = "btn_receipt";
            btn_receipt.Size = new Size(116, 74);
            btn_receipt.TabIndex = 48;
            btn_receipt.Text = "PRINT\r\nRECEIPT";
            btn_receipt.UseVisualStyleBackColor = true;
            btn_receipt.Click += btn_receipt_Click;
            // 
            // btn_exit
            // 
            btn_exit.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_exit.Location = new Point(932, 694);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(116, 47);
            btn_exit.TabIndex = 49;
            btn_exit.Text = "EXIT";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(680, 608);
            button1.Name = "button1";
            button1.Size = new Size(116, 74);
            button1.TabIndex = 52;
            button1.Text = "NEW \r\nORDER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(1054, 694);
            button2.Name = "button2";
            button2.Size = new Size(116, 47);
            button2.TabIndex = 55;
            button2.Text = "LOGOUT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txt_Summary
            // 
            txt_Summary.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txt_Summary.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Summary.Location = new Point(402, 111);
            txt_Summary.Name = "txt_Summary";
            txt_Summary.ScrollBars = RichTextBoxScrollBars.Vertical;
            txt_Summary.Size = new Size(376, 448);
            txt_Summary.TabIndex = 57;
            txt_Summary.Text = "";
            txt_Summary.TextChanged += rec_TextChanged_1;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(528, 608);
            button3.Name = "button3";
            button3.Size = new Size(116, 74);
            button3.TabIndex = 58;
            button3.Text = "BACK";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // SummaryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1182, 753);
            Controls.Add(button3);
            Controls.Add(txt_Summary);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btn_exit);
            Controls.Add(btn_receipt);
            Controls.Add(label12);
            Name = "SummaryForm";
            Text = "Form3";
            Load += SummaryForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label12;
        private Button btn_receipt;
        private Button btn_exit;
        private Button button1;
        private Button button2;
        private RichTextBox txt_Summary;
        private Button button3;
    }
}