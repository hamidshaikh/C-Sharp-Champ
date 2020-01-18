//-----------------------------------------------------------------------------------------------
/*
	Difference between type and types members in C#.
	
	In this example 'Customer' is a type and fields, properties and methods are type member.
	
	So, in general classes enume, structs, interface, delegates are called as types and fileds, properties,
	methods etc. that normally resides in a type are called as type members.
	
	In C# there are 5 different access modifiers.
	1) Private
	2) Protected
	3) Internal
	4) Protected internal
	5) public
	
	Type member can have all access modifiers, where as types can have only 2 access modifiers.
	(internal, public) of 5 accesss modifiers.
	
	Note : using region you can expand and collapse section of your code eighter mannually, 
	or using visual studeo Edit > Outlining > Toggle All outlining
	
*/
//-------------------------------------------------------------------------------------------------
using System;

public class Program
{
	public static void Main()
	{
			
	}
}

//It is type
public class customer
{
  // All are type members inside class
  
	#region Properties
	private int _Id;
	private string _Name;
	#endregion
	
	#region PropertiesGetterSetter
	public int Id{
		get { return _Id; }
		set { this._Id = value; }
	}
	
	public string Name{
		get { return _Name; }
		set { this._Name = value; }
	}
	#endregion
}
