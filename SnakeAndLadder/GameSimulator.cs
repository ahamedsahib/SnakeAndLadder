using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    class GameSimulator
    {
        public int position = 0;
        public const int noPlay = 1;
        public const int ladder = 2;
        public const int snake = 3;
        public void Game()
        {
            
            Random random = new Random();
            int rolled_dice = random.Next(1, 7);
            int option = random.Next(1, 4);
            Console.WriteLine($"The Dice rolled as {rolled_dice}");
            if (option == 2)
            {
                Console.WriteLine("Player got Ladder and Climbing up");
                position +=  rolled_dice;
            }
            else if (option == 3)
            {
                Console.WriteLine("Player hit by a snake");
                position -= rolled_dice;
            }
            else
            {
                Console.WriteLine("player had no chance to play ");
            }

            Console.WriteLine($"Player position is {position} ");

        }


    }
}
