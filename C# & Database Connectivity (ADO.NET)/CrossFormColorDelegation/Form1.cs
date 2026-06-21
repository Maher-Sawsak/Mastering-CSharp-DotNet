using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CrossFormColorDelegation.ColorForm;

namespace CrossFormColorDelegation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblColor_Click(object sender, EventArgs e)
        {

        }

        private void btnOpenColorForm_Click(object sender, EventArgs e)
        {
            ColorForm frmColor = new ColorForm();
            frmColor.ColorEvent += ChangeLabelColor;
            frmColor.ShowDialog();
        }

        private void ChangeLabelColor(object sender,string ColorName) 
        {
            lblColor.ForeColor = Color.FromName(ColorName);
        }


    }
}
