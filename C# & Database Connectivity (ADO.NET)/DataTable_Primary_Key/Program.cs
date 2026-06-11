    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
    using System.Threading.Tasks;

    namespace DataTable_Primary_Key
    {
        internal class Program
        {
            static void Main(string[] args)
            {

                DataTable dtEmp = new DataTable();

                dtEmp.Columns.Add("ID", typeof(int));
                dtEmp.Columns.Add("Name", typeof(string));
                dtEmp.Columns.Add("Country", typeof(string));

            //u can assign primary key by more than way :

            /*
             //this wae is simple and readable and same to the second way below.
            dtEmp.PrimaryKey = new DataColumn[] { dtEmp.Columns["ID"] };
             */
            


            //ThE second way its longer but same result to the first.
            DataColumn[] PKColumn = new DataColumn[1];
                //u can assign as much as u need as Primary key here its only one.
                PKColumn[0] = dtEmp.Columns["ID"];
                dtEmp.PrimaryKey = PKColumn;

                dtEmp.Rows.Add(1, "Maher Sawsak", "Syria");
                dtEmp.Rows.Add(2, "Ali Sawsak", "Turkey");
                dtEmp.Rows.Add(3, "Habib Sawsak", "Turkey");
                dtEmp.Rows.Add(4, "Nidal Sawsak", "Saudi Arabia");

                foreach (DataRow RecordRow in dtEmp.Rows)
                {
                  Console.WriteLine($"ID: {RecordRow["ID"]}\tName: {RecordRow["Name"]}\t Country: {RecordRow["Country"]}");
                }

            }
        }
    }
