//--------------------------------------------------------------------------------------------
/*
	string type in c#
	
	string are mostly used type in every programing language.
	it is a collection of character called string. 
	
	most of the time backslash are often used with string 
		
	for more information about backslash you can visit : 
	https://docs.microsoft.com/en-us/cpp/c-language/escape-sequences?view=vs-2019
*/
//--------------------------------------------------------------------------------------------
using System;
public class StrType
{
  public static void Main()
  {
      //-------------------------------------------------------------------------------------------------
      // Below are the code to demontrate of string with backslash and verbatim literal
      //-------------------------------------------------------------------------------------------------
	   
	     string name = @"C:\Users\Hamid Shaikh\Documents";
       Console.WriteLine("Drive Name is " + name);
	  
	  //-------------------------------------------------------------------------------------------------
    // '@' is a verbatim literal, backslash has a special meaning in c# so some time it is recommended to use this literal.
    //-------------------------------------------------------------------------------------------------
	   
	}
}
