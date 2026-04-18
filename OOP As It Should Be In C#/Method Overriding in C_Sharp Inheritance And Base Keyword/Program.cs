namespace Method_Overriding_in_C_Sharp_Inheritance_And_Base_Keyword
{

    public class clsA
    {

        public virtual void Print()
        {

            Console.WriteLine("I am Class A ");
        }
        public virtual void Print2()
        {
            Console.WriteLine("I am Class A with new");


        }

        public class clsB : clsA
        {

            public override void Print()
            {

                Console.WriteLine("I am Class B, The below is also from clsB but from base clsA");

             
            }


            public new void Print2()
            {
                Console.WriteLine("I am Class B with new");
            }

        }




        internal class Program
        {
            static void Main(string[] args)
            {


                ////Test the diff between the overriding and new (shadowing)/Hiding.
                //clsA ObjA = new clsA();

                //ObjA.Print();
                //ObjA.Print2();

                //clsB ObjB = new clsB();

                //ObjB.Print();
                //ObjB.Print2();




                // 1. ننشئ كائن من الابن
                clsB myObj = new clsB();

                // efrece from the parent point to the child.
                clsA upcastedObj = myObj; 

                upcastedObj.Print();  //Override
                upcastedObj.Print2(); //by new


            }
        }
    }
}
