using System;

namespace TextExercise3
{
    class Program
    {
		/// <summary>
        /// Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
        /// A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, 
        /// display "Invalid Time". If the user doesn't provide any values, consider it as invalid time. 
        /// </summary>

        static void Main(string[] args)
        {
			Console.Write("Enter a time value in the 24-hour time format: ");
			var input = Console.ReadLine();

			if (String.IsNullOrWhiteSpace(input))
			{
				Console.WriteLine("Invalid Time");
                return;
			}
				
			var components = input.Split(':');
			if (components.Length != 2)
			{
				Console.WriteLine("Invalid Time");
				return;
			}



			var hour = Convert.ToInt32(components[0]);
			var minutes = Convert.ToInt32(components[1]);

            if (hour < 24 && minutes < 60)
			{
				Console.WriteLine("Ok");
			}
			else
				Console.WriteLine("Invalid Time");


		}
    }
}
