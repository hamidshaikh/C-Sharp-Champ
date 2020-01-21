//------------------------------------------------------------------------------------------------------------
/*
	Difference between Convert.ToString and ToString
	
	Convert.ToString() handlers null, while ToString() doesn't, and throws a null reference exception.
	
	Depending upon the type of application, architecture and what you are trying to achieve, you choose 
	one over other.
	
	Let's understand it by example.
*/
//------------------------------------------------------------------------------------------------------------
using System;

public class Customer
{
	public string Name { get; set;}
}
		
public class Program
{
	public static void Main()
	{
		Customer C1 = new Customer();
		//string str = C1.toString();
		
		string str = Convert.ToString(C1);
		
		Console.WriteLine(str);
	}
}

/*
	Output : 
		Customer
*/
