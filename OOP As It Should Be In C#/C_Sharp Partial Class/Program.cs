namespace C_Sharp_Partial_Class
{
       internal class Program
    {
        static void Main(string[] args)
        {

            clsMyClass Obj = new clsMyClass();
           //here from the second file 
            Obj.Method1();

            //here is from the third file
            Obj.Method2();

        }
    }
}
