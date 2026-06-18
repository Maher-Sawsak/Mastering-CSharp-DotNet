using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_ControlsAndExposeProperty
{
    public partial class ctlrSimpleCalculater : UserControl
    {
        public ctlrSimpleCalculater()
        {
            InitializeComponent();
        }

        public float Result
        {
            get { return (float)Convert.ToDouble(lblResult.Text); }
        }



        private void button1_Click(object sender, EventArgs e)
        {
           lblResult.Text = (int.Parse(textBox1.Text) + int.Parse(textBox2.Text)).ToString();

        }

        private void ctlrSimpleCalculater_Load(object sender, EventArgs e)
        {

        }
    }
}
