using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop
{
    internal class ArrayDeclaration
    {
        static void Main(string[] args)
        {

            //decleare an array syntax::::::::::::datatype[] arrayName;:::::::::::::::
            int[] number = { 1, 2, 3 };

            number[0] = 2;
            number[1] = 4;
            number[2] = 8;


            //this how to define the number of elements that an array can hold.
            //we have to allocate memory for the array in C#
            //make sure to put the size in the [] its like my old code in c++ very similiar.
            string[] Names = new string[6];

        }
    }
}
