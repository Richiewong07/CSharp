using System;
using System.Collections.Generic;

namespace DelegatesExample
{
    class Program
    {
        static void Main(string[] args)
        {
			List<Employee> empList = new List<Employee>();

			empList.Add(new Employee() { ID = 101, Name = "Mary", Salary = 5000, Experience = 5 });
			empList.Add(new Employee() { ID = 202, Name = "John", Salary = 4000, Experience = 4 });
			empList.Add(new Employee() { ID = 303, Name = "Mike", Salary = 3000, Experience = 3 });

			IsPromotable isPromotable = new IsPromotable(Promote);
			Employee.PromoteEmployee(empList, isPromotable);
        }

        public static bool Promote(Employee emp)
		{
			if(emp.Experience >= 5)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
    }

    // Delegate that takes in boolean of Employee object
	public delegate bool IsPromotable(Employee emp1);

    public class Employee
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public int Salary { get; set; }
		public int Experience { get; set; }
        

		public static void PromoteEmployee(List<Employee> employeelist, IsPromotable IsEligibleToPromote)
		{
			foreach(Employee employee in employeelist)
			{
				// Delegate passed as parameter and used as logic
				if(IsEligibleToPromote(employee))
				{
					Console.WriteLine(employee.Name + " promoted");
				}
			}
		}
	}
}
