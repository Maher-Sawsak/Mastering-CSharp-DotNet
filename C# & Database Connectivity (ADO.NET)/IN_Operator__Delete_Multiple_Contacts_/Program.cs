using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IN_Operator__Delete_Multiple_Contacts_
{
    
    internal class Program
    {

        static string ConnectionString = "Server =.;Database= ContactsDB;User Id = sa;Password=MaherSawsak123";

        static void DeleteRecordsUsinInOperator(string ContactIDs) {
            SqlConnection connection = new SqlConnection(ConnectionString);
            //here to use in operater in safe way to prevent the sql injection u need to use it like this 
            //and there is onther way by the array  but now u can use this and will work good and safe.
            string query = @"DELETE Contacts           
                                            Where ContactID in(select value From STRING_SPLIT(@IDs, ','));";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@IDs", ContactIDs);

            try
            {
                connection.Open();

                int AffectedRows = command.ExecuteNonQuery();

                if (AffectedRows > 0)
                {
                    Console.WriteLine($"Done Successfully, The Number Of Deleted Rows Is {AffectedRows}");
                }
                else {
                    Console.WriteLine($"The Deleting Operation Failed, The Number Of Deleted Rows Is {AffectedRows}");
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

            DeleteRecordsUsinInOperator("3,4,5");
        }
    }
}
