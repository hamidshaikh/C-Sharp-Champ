/*
    Sort a list of Complex type using comparision delegates.
	
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Customer customer1 = new Customer()
			{
				Id = 101,
				Name = "Marry",
				Salary = 5500,
				type = "General Customer"
			};
			
			Customer customer2 = new Customer()
			{
				Id = 102,
				Name = "Mark",
				Salary = 4500,
				type = "General Customer"
			};
			
			Customer customer3 = new Customer()
			{
				Id = 103,
				Name = "John",
				Salary = 7500,
				type = "General Customer"
			};
			
			List<Customer> generalCustomers = new List<Customer>();
			generalCustomers.Add(customer1);
			generalCustomers.Add(customer2);
			generalCustomers.Add(customer3);
			
			Console.WriteLine("Before sorting");
			foreach(Customer c in generalCustomers)
			{
				Console.WriteLine(c.Salary);
			}
			
			generalCustomers.Sort((x, y) => x.Salary.CompareTo(y.Salary));
			Console.WriteLine("After sorting");
			foreach(Customer c in generalCustomers)
			{
				Console.WriteLine(c.Salary);
			}
			
		}
    }
	
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
		public string type { get; set; }
    }
}

/*
	Output :
		Before sorting
		5500
		4500
		7500
		After sorting
		4500
		5500
		7500
*/
