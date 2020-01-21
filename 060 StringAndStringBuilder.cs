//------------------------------------------------------------------------------------------------------------
/*
	Difference between String and StringBuilder.
	
	System.String is immutable where as StringBuilder is mutable.
	
	A Stringbuilder objects are mutable, they offer better performance than string object of type 
	System.String when heavy manipulation is required.
	
	Let's understand it by example.
*/
//------------------------------------------------------------------------------------------------------------
using System;
using System.Text;

public class Program
{
	public static void Main()
	{
		/*
		
		Here each time new object will be created for each assignment. so as a performance stand point 
		string is not recomended.
		
		string S1 = string.Empty;
		for(int i = 1; i <= 10000; i++){
			S1 += i.ToString() + " ";
		}

		Console.WriteLine(S1);	
		
		*/
		
		StringBuilder stringBuilder = new StringBuilder();
		
		for(int i = 1; i <= 10000; i++){
			stringBuilder.Append(i.ToString() + " \n");
		}
		
		Console.WriteLine(stringBuilder);
	}	
}
