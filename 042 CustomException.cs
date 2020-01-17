//-----------------------------------------------------------------------------------------------
/*
	Custom exception in C#.
	
	1. Create a class that derived from System.Exception class. As a conversation, end the class name with Exception Suffix.
	All the .Net suffix end with, Exception suffix.
	
	2. provide public constructor, that takes in a string parameter. This constructor simply passes the string parameter,
	to the base exception class constructor.
	
	3. using inner exception, you can also track back the origional exaception. if you want to provide the capability of your
	custom eception then overload the custructor accordingly.
	
	4. If you want your exception class object to work accross application domains, then the object must be serializable.
	To make your class rerializable mark it with Serializable attribute and provide a constructor that invokes a base exception
	class constructor that takes in SerializationInfo and StreamingContext object as a parameters.
	
*/
//-------------------------------------------------------------------------------------------------
using System;

public class Program
{
	public static void Main()
	{
		try
		{
			try
			{
				int zero = 0;
				int num = 10 / zero;
			}
			catch(DivideByZeroException exception){
				throw new userAlreadyLoggedIn("Inner exception..", exception);
			}
		}
		catch(Exception ex){
			Console.WriteLine("It's a inner exception : {0}", ex.InnerException.GetType().Name);
			Console.WriteLine("It's a outer exception : {0}", ex.GetType().Name);
		}
	}	
}

public class userAlreadyLoggedIn : Exception
{
	public userAlreadyLoggedIn(){
	}
	
	public userAlreadyLoggedIn(string message) : base(message){
	}
	
	public userAlreadyLoggedIn(string message, Exception ex) : base(message, ex){
	}
}

/*
  Output : 
    It's a inner exception : DivideByZeroException
It's a outer exception : userAlreadyLoggedIn
*/
