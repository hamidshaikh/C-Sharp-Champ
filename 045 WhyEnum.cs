//-----------------------------------------------------------------------------------------------
/*
	Why Enum ?
	Enums are the strongly typed constants.
	
	If the program uses the set of integral numbers, consider replacing with enums, Otherwise program become 
	less readable and maintanable. 
	
	In the next session we will replace, these integral numbers with enums, which makes the program better 
	readable and maintainable.
	
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
			Gender = 0
		};
		
		customers[1] = new Customer(){
			Name = "Marry",
			Gender = 1
		};
		
		customers[2] = new Customer(){
			Name = "Mark",
			Gender = 2
		};
		
		foreach(var customer in customers){
			Console.WriteLine("Customer Name {0} and Gender {1}", customer.Name, GetGender(customer.Gender));
		}
	}
	
	public static string GetGender(int gender){
		switch(gender){
			case 0 : return "Male";
			case 1 : return "Female";
			default : return "Unknown";
		}
	}
}

public class Customer
{
	public string Name { get; set; }
	public int Gender { get; set; }
}


/*
  Output : 
    Customer Name John and Gender Male
    Customer Name Marry and Gender Female
    Customer Name Mark and Gender Unknown
*/
