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
    public partial class SecondForm : Form
    {

        //here is declare delegate.
        public delegate void DataBackEventDelegate(object sender,int PersonID);

        //here is the decleration for the Event.
        public event DataBackEventDelegate DataBackEvent;


        public SecondForm()
        {
            InitializeComponent();
        }

        private void SecondForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSendDataBack_Click(object sender, EventArgs e)
        {

            if (int.TryParse(txtPersonID.Text, out int PersonID))
            {
                // Launch the event and send data
                DataBackEvent?.Invoke(this, PersonID);
                this.Close();
            }
            else
            {
              
                MessageBox.Show("Enter Numbers Only.", "Entering Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPersonID.Focus(); 
            }

        }



    }
}
