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
	
	public override bool Equals(object obj){
		if(obj == null){
			return false;
		}
		
		if(!(obj is Customer)){
			return false;
		}
		
		return this.FirstName == ((Customer)(obj)).FirstName && this.LastName == ((Customer)obj).LastName;
	}
	
	public override int GetHashCode()
	{
		return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
	}
}
		
public class Program
{
	public static void Main()
	{
		Customer C1 = new Customer();
		C1.FirstName = "John";
		C1.LastName = "Doe";
		
		Customer C2 = new Customer();
		C2.FirstName = "John";
		C2.LastName = "Doe";
		
		//We make this method for reference comparison.
		Console.WriteLine(C1 == C2);
		
		//We make this method for content comparison.
		Console.WriteLine(C1.Equals(C2));
	}
}

/*
	Output : 
		False
		True
*/
