using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatable_Example_4__Sorting_
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


            dtEmployeess.DefaultView.Sort = "ID DESC";
            dtEmployeess = dtEmployeess.DefaultView.ToTable();

            Console.WriteLine("\n\nOrdering The Table ID DESC :");
            foreach (DataRow RecordRow in dtEmployeess.Rows)
            {
                Console.WriteLine($"ID : {RecordRow["ID"]}\tName: {RecordRow["Name"]}\tCountry: {RecordRow["Country"]}");
            }



            //here to orderby Asc order by Name.

            dtEmployeess.DefaultView.Sort = "Name Asc";
//to table will convert the view to real DataTable and I will store after sorting on the dtEmployees.
            dtEmployeess = dtEmployeess.DefaultView.ToTable();


            Console.WriteLine("\n\nOrdering The Table By Name ASC :");
            foreach (DataRow RecordRow in dtEmployeess.Rows)
            {
                Console.WriteLine($"ID : {RecordRow["ID"]}\tName: {RecordRow["Name"]}\tCountry: {RecordRow["Country"]}");
            }
        }
    }
}
