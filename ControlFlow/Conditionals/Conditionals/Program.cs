using System;

namespace Conditionals
{
	class Program
    {
        static void Main(string[] args)
        {

			// SWITCH CASE
			var season = Season.Autumn;
            
            switch (season)
			{
				case Season.Autumn:
				case Season.Summer:
					Console.WriteLine("We got a promotion");
					break;

				//case Season.Autumn:
				//	Console.WriteLine("It's autumn and a beatiful season.");
				//	break;
                 
				//case Season.Summer:
					//Console.WriteLine("It's perfect to go to the beach.");
					//break;

				default:
					Console.WriteLine("I don't understand that season!");
					break;
			}


           

			// CONDITIONAL OPERATORS
			//float price = (isGoldCustomer) ? 19.95f : 29.95;
			//Console.WriteLine(price);

			//bool isGoldCustomer = true;

            //float price;

            //if (isGoldCustomer)
            //    price = 19.95f;
            //else
                //price = 29.95f;

           

            // IF/ELSE STATEMENT                             
			//int hour = 10;

			//if (hour > 0 && hour < 12)
			//{
			//	Console.WriteLine("It's morning.");
			//}
			//else if (hour >= 12 && hour < 18)
			//{
			//	Console.WriteLine("It's afternoon.");
			//}
			//else
			//{
			//	Console.WriteLine("It's evening.");
			//}

		}
    }
}
