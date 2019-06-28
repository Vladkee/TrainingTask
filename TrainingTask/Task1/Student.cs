using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask.Task1
{
	public class Student
	{
		private string firstName;

		private string lastName;

		public int Course { get; set; }

		public string Group { get; set; }

		public string Faculty { get; set; }

		public string FirstName
		{
			get { return firstName; }
			set { firstName = value; }
		}

		public string LastName
		{
			get { return lastName; }
			set { lastName = value; }
		}

		public Student(string firstName, string lastName, int course, string group, string faculty)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Course = course;
			this.Group = group;
			this.Faculty = faculty;
		}

		public override string ToString()
		{
			return this.FirstName + " " + this.LastName + ", " + this.Course + ", " + this.Group + ", " + this.Faculty;
		}
	}
}
