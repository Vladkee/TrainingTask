using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingTask.Task1;

namespace TrainingTask.Task2
{
	public class StudentDictionary
	{
		private Dictionary<string, Student> studentDict = new Dictionary<string, Student>()
		{
			{ "Vlad Radchenko", new Student("Vlad", "Radchenko", 4, "G13", "GIS") },
			{"Egor Buryakov" , new Student("Egor", "Buryakov", 4, "I45", "Engineering")}
		};
		
		public Dictionary<string, Student> GetStudentDictionary()
		{
			return studentDict;
		}
	}
}
