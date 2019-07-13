using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask.Task2.EmployeeCollection
{
	public class Pupil
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string School { get; set; }

		public Pupil(string firstName, string lastName, string school)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.School = school;
		}

		public override string ToString()
		{
			return this.FirstName + " " + this.LastName + ", " + this.School;
		}
	}
}
