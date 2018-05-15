using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
			//var a = 10;
			//var b = 3;
			//Console.WriteLine(a / b);


			// FLOATING POINT NUMBERS
			//var a = 10;
			//var b = 3;
			//Console.WriteLine((float)a / (float)b);


			// OPERATOR PRECEDENCE
			//var a = 1;
			//var b = 2;
			//var c = 3;
			//Console.WriteLine(a + b * c);


			//// COMPARION OPERATORS -> GIVES BOOLEAN VALUE
			//var a = 1;
			//var b = 2;
			//Console.WriteLine(!(a != b)); // CONVERT TWO NEGATIVEES(!) TO POSITIVE --> (a == b)

			// LOGICAL OPERATORS
			var a = 1;
			var b = 2;
			var c = 3;
			Console.WriteLine(c > b && c > a);
        }
    }
}
