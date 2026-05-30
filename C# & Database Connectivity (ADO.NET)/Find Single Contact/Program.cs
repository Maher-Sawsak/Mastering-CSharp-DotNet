using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Find_Single_Contact
{
    internal class Program
    {
        //remeber the struct is by value by default.
        public struct stContact
        {

            public int ContactID { set; get; }
            public string FirstName { set; get; }
            public string LastName { set; get; }
            public string Email { set; get; }

            public string Phone { set; get; }
            public string Address { set; get; }

            public int CountryID { set; get; }

        }

        static string ConnectionString = "Server =.;Database= ContactsDB;User Id = sa;Password =MaherSawsak123";
        static bool FindContactByID(int ContactID, ref stContact ContactInfo)
        {

            bool IsFound = false;
            SqlConnection connection = new SqlConnection(ConnectionString);

            string query = "Select * from Contacts where ContactID = @ContactID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ContactID", ContactID);
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    ContactInfo.ContactID = (int)reader["ContactID"];
                    ContactInfo.FirstName = (string)reader["FirstName"];
                    ContactInfo.LastName = (string)reader["LastName"];
                    ContactInfo.Email = (string)reader["Email"];
                    ContactInfo.Phone = (string)reader["Phone"];
                    ContactInfo.Address = (string)reader["Address"];
                    ContactInfo.CountryID = (int)reader["CountryID"];
                }
                else
                {
                    IsFound = false;

                }

                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error {ex.Message}");
            }


            return IsFound;

        }








        static void Main(string[] args)
        {
            //this new word here will called the constructor and the constractor will give the default 
            //value for the struct memeber so cmpiler will be fine for this like string = null ,decimal int will be 0 like this.
            stContact contact = new stContact();


            //the function will return true if connection to database done if not will return false
            //and its will by reference fill the struct that in the parameter
            if (FindContactByID(1, ref contact))
            {


                Console.WriteLine($"Contact ID : {contact.ContactID}");
                Console.WriteLine($"First Name : {contact.FirstName}");
                Console.WriteLine($"Last Name : {contact.LastName}");
                Console.WriteLine($"Email : {contact.Email}");
                Console.WriteLine($"Phone : {contact.Phone}");
                Console.WriteLine($"Address : {contact.Address}");
                Console.WriteLine($"Country ID : {contact.CountryID}");
            }
            else {
                Console.WriteLine("Error Not Found");
            
            }


    }
}
}