using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask.Task2
{
	class Student : User
	{
		public decimal Scholarship;
		public int Course;

		public Student(string name, int age, decimal scholarship, int course) 
			:base(name, age)
		{
			Scholarship = scholarship;
			Course = course;
			Name = name;
			Age = age;
		}
	}
}
