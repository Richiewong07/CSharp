using System;

namespace Conditional_Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
			/// <summary>
			/// Write a program which takes two numbers from the console and displays the maximum of the two.
			/// </summary>

			Console.WriteLine("Enter a number: ");
			var number1 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter another number: ");
			var number2 = Convert.ToInt32(Console.ReadLine());

			var max = (number1 > number2) ? number1 : number2;
			Console.WriteLine("The max number is: " + max);

		}
    }
}
