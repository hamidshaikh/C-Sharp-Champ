//-----------------------------------------------------------------------------------------------
/*
	Abstract class in C#.
	
	A abstract keyword is used to create a abstract classes.
	
	An abstract class is incomplete so cannot be instantiated.
	
	An abstract class canoot be used as a sealed class.
	
	An abtract class may contain abstract members(Method, properties, indexers, and events), but not mandatory.
	
	A non-abstract class derived from a abstract class must provide implementation for all abstract member.
	
	if a class inherits an abstract class, there are two options avalable for that class.
	
	Option 1 : Provide implementation for all abtract members inherited from all abstract class.
	
	option 2 : If a class does not wish to provide implementation for all the abstract members
	inherited from abstract class, then the class has to be marked as abstrat.
	
	Let's understand it by example.
*/
//-------------------------------------------------------------------------------------------------
using System;

public abstract class AbsDemo1
{
	public abstract void print();
	
	public void Display()
	{
		Console.WriteLine("Display method....");
	}
}

public abstract class AbsDemo2 : AbsDemo1
{
	public abstract void AbsDemo2Print();
}

public class AbsDemo3 : AbsDemo2
{
	public override void print()
	{
		Console.WriteLine("Display method....");
	}
	
	public override void AbsDemo2Print()
	{
		Console.WriteLine("Display method....");
	}
}

public class Program : AbsDemo3
{
	public override void print()
	{
		Console.WriteLine("print method....");
	}
	public static void Main()
	{
		Program p = new Program();
		p.Display();
		p.print();
		p.AbsDemo2Print();
		
		//OR
		
		Console.WriteLine("--------------------------------------------------------------------");
		
		AbsDemo3 ad = new Program();
		ad.print();
		ad.Display();
		ad.AbsDemo2Print();
	}	
}
