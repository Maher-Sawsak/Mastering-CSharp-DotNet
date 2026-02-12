using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadLine_Syntax
{
    internal class ReadLineSyntax
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Name : ");
            string Name = Console.ReadLine();

            Console.WriteLine("The Name You Entered Is  : "  + Name);

            Console.WriteLine($"Hello {Name}, How are u doing !!");
        }
    }
}
