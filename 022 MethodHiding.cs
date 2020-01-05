//---------------------------------------------------------------------------------------
/*
	Method hidding in C#.
	
	In case of inheritance if parent and child class have the same method implementation then
	child class method get executed and parent class method will be hidded.
	That is called method hiding.
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
	
	public void FullName()
	{
		Console.WriteLine(FirstName + " " + LastName);
	}
}

public class FullTimeEmployee : Employee
{
	public new void FullName()
	{
		//base.FullName(); //We can make like this to call base class method
		Console.WriteLine(FirstName + " " + LastName + " - Contractor");
	}
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
		FTE.FullName();
		
		//---------------------------------------------------------------------------------------------------
		// To call patent class method we have sevaral ways as i.e
		//---------------------------------------------------------------------------------------------------
		((Employee)FTE).FullName();
		
		Employee EFTE = new FullTimeEmployee();
		EFTE.FirstName = "Sara";
		EFTE.LastName = "Khan";
		EFTE.FullName();
	}	
}
