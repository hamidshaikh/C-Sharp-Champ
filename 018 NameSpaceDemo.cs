//---------------------------------------------------------------------------------------
/*
	Namespace in C#.
	
	Namespace is a logical grouping of classes, interfaces structs etc.
	
	In a large complex project use use namespace to logically devide and manage projec.
*/
//---------------------------------------------------------------------------------------
using System;
					
public class Program
{
	public static void Main()
	{
		DisplayNameSpace.ClassA.Display();
		ShowNameSpace.ClassB.Display();
	}
}

namespace DisplayNameSpace
{
	public class ClassA{
		public static void Display(){
			Console.WriteLine("Hello from namespace DisplayNameSpace");
		}
	}
}

namespace ShowNameSpace
{
	public class ClassB{
		public static void Display(){
			Console.WriteLine("Hello  namespace ShowNameSpace");
		}
	}
}
