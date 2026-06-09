using System;
using System.Data;
using System.Linq;

namespace DataTableExample_1_CreateOfflineDataTableAndListData_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataTable dtStudent = new DataTable();

            dtStudent.Columns.Add("ID", typeof(int));
            dtStudent.Columns.Add("Name", typeof(string));
            dtStudent.Columns.Add("Country", typeof(string));
            dtStudent.Columns.Add("Salary", typeof(Double));
            dtStudent.Columns.Add("Date", typeof(DateTime));

            dtStudent.Rows.Add(1, "Maher Sawsak", "Turkey",2092.3, DateTime.Now);
            dtStudent.Rows.Add(2, "Ali Sawsak", "Syria"   ,32874, DateTime.Now);
            dtStudent.Rows.Add(3, "Habib Sawsak", "Syria" ,1043.3, DateTime.Now);


   



            Console.WriteLine("\t _________________________________________________________________________________________");
            Console.WriteLine("\t|{0,-4}|{1,-30}|{2,-20}|{3,-10}|{4,-21}|", "ID", "Name", "Country", "Salary", "Date Of Birth");

            foreach (DataRow row in dtStudent.Rows)
            {
                Console.WriteLine("\t|-----------------------------------------------------------------------------------------|");
                Console.WriteLine("\t|{0,-4}|{1,-30}|{2,-20}|{3,-10}|{4,-21}|", row["ID"], row["Name"], row["Country"], row["Salary"], row["Date"]);
            }
            Console.WriteLine("\t|_________________________________________________________________________________________|");
        }
    }
}
