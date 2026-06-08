using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Contacts___WinForms.Properties;
using ContactsBusinessLayer;

namespace Contacts___WinForms
{
    public partial class frmAddEditContact : Form
    {
        enum enMode {AddNew =  0, Update = -1};
        private enMode _Mode;

        int _ContactID;
        private clsContacts _Contact;

        
        //this is the constructor
        public frmAddEditContact(int ContactID)
        {
            InitializeComponent();

            _ContactID = ContactID;
            if (_ContactID == -1)
            {
                _Mode = enMode.AddNew;
            }
            else { 
            _Mode = enMode.Update;
            }
        }

        private void _FillCountriesInComboBox() 
        {
        DataTable dtCountries  = clsCountry.GetAllCountries();

            foreach (DataRow Row in dtCountries.Rows)
            {
                cbCountries.Items.Add(Row["CountryName"]);
            }

    }



        private void _LoadData() 
        {
            _FillCountriesInComboBox();
            cbCountries.SelectedIndex = 0;

            if (_Mode == enMode.AddNew) {
                lblMode.Text = "Add New Contact";
                _Contact = new clsContacts();
                return;
            }

            _Contact = clsContacts.Find(_ContactID);

            if (_Contact == null) {
                MessageBox.Show("This contact could not be found Form Will Be Closed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                //why i wrote here return cuz the form.close it will close the form but the compiler
                //will continue and compile the following lines by return will close form and stop compilation.
                return;
            }
            lblMode.Text = $"Edit Contact ID : {_ContactID}";
            lblContactID.Text =  _ContactID.ToString(); 
            txtFirstName.Text = _Contact.FirstName;
            txtLastName.Text = _Contact.LastName;
            txtEmail.Text = _Contact.Email;
            txtPhone.Text = _Contact.Phone; 
            txtAddress.Text = _Contact.Address;
            dtpDateOfBirth.Value = _Contact.DateOfBirth;

            if (_Contact.ImagePath != "") 
            {
                pictureBox1.Load(_Contact.ImagePath);
            }

        //means hide this linklable if there is no image path in the object.
            llblRemoveImage.Visible = (_Contact.ImagePath != "");

            //Find the contact's country name in the DB, get its index, and select it in the ComboBox when load the form.
            cbCountries.SelectedIndex = cbCountries.FindString(clsCountry.FindCountryByID(_Contact.CountryID).CountryName);
        }


        private void frmAddEditContact_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int CountryID = clsCountry.FindCountryByName(cbCountries.Text).CountryID;

            _Contact.FirstName = txtFirstName.Text;
            _Contact.LastName = txtLastName.Text;
            _Contact.Email = txtEmail.Text;
            _Contact.Phone = txtPhone.Text;
            _Contact.Address = txtAddress.Text;
            _Contact.DateOfBirth = dtpDateOfBirth.Value;
            _Contact.CountryID = CountryID;

            if (pictureBox1.ImageLocation != null)
            {
                _Contact.ImagePath = pictureBox1.ImageLocation;
            }
            else {
                _Contact.ImagePath = "";
            }


            if (_Contact.Save())
            {
                MessageBox.Show("Contact Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("Failed To Save Contact", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //here the method save will return bool but also will change the previous id -1 to the new ID 
            //so the object will came with the newest ID by ScopeIdentity in DataAccessLayer Remember this trace it. 
            _ContactID = _Contact.ID;
            _Mode = enMode.Update;
            lblMode.Text = $"Edit Contact ID : {_ContactID}";
            lblContactID.Text = _ContactID.ToString();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblMode_Click(object sender, EventArgs e)
        {

        }

        private void llblSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                llblRemoveImage.Visible = true;
                pictureBox1.Load(openFileDialog1.FileName);
            }


        }

        private void llblRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.ImageLocation = null;
            pictureBox1.Image = Resources.default_avatar_1;
            llblRemoveImage.Visible = false;
            _Contact.ImagePath = "";
        }
    }
}
