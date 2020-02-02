/*
    Sort a list of Complex type.
	
	To sort a list of complex type, without using LINQ, the complex type has to implement IComparable interface and 
    provide implementation for CompareTo() method.
    
    CompareTo() method return an integer. and the meaning of the return value is shown below. RETURN VALUE is.
    
    Greater than Zero - The cureent instance is greater than the object using compare with.
    Less Than Zero - The current instance is less than the object being compared with.
    Is Zero - The current instance is equal to the object being compared with.
    
    Alternativey you cam also invoke CompareTo() method. Salary propety of the Customer object is int. CompareTo() method is 
    already implemented an integer type, so we can invoke this method and it's value.
	
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
			
			generalCustomers.Sort();
			Console.WriteLine("After sorting");
			foreach(Customer c in generalCustomers)
			{
				Console.WriteLine(c.Salary);
			}
			
			generalCustomers.Reverse();
			Console.WriteLine("After sorting");
			foreach(Customer c in generalCustomers)
			{
				Console.WriteLine(c.Salary);
			}
			
			SortCustomer sc = new SortCustomer();
			generalCustomers.Sort(sc);
			Console.WriteLine("After sorting");
			foreach(Customer c in generalCustomers)
			{
				Console.WriteLine(c.Name);
			}
		}
    }
	
	public class SortCustomer : IComparer<Customer>
	{
		public int Compare(Customer x, Customer y)
		{
			return x.Name.CompareTo(y.Name);
		}
	}
    
    public class Customer : IComparable<Customer>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
		public string type { get; set; }
		
		public int CompareTo(Customer obj)
		{
		/*
			if(this.Salary > obj.Salary)
			{
				return 1;
			}
			else if(this.Salary < obj.Salary)
			{
				return -1;
			}
			else
			{
				return 0;
			}	
		*/
		
			//Same result as above code this is because Salary is a double type and it already implements IComparable interface.
		
			return this.Salary.CompareTo(obj.Salary);
		
		}
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
		After sorting
		7500
		5500
		4500
		After sorting
		John
		Mark
		Marry
*/
