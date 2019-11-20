using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Controls
    {
        ConsoleKeyInfo keyboard = new ConsoleKeyInfo();

        public void controller()
        {
            while (Console.KeyAvailable)
            {
                keyboard = Console.ReadKey();
                if (keyboard.Key == ConsoleKey.UpArrow && GameLogic.s != "down")
                    GameLogic.s = "up";
                else if (keyboard.Key == ConsoleKey.DownArrow && GameLogic.s != "up")
                    GameLogic.s = "down";
                else if (keyboard.Key == ConsoleKey.LeftArrow && GameLogic.s != "right")
                    GameLogic.s = "left";
                else if (keyboard.Key == ConsoleKey.RightArrow && GameLogic.s != "left")
                    GameLogic.s = "right";
                else if (keyboard.Key == ConsoleKey.P)
                    GameLogic.pause = true;
            }
        }

        
    }
}
