using System;
using System.Collections.Generic;
using System.Linq;

namespace TypeInferenceDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            // very very impotant Note :::: the var must initialized with value if not the compiler will gave an error

            var employeeName = "John Doe";
            var employeeId = 1024;
            var hourlyRate = 45.50;
            var isActive = true;

            Console.WriteLine($"Name: {employeeName} | ID: {employeeId} | Rate: {hourlyRate} | Active: {isActive}");
            Console.WriteLine(new string('-', 50));

            // 2. Complex Collections
            var projects = new List<string> { "Alpha", "Beta", "Gamma", "Delta" };
            projects.Add("Omega");

            Console.WriteLine("Project List:");
            foreach (var project in projects)
            {
                Console.WriteLine($" - Project: {project}");
            }
            Console.WriteLine(new string('-', 50));

            // 3. LINQ & Anonymous Types (Where var is most powerful)
            var searchResults = projects
                                .Where(p => p.Length > 4)
                                .Select(p => new
                                {
                                    ProjectName = p.ToUpper(),
                                    Timestamp = DateTime.Now
                                });

            Console.WriteLine("Filtered Project Data:");
            foreach (var item in searchResults)
            {
                // The compiler knows 'item' has 'ProjectName' and 'Timestamp' properties
                Console.WriteLine($"Target: {item.ProjectName} | Processed: {item.Timestamp}");
            }

            // Note: Once inferred, types are fixed. 
            // employeeName = 500; // This would cause a compile-time error.

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}