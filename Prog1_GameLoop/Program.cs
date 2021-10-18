using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1_GameLoop
{
    class Program
    {
        static bool gameOver;
        static int x = 50;
        static int y = 50;

        static void Main(string[] args)
        {
            while (gameOver == false)
            {
                PlayerUpdate();
                PlayerDraw(x, y);
            }

        }
        
        static void PlayerDraw(int x, int y)
        {
            Console.Write("x");
            Console.SetCursorPosition(x, y);
            Console.Write("X");
        }

        static void PlayerUpdate()
        {
            //char input;
            //ConsoleKeyInfo readKeyInput;
            //readKeyInput = Console.ReadKey(true);
            //input = readKeyInput.KeyChar;
            
            
                Console.ReadKey(true);

                if (Console.ReadKey(true).Key == ConsoleKey.W)
                {
                    y--;
                }
                else if (Console.ReadKey(true).Key == ConsoleKey.S)
                {
                    y++;
                }
                else if (Console.ReadKey(true).Key == ConsoleKey.A)
                {
                    x--;
                }
                else if (Console.ReadKey(true).Key == ConsoleKey.D)
                {
                    x++;
                }
            
        }
    }
}
