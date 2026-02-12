using System;

public class Program
{
    public static void Main()
    {
        // 1. Valid date string
        string goodInput = "2026-02-12";

        // 2. Invalid string
        string badInput = "Not a Date";

       
        DateTime result;

        Console.WriteLine("--- Testing Good Input ---");

        // If (TryParse) returns true, ::::result::: will be filled with the date
        if (DateTime.TryParse(goodInput, out result))
        {
            Console.WriteLine("Success! Date is: " + result.AddDays(350));
            Console.WriteLine("Day of week: " + result.DayOfWeek);
        }
        else
        {
            Console.WriteLine("\n\nConversion failed!");
        }

        Console.WriteLine("\n--- Testing Bad Input ---");

        // This will return 'false' and the program will NOT crash
        //Note : TryParse it return true or false if parse it will throw an exception not return bool.
        if (DateTime.TryParse(badInput, out result))
        {
            Console.WriteLine("Success!");
        }
        else
        {
            Console.WriteLine("Error: '" + badInput + "' is not a valid date.");
        }
    }
}