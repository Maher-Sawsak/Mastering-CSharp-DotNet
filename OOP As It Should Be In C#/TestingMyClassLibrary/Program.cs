using System;
using MyFirstClass;

namespace TestingMyClassLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MyClass Obj = new MyClass();
                      
            Console.WriteLine("The First Result  : "  + Obj.Sum(10, 20));

            Console.WriteLine("The Second Result : " + Obj.Sum(10, 20, 20));

           

        }
    }
}
