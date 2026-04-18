namespace Properties_Set_and_Get
{
    class clsEmployee { 
    
    private string  _Name;

    private int _Age;


        public int Age{

         set {
                //when he will assign a value to _ Age will add 10 additional.
                _Age = value + 10;
            }


        get {

                return _Age ;
            
        }
                  
    }



        public string Name
        {
            set {
                _Name = value;
            }
            get {
                return _Name;
            }
        
        }


    
    
 }



    internal class Program
    {
        static void Main(string[] args)
        {

            clsEmployee Emp = new clsEmployee();

            Emp.Age = 20;
            Emp.Name = "Maher";


            Console.WriteLine($"Employee Name: {Emp.Name}");

            Console.WriteLine($"Employee Age: {Emp.Age}");


        }
    }
}
