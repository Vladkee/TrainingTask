using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask.Task1.DeferedInitialization
{
	public class EmployeeGender
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Gender { get; set; }

		public EmployeeGender(string firstName, string lastName, string gender)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Gender = gender;
		}

		public static List<EmployeeGender> GetEmployees()
		{
			return new List<EmployeeGender>
			{
				new EmployeeGender("John", "Wick", "M"),
				new EmployeeGender("Elena", "Poleno", "F"),
				new EmployeeGender("Putin", "Huelo", "M"),
			};
		}
	}
}
