using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Data_in_Dataview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataTable dtEmp = new DataTable();
            dtEmp.Columns.Add("ID", typeof(int));
            dtEmp.Columns.Add("Name", typeof(string));
            dtEmp.Columns.Add("Country", typeof(string));
            dtEmp.Columns.Add("Salary", typeof(double));

            dtEmp.PrimaryKey = new DataColumn[]
            {
            dtEmp.Columns["ID"]
            }; 

            dtEmp.Rows.Add(1,"Maher","Syria",2300);
            dtEmp.Rows.Add(2,"Ali","Syria",3214);
            dtEmp.Rows.Add(3,"Habib","KSA",1000.2);


            DataView dvEmp = dtEmp.DefaultView;
          //this how to sort data on the view its like database but without order by..
            dvEmp.Sort = "Name ASC";
            for (int i = 0; i < dvEmp.Count; i++) 
            {

                Console.WriteLine($"ID: {dvEmp[i][0]}\tName: {dvEmp[i][1]}\tCountry: {dvEmp[i][2]}\tSalary: {dvEmp[i][3]}\t");

            }




        }
    }
}
