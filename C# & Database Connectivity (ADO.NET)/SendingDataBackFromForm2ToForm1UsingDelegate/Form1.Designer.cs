namespace SendingDataBackFromForm2ToForm1UsingDelegate
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
            this.btnOpenForm2 = new System.Windows.Forms.Button();
            this.txtPersonIDInForm1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOpenForm2
            // 
            this.btnOpenForm2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenForm2.Location = new System.Drawing.Point(29, 76);
            this.btnOpenForm2.Name = "btnOpenForm2";
            this.btnOpenForm2.Size = new System.Drawing.Size(134, 35);
            this.btnOpenForm2.TabIndex = 0;
            this.btnOpenForm2.Text = "Open Form 2";
            this.btnOpenForm2.UseVisualStyleBackColor = true;
            this.btnOpenForm2.Click += new System.EventHandler(this.btnOpenForm2_Click);
            // 
            // txtPersonIDInForm1
            // 
            this.txtPersonIDInForm1.Location = new System.Drawing.Point(209, 82);
            this.txtPersonIDInForm1.Name = "txtPersonIDInForm1";
            this.txtPersonIDInForm1.Size = new System.Drawing.Size(245, 24);
            this.txtPersonIDInForm1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 218);
            this.Controls.Add(this.txtPersonIDInForm1);
            this.Controls.Add(this.btnOpenForm2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenForm2;
        private System.Windows.Forms.TextBox txtPersonIDInForm1;
    }
}

