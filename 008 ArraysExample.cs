//--------------------------------------------------------------------------------------
	/*
		Arrays in C#
		Array is a collection of simmilar data type
		
		Advantage : An arrays are strongly typed
		Disadvantages : An array cannot grow in size once initilized.
	*/
//--------------------------------------------------------------------------------------
using System;
					
public class ArraysExample
{
	public static void Main()
	{
		//--------------------------------------------------------------------------------------
		// 1) To create an array we need to specify the size of an array in advance.
		//--------------------------------------------------------------------------------------
		
		int[] arr = new int[3];
		arr[0] = 10;
		arr[1] = 20;
		arr[2] = 30;
		
		//--------------------------------------------------------------------------------------
		// If we want to access 2nd element of an array then 
		//--------------------------------------------------------------------------------------
		
		Console.WriteLine(arr[1]);
		
		//--------------------------------------------------------------------------------------
		// If we try to insert element at arr[3] then we will get runtime error
		//telling that IndexOutOfRangeException.
		//--------------------------------------------------------------------------------------
		
		//arr[3] = 40;
	}
}
