using System;

namespace Enums
{
    public enum ShippingMethod
	{
		RegularAirMail = 1,
        RegisterAirMail = 2,
        Express = 3
	}

    class Program
    {
        static void Main(string[] args)
        {   
			// CONVERT ENUM TO INTEGER
			var method = ShippingMethod.Express;
            Console.WriteLine((int)method); // NEED TO CAST TO INTERGER
            

            // CASTING TO CONVERT INTEGER TO SHIPPING METHOD
			var methodID = 3;
			Console.WriteLine((ShippingMethod)methodID);

            // CONVERT TO STRING
			Console.WriteLine(method.ToString());


			// CONVERT STRING TO ENUM
			var methodName = "Express";
			var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
		}
    }
}

