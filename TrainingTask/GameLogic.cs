using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrainingTask
{
    public class GameLogic
    {
        private MyCar myCar = new MyCar();

        private GameField gameField = new GameField();

        private OtherCar otherCar = new OtherCar();

        private TrackField trackField = new TrackField();

        private Drawer drawerInstance = new Drawer();

        private Random random = new Random();

        private static int countCar;

        private volatile static bool isShutdown;

        private static int speed;

        private static int live;

        private static bool isCrash;

        public void RunGame()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            this.gameField.GenerateGameBorder();

            RunTimer();

            Console.ForegroundColor = ConsoleColor.Green;
            RunMyCar();
        }

        public void RunMyCar()
        {
            while (true)
            {
                var key = Console.ReadKey(true);

                lock (Drawer.locker)
                {
                    if (key.Key == ConsoleKey.RightArrow)
                    {
                        this.myCar.MoveRight();
                    }
                    else if (key.Key == ConsoleKey.LeftArrow)
                    {
                        this.myCar.MoveLeft();
                    }
                }
            }
        }

        public void SendOtherCar()
        {
            int leftCarPosition;

            speed = 99;

            live = 3;

            while (true)
            {
                isCrash = false;

                var positionCase = this.random.Next(0, 4);

                if (positionCase >= 2)
                {
                    leftCarPosition = 0;
                }
                else
                {
                    leftCarPosition = 12;
                }

                this.otherCar.CreateCar(leftCarPosition, speed);

                for (int i = 0, y = 1, z = 5; i < this.trackField.TrackHeight; i++, y++, z++)
                {
                    if (i < this.trackField.TrackHeight - 5)
                    {
                        Thread.Sleep(speed);

                        if (isShutdown)
                        {
                            Thread.CurrentThread.Abort();
                        }

                        lock (Drawer.locker)
                        {
                            Console.SetCursorPosition(gameField.GameWindowWidth - 23, 5);
                            Console.WriteLine("SCORE: " + GetScore(countCar));
                            Console.SetCursorPosition(gameField.GameWindowWidth - 23, 6);
                            Console.WriteLine("SPEED: " + speed);
                            Console.SetCursorPosition(gameField.GameWindowWidth - 23, 7);
                            Console.WriteLine("LIVES: " + live);
                        }

                        this.otherCar.RunAnotherCar(i, leftCarPosition);

                        if (i >= this.trackField.TrackHeight - 10 && leftCarPosition == 0 && MyCar.MyCarPosition == 1)
                        {
                            lock (Drawer.locker)
                            {
                                if (!isCrash)
                                {
                                    live--;
                                    Console.Beep();
                                    isCrash = true;

                                    if (live == 0)
                                    {
                                        isShutdown = true;
                                        Console.Clear();

                                        SendGameOverMessage(GetScore(countCar));
                                        Thread.CurrentThread.Abort();
                                    }
                                }

                                if (i >= this.trackField.TrackHeight - 7)
                                {
                                    drawerInstance.GenerateElement(5, trackField.TrackHeight - 5, 'x');
                                }
                            }
                        }
                        else if (i >= this.trackField.TrackHeight - 10 && leftCarPosition == 12 && MyCar.MyCarPosition == 2)
                        {
                            lock (Drawer.locker)
                            {
                                if (!isCrash)
                                {
                                    live--;
                                    Console.Beep();
                                    isCrash = true;

                                    if (live == 0)
                                    {
                                        isShutdown = true;
                                        Console.Clear();

                                        SendGameOverMessage(GetScore(countCar));
                                        Thread.CurrentThread.Abort();
                                    }
                                }

                                if (i == this.trackField.TrackHeight - 7)
                                {
                                    drawerInstance.GenerateElement(17, trackField.TrackHeight - 5, 'x');
                                }
                            }
                        }

                        if (y >= this.trackField.TrackHeight - 5)
                        {
                            this.otherCar.DeleteAnotherCar(leftCarPosition, speed);

                            countCar++;

                            speed = GenerateSpeed(GetScore(countCar));
                        }
                    }
                    else if (i >= this.trackField.TrackHeight - 5 && i < this.trackField.TrackHeight)
                    {
                        if (i >= this.trackField.TrackHeight - 5 && leftCarPosition == 0 && MyCar.MyCarPosition == 1)
                        {
                            lock (Drawer.locker)
                            {
                                if (!isCrash)
                                {
                                    live--;
                                    Console.Beep();
                                    isCrash = true;

                                    if (live == 0)
                                    {
                                        isShutdown = true;
                                        Console.Clear();

                                        SendGameOverMessage(GetScore(countCar));
                                        Thread.CurrentThread.Abort();
                                    }
                                }

                                if (i == this.trackField.TrackHeight - 5)
                                {
                                    drawerInstance.GenerateElement(4, trackField.TrackHeight - 4, 'x');
                                    drawerInstance.GenerateElement(6, trackField.TrackHeight - 4, 'x');
                                    drawerInstance.GenerateElement(5, trackField.TrackHeight - 4, 'x');
                                    drawerInstance.GenerateElement(5, trackField.TrackHeight - 3, 'x');
                                    drawerInstance.GenerateElement(4, trackField.TrackHeight - 2, 'x');
                                    drawerInstance.GenerateElement(6, trackField.TrackHeight - 2, 'x');
                                }
                            }
                        }
                        else if (i >= this.trackField.TrackHeight - 5 && leftCarPosition == 12 && MyCar.MyCarPosition == 2)
                        {
                            lock (Drawer.locker)
                            {
                                if (!isCrash)
                                {
                                    live--;
                                    Console.Beep();
                                    isCrash = true;

                                    if (live == 0)
                                    {
                                        isShutdown = true;
                                        Console.Clear();

                                        SendGameOverMessage(GetScore(countCar));
                                        Thread.CurrentThread.Abort();
                                    }
                                }

                                if (i == this.trackField.TrackHeight - 5)
                                {
                                    drawerInstance.GenerateElement(16, trackField.TrackHeight - 4, 'x');
                                    drawerInstance.GenerateElement(18, trackField.TrackHeight - 4, 'x');
                                    drawerInstance.GenerateElement(17, trackField.TrackHeight - 4, 'x');
                                    drawerInstance.GenerateElement(17, trackField.TrackHeight - 3, 'x');
                                    drawerInstance.GenerateElement(16, trackField.TrackHeight - 2, 'x');
                                    drawerInstance.GenerateElement(18, trackField.TrackHeight - 2, 'x');
                                }
                            }
                        }
                    }
                }
            }
        }

        public void SendGameOverMessage(int score)
        {
            lock (Drawer.locker)
            {
                Console.Clear();

                Console.SetCursorPosition(this.gameField.GameWindowWidth - 23, 4);
                Console.WriteLine("GAME OVER");

                Console.SetCursorPosition(this.gameField.GameWindowWidth - 23, 5);
                Console.WriteLine("SCORE: " + score);
            }
        }

        public int GetScore(int countCar)
        {
            lock (Drawer.locker)
            {
                int score = countCar * 20;

                return score;
            }
        }

        public int GenerateSpeed(int score)
        {
            lock (Drawer.locker)
            {
                if (score >= 0 && score <= 50)
                {
                    return speed = 99;
                }
                else if (score >= 51 && score <= 100)
                {
                    return speed = 90;
                }
                else if (score >= 101 && score <= 200)
                {
                    return speed = 80;
                }
                else if (score >= 201 && score <= 300)
                {
                    return speed = 70;
                }
                else if (score >= 301 && score <= 500)
                {
                    return speed = 50;
                }
                else if (score >= 501 && score <= 600)
                {
                    return speed = 30;
                }
                else
                {
                    return speed = 20;
                }
            }
        }

        public void RunTimer()
        {
            for (int i = 3; i >= 0; i--)
            {
                if (i > 0)
                {
                    Thread.Sleep(1000);
                    lock (Drawer.locker)
                    {
                        Console.SetCursorPosition(11, 12);
                        Console.WriteLine(i);
                    }
                }
                else if (i == 0)
                {
                    Thread.Sleep(1000);
                    lock (Drawer.locker)
                    {
                        Console.SetCursorPosition(11, 12);
                        Console.WriteLine(' ');
                    }
                }
            }
        }
    }
}
