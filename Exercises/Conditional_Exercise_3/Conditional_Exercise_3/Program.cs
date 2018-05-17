using System;

namespace Conditional_Exercise_3
{

	class Program
    {
        static void Main(string[] args)
        {
			/// <summary>
            /// Write a program and ask the user to enter the width and height of an image. Then tell if the image 
            /// is landscape or portrait.
            /// </summary>

			Console.Write("Enter a width: ");
			var width = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter a height: ");
            var height = Convert.ToInt32(Console.ReadLine());

			var orientation = width > height ? ImageOrientation.Portait : ImageOrientation.Landscape;
			Console.WriteLine("The image orientation is a: " + orientation);

		}
    }
}
