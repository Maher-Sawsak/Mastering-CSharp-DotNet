namespace Parameter_less_Constructor
{



    class clsPerson { 
    

        public int ID { get; set;}
        public string Name { get; set; }
        public int Age { get; set; }

        //Parameterless Constructor
        public clsPerson() {

            ID = -10;
            Name = "Maher";
            Age = 21;
        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
        clsPerson Person1 = new clsPerson ();

            Console.WriteLine(Person1.ID);
            Console.WriteLine(Person1.Name);
            Console.WriteLine(Person1.Age);






        }
    }
}
