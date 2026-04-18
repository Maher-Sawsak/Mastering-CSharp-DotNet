namespace Application_of_Using_Static_and_Constructors_
{


     class clsEmployee {


        public int ID { set; get; }
        public int Age { set; get; }
        public string Name { set; get; }

        //here is the paramerized constructor
        public clsEmployee(int ID , string Name, int Age) {
            this.ID = ID;
            this.Name = Name;   
            this.Age = Age;
                   
        }





        //Overloading for Find
        public static clsEmployee Find(int ID) {

            if (ID == 10)
            {
                //here it will return an object with fully data
                return new clsEmployee(10, "Maher Sawsak", 21);
            }
            else {
                return null;
            
            }
        
        }


        public static clsEmployee Find(string UserName, string Password) {

            if (UserName == "Ma123" && Password == "123123")
            {
                //if found it will return the object with full data.
                return new clsEmployee(10, "Ali Sawsak", 23);
            }
            else {
                //if the find didn't found find any will return null not object.
                return null;
            }
        
        
        }


    }





    internal class Program
    {
        static void Main(string[] args)
        {

            //clsEmployee Emp1 = new clsEmployee(10,"SOSO",20);

            //this line is wrong u can't use the static with object 
            //Emp1.Find(10);


            //here is wrong Why ? 
            //cuz the Find it will return null for value11) so there is no object
            //and  want to get value of Emp1 and there is no object so that is it.
            // clsEmployee Emp1 = clsEmployee.Find(11);
            // Console.WriteLine(Emp1.Name); 




            //very important !!
            //why there is no new keyword here ????
            //cuz the find will make an object if the id found and it will return it to us.
            //if u write new means that u have an object u don't need the find .
            clsEmployee Emp2 = clsEmployee.Find(10);
            if (Emp2 != null)
            {
                Console.WriteLine(Emp2.ID);
                Console.WriteLine(Emp2.Name);
                Console.WriteLine(Emp2.Age);
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }





        }
    }
}
