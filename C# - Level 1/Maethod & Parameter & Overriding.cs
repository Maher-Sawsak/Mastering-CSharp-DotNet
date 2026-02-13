using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods___Parameter
{
    internal class Program
    {

        //mustbe appear after the requirement 
        static void PrintFullName(string FirstName, string LastName, string FatherName = "Nezar")
        {

          Console.WriteLine("Name : {0} FatherName : {1} LastName : {2}",
                                     FirstName , FatherName, LastName );

        }

        static void PrintName(string FirstName, string LastName ) {

            Console.WriteLine("Name : {0}  LastName : {1}", FirstName , LastName);
        
        }
        static void PrintMyName() {
            Console.WriteLine("Maher Sawsak");
        
        }

        //Overriding method concept in c# ..
        static int Sum(int n1, int n2)
        {
            return n1 + n2;
        }
        static int Sum(int n1, int n2, int n3) {
            return n1 + n2 + n3;
        }

        static int Sum(int n1, int n2, int n3, int n4) {
            return n1 + n2 + n3 + n4;
        }
        static void Main(string[] args)
        {
            PrintMyName();
            PrintName("Ali", "Sawsak");
            PrintFullName("Ali", "Sawsak");
            PrintFullName("Ali", LastName: "Sawsak", FatherName: "Nezar");

            Console.WriteLine(Sum(2, 3));
            Console.WriteLine(Sum(5, 5,6));
            Console.WriteLine(Sum(5, 5, 6, 6));
            //thie last will give compilation error cuz the parameter is more than need.
            //Console.WriteLine(Sum(5, 5, 6, 6,5));
        }
    }
}
