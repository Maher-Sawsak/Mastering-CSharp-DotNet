using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertOrAddToDatabase
{
    internal class Program
    {
        static string ConnectionString = "Server =.;Database =ContactsDB;User Id = sa;Password = MaherSawsak123" ;

        public struct stContactInfo {
            public int ContactID { set; get; }
            public string FirstName { set; get; }
            public string LastName { set; get; }
            public string Email { set; get; }
            public string PhoneNumber { set; get; }
            public string Address { set; get; }
            public int CountryID { set; get; }

        
        }

        static void AddOneRecordContactInfoToDatabase(stContactInfo ContactInfo) {

            SqlConnection connection = new SqlConnection(ConnectionString);
            string query = @"INSERT INTO Contacts (FirstName, LastName, Email, Phone, Address, CountryID)
                            Values(@FirstName, @LastName, @Email, @Phone, @Address, @CountryID)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", ContactInfo.FirstName);
            command.Parameters.AddWithValue("@LastName", ContactInfo.LastName);
            command.Parameters.AddWithValue("@Email", ContactInfo.Email);
            command.Parameters.AddWithValue("@Phone", ContactInfo.PhoneNumber);
            command.Parameters.AddWithValue("@Address", ContactInfo.Address);
            command.Parameters.AddWithValue("@CountryID", ContactInfo.CountryID);

            try {
                connection.Open();
                int NumberOfRowsAffected = command.ExecuteNonQuery();

                if (NumberOfRowsAffected > 0)
                {
                    Console.WriteLine("Data Inserted Successfully");
                }
                else {

                    Console.WriteLine(" Insert Data Failed");
                }


            }
            catch (Exception ex) {
                Console.WriteLine($"Error{ex.Message}");
            }




        }



        static void Main(string[] args)
        {
            stContactInfo ContactRecored = new stContactInfo();
            ContactRecored.FirstName = "Maher";
            ContactRecored.LastName = "Sawsak";
            ContactRecored.Email = "Sawsak@gmail.com";
            ContactRecored.PhoneNumber = "123135";
            ContactRecored.Address = "Ankara";
            ContactRecored.CountryID = 1;

            AddOneRecordContactInfoToDatabase(ContactRecored);
        }
    }
}
