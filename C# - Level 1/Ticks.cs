using System;

class TicksExample
{
    static void Main()
    {

        // Record the starting Ticks (Current time in 100-nanosecond intervals)
        long startTicks = DateTime.Now.Ticks;
        Console.WriteLine($"Start Time (Ticks): {startTicks}");

        // Simulate a small workload: A loop running 1 million times
        long sum = 0;
        for (int i = 0; i < 1_000_000; i++)
        {
            sum += i;
        }

        // Record the ending Ticks
        long endTicks = DateTime.Now.Ticks;
        Console.WriteLine($"End Time (Ticks):   {endTicks}");

        // Calculate the difference
        long elapsedTicks = endTicks - startTicks;

        // Convert Ticks to Milliseconds (1 ms = 10,000 ticks)
        double elapsedMilliseconds = (double)elapsedTicks / 10000;

        Console.WriteLine("\n--- Performance Results ---");
        Console.WriteLine($"Elapsed Ticks: {elapsedTicks}");
        Console.WriteLine($"Elapsed Milliseconds: {elapsedMilliseconds} ms");


        // --- 2. CONVERTING A LARGE TICK NUMBER TO A DATE ---

        // Let's take a random large Tick number (e.g., from a database)
        long mysteryTicks = 638435136000000000;

        // Convert the long number back into a DateTime object
        DateTime convertedDate = new DateTime(mysteryTicks);

        Console.WriteLine("\n--- Conversion Example ---");
        Console.WriteLine($"The Date for {mysteryTicks} is: {convertedDate.ToString("yyyy-MM-dd HH:mm:ss")}");

 
    }
}