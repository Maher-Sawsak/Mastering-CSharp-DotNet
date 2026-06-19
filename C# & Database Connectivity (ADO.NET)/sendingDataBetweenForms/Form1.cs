using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sendingDataBetweenForms
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
     
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSendData_Click(object sender, EventArgs e)
        {


            if (int.TryParse(txtPersonID.Text, out int PersonID))
            {
                Form frm = new SecondForm(PersonID);
                frm.ShowDialog();
            }
            else if (txtPersonID.Text.All(char.IsLetter)) {

                Form frm = new SecondForm(txtPersonID.Text);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("PersonID must be number (OR) Name", "Error");
                txtPersonID.Focus();
            }

        }
    }
}
