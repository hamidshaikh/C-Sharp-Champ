/*
    What is Func<T, TResult> in C#.
	
	In simple term, Func<T, TResult> is just a generic delegates, Depending on the requirements, the type parameter(T and TResult) can be replaced with 
	the curresponding type arguments.
	
	For example, Func<Employee, string> is a delegate that represent a funcion, expecting Employee object. as input parameter, and return a string.
	
	
	What is difference between Func delegates and lambda expression?
	
	They are same, just two different way's to write two things The lambda syntax is newer, More consize and easy to write.
	
	What if I have to pass two or more input parameters?
	
	As of this code there are 17 overloaded version of Func, which enable us to pass variable number of input parameters, In the example below, 
	Func<int, int, string> represent a function that expects 2 int input parameter, and return a tring.
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
			List<Customer> listCustomer = new List<Customer>()
			{
				new Customer{ Id = 101, Name = "Mark"},
				new Customer{ Id = 102, Name = "Maarry"},
				new Customer{ Id = 103, Name = "John"},
			};
			
			//Func<Customer, string> selector = c => "Name = " + c.Name;
			
			IEnumerable<string> names = listCustomer.Select(c => "Name = " + c.Name);
			
			foreach(string name in names)
			{
				Console.WriteLine(name);
			}
			
			Func<int, int, string> funcDelegates = (FN, SN) => 
				"Sum = " + (FN + SN).ToString();
			
			string result = funcDelegates(10, 20);
			Console.WriteLine(result);
		}
    }
	
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

/*
	Output :
		Name = Mark
		Name = Maarry
		Name = John
		Sum = 30
*/
