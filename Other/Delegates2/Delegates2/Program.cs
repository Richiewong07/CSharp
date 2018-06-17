using System;

namespace Delegates2
{
	// This delegate can point to any method with void method type and string parameter
	public delegate void HelloFunctionDelegate(string Message);

    class Program
    {
        static void Main(string[] args)
        {
			// A delegate is a type safe function pointer --> function is invoke when it is pointed at
			HelloFunctionDelegate del = new HelloFunctionDelegate(Hello2);
			del("Hello from Delegate");
        }

        public static void Hello(string strMessage)
		{
			Console.WriteLine("Hello 1 Method " + strMessage);
		}

        public static void Hello2(string strMessage2)
		{
			Console.WriteLine("Hello2 Method " + strMessage2);
		}
    }
}

