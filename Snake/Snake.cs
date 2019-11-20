using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake
    {
        public void snakeFollow()
        {
            if (GameLogic.TrailX.Count > 0)
            {
                for (int i = GameLogic.TrailX.Count - 1; i >= 1; i--)
                {
                    GameLogic.TrailX[i] = GameLogic.TrailX[i - 1];
                    GameLogic.TrailY[i] = GameLogic.TrailY[i - 1];
                }
                GameLogic.TrailX[0] = GameLogic.HeadX;
                GameLogic.TrailY[0] = GameLogic.HeadY;
            }
        }

        public void snakeHit()
        {
            if (GameLogic.TrailX.Count > 0)
            {
                for (int i = GameLogic.TrailX.Count - 1; i >= 1; i--)
                {
                    if (GameLogic.HeadX == GameLogic.TrailX[i] && GameLogic.HeadY == GameLogic.TrailY[i])
                    {
                        GameLogic gameLogic = new GameLogic();
                        gameLogic.GameOver();
                        return;
                    }
                }
            }
        }
    }
}
