using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text += dateTimePicker1.Text + Environment.NewLine;
        label1.Text+=  dateTimePicker1.Value.ToString("dd-MM-yy") + Environment.NewLine;
            label1.Text+=  dateTimePicker1.Value.ToString("dd/MMM/yyyyyy") + Environment.NewLine;
            label1.Text+=  dateTimePicker1.Value.ToString("dd/MM/yyyy") + Environment.NewLine;
            label1.Text+=  dateTimePicker1.Value.ToString("ddd/MM/yyy") + Environment.NewLine;
            label1.Text+=  dateTimePicker1.Value.ToString("ddd/MMMMM/yy") + Environment.NewLine;
        }
    }
}
