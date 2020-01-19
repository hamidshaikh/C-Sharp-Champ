//------------------------------------------------------------------------------------------------------------
/*
	Reflection in C#.
	
	Reflection is a ability of inspecting an assemblies metadata at runtime. it is used to find all types in a assembly
	and/or dynamically invoke method in assembly.
	
	* uses of reflection
	1. When you drag and drop button on a win forms or an asp.net application. the properties window uses reflection to
	show all properties of the bbutton class, So reflection is extensivly used by an IDE or a UI developer.
	
	2. Late binding can be aachived by using reflection. you can use reflection to dynamically create an instance of type.
	about which you don't have any information at compile time. So, Reflection enable you to use code that is not available at compile time.
	
	3. consider an example where you have no alternate implementation of an interface. You want to allow the user to pick one or othe using 
	config file, with reflection, you can simply read the name of the class whose implementaion you want to use from the config file
	and instantiat an instance of that class. this is an another example of late binding using reflection
	
	Let's understand it by example.
*/
//------------------------------------------------------------------------------------------------------------
using System;
using System.Reflection;

public class Customer
{
	public int Id {get; set;}
	public string Name {get; set;}
	
	public Customer(int id, string name)
	{
		this.Id = id;
		this.Name = name;
	}
	
	public void PrintName()
	{
		Console.WriteLine("Name = {0} and Id = {1}", Id, Name);
	}
}
		
public class Program
{
	public static void Main()
	{
		var T  = typeof(Customer);
		Console.WriteLine(T.FullName);
		Console.WriteLine(T.Name);
		
		Console.WriteLine("-------------------------------------------------");
		Console.WriteLine("Properties in Customer");
		Console.WriteLine("-------------------------------------------------");
		
		PropertyInfo[] properties = T.GetProperties();
		
		foreach(var property in properties){
			Console.WriteLine(property.Name + " " +property.PropertyType);
		}
		
		Console.WriteLine("-------------------------------------------------");
		Console.WriteLine("Methods in Customer");
		Console.WriteLine("-------------------------------------------------");
		
		MethodInfo[] methods = T.GetMethods();
		
		foreach(var method in methods){
			Console.WriteLine(method.Name + " " + method.ReturnType);
		}
		
		Console.WriteLine("-------------------------------------------------");
		Console.WriteLine("Constructor in Customer");
		Console.WriteLine("-------------------------------------------------");
		
		ConstructorInfo[] constructors = T.GetConstructors();
		
		foreach(var constructor in constructors){
			Console.WriteLine(constructor.ToString());
		}
	}
}

/*
	Output : 
        Customer
        Customer
        -------------------------------------------------
        Properties in Customer
        -------------------------------------------------
        Id System.Int32
        Name System.String
        -------------------------------------------------
        Methods in Customer
        -------------------------------------------------
        get_Id System.Int32
        set_Id System.Void
        get_Name System.String
        set_Name System.Void
        PrintName System.Void
        ToString System.String
        Equals System.Boolean
        GetHashCode System.Int32
        GetType System.Type
        -------------------------------------------------
        Constructor in Customer
        -------------------------------------------------
        Void .ctor(Int32, System.String)
*/
