using System.Data.SqlTypes;
using System.Net.Cache;

namespace Inheritance___Inheritance_With_Constructor
{

   public class clsPerson
    {
       public clsPerson(int ID , string FirstName, string LastName, int Age, int BirthDate) {
        
            this.Id = ID ;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
            this.Birthday = BirthDate;
        
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Birthday { get; set; }


        //Read Only.
        public string FullName()
        {
            return FirstName + ' ' + LastName;
        }

    }

    class clsEmployee : clsPerson
    {

        public int Salary { set; get; }

        public clsEmployee(int ID, string FirstName, string LastName, int Age, int BirthDate,
                            int Salary) : base (ID , FirstName,LastName, Age,BirthDate)
        {
            this.Salary = Salary;

        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {

            //Derived Class / Sub class.
            clsEmployee Emp = new clsEmployee(10,"Maher", "Sawsak", 22,2005,12000);
            Console.WriteLine($"ID : {Emp.Id} , Name: {Emp.FullName()} ,Salary:  {Emp.Salary}  ");

            //Base Class / Super class / inhertead class
            clsPerson Prs1 = new clsPerson(10,"Ali" , "Romani", 24,2002);
            Console.WriteLine(Prs1.FullName());

        }
    }
}
