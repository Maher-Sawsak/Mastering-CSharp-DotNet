using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrossFormColorDelegation
{
    public partial class ColorForm : Form
    {
        public delegate void ChangeColorDelegate(object sender, string ColorName);

        public event ChangeColorDelegate ColorEvent;


        public ColorForm()
        {
            InitializeComponent();
        }

        private void ColorForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            string ColorName = btnRed.ForeColor.Name;

            ColorEvent?.Invoke(this, ColorName);
            this.Close();
        
        }

        private void btnPink_Click(object sender, EventArgs e)
        {
            string ColorName = btnLime.ForeColor.Name;

            ColorEvent?.Invoke(this, ColorName);
            this.Close();
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            string ColorName = btnBlue.ForeColor.Name;

            ColorEvent?.Invoke(this, ColorName);
            this.Close();
        }
    }
}
