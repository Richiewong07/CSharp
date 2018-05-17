using System;

namespace ReferenceAndValueTypes
{
    public class Person
	{
		public int Age;
	}


    class Program
    {
		static void Main(string[] args)
		{
			var number = 1;
			Increment(number);
            Console.WriteLine(number); // 1

			var person = new Person() { Age = 20 };
			MakeOld(person);
			Console.WriteLine(person.Age); // 30
		}


		public static void Increment(int number)
		{
			number += 10;
            Console.WriteLine(number); // 11
		}


        public static void MakeOld(Person person)
		{
			person.Age += 10;
            
		}

        

       
			//// VALUE TYPES
			//var a = 10;
			//var b = a;
			//b++;
			//Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));
            
			//// REFERENCE TYPES
			//var arr1 = new int[3] { 1, 2, 3 };
			//var arr2 = arr1;
			//arr2[0] = 0;
			//Console.WriteLine(string.Format("arr1[0]: {0}, arr2[0]: {1}", arr1[0], arr2[0]));


    }
}
