using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErrorProvider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, CancelEventArgs e)
        {
        


        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                //even the x to close the form or the app will not work
               e.Cancel = true;
               //here in the focus() u can close the form itself.
               textBox1.Focus();
                errorProvider1.SetError(textBox1, "You must enter a name.");
                
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox1, "");
            }


        }
    }
}
