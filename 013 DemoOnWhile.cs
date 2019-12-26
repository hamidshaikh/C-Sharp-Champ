//--------------------------------------------------------------------------------------
	/*
		Looping statement in C#.
		
		Looping statement help to iterate the statements for specific number of times.
		
		In this program we will discuss about 'while' loop.
		
		While loop check the condition first. If the condtion is true statement in while loop executed untill
		that condition become false. once the condition become false in this case while loop terminate it's execution
		and control goes to the next line.
		
		Note : Meke the condition such that that it will become false after some amount of execution otherwise 
		loop will go to infinite state and grab your processor and memory.
		
		There are 4 looping statement in C#
		
		1) while 2) do-while 3) for 4) foreach loop
		
		We will see all loops in great detail in our upcoming programs.		
		
	*/
//--------------------------------------------------------------------------------------
using System;
					
public class DemoOnWhile
{
	public static void Main()
	{
		int start = 0;
		//--------------------------------------------------------------------------------------
		// Read one number to process while loop nth number of times.
		//--------------------------------------------------------------------------------------
		
		Console.WriteLine("Enter a while loop end-point");
		
		int endPoint = int.Parse(Console.ReadLine());
		
		while(start < endPoint)
		{
			Console.WriteLine(start);
			start ++; // similar as start = start + 1;
		}
	}
}
