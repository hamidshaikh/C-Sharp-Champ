//--------------------------------------------------------------------------------------
	/*
		Conditional statement in C#
		
		There are three conditional statement in C#
		1) if 
		2) if-else
		3) switch
		
		Here in this example we will discuss about if and if-else.
		along with that we will see the defferance between 
		1) || and & |
		2) && and &
		
		So let's start.....
	*/
//--------------------------------------------------------------------------------------
using System;
					
public class ArraysExample
{
	public static void Main()
	{
		//--------------------------------------------------------------------------------------
		/* 1) if statement
		When we have to check only single condition then we shoud use if block 
		*/
		//--------------------------------------------------------------------------------------
		
		Console.WriteLine("Enter a number");
		
		int i = int.Parse(Console.ReadLine());
		
		if(i == 1)
		{
			Console.WriteLine("You enterd one");
		}
		
		//if single statement is there inside if block then we can write it without {} (curly brace)
		if(i == 2)
			Console.WriteLine("You enterd two");
		
		if(i == 3)
			Console.WriteLine("You enterd two");
		
		if(i != 1 && i != 2 && i != 3)
			Console.WriteLine("Number not between 1 and 3");
		
		//--------------------------------------------------------------------------------------
		/* 2) if-else statement
		When we have to check only single condition then we shoud use if block 
		if one of the condition not match with if block then else part will be executed.
		And we can use nested if else also (if else within another if-else)
		we can opetime above program.
		*/
		//--------------------------------------------------------------------------------------
		
		if(i == 1)
			Console.WriteLine("You enterd one");
		else if(i == 2)  //if single statement is there inside if block then we can write it without {} (curly brace)
			Console.WriteLine("You enterd two");
		else if(i == 3)
			Console.WriteLine("You enterd two");
		else
			Console.WriteLine("Number not between 1 and 3");
		
		//--------------------------------------------------------------------------------------
		/* Difference between || | and &&, &
		1) || and |
		
			if we write || then if the first condition is true then it will not check for second condition
			if we wrire | then if first condition is true then also it check's for the second condition.

			So || is much faster than |
		
		2) && and & 
		
			if we write && then if first condition is true then only it goes for second condition
			otherwise it executes the next part of a program.

			if we write & then if first condition is true or false it goes for second condition

			So && is much faster than &

			|| and && also called short hand operator.
		*/
		//--------------------------------------------------------------------------------------
	}
}
