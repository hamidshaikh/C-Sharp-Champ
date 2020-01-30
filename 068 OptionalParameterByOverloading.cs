//------------------------------------------------------------------------------------------------------------
/*
	Optional parameter in C#.
	
	there are four ways to make method parameter optional.
	1) Use Params array.
	2) Method overloading 
	3) Specify parameter default.
	4) Use optional attribute that is present in System.interopServices namespace
	
	Let's see the simple example...
*/
//------------------------------------------------------------------------------------------------------------
using System;

public class Program
{
	public static void Main()
	{
		AddNumber(10, 20);
		AddNumber(10, 20, new int[] { 30, 40, 50 });
	}	
	
	public static void AddNumber(int FN, int SN)
	{
		AddNumber(FN, SN, null);
	}
	
	public static void AddNumber(int FN, int SN, int[] LN)
	{
		int result = FN + SN;
		
		if(LN != null)
		{
			foreach(int number in LN)
			{
				result += number;
			}
		}
		
		Console.WriteLine("Addition is {0}", result);
	}
}
/*
	Output : 
		Addition is 30
		Addition is 150
*/
