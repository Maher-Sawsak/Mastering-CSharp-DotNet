using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Math_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte Number1 = 3, Number2 = 6, Number3 = 8;

            byte MaxNumebr = Convert.ToByte(Math.Max(Number1, Number2));
            Console.WriteLine("The Max Number Is        : " + MaxNumebr);
            Console.WriteLine("The Min Numebr Is        : " + Convert.ToString(Math.Min(Number1, Number2)));
            Console.WriteLine("The Square Root of 8 Is  : " + Math.Sqrt(Number3));
            Console.WriteLine("The Round Of 8.93 Is     : " + Math.Round(8.93));//it took double&decimal return same thing.
            Console.WriteLine("The Floor of 4.49 Is     : " + Math.Floor(4.49));//take double & decimal return same thing.
            Console.WriteLine("The Floor of 4.51 Is     : " + Math.Floor(4.51));//take double & decimal return same thing
            Console.WriteLine("The Ceiling of 5.2       : " + Math.Ceiling(5.2));
            Console.WriteLine("The Ceiling of 5.6       : " + Math.Ceiling(5.6));

            //removes the decimal part and returns only the integer
            Console.WriteLine("The Truncate of 4.123    : " + Math.Truncate(4.123));

            Console.WriteLine("The Pi Value IS          : " + Math.PI);
            Console.WriteLine("The e Vlaue IS           : " + Math.E);
            Console.WriteLine("The Logarithms Of 100    : " + Math.Log(100));//its ln means base is e
            Console.WriteLine("The Logarithms Of 100 to Base 10    : " + Math.Log10(100));//here base is 10

            Console.WriteLine("The Absoulate Value of -1 Is        : " + Math.Abs(-1));
        }
    }
}
