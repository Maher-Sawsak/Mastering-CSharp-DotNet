using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ParameterizedQueryWithLike
{

    internal class Program
    {

        static string ConnectionString = "Server =.;Database = ContactsDB;User Id =sa; Password = MaherSawsak123";

        static void PrintReaderResults(SqlDataReader reader) {

            while (reader.Read())
            {

                int ContactID = (int)reader["ContactID"];
                string FirstName = (string)reader["FirstName"];
                string LastName = (string)reader["LastName"];
                string Email = (string)reader["Email"];
                string Phone = (string)reader["Phone"];
                string Address = (string)reader["Address"];
                int CountryID = (int)reader["CountryID"];



                Console.WriteLine($"ContactID :    {ContactID}");
                Console.WriteLine($"FirstName :    {FirstName}");
                Console.WriteLine($"LastName  :    {LastName}");
                Console.WriteLine($"Email     :    {Email}");
                Console.WriteLine($"Phone     :    {Phone}");
                Console.WriteLine($"Address   :    {Address}");
                Console.WriteLine($"CountryID :    {CountryID}\n\n");

            }

        }
        static void SearchContactStartWith(string StartWith)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string query = "Select * from Contacts where FirstName Like '' +@StartWith +'%'";

            SqlCommand command = new SqlCommand(query ,connection);
            command.Parameters.AddWithValue("@StartWith", StartWith);


            try {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();


                PrintReaderResults(reader);
                connection.Close();
                reader.Close();
            
                   }
            catch (Exception ex)
            {
                Console.WriteLine($"Error {ex.Message}");
            }


        }

        static void SearchContactsEndWith(string EndWith) {

            SqlConnection connection = new SqlConnection(ConnectionString);

            string query = "Select * from Contacts where FirstName Like '%' + @EndWith";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@EndWith", EndWith);

            try {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();


                PrintReaderResults(reader);
                reader.Close();
                connection.Close();
                


            } 
            catch (Exception ex)
            {
                Console.WriteLine($"Error {ex.Message}");
            }
        }

        static void SearchContactsContains(string Contain) {

            SqlConnection connection = new SqlConnection(ConnectionString);
            string query = "Select * from Contacts where FirstName Like '%' +@Contain + '%' ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Contain", Contain);
            try {

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                PrintReaderResults(reader);
             
            
                //Important note for mr close reader then close the connection cuz remember reader bring data row by row.
                reader.Close();
                connection.Close();


            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Error {ex.Message}");
            }


        
        }

        static void Main(string[] args)
        {
            SearchContactStartWith("j");

            Console.WriteLine("\n\nNames Ends With (ne)\n\n");

            SearchContactsEndWith("ne");

            Console.WriteLine("\n\nNames Contains With (ae)\n\n");

            SearchContactsContains("ae");
        }
    }
}
