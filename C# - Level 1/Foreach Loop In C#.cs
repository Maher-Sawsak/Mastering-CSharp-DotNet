using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] MyArray = { 'A', 'B', 'C', 'D', 'E', 'F' };

            //its like nearly close to range loop in C++ that i solved for vectors.for(string &v: vectorName).  
            Console.Write("My Array Elements : ");
            foreach (char C in MyArray) {

                Console.Write(C);
            }

            //instead od vector in c# we user List its same behavior for it push = add , size = count,
            List <string> MyList = new List<string>();
            MyList.Add("Maher");
            MyList.Add("Nezar");
            MyList.Add("Sawsak");


            Console.Write("\nList/Vector Elements : ");            
            foreach (string TempName in MyList) {
                Console.Write(TempName + " ");
            }



        }
    }
}
