//------------------------------------------------------------------------------------------------------------
/*
	Methods in C#
	
	Methods is collections of statement which can be excuted when specific call made to it.
	
	Basically there are two types of method.
	1) Instance method
	2) static method
	
	Method can take value as a parameter and return value as a return value to the calling section.
*/
//------------------------------------------------------------------------------------------------------------
using System;
					
public class MethodsDemo
{
	public static void Main()
	{
		//------------------------------------------------------------------------------------------------------------
		// 1) Call to the instance Method : We can call instance method by creating object of the class.
		//------------------------------------------------------------------------------------------------------------
		MethodsDemo md = new MethodsDemo();
		Console.WriteLine("Addition is {0}", md.Add(10, 20));
		
		//------------------------------------------------------------------------------------------------------------
		// 2) Call to the static Method : We can call static method directly using class name.
		//------------------------------------------------------------------------------------------------------------
		
		Console.WriteLine("Addition is {0}", MethodsDemo.Addition(30, 40));
	}
	
	//------------------------------------------------------------------------------------------------------------
	// 1) Instance Method : Instance method object specific method which can be called by creating objects
	//------------------------------------------------------------------------------------------------------------
	
	public int Add(int num1, int num2){
		return (num1 + num2);
	}
	
	//------------------------------------------------------------------------------------------------------------
	// 2) Static Method : Instance method object specific method which can be called by creating objects
	//------------------------------------------------------------------------------------------------------------
	
	public static int Addition(int num1, int num2){
		return (num1 + num2);
	}
}
