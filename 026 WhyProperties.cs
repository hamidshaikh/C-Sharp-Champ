//-----------------------------------------------------------------------------------------------
/*
	Why properties (Need of properties)
	
	Making the class field as public and exposing to the external world is bad. as you will not have
	control over what's get assign and return.
	
	In the below example we are trying to solve some problem with public field let's start.
*/
//-------------------------------------------------------------------------------------------------
using System;

public class ProperiesDemo
{
	/*
		some business logic is : 
		1) Id sould always be greater than 0 field.
		2) name cannot be set to null.
		3) If student name is missing the 'No name' should be returned.
		4) Passmark should be read only.
		
		These are the condition of our business so in this case let's make the property such that.
	*/
	
	private int _Id;
	private string _Name;
	private int _PassCode = 39;
	
	public void SetId(int Id){
		if(Id <= 0)
			throw new Exception("Id should not be less than zero");
		else
			this._Id = Id;
	}
	public int GetId(){
		return this._Id;
	}
	
	public void SetName(string Name){
		if(string.IsNullOrEmpty(Name))
			throw new Exception("Name should not be null or empty");
		else
			this._Name = Name;
	}
	
	public string GetName(){
		if(string.IsNullOrEmpty(this._Name))
			return "No Name";
		else
			return this._Name;
	}
	
	public int GetPassCode(){
		return this._PassCode;
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
		
		pd.SetId(10);
		
		//pd.SetName(null);
		
		//-------------------------------------------------------------------------------------------------
		// If we set name as null then exception weill be rised saying Name should not be null or empty
		//-------------------------------------------------------------------------------------------------
		
		Console.WriteLine(pd.GetName());
		
		//-------------------------------------------------------------------------------------------------
		// If we trying to get unassign name then we will get No Name.
		//-------------------------------------------------------------------------------------------------
		
		pd.SetName("Hello");
		
		//-------------------------------------------------------------------------------------------------
		// If we trying to get unassign name then we will get No Name.
		//-------------------------------------------------------------------------------------------------
		
		Console.WriteLine(pd.GetName());
		
		//-------------------------------------------------------------------------------------------------
		// From the above code we will get exact assigned name.
		//-------------------------------------------------------------------------------------------------
		
		
		//pd.setPassCode(45);
		
		//-------------------------------------------------------------------------------------------------
		// As passCode is read only so not such method found and we cannot assign value to the PassCode.
		//-------------------------------------------------------------------------------------------------
		
		Console.WriteLine(pd.GetPassCode());
		
		//-------------------------------------------------------------------------------------------------
		// Here we get the value of passCode which is already set.
		//-------------------------------------------------------------------------------------------------
		
	}	
}
