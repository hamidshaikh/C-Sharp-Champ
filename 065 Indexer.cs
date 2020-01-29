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
		
		Console.WriteLine("Initial name");
		Console.WriteLine("Name of Employee Id 1 " + customer[1]);
		Console.WriteLine("Name of Employee Id 3 " + customer[3]);
		
		Console.WriteLine();
		
		Console.WriteLine("Changed name of employee id 1, and 3");
		
		Console.WriteLine();
		
		customer[1] = "Josef";
		customer[3] = "Mare";
		
		
		Console.WriteLine("Changed name");
		Console.WriteLine("Name of Employee Id 1 " + customer[1]);
		Console.WriteLine("Name of Employee Id 3 " + customer[3]);
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
}

public class Employee
{
	public int EmployeeId { get; set; }
	public string Name { get; set; }
	public string Gender { get; set; }
}

/*
	Output : 
		Initial name
		Name of Employee Id 1 John
		Name of Employee Id 3 Rock

		Changed name of employee id 1, and 3

		Changed name
		Name of Employee Id 1 Josef
		Name of Employee Id 3 Mare
*/
