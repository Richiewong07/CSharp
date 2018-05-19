using System;

namespace ListsArraysExercise2
{
    class Program
    {
		/// <summary>
        /// Ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. 
        /// Display the reversed name on the console.
        /// </summary>

        static void Main(string[] args)
        {
			
			//Console.Write("What is your name: ");
			//var name = Console.ReadLine();
			//var array = new char[name.Length];


			//for (var i = name.Length; i > 0; i--)
			//{
			//	array[name.Length - i] = name[i - 1];
			//}
			//var reversed = new string(array);

			//Console.WriteLine("Reversed name: " + reversed);



			Console.Write("What is your name: ");
			var name = Console.ReadLine().ToCharArray();

            Array.Reverse(name);

            var reverse = new string(name);

			Console.WriteLine("Reversed name: " + reverse);

		}
    }
}
