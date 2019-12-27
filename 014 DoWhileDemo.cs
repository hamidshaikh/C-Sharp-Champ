//--------------------------------------------------------------------------------------
	/*
	do-while loop in C#.
	
	do-while loop executes minimum one time whether condition is true or false.
	
	Let's try to understand with an example.
	*/
//--------------------------------------------------------------------------------------
using System;
					
public class DemoOnWhile
{
	public static void Main()
	{
		//--------------------------------------------------------------------------------------
		//In this tutorial we are going to undertand it be two example.
		//--------------------------------------------------------------------------------------
		string choice = String.Empty;
		
		do{	
			int stratIndex = 0;
			Console.WriteLine("Enter your targer number");
			int targetNumber = int.Parse(Console.ReadLine());

			while (stratIndex <= targetNumber){
				Console.WriteLine(stratIndex);
				stratIndex = stratIndex + 2;
			}
			
			do{
				Console.WriteLine("Do you want to continue type 'Yes' OR 'No' ?");
				choice = Console.ReadLine().ToUpper();
				if(choice != "YES" && choice != "NO")
					Console.WriteLine("Your choice {0} is invalid", choice);
			}while(choice != "YES" && choice != "NO");
		}while(choice == "YES");
		
		int totalCoffeeCost = 0;
		choice = string.Empty;
		
		
		do{
			Console.WriteLine("Do you want to execute offie example, Yes or No");
			choice = Console.ReadLine().ToUpper();
			if(choice != "YES" && choice != "NO")
				Console.WriteLine("Your choice {0} is invalid", choice);
		}while(choice != "YES" && choice != "NO");
		
		if(choice == "YES"){
			do{
				int userSelection = -1;

				do{
					Console.WriteLine("Please select yoour coffee size 1 - small, 2 - medium, 3 - large");
					userSelection = int.Parse(Console.ReadLine());

					switch(userSelection){
						case 1 : 
							totalCoffeeCost += 10;
							break;
						case 2 : 
							totalCoffeeCost += 20;
							break;
						case 3 : 
							totalCoffeeCost += 30;
							break;
						default : 
							Console.WriteLine("Your choice {0} is invalid", userSelection);
							break;
						}
					}while(userSelection != 1 && userSelection != 2 && userSelection != 3);

					choice = string.Empty;

					do{
						Console.WriteLine("Do yo want to buy another coffee, Yes or No");

						choice = Console.ReadLine().ToUpper();
						if(choice != "YES" && choice != "NO"){
							Console.WriteLine("Your choice {0} is invalid", choice);
						}
					}while(choice != "YES" && choice != "NO");

					if(choice != "YES" && choice != "NO"){
						Console.WriteLine("Your choice {0} is invalid", choice);
					}
				}while(choice != "NO");

			Console.WriteLine("Thank you for visiting us,");
			Console.WriteLine("Your total bill amount is {0}", totalCoffeeCost);
		}
		else
			Console.WriteLine("Program terminated");
	}
}
