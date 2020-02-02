/*
    Working with generic class and range.
	
	Addrange() : Add() method allow you to add one item at a time to the end of list, where as AddRange() allow you to add
	another list of items to the end of list.
	
	GetRange() : using the item index, we can retrive only one item at a time from the list. if you want to get list of item from the list.
	then use GetRange() function. these function expect 2 parameters, i.e. the start index of a list and the number of element to return.
	
	InsertRange() : Insert() method allow you to insert a single item into list at specified index.
	
	RemoveRange() ; Remove() function remove the first matching item from the list. RemoveAt() function. remove the item at the specified index.
	in the list. RemoveAll() funtion removes all the item that matches the specified condition. RemoveRange() remove the range of element
	from the list. The funtion expect the two parameters. 
	i.e. The start index in the list and the number of element to remove. If you want to remove all the elements from the list without 
	specifing any condition. then use Clear() funtion.
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
			
			Customer customer4 = new Customer()
			{
				Id = 104,
				Name = "Setu",
				Salary = 8500,
				type = "Corporate Customer"
			};
			
			Customer customer5 = new Customer()
			{
				Id = 105,
				Name = "Remo",
				Salary = 10500,
				type = "Corporate Customer"
			};
			
			List<Customer> Corporateustomers = new List<Customer>();
			Corporateustomers.Add(customer4);
			Corporateustomers.Add(customer5);
			
			generalCustomers.AddRange(Corporateustomers);
			
			foreach(Customer customer in generalCustomers)
			{
				Console.WriteLine("Id = {0} Name = {1} Salary = {2} Type = {3}", customer.Id, customer.Name, customer.Salary, customer.type);
			}
			
			Console.WriteLine("-------------------------------------------------------------");
			
			List<Customer> customers = generalCustomers.GetRange(3, 2);
			
			foreach(Customer customer in customers)
			{
				Console.WriteLine("Id = {0} Name = {1} Salary = {2} Type = {3}", customer.Id, customer.Name, customer.Salary, customer.type);
			}
			
			Console.WriteLine("-------------------------------------------------------------");
			
			Customer customer6 = new Customer()
			{
				Id = 106,
				Name = "Ritu",
				Salary = 8600,
				type = "Corporate Customer"
			};
			
			Customer customer7 = new Customer()
			{
				Id = 107,
				Name = "Roshan",
				Salary = 20211,
				type = "Corporate Customer"
			};
			
			List<Customer> NewCorporateCustomer = new List<Customer>();
			NewCorporateCustomer.Add(customer6);
			NewCorporateCustomer.Add(customer7);
			
			generalCustomers.InsertRange(0, NewCorporateCustomer);
			
			foreach(Customer customer in generalCustomers)
			{
				Console.WriteLine("Id = {0} Name = {1} Salary = {2} Type = {3}", customer.Id, customer.Name, customer.Salary, customer.type);
			}
			
			Console.WriteLine("-------------------------------------------------------------");
			
			generalCustomers.RemoveRange(5, 2);
			
			foreach(Customer customer in generalCustomers)
			{
				Console.WriteLine("Id = {0} Name = {1} Salary = {2} Type = {3}", customer.Id, customer.Name, customer.Salary, customer.type);
			}
			
			Console.WriteLine("-------------------------------------------------------------");
			
			generalCustomers.Clear();
			
			foreach(Customer customer in generalCustomers)
			{
				Console.WriteLine("Id = {0} Name = {1} Salary = {2} Type = {3}", customer.Id, customer.Name, customer.Salary, customer.type);
			}
			
			Console.WriteLine("-------------------------------------------------------------");
			
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
		Id = 101 Name = Marry Salary = 5500 Type = General Customer
    Id = 102 Name = Mark Salary = 4500 Type = General Customer
    Id = 103 Name = John Salary = 7500 Type = General Customer
    Id = 104 Name = Setu Salary = 8500 Type = Corporate Customer
    Id = 105 Name = Remo Salary = 10500 Type = Corporate Customer
    -------------------------------------------------------------
    Id = 104 Name = Setu Salary = 8500 Type = Corporate Customer
    Id = 105 Name = Remo Salary = 10500 Type = Corporate Customer
    -------------------------------------------------------------
    Id = 106 Name = Ritu Salary = 8600 Type = Corporate Customer
    Id = 107 Name = Roshan Salary = 20211 Type = Corporate Customer
    Id = 101 Name = Marry Salary = 5500 Type = General Customer
    Id = 102 Name = Mark Salary = 4500 Type = General Customer
    Id = 103 Name = John Salary = 7500 Type = General Customer
    Id = 104 Name = Setu Salary = 8500 Type = Corporate Customer
    Id = 105 Name = Remo Salary = 10500 Type = Corporate Customer
    -------------------------------------------------------------
    Id = 106 Name = Ritu Salary = 8600 Type = Corporate Customer
    Id = 107 Name = Roshan Salary = 20211 Type = Corporate Customer
    Id = 101 Name = Marry Salary = 5500 Type = General Customer
    Id = 102 Name = Mark Salary = 4500 Type = General Customer
    Id = 103 Name = John Salary = 7500 Type = General Customer
    -------------------------------------------------------------
    -------------------------------------------------------------
    */
