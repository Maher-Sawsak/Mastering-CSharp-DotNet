using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectToSQLServerDatabaseAndUpdateData
{


    internal class Program
    {


    static string ConnectionString = "Server =.;Database = ContactsDB;User Id = sa;Password =MaherSawsak123";
    public struct stContact {

        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Email { set; get; }
        public string Phone { set; get; }
        public string Address { set; get; }
        public string CountryID { set; get; }

    }
        static void UpdateContact(int OldContactID ,stContact NewContact) {

            SqlConnection connection = new SqlConnection(ConnectionString);
            string query = @"UPDATE Contacts SET FirstName = @FirstName ,
                          LastName = @LastName,Email = @Email, Phone = @Phone ,
                          Address = @Address ,CountryID = @CountryID
                          WHERE ContactID = @OldContactID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", NewContact.FirstName);
            command.Parameters.AddWithValue("@LastName", NewContact.LastName);
            command.Parameters.AddWithValue("@Email", NewContact.Email);
            command.Parameters.AddWithValue("@Phone", NewContact.Phone);
            command.Parameters.AddWithValue("@Address", NewContact.Address);
            command.Parameters.AddWithValue("@CountryID", NewContact.CountryID);
            command.Parameters.AddWithValue("@OldContactID", OldContactID);


            try {

                connection.Open();

                //here it will be one cuz i add where condition so i know its one 1 will be returned;
                /*and i used NonQuery because when add/update/delete use it
                u are not reading data or retrieving data to use scalar or reader.*/
                int NumberOfAffectedRows = command.ExecuteNonQuery();

                if (NumberOfAffectedRows > 0)
                {

                    Console.WriteLine("Record Updated Successfully");
                }
                else {

                    Console.WriteLine("Record Update Failed");
                }


            }
            catch (Exception ex) {
                Console.WriteLine($"Error {ex.Message}");

            }
            finally {
                connection.Close();
            }


        }


        static void Main(string[] args)
        {
            stContact ContactInfo = new stContact
            {

                FirstName = "Ali",
                LastName = "Sawsak",
                Email = "alisawsak5@gmail.com",
                Phone = "055345221",
                Address = "Turkey,Ankara Delmetlalle Mahllise",
                CountryID = "1",
            };
            UpdateContact(1, ContactInfo);

        }
    }
}
