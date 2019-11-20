using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Displays
    {
        public void Wellcome()
        {
            Console.SetCursorPosition(Console.WindowWidth / 2 - 15, Console.WindowHeight / 2 - 3);
            Console.WriteLine("wellcome to amit's snake game!");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 20, Console.WindowHeight / 2 - 2);
            Console.WriteLine("use the arrows key to navigate the snake.");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 18, Console.WindowHeight / 2 - 1);
            Console.WriteLine("press p to pause and unpause the game.");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 26, Console.WindowHeight / 2);
            Console.WriteLine("your goal is to collect as much as fruits as possible.");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 11, Console.WindowHeight / 2 + 1);
            Console.WriteLine("press any key to start.");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 3, Console.WindowHeight / 2 + 2);
            Console.WriteLine("enjoy!");
            Console.ReadKey();
            GameLogic gameLogic = new GameLogic();
            gameLogic.activate();

        }
        public void Render(int height, int width, int HeadX, int HeadY, int FruitX, int FruitY, int score, List<int> TrailX, List<int> TrailY)
        {
            Console.SetCursorPosition(0, 0);
            

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {

                    if (i == 0 || i == height - 1 || j == 0 || j == width - 1)
                    {
                        Console.Write("#");
                    }
                    else if (HeadX == 0 || HeadX >= width - 1 || HeadY == 0 || HeadY == height - 1)
                    {
                        GameLogic gameLogic = new GameLogic();
                        gameLogic.GameOver();
                        return;
                    }
                    else if (j == HeadX && i == HeadY)
                        Console.Write("O");
                    else if (j == FruitX && i == FruitY)
                        Console.Write("F");

                    else
                    {
                        bool isPrinted = false;
                        for (int k = 0; k < TrailX.Count; k++)
                        {
                            if (TrailX[k] == j && TrailY[k] == i)
                            {
                                Console.Write('o');
                                isPrinted = true;
                            }
                        }
                        if (!isPrinted)
                            Console.Write(' ');
                    }

                }
            }
            Console.WriteLine("your score is: " + score + "                ");
        }

    }
}
