using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
			var fullName = "Richie Wong ";

			// Trim() -> ELIMINATES WHITE SPACES
			Console.WriteLine("Trim: '{0}'", fullName.Trim());

			// ToUpper()
			Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            // SPLITING NAMES
			var index = fullName.IndexOf(' ');
			var firstName = fullName.Substring(0, index);
			var lastName = fullName.Substring(index + 1);
			Console.WriteLine("First Name: " + firstName);
			Console.WriteLine("Last Name: " + lastName);

			// Split() --> TURNS IN STRING ARRAY
			var names = fullName.Split(' ');
			Console.WriteLine("First Name: " + names[0]);
            Console.WriteLine("Last Name: " + names[1]);

			// Replace()
			Console.WriteLine(fullName.Replace("Richie", "Rich"));

			// VALIDATIONS
			//if (String.IsNullOrEmpty(" ".Trim()))

			if (String.IsNullOrWhiteSpace(" "))
				Console.WriteLine("Invalid");

			// CONVERT TO NUMBER
			var str = "25";
			var age = Convert.ToByte(str);
            Console.WriteLine(age);
            
			// CONVERT TO STRING
			float price = 29.95f;
			Console.WriteLine(price.ToString("C"));
			Console.WriteLine(price.ToString("C0"));

		}
    }
}
