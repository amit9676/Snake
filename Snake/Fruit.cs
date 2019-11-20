using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    
    class Fruit
    {
        static Random rand = new Random();



        public static void InitFruit()
        {
            GameLogic.FruitX = rand.Next(1, Console.WindowWidth - 1);
            GameLogic.FruitY = rand.Next(1, Console.WindowHeight - 4);
        }

        public void catchFruit()
        {
            if (GameLogic.HeadX == GameLogic.FruitX && GameLogic.HeadY == GameLogic.FruitY)
            {

                InitFruit();
                for (int i = 0; i < GameLogic.TrailX.Count; i++)
                {
                    if ((GameLogic.FruitX == GameLogic.TrailX[i] && GameLogic.FruitY == GameLogic.TrailY[i]) || (GameLogic.FruitX == GameLogic.HeadX && GameLogic.FruitY == GameLogic.HeadY))
                    {
                        InitFruit();
                    }

                }

                GameLogic.Score += 10;
                if (GameLogic.TrailX.Count == 0)
                {
                    GameLogic.TrailX.Add(GameLogic.HeadX);
                    GameLogic.TrailY.Add(GameLogic.HeadY);
                }
                else if (GameLogic.TrailX.Count > 0)
                {
                    GameLogic.TrailX.Add(GameLogic.TrailX[GameLogic.TrailX.Count - 1]);
                    GameLogic.TrailY.Add(GameLogic.TrailX[GameLogic.TrailX.Count - 1]);
                }
            }
        }
    }
}
