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
            dtStudent.Rows.Add(3, "Nour Sawsak", "KSA" ,324, DateTime.Now);

            int NumberOfStudents  = 0;
            double SumOfSalary = 0;
            double AvgSalary = 0;
            double MinSalary = 0;
            double MaxSalary = 0;
                       

   



            Console.WriteLine("\t _________________________________________________________________________________________");
            Console.WriteLine("\t|{0,-4}|{1,-30}|{2,-20}|{3,-10}|{4,-21}|", "ID", "Name", "Country", "Salary", "Date Of Birth");

            foreach (DataRow row in dtStudent.Rows)
            {
                Console.WriteLine("\t|-----------------------------------------------------------------------------------------|");
                Console.WriteLine("\t|{0,-4}|{1,-30}|{2,-20}|{3,-10}|{4,-21}|", row["ID"], row["Name"], row["Country"], row["Salary"], row["Date"]);
            }
            Console.WriteLine("\t|_________________________________________________________________________________________|");
    
        NumberOfStudents = dtStudent.Rows.Count;
        SumOfSalary = Convert.ToDouble(dtStudent.Compute("Sum(Salary)",string.Empty));
        AvgSalary = Convert.ToDouble(dtStudent.Compute("Avg(Salary)",string.Empty));
        MinSalary = Convert.ToDouble(dtStudent.Compute("Min(Salary)",string.Empty));
        MaxSalary = Convert.ToDouble(dtStudent.Compute("Max(Salary)",string.Empty));


            Console.WriteLine($"Number Of Students : {NumberOfStudents}");
            Console.WriteLine($"Sum of Salary : {SumOfSalary}");
            Console.WriteLine($"Avg of Salary : {AvgSalary}");
            Console.WriteLine($"Min of Salary : {MinSalary}");
            Console.WriteLine($"Max of Salary : {MaxSalary}");




            //Now Applying the filter for table .
            DataRow[] DataRows;
            DataRows = dtStudent.Select("Country = 'Syria' or Country ='KSA'");
            Console.WriteLine("\nFilter For Syria (OR) KSA Country : ");
            foreach (DataRow RecordRow in DataRows)
            {
                Console.WriteLine($"ID :{RecordRow["ID"]}\tName: {RecordRow["Name"]}\tCountry : {RecordRow["Country"]} ");
            }





       
            DataRows =  dtStudent.Select("Country = 'Syria'");
            Console.WriteLine("\nFilter For Syria Country Only: ");
            foreach (DataRow  RecordRow in DataRows) 
            {
                Console.WriteLine($"ID :{RecordRow["ID"]}\tName: {RecordRow["Name"]}\tCountry : {RecordRow["Country"]} ");
            }


            Console.WriteLine("\nAdding Filter Compute Function On Syria Country");

            NumberOfStudents = DataRows.Count();
            SumOfSalary = Convert.ToDouble(dtStudent.Compute("Sum(Salary)", "Country='Syria'"));
            AvgSalary = Convert.ToDouble(dtStudent.Compute("Avg(Salary)", "Country='Syria'"));
            MinSalary = Convert.ToDouble(dtStudent.Compute("Min(Salary)", "Country='Syria'"));
            MaxSalary = Convert.ToDouble(dtStudent.Compute("Max(Salary)", "Country='Syria'"));


            Console.WriteLine($"Number Of Students : {NumberOfStudents}");
            Console.WriteLine($"Sum of Salary : {SumOfSalary}");
            Console.WriteLine($"Avg of Salary : {AvgSalary}");
            Console.WriteLine($"Min of Salary : {MinSalary}");
            Console.WriteLine($"Max of Salary : {MaxSalary}");


            //Show Only Student Hold ID 1.
            //IT WILL ONLY HOLD ONE RECORD THERE IS NO NEED TO ADD []
            DataRows = dtStudent.Select("ID=1");
            Console.WriteLine("\nFiltering : Student With ID = 1 : ");
            if (DataRows.Length > 0)
            {
                Console.WriteLine($"ID: {DataRows[0]["ID"]}\tName: {DataRows[0]["Name"]}\tCountry: {DataRows[0]["Country"]}");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }
    }

}
