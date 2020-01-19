//-----------------------------------------------------------------------------------------------
/*
	Access modifiers in C#.
	
	There are 5 different access modifiers in C#.
	
	1) Private
	2) protected
	3) internal
	4) protected internal
	5) public
	
	private member are only available only within the containning type. where as public member avalable
	any where, there is no restriction.
	
	protected members are available, within the containing type and the type that derived from the the containing type
*/
//-------------------------------------------------------------------------------------------------
using System;

public class Customer
{
	private int _Id;
	
	public int Id
	{
		get
		{
			return _Id;
		}
		set
		{
			_Id = value;
		}
	}
	
	protected string Name;
	
	public string Email;
}

public class CorporateCustomer : Customer
{
	public void PrintID()
	{
		CorporateCustomer corporateCustomer = new CorporateCustomer();
		corporateCustomer.Name = "Customer 1";
		Console.WriteLine(corporateCustomer.Name);
		Console.WriteLine(this.Name);
		Console.WriteLine(base.Name);
		
		//We cannot print '_Id' because it's private
		//Console.WriteLine(corporateCustomer._Id);
		
		//To access above type member with the help of public getter and setter method as
		
		corporateCustomer.Id = 101;
		
		Console.WriteLine(corporateCustomer.Id);
	}
}

public class Program
{
	public static void Main()
	{
		CorporateCustomer corporateCustomer = new CorporateCustomer();
		Console.WriteLine(corporateCustomer.Email);
		
		//We cannot print '_Id' because it's private
		//Console.WriteLine(corporateCustomer._Id);
		
		//To access above type member with the help of public getter and setter method as
		
		corporateCustomer.Id = 102;
		
		Console.WriteLine(corporateCustomer.Id);
		
		//We cannot print 'Nane' because it's protected
		//Console.WriteLine(corporateCustomer.Name);
		
		corporateCustomer.PrintID();
	}
}

/*
  Output : 
  102
  Customer 1


  101
  */
