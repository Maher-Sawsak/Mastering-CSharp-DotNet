using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ContactsDataAccessLayer;
namespace ContactsBusinessLayer
{

 public  class clsCountry
    {

        public int CountryID { set; get; }
        public string CountryName { set; get; }



        private clsCountry(int CountryID, string CountryName)
        {
            this.CountryName = CountryName;
            this.CountryID = CountryID;
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

    }
}
