using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternary_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool IsEven;

            Console.WriteLine("Please Enter A Number To Check Even Or Not   ? ");

            int Number = Convert.ToInt32(Console.ReadLine());

            IsEven = (Number % 2 == 0) ? true : false;

            Console.WriteLine((Number % 2 == 0) ? "Yes" : "No");

        }        
    }
}
