namespace Coffee_Shop_CSA_FinalProj
{
    partial class Admin_Dashboard
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
            btnstaff = new Button();
            btnmenu = new Button();
            btnreports = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 68);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 0;
            label1.Text = "Admin Dashboard";
            // 
            // btnstaff
            // 
            btnstaff.Location = new Point(50, 123);
            btnstaff.Name = "btnstaff";
            btnstaff.Size = new Size(141, 29);
            btnstaff.TabIndex = 1;
            btnstaff.Text = "Manage Staff";
            btnstaff.UseVisualStyleBackColor = true;
            // 
            // btnmenu
            // 
            btnmenu.Location = new Point(50, 172);
            btnmenu.Name = "btnmenu";
            btnmenu.Size = new Size(141, 29);
            btnmenu.TabIndex = 2;
            btnmenu.Text = "Edit Menu";
            btnmenu.UseVisualStyleBackColor = true;
            // 
            // btnreports
            // 
            btnreports.Location = new Point(50, 219);
            btnreports.Name = "btnreports";
            btnreports.Size = new Size(141, 29);
            btnreports.TabIndex = 3;
            btnreports.Text = "Check Reports";
            btnreports.UseVisualStyleBackColor = true;
            // 
            // Admin_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnreports);
            Controls.Add(btnmenu);
            Controls.Add(btnstaff);
            Controls.Add(label1);
            Name = "Admin_Dashboard";
            Text = "Admin_Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnstaff;
        private Button btnmenu;
        private Button btnreports;
    }
}