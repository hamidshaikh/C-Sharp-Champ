/*
    Queue is a generic FIFO (First In First Out) collection class that is present in System.Collections.Generic namespace.
	The queue collection class is analogous to a queue at the ATM machine to withdaw money. The order in which people queue up, will be the order
	in which they will be able to get out of the queue and withdaw monney from ATM.
	
	The queue collection class operates in simillar fasion. The first item to be added (enqueued) to the queue, will be the first item.
	to be removed (Dequeued) from the queue.
	
	To add item to the queue use Enqueue() method. 
	To remove an item that is present at the beggining of the queue, use Dequeue() Method.
	
	A foreach loop iterate through the items in a queue, but will not remove them from the queue.
	
	To check if an item, exist in the queue, use Contains() method.
	
	What is the difference between Dequeue() and Peak() method?
	
	Dequeue() method removes and return an item at the beginning of the queue where as Peak() returns the item at the beginning of the 
	queue, without removing it.
	
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
			
			Queue<Customer> queueCustomers = new Queue<Customer>();
			queueCustomers.Enqueue(customer1);
			queueCustomers.Enqueue(customer2);
			queueCustomers.Enqueue(customer3);
			
			Console.WriteLine("Queue lenght " + queueCustomers.Count());
			
			Console.WriteLine("Customer dequeue of Id " + queueCustomers.Dequeue().Id);
			
			Console.WriteLine("Queue lenght " + queueCustomers.Count());
			
			Console.WriteLine("Customer dequeue of Id " + queueCustomers.Peek().Id);
			
			Console.WriteLine("Queue lenght " + queueCustomers.Count());
			
			foreach(Customer c in queueCustomers)
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
		Queue lenght 3
		Customer dequeue of Id 101
		Queue lenght 2
		Customer dequeue of Id 102
		Queue lenght 2
		102
		103
*/
