/*
    Usefull method in list collection class.
	
	TrueForAll() : Return true or false depending on whether if every element in the list matches the condition defined 
	by the specified predicates.
	
	AsReadOnly() : Return a readonly wrapper for the current collection. Use this method, If you don't want the client code to modify 
	the collection i.e. add or remove any elements from the collection. the ReadOnly collection will not have method to add or remove
	item from collection. You can readonly the item from collection.
	
	trimExcess() : Set the capacity to the actual member of elements in the list. If the number is less than the threshold value.
	
	According to MSDN:
		This method can be used to minimisze the collections memory overhead if no new elements will be added to the collection. The cost of reallocating 
		and copying the large List<T> can be considarable.
		So the trimAxcess() mmethod does nothong if the list is at more than 90% of capacite. This avoide incurring a large re-allocation cost for a 
		relativly small gain. The current threshold is 90%, but it could be change in futute.		
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
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
			
			List<Customer> generalCustomers = new List<Customer>(100);
			generalCustomers.Add(customer1);
			generalCustomers.Add(customer2);
			generalCustomers.Add(customer3);
			
			Console.WriteLine("All salary greater than 3000 " + generalCustomers.TrueForAll(cust => cust.Salary > 3000));
			Console.WriteLine("All salary greater than 6000 " + generalCustomers.TrueForAll(cust => cust.Salary > 6000));
			
			ReadOnlyCollection<Customer> customers = generalCustomers.AsReadOnly();
			
			//We cannot apply these crud methods
			//customers.Add();
			
			Console.WriteLine("initial capacity " + generalCustomers.Capacity);
			
			generalCustomers.TrimExcess();
			
			Console.WriteLine("initial capacity " + generalCustomers.Capacity);
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
		All salary greater than 3000 True
		All salary greater than 6000 False
		initial capacity 100
		initial capacity 3
*/
