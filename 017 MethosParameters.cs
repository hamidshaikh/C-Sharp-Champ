//------------------------------------------------------------------------------------------------------------
/*
	Method parameters in C#.
	
	There are four types of parameter in C#.
	1) Value parameter
	2) Reference parameter
	3) Out parameter
	4) Parameter array.
*/
//------------------------------------------------------------------------------------------------------------
using System;
					
public class MethodsDemo
{
	public static void Main()
	{
		//------------------------------------------------------------------------------------------------------------
		// 1) Value parameter : Create a copy of parameter passed, so modification does not affect each other.
		//------------------------------------------------------------------------------------------------------------
		MethodsDemo md = new MethodsDemo();
		Console.WriteLine("Addition is {0}", md.Add1(10, 20));
		
		//------------------------------------------------------------------------------------------------------------
		// 2) Reference parameter : The ref method parameter keyword on method parameter causes a method to refer to
		// the same variable that was passed into a method. Any changes made to the parameter in method will be reflected
		// in that variable when control passes back to the calling method.
		//------------------------------------------------------------------------------------------------------------
		
		int total = 0;
		md.Add2(30, 40, ref total);
		
		Console.WriteLine("Total is {0}", total);
		
		//------------------------------------------------------------------------------------------------------------
		// 3) Out parameter : Use when you want a method to return more than one value/
		//------------------------------------------------------------------------------------------------------------
		
		int product = 0;
		int sum = md.Add3(6, 2, out product);
		
		Console.WriteLine("Sum is {0} and product is {1}", sum, product);
		
		//------------------------------------------------------------------------------------------------------------
		// 4) Parameter array : The params keyword let's you specify a method parameter a method parameter that takes a 
		// variable number of argument.
		// Params keyword must be the last keyword in method declaration and only one params keyword is permited in method declaration.
		//------------------------------------------------------------------------------------------------------------
		
		md.Add4("Number List", 1, 2, 3, 4, 5);
		
	}
	
	public int Add1(int num1, int num2){
		return (num1 + num2);
	}
	
	public int Add2(int num1, int num2, ref int sum){
		sum = num1 + num2;
		return (num1 + num2);
	}
	
	public int Add3(int num1, int num2, out int product){
		product = num1 * num2;
		return (num1 + num2);
	}
	
	public void Add4(string name, params int[] nums){
		Console.WriteLine(name);
		foreach(var num in nums){
			Console.WriteLine(num);
		}
	}
}
