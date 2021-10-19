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
        static int x = 20;
        static int y = 20;
        static int previous_cursor_x;
        static int previous_cursor_y;

        static void Main(string[] args)
        {
            Console.CursorVisible=false;
            Console.SetWindowSize(40, 40);
            Console.SetBufferSize(80, 80);
            
            while (gameOver == false)
            {
                PlayerUpdate();
                BoundsCheck();
                PlayerDraw(x, y);
            }

        }
        
        static void PlayerDraw(int x, int y)
        {   
            
            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.Write("X");
        }

        static void PlayerUpdate()
        {
            //*CHARS NEED TO HAVE SINGLE QUOTES TO BE REFERENCED*

            //ConsoleKeyInfo readKeyInput;
            //readKeyInput = Console.ReadKey(true);
            //char input = readKeyInput.KeyChar;
            //if (input == 'd')
            //  {
            //      Do Stuff
            //  }

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

        static void BoundsCheck()
        {
            if(x<0)
            {
                x = 0;
            }
            
            if (x>40)
            {
                x = 40;
            }

            if(y<0)
            {
                y = 0;
            }
            
            if(y>40)
            {
                y = 40;
            }
        }

    }
}
