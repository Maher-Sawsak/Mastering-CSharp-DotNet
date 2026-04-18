namespace Parameterized_Constructor
{
    class clsPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        

        public clsPerson(int ID , string Name , int Age){

            this.Id = ID;
            this.Name = Name;
            this.Age = Age;        
        }


    }



    internal class Program
    {
        static void Main(string[] args)
        {

            clsPerson Person1 = new clsPerson(10, "Maher Sawsak", 21);

            Console.WriteLine(Person1.Id);
            Console.WriteLine(Person1.Name);
            Console.WriteLine(Person1.Age);

        }
    }
}
