using System;

namespace Methods
{
	partial class Program
    {

        static void Main(string[] args)
        {
			//try
			//{
			//	var number = int.Parse("abc");
			//}
			//catch (Exception ex)
			//{
			//	Console.WriteLine("Conversion Failed");
			//}


            // OUT MODIFIER
			int number;
			var result = int.TryParse("abc", out number);
            if (result)
				Console.WriteLine(number);
			else
				Console.WriteLine("Conversion Failed");
                         
		}


        static void UseParams()
		{
			var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4 }));
		}


        static void UsePoints()
		{
			// GLOBAL EXCEPTION HANDLING
			try
            {
                var point = new Point(10, 20);

                // TAKES POINT OBJECT
                point.Move(new Point(40, 60));
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                // TAKES X AND Y
                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexcepted error occured");
            }
		}
    }
}
