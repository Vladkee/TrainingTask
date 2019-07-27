using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask.Task4
{
	public class BookList
	{
		private List<Book> listOfBooks = new List<Book>()
		{
			new Book(1, "Moonlight", "Jacob Ferri"),
			new Book(2, "Peace in paradise", "John Malkovich"),
			new Book(3, "Blood", "Frank Joseph")
		};

		public List<Book> GetBookList()
		{
			return listOfBooks;
		}
	}
}
