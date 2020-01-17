//-----------------------------------------------------------------------------------------------
/*
	Preventing Exception Handling abuse in C#.
	
	There is a best way to prevent using lost of exception class in the program
	
	Let's see it by example.
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
			int Numerator;
			bool isNumeratorValid = int.TryParse(Console.ReadLine(), out Numerator);
			
			if(isNumeratorValid){
				Console.WriteLine("Please enter denominator");
				int Denomirator;
				bool isDenomiratorValid = int.TryParse(Console.ReadLine(), out Denomirator);
				
				if(isDenomiratorValid && Denomirator != 0){
					int result = Numerator / Denomirator;
					Console.WriteLine(result);
				}
				else{
					if(Denomirator == 0)
						Console.WriteLine("Denomirator should not be zero.");
					else
						Console.WriteLine("Denomirator should be in range of {0} and {1}", int.MinValue, int.MaxValue);
				}
					
			}
			else
				Console.WriteLine("Numerator should be in range of {0} and {1}", int.MinValue, int.MaxValue);
		}
		catch(Exception ex){
			Console.WriteLine(ex.Message);
		}
	}
}
