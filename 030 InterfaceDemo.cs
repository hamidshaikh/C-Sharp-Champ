//-----------------------------------------------------------------------------------------------
/*
	We create interface using interface keyword, just like a class interface also contains properies,
	methods, delegate, and events, but only declaration not implementation.
	
	it is compile time error to provide implementation for any interface member.
	
	Interface member public by defaul, and they don't allow explicit access modifiers.
	
	interface cannot contain fields.
	
	If a class or a structs inherit from interface, it must provide implementation for all interface member. Otherwise 
	we get a compile time error.
	
	A class can also inherit from more than one interface, A class that inherit this interface must prpvide implementation for 
	all interface member in the entire interface inheritance chain.
	
	We cannot create a instance of an interface, but an interface reference variable can point to a dirived class object.
	
	Interface Naming convention: Interface name are profixed with capital I.
	
	Let's understand it by example.
*/
//-------------------------------------------------------------------------------------------------
using System;

public interface IDemo1
{
	void print1();
}

public interface IDemo2 : IDemo1
{
	void print2();
}

public class Demo : IDemo1, IDemo2
{
	public void print1()
	{
		Console.WriteLine("Interface1 Method implementation");
	}
	public void print2()
	{
		Console.WriteLine("Interface2 Method implementation");
	}
}

public class Program
{
	public static void Main()
	{
		Demo d = new Demo();
		d.print1();
		d.print2();
	}	
}
