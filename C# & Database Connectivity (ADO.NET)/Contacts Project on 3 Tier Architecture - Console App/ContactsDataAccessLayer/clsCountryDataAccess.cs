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


        public static int AddNewCountry(string CountryName) {

            int Flag = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Countries (CountryName)
             VALUES(@CountryName);
             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@CountryName", CountryName);


            try
            {
                Connection.Open();
                object Result = command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    Flag = InsertedID;
                }
                
            }
            catch (Exception ex)
            {
        
            }
            finally { 
            Connection.Close();
            }

            return (Flag );
        }

        
        public static bool UpdateCountry(int CountryID,string CountryName) {

            int AffectedRows = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Countries SET CountryName = @CountryName
                             WHERE CountryID = @CountryID;";
            
            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("@CountryName", CountryName);
            Command.Parameters.AddWithValue("@CountryID", CountryID);
            try
            {

                Connection.Open();
                AffectedRows = Command.ExecuteNonQuery();

                

            }
            catch (Exception ex)
            {
                return false;
            }
            finally {
                Connection.Close();
            }

            return (AffectedRows > 0);
        }


        public static bool DeleteCountry(int CountryID) 
        {
            int NumberOfAffectedRows = 0;
            SqlConnection Connection =  new SqlConnection(clsDataAccessSettings.ConnectionString);
            
            string query = "DELETE FROM Countries WHERE CountryID = @CountryID";

            SqlCommand Command  = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@CountryID", CountryID);

            try
            {
                Connection.Open();
                NumberOfAffectedRows = Command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                return (false);
            }
            finally 
            {
                Connection.Close();
            }
            return (NumberOfAffectedRows != 0);


        }













    }
}
