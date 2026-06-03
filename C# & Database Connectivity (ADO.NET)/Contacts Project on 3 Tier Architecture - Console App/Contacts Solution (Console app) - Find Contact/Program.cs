using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ContactsBusinessLayer;
namespace Contacts_Solution__Console_app____Find_Contact
{
    internal class Program
    {
        static void TestFindContact(int ContactID) {
            clsContacts ContactData = clsContacts.Find(ContactID);

            if (ContactData != null)
            {

                Console.WriteLine(ContactData.ID);
                Console.WriteLine(ContactData.FirstName);
                Console.WriteLine(ContactData.LastName);
                Console.WriteLine(ContactData.Email);
                Console.WriteLine(ContactData.Phone);
                Console.WriteLine(ContactData.Address);
                Console.WriteLine(ContactData.DateOfBirth);
                Console.WriteLine(ContactData.CountryID);
                Console.WriteLine(ContactData.ImagePath);
            }
            else
            {

                Console.WriteLine($"The {ContactID} Not Found");
            }
        }

        static void TestAddContact() {
            clsContacts NewContact = new clsContacts();
            NewContact.FirstName = "Maher";
            NewContact.LastName = "Sawsak";
            NewContact.Phone = "05342697871";
            NewContact.Email = "mahersawsak2@gmail.com";
            NewContact.Address = "Ankara,Turkey";
            NewContact.DateOfBirth = new DateTime(2005, 01, 25);
            NewContact.CountryID = 1;

            if (NewContact.Save()) {
                Console.WriteLine($"The Contact Id {NewContact.ID} Added Successfully To Database");
            }
        
        }

        static void TestUpdateContact(int ID) {

            clsContacts ExistingContact = clsContacts.Find(ID);

            ExistingContact.FirstName = "Lina";
            ExistingContact.LastName = "Sawsak";
            ExistingContact.Phone = "1231233123";
            ExistingContact.Email = "Lina@gmail.com";
            ExistingContact.Address = "Istanbul";
            ExistingContact.CountryID = 2;
            ExistingContact.DateOfBirth = new DateTime(1999,10,23);

            if (ExistingContact.Save())
            {
                Console.WriteLine($"Contact ID Number {ExistingContact.ID} Updated Successfully");
            }
            else {
                Console.WriteLine("Error, The Update Failed");
            }
        }

        static void TestDeleteContact(int ContactID) 
        {


            if (clsContacts.isContactExist(ContactID))
            {
                Console.WriteLine($"Contact With ID Number {ContactID} Is Found");

                if (clsContacts.DeleteContacts(ContactID))
                {
                    Console.WriteLine($"Conatct With ID {ContactID} Deletes Successfully");
                }
                else
                {
                    Console.WriteLine("Failed To Delete");
                }
            }
            else {

                Console.WriteLine($"Contact With ID Number {ContactID} Is Not Found To Delete");

            }

        }


        static void ListAllContacts() {

            DataTable dataTable = clsContacts.GetAllContacts();//this method will return full data as DataTable instead of reader.


            foreach (DataRow Row in dataTable.Rows) {

                Console.WriteLine($"ID = {Row["ContactID"]} , First Name: {Row["FirstName"]}  LastName: {Row["LastName"]}");
            }



        }

        static void TestContactExist(int ID) 
        {

            if (clsContacts.isContactExist(ID))
            {
                Console.WriteLine($"Contact With ID Number {ID} Is Found");
            }
            else { 
            Console.WriteLine($"Contact With ID Number {ID} Is  Not Found");
            }
        
        }

        static void TestFindCountry(int ID) {



            clsCountry CountryObject = clsCountry.FindCountryByID(ID);

            if (CountryObject != null)
            {
                Console.WriteLine($"Country ID : {CountryObject.CountryID} ");
                Console.WriteLine($"Country Name : {CountryObject.CountryName}");
                Console.WriteLine($"Country Code : {CountryObject.Code}");
                Console.WriteLine($"Country PhoneCode : {CountryObject.PhoneCode}");
            }
            else
            {

                Console.WriteLine($"The {ID} Not Found");
            }

        }

        static void TestAddNewCountry(string CountryName,string Code = "",string PhoneCode = "") {

            clsCountry NewCountry = new clsCountry(CountryName,Code,PhoneCode);

            if (NewCountry.Save())
            {
                Console.WriteLine($"The Country With ID :{NewCountry.CountryID} Added Successfully");
            }
            else {
                Console.WriteLine($"The Country With Name :{CountryName} Adding Failed ");


            }


        }



        static void TestUpdateCountry(int CountryID,string NewCountryName,string Code =  "",string PhoneCode = "")
        {
        
        clsCountry OldRecord = clsCountry.FindCountryByID(CountryID);

            if (OldRecord != null)
            {
                OldRecord.CountryName = NewCountryName;
                if (!string.IsNullOrEmpty(Code))
                {
                    OldRecord.Code = Code;
                }

                if (!string.IsNullOrEmpty(PhoneCode))
                {
                    OldRecord.PhoneCode = PhoneCode;
                }
            }
            else {
                Console.WriteLine($"Could Not Found Country With This ID : {CountryID}");
                return;
            }
            

            if (OldRecord.Save())
            {
                Console.WriteLine($"Country With This ID : {CountryID} , Updated Successfully");


            }
            else {
                Console.WriteLine($"Error: Failed to update Country With ID : {CountryID}");
            }

        }


        static void TestDeleteCountryRecord(int CountryID) {

            if (clsCountry.DeleteCountry(CountryID))
            {
                Console.WriteLine($"Country With ID:  {CountryID} Deleted Successfully.");
            }
            else {
                Console.WriteLine($"Country With ID:  {CountryID} Failed To Delete.");

            }

        }



        static void PrintAllCountries() {

            DataTable DT = new DataTable();

            DT = clsCountry.GetAllCountries();

            if (DT != null)
            {
                foreach (DataRow Row in DT.Rows)
                {
                
                    Console.WriteLine($@"Country ID = {Row["CountryID"]}        Country Name  : {Row["CountryName"]}                Country Code = {Row["Code"]}                Country PhoneCode  : {Row["PhoneCode"]}");

                }
            }
            else {
                Console.WriteLine("There Is No Data For Countries");
            }
        
        
        }



        static void TestIsCountryExist(int CountryID) 
        {
            if (clsCountry.IsCountryExist(CountryID)) {

                Console.WriteLine($"Country With ID {CountryID} Is Found Successfully");
            }
            else{
                Console.WriteLine($"Country With ID {CountryID} Failed To Found");
            }
        
        }




        static void TestFindCountryByName(string CountryName) {

            clsCountry CountryObject = clsCountry.FindCountryByName(CountryName);

            if (CountryObject != null)
            {
                Console.WriteLine($"Country ID:  {CountryObject.CountryID} \nCountry Name : {CountryObject.CountryName}");
                Console.WriteLine($"Country Code:  {CountryObject.Code} \nCountry PhoneCode : {CountryObject.PhoneCode}");
            }
            else {

                Console.WriteLine($"Country With Name {CountryName} Not Found");
            }
            
               
        
        }



        static void TestIsCountryExist(string CountryName)
        {
            if (clsCountry.IsCountryExist(CountryName))
            {

                Console.WriteLine($"Country With Name {CountryName} Is Found Successfully");
            }
            else
            {
                Console.WriteLine($"Country With Name {CountryName} Failed To Found");
            }

        }


        static void Main(string[] args)
        {
            //TestFindContact(1);

            //TestAddContact();

            //TestUpdateContact(6);

            //TestDeleteContact(15);


            // ListAllContacts();

            // TestContactExist(100);//There is no record in my database with number 100.
            // TestContactExist(1);// there is a record with ID number 1 its exist.

            //TestFindCountry(1);


            ////Done Successfully This Method with ID 6.
           // TestAddNewCountry("Turkey","+90","554");


           // TestUpdateCountry(8, "Saudi Arabia","+966","554");



            //TestDeleteCountryRecord(6);



            // PrintAllCountries();




            //TestIsCountryExist(2);






            //TestFindCountryByName("Germany");



            //TestIsCountryExist("Germany");



        }
    }
}
