//-----------------------------------------------------------------------------------------------
/*
	Usage of delegates part - 2
	
	It is continueation from the first part on delegates, so in this example we are going to undertand 
	the use of delegates in real seanario.
	
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
		
		//Using lamda expression we are in a position to remove hard coded login from 
		//employee class.
		
		Employee.getPromoted(employeelist, emp => emp.Salary > 3000);
		
		Console.WriteLine("---------------------------------------------");
		
		Employee.getPromoted(employeelist, emp => emp.Experiance > 3);
	}	
}

public delegate bool IsPromotable(Employee emp);

public class Employee
{
	public int Id { get; set; }
	public string Name { get; set; }
	public double Salary { get; set; }
	public float Experiance { get; set; }
	
	public static void getPromoted(List<Employee> employees, IsPromotable isEligibleToPromotable){
		foreach(var employee in employees){
			if(isEligibleToPromotable(employee)){
				Console.WriteLine(employee.Name + " - promoted");
			}
		}
	}
}


/*
  Output : 
      John - promoted
      Marry - promoted
      Todd - promoted
      ---------------------------------------------
      Marry - promoted
      Todd - promoted
*/
