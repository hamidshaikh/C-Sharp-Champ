//--------------------------------------------------------------------------------------------
  /*
    This include to steps:
    1) read from console.
    2) Writing to console.
    Basically there are two ways to write output to the console
      a) Concatination
      b) Place holder syntax - Most preferred
  */
//--------------------------------------------------------------------------------------------
using System;
//--------------------------------------------------------------------------------------------
  //'RWTC' is a name of class which is public in this example.
//--------------------------------------------------------------------------------------------
public class RWTC
{
  //--------------------------------------------------------------------------------------------
	  // 'Main' method is a entry point of application, so here application starts from main method.
  //--------------------------------------------------------------------------------------------
	public static void Main()
	{
  //--------------------------------------------------------------------------------------------
		/*veriable declaration : We can variable at any place of our program,
		but it is always recomended to declare variable at top of the program code.
		It increases code readability.*/
   //--------------------------------------------------------------------------------------------
   
		string firstName, lastName;
    
    //--------------------------------------------------------------------------------------------
		  //Prompt the user to enter something.
    //--------------------------------------------------------------------------------------------
    
		Console.WriteLine("Enter your first name");
    
    //--------------------------------------------------------------------------------------------
      /*When user enter his name then read that name using 'ReadLine' method 
      present in 'System' namespace and store that output to one variable called 'firstName'.*/
    //--------------------------------------------------------------------------------------------
    
		firstName = Console.ReadLine();
		
    //--------------------------------------------------------------------------------------------
      //Same for variable 'lastName
    //--------------------------------------------------------------------------------------------
    
		Console.WriteLine("Enter your last name");
		lastName = Console.ReadLine();
    
		//--------------------------------------------------------------------------------------------
		//a) Concatination - Print the User name to the console.
		//Console.WriteLine("Welcome " + userName); //To see it's output you can uncomment this code.
    //--------------------------------------------------------------------------------------------
		
    //--------------------------------------------------------------------------------------------
		  //b) Place holder syntax - Most preferred.
    //--------------------------------------------------------------------------------------------
		Console.WriteLine("Welcome {0} {1}", firstName, lastName);
	}
}
