//-----------------------------------------------------------------------------------------------
/*
	Multiple class inheritance problem.
	
	Supose there is a situation like...
	
	1) Class B and class C inherit from class A
	2) class D inherit from both classes B and C
	3) if a method in D calls a method defined in A(and does not override the method) and B and C have overriden 
	that method differently, then from which class does it inherit: B OR C
	
	This ambiguity is called as diamond problem.
	
	Let's understand it by example.
*/
//-------------------------------------------------------------------------------------------------
using System;

public class A
{
	public virtual void print(){
		Console.WriteLine("Inside A");
	}
}

public class B : A
{
	public override void print(){
		Console.WriteLine("Inside B");
	}
}

public class C : A
{
	public override void print(){
		Console.WriteLine("Inside C");
	}
}

// it gives a compile time error stating that "Class D cannot have multiple base class C and A"
public class D : C//, A
{
	public override void print(){
		Console.WriteLine("Inside D");
	}
}

public class Program
{
	public static void Main()
	{
		A d = new D();
		d.print();
	}	
}

/*
  Output : 
    Inside D
*/
