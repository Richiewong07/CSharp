using System;
using System.IO;

namespace FileExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
			var path = "/Users/richiewong/Documents/CSharp/Exercises/FileExercise1/FileExercise1/SampleText.txt";

			var words = File.ReadAllText(path).Split(' ');

			var count = 0;
			var longestWord = "";


			foreach(var word in words)
			{
				count++;

                if (word.Length > longestWord.Length)
				{
					longestWord = word;
				}
			}
            
			Console.WriteLine("Word Count: " + count);
			Console.WriteLine("Longest Word: " + longestWord);





		}
    }
}
