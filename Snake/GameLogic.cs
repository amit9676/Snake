using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class GameLogic
    {
        //GameLogic gameLogic = new GameLogic();
        Controls controls = new Controls();
        Displays display = new Displays();
        Snake snake = new Snake();
        Fruit fruit = new Fruit();


        public static int HeadY;
        public static int HeadX;

        static Random rand = new Random();

        public static int FruitX;
        public static int FruitY;

        public static List<int> TrailX = new List<int>();
        public static List<int> TrailY = new List<int>();

        public static int Score;
        public static string s;

        public static bool pause;
        private bool endMode = false;

        public void activate()
        {
            gameInit();

            while (!endMode)
            {
                Movement();
                controls.controller();
                while (pause)
                {
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 7, (Console.WindowHeight - 1) / 2);
                    Console.Write("game paused");
                    Console.SetCursorPosition(0, Console.WindowHeight - 2);
                    ConsoleKeyInfo keyboard = Console.ReadKey();
                    Console.Write("\r                                                  ");
                    if (keyboard.Key == ConsoleKey.P)
                        pause = false;
                }
                display.Render(Console.WindowHeight - 3, Console.WindowWidth, HeadX, HeadY, FruitX, FruitY, Score, TrailX, TrailY);
                fruit.catchFruit();
                snake.snakeFollow();
                snake.snakeHit();
            }
        }

        private void gameInit()
        {
            Console.CursorVisible = false;
            Score = 0;
            TrailX.Clear();
            TrailY.Clear();
            s = "up";
            pause = false;

            HeadX = Console.WindowWidth / 2;
            HeadY = (Console.WindowHeight - 1) / 2;
            Fruit.InitFruit();
        }

        public void Movement()
        {

            switch (s)
            {
                case "right":
                    HeadX++;

                    break;
                case "left":
                    HeadX--;

                    break;
                case "up":
                    HeadY--;


                    Thread.Sleep(50);
                    break;
                case "down":
                    HeadY++;

                    Thread.Sleep(50);
                    break;
            }
        }
        
        public void GameOver()
        {
            endMode = true;
            Console.SetCursorPosition(0, Console.WindowHeight - 2);
            Console.Write("game over. press any key to restart the game");
            Console.ReadKey();
            Console.Write("\r                                                  ");
            activate();
            endMode = false;
        }
    }
}
