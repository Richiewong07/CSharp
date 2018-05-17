using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
			//for (var i = 1; i < 10; i++)
			//{
			//	if (i % 2 == 0)
			//	{
			//		Console.WriteLine(i);
			//	}
			//}


			//var i = 0;
            //while (i <= 10)
			//{
			//	if (i % 2 == 0)
			//	{
			//		Console.WriteLine(i);
			//	}
			//	i++;
			//}


            while (true)
			{
				Console.Write("Type your name: ");
				var input = Console.ReadLine();

				if (!String.IsNullOrWhiteSpace(input))
				{
					Console.WriteLine("@Echo: " + input);
					continue;
				}

				break;
			}

        }
    }
}
