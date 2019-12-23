//--------------------------------------------------------------------------------------
	/*
		Comments in C#
		
		Comment is nothing but the document part of the complex code.
		It is not recommended to comment out each line of code.
		
		Whatever we make comment in program compiler ignores that line for execution.
		
		There is three types of comment in C#
		1) for single line comment
		2) multiline comment
		3) XML comment
		
		Keyboard Shortcut for comment CTR+C
		Keyboard Shortcut for comment CTR+U
		
		In most of our code we are using comment to explain.
	*/
//--------------------------------------------------------------------------------------
using System;
					
public class ArraysExample
{
	public static void Main()
	{
		//--------------------------------------------------------------------------------------
		// 1) Single line comment (//)
		// we can use // (double slash) to make comment for single line.
		//--------------------------------------------------------------------------------------
		
		int[] arr = new int[3];
		arr[0] = 10;
		arr[1] = 20;
		//arr[2] = 30;
		
		//--------------------------------------------------------------------------------------
		// In above line we make comment to arr[2] = 30; 
		//--------------------------------------------------------------------------------------
		
		//--------------------------------------------------------------------------------------
		// 2) Multiline comment (/**/)
		//If we want more than one line of comment then we can use /**/ like
		//--------------------------------------------------------------------------------------
		
		/*
		int i;
		string s;
		*/
		
		Console.WriteLine(arr[1]);
		
		//--------------------------------------------------------------------------------------
		// 3) XML based comments (///)
		// These comments are the documentory comment. which is display in intellicense if we hour move over specific
		//class or method. as sj=hown below.
		//--------------------------------------------------------------------------------------
		
	}
}

///<summary>
///This is comment demo class
///</summary>
public class CommentDemo{

}
