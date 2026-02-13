using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Dimensional_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //syntax for 2D array
            int[,] x = { { 1, 2, 3 }, { 3, 4, 5 } };

            Console.WriteLine("2D Array Without Size = " + x[1, 0] +" "+ x[1, 1] +" "+ x[1, 2]);

            int[,] DArr = new int[2, 2];

            //for first element in 2d array Meaning first array in 2D Array.
            DArr[0, 0] = 2;
            DArr[0, 1] = 4;
            Console.WriteLine( "2D Array In heap memory With Size First Element : "+DArr[0, 0] + " " + DArr[0, 1]);

            //for second element.
            DArr[1, 0] = 6;
            DArr[1, 1] = 12;

            Console.WriteLine("2D Array In heap memory With Size Second Element : " + DArr[1, 0] + " " + DArr[1, 1]);
        }
    }
}
