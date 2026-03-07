namespace Coffee_Ordering
{
    partial class form_lg1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_lg1));
            btn_ok = new Button();
            btn_back = new Button();
            txt_pass = new TextBox();
            txt_email = new TextBox();
            SuspendLayout();
            // 
            // btn_ok
            // 
            btn_ok.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ok.Location = new Point(713, 531);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(160, 42);
            btn_ok.TabIndex = 8;
            btn_ok.Text = "LOGIN";
            btn_ok.UseVisualStyleBackColor = true;
            btn_ok.Click += btn_ok_Click;
            // 
            // btn_back
            // 
            btn_back.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_back.Location = new Point(526, 531);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(160, 42);
            btn_back.TabIndex = 7;
            btn_back.Text = "BACK";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // txt_pass
            // 
            txt_pass.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_pass.Location = new Point(368, 439);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(505, 38);
            txt_pass.TabIndex = 6;
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_email.Location = new Point(368, 325);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(505, 38);
            txt_email.TabIndex = 5;
            // 
            // form_lg1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1182, 753);
            Controls.Add(btn_ok);
            Controls.Add(btn_back);
            Controls.Add(txt_pass);
            Controls.Add(txt_email);
            Name = "form_lg1";
            Text = "_1";
            Load += form_lg1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_ok;
        private Button btn_back;
        private TextBox txt_pass;
        private TextBox txt_email;
    }
}