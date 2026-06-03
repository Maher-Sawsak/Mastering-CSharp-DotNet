using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using ContactsDataAccessLayer;
namespace ContactsBusinessLayer
{

 public  class clsCountry
    {
        enum enMode {Add =  1,Update = 2 };
        enMode Mode;

        public int CountryID { set; get; }
        public string CountryName { set; get; }


        public clsCountry(string CountryName) { 
        this.CountryName = CountryName;
            this.CountryID = -1;
            Mode = enMode.Add;
        }

        private clsCountry(int CountryID, string CountryName)
        {
            this.CountryName = CountryName;
            this.CountryID = CountryID;
            Mode= enMode.Update;
        }

        public static clsCountry FindCountryByID(int CountryID)
        {
            string CountryName = "";

            if (clsCountryDataAccess.FindCountryByID( CountryID, ref CountryName)){

                return new clsCountry(CountryID, CountryName);
            }
            else {
                return null;
            }
           

        }


        private bool _AddNewCountry() {
            this.CountryID = clsCountryDataAccess.AddNewCountry(this.CountryName);
            return (CountryID != -1);
        }

        private bool _UpdateCountryRecord() {


            return (clsCountryDataAccess.UpdateCountry(this.CountryID,this.CountryName));
        
        }

        public static bool DeleteCountry(int CountryID) 
        {
            return (clsCountryDataAccess.DeleteCountry(CountryID));
        
        }

        public  bool Save() {

            switch (Mode) { 
                case enMode.Add:
                    return (_AddNewCountry());


                case enMode.Update:
                    return (_UpdateCountryRecord());
            }
            return false;
        }





        public static DataTable GetAllCountries() 
        {

            return (clsCountryDataAccess.GetAllCountries());
        
        }


        public static bool IsCountryExist(int CountryID) 
        {
            return (clsCountryDataAccess.IsCountryExist(CountryID));
        }



        public static clsCountry FindCountryByName(string CountryName) 
        {
            int CountryID = 0;

            if (clsCountryDataAccess.GetCountryInfoByCountryNam(ref CountryID, CountryName))
            {

                return new clsCountry(CountryID, CountryName);
            }
            else {

                return null;
            }
        
        }





        public static bool IsCountryExist(string CountryName) {

            return (clsCountryDataAccess.IsCountryExist(CountryName));
        }




    }
}
