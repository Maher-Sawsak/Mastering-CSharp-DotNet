using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControls
{
    public partial class CashierHeaderUC : UserControl
    {
        public CashierHeaderUC()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
