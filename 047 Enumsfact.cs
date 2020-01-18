//-----------------------------------------------------------------------------------------------
/*
	Why Facts,
	
	1) Enumes are enumerations 
	2) Enums are stringly type constants, hence the explicite cast is needed to convert from enum type 
	to integral type and vice versa.
	
	Also an enum of one type cannot be explicitly assigned to an enum of another type even thought the underline 
	value of there menbers are the same.
	
	3) the default underline type of enum is int
	4) the default type of first element is zero.
	5) it is possible to costomize the underline type and values.
	6) Enum are value type.
	7) Enum keywords (All small letters) is used to create enumarations, where as Enum class, contains static
	GetValue() and getName() method which can be used to list Enum underline type values and names.
	
	Let's understand it by example.
*/
//-------------------------------------------------------------------------------------------------
using System;

public class Program
{
	public static void Main()
	{
		int[] IntValues = (int[])Enum.GetValues(typeof(Gender));
		string[] Names = Enum.GetNames(typeof(Gender1));
		
		foreach(var value in IntValues){
			Console.WriteLine(value);
		}
		
		foreach(var name in Names){
			Console.WriteLine(name);
		}
			
	}
}

// Default underline type is int and the value start at ZERO.
public enum Gender
{
	Male,
	Female,
	Unknown
}

//Gender underline type is now short and the value start at one.
public enum Gender1 : short
{
	Male = 1,
	Female,
	Unknown
}
