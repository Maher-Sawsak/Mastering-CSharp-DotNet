using System;
using System.Data;
using System.Net;
using System.Data.SqlClient;
using System.Collections.Specialized;
using System.Runtime.InteropServices;

namespace FirstTryingToConnect
{
    
    internal class Program
    {
        //this is the connection string it will be as a parameter to SqlConnection object's
        static string connectionString = "Server=.;Database = ContactsDB;User Id=sa;Password=MaherSawsak123";


        static void PrintAllContacts() {

            //here i am preapearing to make the connection.
            SqlConnection connection = new SqlConnection(connectionString);
            //this is my query i am asking the ado.net to do on the database and bring the result
            string query = "SELECT * FROM Contacts";

            //here is the object command from class SqlCommand it need the connection string and the query.
            SqlCommand command = new SqlCommand(query, connection);
            

            //always make sure to use try{}catch(){} to handle if somthing happend to the connection.
            try {
                //by this line I opened the connection
                connection.Open();
               //here i'm using the reader to store the data rows result make sure that u have more than one
               //rows if u are using the reader and will read row by row.
                SqlDataReader reader = command.ExecuteReader();


                //this while will be true until the reader will not read any row during reading will be true.
                while (reader.Read()) {

                    //to store the coming data in variable will by used later
                    //and make sure to cast or convert the type coming for need it.
                    int ContactID = (int)reader["ContactID"];
                    string FirstName = (string)reader["FirstName"];
                    string LastName = (string)reader["LastName"];
                    string Email = (string)reader["Email"];
                    string Phone = (string)reader["Phone"];
                    string address = (string)reader["Address"];
                    int CountryID = (int)reader["CountryID"];


                    //here printing the result which stored in the variable on step before.
                    Console.WriteLine($"Contact ID     : {ContactID}");
                    Console.WriteLine($"First Name     : {FirstName}");
                    Console.WriteLine($"Last Name      : {LastName}");
                    Console.WriteLine($"Email          : {Email}");
                    Console.WriteLine($"Phone          : {Phone}");
                    Console.WriteLine($"Address        : {address}");
                    Console.WriteLine($"Country ID     : {CountryID}\n\n");


                                  
                }
 //SOOOO Important Note here :
 //u need to close the connection and the reader cuz there limited number of connection called Connection Pool
 //so every open need to close for reader and connection.
                reader.Close();
                connection.Close();

            }//here to handle the if an error or exception thrown
            catch (Exception ex) {
                Console.WriteLine("Error " + ex.Message);
            }
          

        }
        
        static void Main(string[] args)
        {
            //calling function 
            PrintAllContacts();
        }
    }
}
