using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Program.cs
/// June 21, 2021
/// Written by Taylor Dauphinee
/// A program that plays the game fizzbuzz
/// </summary>

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 1, end = 100; // These values can be changed if necessary

            // run the game from start to end
            for (int i = start; i <= end; i++)
            {
                string output = "";

                if (i % 3 == 0)
                {
                    output += "Fizz";
                }
                if (i % 5 == 0)
                {
                    output += "Buzz";
                }
                if (output == "")
                {
                    output += i.ToString();
                }
                Console.WriteLine(output);
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey(true);
        }
    }
}
