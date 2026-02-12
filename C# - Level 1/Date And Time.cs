using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date___Time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //it will give the default date & time ::: 1/1/0001 12:00:00 AM ::: .
            DateTime dt = new DateTime();
            Console.WriteLine(dt);

            //I can also assign the date like here.
            dt = new DateTime(2026,01,27);
            Console.WriteLine(dt);

            //I can also assign the date & time // it will convert 23 to 11 for hours.
            dt = new DateTime(2026, 01, 27,23,00,59);
            Console.WriteLine(dt);

            //assigns year, month, day, hour, min, seconds, UTC timezone
            DateTime dt3 = new DateTime(2026, 12, 31, 5, 10, 20, DateTimeKind.Utc);
            Console.WriteLine(dt3);

            DateTime dt4 = new DateTime(2026, 12, 31, 5, 10, 20, DateTimeKind.Local);
            Console.WriteLine(dt4);

            DateTime CurrentDate = new DateTime();
            CurrentDate = DateTime.Now;
            Console.WriteLine(CurrentDate);


        }

    }
}
