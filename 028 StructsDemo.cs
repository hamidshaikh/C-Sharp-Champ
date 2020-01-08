//-----------------------------------------------------------------------------------------------
/*
	Stucture in C#.
	
	Just like classes struct can have
	1) Private fields
	2) Public properties
	3) Constructor
	4) Methods
	
	Look at the following example.
*/
//-------------------------------------------------------------------------------------------------
using System;

public struct StructDemo
{
	public int Id {get; set;}
	public string Name {get; set;}
	
	/*
		By calling :this() from your constructor declaration you let the base ValueType class initialize all 
		the backing fields for the automatic properties. We cannot do it manually on our constructor 
		because we don't have access to the backing field of an automatic property. ValueType is the base class of all structs.
	*/
	
	public StructDemo(int _Id, string _Name) : this()
	{
		this.Id = _Id;
		this.Name = _Name;
	}
}

public class Program
{
	public static void Main()
	{
		StructDemo sd1 = new StructDemo(101, "Mark");
		Console.WriteLine("Id is = {0} and Name = {1}", sd1.Id, sd1.Name);
		
		StructDemo sd2 = new StructDemo();
		sd2.Id = 102;
		sd2.Name = "John";
		Console.WriteLine("Id is = {0} and Name = {1}", sd2.Id, sd2.Name);
		
		/*
			Object initilizer syntax, introduced in C# 3.0 can be used to initilize eighter struct or a class.
		*/
		
		StructDemo sd3 = new StructDemo{
			Id = 103,
			Name = "Sara"
		};
		
		Console.WriteLine("Id is = {0} and Name = {1}", sd3.Id, sd3.Name);
	}	
}
