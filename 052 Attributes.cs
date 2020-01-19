//------------------------------------------------------------------------------------------------------------
/*
	Attributes in C#.
	
	Attribute allow you to add declarative information to your program. This information can then be quired at runntime
	using reflection.
	
	There are several pre-defined attribute provided by .Net It is possible to create your own custome attributes.
	
	A few-predifined attributes with in the .Net framework:
	obsolete - Mark type and type member as outdated.
	WebMothod - To expose method as XML web service method
	Serializable - Indicate that a class can be serialized
	
	It is possible to customize the attribute using parameters.
	
	An attribute is a class that inherits from System.Attribute base class.
	
	Let's understand it by example.
*/
//------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

public class Calculator
{
	//if we pass want 3 or more parameters addition then this method will not support
	//So we create new method and mark this method as obsolete
	
	[Obsolete("Use Add(List<int> numbers)")]
	public static int Add(int Fn, int Sn){
		return Fn + Sn;
	}
	
	public static int Add(List<int> numbers){
		int sum = 0;
		foreach(int number in numbers){
			sum += number;
		}
		return sum;
	}
}
		
public class Program
{
	public static void Main()
	{
		Console.WriteLine(Calculator.Add(10, 20));
		Console.WriteLine(Calculator.Add(new List<int>{10, 20, 30}));
	}
}

/*
	Output : 
		30
		60
*/
