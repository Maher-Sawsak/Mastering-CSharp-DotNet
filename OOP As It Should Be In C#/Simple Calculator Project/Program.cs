using System.Security.Claims;
using System.Xml.Serialization;

namespace Simple_Calculator_Project { 

    //The tiny project here just to apply the Encapsulation and Abstraction Concepts only
    class clsCalculator { 

    private static decimal _Result;


    public void Add(decimal Number)
    {
        _Result += Number;

    }

    public void Subtract(decimal Number) {

        _Result -= Number;   
    
    }

    public  void Multiply(decimal Number) {

        _Result *= Number;
    
    }

    public void Divide(decimal Number) {


        if (Number == 0)
        {

            _Result /= 1;

        }
        else {
            _Result /= Number;
        
        }
    
    }


    public void PrintResult() {

            Console.WriteLine(_Result);
    }

        public decimal GetResult() {
            return _Result;
        
        }

    public void Clear() {

            _Result = 0;    
    }


}



    internal class Program
    {
        static void Main(string[] args)
        {
            clsCalculator Calculator1 = new clsCalculator ();



            Calculator1.Clear();
            Calculator1.PrintResult();

            Calculator1.Add(10);
            Calculator1.PrintResult();

            Calculator1.Add(100);
            Calculator1.PrintResult();

            Calculator1.Subtract(20);
            Calculator1.PrintResult();

            Calculator1.Divide(0);
            Calculator1.PrintResult();

            Calculator1.Divide(2);
            Calculator1.PrintResult();


            Calculator1.Multiply(3);
            Calculator1.PrintResult();


            Calculator1.Clear();
            Calculator1.PrintResult();

        }
    
    
    
    
    }
}
