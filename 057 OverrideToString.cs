//------------------------------------------------------------------------------------------------------------
/*
	Wht should we override toString() method.
	
	To string method is basically used to convert value to string.
	but in some case if we want our custom implementation then we use toString method.
	
	Let's understand it by example.
*/
//------------------------------------------------------------------------------------------------------------
using System;

public class Customer
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
	
	public override string ToString()
	{
		return this.FirstName + " " + this.LastName;
	}
}
		
public class Program
{
	public static void Main()
	{
		Customer C1 = new Customer();
		C1.FirstName = "John";
		C1.LastName = "Doe";
		
		Console.WriteLine(Convert.ToString(C1));
	}
}

/*
	Output : 
		Equal
		Not Equal
*/
