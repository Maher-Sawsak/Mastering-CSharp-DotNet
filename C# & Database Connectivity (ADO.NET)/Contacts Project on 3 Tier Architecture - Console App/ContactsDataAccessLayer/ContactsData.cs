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
                                              ref string Phone, ref string Address, ref DateTime DateOfBirth, ref int CountryID, ref string ImagePath){

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











    }



}
