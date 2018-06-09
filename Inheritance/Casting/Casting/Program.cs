using System;
using System.IO;

namespace Casting
{
	class Program
    {
		static void Main(string[] args)
		{

			// UPCASTING
			//Text text = new Text();
			//Shape shape = text;
           

            // DOWNCASTING
			Shape shape = new Text();
			if (shape is Text)
			{
				Text text = (Text)shape;
			}



		}
    }
}
