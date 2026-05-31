using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        static void Main(string[] args)
        {
            TestFindContact(1);

        }
    }
}
