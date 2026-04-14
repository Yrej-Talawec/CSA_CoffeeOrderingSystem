namespace Coffee_Shop_CSA_FinalProj
{
    partial class Receipt_Form
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
            txtBoxReceipt = new TextBox();
            SuspendLayout();
            // 
            // txtBoxReceipt
            // 
            txtBoxReceipt.Location = new Point(254, 44);
            txtBoxReceipt.Multiline = true;
            txtBoxReceipt.Name = "txtBoxReceipt";
            txtBoxReceipt.Size = new Size(258, 307);
            txtBoxReceipt.TabIndex = 0;
            // 
            // Receipt_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBoxReceipt);
            Name = "Receipt_Form";
            Text = "Receipt_Form";
            Load += Receipt_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxReceipt;
    }
}