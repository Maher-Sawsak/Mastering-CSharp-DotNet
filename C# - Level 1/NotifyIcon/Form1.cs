using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotifyIcon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowNotification_Click(object sender, EventArgs e)
        {
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;

            notifyIcon1.BalloonTipText = "Hello, this is me";
            notifyIcon1.BalloonTipTitle = "Notification me";
            //here for time to show the notification max = 30 second and min = 10;
            notifyIcon1.ShowBalloonTip(1000);
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            chkClicked.Checked = true;
            chkUnClicked.Checked = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //to show the form if its hidin we use this syntax. why this cuz we are standing on the form itself and its an object .
            this.Show();
            this.WindowState = FormWindowState.Normal;
        
    }

    }
}
