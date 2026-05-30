using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delete_Data
{
    internal class Program
    {
        public struct stContacts { 
      
        public string FirstName { set; get; }
       
        public string LastName { set; get; }

        public string Email { set; get; }
        public string PhoneNumber { set; get; }

        public string Address { set; get; }

        public string CountryID { set; get; }
        }


        static string ConnectionString = "Server =.;Database =ContactsDB;User Id =sa;Password=MaherSawsak123";


        static void DeleteOneRecordFromDatabase(int ContactID) 
        {


            SqlConnection connection = new SqlConnection(ConnectionString);

            string query = @"DELETE FROM Contacts
                                  WHERE ContactID = @ContactID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ContactID", ContactID);

            try
            {
                connection.Open();

                //will return NumberOfAffectedRows I Know its will be one 
                int NumberOfAffectedRows = command.ExecuteNonQuery();

                if (NumberOfAffectedRows > 0)
                {
                    Console.WriteLine($"Done Successfully With {NumberOfAffectedRows} Number Of Affected Rows");
                }
                else {
                    Console.WriteLine($"Deleting Failed With {NumberOfAffectedRows} row Affect ");
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
            // I can make it return false or true also to check it here in the main.
            DeleteOneRecordFromDatabase(9);

        }
    }
}
