using System;

namespace TextExercise4
{
    class Program
    {
		/// <summary>
        /// Write a program and ask the user to enter a few words separated by a space. Use the words to 
        /// create a variable name with PascalCase convention. For example, if the user types: 
        /// "number of students", display "NumberOfStudents". Make sure the program is not dependent on 
        /// the casing of the input. So if the input is "NUMBER OF STUDENTS", it should still display 
        /// "NumberOfStudents". If the user doesn't supply any words, display "Error".
        /// </summary>

        static void Main(string[] args)
        {
			Console.Write("Enter a few words separated by a space: ");
			var input = Console.ReadLine();

			if (String.IsNullOrWhiteSpace(input))
			{
				Console.WriteLine("Error");
				return;
			}

			var modifiedWord = "";
           
            foreach (var character in input.Split(' '))
			{
				var wordWithPascalCase = char.ToUpper(character[0]) + character.ToLower().Substring(1);
				modifiedWord += wordWithPascalCase;
			}

            Console.WriteLine(modifiedWord);

            

		}
    }
}
