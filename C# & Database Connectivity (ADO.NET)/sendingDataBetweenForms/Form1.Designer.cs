namespace sendingDataBetweenForms
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
            this.txtPersonID = new System.Windows.Forms.TextBox();
            this.btnSendData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPersonID
            // 
            this.txtPersonID.Location = new System.Drawing.Point(72, 37);
            this.txtPersonID.Multiline = true;
            this.txtPersonID.Name = "txtPersonID";
            this.txtPersonID.Size = new System.Drawing.Size(281, 35);
            this.txtPersonID.TabIndex = 0;
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(139, 98);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(127, 37);
            this.btnSendData.TabIndex = 1;
            this.btnSendData.Text = "Send Data";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 163);
            this.Controls.Add(this.btnSendData);
            this.Controls.Add(this.txtPersonID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPersonID;
        private System.Windows.Forms.Button btnSendData;
    }
}

