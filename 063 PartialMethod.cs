//------------------------------------------------------------------------------------------------------------
/*
	1. A partial class or a structs can contain partial method.
	2. A partial method is created using the partial keyword.
	3. A partial method declarartion consist of two parts.
	I) The definotion (Only the method signature).
	II) The implementation
	
	These may be in separate parts of the partial class, or in the same part.
	
	4. The implementaion for a partial method is optional. If we don't provide the implementation, the compiler removes
	the signature and all call to the method.
	
	5. partial methods are private by default, and it is compile time error to include any access modifiers, including private.
	6. It is compile time error, to include declaration and implementation at the same time for a partial method.
	7. A partial method retun type must be void. Include any other retun type is a compile time error.
	8. Signature of the partial method declaration, must match with the signature of the implementation.
	
	9. A partial method must be declared within a partial class or partial struct. A non partial class or struct cannot include 
	partial method.
	
	10. A partial method can be implementaed only once, Trying to implement the partial method more than once, raises a
	compile time error.
	
	Let's see the simple example...
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
		
		// Console.WriteLine(C1.GetFullName());
	}	
}

public partial class Customer
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
	
	partial void GetFullName();
}

public partial class Customer
{
	partial void GetFullName()
	{
		Console.WriteLine("GetFullName Invoked...");
	}
}

/* Output : 
	
*/
