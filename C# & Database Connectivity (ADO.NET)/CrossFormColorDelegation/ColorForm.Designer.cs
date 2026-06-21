namespace CrossFormColorDelegation
{
    partial class ColorForm
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
            this.btnRed = new System.Windows.Forms.Button();
            this.btnLime = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRed
            // 
            this.btnRed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnRed.ForeColor = System.Drawing.Color.Red;
            this.btnRed.Location = new System.Drawing.Point(50, 151);
            this.btnRed.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(74, 30);
            this.btnRed.TabIndex = 0;
            this.btnRed.Text = "Red";
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnLime
            // 
            this.btnLime.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLime.ForeColor = System.Drawing.Color.Lime;
            this.btnLime.Location = new System.Drawing.Point(50, 189);
            this.btnLime.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnLime.Name = "btnLime";
            this.btnLime.Size = new System.Drawing.Size(74, 32);
            this.btnLime.TabIndex = 1;
            this.btnLime.Text = "Lime";
            this.btnLime.UseVisualStyleBackColor = true;
            // 
            // btnBlue
            // 
            this.btnBlue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnBlue.ForeColor = System.Drawing.Color.Blue;
            this.btnBlue.Location = new System.Drawing.Point(50, 229);
            this.btnBlue.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(74, 31);
            this.btnBlue.TabIndex = 2;
            this.btnBlue.Text = "Blue";
            this.btnBlue.UseVisualStyleBackColor = true;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 88);
            this.label1.TabIndex = 3;
            this.label1.Text = "Press to change color...\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 269);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnLime);
            this.Controls.Add(this.btnRed);
            this.Font = new System.Drawing.Font("Blackadder ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ColorForm";
            this.Text = "ColorForm";
            this.Load += new System.EventHandler(this.ColorForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnLime;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Label label1;
    }
}