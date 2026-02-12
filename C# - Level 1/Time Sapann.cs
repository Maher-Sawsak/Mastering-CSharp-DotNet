using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Time_Span
{
    internal class TimeSpann
    {
        static void Main(string[] args)
        {

            DateTime d = new DateTime(2026,02,12);

            TimeSpan ts = new TimeSpan(25, 5, 30);


            //it will return how much remain after calculating the day.
            Console.WriteLine(ts);
            Console.WriteLine(ts.Days);
            Console.WriteLine(ts.Minutes);
            Console.WriteLine(ts.Hours);//1 hours like 24 -25 =1



            //new date storing the d + time span ts
            DateTime newDate = d.Add(ts);
            Console.WriteLine(newDate);



            Console.ReadKey();

        }
    }
}
