//--------------------------------------------------------------------------------------
	/*
		Two points need to cover in this example
		1) Nullable type in C# like ?
		2) Coalescing nullable type like ??
		
		There are two types that is value type and reference type.
		
		reference type can store null but in case of value type they cannot store null.
		
		so to make value type as a nullable we use the nullable type, because there is a need to do that
		suppose there is a field 'areYouMajor' which is not mandatory to select, so it should be null
		in program and database also so that field need's to make as nullable.
		
		Let's understand it by example.
	*/
//--------------------------------------------------------------------------------------
using System;
					
public class Program
{
	public static void Main()
	{
		//--------------------------------------------------------------------------------------
		// 1) Nullable type
		//--------------------------------------------------------------------------------------
		
		//bool areYouMajor = null;
		
		//--------------------------------------------------------------------------------------
		// In above line we cannot store null in 'areYouMajor' it gives compile time error
		//because it is not nullable. so to get rid of that we can write as...
		//--------------------------------------------------------------------------------------
		
		bool? areYouMajor = null;
		
		if(areYouMajor == true)
			Console.WriteLine("You selected as major {0}",  areYouMajor);
		else if(areYouMajor == false)
			Console.WriteLine("You selected as major {0}",  areYouMajor);
		else 
			Console.WriteLine("You not selected any major");
			
		//--------------------------------------------------------------------------------------
		// 2) Coalescing nullable
		//--------------------------------------------------------------------------------------
		
		int? ticketsForSale = null;
		int totalTicketsAvailable = ticketsForSale ?? 0;
		
		Console.WriteLine("total available tickets are {0}", totalTicketsAvailable);
		
		//--------------------------------------------------------------------------------------
		// Without Coalescing operator we need to write below code which is quite lenthy.
		//--------------------------------------------------------------------------------------
		
		//---------------------------------Not Recommended at all-----------------------------------------------------
		ticketsForSale = 10;
		
		if(ticketsForSale == null)
			totalTicketsAvailable = 0;
		else
			totalTicketsAvailable = /*(int) or */ticketsForSale.Value;
		
		Console.WriteLine("total available tickets are {0}", totalTicketsAvailable);
		//---------------------------------Not Recommended at all-----------------------------------------------------
	}
}
