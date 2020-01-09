//-----------------------------------------------------------------------------------------------
/*
	Differences between classes and structs.
	1) Struct is a value type and classes are reference type.
	So whatever the differences applicable to reference type value type they are also applicable to classes
	and structs.
	
	2) value types hold there value in memory where they are declared, but reference type hold a reference to the 
	object in memory.
	
	3) value type distroyed immidiatly after the scope is lost. where as for reference type only the reference variable
	is destroyed after a scope is lost. the objetc is destroyed alter by garbage collector.
	
	4) When you copy struct into another struct, a new copy of that struct will be created and modification on one struct will 
	not affect the value contained by other struct.
	
	5) When you copy a class into another class, we only get a copy of reference variable. Both the reference variable point to the 
	same object to the heap, So, operation on  one variable will affect the values contained by the other reference variable.
	
	6) Struct can't have destructors, but classes can have destructors.
	7) Structs cannot have explicite parameterless constructors where as a class can.
	8) Structs can't inherit from aother class Where as a class can, Both structs and class can inherit from interface.
	9)Structs are sealed type.
	
	Let's try to inderstand it by simple example.
	
*/
//-------------------------------------------------------------------------------------------------
using System;

public struct StructDemo
{
	public int Id {get; set;}
	public string Name {get; set;}	
}

public class ClassDemo
{
	public int Id {get; set;}
	public string Name {get; set;}	
}

public class Program
{
	public static void Main()
	{
		StructDemo sd1 = new StructDemo();
		
		sd1.Id = 101;
		sd1.Name = "Mark";
		
		StructDemo sd2 = sd1;
		
		sd2.Id = 102;
		sd2.Name = "Marry";
		
		Console.WriteLine("sd1.Id = {0}, sd1.Id = {1}, && sd2.Name = {2}, sd2.Name = {3}", sd1.Id, sd1.Name, sd2.Id, sd2.Name);
		
		ClassDemo cd1 = new ClassDemo();
		
		cd1.Id = 101;
		cd1.Name = "Mark";
		
		ClassDemo cd2 = cd1;
		
		cd2.Id = 102;
		cd2.Name = "Marry";
		
		Console.WriteLine("cd1.Id = {0}, cd1.Id = {1}, && cd2.Name = {2}, cd2.Name = {3}", cd1.Id, cd1.Name, cd2.Id, cd2.Name);
	}	
}


/*
  Output : 
  sd1.Id = 101, sd1.Id = Mark, && sd2.Name = 102, sd2.Name = Marry
  cd1.Id = 102, cd1.Id = Marry, && cd2.Name = 102, cd2.Name = Marry
*/
