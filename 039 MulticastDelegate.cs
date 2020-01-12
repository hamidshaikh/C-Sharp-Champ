//-----------------------------------------------------------------------------------------------
/*
	Multicast delegate in C#.
	
	A multicast delegate is a delegate that has reference to more than one function. When you invoke a 
	multicast delegate, all the functions the delegate is pointing to are invoked.
	
	There are two approches to create a multicast delegates, depending on a approch you use.
	
	+ or += to register a method with delegates
	- or -+ to un-register a method with delegates.
	
	Note : A multicast delegates, invoke the method in invocation list, in the same order in which they are added.
	
	If the delegates has a return type other than void and if the delegate is a multicast delegates, then only the value 
	of last invoked method will be returned. Along the same lines, if the delegates has an out parameter, the value of the output 
	parameter, will be returned assign by last parameter.
	
	Common interview question : Where do you use multicast delegates.
	
	Multicast delegates make inplemntation of observer design pattern very simple. 
	Observer pattern also called as publish/subscribe pattern.
	
	Let's understand it by example.
*/
//-------------------------------------------------------------------------------------------------
using System;

public delegate void DelegateDemo();

public class Program
{
	public static void Main()
	{
		DelegateDemo del = new DelegateDemo(method1);
		del += method2;
		
		del();
	}	
	
	public static void method1(){
		Console.WriteLine("Method1 called");
	}
	
	public static void method2(){
		Console.WriteLine("Method2 called");
	}
	
	public static void method3(){
		Console.WriteLine("Method3 called");
	}
}

/*
  Output : 
      Method1 called
      Method2 called
*/
