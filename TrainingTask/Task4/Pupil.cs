using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask.Task4
{
	public class Pupil
	{
		public string FirstName { get; set; }

		public string LastName { get; set; }

		public int YearOfBirth { get; set; }

		//
		// As well we can use DateTime as type of YearOfBith.
		//

		public int SchoolNumber { get; set; }

		public string SchoolClass { get; set; }

		public Pupil(string firstName, string lastName, int yearOfBirth, int schoolNumber, string schoolClass)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.YearOfBirth = yearOfBirth;
			this.SchoolNumber = schoolNumber;
			this.SchoolClass = schoolClass;
		}

		public int CalculateAge()
		{
			int age = 2019 - this.YearOfBirth;

			return age;
		}

		public void DisplayInfo()
		{
			Console.WriteLine($"{GetType().Name} {this.FirstName} {this.LastName} is {CalculateAge()} years old. He is studying in {this.SchoolClass} of {this.SchoolNumber} school.");
		}

		public void DisplayAliases()
		{
			Console.WriteLine(string.Format("{0, -16} {1, -10} {2, -10} {3,-10} {4,-10}", "Name", "Year", "Age", "School", "Class"));

		}
		public void DisplayTable()
		{
			Console.WriteLine(string.Format("{0, -16} {1, -10} {2, -10} {3,-10} {4,-10}", this.FirstName +" " + this.LastName, this.YearOfBirth, CalculateAge(), this.SchoolNumber, this.SchoolClass));
		}


	}
}
