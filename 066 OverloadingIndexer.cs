//------------------------------------------------------------------------------------------------------------
/*
	Indexer in C#.
	
	1) Use this keyword to create an indexer.
	2) Just like properties indexers have get and set accessors.
	3) Indexers can also be overloaded
	
	Let's see the simple example...
*/
//------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
	public static void Main()
	{
		Customer customer = new Customer();
		
		Console.WriteLine("Before Update");
		Console.WriteLine("Total Mail employee = " + customer["Male"]);
		Console.WriteLine("Total Femail employee = " + customer["Female"]);
		
		customer["Male"] = "Female";
		
		Console.WriteLine("After Update");
		Console.WriteLine("Total Mail employee = " + customer["Male"]);
		Console.WriteLine("Total Femail employee = " + customer["Female"]);
	}	
}

public class Customer
{
	private List<Employee> employees;
	public Customer()
	{
		employees = new List<Employee>(){
			new Employee {
				EmployeeId = 1,
				Name = "John",
				Gender = "Male"
			},
			new Employee {
				EmployeeId = 2,
				Name = "Marry",
				Gender = "Female"
			},
			new Employee {
				EmployeeId = 3,
				Name = "Rock",
				Gender = "Male"
			},
			new Employee {
				EmployeeId = 4,
				Name = "Doe",
				Gender = "Male"
			},
		};
	}
	
	public string this[int employeeId]
	{
		get{
			return employees.FirstOrDefault(emp => emp.EmployeeId == employeeId).Name;
		}
		set{
			employees.FirstOrDefault(emp => emp.EmployeeId == employeeId).Name = value;
		}
	}
	
	public string this[string Gender]
	{
		get
		{
			return employees.Count(emp => emp.Gender == Gender).ToString();
		}
		set
		{
			foreach(var employee in employees)
			{
				if(employee.Gender == Gender)
				{
					employee.Gender = value;
				}
			}
		}
	}
}

public class Employee
{
	public int EmployeeId { get; set; }
	public string Name { get; set; }
	public string Gender { get; set; }
}

/*
	Output : 
		Before Update
		Total Mail employee = 3
		Total Femail employee = 1
		After Update
		Total Mail employee = 0
		Total Femail employee = 4
*/
