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
            btnLogin.Location = new Point(62, 129);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 26);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 1;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 69);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Location = new Point(103, 69);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.Size = new Size(125, 27);
            txtBoxPassword.TabIndex = 4;
            txtBoxPassword.TextChanged += txtBoxPassword_TextChanged;
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.Location = new Point(103, 26);
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.Size = new Size(125, 27);
            txtBoxEmail.TabIndex = 3;
            txtBoxEmail.TextChanged += txtBoxEmail_TextChanged;
            // 
            // Login_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Johnny_Lloyd;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(641, 384);
            Controls.Add(txtBoxPassword);
            Controls.Add(txtBoxEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogin);
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