using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsBusinessLayer;

namespace Contacts___WinForms
{
    public partial class frmListContacts : Form
    {
        public frmListContacts()
        {
            InitializeComponent();
        }

        private void _RefreshContactList() {

            dgvAllContacts.DataSource = clsContacts.GetAllContacts();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
          _RefreshContactList();


        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //here to check the current cell that clicked on.
            if (dgvAllContacts.CurrentRow != null)
            {

                int ContactID = (int)dgvAllContacts.CurrentRow.Cells["ContactID"].Value;


                //create an object from the second form and pass object with id to it.
                frmAddEditContact frm = new frmAddEditContact(ContactID);

                
                frm.ShowDialog();

                _RefreshContactList();
            }
            else
            {
                MessageBox.Show("Please Select A Cell With Data ","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        
  
        
        
        
        
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddEditContact frmAddContact = new frmAddEditContact(-1);
            frmAddContact.ShowDialog();

            _RefreshContactList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are You Sure You Want To Delete This Contact ID :{dgvAllContacts.CurrentRow.Cells[0].Value}" , "Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1) == DialogResult.Yes) 
            {
                if (clsContacts.DeleteContacts((int)dgvAllContacts.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshContactList();
                }
                else 
                {
                    MessageBox.Show("Failed To Delete", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }


        }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    }
}
