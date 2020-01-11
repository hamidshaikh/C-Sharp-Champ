//-----------------------------------------------------------------------------------------------
/*
	Multiple inheritance using interface.
	
	It is not possible multiple inheritance using classes but using interface we can implement
	the concept of multiple inheritance.
	
	Let's understand it by example.
*/
//-------------------------------------------------------------------------------------------------
using System;

public interface IA
{
	void methosA();
}

public class A : IA
{
	public void methosA(){
		Console.WriteLine("A");
	}
}

public interface IB
{
	void methosB();
}

public class B : IB
{
	public void methosB(){
		Console.WriteLine("B");
	}
}

public class C : IA, IB
{
	A a = new A();
	B b = new B();
	
	public void methosA(){
		a.methosA();
	}
	
	public void methosB(){
		b.methosB();
	}
}

public class Program
{
	public static void Main()
	{
		C c = new C();
		c.methosA();
		c.methosB();
	}	
}

/*
  A
  B
*/
