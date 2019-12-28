/*
	for and foreach loop in C#.
	
	for is the looping statement like while loop.
	
	for and foreach loop is used for iteration but the one normal defferance is that,
	whatever the class which implements the IEnumarable class internally is used with foreach loop.
	
	Otherwise we have to use for loop.
	
	Lets see it by example.
*/

using System;
					
public class Program
{
	public static void Main()
	{
		int[] arr = new int[3];
		
		arr[0] = 10;
		arr[1] = 20;
		arr[2] = 30;
		
		//--------------------------------------------------------------------------------------
		//Example of for loop.
		//--------------------------------------------------------------------------------------'
		
		Console.WriteLine("Output by 'for' loop");
		
		for(int i = 0; i <= arr.Length-1; i++){
			Console.WriteLine(arr[i]);
		}
		
		//--------------------------------------------------------------------------------------
		//Example of foreach loop
		//Array internally implement IEnumarable interface so we can use forw=each loop on array.
		//--------------------------------------------------------------------------------------
		
		Console.WriteLine("\nOutput by 'foreach' loop");
		
		foreach(var arrElement in arr){
			Console.WriteLine(arrElement);
		}
	}
}
