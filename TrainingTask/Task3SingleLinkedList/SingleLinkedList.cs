using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask.Task3SingleLinkedList
{
	public class SingleLinkedList<T> : IEnumerable<T>
	{
		private Node<T> firstElement;
		private Node<T> lastElement;
		int count;

		public void Add(T element)
		{
			Node<T> node = new Node<T>(element);

			if (firstElement == null)
			{
				firstElement = node;
			}
			else
			{
				lastElement.Next = node;
			}
			lastElement = node;
			count++;
		}

		public IEnumerator GetEnumerator()
		{
			return new Node<T>(element);
		}

		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			Node<T> current = firstElement;
			while (current != null)
			{
				yield return current.Element;
				current = current.Next;
			}
		}
	}
}
