//-----------------------------------------------------------------------------------------------
/*
	Explicite interface implemntation.
	
	We two same signature method contains in both the interface then there will be the amguity that 
	which interface method will be called, so to clarify that which interface method invoking so 
	we should do it using explicite interface.
	
	Or in general sense if there is need to implement specific interface method then we can use explicite interface.
	
	There are two ways to implement it.
	
	2) By casting
	2) By making reference of that interface.
	
	Let's understand it by example.
*/
//-------------------------------------------------------------------------------------------------
using System;

public interface I1
{
	void print();
}

public interface I2
{
	void print();
}

public class Demo : I1, I2
{
	void I1.print()
	{
		Console.WriteLine("I1 Method implementation");
	}
	
	void I2.print()
	{
		Console.WriteLine("I2 Method implementation");
	}
}

public class Program
{
	public static void Main()
	{
		Demo d = new Demo();
		((I1)d).print();
		((I2)d).print();
		
		//OR
		
		Console.WriteLine("--------------------------------------------------------------------");
		
		I1 i1 = new Demo();
		i1.print();
		
		I2 i2 = new Demo();
		i2.print();
	}	
}
