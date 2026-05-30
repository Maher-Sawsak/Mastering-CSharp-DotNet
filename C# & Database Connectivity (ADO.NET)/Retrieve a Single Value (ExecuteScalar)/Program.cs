using System;
using System.Data.SqlClient;

namespace Retrieve_a_Single_Value__ExecuteScalar_
{
    internal class Program
    {
        static string ConnectionString = "Server =.;Database= ContactsDB;User Id =sa;Password=MaherSawsak123";


        static string GetFirstNameByID(int ContactID) {
            string FirstName = "";
            SqlConnection connection = new SqlConnection(ConnectionString);

            string query = "Select FirstName from Contacts where ContactID = @ContactID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("ContactID", ContactID);
            

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {

                     FirstName = (string)result;

                }
                else {
                     FirstName = "";
                }
                
                connection.Close();

            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Error {ex.Message}");
            }
            return FirstName;


        }



        static void Main(string[] args)
        {
            Console.WriteLine(GetFirstNameByID(1));

        }
    }
}
