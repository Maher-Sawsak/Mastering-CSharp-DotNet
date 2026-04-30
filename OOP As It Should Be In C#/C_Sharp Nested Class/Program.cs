namespace C_Sharp_Nested_Class
{

    public class clsOuter
    {

        public int outerVariable;

        public void OuterMethod()
        {

            Console.WriteLine("hi, I'm the outer class");

        }


        public class clsInner
        {

            public int innerVariable;


            public void InnerClass()
            {
                Console.WriteLine("The value for INNER from inner is: " + this.innerVariable);
            }

            public void OuterFromInner(clsOuter ObjOuter)
            {
                Console.WriteLine("The Value for outer is  : " +ObjOuter.outerVariable);
            }

        }

    } 





    internal class Program
    {
        static void Main(string[] args)
        {
          clsOuter.clsInner A1 = new clsOuter.clsInner();

            A1.innerVariable = 2;

            A1.InnerClass();
            
            clsOuter outerobj = new clsOuter();

            outerobj.outerVariable = 30;
            outerobj.OuterMethod();

            A1.OuterFromInner(outerobj);
        }
    }
}
