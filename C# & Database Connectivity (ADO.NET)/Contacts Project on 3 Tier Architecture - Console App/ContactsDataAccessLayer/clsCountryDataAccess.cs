using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsDataAccessLayer
{
    public class clsCountryDataAccess
    {


        public static bool FindCountryByID(int CountryID, ref string CountryName,ref string Code,ref string PhoneCode) 
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

                    Code = Reader["Code"].ToString();
                    PhoneCode = Reader["PhoneCode"].ToString();

                }
                else
                {
                    isFound = false;
                }

                Reader.Close();
            }
            catch (Exception ex)
            {
                throw;
             
            }
            finally
            {
                Connection.Close();
            }

            return isFound;
        }


        public static int AddNewCountry(string CountryName,string Code,string PhoneCode) {

            int Flag = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Countries (CountryName,Code,PhoneCode)
             VALUES(@CountryName ,@Code,@PhoneCode);
             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@CountryName", CountryName);
            command.Parameters.AddWithValue("@Code", string.IsNullOrEmpty(Code) ? (object)System.DBNull.Value : Code);
            command.Parameters.AddWithValue("@PhoneCode", string.IsNullOrEmpty(PhoneCode) ? (object)System.DBNull.Value : PhoneCode);


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
                throw;
            }
            finally { 
            Connection.Close();
            }

            return (Flag );
        }

        
        public static bool UpdateCountry(int CountryID,string CountryName,string Code,string PhoneCode) {

            int AffectedRows = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Countries SET CountryName = @CountryName ,Code = @Code,PhoneCode = @PhoneCode
                             WHERE CountryID = @CountryID;";
            
            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("@CountryName", CountryName);
            Command.Parameters.AddWithValue("@CountryID", CountryID);
            Command.Parameters.AddWithValue("@Code", string.IsNullOrEmpty(Code) ? (object)System.DBNull.Value : Code);
            Command.Parameters.AddWithValue("@PhoneCode", string.IsNullOrEmpty(PhoneCode) ? (object)System.DBNull.Value : PhoneCode);
            try
            {

                Connection.Open();
                AffectedRows = Command.ExecuteNonQuery();

                

            }
            catch (Exception ex)
            {
                throw;
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
                throw;
            }
            finally 
            {
                Connection.Close();
            }
            return (NumberOfAffectedRows != 0);


        }





        public static DataTable GetAllCountries()
        {
            DataTable DataTableContainer = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * From Countries";

            SqlCommand Command = new SqlCommand(query, Connection);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {

                    DataTableContainer.Load(Reader);
                }
                Reader.Close();

            }
            catch (Exception ex)
            {
                throw;
            }
            finally 
            {
                Connection.Close();
            }

            return DataTableContainer;
        }



        public static bool IsCountryExist(int CountryID) 
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select Found = 1 From Countries where CountryID = @CountryID";

            SqlCommand command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@CountryID", CountryID);

            try
            {
                connection.Open();
              object  Result = command.ExecuteScalar();
                if (Result != null) { 
                IsFound  = true;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            finally 
            {
                // The finally will always run EVEN if there is a return before it will compiled and close the connection.
                connection.Close();
            }

            return (IsFound);
        
        }


        public static bool GetCountryInfoByCountryName(ref int CountryID,string CountryName,ref string Code,ref string PhoneCode) 
        {
            bool   IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * from Countries where CountryName = @CountryName" ;

            SqlCommand command  = new SqlCommand(query , connection);
            command.Parameters.AddWithValue("@CountryName" , CountryName);
            try
            {

                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                //Remeber Reader will rturn true and false also will move the Reader one step to start read if there is data.
                if (Reader.Read())
                {
                    IsFound = true;
                    CountryID = (int)Reader["CountryID"];
                    Code = Reader["Code"].ToString();//here ToString will return empty for the DbNull Value.
                    PhoneCode = Reader["PhoneCode"].ToString();
                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally 
            {
                connection.Close();
            }
            return IsFound;
        }




        public static bool IsCountryExist(string CountryName) 
        {

            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select Found = 1 From Countries where CountryName = @CountryName";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryName", CountryName);

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();
                if (Result != null)
                {
                    IsFound = true;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                // The finally will always run EVEN if there is a return before it will compiled and close the connection.
                connection.Close();
            }

            return (IsFound);
        }
    }
}
