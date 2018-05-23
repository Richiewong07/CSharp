using System;
using System.Collections.Generic;

namespace TextExercise5
{
    class Program
    {
		/// <summary>
        /// Write a program and ask the user to enter an English word. Count the number of vowels 
        /// (a, e, o, u, i) in the word. So, if the user enters "inadequate", the program should display 
        /// 6 on the console. Make sure the program calculates the number of vowels irrespective of the 
        /// casing of the word (eg "Inadequate", "inadequate" and "INADEQUATE" all include 6 vowels).
        /// </summary>

        static void Main(string[] args)
        {
			Console.Write("Enter an English word: ");
			var input = Console.ReadLine().ToLower();

			var vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };
            
			var vowelsCount = 0;

            foreach(var character in input)
			{
				if (vowels.Contains(character))
					vowelsCount++;
			}
            Console.WriteLine(vowelsCount);
		}
    }
}
