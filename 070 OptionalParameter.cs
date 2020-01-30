//------------------------------------------------------------------------------------------------------------
/*
	Optional parameter using OptionalAttribute in C#.
	
	This attribute present in System.Runtime.InteropServices;
	
	Let's see the simple example...
*/
//------------------------------------------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;

public class Program
{
	public static void Main()
	{
		AddNumber(10, 20, new object[] { 30, 40, 50 });
	}	
	
	public static void AddNumber(int FN, int SN, [Optional] object[] LN)
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
		Addition is 150
*/
