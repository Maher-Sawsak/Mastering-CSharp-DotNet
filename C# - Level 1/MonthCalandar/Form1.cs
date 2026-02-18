using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonthCalandar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            MessageBox.Show(monthCalendar1.SelectionStart.ToString("dd/MM/yy"));
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            MessageBox.Show(monthCalendar1.SelectionEnd.ToString("dd/MM/yy"));
        }

        private void btnRang_Click(object sender, EventArgs e)
        {
            MessageBox.Show(monthCalendar1.SelectionRange.ToString());
        }
    }
}
