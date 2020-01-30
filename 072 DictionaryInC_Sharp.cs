//------------------------------------------------------------------------------------------------------------
/*
	Dictionary in C#.
	
	1. A dictionary is a collection of key value pairs.
	2. Dictionary class present in System.Collection.Generic namespace.
	3. When creating a dictionary, we neet to specify the type of key and value.
	4. Dictionary provides fast lookups for value using keys.
	5. key in dictionary must be unique.
	
	Let's see the simple example...
*/
//------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
	public static void Main()
	{
		List<Customer> customers = new List<Customer>()
		{
			new Customer {
				Id = 101,
				Name = "Mark",
				Salary = 5500
			},
			new Customer {
				Id = 102,
				Name = "Marry",
				Salary = 4500
			},
			new Customer {
				Id = 103,
				Name = "John",
				Salary = 6500
			},
		};
		
		Dictionary<int, Customer> dictionary = new Dictionary<int, Customer>();
		dictionary.Add(customers.FirstOrDefault(cust => cust.Id == 101).Id, customers.FirstOrDefault(cust => cust.Id == 101));
		dictionary.Add(customers.FirstOrDefault(cust => cust.Id == 102).Id, customers.FirstOrDefault(cust => cust.Id == 102));
		dictionary.Add(customers.FirstOrDefault(cust => cust.Id == 103).Id, customers.FirstOrDefault(cust => cust.Id == 103));
		
		foreach(KeyValuePair<int, Customer> cust in dictionary)
		{
			Console.WriteLine("Key = {0}", cust.Key);
			
			Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", cust.Value.Id, cust.Value.Name, cust.Value.Salary);
			
			Console.WriteLine("--------------------------------------------------------------------------");
		}
	}
}

public class Customer
{
	public int Id { get; set; }
	public string Name { get; set; }
	public double Salary { get; set; }
}

/*
	Output:
		Key = 101
		Id = 101, Name = Mark, Salary = 5500
		--------------------------------------------------------------------------
		Key = 102
		Id = 102, Name = Marry, Salary = 4500
		--------------------------------------------------------------------------
		Key = 103
		Id = 103, Name = John, Salary = 6500
		--------------------------------------------------------------------------
*/
