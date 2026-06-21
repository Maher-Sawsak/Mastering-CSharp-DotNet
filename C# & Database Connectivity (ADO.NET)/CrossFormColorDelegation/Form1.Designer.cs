namespace CrossFormColorDelegation
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
            this.lblColor = new System.Windows.Forms.Label();
            this.btnOpenColorForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblColor
            // 
            this.lblColor.Font = new System.Drawing.Font("Tahoma", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(99, 106);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(207, 58);
            this.lblColor.TabIndex = 0;
            this.lblColor.Text = "Color";
            this.lblColor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblColor.Click += new System.EventHandler(this.lblColor_Click);
            // 
            // btnOpenColorForm
            // 
            this.btnOpenColorForm.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenColorForm.Location = new System.Drawing.Point(413, 98);
            this.btnOpenColorForm.Name = "btnOpenColorForm";
            this.btnOpenColorForm.Size = new System.Drawing.Size(177, 66);
            this.btnOpenColorForm.TabIndex = 1;
            this.btnOpenColorForm.Text = "Open Color";
            this.btnOpenColorForm.UseVisualStyleBackColor = true;
            this.btnOpenColorForm.Click += new System.EventHandler(this.btnOpenColorForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 316);
            this.Controls.Add(this.btnOpenColorForm);
            this.Controls.Add(this.lblColor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Button btnOpenColorForm;
    }
}

