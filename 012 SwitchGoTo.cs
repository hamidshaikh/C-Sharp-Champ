//--------------------------------------------------------------------------------------
	/*
		Switch statement in C# - Part - 2
		In this program we are going to see one example using switch amd goto statement.
		
		Note : We should try to avaoid goto statement because it create program more complicated.
		By switching control to any part of program.
	*/
//--------------------------------------------------------------------------------------
using System;
					
public class SwitchStmt
{
	public static void Main()
	{
		int totalCoffieAmount = 0;
		
		Choice:
		Console.WriteLine("Please enter your coffie size 1 - small, 2 - medium, 3 - large");
		int coffieSize = int.Parse(Console.ReadLine());
		
		switch(coffieSize){
			case 1 : 
				totalCoffieAmount += 10;
				break;
				//We can write both statement one after anather also.
			case 2 : 
				totalCoffieAmount += 15;
				break;
			case 3 : 
				totalCoffieAmount += 20;
				break;
			default : 
				Console.WriteLine("Input '{0}' was wrong ...", coffieSize);
				goto Choice;
        //It not make any sense to write break statement after goto. 
		}
		
		Decision:
		Console.WriteLine("Do you want to buy anathor coffie");
		string userChoice = Console.ReadLine();
		
		switch(userChoice.ToUpper())
		{
			case "YES" : 
				goto Choice;
			case "NO" :
				break;
			default : 
				Console.WriteLine("Your input '{0}' was wrong", userChoice);
				goto Decision;
		}
		
		Console.WriteLine("Thank you for buying");
		Console.WriteLine("Your total bill is {0}", totalCoffieAmount);
		
	}
}
