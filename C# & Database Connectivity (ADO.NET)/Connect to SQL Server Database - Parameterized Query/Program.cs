using System;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.Remoting.Messaging;

namespace Connect_to_SQL_Server_Database___Parameterized_Query
{
    internal class Program
    {
        static string connectionString = "Server =.;Database = ContactsDB;User Id = sa;Password = MaherSawsak123";

        static void PrintAllContactWithFirstName(string FirstName) {

            SqlConnection Connection = new SqlConnection(connectionString);
            string query = "select * from Contacts where FirstName = @FirstName";

            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);

            try {
                Connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read()) {


                    int ContactID = (int)reader["ContactID"];
                    string FirstNamee = (string)reader["FirstName"];
                    string LastName = (string)reader["LastName"];
                    string Email = (string)reader["Email"];
                    string Phone = (string)reader["Phone"];
                    string Address = (string)reader["Address"];
                    int CountryID = (int)reader["CountryID"];


                    Console.WriteLine($"ContactID   :  {ContactID}    ");
                    Console.WriteLine($"FirstName   :  {FirstNamee}   ");
                    Console.WriteLine($"LastName    :  {LastName}     ");
                    Console.WriteLine($"Email       :  {Email}        ");
                    Console.WriteLine($"Phone       :  {Phone}        ");
                    Console.WriteLine($"Address     :  {Address}      ");
                    Console.WriteLine($"CountryID   :  {CountryID}    \n\n");


                
                }
                //here to close reader and connection.
                reader.Close();
                Connection.Close();


            }
            catch (Exception ex) {
                Console.WriteLine($"Error: {ex.Message}");
            }

           
            




        }

        static void PrintAllContactWithFirstNameAndCountry(string FirstName, int CountryID)
        {

            SqlConnection Connection = new SqlConnection(connectionString);
            string query = "select * from Contacts where FirstName = @FirstName AND CountryID = @CountryID";

            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@CountryID", CountryID);

            try
            {
                Connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {


                    int ContactID = (int)reader["ContactID"];
                    string CurrentFirstName = (string)reader["FirstName"];
                    string LastName = (string)reader["LastName"];
                    string Email = (string)reader["Email"];
                    string Phone = (string)reader["Phone"];
                    string Address = (string)reader["Address"];
                    int CurrentCountryID = (int)reader["CountryID"];


                    Console.WriteLine($"ContactID   :  {ContactID}    ");
                    Console.WriteLine($"FirstName   :  {CurrentFirstName}   ");
                    Console.WriteLine($"LastName    :  {LastName}     ");
                    Console.WriteLine($"Email       :  {Email}        ");
                    Console.WriteLine($"Phone       :  {Phone}        ");
                    Console.WriteLine($"Address     :  {Address}      ");
                    Console.WriteLine($"CountryID   :  {CurrentCountryID}    \n\n");



                }
                //here to close reader and connection.
                reader.Close();
                Connection.Close();


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }







        }


        static void Main(string[] args)
        {
            PrintAllContactWithFirstName("jane");
            Console.WriteLine("\n\n Second result for FirstName and Country\n\n");
            PrintAllContactWithFirstNameAndCountry("jane", 1);
        }
    }
}
