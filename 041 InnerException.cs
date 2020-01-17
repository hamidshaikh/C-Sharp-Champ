//-----------------------------------------------------------------------------------------------
/*
	Inner Exception in C#.
	
	The inner exception property return the exception instance that caused the current exception.
	
	To retain the origional exception pass it as a parameter to the constructor, of the current exception.
	
	Always check if the inner exception is not null before accessing any property of any exception object,
	else, you may get Null Reference Exception
	
	To get the type of inner exception use GetType() method.
	
	Let's understand it by example.
*/
//-------------------------------------------------------------------------------------------------
using System;
using System.IO;

public class Program
{
	public static void Main()
	{
		try
		{
			try
			{
				Console.WriteLine("Enter first number")	;
				int FN = int.Parse(Console.ReadLine());

				Console.WriteLine("Enter first number")	;
				int SN = int.Parse(Console.ReadLine());

				double TN = FN / SN;
			}
			catch(Exception ex){
				string filePath = @"C:\Sample File\Log.txt";
				if(File.Exists(filePath)){
					StreamWriter sw = new StreamWriter(filePath);
					sw.Write(ex.GetType().Name);
					sw.WriteLine();
					sw.Write(ex.Message);
					sw.Close();
					Console.WriteLine("There is a problem please try later", ex);
				}
				else
				{
					throw new FileNotFoundException(filePath + "is not present", ex);
				}
			}
		}
		catch(Exception exception)
		{
			Console.WriteLine("Message" + exception.GetType().Name);
			Console.WriteLine("Message" + exception.InnerException.GetType().Name);
		}
	}	
}
