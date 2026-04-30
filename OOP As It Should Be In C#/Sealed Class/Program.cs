namespace Sealed_Class
{


  public sealed class clsPassword {

        public string SystemPassword =  "EWE22";

        public void AccountPass() {
            Console.WriteLine("The Passord for all is EWE22");        }
    
    }


    public class clsB { 
    
        public virtual void Greets(){

            Console.WriteLine("Hello from B");
        }
    }
    public class clsA : clsB
    {


       // Sealed Method it prevent the override from now and so on.
        public sealed override void Greets() {

            Console.WriteLine("Hello , I hope u doing well");
        }

        public string GetValue()
        {
            return "Maher Sawsak Learning Sealed Class";
        }


    }


    /// <summary>
    /// /it will give an error u can't do that check and debuge the code 
   ///to understand how ot work well.
    /// </summary>
    //public class clsV : clsA{

    //    public override void Greets() { 
        
    //    }
    
    //}







    //u can inherat this class clsPassword cuz its sealed class.
    //public class clsA : clsPassword{ 
    
    //    public string GetValue(){
    //        return 120;
    //    }

    //}



    internal class Program
    {
        static void Main(string[] args)
        {

            clsA  s = new clsA();

            s.GetValue();
            //u can use it in the code but u can't inhearted for onther class.
            clsPassword s2 = new clsPassword();

            s2.AccountPass();
             
        }
    }
}
