//---------------------------------------------------------------------------------------
/*
	Inheritance in C#.
	
	Inheritance is one of the main pillar of OOPs.
	It increases code re-useability of code.
	
	Whatever the common functionality of code we have to keep in one place and specific functionality
	we need to do in specific separate class.
	
	Let's see it by example.
*/
//---------------------------------------------------------------------------------------
using System;
//---------------------------------------------------------------------------------------
//Employee is the base class which contains the common property of employee.
//---------------------------------------------------------------------------------------
public class Employee
{
	public string FirstName;
	public string LastName;
	public string Email;
	
	public void FullName()
	{
		Console.WriteLine(FirstName + " " + LastName);
	}
}

//---------------------------------------------------------------------------------------
//Below two classes are the derived classes which is derived from the base class Employee
// Which can access all the property from base class by creating object of derived class
//---------------------------------------------------------------------------------------

public class FullTimeEmployee : Employee
{
	public float YearlySalary;
}

public class PartTimeEmployee : Employee
{
	public float HourlyPay;
}

public class Program
{
	public static void Main()
	{
		//----------------------------------------------------------------------------------------------------
		// Here we are creating object of derived class and accessing the property of base and derived class.
		//---------------------------------------------------------------------------------------------------
		FullTimeEmployee FTE = new FullTimeEmployee();
		FTE.FirstName = "John";
		FTE.LastName = "Doe";
		FTE.Email = "john.doe@gmail.com";
		FTE.YearlySalary = 500000;
		FTE.FullName();
		
		PartTimeEmployee PTE = new PartTimeEmployee();
		PTE.FirstName = "Jimmi";
		PTE.LastName = "Suyang";
		PTE.Email = "Jimmi.Suyang@gmail.com";
		PTE.HourlyPay = 10;
		PTE.FullName();
		
		//----------------------------------------------------------------------------------------------------
		// Note : Here in 'FullTimeEmployee' we cannot access property of 'PartTimeEmployee' as 'HourlyPay'
		// because it is specific to 'FullTimeEmployee' and Vice-Versa
		// Here we able to re-use the member of base class.
		//---------------------------------------------------------------------------------------------------
	}	
}
