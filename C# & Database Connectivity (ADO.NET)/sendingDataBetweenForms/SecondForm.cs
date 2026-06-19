using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sendingDataBetweenForms
{
    public partial class SecondForm : Form
    {
        int _PersonID = -1;
        string _FirstName= "";
        public SecondForm(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }
        public SecondForm(string FirstName)
        {
            InitializeComponent();
            _FirstName = FirstName;
        }
        private void SecondForm_Load(object sender, EventArgs e)
        {
            if (_PersonID != -1)
            {
                lblDataRecived.Text = _PersonID.ToString();
            }

            if (!string.IsNullOrEmpty(_FirstName)){
                lblDataRecived.Text = _FirstName;
            }
        }
    }
}