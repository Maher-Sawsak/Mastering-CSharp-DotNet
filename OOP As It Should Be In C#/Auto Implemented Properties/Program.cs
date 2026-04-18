namespace Auto_Implemented_Properties
{

//So Auto implemented properties are helpful,
//when you don't think you need any validation, computation or any implementation.

    class clsEmployee {

        //here i gave a value for the ID and its Read-Only.
        public int ID { get; } = 3;


        public string Name { set; get; }

    }

       
    internal class Program
    {
        static void Main(string[] args)
        {
            clsEmployee Emp = new clsEmployee();

            //u can't do that cuz its read only .
            //Emp.ID = 3;

            Emp.Name = "Maher";

            Console.WriteLine("Name For Employee {0}" , Emp.Name);
            Console.WriteLine("ID For Employee {0}" , Emp.ID);
        }
    }
}
