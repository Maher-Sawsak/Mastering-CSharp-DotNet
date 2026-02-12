
using System;

namespace Main
{
    internal class Program
    {
        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {



            int SmallerOne = 2;
            double BiggerOne = 3.42;



            Console.WriteLine($"The Value Of Converting From double to int    {(int)BiggerOne}  :   " );
            Console.WriteLine($"\nThe Value Of Converting From int to double   {SmallerOne} :   ");
                                                                                                        
                


            Console.WriteLine(WeekDays.Friday);

            //for Casting the enum .
            int day = (int)WeekDays.Friday;    
            Console.WriteLine(day);            

            var wd = (WeekDays)5; 
            Console.WriteLine(wd);




            Console.ReadKey();

        }
    }
}
