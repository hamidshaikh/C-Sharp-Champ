//------------------------------------------------------------------------------------------------------------
/*
	Optional parameter using default in C#.
	
	* Specify parameter default.
	
	In the following method, parameter b and c are optional
	
	Test(1, 2);
	When we invoke this method as shown above , "1" as passed as argument for parameter "a" and "2" is passed as
	the argument for parameter "b" by default.
	
	My intesion is to pass "2" as a argument for parameter "c". To achive this we can make use of method parameter,
	as shown below. Notice that, I have specified the name of the parameter for which value "2" is being passed.
	
	Test(1, c: 2)
	
	Let's see the simple example...
*/
//------------------------------------------------------------------------------------------------------------
using System;

public class Program
{
	public static void Main()
	{
		Test(1, 2);
		Test(1, c : 2);
	}
	
	public static void Test(int a, int b = 10, int c = 20)
	{
		Console.WriteLine("a = {0}", a);
		Console.WriteLine("b = {0}", b);
		Console.WriteLine("c = {0}", c);
	}
}
/*
	Output : 
		a = 1
		b = 2
		c = 20
		a = 1
		b = 10
		c = 2
*/
