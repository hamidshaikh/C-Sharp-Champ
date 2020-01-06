//-----------------------------------------------------------------------------------------------
/*
	Polymorphism in C#.
	
	Polymorphism is also one of the main pillar of OOPs. Polymorphism enable us to invoke 
	the derived class method using base class reference veriable.
	
	There are two keyword to implement the comcept of polymorphism like 'virtual' and 'override'
	let's see witn an example.
*/
//-------------------------------------------------------------------------------------------------
using System;

public class Employee
{
	public string FirstName = "FName";
	public string LastName = "LName";
	
	public virtual void FullName()
	{
		Console.WriteLine(FirstName + " " + LastName + " - base class");
	}
}

public class FullTimeEmployee : Employee
{
	//-------------------------------------------------------------------------------------------------
	// This method will call by base class reference because it is overriden method.
	//-------------------------------------------------------------------------------------------------
	public override void FullName()
	{
		Console.WriteLine(FirstName + " " + LastName + " - full time");
	}
}

public class PartTimeEmployee : Employee
{
	//-------------------------------------------------------------------------------------------------
	// In this case the base class implemntation will be called because it is not overriden method.
	//-------------------------------------------------------------------------------------------------
	public void FullName()
	{
		Console.WriteLine(FirstName + " " + LastName + " - part time");
	}
}

public class TemporaryEmployee : Employee
{
	//-------------------------------------------------------------------------------------------------
	// There is no such overriden method so in this case also base class method will be called.
	//-------------------------------------------------------------------------------------------------
}

public class Program
{
	public static void Main()
	{
		Employee[] employee = new Employee[4];
		
		employee[0] = new Employee();
		employee[1] = new FullTimeEmployee();
		employee[2] = new PartTimeEmployee();
		employee[3] = new TemporaryEmployee();
		
		foreach(var e in employee){
			e.FullName();
		}
	}	
}
