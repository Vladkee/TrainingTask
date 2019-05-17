using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask.Task4
{
	class SchoolClass
	{
		public static void Execute()
		{
			Pupil[] pupils =
			{
				new Pupil("Ivan", "Petrov", 2005, 151, "8-A"),
				new Pupil("Vlad", "Solomonin", 2003, 151, "10-Б"),
				new Pupil("Dima", "Kisin", 2002, 48, "11-A"),
				new Pupil("Egor", "Bendar", 2004, 12, "9-В")
			};

			for (int i = 0; i < pupils.Length; i++)
			{
				if (i==0)
				{
					pupils[i].DisplayAliases();
				}
				pupils[i].DisplayTable();
			}
		}
	}
}
