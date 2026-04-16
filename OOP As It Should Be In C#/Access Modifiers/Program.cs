namespace Access_Modifiers
{


    /// <summary>
    ///  Remember Note : There are 4 types for the access modifiers in C#
    ///  
    /// public
    ///  private 
    ///  protected 
    ///  internal : The code is only accessible within its own assembly (dll), 
    ///  but not from another assembly. internal is equivalent to friend in c++
    ///  
    /// </summary>




    class clsA
    {

        public int x;
        private int y;
        protected int z;

        public int Fun1()
        {

            return 33;

        }
        private int Fun2()
        {

            return 200;

        }
        protected int Fun3()
        {

            return 300;

        }
    }


    class clsB : clsA {

        public int B1;
        private int B2;
        protected int B3;

        public int fun4()
        {
            //I cannot access any private members of the base class.
            return x + z;
        }
        
    }



        internal class Program
    {
        static void Main(string[] args)
        {
          
            //first object for thw clsA
            clsA Ro = new clsA();
            Ro.x = 101;

            Console.WriteLine(Ro.x);
            //by using the method / Function member
            Console.WriteLine(Ro.Fun1());



            clsB SecondObject = new clsB();
            SecondObject.B1 = 50;
            Console.WriteLine(SecondObject.B1);



        }
    }
}
