using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask.Task1.DeferedInitialization
{
	public class DeferedAndUndereredExampleManagement
	{
		public void Execute()
		{
			var employees = EmployeeGender.GetEmployees();
			var maleEmployees = employees.Where(employee => employee.Gender == "M"); //defered
			//var maleEmployees = employees.Where(employee => employee.Gender == "M").ToList(); //undefered
			this.Display(maleEmployees);
			employees.Add(new EmployeeGender("Vlad", "Radchenko", "M"));
			this.Display(maleEmployees);
		}

		public void Display(IEnumerable<EmployeeGender> employees)
		{
			foreach (var item in employees)
			{
				Console.WriteLine("{0}, {1}", item.FirstName, item.LastName);
				Console.WriteLine("---------------------------------------");
			}
		}
	}
}
