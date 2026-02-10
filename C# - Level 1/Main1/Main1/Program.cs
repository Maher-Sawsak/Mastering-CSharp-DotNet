
//this is a library.
using System;

class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal");
    }
}

class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog");
    }
    
    static void Main()
    {
        
        Dog d = new Dog();
        d.Speak();
        
    }
}
