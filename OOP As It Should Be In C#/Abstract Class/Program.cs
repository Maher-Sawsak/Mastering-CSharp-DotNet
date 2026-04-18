using System.Net.Cache;
using System.Runtime.CompilerServices;

namespace Abstract_Class
{
    public abstract class clsPerson {
        public int Id { get; set; }
        public int Age  { set; get; }



        public abstract void FullName();
    
    }

    public class clsEmployee: clsPerson{

        public override void FullName()
        {
            Console.WriteLine("Hi Done For Abstract");
        }
        public void  WorkHours() {
            Console.WriteLine("The Emp Work for 24/H");
        }
    
    } 



    internal class Program
    {
        static void Main(string[] args)
        {

        clsEmployee Emps1 = new clsEmployee();
            Emps1.FullName();

        }
    }
}
