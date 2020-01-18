//-----------------------------------------------------------------------------------------------
/*
	Why Enum ?
	
	Here in this program we are going to use the use of enum.
	
	this program became more readable and maintanable because of enum.
	
	Let's understand it by example.
*/
//-------------------------------------------------------------------------------------------------
using System;

public class Program
{
	public static void Main()
	{
		// 0 Male
		//1 Female
		// 2 Unknown
		Customer[] customers = new Customer[3];
		customers[0] = new Customer(){
			Name = "John",
			Gender = Gender.Male
		};
		
		customers[1] = new Customer(){
			Name = "Marry",
			Gender = Gender.Female
		};
		
		customers[2] = new Customer(){
			Name = "Mark",
			Gender = Gender.Unknown
		};
		
		foreach(var customer in customers){
			Console.WriteLine("Customer Name {0} and Gender {1}", customer.Name, GetGender(customer.Gender));
		}
	}
	
	public static string GetGender(Gender gender){
		switch(gender){
			case Gender.Male : return "Male";
			case Gender.Female : return "Female";
			case Gender.Unknown : return "Unknown";
			default : return "Invalid gender";
		}
	}
}

public enum Gender
{
	Male,
	Female,
	Unknown
}

public class Customer
{
	public string Name { get; set; }
	public Gender Gender { get; set; }
}
