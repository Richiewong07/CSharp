using System;
using System.Collections.Generic;

namespace TextExercise1
{
    class Program
    {
		/// <summary>
        /// Write a program and ask the user to enter a few numbers separated by a hyphen. Work out 
        /// if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", 
        /// display a message: "Consecutive"; otherwise, display "Not Consecutive".
        /// </summary>

        static void Main(string[] args)
        {   
			// ASK USER FOR NUMBERS
			Console.Write("Enter a few numbers separated by a hyphen: ");
			var input = Console.ReadLine();

			// CREATE NEW LIST TO STORE NUMBER ONCE SPLIT
			var numbers = new List<int>();

            // SPILT STRING OF NUMBERS AND CONVERT THEM TO INTERGERS
			foreach (var number in input.Split('-'))
				numbers.Add(Convert.ToInt32(number));
            
            // SORT LIST OF NUMBERS 
			numbers.Sort();

			var isConsecutive = true;

            // LOOP THROUGH LIST --> CHECK IF INITIAL VALUE IS 1 LESS THAN NEXT VALUE
			for (var i = 1; i < numbers.Count; i++)
			{
				if (numbers[i] != numbers[i - 1] + 1)
					isConsecutive = false;
				    break;
			}
            
			var message = isConsecutive ? "Consecutive" : "Not Consecutive";
            Console.WriteLine(message);




		}
    }
}
