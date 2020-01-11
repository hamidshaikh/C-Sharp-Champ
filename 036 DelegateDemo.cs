//-----------------------------------------------------------------------------------------------
/*
	Delegate in C#.
	
	A delegate is a type safe function pointer, that is it holds reference(pointer) to a function.
	
	The signature of delegate must match the signature of function, a delegate points to, otherwise 
	you get compile time error. This is the reason delegates are called as type safe function pointer.
	
	A delegates is similar to classes you can create instance of it, and when you do, you pass in the function name as a parameter 
	to delegate constructor, and it is to this function the delegates will point to.
	
	Tips to remember delegate syntax : Delegate syntax very much similar to a method with a delegate keyword.
	
	Let's understand it by example.
*/
//-------------------------------------------------------------------------------------------------
using System;

public delegate void deligateDemo(string papam);

public class Program
{
	public static void Main()
	{
		deligateDemo dd = new deligateDemo(message);
		dd("This is message");
	}	
	
	public static void message(string msg)
	{
		Console.WriteLine(msg);
	}
}

/*
  Output :
    This is message
*/
