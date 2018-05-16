using System;
using CSharpFundamentals.Math;

namespace CSharpFundamentals
{


	class Program
    {
        static void Main(string[] args)
        {
			var john = new Person();
			john.FirstName = "John";
			john.LastName = "Smith";
			john.Introduce();

			var calculator = new Calculator();
			var result = calculator.Add(1, 2);
            Console.WriteLine(result);
		}
    }
}
