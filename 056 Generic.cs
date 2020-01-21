//------------------------------------------------------------------------------------------------------------
/*
	Generics are introduced in C# 2.0. Generics allow us to design classes and methods decoupled from 
	the datatype.
	
	Generic classes are extensively used by collection classes in System.Collection	namespace.
	
	One way of making AreEqual() method resuable, is to use object type parameter, Since every type in .Net directly 
	or Indirectly inheriit from System.Object type,
	AreEqual() method work with any data type, but the problem is performance degradation due to boxing and unboxing happening
	
	Also, AreEqual() method is no longer type safe, it is now possible to pass integer for the first parameter, and the string 
	for the second parameter, it does't make sense to comppare string with integers.
	
	So, the problem with using System.Object type is that
	
	1. AreEqual method is not type safe.
	2. Performance degradation due to boxing and Unboxing.
	
	to make AreEqual() method generic, we specially a type parameter using regular. brackets as shown below
	
	public static bool AreEqual<T>(T value1, T value2)
	
	At the point, when the client code wants to invike this method, they need to specify the type, they want the method
	to operate on. If the user want the AreEqual() method to work with integers, they can invoke the method specifying int 
	as the datatype using angular bracket as shown below.
	
	bool Equal = Calculator.AreEqual<int>(10, 10);
	
	To compare with string data type
	
	bool Equal = Calculator.AreEqual<string>('AB', 'BA');
	
	In this example we make the method generic. Along the same line, it is also possible to make classes,
	interface and delegate generic.
	
	Let's understand it by example.
*/
//------------------------------------------------------------------------------------------------------------
using System;
using System.Reflection;

public class Calculator//<T> We can use generic class like this but here we are making method as generic
{
	public bool AreEqual<T>(T value1, T value2){
		return value1.Equals(value2);
	}
}
		
public class Program
{
	public static void Main()
	{
		Calculator calculator = new Calculator();
		bool isEqual = calculator.AreEqual<int>(10, 10);
		
		if(isEqual)
			Console.WriteLine("Equal");
		else
			Console.WriteLine("Not Equal");
			
		isEqual = calculator.AreEqual<string>("AB","BA");
		
		if(isEqual)
			Console.WriteLine("Equal");
		else
			Console.WriteLine("Not Equal");
	}
}

/*
	Output : 
		Equal
		Not Equal
*/
