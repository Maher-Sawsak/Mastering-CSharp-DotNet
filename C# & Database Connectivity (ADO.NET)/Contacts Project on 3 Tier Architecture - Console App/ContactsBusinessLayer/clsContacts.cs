using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using ContactsDataAccessLayer;
namespace ContactsBusinessLayer
{

    public class clsContacts
    {


        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string ImagePath { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int CountryID { get; set; }



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


    }


}
