using System;

namespace Delegates
{
	public class MyClass
    {
		public delegate void CallBackDelegate(int i);

        public void LongRunning(CallBackDelegate obj)
        {
            for (int i = 0; i < 100; i++)
            {
				// Does something
				obj(i);
            }
        }
    }


    class Program
    { 
        static void Main(string[] args)
        {
			MyClass obj = new MyClass();
			obj.LongRunning(CallbackMethod);
        }

        static void CallbackMethod(int i)
		{
			Console.WriteLine(i);
		}

    }  
}
