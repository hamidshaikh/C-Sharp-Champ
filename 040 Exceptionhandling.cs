//-----------------------------------------------------------------------------------------------
/*
	Exception handling in C#.
	
	Let's understand it by example.
*/
//-------------------------------------------------------------------------------------------------
using System;
using System.IO;

public delegate void DelegateDemo();

public class Program
{
	public static void Main()
	{
		try{
			//Here you can change file of your derectory
			StreamReader streamReader = new StreamReader(@"C:\Sample File\data.txt");
			Console.WriteLine(streamReader.ReadToEnd());	
		}
		//It is specific exception of file not found exception
		catch(FileNotFoundException ex){
			//log the detail to the file
			Console.WriteLine("Please check if the file {0} exist", ex.FileName);
		}
		//Exception is the root exception class of all exception.
		catch(Exception ex){
			Console.WriteLine(ex.Message);
		}
	}	
}
