using System;
using System.Linq;
namespace Array_Operations_Using_System.Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Myarr = {2, 324, 65, 423, 4, 7, 43, 23, 643, 566, 57 };
            Console.WriteLine("The Maimun Value In The Array Is  :   " + Myarr.Max());
            Console.WriteLine("The Minumum Value In The Array Is :   " + Myarr.Min());

            //it will give the value at certain Index  if out of range will give the default value 0.
            Console.WriteLine("The Value At index 0 = " + Myarr.ElementAtOrDefault(0));
            Console.WriteLine("The Value At index -1 = " + Myarr.ElementAtOrDefault(-1));
            Console.WriteLine("The Value At index 100 = " + Myarr.ElementAtOrDefault(100));

            //returning double value contain the average   1 + 2 + 3 / 3
            Console.WriteLine("The Average Is : " + Myarr.Average());

            Console.WriteLine("The Size Or Number Of Elements In My Array : " + Myarr.Count());

            Console.WriteLine("The Sum Of All elemnts Is  : " + Myarr.Sum());

          
        
        
        
        }



    }
}
