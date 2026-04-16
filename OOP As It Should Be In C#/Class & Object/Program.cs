using System.Security;

namespace Class___Object
{

    class clsPerson {

        public string FirstName  = string.Empty;
        public string LastName  = string.Empty;
        public string FullName() {

            return FirstName + ' ' + LastName;

        }
    
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            clsPerson Person1 = new clsPerson();


            Console.WriteLine("The First (Person1) : ");
            Person1.FirstName = "Maher";
            Person1.LastName = "Sawsak";
            Console.WriteLine($"First Name  : {Person1.FullName()}");


            Console.WriteLine("\n\nThe Second (Person2)");
            clsPerson Person2 = new clsPerson();
            Person2.FirstName = "Ali";
            Person2.LastName = "Sawsak";
            Console.WriteLine($"Full Name  : {Person2.FullName()}");

        }
    }
}