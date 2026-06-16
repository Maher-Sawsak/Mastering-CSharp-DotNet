using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDatatablesInsideDatasetByName
{
    internal class Program
    {
        static void Main(string[] args)
        {


            DataTable dtEmp = new DataTable("tblEmployee");

            dtEmp.Columns.Add("ID", typeof(int));
            dtEmp.Columns.Add("Name", typeof(string));
            dtEmp.Columns.Add("Country", typeof(string));
            dtEmp.Columns.Add("Salary", typeof(double));


            dtEmp.Rows.Add(1, "Maher", "Syria", 1234.8);
            dtEmp.Rows.Add(1, "Ali", "Syria", 3942);
            dtEmp.Rows.Add(1, "Nour", "Syria", 55235);
            dtEmp.Rows.Add(1, "Rayan", "Iran", 7672);


            DataTable dtDepartment = new DataTable("tblDepartments");
            dtDepartment.Columns.Add("ID", typeof(int));
            dtDepartment.Columns.Add("Name", typeof(string));

            dtDepartment.Rows.Add(1, "Marketing");
            dtDepartment.Rows.Add(2, "Software");
            dtDepartment.Rows.Add(3, "Hardware");

            DataSet ds = new DataSet();
            ds.Tables.Add(dtEmp);
            ds.Tables.Add(dtDepartment);

           

            foreach (DataRow DataRow in ds.Tables["tblEmployee"].Rows)
            {
                Console.WriteLine($"ID: {DataRow["ID"]}\tName: {DataRow["Name"]}\tCountry:{DataRow["Country"]}\tSalary:{DataRow["Salary"]}");
            }



            Console.WriteLine("\n\nDepartment Table:\n");
            foreach (DataRow RecordRow in ds.Tables["tblDepartments"].Rows)
            {
                Console.WriteLine($"ID {RecordRow["ID"]}\t Name: {RecordRow["Name"]}");
            }
        }
    }
}
