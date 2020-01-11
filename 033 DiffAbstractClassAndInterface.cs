//-----------------------------------------------------------------------------------------------
/*
	Abstract class vs. Interface
	
	Abstract class have the implementation of some of it's members (Methods), but an interface 
	can't have implementation for any of it's members.
	
	An interface can inherite from another interface only, and cannot inherit from another abstract class
	Where as an abstract class can inherit from another abstract class or another interface.
	
	A class can inherit from multiple interface at the same time, where as a class connot inherit from multiple classes at the same time.
	
	Abstract class members can have access modifiers where as an interface members cannot have access modifiers.
	
	Let's understand it by example.
*/
//-------------------------------------------------------------------------------------------------
using System;

public interface I2
{
	void AbsDemo2Print();
}

public abstract class AbsDemo : I2
{
	public abstract void print();
	
	public void Display()
	{
		Console.WriteLine("Display method....");
	}
	
	public void AbsDemo2Print(){
		Console.WriteLine("Interface method...");
	}
}

public class Program : AbsDemo
{
	public override void print(){
		Console.WriteLine("Abstract class method...");
	}
	public static void Main()
	{
		Program p = new Program();
		p.Display();
		p.print();
		p.AbsDemo2Print();
	}	
}

/*
    Output : 
      Display method....
      Abstract class method...
      Interface method...
*/
