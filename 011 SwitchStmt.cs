//--------------------------------------------------------------------------------------
	/*
		Switch statement in C#
		
		Instead of using multiple if-else statement we can use switch statement.
		it increases code readability.
		
		switch have the default case also like else block in if-else.
	*/
//--------------------------------------------------------------------------------------
using System;
					
public class SwitchStmt
{
	public static void Main()
	{
		Console.WriteLine("Enter a number");
		int i = int.Parse(Console.ReadLine());
		
		switch(i){
			case 1 : 
				Console.WriteLine("You entered one");
				break;
				//We can write both statement one after anather also.
			case 2 : 
			case 3 : 
				Console.WriteLine("You entered eighter two or three");
				break;
			default : 
				Console.WriteLine("User not entered eighter 1, 2 or 3");
				break;
		}
	}
}
