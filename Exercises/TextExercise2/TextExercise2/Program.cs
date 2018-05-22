using System;
using System.Collections.Generic;

namespace TextExercise2
{
    class Program
    {
		/// <summary>
        /// Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply 
        /// presses Enter without supplying an input, exit immediately; otherwise, check to see if there are 
        /// any duplicates. If so, display "Duplicate" on the console.
        /// </summary>

        static void Main(string[] args)
        {
			while(true)
			{
				Console.Write("Enter a few numbers separated by a hypehn: ");
                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                    break;

                var numbers = new List<int>();
                foreach (var number in input.Split('-'))
                    numbers.Add(Convert.ToInt32(number));


                var unique = new List<int>();
                var includeDuplicate = false;

                foreach (var number in numbers)
                {
                    if (!unique.Contains(number))
                    {
                        unique.Add(number);
                    }
                    else
                    {
                        includeDuplicate = true;
                        break;
                    }
                }

                if (includeDuplicate)
                    Console.WriteLine("Duplicate");
               
			}

		}
    }
}
