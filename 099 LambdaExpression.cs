/*
    Lambda Expressions.
	
	Anonymous methods and lambda expression are very simillar, Anonymous methods were introduced in C# 2.0 and lambda
	expression in C# 3.0.
	
	To find an employee with id = 102, using anonymous method
	Employee employee = listEmployee.find(delegate(Emloyee emp) { return Emp.ID == 102 });
	
	To find an employee with id = 102, using lambda expression.
	Employee employee = listEmployee.Find(emp => emp.ID == 102);
	
	You can also explicitly specify the input type but not required
	Employee employee = listEmployee.Find((Employee emp) => Emp.Id == 102)
	
	=> is called lambda expression operator and read as GOES TO. Notice that with a lambda expression you don't have to use 
	the delegate keyword explicitly. and don't have to specify the input type parameter explicitly. 
	The parameter type is inferred.
	
	The lamda expressions are more convenient to use then anonymous methods. Lambda expressions are perticularly helpful for writing LINQ
	query expressions.
	
	In most of the cases the lambda expressions supersedes anonymous method. To my knoledge, the only time I frefferd to use anonymous methods over
	lambda is, when you have to omit the parameter list. when it is not used within the body.
	
	Anonymous method allow the parameter list to be omitted entirly when is is not used when it is not used within the body. Where as with lambda 
	expression this is not the case.
	
	For example, with anonymous method notice that we have omitted the parameter list as we are not using them within the body.
	
	Button1.click += delegate
	{
		Messagebox.Show("Button clicked");
	}
	
	The above code can be written using lambda expression as shown below. Notice that with lambda we cannot omit the parameter list.
	
	Button1.click += (eventSender, eventArgs) =>
	{
		MessageBox.Show("Button Clicked");
	}
*/

using System;
using System.Collections.Generic;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {	
			List<Customer> listCustomer = new List<Customer>()
			{
				new Customer{ Id = 101, Name = "Mark"},
				new Customer{ Id = 102, Name = "Maarry"},
				new Customer{ Id = 103, Name = "John"},
			};
			
			//Step 2
			//Predicate<Customer> customerPredicates = new Predicate<Customer>(FindEmployee);
			
			//Step 3
			//Customer customer = listCustomer.Find(c => customerPredicates(c));
			
			Customer customer = listCustomer.Find((Customer x) => x.Id == 102);
			
			Console.WriteLine("Id = {0} Name = {1}", customer.Id, customer.Name);
			
			int count = (listCustomer.GetRange(0,listCustomer.Count)).Count;
			
			Console.WriteLine("Count = {0}", count);
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
		Id = 102 Name = Maarry
		Count = 3
*/
