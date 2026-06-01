using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsDataAccessLayer
{


    public class clsContactDataAccess {



        public static bool GetContactInfoByID(int ID, ref string FirstName, ref string LastName, ref string Email,
                                              ref string Phone, ref string Address, ref DateTime DateOfBirth, ref int CountryID, ref string ImagePath) {

            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from Contacts where ContactID = @ContactID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ContactID", ID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    //IF iTS Read that means its found will make the flag as true in this case.
                    //and those doesn't allow null except the image path so i will handel it if its null in the databasse.
                    IsFound = true;
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Email = (string)reader["Email"];
                    Phone = (string)reader["Phone"];
                    Address = (string)reader["Address"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    CountryID = (int)reader["CountryID"];

                    if (reader["ImagePath"] != DBNull.Value)
                    {

                        ImagePath = (string)reader["ImagePath"];
                    }
                    else {
                        ImagePath = "";
                    }
                    reader.Close();
                }


            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally {
                connection.Close();
            }


            return IsFound;
        }



        public static int AddNewContact(string FirstName, string LastName,
                                              string Email, string Phone, string Address,
                                                 DateTime DateOfBirth, int CountryID, string ImagePath)
        {
            int ContactID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);


            string query = @"INSERT INTO Contacts
            (FirstName ,LastName, Email, Phone, Address, DateOfBirth, CountryID, ImagePath)
             VALUES(@FirstName,@LastName,@Email,@Phone,@Address,@DateOfBirth, @CountryID, @ImagePath);
             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@CountryID", CountryID);

            //here in the database the imagebPath can be null so Imust handel it here if its came empty to save it as null not empty in the database.
            if (ImagePath != "")
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else {
                //this means put the null instead of @ImagePath which is in the query.
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            }


            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();


                //try will return at end true or false if in the string is number like "15"will converted to int and return true and store it in InsertedID variable.
                //other than this will return fale means condition will be false.  My Note: T&&T = T , T&&F=F.
                //also Notice that Result if done successfully will contain the last id for last insert cuz scope_identity in query second part.
                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {

                    ContactID = InsertedID;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return ContactID;

        }





        public static bool UpdateContact(int ID,  string FirstName,  string LastName,  string Email,
                                               string Phone,  string Address,  DateTime DateOfBirth,  int CountryID, string ImagePath)
        {

            int NumberOfAffectedRows = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Contacts SET FirstName = @FirstName, LastName= @LastName ,Email = @Email,  Phone = @Phone,
                            Address = @Address,  DateOfBirth = @DateOfBirth ,CountryID = @CountryID,ImagePath = @ImagePath 
                             WHERE ContactID = @ContactID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@CountryID", CountryID);
            command.Parameters.AddWithValue("@ContactID", ID);

            if (ImagePath != "")
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else {
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            }

            try
            {

                connection.Open();

                NumberOfAffectedRows = command.ExecuteNonQuery();



            }
            catch (Exception ex)
            {
                return false;
            }
            finally {
                connection.Close();
            }


            return (NumberOfAffectedRows > 0);



        }









        




    }



}
