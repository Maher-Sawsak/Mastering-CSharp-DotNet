namespace SendingDataBackFromForm2ToForm1UsingDelegate
{
    partial class SecondForm
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
            this.btnSendDataBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPersonID
            // 
            this.txtPersonID.Location = new System.Drawing.Point(179, 95);
            this.txtPersonID.Multiline = true;
            this.txtPersonID.Name = "txtPersonID";
            this.txtPersonID.Size = new System.Drawing.Size(236, 28);
            this.txtPersonID.TabIndex = 0;
            // 
            // btnSendDataBack
            // 
            this.btnSendDataBack.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendDataBack.Location = new System.Drawing.Point(209, 155);
            this.btnSendDataBack.Name = "btnSendDataBack";
            this.btnSendDataBack.Size = new System.Drawing.Size(164, 33);
            this.btnSendDataBack.TabIndex = 1;
            this.btnSendDataBack.Text = "Send Data Back";
            this.btnSendDataBack.UseVisualStyleBackColor = true;
            this.btnSendDataBack.Click += new System.EventHandler(this.btnSendDataBack_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "PersonID";
            // 
            // SecondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 365);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSendDataBack);
            this.Controls.Add(this.txtPersonID);
            this.Name = "SecondForm";
            this.Text = "SecondForm";
            this.Load += new System.EventHandler(this.SecondForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPersonID;
        private System.Windows.Forms.Button btnSendDataBack;
        private System.Windows.Forms.Label label1;
    }
}