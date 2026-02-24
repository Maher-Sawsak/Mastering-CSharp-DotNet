using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void findClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //to add new strip at run time.
            ToolStripMenuItem recentClient = new ToolStripMenuItem("Client: Maher Sawsak");
            recentClient.Click += (s, ev) => MessageBox.Show("Opening Maher's Profile...");
            clientToolStripMenuItem.DropDownItems.Add(recentClient);
            //--0------
            MessageBox.Show("Find client will be here","Clients",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void secondFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSecond frm2 = new frmSecond();
            frm2.ShowDialog();

        }
    }
}
