using System.Security.Cryptography;

namespace Static_Members
{

    class clsA {

        public int A1;

        //here its shared in class-level that is mean the A2 u can use it with out 
        //an object and all objects can see it and take ots value 
        //If u want to edit it revalue it u need to edit it by name of the class not object.

       
        public static int A2;


    
        public int Method1(){ 
        
            return A1 + A2;

        }

        public static int Method2() {
            //u can not use non-static inside the static method cuz need an object and the 
            //static method accessed by the class name not object .
            return A2;
        
        }

    
    
    }


    internal class Program
    {
        static void Main(string[] args)
        {



            clsA First = new clsA();

            First.A1 = 5;

            //here u can not access it cuz A2 is static member.
            //First.A2;
            
            //also u  can not access by an object it cuz its static u need to use class name instead of object 
            //First.Method2();
       
           clsA.A2 = 4;
          // clsA.Method2();




            Console.WriteLine($"The Value for A1 is {First.A1}");
            Console.WriteLine($"The Value for A2 is {clsA.A2}");
            Console.WriteLine($"The Value for Method1 is {First.Method1()}");
            Console.WriteLine($"The Value for Method2 is {clsA.Method2()}");


        }
    }
}
