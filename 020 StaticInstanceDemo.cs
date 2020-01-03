//---------------------------------------------------------------------------------------
/*
	Static and instance class member in C#.
	
	The member of class eighter be a static or an instance menber. depending upon the propery
	the memory get accupied to that member.
	
	static member :
	Static member share the same momory accross the class that class and it's object.
	static member is a class level member so we can access it directly using class name.
	
	instance member : 
	For every object new instance member get created and memory accupied for that that each time.
	Instance member is a accessed using instance (Object) of class.
	
	let's understand it by example.
*/
//---------------------------------------------------------------------------------------
using System;
					
public class ClassDemo
{
	//Static member _PI. By making field readonly we can assign value to it only once and we can't change it.
	public static readonly float _PI;
	float redius;
	
	//Static Constructor is used to initilise static member of a class and it get executed only once
	//When we try to access any static field and there is no need to apply access specifiers or create object of class.
	static ClassDemo(){
		Console.WriteLine("Static constructor called...");
		_PI = 3.14F;
	}
	
	//Non static constructor is used to initilise non static members.
	public ClassDemo(float redius){
		Console.WriteLine("Instance constructor called...");
		this.redius = redius;
	}
	
	public float CalculateArea(){
		return _PI * this.redius * this.redius;
	}
}

public class Program
{
	public static void Main()
	{
		//Static constructor call prior to instance one.
		ClassDemo cd = new ClassDemo(5);
		Console.WriteLine(cd.CalculateArea());
	}	
}
