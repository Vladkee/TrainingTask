using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask
{
	public class DateTimePractise
	{
		public void DoSomething()
		{
			DateTime dateNow = DateTime.Today;
			//Console.WriteLine($"Now date: {dateNow.ToShortDateString()}");
			Console.WriteLine($"Now date: {dateNow.ToString("MM.dd.yyyy")}");

			DateTime dateYestrday = dateNow.AddDays(-1);
			Console.WriteLine($"Yesterday date: {dateYestrday.ToShortDateString()}");

			DateTime date2MonthAgo = dateNow.AddMonths(-2);
			Console.WriteLine($"2 month ago date: {date2MonthAgo.ToShortDateString()}");

			DateTime dateYearAgo = dateNow.AddYears(-1);
			Console.WriteLine($"Year ago date: {dateYearAgo.ToShortDateString()}");

			DateTime dateOfBirthday = new DateTime(1996, 02, 28);
			Console.WriteLine($"Birthday date: {dateOfBirthday.ToShortDateString()}");
		}

	}
}
