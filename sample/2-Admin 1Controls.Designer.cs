namespace Coffee_Ordering
{
    partial class ac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ac));
            label1 = new Label();
            btn_brt = new Button();
            btn_view = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(327, 52);
            label1.Name = "label1";
            label1.Size = new Size(346, 42);
            label1.TabIndex = 4;
            label1.Text = "ADMIN CONTROLS";
            label1.UseWaitCursor = true;
            // 
            // btn_brt
            // 
            btn_brt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_brt.Location = new Point(311, 374);
            btn_brt.Margin = new Padding(3, 2, 3, 2);
            btn_brt.Name = "btn_brt";
            btn_brt.Size = new Size(141, 52);
            btn_brt.TabIndex = 5;
            btn_brt.Text = "ADD BARISTA\r\nACCOUNT";
            btn_brt.UseVisualStyleBackColor = true;
            btn_brt.UseWaitCursor = true;
            btn_brt.Click += btn_brt_Click;
            // 
            // btn_view
            // 
            btn_view.BackColor = Color.Transparent;
            btn_view.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_view.Location = new Point(612, 374);
            btn_view.Margin = new Padding(3, 2, 3, 2);
            btn_view.Name = "btn_view";
            btn_view.Size = new Size(145, 52);
            btn_view.TabIndex = 6;
            btn_view.Text = "VIEW REPORT";
            btn_view.UseVisualStyleBackColor = false;
            btn_view.UseWaitCursor = true;
            btn_view.Click += btn_view_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(874, 510);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(137, 39);
            button1.TabIndex = 7;
            button1.Text = "LOG OUT";
            button1.UseVisualStyleBackColor = true;
            button1.UseWaitCursor = true;
            button1.Click += button1_Click;
            // 
            // ac
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1034, 565);
            Controls.Add(button1);
            Controls.Add(btn_view);
            Controls.Add(btn_brt);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ac";
            Text = "ADMIN CONTROLS";
            UseWaitCursor = true;
            Load += ac_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_brt;
        private Button btn_view;
        private Button button1;
    }
}