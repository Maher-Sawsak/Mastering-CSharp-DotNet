namespace MonthCalandar
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnRang = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.monthCalendar1.Location = new System.Drawing.Point(153, 45);
            this.monthCalendar1.MaxSelectionCount = 40;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // btnRang
            // 
            this.btnRang.Location = new System.Drawing.Point(157, 317);
            this.btnRang.Name = "btnRang";
            this.btnRang.Size = new System.Drawing.Size(143, 58);
            this.btnRang.TabIndex = 1;
            this.btnRang.Text = "Selected Rang";
            this.btnRang.UseVisualStyleBackColor = true;
            this.btnRang.Click += new System.EventHandler(this.btnRang_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(348, 317);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(143, 58);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start Date";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(497, 317);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(143, 58);
            this.btnEnd.TabIndex = 3;
            this.btnEnd.Text = "End Date";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnRang);
            this.Controls.Add(this.monthCalendar1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnRang;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnEnd;
    }
}

