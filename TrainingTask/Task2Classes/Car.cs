using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTask.Task2Classes
{
	public class Car : ICar
	{
		public string Name { get; set; }

		public int Year { get; set; }

        private MyList<Car> carArray = new MyList<Car>();

        public Car this[string name]
        {
            get
            {
                Car car = null;
                for (int i = 0; i < carArray.Count; i++)
                {
                    if (carArray[i].Name.Equals(name))
                    {
                        car = carArray[i];
                    }
                    else
                    {
                       throw new Exception("There is no such car.");
                    }
                }
                return car;
            }
        }

        public Car(string name, int year)
		{
			this.Name = name;
			this.Year = year;
		}

		public override string ToString()
		{
			return this.Name + " " + this.Year;
		}
	}
}
