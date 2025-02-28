// Example solution for task 1
// Pirkko Sutinen 13.4.2021
// pirkko.sutinen@sasky.fi

using System;

namespace Tehtava1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user for their name
            Console.WriteLine("Mikä sinun nimesi on?");
            string name = Console.ReadLine();

            // Prompt user for their age
            Console.WriteLine("Minä ikäinen olet?");
            string ageInput = Console.ReadLine();

            // Try to parse the input age to an integer
            bool isParsed = int.TryParse(ageInput, out int age);

            if (isParsed)
            {
                // Calculate and display the age in 2031
                Console.WriteLine($"Ajattele {name.ToUpper()}, vuonna 2031 olet jo {age + 10} vuotta vanha");
            }
            else
            {
                // Display error message if age input is not a valid number
                Console.WriteLine("Anna ikä numerona");
            }
        }
    }
}
