using System;


public partial class clsMyClass {

    public int Age { set; get; }

    public void Method1() {

        Console.WriteLine("I am Method 1");
    }
    partial void PrintAge();
    public void Birthday()
    {
        Age++;
        PrintAge();
    }

  

}