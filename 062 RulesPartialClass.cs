//------------------------------------------------------------------------------------------------------------
/*
	* Rules for creating partial class.
	
	1. All the parts spread across different files, Must use the partial keyword.
	2. All the parts spread across different files, must have the same access modifiers.
	3. If any of the parts are declared abstract, then the entire type is considered as abstract.
	4. If any of the parts are declared sealed, then the entire type considered as sealed.
	5. If any of the parts inherit a class then entire type inherit that class.
	6. C# does not support multiple class inheritance. different parts of the partial class, must not specify 
	different base class.
	7. Different parts of the partial class can specify different base interfaces, and the final type implements
	all the interfaces listed by all of the partial declaration.
	8. Any member that are declared in a partial definition are available to all of the other parts of the partial class.
	
*/
//------------------------------------------------------------------------------------------------------------
using System;

public class Program
{
	public static void Main()
	{
		Customer C1 = new Customer();
		C1.FirstName = "john";
		C1.LastName = "Doe";
		
		Console.WriteLine(C1.GetFullName());
	}	
}

public partial class Customer
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
}

public partial class Customer
{
	public string GetFullName()
	{
		return FirstName +" - " + LastName;
	}
}

/* Output : 
	john - Doe
*/
