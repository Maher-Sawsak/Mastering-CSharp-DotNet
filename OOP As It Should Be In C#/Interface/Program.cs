namespace Interface
{
    //this is an interface
    public interface IPerson{ 
    
        string Name { set; get; }
        string Description { set; get; }

        string SendInfo();
    
        

    }

    //this is an interface 
    public interface ICommiucate {


        void SendEmail();

        void SendPhone(string PhoneNumber , string Country);
        void SendSms();
       
    
    }

    //here is the multiple interfaces not multiple inheritance 
    //Remember : The Multiple Interfaces ( Not Equal ) multiple inheritance 
    public class clsEmployee : IPerson , ICommiucate { 
    
    public string Name { set; get; }
        public string Description { set; get; }

        public string SendInfo() {

            return "Hi, I'm  the Info";
        }

        public void SendEmail() {
            Console.WriteLine("Hi I'm Email");
                    
        }

        public void SendPhone(string Phone , string Country) {

            Console.WriteLine("Phone Calling !!");
        }

        public void  SendSms() {
            Console.WriteLine("This Is Sms Message");        
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {

            clsEmployee Emp1 = new clsEmployee();

            Console.WriteLine(Emp1.SendInfo());

            Emp1.SendSms();
            Emp1.SendPhone("0554325457", "Turkye");
          
        }
    }
}
