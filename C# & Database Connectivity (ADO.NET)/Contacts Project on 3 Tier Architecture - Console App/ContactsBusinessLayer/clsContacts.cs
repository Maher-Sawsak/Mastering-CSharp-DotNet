using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using ContactsDataAccessLayer;
namespace ContactsBusinessLayer
{

    public class clsContacts
    {
        enum enMode { Add = 0,Update = 1 };
        enMode Mode;
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string ImagePath { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int CountryID { get; set; }

        public clsContacts()
        {
            //this constructor if the object is created on the presentation Layer
            //I will set these value as default andd give Add mode cuz the data is new.
            this.ID = -1;
            this.FirstName = "";
            this.LastName = "";
            this.Email = "";
            this.Phone = "";
            this.Address = "";
            this.ImagePath = "";
            this.CountryID = -1;
            this.DateOfBirth = DateTime.Now;
            Mode = enMode.Add;//if the user create a new and empty object and late set values I will consider these values as deafult with mode add
                              //and I will will use the mode in save function will benefit me later to know i will Update or Add to database.
        }



        private clsContacts(int ID, string FirstName, string LastName, string Email, string Phone, string Address, DateTime DateOfBirth,
             int CountryID, string ImagePath)
        {
            this.ID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
            this.Address = Address;
            this.DateOfBirth = DateOfBirth;
            this.CountryID = CountryID;
            this.ImagePath = ImagePath;

            Mode = enMode.Update;//if its return with data i mean if object hold data by find Function so its on the database so mode is update.
        }


        private bool _AddNewContact() {

            this.ID = clsContactDataAccess.AddNewContact(this.FirstName, this.LastName, this.Email,
                                                         this.Phone, this.Address, this.DateOfBirth, this.CountryID, this.ImagePath);
            return (this.ID != -1);//if in data Access layer doesn't add any record will return -1 and my default value in constructor for ID is -1.     
              
  }

        private bool _UpdateContact() 
        {
            return (clsContactDataAccess.UpdateContact(this.ID, this.FirstName, this.LastName, this.Email, this.Phone, this.Address, this.DateOfBirth,
                this.CountryID, this.ImagePath));      
        
        }
                   
       
     public bool Save() {

            switch (Mode) 
            {

            case enMode.Add:

                    if (_AddNewContact())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateContact();

           }
            
            return false;
}

        public static clsContacts Find(int ContactID)
        {
            string FirstName = "", LastName = "", Email = "", Phone = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            int CountryID = -1;

            //here this method will return true or false based on the situation for founding
            if (clsContactDataAccess.GetContactInfoByID(ContactID, ref FirstName, ref LastName, ref Email,
                                                       ref Phone, ref Address, ref DateOfBirth, ref CountryID, ref ImagePath))
            {
                return new clsContacts(ContactID, FirstName, LastName, Email,
                                                        Phone, Address, DateOfBirth, CountryID, ImagePath);
            }
            else
            {
                return null;
            }


        }



        public static bool DeleteContacts(int ContactID) 
        {
            return (clsContactDataAccess.DeleteContact(ContactID));
        }





        public static DataTable GetAllContacts() {

            return (clsContactDataAccess.GetAllContacts());
        
        }




        public static bool isContactExist(int ContactID) 
        {
        return clsContactDataAccess.IsContactExist(ContactID);
                
        }









    }


}
