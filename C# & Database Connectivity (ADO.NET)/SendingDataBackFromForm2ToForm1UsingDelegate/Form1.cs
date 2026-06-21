using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendingDataBackFromForm2ToForm1UsingDelegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenForm2_Click(object sender, EventArgs e)
        {
            SecondForm frm2 = new SecondForm();
            frm2.DataBackEvent += Form2_DataBack;
            frm2.ShowDialog();
        }

        private void Form2_DataBack(object Sender,int PersonID) {

            txtPersonIDInForm1.Text = PersonID.ToString();
        }



    }
}
