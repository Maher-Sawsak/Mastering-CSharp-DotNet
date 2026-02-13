using System;


namespace Random_Number_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine(rnd.Next(2));//here is the max.
            Console.WriteLine(rnd.Next(1,10));//this in range from min to max.
            Console.WriteLine(rnd.Next());//this will return a random Number just positive.
        }
    }
}
