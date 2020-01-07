//-----------------------------------------------------------------------------------------------
/*
	Method overloading in C#.
	
	Method overloading and function overloading terms are used interchangibaly.
	
	Method overloading allow a class to have multiple methods with the same name, but with different signature,
	So in C# functions can be overloaded based on the number, type(int, float etc.) and a kind (value, ref or out).
	of parameter.
	
	the signature of method consist of the name of the method and the type, kind(value, ref, out) and the number of formal parameter.
	the signature of method does not include the return type and params modifier, So it is not possible to overload a function,
	just based on the return type or params modifier.
	
*/
//-------------------------------------------------------------------------------------------------
using System;

public class MethodOverloading
{
	public void Add(int FN, int SN, int TN){
		Console.WriteLine(FN + SN + TN);
	}
	
	public void Add(int FN, int SN, float TN){
		Console.WriteLine(FN + SN + TN);
	}
	
	public void Add(int FN, int SN, out int sum){
		sum = FN + SN;
		Console.WriteLine(FN + SN);
	}
	
				//OR
	/*
	public void Add(int FN, int SN, ref int sum){
		sum = FN + SN;
		Console.WriteLine(FN + SN);
	}
	*/
}

public class Program
{
	public static void Main()
	{
		MethodOverloading mol = new MethodOverloading();
		mol.Add(10, 20, 30);
		mol.Add(40,50,50.5F);
		
		int sum = 0;
		mol.Add(60, 70, sum);
	}	
}
