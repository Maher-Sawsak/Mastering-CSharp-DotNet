namespace NotifyIcon
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
            this.components = new System.ComponentModel.Container();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnShowNotification = new System.Windows.Forms.Button();
            this.chkClicked = new System.Windows.Forms.CheckBox();
            this.chkUnClicked = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.notifyIcon1_BalloonTipClicked);
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // btnShowNotification
            // 
            this.btnShowNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowNotification.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowNotification.Location = new System.Drawing.Point(276, 173);
            this.btnShowNotification.Name = "btnShowNotification";
            this.btnShowNotification.Size = new System.Drawing.Size(220, 68);
            this.btnShowNotification.TabIndex = 0;
            this.btnShowNotification.Text = "Show Notify Icon";
            this.btnShowNotification.UseVisualStyleBackColor = true;
            this.btnShowNotification.Click += new System.EventHandler(this.btnShowNotification_Click);
            // 
            // chkClicked
            // 
            this.chkClicked.AutoSize = true;
            this.chkClicked.Location = new System.Drawing.Point(548, 265);
            this.chkClicked.Name = "chkClicked";
            this.chkClicked.Size = new System.Drawing.Size(83, 21);
            this.chkClicked.TabIndex = 1;
            this.chkClicked.Text = "Checked";
            this.chkClicked.UseVisualStyleBackColor = true;
            // 
            // chkUnClicked
            // 
            this.chkUnClicked.AutoSize = true;
            this.chkUnClicked.Checked = true;
            this.chkUnClicked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUnClicked.Location = new System.Drawing.Point(548, 302);
            this.chkUnClicked.Name = "chkUnClicked";
            this.chkUnClicked.Size = new System.Drawing.Size(100, 21);
            this.chkUnClicked.TabIndex = 2;
            this.chkUnClicked.Text = "UnChecked";
            this.chkUnClicked.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showApplicationToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 104);
            // 
            // showApplicationToolStripMenuItem
            // 
            this.showApplicationToolStripMenuItem.Name = "showApplicationToolStripMenuItem";
            this.showApplicationToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.showApplicationToolStripMenuItem.Text = "Show Application";
            this.showApplicationToolStripMenuItem.Click += new System.EventHandler(this.showApplicationToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkUnClicked);
            this.Controls.Add(this.chkClicked);
            this.Controls.Add(this.btnShowNotification);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnShowNotification;
        private System.Windows.Forms.CheckBox chkClicked;
        private System.Windows.Forms.CheckBox chkUnClicked;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

