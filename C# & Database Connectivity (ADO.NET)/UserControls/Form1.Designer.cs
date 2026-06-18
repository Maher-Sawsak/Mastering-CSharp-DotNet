namespace UserControls
{
    partial class Form1
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
            this.cashierHeaderUC1 = new UserControls.CashierHeaderUC();
            this.cashierHeaderUC2 = new UserControls.CashierHeaderUC();
            this.SuspendLayout();
            // 
            // cashierHeaderUC1
            // 
            this.cashierHeaderUC1.Dock = System.Windows.Forms.DockStyle.Top;
            this.cashierHeaderUC1.Location = new System.Drawing.Point(0, 0);
            this.cashierHeaderUC1.Name = "cashierHeaderUC1";
            this.cashierHeaderUC1.Size = new System.Drawing.Size(800, 101);
            this.cashierHeaderUC1.TabIndex = 0;
            // 
            // cashierHeaderUC2
            // 
            this.cashierHeaderUC2.Location = new System.Drawing.Point(0, 349);
            this.cashierHeaderUC2.Name = "cashierHeaderUC2";
            this.cashierHeaderUC2.Size = new System.Drawing.Size(800, 101);
            this.cashierHeaderUC2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cashierHeaderUC2);
            this.Controls.Add(this.cashierHeaderUC1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CashierHeaderUC cashierHeaderUC1;
        private CashierHeaderUC cashierHeaderUC2;
    }
}

