using System;
using System.Diagnostics;

namespace StopwatchExercise
{
	class Program
    {
		private const string UserPromptMessage = "Enter 's to start the stopwatch, 'st' to stop it, 'd' to see the total duration, 'r' to reset it, and 'x to exit.";

        static void Main(string[] args)
        {
			var stopWatch = new Stopwatch();
			var keepRunning = true;
			Console.Clear();
            
            while (keepRunning)
			{
				Console.WriteLine(UserPromptMessage);
				var input = Console.ReadLine();

                switch(input.ToLower())
				{
					case "s":
						try
						{
							stopWatch.Start();
							Console.WriteLine("Stopwatch has started.");
                            Console.WriteLine();
						}
						catch (Exception ex)
						{
                            Console.WriteLine(ex.Message);
						}
						break;

					case "st":
						try
						{
							stopWatch.Stop();
                            Console.WriteLine("Stopwatch has stopped.");
                            Console.WriteLine();
						}
						catch (Exception ex)
						{
							Console.WriteLine(ex.Message);
						}
						break;
                        
					case "d":
						Console.WriteLine("The total duration the stopwatch has been running is:" + stopWatch.Duration);
                        Console.WriteLine();
						break;

                    case "r":
						stopWatch.Reset();
						Console.WriteLine("Stopwatch has reset.");
                        Console.WriteLine();
						break;

					case "x":
						Console.WriteLine("Exiting the Application.");
						keepRunning = false;
						break;
					default:
						Console.WriteLine("Invalid input");
                        Console.WriteLine();
						break;
				}
			}
			Console.ReadKey();

        }
    }
}
