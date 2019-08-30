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

        private static bool isShutdown;

        private static int speed;

        public void RunGame()
        {
            gameField.GenerateGameBorder();

            //RunTimer();

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
                        myCar.MoveRight();
                    }
                    else if (key.Key == ConsoleKey.LeftArrow)
                    {
                        myCar.MoveLeft();
                    }
                }
            }
        }

        public void SendOtherCar()
        {
            int leftCarPosition;

            speed = 99;

            while (true)
            {
                var positionCase = random.Next(0, 5);

                if (positionCase > 2)
                {
                    leftCarPosition = 0;
                }
                else
                {
                    leftCarPosition = 12;
                }

                otherCar.CreateCar(leftCarPosition, speed);

                for (int i = 0, y = 1; i < trackField.TrackHeight; i++, y++)
                {
                    if (i < trackField.TrackHeight - 5)
                    {
                        lock (Drawer.locker)
                        {
                            Console.SetCursorPosition(gameField.GameWindowWidth - 23, 5);
                            Console.WriteLine("SCORE: " + GetScore(countCar));
                            Console.SetCursorPosition(gameField.GameWindowWidth - 23, 6);
                            Console.WriteLine("SPEED: " + speed);
                        }

                        Thread.Sleep(speed);

                        if (isShutdown)
                        {
                            Thread.CurrentThread.Abort();
                        }

                        otherCar.RunAnotherCar(i, leftCarPosition);

                        if (i >= trackField.TrackHeight - 10 && leftCarPosition == 0 && MyCar.MyCarPosition == 1)

                        {
                            lock (Drawer.locker)
                            {
                                isShutdown = true;
                                Console.Clear();

                                SendGameOverMessage(GetScore(countCar));
                                Thread.CurrentThread.Abort();
                            }
                        }

                        else if (i >= trackField.TrackHeight - 10 && leftCarPosition == 12 && MyCar.MyCarPosition == 2)
                        {
                            lock (Drawer.locker)
                            {
                                isShutdown = true;
                                Console.Clear();

                                SendGameOverMessage(GetScore(countCar));
                                Thread.CurrentThread.Abort();
                            }
                        }

                        if (y >= trackField.TrackHeight - 5)
                        {
                            otherCar.DeleteAnotherCar(leftCarPosition, speed);

                            countCar++;

                            speed = GenerateSpeed(GetScore(countCar));
                        }
                    }
                    else if (i >= trackField.TrackHeight - 5 && i < trackField.TrackHeight)
                    {
                        if (i >= trackField.TrackHeight - 10 && leftCarPosition == 0 && MyCar.MyCarPosition == 1)

                        {
                            lock (Drawer.locker)
                            {
                                isShutdown = true;
                                Console.Clear();

                                SendGameOverMessage(GetScore(countCar));
                                Thread.CurrentThread.Abort();
                            }
                        }

                        else if (i >= trackField.TrackHeight - 10 && leftCarPosition == 12 && MyCar.MyCarPosition == 2)
                        {
                            lock (Drawer.locker)
                            {
                                isShutdown = true;
                                Console.Clear();

                                SendGameOverMessage(GetScore(countCar));
                                Thread.CurrentThread.Abort();
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
                Console.SetCursorPosition(gameField.GameWindowWidth - 23, 4);
                Console.WriteLine("GAME OVER");

                Console.SetCursorPosition(gameField.GameWindowWidth - 23, 5);
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
