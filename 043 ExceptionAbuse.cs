//-----------------------------------------------------------------------------------------------
/*
	Exception Handling abuse in C#.
	
	Exception are unforeseen error that occure when a program is running, for example
	when an application executing query, the database connection is lost.
	
	Exception handling generally use to handle these exception.
	
	using exception handling to implement program logical flow is bad and is termed as exception handling abuse.
	
	
*/
//-------------------------------------------------------------------------------------------------
using System;

public class Program
{
	public static void Main()
	{
		try
		{
			Console.WriteLine("Please enter numerator");
			int Numerator = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Please enter denominator");
			int Denomirator = Convert.ToInt32(Console.ReadLine());

			int result = Numerator / Denomirator;

			Console.WriteLine(result);
		}
		catch(FormatException)
		{
			Console.WriteLine("Only number allowed");
		}
		catch(OverflowException){
			Console.WriteLine("only number between {0} && {1} are allowed ", int.MinValue, int.MaxValue);
		}
		catch(DivideByZeroException){
			Console.WriteLine("Cannot divide by zero");
		}
		catch(Exception ex){
			Console.WriteLine(ex.Message);
		}
	}
}
