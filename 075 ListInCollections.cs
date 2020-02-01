/*
    List collection class in C#.
    
    Contains() function : Check's if item exists in the list. This method will return true if item exist's
    otherwise returns false.
    
    Exists() funtion : Checks if an item exists in the list based on a condition. This method returns true if 
    the item exists, else false.
    
    Find() funtion : Search for an element that matches the conditions difined by the specified lambda expression
    and retun the first matching item from the list.
    
    FindLast() function : Searches for the element that matches the condition defined by the specified lamda expression
    and return the last matching item from the list.
    
    FindAll function : Return all the items from the list that matches the conditions specified by lambda expression.
    
    FindIndex function : Return the index of first item, that matches the condition, specified by the lambda expression
    there are two overload of this method which allow us to specify the range of the element to search, within the list.
    
    FindlastIndex() funtion : Return the index of last item. that matches the condition specified by the lambda expression.
    There are two other overload of this method which allow us to specify the range of elements to search, within the list.
    
    Convert the array to list - Use ToList() method.
    Convert the list of an array - use ToArray() method.
    Convert List to Dictionary - Use ToDictionary().
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
                Salary = 4500
            };
            
            Customer customer2 = new Customer()
            {
                Id = 102, 
                Name = "Mark",
                Salary = 6000
            };
            
            Customer customer3 = new Customer()
            {
                Id = 103, 
                Name = "John",
                Salary = 7000
            };
            
            List<Customer> customers = new List<Customer>();
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);
            
            if(customers.Contains(customer1))
            {
                Console.WriteLine("Customer Exist");
            }
            else
            {
                Console.WriteLine("Customer Not Exist");
            }
			
			if(customers.Exists(cust => cust.Id == 101))
			{
				Console.WriteLine("Customer Exist");
			}
			else
			{
				Console.WriteLine("Customer Not Exist");
			}
			
			Customer customerFirst = customers.Find(c => c.Name.StartsWith("M"));
			
			if(customerFirst != null)
			{
				Console.WriteLine("Id = {0} Name = {1} Salary = {2}", customerFirst.Id, customerFirst.Name, customerFirst.Salary);
			}
			else
			{
				Console.WriteLine("Customer Not Exist");
			}
			
			Customer customerLast = customers.FindLast(c => c.Name.StartsWith("M"));
			
			if(customerLast != null)
			{
				Console.WriteLine("Id = {0} Name = {1} Salary = {2}", customerLast.Id, customerLast.Name, customerLast.Salary);
			}
			else
			{
				Console.WriteLine("Customer Not Exist");
			}
			
			List<Customer> customerList = customers.FindAll(c => c.Name.StartsWith("M"));
			
			foreach(Customer c in customerList)
			{
				Console.WriteLine("Id = {0} Name = {1} Salary = {2}", c.Id, c.Name, c.Salary);
			}
			
			Console.WriteLine(customers.FindIndex(c => c.Name.StartsWith("M")));
			
			Console.WriteLine(customers.FindLastIndex(c => c.Name.StartsWith("M")));
			
			Customer[] customerArray = new Customer[3];
			
			customerArray[0] = customer1;
			customerArray[1] = customer2;
			customerArray[2] = customer3;
			
			List<Customer> NewList = customerArray.ToList();
			
			foreach(Customer c in NewList)
			{
				Console.WriteLine("Id = {0} Name = {1} Salary = {2}", c.Id, c.Name, c.Salary);
			}
			
			Customer[] NewCustomerArray = NewList.ToArray();
			
			foreach(Customer c in NewCustomerArray)
			{
				Console.WriteLine("Id = {0} Name = {1} Salary = {2}", c.Id, c.Name, c.Salary);
			}
			
			Dictionary<int, Customer> dict = NewList.ToDictionary(d => d.Id);
			
			foreach(KeyValuePair<int, Customer> c in dict)
			{
				Console.WriteLine("Id = {0} Name = {1} Salary = {2}", c.Value.Id, c.Value.Name, c.Value.Salary);
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
		Customer Exist
		Customer Exist
		Id = 101 Name = Marry Salary = 4500
		Id = 102 Name = Mark Salary = 6000
		Id = 101 Name = Marry Salary = 4500
		Id = 102 Name = Mark Salary = 6000
		0
		1
		Id = 101 Name = Marry Salary = 4500
		Id = 102 Name = Mark Salary = 6000
		Id = 103 Name = John Salary = 7000
		Id = 101 Name = Marry Salary = 4500
		Id = 102 Name = Mark Salary = 6000
		Id = 103 Name = John Salary = 7000
		Id = 101 Name = Marry Salary = 4500
		Id = 102 Name = Mark Salary = 6000
		Id = 103 Name = John Salary = 7000
*/
