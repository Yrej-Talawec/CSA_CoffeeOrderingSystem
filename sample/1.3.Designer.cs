namespace Coffee_Ordering
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            txt_un = new TextBox();
            txt_pass = new TextBox();
            btn_back = new Button();
            btn_ok = new Button();
            SuspendLayout();
            // 
            // txt_un
            // 
            txt_un.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_un.Location = new Point(373, 321);
            txt_un.Name = "txt_un";
            txt_un.Size = new Size(505, 38);
            txt_un.TabIndex = 0;
            // 
            // txt_pass
            // 
            txt_pass.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_pass.Location = new Point(373, 435);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(505, 38);
            txt_pass.TabIndex = 1;
            // 
            // btn_back
            // 
            btn_back.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_back.Location = new Point(531, 527);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(160, 42);
            btn_back.TabIndex = 3;
            btn_back.Text = "BACK";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // btn_ok
            // 
            btn_ok.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ok.Location = new Point(718, 527);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(160, 42);
            btn_ok.TabIndex = 4;
            btn_ok.Text = "LOGIN";
            btn_ok.UseVisualStyleBackColor = true;
            btn_ok.Click += btn_ok_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1182, 753);
            Controls.Add(btn_ok);
            Controls.Add(btn_back);
            Controls.Add(txt_pass);
            Controls.Add(txt_un);
            Name = "Form3";
            Text = "_2";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_un;
        private TextBox txt_pass;
        private Button btn_back;
        private Button btn_ok;
    }
}