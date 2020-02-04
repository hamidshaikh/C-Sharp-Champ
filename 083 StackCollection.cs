/*
    Generic Stack Collection in C#.
	
	Stack is a generic LIFO(Last In First Out) collection class that is present in System.Collections.Generics namespace.
	The stack collection class is analoguos to a stack of plates.
	
	If you want to add a new plates to the stack of plates, you place it on top of all the existing plates. If you want to remove a plates
	from the stack. you will first remove the one that you have last added.
	
	The stack collection class also operates in a simillar fasion. The last item to be added (Pushed) to the stack, will be the first item to
	be removed (popped) from the stack.
	
	To insert an item at the top of the stack, Use push method.
	
	To remove and return the item that is present at the top of the stack, use Pop() method.
	
	A foreach loop iterate through the item in the stack. but will not remove them from stack. The item from the stack are retrived 
	in LIFO (Last In Forst Out) order, The last element added to the Stack is the first one to be returned.
	
	To check if an item exist in the stack, use Contains() method.
	
	What is difference between Pop() and Peek() methodss?
	Pop() method removes and returns the item at the top of the stack. Where as Peek() returns the item at top of the stack, 
	without removing it.
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
				Name = "Mark",
				Salary = 4500
			};
			
			Customer customer2 = new Customer()
			{
				Id = 102,
				Name = "Marry",
				Salary = 5500
			};
			
			Customer customer3 = new Customer()
			{
				Id = 103,
				Name = "John",
				Salary = 6500
			};
			
			Stack<Customer> stackCustomers = new Stack<Customer>();
			stackCustomers.Push(customer1);
			stackCustomers.Push(customer2);
			stackCustomers.Push(customer3);
			
			Console.WriteLine("Stack lenght " + stackCustomers.Count());
			
			Console.WriteLine("Customer Pop of Id " + stackCustomers.Pop().Id);
			
			Console.WriteLine("Stack lenght " + stackCustomers.Count());
			
			Console.WriteLine("Customer Peek() of Id " + stackCustomers.Peek().Id);
			
			Console.WriteLine("Stack lenght " + stackCustomers.Count());
			
			foreach(Customer c in stackCustomers)
			{
				Console.WriteLine(c.Id);	
			}
		}
    }
	
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
    }
}

/*
	Output :
		Stack lenght 3
		Customer Pop of Id 103
		Stack lenght 2
		Customer Peek() of Id 102
		Stack lenght 2
		102
		101
*/
