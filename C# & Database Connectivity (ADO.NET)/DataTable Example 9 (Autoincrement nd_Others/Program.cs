using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTable_Example_9__Autoincrement_nd_Others
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataTable dtEmp = new DataTable();
  
         
            DataColumn Column = new DataColumn();
            Column.DataType = typeof(int);
            Column.ColumnName = "ID";
            Column.Caption = "Employee ID";
            Column.ReadOnly = true;
            Column.AutoIncrement = true;
            Column.AutoIncrementSeed = 1;
            Column.AutoIncrementStep = 1;
            Column.Unique = true;

            dtEmp.Columns.Add(Column);

            //Now for Name column
            Column = new DataColumn();
            Column.DataType = typeof(string);
            Column.ColumnName = "Name";
            Column.Caption = "Employee Name";
            Column.ReadOnly = false;
            Column.Unique = false;
            dtEmp.Columns.Add(Column);


            //Now for Country column by another way to add 
            dtEmp.Columns.Add(new DataColumn("Country", typeof(string))
            {
                Caption = "Employee Country",
                ReadOnly = false,
                Unique = false
            });



            dtEmp.Rows.Add(null,"Maher Sawsak","Syria");
            dtEmp.Rows.Add(null,"Ali Bitar","Syria");
            dtEmp.Rows.Add(null,"Emmer Raji","Turkey");

            foreach (DataRow RecordRow in dtEmp.Rows) 
            { 
            Console.WriteLine($"ID : {RecordRow["ID"]}\tName: {RecordRow["Name"]}\tCountry {RecordRow["Country"]}");
            }

        }
    }
}
