//--------------------------------------------------------------------------------------
	/*
		Common operator in C#.
		1) Assignment operator like =
		2) Arithmatic operator like +, -, *, /, %
		3) Comparison operator like ==, !=, >, >=, <, <=
		4) Conditional operator like &&, ||
		5) Ternary Operator like ?:
		6) Null Coalesing Operator ??
		
		In this program we will see each operator example.
	*/
//--------------------------------------------------------------------------------------
using System;
					
public class Program
{
	public static void Main()
	{
		//--------------------------------------------------------------------------------------
		// 1) Assignment operator : we are assigning value 10 to variable i.
		//--------------------------------------------------------------------------------------
		
		int i = 10;
		Console.WriteLine("i = {0}", i);
		
		//--------------------------------------------------------------------------------------
		// 2) Arithmatic operator : Output of below code will be 10 / 2 = 5
		//--------------------------------------------------------------------------------------
		
		int number = 10, devident = 2;
		Console.WriteLine(number + " / " + devident + " = " + (number / devident));
		
		//--------------------------------------------------------------------------------------
		// 3) Comparison operator : Output of below code will be '10 / 2 = 5 Is number 10 : true'
		//--------------------------------------------------------------------------------------
		
		bool isNumber10 = false;
		if(number == 10)
			isNumber10 = true;
		else
			isNumber10 = false;
		Console.WriteLine("Is number 10 : {0}", isNumber10);
		
		//--------------------------------------------------------------------------------------
		// 4) Ternary Operator : Ternary operator also called short hand operator
		//--------------------------------------------------------------------------------------
		
		number = 20;
		isNumber10 = number== 10 ? true : false;
		Console.WriteLine("Is number 10 : {0}", isNumber10);
		
		//--------------------------------------------------------------------------------------
		// 5) Null Coalesing Operator : We will see in next example.
		//--------------------------------------------------------------------------------------
	}
}
