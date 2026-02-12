using System;
using System.Collections.Specialized;
using System.Reflection;

namespace Main
{
    internal class Program
    {

        static void Main(string[] args)
        {


            string S1 = "Maher Nezar Sawsak" ;

            Console.WriteLine(S1.Length);

            //this will take 5 characters staring position 2
            Console.WriteLine(S1.Substring(2, 5));
            Console.WriteLine(S1.ToLower());
            Console.WriteLine(S1.ToUpper());
            Console.WriteLine(S1[2]);
            Console.WriteLine(S1.Insert(3, "KKKK"));
            Console.WriteLine(S1.Replace("m", "*"));
            Console.WriteLine(S1.IndexOf("m"));
            Console.WriteLine(S1.Contains("m"));
            Console.WriteLine(S1.Contains("x"));
            Console.WriteLine(S1.LastIndexOf("m"));

            string S2 = "Maher,Nezar,Sawsak";

            //the split function its same that I created before in MyStringLib .
            
         //. you cant set the size for array here cuz its in heap noot in stack like C++ so
         //the NameList is not the array its the pointer or the key to the heap.
         //Split method will make the array in the heap and i can access it by NameList Key/pointer here
            
            string[] NamesList = S2.Split(',');


            Console.WriteLine(NamesList[0]);
            Console.WriteLine(NamesList[1]);
            Console.WriteLine(NamesList[2]);


            Console.Write("\n  Trim Part  \n");
            string S3 = "  Sawsak ";
            Console.WriteLine(S3.Trim());
            Console.WriteLine(S3.TrimStart());
            Console.WriteLine(S3.TrimEnd());
    

            //$ to identify an interpolated string

            string FirstName = "Maher";
            string FatherNmae = "Nezar";
            string LastNmae = "Sawsak";


            string FullName = $"First Name : {FirstName}   LastName :  {LastNmae}" ;
            Console.WriteLine(FullName);

            Console.ReadKey();

        }
    }
}
