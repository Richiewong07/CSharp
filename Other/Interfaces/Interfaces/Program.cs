using System;

namespace Interfaces
{
	interface ICustomer1
	{
		// Only declarations no implementations
		void Print1();
	}

	interface ICustomer2 : ICustomer1
	{
		void Print2();
	}


	public class Customer : ICustomer2
	{
		
		// Class must provide implementations for ALL interfaces
		public void Print1()
		{
			Console.WriteLine("Interface Print Method");
		}

		public void Print2()
        {
            Console.WriteLine("Print2");
		}
	}


	class Program
    {
        static void Main(string[] args)
        {
			ICustomer1 Cust = new Customer();
			Cust.Print1();
            
			Customer c1 = new Customer();
			c1.Print1();
			c1.Print2()
        }
    }
}
