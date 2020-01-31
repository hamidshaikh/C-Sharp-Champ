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
		Customer customer1 = new Customer()
		{Id = 101, Name = "Mark", Salary = 5500};
		Customer customer2 = new Customer()
		{Id = 102, Name = "Mark", Salary = 5500};
		Customer customer3 = new Customer()
		{Id = 103, Name = "John", Salary = 6500};
		List<Customer> customers = new List<Customer>();
		customers.Add(customer1);
		customers.Add(customer2);
		customers.Add(customer3);
		
		Dictionary<int, Customer> dict = customers.ToDictionary(cust => cust.Id, cust => cust);
		
		foreach (KeyValuePair<int, Customer> kvp in dict)
		{
			Console.WriteLine("Key = {0}", kvp.Key);
			Customer cust = kvp.Value;
			Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.Id, cust.Name, cust.Salary);
		}
	}
}

public class Customer
{
	public int Id
	{
		get;
		set;
	}

	public string Name
	{
		get;
		set;
	}

	public double Salary
	{
		get;
		set;
	}
}/*
	Output:
		Key = 101
		ID = 101, Name = Mark, Salary = 5500
		Key = 102
		ID = 102, Name = Mark, Salary = 5500
		Key = 103
		ID = 103, Name = John, Salary = 6500
*/
