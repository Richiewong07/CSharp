using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
			//var firstName = "Richie";
			//String lastName = "Wong";
			//string myName = "Richie Wong";


			var firstName = "Richie";
			var lastName = "Wong";


			var fullname = firstName + " " + lastName;


			var myFullname = string.Format("My name is {0} {1}", firstName, lastName);


			var names = new string[3] { "John", "Jack", "Mary" };
			var formattedNames = string.Join(",", names);
			Console.WriteLine(formattedNames);

			// VERBATIM STRING
			//var text = "Hi John\nLook into the following paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
			var text = @"Hi John
Look into the following paths
c:\folder1\folder2
c:\folder3\folder4";
            Console.WriteLine(text);
		}
    }
}
