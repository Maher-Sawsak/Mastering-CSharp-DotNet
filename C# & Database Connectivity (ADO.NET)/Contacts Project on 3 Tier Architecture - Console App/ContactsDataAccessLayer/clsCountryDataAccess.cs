using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsDataAccessLayer
{
    public class clsCountryDataAccess
    {


        public static bool FindCountryByID(int CountryID, ref string CountryName) 
        {
            bool isFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Countries where CountryID = @CountryID;";

            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@CountryID", CountryID);

            try
            {
                Connection.Open();

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.Read())
                {
                    isFound = true;

                    CountryName = (string)Reader["CountryName"];
                }
                else
                {
                    isFound = false;
                }

                Reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
             
            }
            finally
            {
                Connection.Close();
            }

            return isFound;
        }

    }
}
