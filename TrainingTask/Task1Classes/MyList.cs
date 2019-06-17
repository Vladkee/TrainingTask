using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask
{
	public class MyList<T> : IMyList<T>
	{
		protected T[] array;

		public T this[int index]
		{
			get {
				if (index > array.Length-1)
				{
					throw new Exception("Index out of range.");
				}
				else
				{
					return array[index];
				}
			}
		}

		public int Count
		{
			get { return array.Length; }
		}

		public MyList()
		{
			this.array = new T[0];
		}

		public void Add(T item)
		{
			T[] array2 = new T[this.array.Length + 1]; 
			this.array.CopyTo(array2, 0);
			array2[array2.GetUpperBound(0)] = item;
			this.array = array2;
		}

		public void Clear()
		{
			this.array = new T[0];
		}

		public bool Contains(T item)
		{
			if (this.array.Contains(item))
			{
				return true;
			}
			else 
				return false;
		}

		public override string ToString()
		{
			if (array.Length == 0)
			{
				return "No elements";
			}
			else
				return string.Join(", ", array);
		}
	}
}
