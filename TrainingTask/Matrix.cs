using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrainingTask
{
    public class Matrix
    {
        private Random random = new Random();

        private int width;

        private int height;

        private int lenght;

        static public object locker = new object();

        public Matrix()
        {
            this.width = 100;
            this.height = 30;
            Console.SetWindowSize(this.width, this.height);
            Console.CursorVisible = false;
        }

        public void GenerateRainRow()
        {
            while (true)
            {
                var cursorLeftPosition = ChangeLeftCursorPosition();
                var cursorTopPosition = ChangeTopCursorPosition();
                this.lenght = random.Next(3, height / 2);
                //Thread.Sleep(30);
                Thread.Sleep(GenerateThreadSpeed());


                for (int i = 0, y = 0; i < this.height + this.lenght; i++)
                {
                    //Thread.Sleep(GenerateThreadSpeed());
                    //Thread.Sleep(50);


                    lock (locker)
                    {
                        if (i < this.height)
                        {
                            Console.SetCursorPosition(cursorLeftPosition, i);
                            Console.WriteLine(GenerateElement());

                            if (i > 0)
                            {
                                var prevI = 1;

                                while (prevI < this.lenght)
                                {
                                    Console.SetCursorPosition(cursorLeftPosition, i - prevI);
                                    Console.WriteLine(GenerateElement());

                                    if (i - prevI == 0)
                                    {
                                        break;
                                    }
                                    prevI++;
                                }
                            }
                        }

                        if (i >= this.lenght)
                        {
                            Console.SetCursorPosition(cursorLeftPosition, y);
                            Console.WriteLine(' ');

                            if (i >= this.height && i < this.height + lenght)
                            {
                                var next = 1;

                                while (y < this.height)
                                {
                                    if (y + next == this.height)
                                    {
                                        break;
                                    }
                                    Console.SetCursorPosition(cursorLeftPosition, y + next);
                                    Console.WriteLine(GenerateElement());
                                    next++;
                                }
                            }
                            y++;
                        }
                    }
                }
            }
        }

        public char GenerateElement()
        {
            while (true)
            {
                var element = Convert.ToChar(random.Next(70, 120));

                return element;
            }
        }

        public int ChangeLeftCursorPosition()
        {
            int cursorPos = random.Next(1, 100);

            return cursorPos;
        }

        public int ChangeTopCursorPosition()
        {
            int cursorPos = random.Next(1, 10);

            return cursorPos;
        }

        public int GenerateThreadSpeed()
        {
            var speedCase = random.Next(1, 5);
            int speed = 0;
            switch (speedCase)
            {
                case 1:
                    speed = random.Next(80, 120);
                    break;
                case 2:
                    speed = random.Next(121, 200);
                    break;
                case 3:
                    speed = random.Next(201, 400);
                    break;
                case 4:
                    speed = random.Next(401, 600);
                    break;
                case 5:
                    speed = random.Next(601, 800);
                    break;
            }
            return speed;
        }
    }
}
