using System;

namespace ExplicitInterfaces
{
	interface I1
	{
		void InterfaceMethod();
	}

    interface I2
	{
		void InterfaceMethod();
	}
    
	public class Program : I1, I2
    {
        static void Main(string[] args)
        {
			// Not and object but object reference variable that points to a program in the memory
			I1 i1 = new Program();
			I2 i2 = new Program();

			// Only accessed through interface reference variables, not class reference variables
			// Invokes I1 Interface Method
			i1.InterfaceMethod();

			// Invokes I2 Interface Method
			i2.InterfaceMethod();
        }

        // Explicit Interface Implementation
		void I1.InterfaceMethod()
		{
			Console.WriteLine("I1 Interface Method");
		}

		void I2.InterfaceMethod()
        {
            Console.WriteLine("I2 Interface Method");
        }
	} 
}
