//------------------------------------------------------------------------------------------------------------
/*
	Partial class in C#.
	
	Partial class allow usto split the class into 2 or more files. All these parts are then combined into a single class
	When the application is compiled. the partial keyword can also be used to split a struct or an interface over two or more files.
	
	Advantage of spitting classes.
	
	1. The main advantage is that, visual studio uses partial class to separate, automatically generated system code from the developer code.
	For example, when you add a webform , two .CS files are generated.
	
	  a) WebForm1.aspx.cs - Contain the developer code.
	  b) Webform1.aspx.designer.cs - Contain the system generated code. For example, declaration for the controls that you drag and 
	  drop on the webform.
	
	2. When working on large projects, spreading a class over separate file allow multiple programmer to work on it simultaneously.
	though, Microsoft claim this as an advantage. I haven't seen anywhere, people using partial classes, just to work on them simultaniously.
	
*/
//------------------------------------------------------------------------------------------------------------
using System;

public class Program
{
	public static void Main()
	{
		Customer C1 = new Customer();
		C1.FirstName = "john";
		C1.LastName = "Doe";
		
		Console.WriteLine(C1.GetFullName());
	}	
}

public partial class Customer
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
}

public partial class Customer
{
	public string GetFullName()
	{
		return FirstName +" - " + LastName;
	}
}

/* Output : 
	john - Doe
*/
