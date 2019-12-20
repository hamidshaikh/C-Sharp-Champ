//--------------------------------------------------------------------------------------------
/*
	//built in type in C#
	There are several buil in types in c#.
		
	Boolean type : only store true or false,
	Integral type : sbyte, byte, short, ushort, int, uint, long, ulong, char,
	Floating type : float and double,
	decimal type,
	string type.
		
	In case of 'Integral type' there is signed and unsigned types.
	The core difference is signed type can store negative value where as unsigned can store 
	value from 0 to it's maximum range.
		
	for more information you can wisit : 
	https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/built-in-types-table
	*/
//--------------------------------------------------------------------------------------------
using System;
public class BIT
{
  public static void Main()
  {
      //-------------------------------------------------------------------------------------------------
      //Below are the statements to demonstrate int and uint capacity to store values.
      //-------------------------------------------------------------------------------------------------

       Console.WriteLine("Min capacity = {0} and Max capacity = {1}", int.MinValue, int.MaxValue);
       Console.WriteLine("Min capacity = {0} and Max capacity = {1}", uint.MinValue, uint.MaxValue);
  }
}
