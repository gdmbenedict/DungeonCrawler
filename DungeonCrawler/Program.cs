using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Program
    {
        //player position values
        static int playerY = 0;
        static int playerX = 0;

        //value to track if game is done
        static bool gameOver = false;

        //Main game loop
        static void Main(string[] args)
        {
            // setting the window size 
            Console.SetWindowSize(40, 40);

            // setting buffer size of console 
            Console.SetBufferSize(80, 80);

            //making cursor invisible
            Console.CursorVisible = false;

            while (!gameOver)
            {
                PlayerDraw(playerX, playerY);
                PlayerUpdate();
            }
        }

        //method that draws the player onto the console
        private static void PlayerDraw(int x, int y)
        {
            Console.Clear();
            Console.SetCursorPosition(-x, -y);
            Console.Write("P");
        }

        //method that update's the player's position in console
        private static void PlayerUpdate()
        {
            ConsoleKeyInfo input;
            input = Console.ReadKey();

            //switch statement to update player position
            switch (input.Key)
            {
                case ConsoleKey.W:
                    playerY += 1;
                    break;

                case ConsoleKey.A:
                    playerX += 1;
                    break;

                case ConsoleKey.S:
                    playerY -= 1;
                    break;

                case ConsoleKey.D:
                    playerX -= 1;
                    break;

                case ConsoleKey.Escape:
                    gameOver = true;
                    break;

                default:
                    break;
            }
        }
    }
}
