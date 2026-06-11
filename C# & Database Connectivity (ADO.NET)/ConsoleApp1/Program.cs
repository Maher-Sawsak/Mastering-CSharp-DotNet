using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

          DataTable dtEmp = new DataTable();
            dtEmp.Columns.Add("ID",typeof(int));
            dtEmp.Columns.Add("Name",typeof(string));
            dtEmp.Columns.Add("Country" , typeof(string));


            dtEmp.Rows.Add(1, "Maher Sawsak", "Syria");
            dtEmp.Rows.Add(2, "Ali Sawsak", "Turkey");
            dtEmp.Rows.Add(3, "Habib Sawsak", "Turkey");
            dtEmp.Rows.Add(4, "Nidal Sawsak", "Saudi Arabia");


            foreach (DataRow RecordRow in dtEmp.Rows)
            {
                Console.WriteLine($"ID: {RecordRow["ID"]}\tName: {RecordRow["Name"]}\t Country: {RecordRow["Country"]}");
            }






            Console.WriteLine("\nAfter Updating Record With ID 3 : ");
            DataRow[] RefRows = dtEmp.Select("ID = 3");

            foreach (DataRow RecordRow in RefRows) 
            {
                RecordRow["Name"] = "Butrous";
                RecordRow["Country"] = "United Kingdom";
            }


            foreach (DataRow RecordRow in dtEmp.Rows)
            {
                Console.WriteLine($"ID: {RecordRow["ID"]}\tName: {RecordRow["Name"]}\t Country: {RecordRow["Country"]}");
            }

        }
    }
}
