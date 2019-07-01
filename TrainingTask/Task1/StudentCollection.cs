using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask.Task1
{
	public class StudentCollection
	{
		private List<Student> studentList = new List<Student> {
			new Student ("Egor", "Buryakov", 4, "I45", "Engineering"),
			new Student ("Dima", "Bulgakov", 3, "B23", "Mathematics"),
			new Student ("Vlad", "Radchenko", 2, "A12", "Medical")
		};

		public List<Student> GetStudentList()
		{
			return studentList;
		}
	}
}
