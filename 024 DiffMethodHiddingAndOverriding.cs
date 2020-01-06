//------------------------------------------------------------------------------------------------------------
/*
	Difference between method hidding and methid overriding.
	
	If base class referrence is pointing to dirived class object with virtual and override keywork then
	derived class method will be invoked then it is called method overriding.
*/
//------------------------------------------------------------------------------------------------------------
using System;
		
public class BaseClass {
	public virtual void Print(){
		Console.WriteLine("I am in base class");
	}
}

public class DerivedClassA : BaseClass {
	public override void Print(){
		Console.WriteLine("I am in derived class");
	}
}

public class DerivedClassB : BaseClass
{
	public new void Print(){
		Console.WriteLine("I am in derived class");
	}		
}

public class Program
{
	public static void Main()
	{
		/*
			If base class referrence is pointing to dirived class object with virtual and override keywork then
			derived class method will be invoked then it is called method overriding.
		*/
		BaseClass b = new DerivedClassA();
		b.Print();
		
		/*
			If base class referrence is pointing to dirived class object with virtual (Optional) and new keywork then
			base class method will be invoked then it is called method hidding.
		*/
		BaseClass b1 = new DerivedClassB();
		b1.Print();
	}
}

