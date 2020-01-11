//-----------------------------------------------------------------------------------------------
/*
	Usage of delegates part - 1
	
	Suppose there is a situation in which the employee is promoted based in his salary then
	in this case use have to modify our 'Employee' class that is not good.
	
	in below example we make some hardcore logic where on the basis of employee experiance we are promoting employees
	
	so with the help of delegate we can remove this hardcore logic that is we will see in next code tutorial.
	
	Here in this example we did not use any delegates.
	
	Let's understand it by example.
*/
//-------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		List<Employee> employeelist = new List<Employee>();
		
		employeelist.Add(new Employee(){
			Id = 101, Name = "John",
			Salary = 4000, Experiance = 3
		});
		
		employeelist.Add(new Employee(){
			Id = 102, Name = "Marry",
			Salary = 5000, Experiance = 4
		});
		
		employeelist.Add(new Employee(){
			Id = 103, Name = "Mark",
			Salary = 3000, Experiance = 2
		});
		
		employeelist.Add(new Employee(){
			Id = 104, Name = "Todd",
			Salary = 6000, Experiance = 6
		});
		
		Employee.getPromoted(employeelist);
	}	
}

public class Employee
{
	public int Id { get; set; }
	public string Name { get; set; }
	public double Salary { get; set; }
	public float Experiance { get; set; }
	
	public static void getPromoted(List<Employee> employees){
		foreach(var employee in employees){
			if(employee.Experiance > 3){
				Console.WriteLine(employee.Name + " - promoted");
			}
		}
	}
}

/*
	Marry - promoted
	Todd - promoted
*/
