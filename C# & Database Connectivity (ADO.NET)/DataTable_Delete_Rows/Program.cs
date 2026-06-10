using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTable_Delete_Rows
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataTable dtEmployeess = new DataTable();
            //i made it simple just to apply the concept
            dtEmployeess.Columns.Add("ID", typeof(int));
            dtEmployeess.Columns.Add("Name", typeof(string));
            dtEmployeess.Columns.Add("Country", typeof(string));


            dtEmployeess.Rows.Add(1, "Maher", "Syria");
            dtEmployeess.Rows.Add(2, "Ahmad", "Syria");
            dtEmployeess.Rows.Add(3, "Mohammed", "Lebanon");
            dtEmployeess.Rows.Add(4, "Bilal", "Saudi Arabia");
            dtEmployeess.Rows.Add(5, "Maksat", "Russia");



            foreach (DataRow RecordRow in dtEmployeess.Rows)
            {
                Console.WriteLine($"ID : {RecordRow["ID"]}\tName: {RecordRow["Name"]}\tCountry: {RecordRow["Country"]}");
            }



            Console.WriteLine("After Deleting The Row With ID = 2");
            //remember it will not deleted it will hide it only.
            //here the Result its a By Reference not by value remember that.
            DataRow[] Result = dtEmployeess.Select("ID=2");

            foreach (DataRow RowRecord in Result) 
            {
                //very important note :
                //this delete acctually will no delete the row it will just mark it as deleted
                // when u use -----dtEmployeess.AcceptChanges();----- after delete will use this.
                //the abve code for accept its for database to verify changes
                RowRecord.Delete();
            }

            foreach (DataRow Row in dtEmployeess.Rows) 
            {
                Console.WriteLine($"ID : {Row["ID"]}\tName: {Row["Name"]}\tCountry: {Row["Country"]}");
            }

        }
    }
}
