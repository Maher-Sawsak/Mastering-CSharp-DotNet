using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinglePageInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SalesScreenUC ctrlSales = new SalesScreenUC();
            panel1.Controls.Clear();
            panel1.Controls.Add(ctrlSales);


        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsScreenUC ctrlSettings = new SettingsScreenUC();
            panel1.Controls.Clear();
            panel1.Controls.Add(ctrlSettings);
        }
    }
}
