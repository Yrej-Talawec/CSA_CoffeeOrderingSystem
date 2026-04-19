namespace Coffee_Shop_CSA_FinalProj
{
    partial class Login_Page
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
            btnLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            txtBoxPassword = new TextBox();
            txtBoxEmail = new TextBox();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(94, 258);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(82, 22);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 181);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 213);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Location = new Point(130, 213);
            txtBoxPassword.Margin = new Padding(3, 2, 3, 2);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.Size = new Size(110, 23);
            txtBoxPassword.TabIndex = 4;
            txtBoxPassword.TextChanged += txtBoxPassword_TextChanged;
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.Location = new Point(130, 181);
            txtBoxEmail.Margin = new Padding(3, 2, 3, 2);
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.Size = new Size(110, 23);
            txtBoxEmail.TabIndex = 3;
            txtBoxEmail.TextChanged += txtBoxEmail_TextChanged;
            // 
            // Login_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Cream_Playful_Retro_Coffee_Shop_Sign_A4_Document__4_;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(852, 464);
            Controls.Add(txtBoxPassword);
            Controls.Add(txtBoxEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login_Page";
            Text = "Login_Page";
            Load += Login_Page_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label label1;
        private Label label2;
        private TextBox txtBoxPassword;
        private TextBox txtBoxEmail;
    }
}