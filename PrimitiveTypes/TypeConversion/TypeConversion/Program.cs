using System;

namespace TypeConversion
{
	class Program
	{
		static void Main(string[] args)
		{
			//  IMPLICIT TYPE CONVERSION
			//byte b = 1;
			//int i = b;
			//Console.WriteLine(i);


			//  EXPLICIT TYPE CONVERSION W/ CAST
			//int i = 1;
			//byte b = (byte) i;
			//Console.WriteLine(b);


			//  EXPLICIT TYPE CONVERSION W/ DATA LOST
			//int i = 1000;
			//byte b = (byte) i
			//Console.WriteLine(b);


			//  NON COMPATIBLE TYPE CONVERSION
			//var number = "1234";
			//int i = Convert.ToInt32(number);
			//Console.WriteLine(i);


			// HANDLING EXCEPTIONS --> System.OverflowException
			//        try
			//	{
			//		var number = "1234";
			//              byte b = Convert.ToByte(number);
			//              Console.WriteLine(b);
			//	}
			//	catch (Exception)
			//	{
			//            Console.WriteLine("The number could not be converted to a byte.");
			//	}

			//}

			try
			{
				string str = "true";
				bool b = Convert.ToBoolean(str);
				Console.WriteLine(b);

			}
			catch (Exception)
			{
				Console.WriteLine("The string could not be converted to a byte.");
			}
		}
	}
}