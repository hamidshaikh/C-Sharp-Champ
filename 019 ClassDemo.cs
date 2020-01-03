//---------------------------------------------------------------------------------------
/*
	Classes in C#.
	
	Class is a blue print of an real world boject. class contain specific methods and fields.
	
	and class has constructors also let's try to understand by example.
*/
//---------------------------------------------------------------------------------------
using System;
					
public class ClassDemo
{
	string firstName, lastName;
	//---------------------------------------------------------------------------------------
	//default constructor is created by default or if we can also create.
	//---------------------------------------------------------------------------------------
	public ClassDemo() : this("Default Value","Default Value")
	{
	}
	//---------------------------------------------------------------------------------------
	//Constructor is used to initilise the fields of class and create object of the class.
	//---------------------------------------------------------------------------------------
	public ClassDemo(string _firstName, string _lastName){
		this.firstName = _firstName;
		this.lastName = _lastName;
	}
	
	public void Display(){
		Console.WriteLine("Full name is {0}", firstName+ " " +lastName);
	}
	
}

public class Program
{
	public static void Main()
	{
		ClassDemo dc = new ClassDemo();
		dc.Display();
		ClassDemo cd = new ClassDemo("Git", "Hub");
		cd.Display();
	}	
}
