/*
    Anonymous method in C#.
	
	What is anonymous method in C#?
	Anonymous method is a method without a name. Introduced in C# 2. They provide us a way of creating delegates instances 
	without having to write a sepates method.
	
	Let's try to understand it by example.
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
			List<Customer> listCustomer = new List<Customer>()
			{
				new Customer{ Id = 101, Name = "Mark"},
				new Customer{ Id = 102, Name = "Mark"},
				new Customer{ Id = 103, Name = "Mark"},
			};
			
			//Step 2
			//Predicate<Customer> customerPredicates = new Predicate<Customer>(FindEmployee);
			
			//Step 3
			//Customer customer = listCustomer.Find(c => customerPredicates(c));
			
			Customer customer = listCustomer.Find(delegate(Customer c)
												  {
													  return c.Id == 102;
												  });
			
			Console.WriteLine("Id = {0} Name = {1}", customer.Id, customer.Name);
		}
		
		//Step 1
		//public static bool FindEmployee(Customer customer)
		//{
			//return customer.Id == 102;
		//}
    }
	
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

/*
	Output :
		Id = 102 Name = Mark
*/
