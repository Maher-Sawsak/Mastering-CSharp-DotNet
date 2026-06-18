namespace User_ControlsAndExposeProperty
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
            this.button1 = new System.Windows.Forms.Button();
            this.ctlrSimpleCalculater2 = new User_ControlsAndExposeProperty.ctlrSimpleCalculater();
            this.ctlrSimpleCalculater1 = new User_ControlsAndExposeProperty.ctlrSimpleCalculater();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(572, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Show Result";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ctlrSimpleCalculater2
            // 
            this.ctlrSimpleCalculater2.Location = new System.Drawing.Point(38, 238);
            this.ctlrSimpleCalculater2.Name = "ctlrSimpleCalculater2";
            this.ctlrSimpleCalculater2.Size = new System.Drawing.Size(292, 200);
            this.ctlrSimpleCalculater2.TabIndex = 1;
            // 
            // ctlrSimpleCalculater1
            // 
            this.ctlrSimpleCalculater1.Location = new System.Drawing.Point(38, 21);
            this.ctlrSimpleCalculater1.Name = "ctlrSimpleCalculater1";
            this.ctlrSimpleCalculater1.Size = new System.Drawing.Size(261, 195);
            this.ctlrSimpleCalculater1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ctlrSimpleCalculater2);
            this.Controls.Add(this.ctlrSimpleCalculater1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctlrSimpleCalculater ctlrSimpleCalculater1;
        private ctlrSimpleCalculater ctlrSimpleCalculater2;
        private System.Windows.Forms.Button button1;
    }
}