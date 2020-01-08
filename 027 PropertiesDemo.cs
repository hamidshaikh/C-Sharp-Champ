//-----------------------------------------------------------------------------------------------
/*
	Properties in C#.
	
	in C# to encapsulate and protect fields we use properties.
	A property with both get and set accessors is a read/write properties.
	A properties with only get is a raed properties.
	A properties with only set is a write properties.
	
	Note : The adantage of properties over traditional get() and set() methods is that,
	you can access them as if they ware public fields.
*/
//-------------------------------------------------------------------------------------------------
using System;

public class ProperiesDemo
{
	private int _Id;
	private string _Name;
	private int _PassMark = 39;
	
	/*
		If there is no additional logic in the properties accessors, then we can make use of auto implemented 
		properties introduced in C# 3.0;
		
		Auto implemented properties reduce the amount of code that we have to write.
		
		when we use auto implemented properties, the compiler creates a private, anonyms field that can only be accessed through 
		the properties get and set accessors. like...
	*/
	
	public string City {get; set;}
	public string Email {get; set;}
	
	public int Id {
		set {
			if(value <= 0)
				throw new Exception("Id should not be less than zero");
			else
				this._Id = value;
		}
		get{
			return this._Id;
		}
	}
	
	public string Name{
		set{
			if(string.IsNullOrEmpty(value))
				throw new Exception("Name should not be null or empty");
		else
			this._Name = Name;
		}
		get{
			if(string.IsNullOrEmpty(this._Name))
				return "No Name";
			else
				return this._Name;
		}
	}
	
	public int PassMark{
		get{
			return this._PassMark;
		}
	}
}

public class Program
{
	public static void Main()
	{
		ProperiesDemo pd = new ProperiesDemo();
		
		//pd.SetId(-10);
		
		//-------------------------------------------------------------------------------------------------
		// If we set value less than 0 then exception will be thrown i.e Id should not be less than zero
		//-------------------------------------------------------------------------------------------------
		
		pd.Id = 10;
		
		Console.WriteLine(pd.Id);
		
		//pd.Name = null;
		
		//-------------------------------------------------------------------------------------------------
		// If we set name as null then exception weill be rised saying Name should not be null or empty
		//-------------------------------------------------------------------------------------------------
		
		Console.WriteLine(pd.Name);
		
		//-------------------------------------------------------------------------------------------------
		// If we trying to get unassign name then we will get No Name.
		//-------------------------------------------------------------------------------------------------
		
		pd.Name = "Hello";
		
		//-------------------------------------------------------------------------------------------------
		// If we trying to get unassign name then we will get No Name.
		//-------------------------------------------------------------------------------------------------
		
		Console.WriteLine(pd.Name);
		
		//-------------------------------------------------------------------------------------------------
		// From the above code we will get exact assigned name.
		//-------------------------------------------------------------------------------------------------
		
		
		//pd.PassMark = 45;
		
		//-------------------------------------------------------------------------------------------------
		// As passCode is read only so not such method found and we cannot assign value to the PassCode.
		//-------------------------------------------------------------------------------------------------
		
		Console.WriteLine(pd.PassMark);
		
		//-------------------------------------------------------------------------------------------------
		// Here we get the value of passCode which is already set.
		//-------------------------------------------------------------------------------------------------
		
		pd.City = "Pune";
		pd.Email = "abc@gmail.com";
		
		Console.WriteLine(pd.City);
		Console.WriteLine(pd.Email);
	}	
}
