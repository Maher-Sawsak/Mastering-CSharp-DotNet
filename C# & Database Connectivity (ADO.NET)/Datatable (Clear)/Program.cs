using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatable__Clear_
{
    internal class Program
    {
        static void Main(string[] args)
        {



            DataTable dtEmp = new DataTable();

            dtEmp.Columns.Add("ID", typeof(int));

            dtEmp.Columns.Add("Name", typeof(string));

            dtEmp.Columns.Add("Country", typeof(string));





            dtEmp.Rows.Add(1, "Maher Sawsak", "Syria");

            dtEmp.Rows.Add(2, "Ali Sawsak", "Turkey");

            dtEmp.Rows.Add(3, "Habib Sawsak", "Turkey");

            dtEmp.Rows.Add(4, "Nidal Sawsak", "Saudi Arabia");





            foreach (DataRow RecordRow in dtEmp.Rows)
            {
                Console.WriteLine($"ID: {RecordRow["ID"]}\tName: {RecordRow["Name"]}\t Country: {RecordRow["Country"]}");
            }

            
            
            //This is how to delete all data in data table.
            dtEmp.Clear();

            Console.WriteLine("\n\nAfter Using Clear Method : ");
            foreach (DataRow RecordRow in dtEmp.Rows)
            {
                Console.WriteLine($"ID: {RecordRow["ID"]}\tName: {RecordRow["Name"]}\t Country: {RecordRow["Country"]}");
            }

        }
    }
}
