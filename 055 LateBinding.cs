//------------------------------------------------------------------------------------------------------------
/*
	Early v/s late binging C#
	
	Difference between early and late binding.
	
	1. early binding can flag error at compile time. With late binding there is a risk run time exception.
	
	2. Early binding is much better for performance and should always be preffered over late binding. 
	Use late binding only when working with an objects that are not available at compile time.
	
	Let's understand it by example.
*/
//------------------------------------------------------------------------------------------------------------
using System;
using System.Reflection;

public class Customer
{
	public string FullName(string FName, string LName)
	{
		return "Full name is "+ FName + " " + LName ;
	}
}
		
public class Program
{
	public static void Main()
	{
		Assembly executeAssembly = Assembly.GetExecutingAssembly();
		Type customerType = executeAssembly.GetType("Customer");
		object customerInstance = Activator.CreateInstance(customerType);
		
		MethodInfo getFullName = customerType.GetMethod("FullName");
		
		string[] methodParameters = new string[2];
		
		methodParameters[0] = "Hamid";
		methodParameters[1] = "Shaikh";
		
		var fullName = (string)getFullName.Invoke(customerInstance, methodParameters);
		
		Console.WriteLine(fullName);
		
		Customer customer = new Customer();
		
		fullName = customer.FullName("John", "Smith");
		
		Console.WriteLine(fullName);
	}
}

/*
	Output : 
		Full name is Hamid Shaikh
		Full name is John Smith
*/
