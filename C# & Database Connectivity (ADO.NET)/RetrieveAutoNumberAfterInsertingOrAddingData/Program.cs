using System;
using System.Collections.Generic;
//provider for Sql
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetrieveAutoNumberAfterInsertingOrAddingData
{
    internal class Program
    {
        static string ConnectionString = "Server =.;Database =ContactsDB;User Id = sa;Password = MaherSawsak123";

        public struct stContactInfo
        {
            public string FirstName { set; get; }
            public string LastName { set; get; }
            public string Email { set; get; }
            public string PhoneNumber { set; get; }
            public string Address { set; get; }
            public int CountryID { set; get; }


        }


        static void AddContactInfoAndGetID(stContactInfo ContactInfo) {

            SqlConnection connection = new SqlConnection(ConnectionString);
            //THIS query contain two part look carefully here......
            string query = @"INSERT INTO Contacts (FirstName, LastName, Email, Phone, Address, CountryID)
                            Values(@FirstName, @LastName, @Email, @Phone, @Address, @CountryID);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", ContactInfo.FirstName);
            command.Parameters.AddWithValue("@LastName", ContactInfo.LastName);
            command.Parameters.AddWithValue("@Email", ContactInfo.Email);
            command.Parameters.AddWithValue("@Phone", ContactInfo.PhoneNumber);
            command.Parameters.AddWithValue("@Address", ContactInfo.Address);
            command.Parameters.AddWithValue("@CountryID", ContactInfo.CountryID);

            try
            {

                connection.Open();
                object Result = command.ExecuteScalar();
                //the ExecuteScalar will return data by object so i converted to string then to int,because i know 
                //query will give me an ID the last ID so if its converted the TryParse will return true if Not false
                if (Result != null && int.TryParse(Result.ToString(), out int insertID))
                {
                    Console.WriteLine($"Newest ID For Insert Is : {insertID}");

                }
                else
                {
                    Console.WriteLine("The ID Is NULL No thing returned ");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error {ex.Message}");
            }
            finally {
                connection.Close();
            }

        }
        static void Main(string[] args)
        {
            stContactInfo ContactRecored = new stContactInfo
            {
                FirstName = "Habib",
                LastName = "Sawsak",
                Email = "HabibSawsak@gmail.com",
                PhoneNumber = "0556565398",
                Address = "Damascus",
                CountryID = 1,
            };
            AddContactInfoAndGetID(ContactRecored);

            //I Got this resutl below ->
            //Newest ID For Insert Is : 9
        }
    }
}
