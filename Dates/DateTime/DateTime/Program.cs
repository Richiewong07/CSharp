using System;

namespace Datetime
{
    class Program
    {
        static void Main(string[] args)
        {
			var datetime = new DateTime(2018, 5, 20);
			var now = DateTime.Now;
			var today = DateTime.Today;

			//Console.WriteLine("Hour: " + now.Hour);
			//Console.WriteLine("Minute: " + now.Minute);

			var tomorrow = now.AddDays(1);
			var yesterday = now.AddDays(-1);

			Console.WriteLine("To Long Date String: " + now.ToLongDateString());
			Console.WriteLine("To Short Date String: " + now.ToShortDateString());
			Console.WriteLine("To Long Time String: " + now.ToLongTimeString());
			Console.WriteLine("To Short Time String: " + now.ToShortTimeString());
			Console.WriteLine("To Both Date and Time: " + now.ToString("yyyy-MM-dd HH:mm"));
		}
    }
}
