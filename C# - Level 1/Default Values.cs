
using System;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //using default(type)
            int i = default(int); 
            float f = default(float);
            decimal d = default(decimal);
            bool b = default(bool);//will be false.
            char c = default(char);

            // C# 7.1 onwards
            //get default value using just default 
            int i2 = default; 
            float f2 = default;
            decimal d2 = default;
            bool b2 = default;
            char c2 = default;

        }
    }
}
