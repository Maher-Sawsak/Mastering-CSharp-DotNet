using Static_Properties___Static_Class;

namespace Static_Properties___Static_Class
{
    //here is the static class clsSettings
    static class clsSettings { 

        public static int DayNumber {

            get {
                return DateTime.Today.Day;

            }
        } 


        public static string DayName {

            get
            {
                //today will return full date with time 
               return DateTime.Today.DayOfWeek.ToString();
            }
        
        }


        }

}



    internal class Program
    {
        static void Main(string[] args)
        {
        //u can't create an aboject because the class is static remember class level
        //clsSettings ir = new clsSettings();


        Console.WriteLine("Today Name :{0} ", clsSettings.DayName);

        Console.WriteLine("Today Number  :{0}", clsSettings.DayNumber);




    }
}
