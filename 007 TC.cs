//--------------------------------------------------------------------------------------
	/*
		Type conversion in C#
		Basically there are two type of conversion
		1) Implicite conversion and 
		2) Explicite conversion.
		
		we will discuss these conversion in this example so let's start.
	*/
//--------------------------------------------------------------------------------------
using System;
					
public class TC
{
	public static void Main()
	{
		//--------------------------------------------------------------------------------------
		// 1) Implicite Conversion
		//--------------------------------------------------------------------------------------
		
		int i = 10;
		float f = i;
		
		//--------------------------------------------------------------------------------------
		// In above lines we siigned variable 'i' to 'j', So in this case compiler do implicite 
		//conversion because we are assigning smaller value to bigger type there is no loss of information.
		//--------------------------------------------------------------------------------------
		
		Console.WriteLine("f = {0}", f);
		
		//--------------------------------------------------------------------------------------
		/* 2) Explicite conversion.
		
		We can perform explicite conversion by four ways as
		a) using ({type}) like (int)
		b) using Convert class
		c) using Parse method (In case of string)
		d) using TryParse method (In case of string)
		*/
		//--------------------------------------------------------------------------------------
			
		//--------------------------------------------------------------------------------------
		// a) using ({type}) like (int)
		//--------------------------------------------------------------------------------------
		
		float floatType = 445.548F;
		int intType = (int)floatType;
		
		Console.WriteLine(intType);
		
		//--------------------------------------------------------------------------------------
		// b) using Convert class
		//--------------------------------------------------------------------------------------
		
		intType = Convert.ToInt32(floatType);
		Console.WriteLine(intType);
		
		//--------------------------------------------------------------------------------------
		/*
		In above two types of explicite conversion there is slight difference
		In first approch 
		If value of float is more than the capicity of int type then the result will be the smallest 
		capicity of int it will not throw any exception.
		
		In second approch
		If value of float is more than the capicity of int type then it will throw an exception.
		
		See below example but it is in comment to avoid program execution intruption.
		*/
		//--------------------------------------------------------------------------------------4
		
		floatType = 9879895556545.45457F;
		intType = (int)floatType;
		Console.WriteLine(intType);
		
		//---------------------------------If you are getting excepton then comment this block-----------------------------------------------------
		/*floatType = 9879895556545.45457F;
		intType = Convert.ToInt32(floatType);
		Console.WriteLine(intType);*/
		//---------------------------------If you are getting excepton then comment this block-----------------------------------------------------
		
		//--------------------------------------------------------------------------------------
		// c) using Parse method (In case of string)
		//--------------------------------------------------------------------------------------
		
		string strNumber = "123";
		intType = int.Parse(strNumber);
		Console.WriteLine(intType);
		
		//--------------------------------------------------------------------------------------
		// d) using Parse method (In case of string)
		//--------------------------------------------------------------------------------------
		
		strNumber = "9845454554548455";
		int result = 0;
		bool isConverted = int.TryParse(strNumber, out result);
		Console.WriteLine("result = {0} and isConverted = {1}", result, isConverted);
		
		//--------------------------------------------------------------------------------------
		//TryParse method takes two argument and return the boolean result.
		//If any exception is there then it returns false otherwise false.
		// --------------------------------------------------------------------------------
		
	}
}
