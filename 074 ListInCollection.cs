//------------------------------------------------------------------------------------------------------------
/*
	List in C#.
	
	List is one of the generic collection classes present in System.Collection.Generic namespace. There are sevaral generic collection
	classes in System.Collection.Generic namespace as listed below.
	
	1. Dictionary
	2. List
	3. Stack
	4. Queue etc.
	
	A List class can be used to create a collection of any type.
	
	For example, we can create a list of integers, Strings or even complex types.
	
	The object stored in the list can be accessed by index.
	
	unlike arrays, lists can grow in size automatically.
	
	This class also provides methods to search, sort and manipulate list.
	
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
		{
			Id = 101,
			Name = "John",
			Salary = 5500
		};
		Customer customer2 = new Customer()
		{
			Id = 102,
			Name = "Marry",
			Salary = 4500
		};
		Customer customer3 = new Customer()
		{
			Id = 103,
			Name = "JMark",
			Salary = 5400
		};
		
		List<Customer> customers = new List<Customer>();
		customers.Add(customer1);
		customers.Add(customer2);
		customers.Add(customer3);
		
		customers.Insert(0, customer3);
		
		foreach(var customer in customers)
		{
			Console.WriteLine("ID = {0} Name = {1} Salary = {2}", customer.Id, customer.Name, customer.Salary);
		}
		
		Console.WriteLine(customers.IndexOf(customer3, 1));
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
		ID = 103 Name = JMark Salary = 5400
		ID = 101 Name = John Salary = 5500
		ID = 102 Name = Marry Salary = 4500
		ID = 103 Name = JMark Salary = 5400
3
*/
