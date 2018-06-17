using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
			Customer customer = new Customer("Richie", "Wong");
			customer.ReturnName();

			Customer customer2 = new Customer();
			customer2.ReturnName();
        }
    }

    class Customer
	{

		public string FirstName;
		public string LastName;

        public Customer()
			:this("Test First Name ", "Test Last Name ")
		{

		}

		public Customer(string firstName, string lastName)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
		}

        public void ReturnName()
		{
			Console.WriteLine("Full Name {0}", this.FirstName + " " + this.LastName);
		}
	}
}
