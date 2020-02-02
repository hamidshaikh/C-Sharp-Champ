/*
    Sort a list of simple type.
	
	Sorting list of simple types like int, string, char, etc is straight forward. just invoke the Sort() method on list instance
    and the data will be sorted in ascending order.
    
    If you want the data to retrived in decsending order, Use Reverse() method on the list instance.
    
    however when you do the same thing on the complex type like customer we get runtime invalid operation exception. 
    Failed to compare 2 elements in an array.
    
    This is because, .NET runtime does not know, How to sort complex types. We have to tell the way we want data to be sorted in a list
    by implementing IComparable interface.
    
    How is the sort funtionality working for simple type like int, string, char etc.
    
    That is because these types (int, string, decimal, char etc.) have implemented IComparable interface already.
	
	
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
			List<int> numbers = new List<int>{  8, 6, 2, 3, 4, 9, 3 };
			
			Console.WriteLine("plain list");
			
			foreach(int number in numbers)
			{
				Console.Write(number);
			}
			Console.WriteLine();
			Console.WriteLine("--------------");
			
			Console.WriteLine("Sort list");
			
			numbers.Sort();
			
			foreach(int number in numbers)
			{
				Console.Write(number);
			}
			Console.WriteLine();
			Console.WriteLine("--------------");
			
			Console.WriteLine("Reverse Sort list");
			
			numbers.Reverse();
			
			foreach(int number in numbers)
			{
				Console.Write(number);
			}
			Console.WriteLine();
			Console.WriteLine("--------------");
			Console.WriteLine("Plain list");
			
			List<string> alphabets = new List<string>{"A", "I", "E", "U", "O"};
			
			foreach(string alphabet in alphabets)
			{
				Console.Write(alphabet);
			}
			Console.WriteLine();
			Console.WriteLine("--------------");
			Console.WriteLine("Sort list");
			
			alphabets.Sort();
			
			foreach(string alphabet in alphabets)
			{
				Console.Write(alphabet);
			}
			Console.WriteLine();
			Console.WriteLine("--------------");
			Console.WriteLine("Reverse Sort list");
			
			alphabets.Reverse();
			
			foreach(string alphabet in alphabets)
			{
				Console.Write(alphabet);
			}
			Console.WriteLine();
			Console.WriteLine("--------------");
			
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
			
			//generalCustomers.Sort();
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
		plain list
		8623493
		--------------
		Sort list
		2334689
		--------------
		Reverse Sort list
		9864332
		--------------
		Plain list
		AIEUO
		--------------
		Sort list
		AEIOU
		--------------
		Reverse Sort list
		UOIEA
		--------------
*/
