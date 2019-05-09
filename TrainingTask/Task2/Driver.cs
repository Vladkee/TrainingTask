using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask.Task2
{
	class Driver : Worker
	{
		private double driverExperience;
		private DriverLicenceCategories driverLicence;

		public Driver(double driverExperience, DriverLicenceCategories driverLicence, string name, int age, decimal salary)
			: base(name, age, salary)
		{
			this.driverExperience = driverExperience;
			this.driverLicence = driverLicence;
			Name = name;
			Age = age;
			Salary = salary;
		}

		public static double GetDriverExperience(double driverExperience)
		{
			return driverExperience;
		}

		public static DriverLicenceCategories GetDriverLicence(DriverLicenceCategories driverLicence)
		{
			return driverLicence;
		}
	}

	enum DriverLicenceCategories
	{
		A,
		B,
		C
	}


}
